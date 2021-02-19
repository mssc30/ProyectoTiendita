<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerCarrito.aspx.cs" Inherits="ProyectoTiendita.VISTA.VerCarrito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Detalles del Pedido"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Pedido" />
&nbsp;<asp:Button ID="btnCancelar" runat="server" Text="Cancelar Pedido" />
        </div>
    </form>
</body>
</html>
