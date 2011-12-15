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

    public IList<Store> getStoreByType(int typeID)
    {
        var result = (from s in dc.Stores
                      where s.typeID == typeID
                      select s).ToList();

        return result;

    }


    public IList<Store> getStoreByName(string store)
    {
        var result = (from s in dc.Stores
                      where s.name == store
                      select s).ToList();

        return result;
    }

    public IList<Store> getStoreByTag(string store)
    {
        var result = (from s in dc.Stores
                      where s.tag1 == store || s.tag2 == store
                      select s).ToList();
        return result;
    }
}