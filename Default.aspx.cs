using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session != null && (string)Session["loggedin"] == "2")
        {
            Response.Redirect("shopper.aspx");
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        BLLuser BLLuser = new BLLuser();

        User u = new User();
        u.email = txtEmail.Value;
        u.password = txtPassword.Value;

        try
        {
            BLLuser.selectUser(u);
            if (Session["loggedin"] == null)
            {    
                Session["loggedin"] = "2";
            }

            Response.Redirect("Shopper.aspx");
        }
        catch(Exception ex)
        {
            lblFeedback.Text = ex.Message;
        }
    }
}