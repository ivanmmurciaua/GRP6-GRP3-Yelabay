<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="webYelabay.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"/>
    <div id ="innerContainer">
        <div id ="title">
            <h1>Carrito</h1>
        </div>
        <div id="content">
            <h1>Artículos actualmente en el carrito:<asp:DataList ID="DataList1" runat="server" DataKeyField="id" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    id:
                    <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                    <br />
                    cantidad:
                    <asp:Label ID="cantidadLabel" runat="server" Text='<%# Eval("cantidad") %>' />
                    <br />
                    precio:
                    <asp:Label ID="precioLabel" runat="server" Text='<%# Eval("precio") %>' />
                    <br />
                    precioxcantidad:
                    <asp:Label ID="precioxcantidadLabel" runat="server" Text='<%# Eval("precioxcantidad") %>' />
                    <br />
                    fkproducto:
                    <asp:Label ID="fkproductoLabel" runat="server" Text='<%# Eval("fkproducto") %>' />
                    <br />
                    fkusuario:
                    <asp:Label ID="fkusuarioLabel" runat="server" Text='<%# Eval("fkusuario") %>' />
                    <br />
<br />
                </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:miconexion %>" SelectCommand="SELECT * FROM [Carrito]"></asp:SqlDataSource>
            </h1>
            
            
            
            
            
            <asp:Button ID="Comprar" runat="server" Text="Confirmar Compra" OnClick="Comprar_Click"/>
            <asp:Label ID="PruebaCompra" runat="server"></asp:Label>
            
        </div>
    </div>
</asp:Content>
