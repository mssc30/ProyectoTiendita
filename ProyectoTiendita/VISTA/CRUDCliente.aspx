<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDCliente.aspx.cs" Inherits="ProyectoTiendita.VISTA.CRUDCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre<br />
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            Apellidos<br />
            <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
            <br />
            Dirección<br />
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            <br />
            Telefono<br />
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <br />
            Email<br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            Contraseña<br />
            <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
&nbsp;
            <asp:Button ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Iniciar Sesión" />
&nbsp;<br />
            <br />
            <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar Datos" />
&nbsp;
            <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar Cuenta" />
            <br />
        </div>
    </form>
</body>
</html>
