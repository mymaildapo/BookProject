using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using System.Collections;
using System.IO;
public partial class Pages_Managemet_ManageBooks : System.Web.UI.Page
{
 protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            GetImages();

            
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
               
            {

               int id = Convert.ToInt32(Request.QueryString["id"]);
                
               
                FillForm(id);
                
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ProductModel productModel = new ProductModel();
       
       
        BookTB product = CreateProduct();
       
       
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        { 
            int id = Convert.ToInt32(Request.QueryString["id"]);
            lblResult.Text = productModel.UpdateProduct(id, product);
           
        }
        else
        {
            
            lblResult.Text = productModel.InsertProduct(product);
          
        }
    }

     private void FillForm(int id)
    {
        try
        {
           
            ProductModel productModel = new ProductModel();
            BookTB product = productModel.GetProduct(id);


            txtDescription.Text = product.Description;
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtAuthor.Text = product.author;

            
            ddlImage.SelectedValue = product.Image;
            ddlType.SelectedValue = product.TypeID.ToString();
        }
        catch (Exception ex)
        {
            lblResult.Text = ex.ToString();
        }
    }

   
    private void GetImages()
    {
        try
        {
           
            string[] images = Directory.GetFiles(Server.MapPath("~/Images/Books/"));

          
            ArrayList imageList = new ArrayList();
            foreach (string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imageList.Add(imageName);
            }

       
            ddlImage.DataSource = imageList;
            ddlImage.AppendDataBoundItems = true;
            ddlImage.DataBind();
        }
        catch (Exception e)
        {
            lblResult.Text = e.ToString();
        }
    }

   
    private BookTB CreateProduct()
    {
        BookTB product = new BookTB();

        product.Name = txtName.Text;
        product.Price = Convert.ToDouble(txtPrice.Text);
        product.TypeID = Convert.ToInt32(ddlType.SelectedValue);
        product.Description = txtDescription.Text;
        product.Image = ddlImage.SelectedValue;
        product.author = txtAuthor.Text;

        return product;
     
    }
    protected void btnUploadImage_Click(object sender, EventArgs e)
    {
        try
        {
            string filename = Path.GetFileName(FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath("~/Images/Books/") + filename);
            lblResult.Text = "Image " + filename + " succesfully uploaded!";
            Page_Load(sender, e);
        }
        catch (Exception)
        {
            lblResult.Text = "Upload failed!";
        }
    }
   
}