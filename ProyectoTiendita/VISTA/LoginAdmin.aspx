<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="ProyectoTiendita.VISTA.LoginAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.bundle.min.js" integrity="sha384-JEW9xMcG8R+pH31jmWH6WWP0WintQrMb4s7ZOdauHnUtxwoG2vI5DkLtS3qm9Ekf" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js" integrity="sha384-SR1sx49pcuLnqZUnnPwx6FCym0wLsk5JZuNx2bPPENzswTNFaQU1RDvt3wT4gWFG" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/js/bootstrap.min.js" integrity="sha384-j0CNLUeiqtyaRmlzUHCPZ+Gy5fQu0dQ6eZ/xAww941Ai1SxSY+0EQqNXNE6DZiVc" crossorigin="anonymous"></script>

    <title>Iniciar Sesión</title>
</head>
<body>
      <form id="form1" runat="server" >

    <div class="text-center">
            <table class="table table-dark" width="100%">
              <thead>
                <tr>
                  <th scope="col"><asp:Button class="btn btn-outline-light" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Inicio" /></th>
                </tr>
              </thead>
            </table>
        </div>

     <img src="https://i.ibb.co/1TQFxZf/2.png" width="100%" alt="Abarrotes"><br />

            <h1 class="display-4">Iniciar Sesión</h1>

  
        
            <div class="text-center" >

            <div class="form-floating mb-3" >
                <asp:TextBox padding="220px" ID="txtUser" class="form-control col-lg-4 " placeholder="name@example.com" runat="server" ></asp:TextBox>
                <label for="txtUser">Usuario</label>
            </div>
            <div class="form-floating">
                 <asp:TextBox ID="txtContra" class="form-control col-lg-4 "  placeholder="Contraseña" runat="server"></asp:TextBox>
                 <label for="txtContra">Contraseña</label>
            </div>

            <asp:CheckBox ID="chkAdmin" runat="server" Text="Administrador" />

            <br />
            <br />
            <asp:Button class="btn btn-success" ID="btnEntrar" runat="server" OnClick="btnEntrar_Click" Text="Iniciar Sesion" />
            &nbsp;<asp:Button class="btn btn-info" ID="btnRegistrarse" runat="server" OnClick="btnRegistrarse_Click" Text="Registrarse" />
            <br />
            <br />
                
            <asp:Label ID="lblError" runat="server" Text="**USUARIO O CONTRASEÑA NO VALIDOS**" Font-Bold="True" ForeColor="#FF0F15"></asp:Label>
           
            </div>
        </div>
    </form>
</body>
</html>
