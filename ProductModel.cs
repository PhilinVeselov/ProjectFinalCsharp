using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalCsharp
{
	public class ProductModel
	{
		public string ProductName {  get; set; }
		public int ProductAmount {  get; set; }

		public ProductModel(string productName, int productAmount)
		{
			ProductName = productName;
			ProductAmount = productAmount;
		}
	}
}
