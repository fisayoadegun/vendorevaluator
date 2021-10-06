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

namespace GMTVendorEvaluationWebApp.Controllers
{
    public class VendorController : Controller
    {
        private readonly EvaluationContext _context;

        public VendorController(EvaluationContext context)
        {
            _context = context;
        }

        // GET: Vendor
        public async Task<IActionResult> Index(string searchString, string vendorFilter, int? pageNumber)
        {
            ViewData["VendorFilter"] = searchString;
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = vendorFilter;
            }
            var vendors = from s in _context.Vendors
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                vendors = vendors.Where(s => s.company_name.Contains(searchString)
                                       || s.type_of_business.Contains(searchString));
            }
            int pageSize = 10;
            return View(await PaginatedList<Vendor>.CreateAsync(vendors.AsNoTracking(), pageNumber ?? 1, pageSize));
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
            ViewBag.PER = vendor_evaluations.Select(x => x.Percentage);
            ViewBag.VENDORS = vendors.Select(x => x.company_name);
            return View(vendor_evaluations.OrderByDescending(x => x.Percentage));
        }

        public async Task<IActionResult> Vendor_Check(int? id, int? vendorID)
        {
            var vendor_check = new VendorEvaluation();
            vendor_check.Vendors = await _context.Vendors
                .Include(x => x.Products_Services)
                    .ThenInclude(x => x.Evaluations)
                .Include(x => x.Products_Services)
                    .ThenInclude(x => x.Department)
                    
                .AsNoTracking().ToListAsync();
            foreach(var item in vendor_check.Vendors)
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
