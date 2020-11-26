<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OperacionLaboratorios.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous"/>
    <link rel="stylesheet" href="estilos.css" />
    <script src="https://kit.fontawesome.com/d9db2b63d9.js" crossorigin="anonymous"></script>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container text-center">
            
            <h1 class="text-center"> <i class="fas fa-user"></i>&nbsp;Login</h1>
            <hr />
            <div class="jumbotron jumbostyle">
                <br />
                <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label Text="Cuenta: " runat="server" /> 
            &nbsp; 
            <asp:TextBox runat="server" id="txtCuenta"/>
                <br />
            <br />
            <asp:Label Text="Contraseña: " runat="server" /> 
            &nbsp; 
            <asp:TextBox runat="server" id="txtContrasena" TextMode="Password"/>

            <br />
            <br />
            <br />

            <asp:Button class="btn btn-dark" ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingresar" />
                <br />
            <br />
            <asp:Label Text="Cuenta o contraseña incorrecta " runat="server" id="lblError" /> 
            <asp:Label Text="FUNCIONA" runat="server" id="LblFunciona" /> 
                <br />
                </div>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
