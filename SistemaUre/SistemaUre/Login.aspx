<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaUre.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>URE | Inicio Sesion </title>
    <link rel="stylesheet" href="Recursos/css/login/style.css">
</head>
<body background="Recursos/images/fondo.jpg">
    <form id="form1" runat="server">
        
    <div class="loginBox">
			<img src="Recursos/images/Login/user.png" class="user">
			<h2>Inicio de Sesion</h2>
			<form>
				<p>ID USUARIO</p>
                <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
				<p>CONTRASEÑA</p>
                <asp:TextBox ID="txtcontrasena" runat="server" TextMode="Password" ></asp:TextBox>
                <asp:Button ID="inicia_Sesion" runat="server" Text="INGRESAR" OnClick="inicia_Sesion_Click" />
				<a href="#">OLVIDASTE CONTRASEÑA</a>
			</form>
		</div>
    </form>
</body>
</html>
<%--  --%>