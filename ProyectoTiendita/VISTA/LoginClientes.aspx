<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginClientes.aspx.cs" Inherits="ProyectoTiendita.VISTA.LoginClientes" %>

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
            <asp:TextBox ID="txtContra" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="-" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
