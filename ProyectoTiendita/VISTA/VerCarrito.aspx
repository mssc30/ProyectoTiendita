<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerCarrito.aspx.cs" Inherits="ProyectoTiendita.VISTA.VerCarrito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js" integrity="sha384-SR1sx49pcuLnqZUnnPwx6FCym0wLsk5JZuNx2bPPENzswTNFaQU1RDvt3wT4gWFG" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.min.js" integrity="sha384-j0CNLUeiqtyaRmlzUHCPZ+Gy5fQu0dQ6eZ/xAww941Ai1SxSY+0EQqNXNE6DZiVc" crossorigin="anonymous"></script>

    <title>Mi Carrito</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="text-center">
            <table class="table table-dark" width="100%">
              <thead>
                <tr>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnPedido" runat="server" Text="Inicio" OnClick="btnPedido_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnPerfil" runat="server" Text="Perfil" OnClick="btnPerfil_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Iniciar Sesion" /></th>
                </tr>
              </thead>
            </table>
        </div>

        <img src="https://i.ibb.co/D9bZjPk/carrito.png" width="100%" alt="Abarrotes"><br />

        <div>
            <asp:Label class="display-4" ID="Label1" runat="server" Text="Detalles del Pedido"></asp:Label>
            <br />

             <div class="text-center">

            <asp:ScriptManager ID="MainScriptManager" runat="server"/>
            <asp:UpdatePanel ID="pnlTabla" runat="server">
            <ContentTemplate>
                <asp:GridView class="table table-hover align-middle table-responsive" ID="dgvPedido" runat="server" OnRowDataBound="dgv_RowDataBound">
            </asp:GridView>
            </ContentTemplate>
            </asp:UpdatePanel>

            <br />
            <asp:Label  ID="Label2" runat="server" Text="-" Font-Bold="True"></asp:Label>
            <br />
            <asp:Button class="btn btn-success" ID="btnConfirmar" runat="server" Text="Confirmar Pedido" OnClick="btnConfirmar_Click" />
      &nbsp;<asp:Button class="btn btn-danger" ID="btnCancelar" runat="server" Text="Cancelar Pedido" OnClick="btnCancelar_Click" />
                &nbsp;
                 <br />
        </div>
            </div>
    </form>
</body>
</html>
