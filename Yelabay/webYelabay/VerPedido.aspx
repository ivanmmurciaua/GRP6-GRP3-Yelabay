<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerPedido.aspx.cs" Inherits="webYelabay.Verpedid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Mis Pedidos</h1>
        </div>
        <div id="content">
            <asp:Table ID="tablaCarrito" runat="server" Width="100%"> 
                
                <asp:TableHeaderRow> 
                 <asp:TableHeaderCell>Pedido ID</asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Fecha de compra</asp:TableHeaderCell> 
                 <asp:TableHeaderCell>Fecha de empaquetamiento</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Fecha de envio</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Fecha de entrega</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Precio sin IVA</asp:TableHeaderCell>
                 <asp:TableHeaderCell>IVA 18% </asp:TableHeaderCell>
                 <asp:TableHeaderCell>Precio con IVA</asp:TableHeaderCell>
                 <asp:TableHeaderCell>Estado</asp:TableHeaderCell>
                </asp:TableHeaderRow>

                <asp:TableRow> 
                 <asp:TableCell>00001</asp:TableCell> 
                 <asp:TableCell>12/02/2019</asp:TableCell> 
                 <asp:TableCell>13/02/2019</asp:TableCell>
                 <asp:TableCell>13/02/2019</asp:TableCell>
                 <asp:TableCell>15/02/2019</asp:TableCell>
                 <asp:TableCell>82€</asp:TableCell>
                 <asp:TableCell>18€</asp:TableCell>
                 <asp:TableCell>100€</asp:TableCell>
                 <asp:TableCell>Recibido</asp:TableCell>
                </asp:TableRow>

                <asp:TableRow> 
                 <asp:TableCell>00002</asp:TableCell> 
                 <asp:TableCell>14/02/2019</asp:TableCell> 
                 <asp:TableCell>14/02/2019</asp:TableCell>
                 <asp:TableCell>15/02/2019</asp:TableCell>
                 <asp:TableCell>17/02/2019</asp:TableCell>
                 <asp:TableCell>34€</asp:TableCell>
                 <asp:TableCell>6€</asp:TableCell>
                 <asp:TableCell>40€</asp:TableCell>
                 <asp:TableCell>Recibido</asp:TableCell>
                </asp:TableRow>

                <asp:TableRow> 
                 <asp:TableCell>00003</asp:TableCell> 
                 <asp:TableCell>17/02/2019</asp:TableCell> 
                 <asp:TableCell>18/02/2019</asp:TableCell>
                 <asp:TableCell>18/02/2019</asp:TableCell>
                 <asp:TableCell>21/02/2019</asp:TableCell>
                 <asp:TableCell>20€</asp:TableCell>
                 <asp:TableCell>4€</asp:TableCell>
                 <asp:TableCell>24€</asp:TableCell>
                 <asp:TableCell>Recibido</asp:TableCell>
                </asp:TableRow>

                <asp:TableRow> 
                 <asp:TableCell>00003</asp:TableCell> 
                 <asp:TableCell>17/02/2019</asp:TableCell> 
                 <asp:TableCell>18/02/2019</asp:TableCell>
                 <asp:TableCell>18/02/2019</asp:TableCell>
                 <asp:TableCell>21/02/2019</asp:TableCell>
                 <asp:TableCell>20€</asp:TableCell>
                 <asp:TableCell>4€</asp:TableCell>
                 <asp:TableCell>24€</asp:TableCell>
                 <asp:TableCell>Recibido</asp:TableCell>
                </asp:TableRow>

            </asp:Table> 
        </div>

    </div>
</asp:Content>
