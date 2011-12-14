using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALstore
/// </summary>
public class DALstore
{
    private shopperModelDataContext dc = new shopperModelDataContext();

    public void insertStore(Store s)
    {
        dc.Stores.InsertOnSubmit(s);
        dc.SubmitChanges();
    }

<<<<<<< HEAD
    public Store getStore(int storeid)
    {
        var result = (from s in dc.Stores
                      where s.id == storeid
                      join t in dc.Types on s.typeID equals t.id  
                      select s).SingleOrDefault();   

        return result;
    }

    public IList<Comment> getCommentsForStore(int storeid)
    {
        var result = (from c in dc.Comments
                      where c.storeID == storeid
                      join u in dc.Users on c.userID equals u.id
                      select c).ToList();

        return result;
    }
}
=======
    public IList<Store> getStoreByType(int typeID)
    {
        var result = (from s in dc.Stores
                      where s.typeID == typeID
                      select s).ToList();

        return result;

    }

}
>>>>>>> 11501a17b455cf8fe3c96cd7199a6b5a32af6713
