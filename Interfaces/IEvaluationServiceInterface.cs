using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMTVendorEvaluationWebApp.Models

namespace GMTVendorEvaluationWebApp.Interfaces
{
    public interface IEvaluationServiceInterface
    {
        IEnumerable<Evaluation> GetAll();

        Evaluation GetEvaluationByProduct(int product_serviceID);
    }
}
