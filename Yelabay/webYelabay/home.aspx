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
            <h1>Si tan solo deseas ver nuestro catálogo, pulsa <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/VerTodosProductos.aspx">aquí</asp:HyperLink> .</h1>
            <h1>Si, por otro lado, tu intención es comprar alguno de nuestros productos, primero deberás <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Register.aspx">registrarte</asp:HyperLink> o, en el caso de que ya estés registrad@,
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Login.aspx">identificarte</asp:HyperLink> .</h1>
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
