using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GMTVendorEvaluationWebApp.Models
{
    public class Criteria
    {
        public int criteriaID { get; set; }

        [Display(Name = "Criteria")]
        public string criteria_name { get; set; }

        public virtual IList<Evaluation> Evaluations { get; set; }

        public int GetCriteriaCount()
        {
            return criteria_name == null ? 0 : criteria_name.Count();
        }

    }
}
