namespace ProjectFinalCsharp
{
	public partial class Form1 : Form
	{
		public WarehouseClass warehouseClass;

		public Form1()
		{
			InitializeComponent();
			warehouseClass = new WarehouseClass();
			this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);

		}

		private void ButtonAddProduct_Click(object sender, EventArgs e)
		{
			string productName = ProductNameTextboxAP.Text;
			int productAmount = int.Parse(ProductAmountTextboxAP.Text);

			warehouseClass.AddProduct(productName, productAmount);

			UpdateProductList();
		}

		private void ButtonAddPanel_Click(object sender, EventArgs e)
		{
			PanelSearchProduct.Visible = false;
			PanelRefreshProduct.Visible = false;
			PanelAddProduct.Visible = true;
			ProductList.Visible = false;

		}

		private void ButtonRefreshPanel_Click(object sender, EventArgs e)
		{
			PanelSearchProduct.Visible = false;
			PanelRefreshProduct.Visible = true;
			PanelAddProduct.Visible = false;
			ProductList.Visible = true;

			ProductList.Items.Clear();
			foreach (var product in warehouseClass.WarehouseProductList)
			{
				ProductList.Items.Add($"{product.Key}: {product.Value.ProductAmount}");
			}
		}

		private void ButtonSearchPanel_Click(object sender, EventArgs e)
		{
			PanelSearchProduct.Visible = true;
			PanelRefreshProduct.Visible = false;
			PanelAddProduct.Visible = false;
			ProductList.Visible = true;

			ProductList.Items.Clear();
			foreach (var product in warehouseClass.WarehouseProductList)
			{
				ProductList.Items.Add($"{product.Key}: {product.Value.ProductAmount}");
			}
		}

		private void ButtonSearchProduct_Click(object sender, EventArgs e)
		{
			ProductList.Items.Clear();
			foreach (var product in warehouseClass.WarehouseProductList)
			{
				ProductList.Items.Add($"{product.Key}: {product.Value.ProductAmount}");
			}
		}

		private async void ButtonRefreshProduct_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(ProductAmountTextboxRP.Text))
			{
				string productName = ProductNameTextboxRP.Text;
				int newAmount = int.Parse(ProductAmountTextboxRP.Text);

				await warehouseClass.UpdateProductQuantityAsync(productName, newAmount);

			}

			UpdateProductList();
		}

		private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selectedProduct = ProductList.SelectedItem?.ToString();
			if (selectedProduct != null)
			{
				string productName = selectedProduct.Split(':')[0].Trim();
				ProductNameTextboxRP.Text = productName;
			}
		}

		private void UpdateProductList()
		{
			ProductList.Items.Clear();
			foreach (var product in warehouseClass.WarehouseProductList)
			{
				ProductList.Items.Add($"{product.Key}: {product.Value.ProductAmount}");
			}
		}
	}
}
