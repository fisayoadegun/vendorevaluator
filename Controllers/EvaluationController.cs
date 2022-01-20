using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GMTVendorEvaluationWebApp.Data;
using GMTVendorEvaluationWebApp.Models;
using GMTVendorEvaluationWebApp.ViewModels;
using GMTVendorEvaluationWebApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MailKit.Net.Smtp;
using MimeKit;
using System.IO;

namespace GMTVendorEvaluationWebApp.Controllers
{
	//[Authorize(Roles = "Administrator")]
	public class EvaluationController : Controller
	{
		private readonly IEvaluationServiceInterface _evaluationService;
		private readonly EvaluationContext _context;

		public EvaluationController(EvaluationContext context, IEvaluationServiceInterface evaluationService)
		{
			_context = context;
			_evaluationService = evaluationService;
		}

		// GET: Evaluation
		[Authorize(Roles = "Administrator")]
		public async Task<IActionResult> Index()
		{
			var evaluations = _context.Evaluations
			.Include(c => c.Product_Service).Include(p => p.Criteria)
			.AsNoTracking();
			return View(await evaluations.ToListAsync());
		}

		// GET: Evaluation/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var evaluation = await _context.Evaluations
				.Include(e => e.Criteria)
				.Include(e => e.Product_Service)
				.AsNoTracking()
				.FirstOrDefaultAsync(m => m.evaluationID == id);
			if (evaluation == null)
			{
				return NotFound();
			}

			return View(evaluation);
		}

		[Authorize(Roles = "Administrator")]
		public async Task<IActionResult> Create(int? id)
		{
			var product = await this._context.Products_Services.FindAsync(id);
			ViewData["product"] = product;
			ViewData["vendor"] = await this._context.Vendors.FindAsync(product.vendorID);
			ViewData["productid"] = id;
			var eva = await _context.Evaluations.ToListAsync();

			return View();
		}

		// POST: Evaluation/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[Authorize(Roles = "Administrator")]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(CriteriaOptions evaluation)
		{
			var product = await this._context.Products_Services.FindAsync(evaluation.productId);
			product.Evaluated = true;
			foreach (var item in _context.Criteria.ToList())
			{
				if (item.criteria_name == "Competitiveness of Costing")
				{
					if (!string.IsNullOrEmpty(evaluation.competitiveness_of_costing))
					{
						var evaluate = new Evaluation
						{
							criteriaID = item.criteriaID,
							product_serviceID = evaluation.productId,
							Grade = (Grade)int.Parse(evaluation.competitiveness_of_costing)
						};

						_context.Add(evaluate);
					}
				}
				else if (item.criteria_name == "Statutory permits and rules")
				{
					if (!string.IsNullOrEmpty(evaluation.staturory_permits))
					{
						var evaluate = new Evaluation
						{
							criteriaID = item.criteriaID,
							product_serviceID = evaluation.productId,
							Grade = (Grade)int.Parse(evaluation.staturory_permits)
						};

						_context.Add(evaluate);
					}
				}
			}

			_context.Products_Services.Update(product);
			await _context.SaveChangesAsync();
			return RedirectToAction(actionName: nameof(Index), controllerName: "Product_Service");
		}

		// GET: Evaluation/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			//var url = this.Url.Action("Edit", "Evaluation", null);
			//var url = Url.Action("Edit", "Evaluation", HttpContext.Request.Url.Scheme, HttpContext.Request.Url.Authority);
			string url = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + Url.Action("Edit", "Evaluation");

			var product = await this._context.Products_Services.FindAsync(id);
			ViewData["product"] = product;
			ViewData["vendor"] = await this._context.Vendors.FindAsync(product.vendorID);

			ViewData["productid"] = id;
			ViewData["url"] = url;
			var eva = await _context.Evaluations.ToListAsync();
			if (product == null)

			{
				return NotFound();
			}
			PopulateProductsDropDownList();
			PopulateCriteriaDropDownList();
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> Email(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var product = await this._context.Products_Services.FindAsync(id);
			string url = HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + Url.Action("Edit", "Evaluation") + "/" + product.product_serviceID;
			var productname = product.product_name;
			ViewData["product"] = product;
			ViewData["department"] = await this._context.Departments.FindAsync(product.departmentID);
			var departmentinfo = ViewData["department"] as Department;

			//ViewData["url"] = url;

			//var message = new MimeMessage();
			//message.From.Add(new MailboxAddress("GMT Vendor Evaluation", "Auto.Mail@gmt-limited.com"));
			//message.To.Add(new MailboxAddress(departmentinfo.email));
			//message.Subject = "GMT Vendor Evaluation Evaluation";
			//message.Body = new BodyBuilder { HtmlBody = string.Format("<h3 style='color:black;'>Click on the link below to Evaluate this Product/Service({0}) delivered to your Department <hr /> {1}</h3>", productname, url) }.ToMessageBody();

			//using (var client = new SmtpClient())
			//{
			//    client.Connect("smtp.office365.com", 587, false);
			//    client.Authenticate("Auto.Mail@gmt-limited.com", "Hav!34iT");

			//    client.Send(message);
			//    client.Disconnect(true);
			//}

			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("GMT Vendor Evaluation", "fisayo.adegun@gmt-limited.com"));
			message.To.Add(new MailboxAddress(departmentinfo.email));
			message.Subject = "GMT Vendor Evaluation Evaluation";
			message.Body = new BodyBuilder { HtmlBody = string.Format("<h3 style='color:black;'>Click on the link below to Evaluate this Product/Service({0}) delivered to your Department <hr /> {1}</h3>", productname, url) }.ToMessageBody();

