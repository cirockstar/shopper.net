<%@ Page Title="" Language="C#" MasterPageFile="~/Global.master" AutoEventWireup="true" CodeFile="AddStore.aspx.cs" Inherits="AddShop" %>

<%@ Register assembly="GMaps" namespace="Subgurim.Controles" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" Runat="Server">
    <title>Add a Store</title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
    <script src="js/modernizr.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            if (Modernizr.geolocation) {
                navigator.geolocation.getCurrentPosition(getCoords, handleErrors, { enableHighAccuracy: true });
            }
            else {
                // no support
            }

            function getCoords(position) {
                $("#contentBody_hdnLat").val(position.coords.latitude);
                $("#contentBody_hdnLong").val(position.coords.longitude);
            }

            function handleErrors(err) { 
                // handle errors
            }
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" Runat="Server">
    <div class="sixteen columns">
        <h3>Add a store</h3><br />
    </div>
    <div class="one-third columns">
        <label for="txtName">Name:<asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" 
            ErrorMessage="*" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        </label><br />
        <input type="text" name="txtName" id="txtName" runat="server" />

        <label for="txtCity">City:<asp:RequiredFieldValidator 
            ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCity" 
            ErrorMessage="*" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        </label><br />
        <input type="text" name="txtCity" id="txtCity" runat="server" />

        <label>Type:</label><br /> 
        <asp:DropDownList ID="drpType" runat="server"></asp:DropDownList>

        <label>Tags:</label><br />
        <input type="text" id="txttag1" runat="server" />
        <input type="text" id="txttag2" runat="server" />

        <label>Current Location:</label><br />
        <input type="hidden" id="hdnLat" runat="server" />
        <input type="hidden" id="hdnLong" runat="server" />

        <asp:Button ID="btnGetCoords" runat="server" Text="Set current position" 
            onclick="btnGetCoords_Click" />

        <asp:Button ID="btnSubmitStore" runat="server" Text="Submit store" 
            Visible="false" onclick="btnSubmitStore_Click" />

        <br />
        <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
    </div> 

    <div class="two-thirds columns">
        
        <cc1:GMap ID="addStoreMap" runat="server" />

    </div>
</asp:Content>
