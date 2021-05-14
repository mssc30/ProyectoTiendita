<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumirServicioExterno.aspx.cs" Inherits="ProyectoTiendita.VISTA.ConsumirServicioExterno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style type="text/css">
        @import url('https://fonts.googleapis.com/css?family=Josefin+Sans:400,400i,600,600i');
        html,body{
          margin:0;
          height:120%;
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
          background:#1B2030 url(https://images.unsplash.com/photo-1580519542036-c47de6196ba5?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=751&q=80) 50% 0 no-repeat;
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


<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Indicadores Economicos</title>
</head>

    


<body>
    <form id="form1" runat="server">

        <div class="text-left">
            <table class="table table-dark" width="100%">
              <thead>
                <tr>
                    <div class="header">
                        <div class="info">
                        <h1>INDICADORES ECONÓMICOS</h1>
                        <h4>Consume el Web Service del Banco Central de Costa Rica para tomar mejores decisiones en tus finanzas.</h4>   
                        </div>
                    </div>
                    </tr>
              </thead>
                <tr>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnVerPedidos" runat="server" Text="Ver Pedidos" OnClick="btnVerPedidos_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnProductosCRUD" runat="server" Text="CRUD productos" OnClick="btnProductosCRUD_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnUsersCRUD" runat="server" Text="CRUD usuarios" OnClick="btnUsersCRUD_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnPedido" runat="server" Text="Ver Carrito" OnClick="btnPedido_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnPerfil" runat="server" Text="Perfil" OnClick="btnPerfil_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnWebServer" runat="server" Text="Principal" OnClick="btnWebServer_Click"/></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Iniciar Sesion" /></th>
                </tr>
                  
            </table>
            </div>

        
        <div class="container">
            <div class="row">
                <div class="col-sm-4">
                    <br />
             <h3>Selecciona:</h3>
                <b>Un Indicador</b><br />
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="332">Peso mexicano</asp:ListItem>
                        <asp:ListItem Value="328">Dolar Canadiense</asp:ListItem>
                        <asp:ListItem Value="330">Libra esterlina</asp:ListItem>
                        <asp:ListItem Value="338">Quetzal Guatemalteco</asp:ListItem>
                        <asp:ListItem Value="344">Peso argentino</asp:ListItem>
                        <asp:ListItem Value="345">Peso colombiano</asp:ListItem>
                        <asp:ListItem Value="3055">Peso chileno</asp:ListItem>
                        <asp:ListItem Value="3057">Sol Peruano</asp:ListItem>
                        <asp:ListItem Value="3433">Dolar australiano</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <b>Fecha Inicio</b><br />
                    <asp:TextBox ID="txtFecha1" runat="server" TextMode="Date"></asp:TextBox>
                    <br />
                    <br />
                    <b>Fecha Fin</b><br />
                    <asp:TextBox ID="txtFecha2" runat="server" TextMode="Date"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="btnConsultar" class="btn btn-success" runat="server" Text="Consultar" OnClick="btnConsultar_Click1" />
                 </div>
                 
                <div class="col-sm-8">   
                    <asp:GridView align="center" class="table table-hover align-middle table-responsive"
                        ID="dgvDatosServer"  runat="server">
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
