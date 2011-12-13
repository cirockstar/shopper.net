using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALtype
/// </summary>
public class DALtype
{
    private Shopper_modelDataContext dc = new Shopper_modelDataContext();

    public IList<Type> selectAll()
    {
        var result = (from t in dc.Types
                      select t).ToList();

        return result;
    }
}