<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrarEmpleado.aspx.cs" Inherits="Proyect.WEB.RegistrarEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container register">                    
                    <div class="col-md-12 register-right">
                       
                        <div class="tab-content" id="myTabContent">
                            <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                <h3 class="register-heading">Registrar Empleado</h3>
                                <div class="row register-form">
                                    <div class="col-md-8">
                                        <label for="txtNomUsuario" class="control-label">Nombre</label>
                                        <div class="form-group">
                                            <asp:TextBox ID="txtNomUsuario" runat="server" type="text" class="form-control" placeholder="First Name *"></asp:TextBox>
                                        </div>

                                        <label for="txtApPaterno" class="control-label">Apellido Paterno</label>
                                        <div class="form-group">
                                            <asp:TextBox ID="txtApPaterno" runat="server" type="text" class="form-control" placeholder="Apellido Paterno *"></asp:TextBox>
                                        </div>

                                        <label for="txtApMaterno" class="control-label">Apellido Materno</label>
                                        <div class="form-group">
                                            <asp:TextBox ID="txtApMaterno" runat="server" type="text" class="form-control" placeholder="Apellido Materno *"></asp:TextBox>
                                        </div>

                                        <label for="txtRut" class="control-label">RUT Empleado</label>
                                        <div class="form-group">
                                            <asp:TextBox ID="txtRut" runat="server" type="text" class="form-control" placeholder="RUT *"></asp:TextBox>
                                        </div>

                                        <!--    <label for="birthDate" class="control-label">Fecha de Nacimiento*</label>
                                           <div class="form-group">
                                                <input type="date" id="birthDate" class="form-control"> 
            <asp:Calendar type="date" ID="DateBirth" runat="server" class="form-control"></asp:Calendar>
                                            </div>-->

                                        <label for="txtEmail" class="control-label">Correo</label>
                                         <div class="form-group">
                                            <asp:TextBox ID="txtEmail" runat="server" type="text" class="form-control" placeholder="Correo *"></asp:TextBox>
                                        </div>

                                        <label for="txtEmpresa" class="control-label">Empresa</label>
                                         <div class="form-group">
                                            <asp:TextBox ID="txtEmpresa" runat="server" type="text" class="form-control" placeholder="Nombre Empresa *"></asp:TextBox>
                                        </div>

                                        <label for="txtCargo" class="control-label">Cargo en Empresa</label>
                                         <div class="form-group">
                                            <asp:TextBox ID="txtCargo" runat="server" type="text" class="form-control" placeholder="Cargo Empresa *"></asp:TextBox>
                                        </div>
                                        <label for="txtArea" class="control-label">Area Empresa</label>
                                         <div class="form-group">
                                            <asp:TextBox ID="txtArea" runat="server" type="text" class="form-control" placeholder="Area Empresa *"></asp:TextBox>
                                        </div>

                                           <label class="control-label">Sexo</label>

                                          <div class="form-group">
                                            <div class="maxl">
                                                <label class="radio inline"> 
                                                   <asp:RadioButton ID="rbtnHombre" type="radio"  name="gender" runat="server" GroupName="GroupGender" />

                                                    <span> Hombre </span> 
                                                </label>
                                                <label class="radio inline"> 
                                                   <asp:RadioButton ID="rbtnMujer" type="radio"  name="gender" runat="server" GroupName="GroupGender" />
                                                    <span>Mujer 
                                                </span> 
                                                </label>
                                            </div>
                                        </div>

                                        <asp:TextBox ID="txtIdEmpleado" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
                                        <asp:TextBox ID="txtIdPersona" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:Button ID="btnRegistrarUsuario" class="btn btn-primary btn-block" runat="server" OnClick="RegistrarEmpleado_Click" Text="Registrar" />
                     <asp:Label ID="lblMsj" runat="server" ></asp:Label>
            </div>
</asp:Content>
