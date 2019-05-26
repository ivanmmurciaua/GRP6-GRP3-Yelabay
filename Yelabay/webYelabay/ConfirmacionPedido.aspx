<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ConfirmacionPedido.aspx.cs" Inherits="webYelabay.ConfirmacionPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 61%;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 361px;
            height: 23px;
            text-align: left;
        }
        .auto-style6 {
            width: 161px;
            height: 23px;
            text-align: center;
        }
        .auto-style7 {
            width: 161px;
        }
        .auto-style8 {
            width: 361px;
            text-align: left;
        }
        .auto-style9 {
            text-align: justify;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"/>
    <div id ="innerContainer">
        <div id ="title">
            <h1>Confirmacion Pedido</h1>
        </div>
        <div id="content" class="auto-style9">
            
            
            
            
            <table class="auto-style1">
                <tr>
                    <td colspan="5">
            
            
                        <h3><b>Elije la agencia de transporte:</b></h3></td>
                </tr>
                <tr>
                    <td>
            
            
            <asp:Label ID="Label1" runat="server" ><b>Agencia de Transporte:</b></asp:Label> </td>
                    <td>
            <asp:Label ID="Labelrellenar" runat="server" ><b>Pais:</b></asp:Label>
                    </td>
                    <td>
            <asp:Label ID="LabelRellenar2" runat="server"><b>Precio Envio:</b></asp:Label>
                    </td>
                    <td>
                        Total sin IVA:</td>
                    <td>
                        <b>Total pedido:</b></td>
                </tr>
                <tr>
                    <td>
            <asp:DropDownList ID="DropListAgTrans" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropListAgTrans_SelectedIndexChanged">
            </asp:DropDownList>
            
                    </td>
                    <td>
            <asp:Label ID="LabelPais" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
            <asp:Label ID="LabelPrecioEnvio" runat="server" Text=""></asp:Label>
            
            
                        <asp:Label ID="LabelEuro" runat="server" Text="€"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelPrecioTotalSinIVA" runat="server" Text=""></asp:Label>
                        <asp:Label ID="LabelEuro1" runat="server" Text="€"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelPrecioTotal" runat="server" Text=""></asp:Label>
                        <asp:Label ID="LabelEuro2" runat="server" Text="€"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />           
            
            
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4" colspan="2"><h3><b>Rellena los datos de envio:</b></h3></td>
                </tr>
                <tr>
                    <td class="auto-style6"><b>Direccion:</b></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBoxDireccion" runat="server" Width="374px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"><b>Ciudad:</b></td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBoxCiudad" runat="server" Width="177px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"><b>Pais:</b></td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBoxPais" runat="server" Width="177px"></asp:TextBox>
                    </td>
                </tr>
                </table>


            
            <asp:Button ID="Button1" runat="server" Text="Confirmar Pedido" OnClick="ButtonConfirmarPedido_Click" />
                        
            <asp:Label ID="LabelMensajeError" Text="" runat="server" ForeColor="Red"></asp:Label>

            
                 
        </div>
    </div>
</asp:Content>