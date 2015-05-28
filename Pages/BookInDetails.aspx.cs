using System;
using System.Linq;
using Microsoft.AspNet.Identity;
using Models;

public partial class Pages_BookInDetails : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
           
        {
           
            string clientId = Context.User.Identity.GetUserId();
           
            if (clientId != null)
              
            {
                

                int id = Convert.ToInt32(Request.QueryString["id"]);
                

                int amount = Convert.ToInt32(ddlAmount.SelectedValue);
                int orderAmount = Convert.ToInt32(ddlAmount.SelectedValue);
               
                Cart cart = new Cart
               
                {
                   
                    Amount = amount,
                    ClientID = clientId,
                    DatePurchased = DateTime.Now,
                    IsInCart = true,
                    ProductID = id
                };
             
                

                CartModel model = new CartModel();
            
                lblResult.Text = model.InsertCart(cart);
              
               
            }
            else
            {
                lblResult.Text = "Please log in to order items";
            }
        }

    
    }

   
    private void FillPage()
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ProductModel model = new ProductModel();
            BookTB product = model.GetProduct(id);

           
            lblTitle.Text = product.Name;
            lblDescription.Text = product.Description;
            lblPrice.Text = "Price per unit:<br/>£ " + product.Price;
            imgProduct.ImageUrl = "~/Images/Books/" + product.Image;
            lblItemNr.Text = product.Id.ToString();

            
            int[] amount = Enumerable.Range(1, 20).ToArray();
            ddlAmount.DataSource = amount;
            ddlAmount.AppendDataBoundItems = true;
            ddlAmount.DataBind();
        }
    }

}