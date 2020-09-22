<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="Proyect.WEB.RegistrarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container register">                    
                    <div class="col-md-12 register-right">
                        <ul class="nav nav-tabs nav-justified" id="myTab" role="tablist">
                            <li class="nav-item">
                                <a class="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">Admin</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">Normal</a>
                            </li>
                        </ul>
                        <div class="tab-content" id="myTabContent">
                            <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                <h3 class="register-heading">Rol Administrador</h3>
                                <div class="row register-form">
                                    <div class="col-md-8">

                                        <label for="txtNomUsuario" class="control-label">Nombre</label>
                                        <div class="form-group">
                                            <asp:TextBox ID="txtNomUsuario" runat="server" type="text" class="form-control" placeholder="ingrese Nombre *"></asp:TextBox>
                                        </div>
                                        <label for="txtApPaterno" class="control-label">Apellido Paterno</label>
                                        <div class="form-group">
                                            <asp:TextBox ID="txtApPaterno" runat="server" type="text" class="form-control" placeholder="Ingrese Apellido Paterno *"></asp:TextBox>
                                        </div>
                                        <label for="txtApMaterno" class="control-label">Apellido Materno</label>
                                        <div class="form-group">
                                            <asp:TextBox ID="txtApMaterno" runat="server" type="text" class="form-control" placeholder="Ingrese Apellido Materno *"></asp:TextBox>
                                        </div>
                                        <label for="txtRut" class="control-label">RUT</label>
                                         <div class="form-group">
                                            <asp:TextBox ID="txtRut" runat="server" type="text" class="form-control" placeholder="Ingrese RUT *"></asp:TextBox>
                                        </div>
                                        <label for="txtEmail" class="control-label">Correo</label>
                                         <div class="form-group">
                                            <asp:TextBox ID="txtEmail" runat="server" type="text" class="form-control" placeholder="Ingrese Correo *"></asp:TextBox>
                                        </div>
                                        <label for="txtPass" class="control-label">Contraseña</label>
                                         <div class="form-group">
                                            <asp:TextBox ID="txtPass" runat="server" type="Password" class="form-control" placeholder="Ingrese Contraseña *"></asp:TextBox>
                                        </div>
                                        <label for="txtCPass" class="control-label">Confirmar Contraseña</label>
                                         <div class="form-group">
                                            <asp:TextBox ID="txtCPass" runat="server" type="Password" class="form-control" placeholder="Ingrese Contraseña Nuevamente *"></asp:TextBox>
                                        </div>
                                        
                                         <label class="control-label">Rol de Usuario</label>

                                        <div class="form-group">
                                            <div class="maxl">
                                                <label class="radio inline"> 
                                                   <asp:RadioButton ID="rbtnAdmin" type="radio"  name="rol" runat="server" GroupName="GroupUsers" />

                                                    <span> Administrador </span> 
                                                </label>
                                                <label class="radio inline"> 
                                                   <asp:RadioButton ID="rbtnUser" type="radio"  name="rol" runat="server" GroupName="GroupUsers" />
                                                    <span>Usuario Simple 
                                                </span> 
                                                </label>
                                            </div>
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

                                        <asp:TextBox ID="txtIdUser" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
                                        <asp:TextBox ID="txtIdPersona" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:Button ID="Button1" class="btn btn-primary btn-block" runat="server" OnClick="Button1_Click" Text="Registrar" />
                     <asp:Label ID="lblMsj" runat="server" ></asp:Label>
            </div>                            
</asp:Content>
