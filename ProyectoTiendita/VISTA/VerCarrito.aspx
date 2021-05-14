<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerCarrito.aspx.cs" Inherits="ProyectoTiendita.VISTA.VerCarrito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
          background:#1B2030 url(https://images.unsplash.com/photo-1574722772633-e401c33eb317?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1354&q=80) 50% 0 no-repeat;
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

    <title>Mi Carrito</title>
</head>
<body>
    <form id="form1" runat="server">

        <div class="text-center">
            <table class="table table-dark" width="100%">
              <thead>
                <tr>
                    <div class="header">
                        <div class="info">
                        <h1>MI PEDIDO</h1>
                        <h4>Aqui se encuentran los productos que has agregado al carrito. Puedes proceder a hacer el pedido o a cancelarlo.</h4>   
                        </div>
                    </div>
                    </tr>
              </thead>
                <tr>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnPedido" runat="server" Text="Inicio" OnClick="btnPedido_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnPerfil" runat="server" Text="Perfil" OnClick="btnPerfil_Click" /></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnWebServer" runat="server" Text="Indicadores Económicos" OnClick="btnWebServer_Click"/></th>
                  <th scope="col">&nbsp;<asp:Button class="btn btn-outline-light" ID="btnIniciarSesion" runat="server" OnClick="btnIniciarSesion_Click" Text="Iniciar Sesion" /></th>
                </tr>
                  
            </table>
            </div>

        <div>
            <br />
             <div class="row">
                <div class="col">
                </div>
                <div class="col-6">
                    <br />
                    <h3>Mi carrito</h3>
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
                <div class="col">
                </div>
              </div>
            </div>
    </form>
</body>
</html>
