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
using System.Data;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using OfficeOpenXml;
using Microsoft.AspNetCore.Authorization;

namespace GMTVendorEvaluationWebApp.Controllers
{
    [Authorize(Roles = "Administrator")]
    //[Authorize(Roles = "Administrator")]
    public class VendorController : Controller
    {
        private readonly EvaluationContext _context;

        public VendorController(EvaluationContext context)
        {
            _context = context;
        }

        // GET: Vendor
        //public async Task<IActionResult> Index(string searchString, string vendorFilter, int? pageNumber)
        //{
        //    ViewData["VendorFilter"] = searchString;
        //    if (searchString != null)
        //    {
        //        pageNumber = 1;
        //    }
        //    else
        //    {
        //        searchString = vendorFilter;
        //    }
        //    var vendors = from s in _context.Vendors
        //                    select s;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        vendors = vendors.Where(s => s.company_name.Contains(searchString)
        //                               || s.type_of_business.Contains(searchString));
        //    }
        //    int pageSize = 10;
        //    return View(await PaginatedList<Vendor>.CreateAsync(vendors.AsNoTracking(), pageNumber ?? 1, pageSize));
        //}
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vendors.ToListAsync());
        }


        [HttpGet]
        public IActionResult Vendor_Upload(List<Vendor> vendors = null)
        {
            vendors = vendors == null ? new List<Vendor>() : vendors;
            return View();
        }



        public async Task<IActionResult> Vendor_Upload(IFormFile file)
        {
            var vendors = new List<Vendor>();
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowcount = worksheet.Dimension.Rows;
                    for (int row = 2; row <= rowcount; row++)
                    {
                        _context.Vendors.Add(new Vendor
                        {
                            company_name = worksheet.Cells[row, 1].Value.ToString().Trim(),
                            contact_person = worksheet.Cells[row, 2].Value.ToString().Trim(),
                            company_address = worksheet.Cells[row, 3].Value.ToString().Trim(),
                            type_of_business = worksheet.Cells[row, 4].Value.ToString().Trim(),
                            phone_number = worksheet.Cells[row, 5].Value.ToString().Trim(),
                            email = worksheet.Cells[row, 6].Value.ToString().Trim(),
                        });
                        
                        await _context.SaveChangesAsync();
                       

                    }
                    

                }
            }
            return RedirectToAction(nameof(Index));
        }

        
        
        public async Task<IActionResult> Vendor_Performance()
        {
            var vendor_evaluations = new List<VendorEvaluation>();
            var vendors = await _context.Vendors
                .Include(x => x.Products_Services)
                    .ThenInclude(x => x.Evaluations)
                        .ThenInclude(x => x.Criteria)                        
                .AsNoTracking().ToListAsync();

           

            foreach (var item in vendors)
            {
                var vendor_evaluate = new VendorEvaluation();
                vendor_evaluate.CompanyName = item.company_name;
                vendor_evaluate.vendor_id = item.vendorID;
                var criteria = await _context.Criteria.ToListAsync();
                vendor_evaluate.NumberofVendors = vendors.Count();
                vendor_evaluate.NumberOfProducts = _context.Products_Services.Count();
                vendor_evaluate.NumberofDepartments = _context.Departments.Count();
                ViewData["vendor_count"] = vendor_evaluate.NumberofVendors;
                ViewData["product_count"] = vendor_evaluate.NumberOfProducts;
                ViewData["department_count"] = vendor_evaluate.NumberofDepartments;
                var overallvendorscore = 0;
                
                foreach (var product in item.Products_Services)
                {
                    var totalscore = (double)(criteria.Count() * 6);

                    var evaluationscore = product.Evaluations.Select(a => ((int)a.Grade));

                    var evaluationscorecriteria = evaluationscore.Sum();
                    overallvendorscore += evaluationscorecriteria;
                }

                var sytemoverall = (double)(item.Products_Services.Count * 36);
                var vendor_evaluation_score = (double)(overallvendorscore / sytemoverall);
                vendor_evaluate.Percentage =  Math.Round((double)(vendor_evaluation_score * 100));
                if (double.Equals(double.NaN, vendor_evaluate.Percentage))
                    vendor_evaluate.Percentage = 0;
                vendor_evaluate.NumberOfProducts = item.Products_Services.Count;
                vendor_evaluations.Add(vendor_evaluate);
                
                
            }
            
            ViewBag.PER = vendor_evaluations.OrderByDescending(x => x.Percentage).Select(x => x.Percentage).Take(5).ToList();
            ViewBag.VENDORS = vendor_evaluations.OrderByDescending(x => x.Percentage).Select(x => x.CompanyName).Take(5).ToList();
            return View(vendor_evaluations.OrderByDescending(x => x.Percentage));
        }

        //public async Task<IActionResult> Vendor_Check(int? id, int? vendorID)
        //{
        //    var vendor_check = new EvaluationViewModel();
        //    vendor_check.Vendors = await _context.Vendors
        //        .Include(x => x.Products_Services)
        //            .ThenInclude(x => x.Evaluations)
        //                .ThenInclude(x => x.Criteria)
        //        .Include(x => x.Products_Services)
        //            .ThenInclude(x => x.Department)                                    
        //        .AsNoTracking().ToListAsync();

        //    var vendors = await _context.Vendors
        //       .Include(x => x.Products_Services)
        //           .ThenInclude(x => x.Evaluations)
        //               .ThenInclude(x => x.Criteria)
        //       .AsNoTracking().ToListAsync();

        //    var products_services = await _context.Products_Services
        //       .Include(x => x.Vendor)
        //       .Include(x => x.Evaluations)
        //       .Include(x => x.Department)
        //       .OrderByDescending(x => x.departmental_evaluation == false)
        //           .ThenByDescending(p => p.Date_delivered)
        //       .AsNoTracking().ToListAsync();
        //    //var evaluations = new List<EvaluationViewModel>();                           



        //        //vendorID = vendor.vendorID;
        //        if (vendorID != null)
        //        {

        //            vendor_check.Product_Services = vendor_check.Vendors.Where(
        //                x => x.vendorID == vendorID).Single().Products_Services;
        //            foreach (var vendor in vendors)
        //            {
        //                foreach (var item in products_services)
        //                {
        //                    var evaluations = new List<EvaluationViewModel>();
        //                    var evaluation = new EvaluationViewModel();
        //                    evaluation.ProductName = item.product_name;
        //                    evaluation.Evaluated = item.Evaluated;
        //                    evaluation.departmental_evaluation = item.departmental_evaluation;
        //                    evaluation.CompanyName = item.Vendor.company_name;
        //                    evaluation.DepartmentName = item.Department.department_name;
        //                    evaluation.Date_Delivered = item.Date_delivered;
        //                    evaluation.product_id = item.product_serviceID;
        //                    evaluation.vendorId = item.vendorID;
        //                    var criteria = await _context.Criteria.ToListAsync();

        //                    var totalscore = (double)(criteria.Count() * 6);
        //                    var evaluationscore = item.Evaluations.Select(a => ((int)a.Grade));

        //                    var evaluationscorecriteria = evaluationscore.Sum();
        //                    evaluation.Score = evaluationscorecriteria;
        //                    var total_evaluation_score = (double)(evaluationscorecriteria / totalscore);
        //                    evaluation.Percentage = Math.Round((double)(total_evaluation_score * 100));
        //                    evaluations.Add(evaluation);
        //                    ViewData["Score"] = evaluation.Score;


        //                }

        //        }

        //    }



        //        ViewData["vendorID"] = vendorID.Value;

        //        //ViewData["venID"] = new SelectList(_context.Vendors, "vendorID", "vendorID");
        //    return View(vendor_check);
        //}

        public async Task<IActionResult> Vendor_Check(int? id, int? vendorID)
        {
            var vendor_check = new VendorEvaluation();
            vendor_check.Vendors = await _context.Vendors
                .Include(x => x.Products_Services)
                    .ThenInclude(x => x.Evaluations)
                .Include(x => x.Products_Services)
                    .ThenInclude(x => x.Department)

                .AsNoTracking().ToListAsync();
            foreach (var item in vendor_check.Vendors)
            {
                var vendor_evaluate = new VendorEvaluation();
                vendor_evaluate.CompanyName = item.company_name;
            }
            if (vendorID != null)
            {
                ViewData["vendorID"] = vendorID.Value;
                ViewData["venID"] = new SelectList(_context.Vendors, "vendorID", "vendorID");

                vendor_check.Product_Services = vendor_check.Vendors.Where(
                    x => x.vendorID == vendorID).Single().Products_Services;
            }

            return View(vendor_check);
        }

        // GET: Vendor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors
                .FirstOrDefaultAsync(m => m.vendorID == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // GET: Vendor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("vendorID,company_name,contact_person,company_address,type_of_business,phone_number,email")] Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendor);
        }

        // GET: Vendor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }
            return View(vendor);
        }

        // POST: Vendor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("vendorID,company_name,contact_person,company_address,type_of_business,phone_number,email")] Vendor vendor)
        {
            if (id != vendor.vendorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendorExists(vendor.vendorID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vendor);
        }

        // GET: Vendor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendors
                .FirstOrDefaultAsync(m => m.vendorID == id);
            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // POST: Vendor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendor = await _context.Vendors.FindAsync(id);
            _context.Vendors.Remove(vendor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendorExists(int id)
        {
            return _context.Vendors.Any(e => e.vendorID == id);
        }
    }
}
