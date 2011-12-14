using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shopper : System.Web.UI.Page
{
    public IList<Store> stores;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session == null || (string)Session["loggedin"] != "2")
        {
            Response.Redirect("default.aspx");
        }

        // zodat btnclick niet upfuckt
        if (!Page.IsPostBack)
        {
            BLLtype BLLtype = new BLLtype();
            DropStoreType.DataSource = BLLtype.selectAll();
            DropStoreType.DataTextField = "name";
            DropStoreType.DataValueField = "id";
            DropStoreType.DataBind();
        }
    }
    
    protected void BtnType_Click(object sender, EventArgs e)
    {
        
            BLLstore BLLstore = new BLLstore();
            stores = BLLstore.getStoreByType(Convert.ToInt16(DropStoreType.SelectedValue));
     }
        
}