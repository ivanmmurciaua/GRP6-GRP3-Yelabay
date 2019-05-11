<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerTodosProductos.aspx.cs" Inherits="webYelabay.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Catálogo</h1>
        </div>
        <b>HyperX Predator DDR4 RGB HX432C16PB3A/8</b>
        <br />
        <asp:ImageButton CssClass ="Img2" runat="server" ID="buttonRam" ImageUrl="images/ram.png" Visible="true" OnClick="buttonRam_Click"></asp:ImageButton>



    </div>
</asp:Content>
