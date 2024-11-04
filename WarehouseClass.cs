using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalCsharp
{
	public class WarehouseClass
	{
		public Dictionary<string, ProductModel> WarehouseProductList;

		public Dictionary<string, ProductModel> WarehouseProductListCache;

		public WarehouseClass()
		{
			WarehouseProductList = new Dictionary<string, ProductModel>();
			WarehouseProductListCache = new Dictionary<string, ProductModel>();

		}

		public void AddProduct(string productName, int productAmount)
		{
			if (!WarehouseProductList.ContainsKey(productName))
			{
				WarehouseProductList[productName] = new ProductModel(productName, productAmount);
			}
		}

		public async Task UpdateProductQuantityAsync(string productName, int newProductAmount)
		{
			if (WarehouseProductList.TryGetValue(productName, out var productModel))
			{
				productModel.ProductAmount = newProductAmount;
				WarehouseProductListCache[productName] = productModel;
				await Task.Delay(5);
			}
		}

		public ProductModel SearchProduct(string productName)
		{
			if (WarehouseProductListCache.TryGetValue(productName, out var cacheProductModel))
			{
				return cacheProductModel;
			}
			if (WarehouseProductList.TryGetValue(productName, out var productModel))
			{
				WarehouseProductListCache[productName] = productModel;
				return productModel;
			}
			return null;
		}
	}
}
