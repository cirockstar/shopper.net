using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Subgurim.Controles;
using System.Web.UI.WebControls;

public partial class ViewStore : System.Web.UI.Page
{
    public string storename;
    public string city;
    public string type;
    public string tag1;
    public string tag2;
    public IList<Comment> comments;

    protected void Page_Load(object sender, EventArgs e)
    {
        BLLstore BLLstore = new BLLstore();
        String s = Request.QueryString["storeid"];
        Store store = new Store();
        store = BLLstore.getStore(Convert.ToInt16(s));
        comments = new List<Comment>();
        

        try
        {
            storename = store.name;
            city = store.city;
            type = store.Type.name;
            tag1 = store.tag1;
            tag2 = store.tag2;

            viewStoreMap.Width = 600;
            viewStoreMap.Height = 250;

            GLatLng p = new GLatLng(store.latitude, store.longitude);
            GMarker m = new GMarker(p);

            viewStoreMap.setCenter(p, 16);
            viewStoreMap.addGMarker(m);

            comments = BLLstore.getCommentsForStore(store.id);
            rptComments.DataSource = comments;
            rptComments.DataBind();
        }
        catch(Exception ex) {
            Response.Write(ex.Message);
        }
    }
}