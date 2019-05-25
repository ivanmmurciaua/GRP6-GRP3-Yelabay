<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerPerifericos.aspx.cs" Inherits="webYelabay.VerPerifericos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            text-align: right;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Perifericos</h1>
        </div>
        <div id="content2">
            <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" RepeatColumns="3" RepeatDirection="Horizontal" CellPadding="10">
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
                            <td class="auto-style2">Precio:</td>
                            <td class="auto-style3">
                                <asp:Label ID="LabelPrecioProducto" runat="server" Text='<%# Eval("precio", "{0:C}") %>'></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:miconexion %>" SelectCommand="SELECT * FROM [Productos] WHERE ([fkcategoria] = @fkcategoria)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="4" Name="fkcategoria" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </div>
</asp:Content>

