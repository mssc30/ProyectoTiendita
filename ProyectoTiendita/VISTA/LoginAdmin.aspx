<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="ProyectoTiendita.VISTA.LoginAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <style type="text/css">
        @import url('https://fonts.googleapis.com/css?family=Josefin+Sans:400,400i,600,600i');
        html,body{
          margin:0;
          height:100%;
          font-family: 'Josefin Sans', sans-serif;
        }
        a{
          text-decoration:none
        }
        .header{
          position:relative;
          overflow:hidden;
          display:flex;
          flex-wrap: wrap;
          justify-content: center;
          align-items: flex-start;
          align-content: flex-start;
          height:50vw;
          min-height:300px;
          max-height:400px;
          min-width:300px;
          color:#fff;
        }
        .header:after{
          content:"";
          width:100%;
          height:100%;
          position:absolute;
          bottom:0;
          left:0;
          z-index:-1;
         background: linear-gradient(to bottom, rgba(0,0,0,0.12) 40%,rgba(33,37,41,1) 100%);
        }
        .header:before{
          content:"";
          width:100%;
          height:150%;
          position:absolute;
          top:0;
          left:0;
            -webkit-backface-visibility: hidden;
            -webkit-transform: translateZ(0); backface-visibility: hidden;
          scale(1.0, 1.0);
            transform: translateZ(0);
          background:#1B2030 url(https://images.pexels.com/photos/3962294/pexels-photo-3962294.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940) 50% 0 no-repeat;
          background-size:100%;
          background-attachment:fixed;
          animation: grow 360s  linear 10ms infinite;
          transition:all 0.4s ease-in-out;
          z-index:-2
        }
        .header a{
          color:#eee
        }
        .menu{
          display:block;
          width:40px;
          height:30px;
          border:2px solid #fff;
          border-radius:3px;
          position:absolute;
          right:20px;
          top:20px;
          text-decoration:none
        }
        .menu:after{
          content:"";
          display:block;
          width:20px;
          height:3px;
          background:#fff;
          position:absolute;
          margin:0 auto;
          top:5px;
          left:0;
          right:0;
          box-shadow:0 8px, 0 16px
        }
        .sides, .info{
          flex: 0 0 auto;
          width:50%
        }
        .info{
          width:100%;
          padding:10% 10% 0 10%;
          text-align:center;
          text-shadow:0 2px 3px rgba(0,0,0,0.2)
        }
        .info h4, .meta{
          font-size:20px
        }


        .meta{
          font-style:italic;
        }
        @keyframes grow{
          0% { transform: scale(1) translateY(0px)}
          50% { transform: scale(1.2) translateY(-400px)}
        }
        .content{  
          padding:5% 10%;
          text-align:justify
        }
        .btn{
          color:#333;
          border:2px solid;
          border-radius:3px;
          text-decoration:none;
          display:inline-block;
          padding:5px 10px;
          font-weight:600
        }

        .twtr{
          margin-top:100px
        }.btn.twtr:after{content:"\1F426";padding-left:5px}
    </style>

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
                    <div class="header">
                        <div class="info">
                        <h1>INICIO DE SESIÓN</h1>
                        <h4>Pide tus abarrotes en línea. Nosotros los llevamos a tu casa. Inicia sesión o registrate para empezar.</h4>   
                        </div>
                    </div>
                    </tr>
              </thead>
                <tr>
                <th>
                    <div class="container">
                        <div class="row row-cols-4">
                        <div class="col"></div>
                        <div class="col"><asp:Button class="btn btn-outline-light" ID="btnWebServer" runat="server" Text="Indicadores Económicos" OnClick="btnWebServer_Click"/></div>
                        <div class="col"><asp:Button class="btn btn-outline-light" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Inicio" /></div>
                        <div class="col"></div>
                        </div>
                    </div>
                </th>  
                </tr>
                  
            </table>
            </div>

           

        <div class="row">
        <div class="col"></div>
        <div class="col-6">
            <br />
             <h3>Ingresa tus datos</h3>
            
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
            <div class="col"></div>
            </div>
        </div>
    </form>
</body>
</html>
