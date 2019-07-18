using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommercialSite.Models.i
{
	public class IndexModel
	{
		public List<DB.Products> Products { get; set; }
		public DB.Categories Category { get; set; }
	}
}