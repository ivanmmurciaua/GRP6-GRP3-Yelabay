<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="webYelabay.Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
        <div id ="title">
            <h1>
                Perfil Administrador
                </h1>
        </div>
    <div id="content">
        <div class="mensaje-admin">
            <h1>Bienvenido Administrador. ¿Qué deseas hacer?</h1>
        </div>
        <div class="invisibleRow">
                <div class="invisibleCol">
                    <asp:Button ID="ButtonUsuariosAdmin" style="background:#249cf4" runat="server" Text="Ver los usuarios" OnClick="ButtonUsuariosAdmin_Click" Height="75px" Width="200px" ForeColor="White" BorderColor="Black"/>
                </div>
                <div class="invisibleCol">
                    <asp:Button ID="ButtonProductosAdmin" style="background:#249cf4" runat="server" Text="Ver los articulos" OnClick="ButtonProductosAdmin_Click" Height="75px" Width="200px" ForeColor="White" BorderColor="Black"/>
                </div>
                <div class="invisibleCol">
                    <asp:Button ID="ButtonPedidosAdmin" style="background:#249cf4" runat="server" Text="Ver los pedidos" OnClick="ButtonPedidosAdmin_Click" Height="75px" Width="200px" ForeColor="White" BorderColor="Black"/>
                </div>
                <div class="invisibleCol">
                    <asp:Button ID="ButtonReclamacionesAdmin" style="background:#249cf4" runat="server" Text="Ver las reclamaciones" OnClick="ButtonReclamacionesAdmin_Click" Height="75px" Width="200px" ForeColor="White" BorderColor="Black"/>
                </div>
        </div>
        </div>
</asp:Content>
