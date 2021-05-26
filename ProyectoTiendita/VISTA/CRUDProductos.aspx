<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDProductos.aspx.cs" Inherits="ProyectoTiendita.VISTA.CRUDProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">

    <title>CRUD Productos</title>
</head>
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">

        <div class="text-center">
            <table class="table table-dark" width="100%">
              <thead>
                <tr>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnVerPedidos" runat="server" Text="Ver Pedidos" OnClick="btnVerPedidos_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnProductosCRUD" runat="server" Text="Inicio" OnClick="btnProductosCRUD_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnUsersCRUD" runat="server" Text="CRUD usuarios" OnClick="btnUsersCRUD_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnWebServer" runat="server" Text="Indicadores Económicos" OnClick="btnWebServer_Click"/></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Cerrar Sesion" /></th>
                </tr>
              </thead>
            </table>
        </div>

        <h1 class="display-4">Gestión de Productos</h1>
        <hr />

        <asp:ScriptManager ID="MainScriptManager" runat="server"/> 
        <asp:UpdatePanel ID="pnlTabla" runat="server">
        <ContentTemplate>

        <div class="text-center">
            <strong> Nombre</strong><br />
            <asp:TextBox ID="txtNombre" runat="server" MaxLength="39"></asp:TextBox>
            <br />
            <strong>Precio</strong><br />
            <asp:TextBox ID="txtPrecio" runat="server" TextMode="Number" MaxLength="12"></asp:TextBox>
            <br />
            <strong>Estado</strong><br />
            <asp:TextBox ID="txtEstado" runat="server" TextMode="Number" MaxLength="1"></asp:TextBox>
            <br />
            <strong>Imagen</strong><br />
            <asp:TextBox ID="txtFoto" runat="server" MaxLength="500" TextMode="Url"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn btn-success" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
&nbsp;<asp:Button class="btn btn-warning" ID="btnModificar" runat="server" Text="Modificar" Enabled="False" OnClick="btnModificar_Click" />
&nbsp;<asp:Button class="btn btn-danger" ID="btnEliminar" runat="server" Text="Eliminar" Enabled="False" OnClick="btnEliminar_Click" />
&nbsp;<br />            
            <br />
            <strong>ID:</strong>
            <asp:TextBox ID="txtID" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;<asp:Button class="btn btn-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            </div>
            <br />
            <br />
            <div class="text-center">

            
            <asp:GridView align="center" class="table table-sm table-hover align-middle table-responsive" 
                ID="dgvProductos" runat="server" onRowDataBound="dgvProductos_RowDataBound">
            </asp:GridView>

            </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
