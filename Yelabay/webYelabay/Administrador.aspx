<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="webYelabay.Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class ="column-left">
                    <asp:Menu ID="MenuLef" runat="server" StaticSubMenuIndent="16px" Orientation="Horizontal" class= "center" style="text-align: center" RenderingMode="List" OnMenuItemClick="MenuLef_MenuItemClick">
                    <Items>
                        <asp:MenuItem Text="Usuarios" Value="usuarios"></asp:MenuItem>
                        <asp:MenuItem Text="Articulos" Value="articulos"></asp:MenuItem>
                        <asp:MenuItem Text="Pedidos" Value="pedidos"></asp:MenuItem>
                        <asp:MenuItem Text="Reclamaciones" Value="reclamaciones"></asp:MenuItem>
                        <asp:MenuItem Text="Ofertas" Value="ofertas"></asp:MenuItem>
                        <asp:MenuItem Text="Agencias de Transporte" Value="agenciastransporte"></asp:MenuItem>
                    </Items>
                    <StaticMenuItemStyle Font-Size="XX-Large" ForeColor="Black" />
                </asp:Menu>
                </div>
        <div id ="title">
            <h1>
                ADMINISTRADOR
                </h1>
        </div>
    <div id="content">
        <div class="center">
            Bienvenido Admin!
        </div>
       <%-- <div class="invisibleRow">
                <div class="invisibleCol">
                    <asp:Button ID="ButtonModify" style="background:#249cf4" runat="server" Text="Actualizar Información" OnClick="ButtonModify_Click" />
                </div>
                <div class="invisibleCol">
                    <asp:Button ID="ButtonPedidos" style="background:#249cf4" runat="server" Text="Ver mis pedidos" OnClick="ButtonPedidos_Click" />
                </div>
                <div class="invisibleCol">
                    <asp:Button ID="ButtonReclamaciones" style="background:#249cf4" runat="server" Text="Ver mis reclamaciones" OnClick="ButtonReclamaciones_Click" />
                </div>
                <div class="invisibleCol">
                    <asp:Button ID="ButtonNuevaReclamacion" style="background:#249cf4" runat="server" Text="Crear nueva reclamación" OnClick="ButtonNuevaReclamacion_Click" />
                </div>
        </div>--%>
        </div>


</asp:Content>
