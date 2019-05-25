<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="webYelabay.Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <br />
        <br />
        <br />
        <div class =" column-left">
                    <asp:Menu ID="MenuLeftUsu" runat="server" StaticSubMenuIndent="16px" Orientation="Horizontal" class= "center" style="text-align: center" RenderingMode="List" OnMenuItemClick="MenuLeftUsu_MenuItemClick">
                    <Items>
                        <asp:MenuItem Text="Mis datos" Value="usu"></asp:MenuItem>
                        <asp:MenuItem Text="Mis pedidos" Value="ped"></asp:MenuItem>
                        <asp:MenuItem Text="Incidencias" Value="inc"></asp:MenuItem>
                        <asp:MenuItem Text="Reclamaciones" Value="rec"></asp:MenuItem>
                    </Items>
                    <StaticMenuItemStyle Font-Size="XX-Large" ForeColor="Black" />
                </asp:Menu>
                </div>
        <div id ="title">
            <h1>
                Mis Datos<asp:Image ID="Image1" runat="server" ImageUrl="images/VectorPerfil.png" Height="50px" Width="84px" />
                </h1>
        </div>
    </div>
    <div id="content">
            <div class="invisibleRow">
                <div class="invisibleCol"><b>Nombre:</b></div>
                <div class="invisibleCol">
                    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="LabelErrorName" runat="server" CssClass="ErrorMessage" Text="¡Nombre Obligatorio! Solo debe contener letras."></asp:Label>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol"><b>Apellidos:</b></div>
                <div class="invisibleCol">
                    <asp:TextBox ID="TextBoxLastname" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="LabelErrorLastname" runat="server" CssClass="ErrorMessage" Text="¡Apellido Obligatorios! Solo deben contener letras."></asp:Label>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol"><b>Teléfono:</b></div>
                <div class="invisibleCol">
                    <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="LabelErrorPhone" runat="server" CssClass="ErrorMessage" Text="¡Teléfono NO válido!"></asp:Label>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol"><b>Correo electronico:</b></div>
                <div class="invisibleCol">
                    <asp:Label ID="LabelEmail" runat="server" ></asp:Label>
                </div>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol"><b>Nick:</b></div>
                <div class="invisibleCol">
                    <asp:Label ID="LabelUsername" runat="server" ></asp:Label>
                </div>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol">
                    <asp:Button ID="ButtonModify" style="background:#249cf4" runat="server" Text="Actualizar Información" OnClick="ButtonModify_Click" />
                </div>
            </div>
            <asp:Menu ID="MenuOrders" runat="server" StaticSubMenuIndent="16px" >
                <Items>
                    <asp:MenuItem Text="Ver Pedidos" Value="orders"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    
</asp:Content>

