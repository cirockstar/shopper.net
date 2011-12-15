<%@ Page Title="" Language="C#" MasterPageFile="~/Global.master" AutoEventWireup="true" CodeFile="Shopper.aspx.cs" Inherits="Shopper" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" Runat="Server">
    <title>Shopper.NET - Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" Runat="Server">
    <div class="sixteen columns" style="margin-bottom:40px">
        <p style="float: right">
            <a href="AddStore.aspx" title="AddStore" >Add Store</a>
            <a href="Logout.aspx" title="Logout">Logout</a></p>
    </div>

    <div class="four columns">
        <asp:Button ID="BtnNear" runat="server" Text="Find near" Width="200px" />
    </div>
     <div class="four columns">
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
        <asp:Button ID="BtnName" runat="server" Text="Find store" 
             onclick="BtnName_Click" />
    </div>
     <div class="four columns">
        <asp:TextBox ID="TxtTags" runat="server"></asp:TextBox>
        <asp:Button ID="BtnTags" runat="server" Text="Find by tags" 
             onclick="BtnTags_Click"/>
    </div>
     <div class="four columns">
        <asp:DropDownList ID="DropStoreType" runat="server" Height="30px"></asp:DropDownList>
        <asp:Button ID="BtnType" runat="server" Text="Find by type" 
             onclick="BtnType_Click" /><br />
    </div>
    <hr />
    <div class="sixteen columns">
        <h1>Search Results</h1>
    </div>
    <asp:Repeater ID="rptSearchResults" runat="server">
     
        <ItemTemplate>
            <div class="four columns">
                <h3><%# DataBinder.Eval(Container.DataItem, "name") %></h3>
                <em><%# DataBinder.Eval(Container.DataItem, "city") %> -
                    <%# DataBinder.Eval(Container.DataItem, "Type.name") %></em><br />
                <a href="ViewStore.aspx?storeid=<%# DataBinder.Eval(Container.DataItem, "id") %>"
                    title="View store">Show details</a>
             </div>
        </ItemTemplate>
    </asp:Repeater> 


</asp:Content>

