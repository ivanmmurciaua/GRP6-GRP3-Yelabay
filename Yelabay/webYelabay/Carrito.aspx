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
                 <asp:TableCell>Cantidad</asp:TableCell> 
                 <asp:TableCell>Precio</asp:TableCell> 
                </asp:TableRow>

                <asp:TableRow> 
                 <asp:TableCell>Componente ordenador nº5</asp:TableCell> 
                 <asp:TableCell>
                    <asp:DropDownList ID="DecrementarCantidad" runat="server">
                        <asp:listitem text="1" value="1"></asp:listitem>
                        <asp:listitem text="2" value="2"></asp:listitem>
                        <asp:listitem text="3" value="3"></asp:listitem>
                        <asp:listitem text="4" value="4"></asp:listitem>
                        <asp:listitem text="5" value="5"></asp:listitem>
                        <asp:listitem text="6" value="6"></asp:listitem>
                        <asp:listitem text="7" value="7"></asp:listitem>
                        <asp:listitem text="8" value="8"></asp:listitem>
                        <asp:listitem text="9" value="9"></asp:listitem>
                        <asp:listitem text="10" value="10"></asp:listitem>
                    </asp:DropDownList>
                 </asp:TableCell> 
                 <asp:TableCell>150€</asp:TableCell> 
                </asp:TableRow>

                <asp:TableRow> 
                 <asp:TableCell></asp:TableCell> 
                 <asp:TableCell>Total:</asp:TableCell> 
                 <asp:TableCell>1000€</asp:TableCell> 
                </asp:TableRow>

            </asp:Table> 
        </div>
    </div>
</asp:Content>
