using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALuser
/// </summary>
public class DALuser
{
    private Shopper_modelDataContext dc = new Shopper_modelDataContext();

    public User selectUser(User user)
    { 
        // select user from db where email and pass == input
        var result = (from u in dc.Users
                      where u.email == user.email
                      && u.password == user.password
                      select u).SingleOrDefault();          // single or default returns user or null
                        
        return result;
    }

    public void insertUser(User u)
    {
        dc.Users.InsertOnSubmit(u);
        dc.SubmitChanges();
    }
}