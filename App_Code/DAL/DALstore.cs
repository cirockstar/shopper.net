using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALstore
/// </summary>
public class DALstore
{
    private Shopper_modelDataContext dc = new Shopper_modelDataContext();

    public void insertStore(Store s)
    {
        dc.Stores.InsertOnSubmit(s);
        dc.SubmitChanges();
    }

    public IList<Store> getStoreByType(int typeID)
    {
        var result = (from s in dc.Stores
                      where s.typeID == typeID
                      select s).ToList();

        return result;

    }

}
