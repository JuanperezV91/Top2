<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="ListaEmpleados.aspx.cs" Inherits="Proyect.WEB.ListaEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <!--  <div>
             <asp:Label ID="lblMsj" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnSignOut" runat="server" Class="btn btn-default navbar-btn" Text="Cerrar Sesión" OnClick="btnSignOut_Click" />
             <asp:TextBox ID="txtIdLog" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
            <asp:Button ID="btnSignUser" runat="server" Class="btn btn-default navbar-btn" Text="Registrar Usuarios" OnClick="btnSignUser_Click" />
        </div>
         
         /.form-group -->

    
        <div class="container register">                    
                    <div class="col-md-12 register-right">
                        
      <div class="col-md-9">
        <div class="head clearfix">
            <div class="isw-grid"></div>
            <h1>Listado de Empleados</h1>
          
        </div>
        <div class="block-fluid">
          
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
            </asp:GridView>
          
        </div></div>
                    </div>
                    
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ProyectoBDConnectionString %>" SelectCommand="SelectCommand=&quot;SELECT Persona.Rut, Persona.Nombre, Persona.ApellidoP, Persona.ApellidoM, Persona.Sexo, Empleado.IdEmpleado, Empleado.EmpresaEmpleado, Empleado.CargoEmpleado FROM Persona INNER JOIN Empleado ON Persona.IdPersona = Empleado.IdPersona"></asp:SqlDataSource>
                    
            </div> 

              

</asp:Content>
