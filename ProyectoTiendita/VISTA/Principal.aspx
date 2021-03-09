<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ProyectoTiendita.VISTA.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
&nbsp;<asp:Button ID="btnVerPedidos" runat="server" Text="Ver Pedidos" OnClick="btnVerPedidos_Click" />
&nbsp;<asp:Button ID="btnProductosCRUD" runat="server" Text="CRUD productos" OnClick="btnProductosCRUD_Click" />
&nbsp;<asp:Button ID="btnUsersCRUD" runat="server" Text="CRUD usuarios" OnClick="btnUsersCRUD_Click" />
&nbsp;<asp:Button ID="btnPedido" runat="server" Text="Hacer Pedido" OnClick="btnPedido_Click" />
&nbsp;<asp:Button ID="btnPerfil" runat="server" Text="Perfil" OnClick="btnPerfil_Click" />
&nbsp;<asp:Button ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Iniciar Sesion" />
            <br />
        </div>
        <br />
        PRODUCTOS<br />
        <asp:GridView ID="dgvProductos" runat="server" OnRowCommand="dgvProductos_RowCommand">
        </asp:GridView>
        <br />
    </form>
</body>
</html>
