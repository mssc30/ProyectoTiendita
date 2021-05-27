<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="ProyectoTiendita.VISTA.Pedidos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js" integrity="sha384-SR1sx49pcuLnqZUnnPwx6FCym0wLsk5JZuNx2bPPENzswTNFaQU1RDvt3wT4gWFG" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.min.js" integrity="sha384-j0CNLUeiqtyaRmlzUHCPZ+Gy5fQu0dQ6eZ/xAww941Ai1SxSY+0EQqNXNE6DZiVc" crossorigin="anonymous"></script>


    <title>Pedidos pendientes</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="text-center">
            <table class="table table-dark" width="100%">
              <thead>
                <tr>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnVerPedidos" runat="server" Text="Inicio" OnClick="btnVerPedidos_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnProductosCRUD" runat="server" Text="CRUD productos" OnClick="btnProductosCRUD_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnUsersCRUD" runat="server" Text="CRUD usuarios" OnClick="btnUsersCRUD_Click" /></th>
                  <!-- <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnWebServer" runat="server" Text="Indicadores Económicos" OnClick="btnWebServer_Click"/></th> -->
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Cerrar Sesion" /></th>
                </tr>
              </thead>
            </table>
        </div>

        <h1 class="display-4">Pedidos Pendientes</h1>

        <div class="text-center">

            <asp:GridView align="center" class="table table-sm table-hover align-middle table-responsive" 
                ID="dgvPedidos" runat="server" OnRowCommand="dgvPedidos_RowCommand">
                <Columns>
                    <asp:BoundField HtmlEncode="False"/>
                </Columns>
            </asp:GridView>
            <br />
        </div>

        <h1 class="display-4">Pedidos Entregados</h1>

        <div class="text-center">

            <asp:GridView align="center" class="table table-sm table-hover align-middle table-responsive" 
                ID="dgvEntregados" runat="server">
                <Columns>
                    <asp:BoundField HtmlEncode="False"/>
                </Columns>
            </asp:GridView>

            <br />
        </div>
    </form>
</body>
</html>
