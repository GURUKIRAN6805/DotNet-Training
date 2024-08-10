using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductApp
{
    public partial class ProductSelection : System.Web.UI.Page 
    {
        private Dictionary<string, (string ImageUrl, decimal Price)> products = new Dictionary<string, (string ImageUrl, decimal Price)>
        {
            { "Laptop", ("~/Images/laptop.jpg", 1200.00m) },
            { "Smartphone", ("~/Images/smartphone.jpg", 800.00m) },
            { "Tablet", ("~/Images/tablet.jpg", 500.00m) }
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProducts.DataSource = products.Keys;
                ddlProducts.DataBind();
            }
        }
        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = ddlProducts.SelectedValue;
            imgProduct.ImageUrl = products[selectedProduct].ImageUrl;
            lblPrice.Text = ""; 
        }
        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            string selectedProduct = ddlProducts.SelectedValue;
            lblPrice.Text = "Price: $" + products[selectedProduct].Price.ToString("F2");
        }
    }
}