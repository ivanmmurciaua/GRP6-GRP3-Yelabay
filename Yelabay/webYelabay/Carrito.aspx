<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="webYelabay.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Carrito</h1>
        </div>
        <div id="content">
            <h1>Artículos actualmente en el carrito:</h1>
            
            
            <asp:Table ID="tablaCarrito" runat="server" Width="100%"> 
                <asp:TableRow> 
                 <asp:TableCell>Nombre del Producto</asp:TableCell>
                 <asp:TableCell></asp:TableCell>
                 <asp:TableCell>Cantidad</asp:TableCell> 
                 <asp:TableCell></asp:TableCell>
                 <asp:TableCell>Precio</asp:TableCell>
                 <asp:TableCell></asp:TableCell>
                </asp:TableRow>

               


            </asp:Table> 
            <asp:Button ID="Comprar" runat="server" Text="Confirmar Compra" OnClick="Comprar_Click"/>
            <asp:Label ID="PruebaCompra" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
