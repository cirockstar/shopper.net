﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shopper : System.Web.UI.Page
{
    public IList<Store> searchResults;
    private BLLstore BLLstore = new BLLstore();

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
        searchResults = BLLstore.getStoreByType(Convert.ToInt16(DropStoreType.SelectedValue));
        bindSearchResults(searchResults);
    }

    protected void BtnName_Click(object sender, EventArgs e)
    {
        searchResults = BLLstore.getStoreByName(TxtName.Text);
        bindSearchResults(searchResults);
    }

    protected void BtnTags_Click(object sender, EventArgs e)
    {
        searchResults = BLLstore.getStoreByTag(TxtTags.Text);
        bindSearchResults(searchResults);
    }

    private void bindSearchResults(IList<Store> searchResults)
    {
        rptSearchResults.DataSource = searchResults;
        rptSearchResults.DataBind();
    }
}