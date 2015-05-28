using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Managemet_ManageOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {  
        ProductModel model = new ProductModel();
        List<Cart> products = model.GetProductsByBollean();
      
        if (products != null)
        {
           
            foreach (Cart product in products)
          
            {

                order p = new order();

            
                Panel productPanel = new Panel();
               
                Label lblName = new Label
                {
                   
                    Text = product.ProductID.ToString(),
                    
                    CssClass = "productName"
                };

                Label lblAuthor = new Label
                {
                    Text = product.Amount.ToString(),


                };

                Label lblPrice = new Label
                {
                    Text = "£ " + product.DatePurchased,
                    CssClass = "productPrice"
                };

                Label lblclient = new Label
                {
                    Text = "£ " + product.ClientID,
                   
                };

              


                
                productPanel.Controls.Add(new Literal { Text = "Order <br/>" });           
                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblAuthor);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblPrice);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblclient);

               pnlProducts.Controls.Add(productPanel);
            }
        }
        else
            pnlProducts.Controls.Add(new Literal { Text = "No products found!" });
    }


}