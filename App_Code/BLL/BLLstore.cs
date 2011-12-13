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
}