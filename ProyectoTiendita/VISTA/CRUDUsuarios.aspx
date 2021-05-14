<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDUsuarios.aspx.cs" Inherits="ProyectoTiendita.VISTA.CRUDUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js" integrity="sha384-SR1sx49pcuLnqZUnnPwx6FCym0wLsk5JZuNx2bPPENzswTNFaQU1RDvt3wT4gWFG" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.min.js" integrity="sha384-j0CNLUeiqtyaRmlzUHCPZ+Gy5fQu0dQ6eZ/xAww941Ai1SxSY+0EQqNXNE6DZiVc" crossorigin="anonymous"></script>

    <title>CRUD Usuarios</title>
</head>
<body>
    <form id="form1" runat="server">
       
            <div class="text-center">
            <table class="table table-dark" width="100%">
              <thead>
                <tr>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnVerPedidos" runat="server" Text="Ver Pedidos" OnClick="btnVerPedidos_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnProductosCRUD" runat="server" Text="CRUD productos" OnClick="btnProductosCRUD_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnUsersCRUD" runat="server" Text="Inicio" OnClick="btnUsersCRUD_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnWebServer" runat="server" Text="Indicadores Económicos" OnClick="btnWebServer_Click"/></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Cerrar Sesion" /></th>
                </tr>
              </thead>
            </table>
        </div>

        <h1 class="display-4">Gestión de Usuarios</h1>
        <hr />

        <asp:ScriptManager ID="MainScriptManager" runat="server"/>
        <asp:UpdatePanel ID="pnlTabla" runat="server">
        <ContentTemplate>
    
        <div class="text-center">
            <strong>Nombre</strong><br />
            <asp:TextBox ID="txtNombre" runat="server" Width="199px"></asp:TextBox>
            <br />
            <strong>Apellidos</strong><br />
            <asp:TextBox ID="txtApellidos" runat="server" Width="198px"></asp:TextBox>
            <br />
            <strong>Telefono</strong><br />
            <asp:TextBox ID="txtTelefono" runat="server" Width="197px"></asp:TextBox>
            <br />
            <strong>Usuario</strong><br />
            <asp:TextBox ID="txtUsuario" runat="server" Width="195px"></asp:TextBox>
            <br />
            <strong>Contraseña</strong><br />
            <asp:TextBox ID="txtContrasena" runat="server" Width="192px" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn btn-success" ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
&nbsp;<asp:Button class="btn btn-warning" ID="btnActualizar" runat="server" Text="Modificar" Enabled="False" OnClick="btnActualizar_Click" />
&nbsp;<asp:Button class="btn btn-danger" ID="btnEliminar" runat="server" Text="Eliminar" Enabled="False" OnClick="btnEliminar_Click" />
&nbsp;<asp:Button class="btn btn-primary" ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <br />
            <br />

            </div>
            <div class="text-center">

            <asp:GridView align="center" class="table table-sm table-hover align-middle table-responsive" ID="dgvUsuarios" runat="server">
            </asp:GridView>
            
            </ContentTemplate>
            </asp:UpdatePanel>

            <br />
        </div>
    </form>
</body>
</html>