			using (var client = new SmtpClient())
			{
				client.Connect("smtp.office365.com", 587, false);
				client.Authenticate("fisayo.adegun@gmt-limited.com", "Surulere007");

				client.Send(message);
				client.Disconnect(true);
			}
			return View();
		}

		// POST: Evaluation/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost, ActionName("Edit")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> EditPost(int? id, CriteriaOptions evaluation)
		{
			if (id == null)
			{
				return NotFound();
			}
			var product = await this._context.Products_Services.FindAsync(evaluation.productId);
			product.departmental_evaluation = true;

			var evaluationToUpdate = await _context.Evaluations
				.FirstOrDefaultAsync(c => c.product_serviceID == id);

			//var check_evaluate =  _context.Criteria.ToList();

			if (evaluationToUpdate.departmental_evaluation == true)
			{
				return RedirectToAction(nameof(Evaluation_Carried_Out));
			}

			foreach (var item in _context.Criteria.ToList())
			{
				if (item.criteria_name == "Timeliness")
				{
					if (!string.IsNullOrEmpty(evaluation.timeliness))
					{
						var evaluate = new Evaluation
						{
							criteriaID = item.criteriaID,
							product_serviceID = evaluation.productId,
							Grade = (Grade)int.Parse(evaluation.timeliness)
						};
						_context.Update(evaluate);
					}
				}
				else if (item.criteria_name == "Quality of service")
				{
					if (!string.IsNullOrEmpty(evaluation.quality_of_products))
					{
						var evaluate = new Evaluation
						{
							criteriaID = item.criteriaID,
							product_serviceID = evaluation.productId,
							Grade = (Grade)int.Parse(evaluation.quality_of_products)
						};
						_context.Update(evaluate);
					}
					else
					{
						return RedirectToAction(nameof(Evaluation_Carried_Out));
					}
				}
				else if (item.criteria_name == "Presentation")
				{
					if (!string.IsNullOrEmpty(evaluation.presentation))
					{
						var evaluate = new Evaluation
						{
							criteriaID = item.criteriaID,
							product_serviceID = evaluation.productId,
							Grade = (Grade)int.Parse(evaluation.presentation)
						};

						_context.Update(evaluate);
					}
				}
				else if (item.criteria_name == "After Sales/Support")
				{
					if (!string.IsNullOrEmpty(evaluation.after_sales_support))
					{
						var evaluate = new Evaluation
						{
							criteriaID = item.criteriaID,
							product_serviceID = evaluation.productId,
							Grade = (Grade)int.Parse(evaluation.after_sales_support)
						};

						_context.Update(evaluate);
					}
				}
			}

			if (await TryUpdateModelAsync<Evaluation>(evaluationToUpdate,
				""))
			{
				evaluationToUpdate.departmental_evaluation = true;
				try
				{
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateException /* ex */)
				{
					//Log the error (uncomment ex variable name and write a log.)
					ModelState.AddModelError("", "Unable to save changes. " +
						"Try again, and if the problem persists, " +
						"see your system administrator.");
				}
				return RedirectToAction(nameof(Evaluation_Completed));
				//return RedirectToAction(actionName: nameof(Index), controllerName: "Product_Service");
			}

			//PopulateProductsDropDownList(evaluationToUpdate.product_serviceID);
			//PopulateCriteriaDropDownList(evaluationToUpdate.criteriaID);
			return View(evaluation);
		}

		public ActionResult Evaluation_Completed()
		{
			return View();
		}

		public ActionResult Evaluation_Carried_Out()
		{
			return View();
		}

		private void PopulateProductsDropDownList(object selectedProduct = null)
		{
			var productsQuery = from d in _context.Products_Services
								orderby d.product_name
								select d;
			ViewBag.product_serviceID = new SelectList(productsQuery.AsNoTracking(), "product_serviceID", "product_name", selectedProduct);
		}

		private void PopulateCriteriaDropDownList(object selectedCriteria = null)
		{
			var criteriaQuery = from d in _context.Criteria
								orderby d.criteria_name
								select d;
			ViewBag.criteriaID = new SelectList(criteriaQuery.AsNoTracking(), "criteriaID", "criteria_name", selectedCriteria);
		}

		[Authorize(Roles = "Administrator")]
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var evaluation = await _context.Evaluations
				.Include(e => e.Criteria)
				.Include(e => e.Product_Service)
				.AsNoTracking()
				.FirstOrDefaultAsync(m => m.evaluationID == id);
			if (evaluation == null)
			{
				return NotFound();
			}

			return View(evaluation);
		}

		[Authorize(Roles = "Administrator")]
		// POST: Evaluation/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var evaluation = await _context.Evaluations.FindAsync(id);
			_context.Evaluations.Remove(evaluation);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool EvaluationExists(int id)
		{
			return _context.Evaluations.Any(e => e.evaluationID == id);
		}
	}
}