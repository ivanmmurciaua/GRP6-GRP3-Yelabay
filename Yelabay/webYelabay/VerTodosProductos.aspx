<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerTodosProductos.aspx.cs" Inherits="webYelabay.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <asp:Label ID="Titulo" runat="server" Text=""></asp:Label>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
                <asp:BoundField DataField="foto" HeaderText="foto" SortExpression="foto" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [nombre], [precio], [foto] FROM [Productos]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <b>HyperX Predator DDR4 RGB HX432C16PB3A/8</b>
        <br />
        <asp:ImageButton CssClass ="Img2" runat="server" ID="buttonRam" ImageUrl="images/ram.png" Visible="true" OnClick="buttonRam_Click"></asp:ImageButton>


    </div>
</asp:Content>
