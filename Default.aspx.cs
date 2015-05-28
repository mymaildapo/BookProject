using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   //database
        //get a list of all products in db
        ProductModel model = new ProductModel();
      List<BookTB> products = model.GetAllProducts();
        //make sure  List<BookTB> products object is not null
        if (products != null)
        {
            // for each row datas in BookTB/table create a 1-panel, 2-image,3-label.
            foreach (BookTB product in products)
            //BookTB product in products(model.context.tt> model.context.cs)
            {
                // 1-panel (object) parent/outside control
                Panel productPanel = new Panel();
                //2-image (object)
                ImageButton imageButton = new ImageButton
                {
                    //set childcontrol/inside control properties
                    ImageUrl = "~/Images/Books/" + product.Image,// remember to put product.Image product is d object (Image is a column in BookTb)
                    CssClass = "productImage",
                    PostBackUrl = string.Format("~/Pages/BookInDetails.aspx?id={0}", product.Id)// remember to put product.Id product is d object (Id is a column in BookTb)
                };
                //3-label (object)
                Label lblName = new Label
                {
                    Text = product.Name, // remember to put product.Name product is d object (Name is a column in BookTb)
                    CssClass = "productName"
                };

                Label lblAuthor = new Label
                {
                    Text = product.author,
                   
                   
                };

                Label lblPrice = new Label
                {
                    Text = "£ " + product.Price,
                    CssClass = "productPrice"
                };

                // parent/outside-this is from above Panel productPanel = new Panel(); child/inside ImageButton imageButton = new ImageButton. put object name of the child inside the  object name of parent
                productPanel.Controls.Add(imageButton);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });  //white space/ used to add a break            
                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblAuthor);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblPrice);

                //Add dynamic controls to static control so this name pnlProducts is name given to the  panel (control) in design mode and productPanel from list just above this comment
                pnlProducts.Controls.Add(productPanel);
            }
        }
        else
            pnlProducts.Controls.Add(new Literal { Text = "No products found!" });
    }

}