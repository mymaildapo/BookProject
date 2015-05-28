using System;
using System.Web;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var user = Context.User.Identity;
        //this object return the Identity of the current log in user(the name of user/ userName)
        if (user.IsAuthenticated)
            //we can check if user is log in
        { 
            //true, user is log in, do below

            LnkLogIn.Visible = false;
            //we need to hide log in HyperLink call  LnkLogIn
            //alse
            lnkRegister.Visible = false;
            //we need to hide Register HyperLink  call  lnkRegister

            litStatus.Visible = true;
            //we need to show the LinkButton to logo out
            
            btnLogOut.Visible = true;
            //we need to show the status HyperLink 

            CartModel model = new CartModel();
            string userId = HttpContext.Current.User.Identity.GetUserId();
            litStatus.Text = string.Format("{0} ({1})", Context.User.Identity.Name, model.GetAmountOfOrders(userId));
            //3 code above will retrieve the name of the current user
        }
        else
        {
           //if user not log in, do expect opposite of the if statement.
            //copy those true and false code, and change them to da top opposite
            LnkLogIn.Visible = true;
            lnkRegister.Visible = true;

            litStatus.Visible = false;
            btnLogOut.Visible = false;
        }
    }


    //on click event
    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        // to allow user to log out
        // button LinkButton ID="btnLogOut" button click,o
   
        IAuthenticationManager authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
        //first we get functionality call it authenticationManager
        authenticationManager.SignOut();
        //then use authenticationManager to call sign out
        Response.Redirect("Default.aspx");
    //take us back to the home page
    }
}
