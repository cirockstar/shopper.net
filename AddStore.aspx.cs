using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Subgurim.Controles;
public partial class AddShop : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BLLtype BLLtype = new BLLtype();

            drpType.DataSource = BLLtype.selectAll();
            drpType.DataTextField = "name";
            drpType.DataValueField = "id";
            drpType.DataBind();

            addStoreMap.Width = 600;
            addStoreMap.Height = 250;
        }

    }
    protected void btnGetCoords_Click(object sender, EventArgs e)
    {
        string[] location = new string[2];
        location[0] = hdnLat.Value;
        location[1] = hdnLong.Value;

        double x = Double.Parse(location[0], System.Globalization.CultureInfo.GetCultureInfo("en-us"));
        double y = Double.Parse(location[1], System.Globalization.CultureInfo.GetCultureInfo("en-us"));

        GLatLng p = new GLatLng(x, y);
        GMarker m = new GMarker(p);

        addStoreMap.setCenter(p, 16);
        addStoreMap.addGMarker(m);

        btnSubmitStore.Visible = true;
    }

    protected void btnSubmitStore_Click(object sender, EventArgs e)
    {
        BLLstore BLLstore = new BLLstore();

        try
        {
            string[] location = new string[2];
            location[0] = hdnLat.Value;
            location[1] = hdnLong.Value;

            double x = Double.Parse(location[0], System.Globalization.CultureInfo.GetCultureInfo("en-us"));
            double y = Double.Parse(location[1], System.Globalization.CultureInfo.GetCultureInfo("en-us"));

            Store s = new Store();
            s.name = txtName.Value;
            s.city = txtCity.Value;
            s.typeID = Convert.ToInt16(drpType.SelectedValue);
            s.latitude = x;
            s.longitude = y;
            BLLstore.insertStore(s);
        }
        catch (Exception ex)
        {
            lblFeedback.Text = ex.Message;
        }
    }
}