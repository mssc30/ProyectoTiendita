<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDCliente.aspx.cs" Inherits="ProyectoTiendita.VISTA.CRUDCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js" integrity="sha384-SR1sx49pcuLnqZUnnPwx6FCym0wLsk5JZuNx2bPPENzswTNFaQU1RDvt3wT4gWFG" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.min.js" integrity="sha384-j0CNLUeiqtyaRmlzUHCPZ+Gy5fQu0dQ6eZ/xAww941Ai1SxSY+0EQqNXNE6DZiVc" crossorigin="anonymous"></script>

    <title>Clientes</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="text-center">
            <table class="table table-dark" width="100%">
              <thead>
                <tr>
                  
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnPedido" runat="server" Text="Ver Carrito" OnClick="btnPedido_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnPerfil" runat="server" Text="Inicio" OnClick="btnPerfil_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="Button1" runat="server" OnClick="btnIniciarSesion_Click" Text="Iniciar Sesion" /></th>
                </tr>
              </thead>
            </table>
        </div>

         <img src="https://i.ibb.co/M75FSZp/Header.png" width="100%" alt="Abarrotes"><br />
         <h1 class="display-4">Mi Perfil</h1>


         <div>
             <div class="form-floating mb-3" >
                <asp:TextBox ID="txtNombre" class="form-control col-lg-4 "  placeholder="Nombre" runat="server" ></asp:TextBox>
                <label for="txtUser">Nombre</label>
            </div>

            <div class="form-floating mb-3" >
            <asp:TextBox ID="txtApellidos" class="form-control col-lg-4 " placeholder="Apellidos" runat="server"></asp:TextBox>
            <label for="txtApellidos">Apellidos</label>
            </div>

             <div class="form-floating mb-3" >
            <asp:TextBox ID="txtDireccion" class="form-control col-lg-4 " placeholder="Direccion" runat="server"></asp:TextBox>
            <label for="txtDireccion">Direccion</label>
            </div>

                 <div class="form-floating mb-3" >
            <asp:TextBox ID="txtTelefono" class="form-control col-lg-4 " placeholder="Telefono" runat="server"></asp:TextBox>
            <label for="txtTelefono">Telefono</label>
            </div>

                     <div class="form-floating mb-3" >
            <asp:TextBox ID="txtEmail" class="form-control col-lg-4 " placeholder="Email" runat="server"></asp:TextBox>
            <label for="txtEmail">Email</label>
            </div>

            <div class="form-floating mb-3" >
            <asp:TextBox ID="txtContrasena" class="form-control col-lg-4 " placeholder="Contrasena"  runat="server"></asp:TextBox>
            <label for="txtContrasena">Contrasena</label>
            </div>

            <br />

             <div class="text-center">

            <asp:Button class="btn btn-success" ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
&nbsp;
            <asp:Button class="btn btn-info" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Iniciar Sesión" />
&nbsp;<asp:Button class="btn btn-success" ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar Datos" />
&nbsp;
            <asp:Button class="btn btn-danger" ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar Cuenta" />
             &nbsp;
                 <br />
                 </div>
            <br />
        </div>
    </form>
</body>
</html>
