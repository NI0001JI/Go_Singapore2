<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Go_Singapore.Views.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
	<meta charset="UTF-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="loginassets/images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="loginassets/vendor/bootstrap/css/bootstrap.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="loginassets/fonts/font-awesome-4.7.0/css/font-awesome.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="loginassets/fonts/Linearicons-Free-v1.0.0/icon-font.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="loginassets/vendor/animate/animate.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="loginassets/vendor/css-hamburgers/hamburgers.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="loginassets/vendor/animsition/css/animsition.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="loginassets/vendor/select2/select2.min.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="loginassets/vendor/daterangepicker/daterangepicker.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="loginassets/css/util.css"/>
	<link rel="stylesheet" type="text/css" href="loginassets/css/main.css"/>
<!--===============================================================================================-->
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100 p-l-85 p-r-85 p-t-55 p-b-55">
				<span class="login100-form validate-form flex-sb flex-w">
					<span class="login100-form-title p-b-32">
						Registration
					</span>

					<span class="txt1 p-b-11">
						Name
					</span>
					<div class="wrap-input100 validate-input m-b-36" data-validate = "Name is required">
                        <asp:TextBox ID="txtName" placeholder="Name" CssClass="input100" runat="server" OnTextChanged="txtUsername_TextChanged"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
                   
                    <span class="txt1 p-b-11">
						Username
					</span>
					<div class="wrap-input100 validate-input m-b-36" data-validate = "Username is required">
                        <asp:TextBox ID="txtUsername" placeholder="Username" CssClass="input100" runat="server" OnTextChanged="txtUsername_TextChanged"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
                   
                    <span class="txt1 p-b-11">
						Email
					</span>
					<div class="wrap-input100 validate-input m-b-36" data-validate = "Email is required">
                        <asp:TextBox ID="txtEmail" placeholder="Email" CssClass="input100" runat="server" OnTextChanged="txtUsername_TextChanged"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
					
                    <span class="txt1 p-b-11">
						Password
					</span>
					<div class="wrap-input100 validate-input m-b-12" data-validate = "Password is required">
						<span class="btn-show-pass">
							<i class="fa fa-eye"></i>
						</span>
                        <asp:TextBox ID="txtPassword" TextMode="Password" placeholder="Password" CssClass="input100" runat="server" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
                    
                    <div class="wrap-input100 validate-input m-b-12" data-validate = "Please confirm your password">
						<span class="btn-show-pass">
							<i class="fa fa-eye"></i>
						</span>
                        <asp:TextBox ID="txtPasswordConfirm" TextMode="Password" placeholder="Confirm your password" CssClass="input100" runat="server" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
					
                    <div>

                    </div>
                    

					<div class="container-login100-form-btn">
						<button class="login100-form-btn">
							<asp:Button ID="btnRegister" CssClass="login100-form-btn" runat="server" Text="Register" OnClick="btnRegister_Click" />
						</button>
					</div>
                    <div>
                        <asp:Label ID="Label1" runat="server" Text="StatusCheck"></asp:Label>
                    </div>
                    

				</span>
			</div>
		</div>
	</div>
	

	<div id="dropDownSelect1"></div>
	
<!--===============================================================================================-->
	<script src="loginassets/vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="loginassets/vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="loginassets/vendor/bootstrap/js/popper.js"></script>
	<script src="loginassets/vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="loginassets/vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="loginassets/vendor/daterangepicker/moment.min.js"></script>
	<script src="loginassets/vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="loginassets/vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="loginassets/js/main.js"></script>
        </div>
    </form>
</body>
</html>
