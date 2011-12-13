using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLtype
/// </summary>
public class BLLtype
{
    private DALtype DALtype = new DALtype();

    public IList<Type> selectAll()
    {
        return DALtype.selectAll();
    }
}