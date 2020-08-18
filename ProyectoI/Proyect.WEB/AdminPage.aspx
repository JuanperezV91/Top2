<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Proyect.WEB.AdminPage" %>

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
            <asp:Button ID="btnSignUser" runat="server" Class="btn btn-default navbar-btn" Text="Registrar Usuarios" OnClick="btnSignUser_Click" />
        </div>
    </form>
</body>
</html>
