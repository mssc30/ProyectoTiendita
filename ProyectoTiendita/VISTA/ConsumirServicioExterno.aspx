<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumirServicioExterno.aspx.cs" Inherits="ProyectoTiendita.VISTA.ConsumirServicioExterno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet">   
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <main class="row col-sm-1 col-md-1 col-3 container">
             <article class="container">
                 Selecciona un Indicador<br />
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
                 Selecciona Fecha Inicio<br />
                 <asp:TextBox ID="txtFecha1" runat="server" TextMode="Date"></asp:TextBox>
                 <br />
                 <br />
                 Selecciona Fecha Fin<br />
                 <asp:TextBox ID="txtFecha2" runat="server" TextMode="Date"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click1" />
                </article>
                 &nbsp;<article class="container">
                
                <asp:GridView ID="dgvDatosServer" runat="server">
                </asp:GridView>
                
                </article>
             </main>
    </form>
</body>
</html>
