using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GMTVendorEvaluationWebApp.Models
{
	public enum Grade
	{
		[Display(Name = "Very Dissatisfied")]
		Very_Dissatisfied = 1,

		Dissatisfied,

		[Display(Name = "Somewhat Dissatisfied")]
		Somewhat_Dissatisfied,

		[Display(Name = "Somewhat Satisfied")]
		Somewhat_Satisfied,

		Satisfied,

		[Display(Name = "Very Satisfied")]
		Very_Satisfied,
	}

	public class Evaluation
	{
		public int evaluationID { get; set; }

		[Display(Name = "Product/Service")]
		public int product_serviceID { get; set; }

		[Display(Name = "Criteria")]
		public int criteriaID { get; set; }

		public bool departmental_evaluation { get; set; }

		public Grade? Grade { get; set; }

		[Display(Name = "Product/Service")]
		public virtual Product_Service Product_Service { get; set; }

		public virtual Criteria Criteria { get; set; }
	}
}