using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// import System.Web.Security for the MD5 method
using System.Web.Security;
/// <summary>
/// Summary description for BLLuser
/// </summary>
public class BLLuser
{
    private DALuser DALuser = new DALuser();

    public User selectUser(User u)
    {
        // use the FormsAuth HashPwd method to turn the string into an md5 hash.
        u.password = FormsAuthentication.HashPasswordForStoringInConfigFile(u.password, "MD5");

        var result = DALuser.selectUser(u);

        if (result == null)
        {   
            // if no user was found, throw new exception and end the login process
            throw new Exception("It appears your credentials were not correct. Please try again.");
        }
        else
        {
            // otherwise return the user
            return result;
        }
    }

    public void insertUser(User u)
    {
        u.password = FormsAuthentication.HashPasswordForStoringInConfigFile(u.password, "MD5");
        DALuser.insertUser(u);
    }
}