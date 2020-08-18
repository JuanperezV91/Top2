<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="Proyect.WEB.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 119px;
        }
        .auto-style2 {
            width: 118px;
        }
        .auto-style3 {
            width: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Nombre </td>
                    <td>
                        <asp:TextBox ID="txtNomUsuario" runat="server"></asp:TextBox>
                        <asp:TextBox ID="txtIdUser" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
                        <asp:TextBox ID="txtIdPersona" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Rut</td>
                    <td>
                        <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Apellido Paterno</td>
                    <td>
                        <asp:TextBox ID="txtApPaterno" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Sexo</td>
                    <td>
                        <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
                    &nbsp;(M/F)</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            &nbsp;<br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Apellido Materno</td>
                    <td>
                        <asp:TextBox ID="txtApMaterno" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="txtPass" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Confirmar Password</td>
                    <td>
                        <asp:TextBox ID="txtCPass" TextMode="Password" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style3">Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Rol</td>
                    <td>
                        <asp:TextBox ID="txtRol" runat="server"></asp:TextBox>
                    &nbsp;(Admin / User)</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registrar" />
                        <asp:Label ID="lblMsj" runat="server" ></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />

        </div>
    </form>
</body>
</html>
