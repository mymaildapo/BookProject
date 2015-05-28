using System;
using System.Collections.Generic;
using System.Linq;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Stationary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductModel model = new ProductModel();
        List<BookTB> products = model.GetProductsByType(7);

        if (products != null)
        {
            foreach (BookTB product in products)
            {
                Panel productPanel = new Panel();
                ImageButton imageButton = new ImageButton
                {
                    ImageUrl = "~/Images/Books/" + product.Image,
                    CssClass = "productImage",
                    PostBackUrl = string.Format("~/Pages/BookInDetails.aspx?id={0}", product.Id)
                };
                Label lblName = new Label
                {
                    Text = product.Name,
                    CssClass = "productName"
                };
                Label lblPrice = new Label
                {
                    Text = "£ " + product.Price,
                    CssClass = "productPrice"
                };

                productPanel.Controls.Add(imageButton);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblPrice);

                //Add dynamic controls to static control
                pnlProducts.Controls.Add(productPanel);
            }
        }
        else
            pnlProducts.Controls.Add(new Literal { Text = "No products found!" });
    }
}