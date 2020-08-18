<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="Proyect.WEB.UserPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="lblMsj" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnSignOut" runat="server" Class="btn btn-default navbar-btn" Text="Cerrar Sesión" OnClick="btnSignOut_Click" />
             <asp:TextBox ID="txtIdLog" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
        </div>
    </form>
</body>
</html>
