using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GMTVendorEvaluationWebApp.Data;
using GMTVendorEvaluationWebApp.Models;

namespace GMTVendorEvaluationWebApp.Controllers
{
    public class Product_ServiceController : Controller
    {
        private readonly EvaluationContext _context;
        

        public Product_ServiceController(EvaluationContext context)
        {
            _context = context;
        }

        // GET: Product_Service
        public async Task<IActionResult> Index(string searchString, string productFilter)
        {
            var products_services = await _context.Products_Services
                .Include(x => x.Vendor)
                .Include(x => x.Evaluations)
                .Include(x => x.Department)
                .AsNoTracking().ToListAsync();
            ViewData["VendorFilter"] = searchString;
            var products = from s in _context.Products_Services
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.product_name.Contains(searchString)
                                       || s.Vendor.company_name.Contains(searchString));

                return View(await products.AsNoTracking().ToListAsync());
            }

            var evaluations = new List<EvaluationViewModel>();
            foreach (var item in products_services)
            {
                var evaluation = new EvaluationViewModel();
                evaluation.ProductName = item.product_name;
                evaluation.Evaluated = item.Evaluated;
                evaluation.departmental_evaluation = item.departmental_evaluation;
                evaluation.CompanyName = item.Vendor.company_name;
                evaluation.DepartmentName = item.Department.department_name;
                evaluation.Date_Delivered = item.Date_delivered;
                evaluation.product_id = item.product_serviceID;

                var criteria = await _context.Criteria.ToListAsync();

                var totalscore = (double)(criteria.Count() * 6);

                var evaluationscore = item.Evaluations.Select(a => ((int)a.Grade));

                var evaluationscorecriteria = evaluationscore.Sum();
                evaluation.Score = evaluationscorecriteria;
                var total_evaluation_score = (double)(evaluationscorecriteria / totalscore);
                evaluation.Percentage = Math.Round((double)(total_evaluation_score * 100));

                evaluations.Add(evaluation);
            }
            return View(evaluations);
            
        }

        // GET: Product_Service/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_service = await _context.Products_Services
                .Include(p => p.Vendor).Include(c => c.Department).Include(s => s.Evaluations)
                    .ThenInclude(e => e.Criteria).AsNoTracking()

                .FirstOrDefaultAsync(m => m.product_serviceID == id);

            if (product_service == null)
            {
                return NotFound();
            }

            return View(product_service);
        }

        // GET: Product_Service/Create
        public IActionResult Create()
        {
            PopulateDepartmentsDropDownList();
            PopulateVendorDropDownList();
            //ViewData["departmentID"] = new SelectList(_context.Departments, "departmentID", "departmentID");
            //ViewData["vendorID"] = new SelectList(_context.Vendors, "vendorID", "vendorID");
            return View();
        }

        // POST: Product_Service/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("product_serviceID,vendorID,departmentID,product_name,Date_delivered")] Product_Service product_Service)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product_Service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateDepartmentsDropDownList();
            PopulateVendorDropDownList();
            //ViewData["departmentID"] = new SelectList(_context.Departments, "departmentID", "departmentID", product_Service.departmentID);
            //ViewData["vendorID"] = new SelectList(_context.Vendors, "vendorID", "vendorID", product_Service.vendorID);
            return View(product_Service);
        }

        // GET: Product_Service/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Service = await _context.Products_Services
                .AsNoTracking().
                FirstOrDefaultAsync(m => m.product_serviceID == id);
            if (product_Service == null)
            {
                return NotFound();
            }
            PopulateDepartmentsDropDownList(product_Service.departmentID);
            PopulateVendorDropDownList(product_Service.vendorID);
            //ViewData["departmentID"] = new SelectList(_context.Departments, "departmentID", "departmentID", product_Service.departmentID);
            //ViewData["vendorID"] = new SelectList(_context.Vendors, "vendorID", "vendorID", product_Service.vendorID);
            return View(product_Service);
        }

        // POST: Product_Service/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id, [Bind("product_serviceID,vendorID,departmentID,product_name,Date_delivered")] Product_Service product_Service)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productToUpdate = await _context.Products_Services
                .FirstOrDefaultAsync(c => c.product_serviceID == id);

            if (await TryUpdateModelAsync<Product_Service>(productToUpdate,
                "",
                c => c.departmentID, c => c.vendorID, c => c.product_name, c => c.Date_delivered))
            {
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
                return RedirectToAction(nameof(Index));
            }
            PopulateDepartmentsDropDownList(productToUpdate.departmentID);
            PopulateVendorDropDownList(productToUpdate.vendorID);
            return View(productToUpdate);
        }

        private void PopulateDepartmentsDropDownList(object selectedDepartment = null)
        {
            var departmentsQuery = from d in _context.Departments
                                   orderby d.department_name
                                   select d;
            ViewBag.departmentID = new SelectList(departmentsQuery.AsNoTracking(), "departmentID", "department_name", selectedDepartment);
        }

        private void PopulateVendorDropDownList(object selectedVendor = null)
        {
            var vendorsQuery = from d in _context.Vendors
                                   orderby d.company_name
                                   select d;
            ViewBag.vendorID = new SelectList(vendorsQuery.AsNoTracking(), "vendorID", "company_name", selectedVendor);
        }
        // GET: Product_Service/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product_Service = await _context.Products_Services
                .Include(p => p.Department)
                .Include(p => p.Vendor)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.product_serviceID == id);
            if (product_Service == null)
            {
                return NotFound();
            }

            return View(product_Service);
        }

        // POST: Product_Service/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product_Service = await _context.Products_Services.FindAsync(id);
            _context.Products_Services.Remove(product_Service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Product_ServiceExists(int id)
        {
            return _context.Products_Services.Any(e => e.product_serviceID == id);
        }
    }
}
