using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        BLLuser BLLuser = new BLLuser();

        try
        {
            User u = new User();
            u.email = txtEmail.Value;
            u.password = txtPassword.Value;
            BLLuser.insertUser(u);
            lblFeedback.Text = "Sign up succesful!";
        }
        catch (Exception ex)
        {
            lblFeedback.Text = ex.Message;
        }

    }
}