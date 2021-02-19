<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="ProyectoTiendita.VISTA.LoginAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuario<br />
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <br />
            Contraseña<br />
            <asp:TextBox ID="txtContra" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkAdmin" runat="server" Text="Administrador" />
            <br />
            <br />
            <asp:Button ID="btnEntrar" runat="server" OnClick="btnEntrar_Click" Text="Iniciar Sesion" />
            &nbsp;<asp:Button ID="btnRegistrarse" runat="server" OnClick="btnRegistrarse_Click" Text="Registrarse" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="-"></asp:Label>
        </div>
    </form>
</body>
</html>
