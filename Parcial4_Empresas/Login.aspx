<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<link href="estilo.css" rel="stylesheet" />
<!DOCTYPE html>
<html>
<head>
    <title>Formulário de login HTML/CSS</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width">
    <link rel="stylesheet" href="css/estilo.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-box">
            <h1>Login</h1>
            <div class="textbox">
                <i class="fa fa-user" aria-hidden="true"></i>
                <input type="text" placeholder="Usuario" name="user" value="">
            </div>

            <div class="textbox">
                <i class="fa fa-lock" aria-hidden="true"></i>
                <input type="password" placeholder="Contraseña" name="pass" value="">
            </div>
            <asp:Button ID="Button1" class="btn" runat="server" Text="Ingresar" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
