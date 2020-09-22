<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyect.WEB.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Iniciar Sesión</title>
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
						Bienvenido
					</span>
					<div class="text-center">
						<img class="mb-7" src="images/healthIcon.png" alt="" width="90" height="90" />
					</div>	
					<span class="login100-form-title p-b-49">						
					</span>								
				
					<div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere su nombre de usuario">
						<span class="label-input100">Nombre de Usuario</span>
						 <asp:TextBox ID="txtUsername"  class="input100" placeholder="Escriba su Nombre de Usuario" runat="server"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Se requiere su contraseña">
						<span class="label-input100">Contraseña</span>
					    <asp:TextBox ID="txtPassword"  class="input100" placeholder="Escriba su Contraseña" TextMode="Password" runat="server"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf190;"></span>
					</div>
					
					<div class="flex-sb-m w-full p-t-3 p-b-32">
						<div class="contact100-form-checkbox" width="72" height="72" >
							 <asp:CheckBox ID="ChkSession" runat="server" class="input-checkbox100" />
							 <asp:Label ID="lblRecordar"  for="ChkSession" class="label-checkbox100" runat="server" Text="Recordar"></asp:Label>
							 <asp:TextBox ID="txtIdLog" runat="server" class="txt2" Enabled="False" EnableViewState="False" Visible="False"></asp:TextBox>
						
						</div>

						<div>
							<a href="ForgotPass.aspx" class="txt1">
								Olvidó su Contraseña?
							</a>
						</div>
					</div>
					
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<asp:Button ID="btnIngresar" runat="server" class="login100-form-btn" Text="Ingresar" OnClick="btnIngresar_Click" BackColor="#00004A" />
												
							<asp:Label ID="lblMsj" class="txt2" runat="server" Text=""></asp:Label>

						</div>
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
