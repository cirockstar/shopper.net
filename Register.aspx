<%@ Page Title="" Language="C#" MasterPageFile="~/Global.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" Runat="Server">
    <title>Shopper.NET - Register</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" Runat="Server">
     <div class="one-third columns">
        <h3>Register</h3><br />
        <label for="txtEmail">Email:<asp:RequiredFieldValidator 
            ID="valReqEmail" runat="server" ControlToValidate="txtEmail" 
            ErrorMessage="*" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="valRegexEmail" runat="server" 
            ControlToValidate="txtEmail" ErrorMessage="*" Font-Bold="True" ForeColor="Red" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </label>
        &nbsp;<input type="text" name="txtEmail" id="txtEmail" runat="server" />
        <label for="txtPassword">Password:
            <asp:RequiredFieldValidator ID="valReqPass" runat="server" ControlToValidate="txtPassword" 
                                        ErrorMessage="*" Font-Bold="True" ForeColor="Red">
            </asp:RequiredFieldValidator>
        </label>
        &nbsp;<input type="password" name="txtPassword" id="txtPassword" runat="server" />
       
        <label for="txtConfPass">Confirm Password:<asp:CompareValidator 
             ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" 
             ControlToValidate="txtConfPass" ErrorMessage="*" Font-Bold="True" 
             ForeColor="Red"></asp:CompareValidator>
         </label><br />
        <input type="password" name="txtConfPass" id="txtConfPass" runat="server" />
   
        <asp:Button ID="btnRegister" runat="server" Text="Register" 
             onclick="btnRegister_Click" />
        <br />
        
        <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

