<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerProducto.aspx.cs" Inherits="webYelabay.VerProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Producto</h1>

        </div>

        <div id="content">
            
            <div>
                <h1>HyperX Predator DDR4 RGB HX432C16PB3A/8</h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="images/ram.png" style="border:solid; height:300px" alt="#:Item.ProductName "/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Description:</b><br />Memoria RAM 3200MHz DDR4 CL16 DIMM 8GB.
                        <br />
                        <br />
                        <span><b>Price:</b>&nbsp;64€</span>
                        <br />
                        
                        <span><b>Product Number:</b>&nbsp;0000001</span>
                        <br />
                        <b>Stock: </b>  100 unidades
                        <br /><br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Añadir al carrito" OnClick="addCarrito_Click" />
                    </td>
                </tr>
            </table>
       
        </div>

    </div>
</asp:Content>
