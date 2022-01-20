using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMTVendorEvaluationWebApp.ViewModels
{
	public class CriteriaOptions
	{
		public int productId { get; set; }

		public string timeliness { get; set; }

		public string quality_of_products { get; set; }
		public string competitiveness_of_costing { get; set; }

		public string presentation { get; set; }
		public string after_sales_support { get; set; }

		public string staturory_permits { get; set; }

		public bool departmental_evaluation { get; set; }
	}
}