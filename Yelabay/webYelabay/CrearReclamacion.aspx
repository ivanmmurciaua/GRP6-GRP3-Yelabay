<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CrearReclamacion.aspx.cs" Inherits="webYelabay.CrearReclamacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <br />
        <br />

        <div id ="title">
            <h1><b>Panel de Reclamaciones</b></h1>
        </div>
       
 <div id="content">
            <div class="invisibleRow">
                <div class="invisibleCol"><b>Número de Pedido:</b></div>
                <div class="invisibleCol">
                    <asp:TextBox ID="TextBoxNumPedido" runat="server" OnTextChanged="TextBoxNumPedido_TextChanged"></asp:TextBox>
                </div>             
            </div>
           
            <div class="invisibleRow">
                <div class="invisibleCol"><b>Motivo Devolución:</b></div>
                <div class="invisibleCol">
                    <asp:TextBox ID="TextBoxMotivo" runat="server" Height="87px" Width="569px"></asp:TextBox>
                </div>
            </div>
                    <asp:Button ID="ButtonModify" style="background:#249cf4" runat="server" Text="Enviar Reclamación" OnClick="ButtonModify_Click" />
     </div>
         <div class="invisibleRow">
                <div class="invisibleCol">
                </div>
            </div>

</asp:Content>