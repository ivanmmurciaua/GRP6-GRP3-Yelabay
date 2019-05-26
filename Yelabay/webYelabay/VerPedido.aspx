<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerPedido.aspx.cs" Inherits="webYelabay.Pedido" EnableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 651px;
        }
        .auto-style2 {
            width: 274px;
        }
        .auto-style3 {
            width: 651px;
            height: 23px;
        }
        .auto-style4 {
            width: 274px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 651px;
            height: 24px;
        }
        .auto-style7 {
            width: 274px;
            height: 24px;
        }
        .auto-style8 {
            height: 24px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Detalles del Pedido</h1>
        </div>
        <div id="content">
            <div class="pedido">
            <table class="tablaPedido">
                
                <tr>
                    <td class="auto-style1" colspan="2"><h3><b>Direccion de envío</b></h3></td>
                    <td class="auto-style2"><h3><b>Resumen de pedido</b></h3></td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style1" colspan="2">
                        <asp:Label ID="LabelDireccion" runat="server"></asp:Label>
                        
                    </td>
                    <td class="auto-style2"><b>Precio sin IVA:</b></></td>
                    <td>
                        <asp:Label ID="LabelPrecioSinIva" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="LabelCiudad" runat="server" Width="167px"></asp:Label>
                    </td>
                    <td class="auto-style4"><b>IVA:</b></td>
                    <td class="auto-style5">
                        <asp:Label ID="LabelIVA" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style3" colspan="2">
                    <asp:Label ID="LabelPais" runat="server" Width="116px"></asp:Label>
                    <td class="auto-style7"><b>TOTAL:</b></td>
                    <td class="auto-style8">
                        <asp:Label ID="LabelPrecioConIVA" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style3" colspan="2">Fecha de compra:</td>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="LabelFechaCompra" runat="server" Text="Label"></asp:Label>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">Fecha de empaquetado:</td>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="LabelFechaEmpaquetado" runat="server" Text="Label"></asp:Label>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">Fecha de envío:</td>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="LabelFechaEnvio" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">Fecha de entrega:</td>
                    <td class="auto-style3" colspan="2">
                        <asp:Label ID="LabelFechaEntrega" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
            </div>
    </div>
</asp:Content>
