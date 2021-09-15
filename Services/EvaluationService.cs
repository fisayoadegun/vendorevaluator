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
            _context = context;
        }

        public IQueryable<Evaluation> GetAll()
        {
            return _context.Evaluations.
                Include(x => x.Product_Service).
                Include(x => x.Criteria).
                Include(x => x.Grade).AsQueryable();
        }
    }
}
