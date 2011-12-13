<%@ Page Title="" Language="C#" MasterPageFile="~/Global.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" Runat="Server">
    <title>Shopper.NET - Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" Runat="Server">
    <div class="one-third columns">
        <h3>Log in</h3><br />
        <label for="txtEmail">Email:<asp:RequiredFieldValidator 
            ID="valReqEmail" runat="server" ControlToValidate="txtEmail" 
            ErrorMessage="*" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="valRegexEmail" runat="server" 
            ControlToValidate="txtEmail" ErrorMessage="*" Font-Bold="True" ForeColor="Red" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </label>
        &nbsp;<input type="text" name="txtEmail" id="txtEmail" runat="server" />
        <label for="txtPassword">Password:<asp:RequiredFieldValidator 
            ID="valReqPass" runat="server" ControlToValidate="txtPassword" 
            ErrorMessage="*" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
        </label>
        &nbsp;<input type="password" name="txtPassword" id="txtPassword" runat="server" />
        <br />
        
        <asp:Button ID="btnLogin" runat="server" Text="Log In" 
            onclick="btnLogin_Click" />
        <br />
        
        <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
    </div>
    <div class="two-thirds column">
        <h3>Welcome!</h3>
        <p>
        Bacon ipsum dolor sit amet ad chuck in, pastrami sausage minim do enim ball tip salami ham hock cow pork belly. 
        Shankle veniam leberkäse filet mignon, ham hock fugiat pastrami dolor occaecat meatball voluptate aute. 
        Elit ut incididunt, enim cillum ad pork belly beef cow venison ribeye andouille short ribs aliqua duis. 
        Do excepteur pancetta culpa veniam beef ribs aliqua, deserunt duis ut aute. Mollit deserunt prosciutto, 
        jerky ham ribeye meatloaf. Chicken esse cupidatat tempor, pork chop aliquip venison nulla nostrud filet 
        mignon rump qui strip steak eu tail. Sunt ullamco officia in.
        </p>
        <h5><a href="Register.aspx" title="Register here!">Register here!</a></h5>
       
    </div>
</asp:Content>

