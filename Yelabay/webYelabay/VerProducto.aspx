<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerProducto.aspx.cs" Inherits="webYelabay.VerProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Producto</h1>
        </div>
        <div id="content">
            <div>
                <h1>
                <asp:Label ID="LabelNombreProducto" runat="server" ></asp:Label></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" Height="500" ImageUrl='<%# Eval("foto") %>' />
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Descripción:</b><br />
                        <asp:Label ID="LabelDescripcion" runat="server" Text="Label"></asp:Label>
                        <br />
                        <br />
                        <span><b>Precio:</b>&nbsp;<asp:Label ID="LabelPrecio" runat="server" Text="Label"></asp:Label>€</span><br />
                        
                        <span><b>Producto ID:</b>&nbsp;<asp:Label ID="LabelProductoID" runat="server" Text="Label"></asp:Label></span>
                        <br />
                        <b>Stock: </b>  <asp:Label ID="LabelStock" runat="server" Text="Label"></asp:Label>
                        <br /><br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="buttonAddCarrito" runat="server" Text="Añadir al carrito" Visible ="false" OnClick="addCarrito_Click" />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:miconexion %>" SelectCommand="SELECT [foto] FROM [Productos] WHERE ([id] = @id)">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="id" QueryStringField="id" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
