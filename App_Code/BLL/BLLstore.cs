using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLstore
/// </summary>
public class BLLstore
{
    private DALstore DALstore = new DALstore();

    public void insertStore(Store s)
    {
        DALstore.insertStore(s);
    }

<<<<<<< HEAD
    public Store getStore(int storeid)
    {
        return DALstore.getStore(storeid);
    }

    public IList<Comment> getCommentsForStore(int storeid)
    {
        return DALstore.getCommentsForStore(storeid);
=======
    public IList<Store> getStoreByType(int typeID)
    {
        return DALstore.getStoreByType(typeID);
>>>>>>> 11501a17b455cf8fe3c96cd7199a6b5a32af6713
    }
}