<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDUsuarios.aspx.cs" Inherits="ProyectoTiendita.VISTA.CRUDUsuarios" %>

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
            <asp:TextBox ID="txtNombre" runat="server" Width="199px"></asp:TextBox>
            <br />
            Apellidos<br />
            <asp:TextBox ID="txtApellidos" runat="server" Width="198px"></asp:TextBox>
            <br />
            Telefono<br />
            <asp:TextBox ID="txtTelefono" runat="server" Width="197px"></asp:TextBox>
            <br />
            Usuario<br />
            <asp:TextBox ID="txtUsuario" runat="server" Width="195px"></asp:TextBox>
            <br />
            Contraseña<br />
            <asp:TextBox ID="txtContrasena" runat="server" Width="192px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
&nbsp;<asp:Button ID="btnActualizar" runat="server" Text="Modificar" Enabled="False" OnClick="btnActualizar_Click" />
&nbsp;<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Enabled="False" OnClick="btnEliminar_Click" />
&nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:GridView ID="dgvUsuarios" runat="server">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
