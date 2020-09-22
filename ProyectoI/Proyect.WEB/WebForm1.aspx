<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proyect.WEB.WebForm1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container register">                    
                    <div class="col-md-12 register-right">                      
                        <div class="tab-content" id="myTabContent">
                            <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                <h3 class="register-heading">Registro Salud</h3>
                                <div class="row register-form">
                                    <div class="col-md-8">

                                        <label for="txtTemperatura" class="control-label">Temperatura</label>
                                        <div class="form-group">
                                            <asp:TextBox ID="txttemperatura" runat="server" type="text" class="form-control" placeholder="Ingrese Temperatura *"></asp:TextBox>
                                        </div>

                                         
                                       <div class="form-group">
                                            <label for="myTab" class="control-label ">Tiene tos seca?</label>

                                            <ul class="nav nav-tabs nav-justified" id="myTab" role="tablist">
                                                <li class="nav-item">
                                                    <a class="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">Si</a>
                                                </li>
                                                <li class="nav-item">
                                                    <a class="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">No</a>
                                                </li>
                                            </ul>   
                                       </div>
                                        
                                        <label for="myTab2" class="control-label">Tiene dificultades para respirar?</label>
                                        <div class="form-group">
                                            <ul class="nav nav-tabs nav-justified"  id="myTab2" role="tablist">
                                                <li class="nav-item">
                                                    <a class="nav-link active"  data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">Si</a>
                                                </li>
                                                <li class="nav-item">
                                                    <a class="nav-link"  data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">No</a>
                                                </li>
                                            </ul>   
                                       </div>

                                        <label for="myTab2" class="control-label">Tiene respiración rápida?</label>                                         
                                        <div class="form-group">
                                            <ul class="nav nav-tabs nav-justified"  id="myTab3" role="tablist">
                                                <li class="nav-item">
                                                    <a class="nav-link active"  data-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">Si</a>
                                                </li>
                                                <li class="nav-item">
                                                    <a class="nav-link" data-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">No</a>
                                                </li>
                                            </ul>   
                                       </div>
<asp:CheckBox ID="CheckBox1" type="switch" runat="server" />
                                        <label for="myTab2" class="control-label">Tiene flema amarilla verdosa?</label>                                         
                                        <label for="myTab2" class="control-label">Tiene dificultades para tragar?</label>  
                                        <label for="myTab2" class="control-label">Presenta cansancio y fatiga?</label>                                         
                                        <label for="myTab2" class="control-label">Tiene flema amarilla verdosa?</label>                                         
                                        <label for="myTab2" class="control-label">Tiene dolores musculares?</label>                                         
                                        <label for="myTab2" class="control-label">Siente dolor en el torax?</label>                                         
                                        <label for="myTab2" class="control-label">Resultado test rápido?</label>                                         


                                        
                                       
                                      
                                      

                                       

                                        <asp:TextBox ID="txtIdUser" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
                                        <asp:TextBox ID="txtIdPersona" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:Button ID="btnRegistro" class="btn btn-primary btn-block" runat="server" OnClick="buttonRegistro_Salud" Text="Ver Resultados" />
                     <asp:Label ID="lblMsj" runat="server" ></asp:Label>
            </div>        
</asp:Content>
