<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="webYelabay.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
        </div>
        <div id="content">
            <h1>Bienvenid@</h1>
            </div>
            <h1>Esto es Yelabay, la tienda de electrónica por excelencia.</h1>
            <h1>Si tan solo deseas ver nuestro catálogo, pulsa 
                <asp:Menu ID="LinkCatalogo" runat="server" StaticSubMenuIndent="16px" Orientation="Horizontal" class= "center" style="text-align: center" RenderingMode="List" OnMenuItemClick="LinkCatalogo_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="aquí" Value="catalogo"></asp:MenuItem>
                </Items>
                </asp:Menu>
            .</h1>
            <h1>Si, por otro lado, tu intención es comprar alguno de nuestros productos, primero deberás 
                <asp:Menu ID="LinkRegistro" runat="server" StaticSubMenuIndent="16px" Orientation="Horizontal" class= "center" style="text-align: center" RenderingMode="List" OnMenuItemClick="LinkRegistro_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="registrarte" Value="register"></asp:MenuItem>
                </Items>
                </asp:Menu> 
            o, en el caso de que ya estés registrad@, 
                <asp:Menu ID="LinkLogin" runat="server" StaticSubMenuIndent="16px" Orientation="Horizontal" class= "center" style="text-align: center" RenderingMode="List" OnMenuItemClick="LinkLogin_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="identificarte" Value="login"></asp:MenuItem>
                </Items>
                </asp:Menu>
            .</h1>
            <h1>Además, por si no te has enterado, cada semana tenemos distintas ofertas en algunos de nuestros productos!!!</h1>
            <h1>                                          ↓↓↓↓↓↓↓↓↓</h1>
            
        <div class="slider">
            <ul>
                <li><img src="images/Banner1.png" alt=""></li>
                <li><img src="images/Banner2.png" alt=""></li>
                <li><img src="images/Banner3.png" alt=""></li>
                <li><img src="images/Banner4.png" alt=""></li>
            </ul>
        </div>
    </div>
</asp:Content>
