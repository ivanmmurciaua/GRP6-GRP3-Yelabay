<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="webYelabay.Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1> Mi Perfil </h1>
        </div>
    </div>
    <div id="content">
            <div class="invisibleRow">
                <div class="invisibleCol">Nombre:</div>
                <div class="invisibleCol">
                    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="LabelErrorName" runat="server" CssClass="ErrorMessage" Text="¡Nombre Obligatorio! Solo debe contener letras."></asp:Label>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol">Apellidos:</div>
                <div class="invisibleCol">
                    <asp:TextBox ID="TextBoxLastname" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="LabelErrorLastname" runat="server" CssClass="ErrorMessage" Text="¡Apellido Obligatorios! Solo deben contener letras."></asp:Label>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol">Teléfono:</div>
                <div class="invisibleCol">
                    <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="LabelErrorPhone" runat="server" CssClass="ErrorMessage" Text="¡Teléfono NO válido!"></asp:Label>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol">Correo electronico:</div>
                <div class="invisibleCol">
                    <asp:Label ID="LabelEmail" runat="server" ></asp:Label>
                </div>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol">Usuario:</div>
                <div class="invisibleCol">
                    <asp:Label ID="LabelUsername" runat="server" ></asp:Label>
                </div>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol">
                    <asp:Button ID="ButtonModify" style="background:#249cf4" runat="server" Text="Actualizar Información" OnClick="ButtonModify_Click" />
                </div>
            </div>
            <asp:Menu ID="MenuOrders" runat="server" StaticSubMenuIndent="16px" OnMenuItemClick="MenuOrders_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="Ver Pedidos" Value="orders"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </div>
</asp:Content>

