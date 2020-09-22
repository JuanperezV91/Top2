<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="RegistroSalud.aspx.cs" Inherits="Proyect.WEB.RegistroSalud" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
     <div class="container register">       

                    <div class="col-md-12 register-right">                      
                        <div class="tab-content" id="myTabContent">
                            <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                                <h3 class="register-heading">Registro Salud</h3>

                                <div class="row register-form">

                                    <div class="col-md-12">
                                         <asp:TextBox ID="txtNombre" runat="server" type="text" class="form-control col-md-5"></asp:TextBox>

                                        <div class="form-group col-md-12">
                                             <label for="txtTemperatura" class="control-label col-md-5">Temperatura</label>
                                            <asp:TextBox ID="txttemperatura" runat="server" type="text" class="form-control col-md-5" placeholder="Ingrese Temperatura *"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-12">
                                           <label for="chkTosSec" class="control-label col-md-7">Tiene tos seca?</label>
                                              <asp:CheckBox ID="chkTosSec" ClientIDMode="Static" runat="server" />
                                        </div> 

                                        <div class="form-group col-md-12">
                                           <label for="chkDifRes" class="control-label col-md-7">Tiene dificultades para respirar?</label>
                                              <asp:CheckBox ID="chkDifRes" ClientIDMode="Static" runat="server" />
                                        </div> 

                                         <div class="form-group col-md-12">
                                           <label for="chkRespRa" class="control-label col-md-7">Tiene respiración rápida?</label>
                                              <asp:CheckBox ID="chkRespRa" ClientIDMode="Static" runat="server" />
                                        </div> 
                                        
                                          <div class="form-group col-md-12">
                                           <label for="chkFle" class="control-label col-md-7">Tiene flema amarilla verdosa?</label>
                                              <asp:CheckBox ID="chkFle" ClientIDMode="Static" runat="server" />
                                        </div> 

                                          <div class="form-group col-md-12">
                                           <label for="chkDif" class="control-label col-md-7">Tiene dificultades para tragar?</label>
                                              <asp:CheckBox ID="chkDif" ClientIDMode="Static" runat="server" />
                                        </div> 

                                          <div class="form-group col-md-12">
                                           <label for="chkCansf" class="control-label col-md-7">Presenta cansancio y fatiga?</label>
                                              <asp:CheckBox ID="chkCansf" ClientIDMode="Static" runat="server" />
                                        </div> 

                                          <div class="form-group col-md-12">
                                           <label for="chkDolms" class="control-label col-md-7">Tiene dolores musculares?</label>
                                              <asp:CheckBox ID="chkDolms" ClientIDMode="Static" runat="server" />
                                        </div> 

                                          <div class="form-group col-md-12">
                                           <label for="chkDolts" class="control-label col-md-7">Siente dolor en el torax?</label>
                                              <asp:CheckBox ID="chkDolts" ClientIDMode="Static" runat="server" />
                                        </div> 

                                          <div class="form-group col-md-12">
                                           <label for="chkTest" class="control-label col-md-7">Resultado test rápido?</label>
                                              <asp:CheckBox ID="chkTest" ClientIDMode="Static" runat="server" />
                                        </div>              
                                        
                                         <asp:TextBox ID="txtIdEmpleado" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>

                                        <asp:TextBox ID="txtIdUser" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
                                        <asp:TextBox ID="txtIdPersona" runat="server" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
                                       
                                    </div>
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:Button ID="btnRegistro" class="btn btn-primary btn-block" runat="server" OnClick="buttonRegistro_Salud" Text="Ver Resultados" />
                     <asp:Label ID="lblMsj" runat="server" ></asp:Label>
                                  <script>
                                      var elem = document.getElementById('<%=chkTosSec.ClientID%>');
                                      var init = new Switchery(elem, {
                                          color: '#6610f2'
                                          , jackColor: '#fff'
                                          , speed: '1s'
                                      });

                                      var elem2 = document.getElementById('<%=chkDifRes.ClientID%>');
                                      var init2 = new Switchery(elem2, {
                                          color: '#6610f2'
                                          , jackColor: '#fff'
                                          , speed: '1s'
                                      });

                                      var elem3 = document.getElementById('<%=chkRespRa.ClientID%>');
                                      var init3 = new Switchery(elem3, {
                                          color: '#6610f2'
                                          , jackColor: '#fff'
                                          , speed: '1s'
                                      });

                                      var elem4 = document.getElementById('<%=chkFle.ClientID%>');
                                      var init4 = new Switchery(elem4, {
                                          color: '#6610f2'
                                          , jackColor: '#fff'
                                          , speed: '1s'
                                      });

                                      var elem5 = document.getElementById('<%=chkDif.ClientID%>');
                                      var init5 = new Switchery(elem5, {
                                          color: '#6610f2'
                                          , jackColor: '#fff'
                                          , speed: '1s'
                                      });

                                      var elem6 = document.getElementById('<%=chkCansf.ClientID%>');
                                      var init6 = new Switchery(elem6, {
                                          color: '#6610f2'
                                          , jackColor: '#fff'
                                          , speed: '1s'
                                      });

                                      var elem7 = document.getElementById('<%=chkDolms.ClientID%>');
                                      var init7 = new Switchery(elem7, {
                                          color: '#6610f2'
                                          , jackColor: '#fff'
                                          , speed: '1s'
                                      });

                                      var elem8 = document.getElementById('<%=chkDolts.ClientID%>');
                                      var init8 = new Switchery(elem8, {
                                          color: '#6610f2'
                                          , jackColor: '#fff'
                                          , speed: '1s'
                                      });

                                      var elem9 = document.getElementById('<%=chkTest.ClientID%>');
                                      var init9 = new Switchery(elem9, {
                                          color: '#6610f2'
                                          , jackColor: '#fff'
                                          , speed: '1s'
                                      });

                

                 
                                       </script>
            </div>        
</asp:Content>
