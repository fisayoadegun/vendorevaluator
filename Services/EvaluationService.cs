using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GMTVendorEvaluationWebApp.Models;
using GMTVendorEvaluationWebApp.Interfaces;
using GMTVendorEvaluationWebApp.Data;

namespace GMTVendorEvaluationWebApp.Services
{
    public class EvaluationService : IEvaluationServiceInterface
    {

        private readonly EvaluationContext _context;
        public EvaluationService(EvaluationContext context)
        {
            this._context = context;
        }

        //public IEnumerable<Evaluation> GetAll()
        //{
        //    return _context.Evaluations.
        //        Include(x => x.Product_Service).
        //        Include(x => x.Criteria).
        //        Include(x => x.Grade).AsQueryable();
            
        //}

        //public Evaluation GetEvaluationByProduct(int id)
        //{
            
        //    //var data = this.GetAll();
        //    //decimal totalenum = data.(Enum.GetValues(typeof(Grade)).Cast<byte>().Sum(x => x));
        //    //return _context.Evaluations.FirstOrDefault(c => c.product_serviceID == id);
        //}
    }
}
