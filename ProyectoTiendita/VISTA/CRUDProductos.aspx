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
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Precio<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Estado<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Fotografia<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" />
&nbsp;<asp:Button ID="btnModificar" runat="server" Text="Modificar" />
&nbsp;<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
&nbsp;<br />
            <br />
            ID
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
