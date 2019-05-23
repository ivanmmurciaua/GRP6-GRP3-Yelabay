<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerComponentes.aspx.cs" Inherits="webYelabay.VerComponentes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Componentes</h1>
        </div>
        
        <div id="content">



            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="3" RepeatDirection="Horizontal">
                <ItemTemplate>
                    <table class="tablaPedido">
                        <tr>
                            <td colspan="2">
                                
                                <asp:ImageButton ID="ImagenProduc"  runat="server" Height="180px" Width="200px" ImageUrl='<%# Eval("foto") %>' CommandArgument='<%# Eval("id") %>' OnCommand="ImagenProduc_Command" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1" colspan="2">
                                <asp:Label ID="LabelNombreProducto" runat="server" Text='<%# Eval("nombre") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Precio:</td>
                            <td>
                                <asp:Label ID="LabelPrecioProducto" runat="server" Text='<%# Eval("precio", "{0:C}") %>'></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:miconexion %>" SelectCommand="SELECT * FROM [Productos] WHERE ([fkcategoria] = @fkcategoria)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="1" Name="fkcategoria" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>






        </div>
    </div>
</asp:Content>
