<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPass.aspx.cs" Inherits="Proyect.WEB.ForgotPass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Recuperar Contraseña</title>
	<meta charset="UTF-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/bootstrap/css/bootstrap.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/iconic/css/material-design-iconic-font.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animate/animate.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/css-hamburgers/hamburgers.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/animsition/css/animsition.min.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendor/select2/select2.min.css">
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="vendor/daterangepicker/daterangepicker.css">
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css-lg/util.css">
	<link rel="stylesheet" type="text/css" href="css-lg/main.css">
<!--===============================================================================================-->
</head>
<body>
    <form id="form1" runat="server">
           <div class="limiter">
		<div class="container-login100" style="background-image: url('images/covidBackground.jpg');">
			<div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
				<form class="login100-form validate-form">
					<span class="login100-form-title p-b-49 txt1">
						<asp:Label ID="lblMail" runat="server" Text="Recuperar Contraseña"></asp:Label>

					</span>
					<div class="text-center">
						<img class="mb-7" src="images/healthIcon.png" alt="" width="90" height="90" />
					</div>	
					<span class="login100-form-title p-b-49">						
					</span>								
				
					<div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere su nombre de usuario">
						<span class="label-input100">Correo</span>
						 <asp:TextBox ID="txtEmail"  class="input100" placeholder="Escriba su Correo" runat="server"></asp:TextBox>
						 <asp:RequiredFieldValidator ID="RequiredValidatorEmail"  CssClass="text-danger" runat="server" ErrorMessage="Por favor escriba su correo" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>

						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

					<div class="flex-sb-m w-full p-t-3 p-b-32"></div>
					
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							 <asp:Button ID="btnRecuperar" class="login100-form-btn"  runat="server" Text="Enviar Solicitud" OnClick="btnRecuperar_Click" BackColor="#00004A" />
						</div>
						<asp:Label ID="lblMsj" runat="server" Text=""></asp:Label>		
					</div>
					
				</form>
			</div>
		</div>
	</div>
	

	<div id="dropDownSelect1"></div>
	
<!--===============================================================================================-->
	<script src="vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/bootstrap/js/popper.js"></script>
	<script src="vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="vendor/daterangepicker/moment.min.js"></script>
	<script src="vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>
			   		 	  	  	   
    </form>
</body>
</html>
