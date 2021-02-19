<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDProductos.aspx.cs" Inherits="ProyectoTiendita.VISTA.CRUDProductos" %>

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
            Precio<br />
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            <br />
            Estado<br />
            <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
            <br />
            Fotografia<br />
            <asp:TextBox ID="txtFoto" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
&nbsp;<asp:Button ID="btnModificar" runat="server" Text="Modificar" Enabled="False" OnClick="btnModificar_Click" />
&nbsp;<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Enabled="False" OnClick="btnEliminar_Click" />
&nbsp;<br />
            <br />
            ID
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />
            <asp:GridView ID="dgvProductos" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
