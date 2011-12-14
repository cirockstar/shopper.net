<%@ Page Title="" Language="C#" MasterPageFile="~/Global.master" AutoEventWireup="true" CodeFile="ViewStore.aspx.cs" Inherits="ViewStore" %>

<%@ Register Assembly="GMaps" Namespace="Subgurim.Controles" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" Runat="Server">
    <title>Shopper.net - view stores</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" Runat="Server">
    <h1><%= storename %></h1>
    <h2><%= city %></h2>
    <h3><%= type %></h3><br />

    <p>Tags:</p>
    <ul>
        <li><%= tag1 %></li>
        <li><%= tag2 %></li>
    </ul>

    <cc1:GMap ID="viewStoreMap" runat="server" /><br />

    <h2>Comments</h2>
    <asp:Repeater ID="rptComments" runat="server">
    <HeaderTemplate>
        <div>
    </HeaderTemplate>

    <ItemTemplate>
            <%# DataBinder.Eval(Container.DataItem,"User.email") %>
            <%# DataBinder.Eval(Container.DataItem,"datetime") %>
            <strong><%# DataBinder.Eval(Container.DataItem, "body") %></strong>
    </ItemTemplate>

    <FooterTemplate>
        </div>
    </FooterTemplate>

    </asp:Repeater>
    
    <asp:TextBox id="txtComment" runat="server" />
    <asp:Button id="btnSubmit" runat="server" />
</asp:Content>

