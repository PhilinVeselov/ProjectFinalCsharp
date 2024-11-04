namespace ProjectFinalCsharp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ButtonAddPanel = new Button();
			ButtonRefreshPanel = new Button();
			ButtonSearchPanel = new Button();
			PanelAddProduct = new Panel();
			ProductAmountAP = new Label();
			ProductNameAP = new Label();
			ProductAmountTextboxAP = new TextBox();
			ProductNameTextboxAP = new TextBox();
			ButtonAddProduct = new Button();
			ProductList = new ListBox();
			PanelRefreshProduct = new Panel();
			ProductAmountRP = new Label();
			ProductNameRP = new Label();
			ProductAmountTextboxRP = new TextBox();
			ProductNameTextboxRP = new TextBox();
			ButtonRefreshProduct = new Button();
			PanelSearchProduct = new Panel();
			ProductNameSP = new Label();
			ProductNameTextboxSP = new TextBox();
			ButtonSearchProduct = new Button();
			PanelAddProduct.SuspendLayout();
			PanelRefreshProduct.SuspendLayout();
			PanelSearchProduct.SuspendLayout();
			SuspendLayout();
			// 
			// ButtonAddPanel
			// 
			ButtonAddPanel.Location = new Point(33, 41);
			ButtonAddPanel.Name = "ButtonAddPanel";
			ButtonAddPanel.Size = new Size(128, 40);
			ButtonAddPanel.TabIndex = 0;
			ButtonAddPanel.Text = "Add Product";
			ButtonAddPanel.UseVisualStyleBackColor = true;
			ButtonAddPanel.Click += ButtonAddPanel_Click;
			// 
			// ButtonRefreshPanel
			// 
			ButtonRefreshPanel.Location = new Point(33, 99);
			ButtonRefreshPanel.Name = "ButtonRefreshPanel";
			ButtonRefreshPanel.Size = new Size(128, 40);
			ButtonRefreshPanel.TabIndex = 1;
			ButtonRefreshPanel.Text = "Refresh Product";
			ButtonRefreshPanel.UseVisualStyleBackColor = true;
			ButtonRefreshPanel.Click += ButtonRefreshPanel_Click;
			// 
			// ButtonSearchPanel
			// 
			ButtonSearchPanel.Location = new Point(33, 156);
			ButtonSearchPanel.Name = "ButtonSearchPanel";
			ButtonSearchPanel.Size = new Size(128, 40);
			ButtonSearchPanel.TabIndex = 2;
			ButtonSearchPanel.Text = "Search Product";
			ButtonSearchPanel.UseVisualStyleBackColor = true;
			ButtonSearchPanel.Click += ButtonSearchPanel_Click;
			// 
			// PanelAddProduct
			// 
			PanelAddProduct.Controls.Add(ProductAmountAP);
			PanelAddProduct.Controls.Add(ProductNameAP);
			PanelAddProduct.Controls.Add(ProductAmountTextboxAP);
			PanelAddProduct.Controls.Add(ProductNameTextboxAP);
			PanelAddProduct.Controls.Add(ButtonAddProduct);
			PanelAddProduct.Location = new Point(187, 12);
			PanelAddProduct.Name = "PanelAddProduct";
			PanelAddProduct.Size = new Size(272, 286);
			PanelAddProduct.TabIndex = 3;
			// 
			// ProductAmountAP
			// 
			ProductAmountAP.AutoSize = true;
			ProductAmountAP.Location = new Point(138, 42);
			ProductAmountAP.Name = "ProductAmountAP";
			ProductAmountAP.Size = new Size(96, 15);
			ProductAmountAP.TabIndex = 5;
			ProductAmountAP.Text = "Product Amount";
			// 
			// ProductNameAP
			// 
			ProductNameAP.AutoSize = true;
			ProductNameAP.Location = new Point(32, 42);
			ProductNameAP.Name = "ProductNameAP";
			ProductNameAP.Size = new Size(84, 15);
			ProductNameAP.TabIndex = 4;
			ProductNameAP.Text = "Product Name";
			// 
			// ProductAmountTextboxAP
			// 
			ProductAmountTextboxAP.Location = new Point(138, 60);
			ProductAmountTextboxAP.Name = "ProductAmountTextboxAP";
			ProductAmountTextboxAP.Size = new Size(100, 23);
			ProductAmountTextboxAP.TabIndex = 3;
			// 
			// ProductNameTextboxAP
			// 
			ProductNameTextboxAP.Location = new Point(32, 60);
			ProductNameTextboxAP.Name = "ProductNameTextboxAP";
			ProductNameTextboxAP.Size = new Size(100, 23);
			ProductNameTextboxAP.TabIndex = 1;
			// 
			// ButtonAddProduct
			// 
			ButtonAddProduct.Location = new Point(32, 119);
			ButtonAddProduct.Name = "ButtonAddProduct";
			ButtonAddProduct.Size = new Size(206, 23);
			ButtonAddProduct.TabIndex = 0;
			ButtonAddProduct.Text = "Add Product";
			ButtonAddProduct.UseVisualStyleBackColor = true;
			ButtonAddProduct.Click += ButtonAddProduct_Click;
			// 
			// ProductList
			// 
			ProductList.FormattingEnabled = true;
			ProductList.ItemHeight = 15;
			ProductList.Location = new Point(487, 12);
			ProductList.Name = "ProductList";
			ProductList.Size = new Size(301, 289);
			ProductList.TabIndex = 2;
			ProductList.Visible = false;
			// 
			// PanelRefreshProduct
			// 
			PanelRefreshProduct.Controls.Add(ProductAmountRP);
			PanelRefreshProduct.Controls.Add(ProductNameRP);
			PanelRefreshProduct.Controls.Add(ProductAmountTextboxRP);
			PanelRefreshProduct.Controls.Add(ProductNameTextboxRP);
			PanelRefreshProduct.Controls.Add(ButtonRefreshProduct);
			PanelRefreshProduct.Location = new Point(184, 15);
			PanelRefreshProduct.Name = "PanelRefreshProduct";
			PanelRefreshProduct.Size = new Size(272, 286);
			PanelRefreshProduct.TabIndex = 6;
			PanelRefreshProduct.Visible = false;
			// 
			// ProductAmountRP
			// 
			ProductAmountRP.AutoSize = true;
			ProductAmountRP.Location = new Point(138, 42);
			ProductAmountRP.Name = "ProductAmountRP";
			ProductAmountRP.Size = new Size(96, 15);
			ProductAmountRP.TabIndex = 5;
			ProductAmountRP.Text = "Product Amount";
			// 
			// ProductNameRP
			// 
			ProductNameRP.AutoSize = true;
			ProductNameRP.Location = new Point(32, 42);
			ProductNameRP.Name = "ProductNameRP";
			ProductNameRP.Size = new Size(84, 15);
			ProductNameRP.TabIndex = 4;
			ProductNameRP.Text = "Product Name";
			// 
			// ProductAmountTextboxRP
			// 
			ProductAmountTextboxRP.Location = new Point(138, 60);
			ProductAmountTextboxRP.Name = "ProductAmountTextboxRP";
			ProductAmountTextboxRP.Size = new Size(100, 23);
			ProductAmountTextboxRP.TabIndex = 3;
			// 
			// ProductNameTextboxRP
			// 
			ProductNameTextboxRP.Location = new Point(32, 60);
			ProductNameTextboxRP.Name = "ProductNameTextboxRP";
			ProductNameTextboxRP.Size = new Size(100, 23);
			ProductNameTextboxRP.TabIndex = 1;
			// 
			// ButtonRefreshProduct
			// 
			ButtonRefreshProduct.Location = new Point(32, 119);
			ButtonRefreshProduct.Name = "ButtonRefreshProduct";
			ButtonRefreshProduct.Size = new Size(206, 23);
			ButtonRefreshProduct.TabIndex = 0;
			ButtonRefreshProduct.Text = "Refresh Product";
			ButtonRefreshProduct.UseVisualStyleBackColor = true;
			ButtonRefreshProduct.Click += ButtonRefreshProduct_Click;
			// 
			// PanelSearchProduct
			// 
			PanelSearchProduct.Controls.Add(ProductNameSP);
			PanelSearchProduct.Controls.Add(ProductNameTextboxSP);
			PanelSearchProduct.Controls.Add(ButtonSearchProduct);
			PanelSearchProduct.Location = new Point(181, 18);
			PanelSearchProduct.Name = "PanelSearchProduct";
			PanelSearchProduct.Size = new Size(272, 286);
			PanelSearchProduct.TabIndex = 7;
			PanelSearchProduct.Visible = false;
			// 
			// ProductNameSP
			// 
			ProductNameSP.AutoSize = true;
			ProductNameSP.Location = new Point(80, 48);
			ProductNameSP.Name = "ProductNameSP";
			ProductNameSP.Size = new Size(84, 15);
			ProductNameSP.TabIndex = 4;
			ProductNameSP.Text = "Product Name";
			// 
			// ProductNameTextboxSP
			// 
			ProductNameTextboxSP.Location = new Point(80, 66);
			ProductNameTextboxSP.Name = "ProductNameTextboxSP";
			ProductNameTextboxSP.Size = new Size(100, 23);
			ProductNameTextboxSP.TabIndex = 1;
			// 
			// ButtonSearchProduct
			// 
			ButtonSearchProduct.Location = new Point(32, 119);
			ButtonSearchProduct.Name = "ButtonSearchProduct";
			ButtonSearchProduct.Size = new Size(206, 23);
			ButtonSearchProduct.TabIndex = 0;
			ButtonSearchProduct.Text = "Search Product";
			ButtonSearchProduct.UseVisualStyleBackColor = true;
			ButtonSearchProduct.Click += ButtonSearchProduct_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(PanelSearchProduct);
			Controls.Add(PanelRefreshProduct);
			Controls.Add(ProductList);
			Controls.Add(PanelAddProduct);
			Controls.Add(ButtonSearchPanel);
			Controls.Add(ButtonRefreshPanel);
			Controls.Add(ButtonAddPanel);
			Name = "Form1";
			Text = "Form1";
			PanelAddProduct.ResumeLayout(false);
			PanelAddProduct.PerformLayout();
			PanelRefreshProduct.ResumeLayout(false);
			PanelRefreshProduct.PerformLayout();
			PanelSearchProduct.ResumeLayout(false);
			PanelSearchProduct.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button ButtonAddPanel;
		private Button ButtonRefreshPanel;
		private Button ButtonSearchPanel;
		private Panel PanelAddProduct;
		private Button ButtonAddProduct;
		private Label ProductAmountAP;
		private Label ProductNameAP;
		private TextBox ProductAmountTextboxAP;
		private TextBox ProductNameTextboxAP;
		private ListBox ProductList;
		private Panel PanelRefreshProduct;
		private Label ProductAmountRP;
		private Label ProductNameRP;
		private TextBox ProductAmountTextboxRP;
		private TextBox ProductNameTextboxRP;
		private Button ButtonRefreshProduct;
		private Panel PanelSearchProduct;
		private Label ProductNameSP;
		private TextBox ProductNameTextboxSP;
		private Button ButtonSearchProduct;
	}
}
