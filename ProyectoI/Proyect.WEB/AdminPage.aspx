<%@ Page Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Proyect.WEB.AdminPage" %>

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
            <div>
            <asp:GridView class="table table-bordered " ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource" OnRowCommand="RegistroSalud">
                <Columns>
                    <asp:BoundField DataField="Rut" HeaderText="RUT" SortExpression="Rut" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="ApellidoP" HeaderText="Apellido Paterno" SortExpression="ApellidoP" />
                    <asp:BoundField DataField="ApellidoM" HeaderText="Apellido Materno" SortExpression="ApellidoM" />
                    <asp:BoundField DataField="Sexo" HeaderText="Sexo" SortExpression="Sexo" />
                    <asp:BoundField DataField="EmpresaEmpleado" HeaderText="Nombre Empresa" SortExpression="EmpresaEmpleado" />
                    <asp:BoundField DataField="CargoEmpleado" HeaderText="Cargo" SortExpression="CargoEmpleado" />
                    <asp:ButtonField ButtonType="Button" Text="Registro Salud" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ProyectoBDConnectionString %>" SelectCommand="SELECT Persona.Rut, Persona.Nombre, Persona.ApellidoP, Persona.ApellidoM, Persona.Sexo, Empleado.EmpresaEmpleado, Empleado.CargoEmpleado FROM Persona INNER JOIN Empleado ON Persona.IdPersona = Empleado.IdPersona"></asp:SqlDataSource>
        </div>
        </div></div>
                    </div>
                    
            </div> 

              

</asp:Content>
