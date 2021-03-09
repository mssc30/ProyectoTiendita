<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="ProyectoTiendita.VISTA.Pedidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="REGISTRO DE PEDIDOS"></asp:Label>
            <br />
            <asp:GridView ID="dgvPedidos" runat="server" Height="50px" OnRowCommand="dgvPedidos_RowCommand">
                <Columns>
                    <asp:BoundField HtmlEncode="False"/>
                </Columns>
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
