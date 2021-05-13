<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ProyectoTiendita.VISTA.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js" integrity="sha384-SR1sx49pcuLnqZUnnPwx6FCym0wLsk5JZuNx2bPPENzswTNFaQU1RDvt3wT4gWFG" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.min.js" integrity="sha384-j0CNLUeiqtyaRmlzUHCPZ+Gy5fQu0dQ6eZ/xAww941Ai1SxSY+0EQqNXNE6DZiVc" crossorigin="anonymous"></script>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>Tu Tiendita</title>

</head>

<body>
    <form id="form1" runat="server">
        
        <div class="text-left">
            <table class="table table-dark" width="100%">
              <thead>
                <tr>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnVerPedidos" runat="server" Text="Ver Pedidos" OnClick="btnVerPedidos_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnProductosCRUD" runat="server" Text="CRUD productos" OnClick="btnProductosCRUD_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnUsersCRUD" runat="server" Text="CRUD usuarios" OnClick="btnUsersCRUD_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnPedido" runat="server" Text="Ver Carrito" OnClick="btnPedido_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnPerfil" runat="server" Text="Perfil" OnClick="btnPerfil_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Iniciar Sesion" /></th>
                </tr>
              </thead>
            </table>
        </div>

         <img src="https://i.ibb.co/NSSf0dn/Header-8.jpg" width="100%" alt="Abarrotes"><br />
        <h1 class="display-4">Lista de Productos</h1>

        <div class="text-center">
            <!--PARA IMPLEMENTAR AJAX SE HACE USO DE COMPONENTES QUE NOS BRINDA ASP, LO QUE ES SCRIPT MANAGER Y UPDATE PANEL
                Y LA FUNCIONALIDAD DE ESTOS, ES QUE TODO LO QUE HAYA EN EL UPDATE PANEL SE CARGA ASINCRONICAMENTE, EN ESTE CASO
                LA TABLA DE PRODUCTOS CON EL BOTON DE AÑADIR AL CARRITO.-->
            <asp:ScriptManager ID="MainScriptManager" runat="server"/>
                <asp:UpdatePanel ID="pnlTabla" runat="server">
                    <ContentTemplate>
                        <asp:GridView align="center" class="table table-hover align-middle table-responsive"
                            ID="dgvProductos" runat="server" OnRowCommand="dgvProductos_RowCommand" onRowDataBound="dgvProductos_RowDataBound" >
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>

        </div>
        <br />
    </form>
</body>
</html>
