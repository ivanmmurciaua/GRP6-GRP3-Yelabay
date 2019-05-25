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
            <h1>Artículos actualmente en el carrito:</h1><asp:Label ID="CompruebaBD" runat="server"></asp:Label>
                
           

                    <asp:GridView ID="GridCarrito" runat="server" AutoGenerateColumns="False" ShowFooter="true" DataKeyNames="nombreproducto"
                  
                OnRowUpdating="GridCarrito_RowUpdating" OnRowDeleting="GridCarrito_RowDeleting"
                
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="90%">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                

                <Columns>
                    

                    <asp:TemplateField HeaderText="Producto">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("nombreproducto") %>' runat="server"/>
                        </ItemTemplate>
                        
                        <FooterTemplate>
                            <asp:TextBox ID="textNombreProductoFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("precio") %>' runat="server"/>
                        </ItemTemplate>
                        
                        <FooterTemplate>
                            <asp:TextBox ID="textPrecioFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Cantidad">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("cantidad") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textCantidad" Text='<%# Eval("cantidad") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textCantidadFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Total">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("precioxcantidad") %>' runat="server"/>
                        </ItemTemplate>
                        
                        <FooterTemplate>
                            <asp:TextBox ID="textTotalFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="images/AñadirIcon.png" runat="server" CommandName="Update" ToolTip="Update" Height="20px" Width="20px" />
                            <asp:ImageButton ImageUrl="images/BorrarIcon.png" runat="server" CommandName="Delete" ToolTip="Delete" Height="20px" Width="20px" />
                        </ItemTemplate>
                        
                        <FooterTemplate>
                            <asp:ImageButton ImageUrl="images/AñadirIcon.png" runat="server" CommandName="Añadir" ToolTip="Añadir" Height="20px" Width="20px" />
                        </FooterTemplate>
                    </asp:TemplateField>

                </Columns>


            </asp:GridView>
                <asp:Label ID="NombreProduct" runat="server"></asp:Label>
                <asp:SqlDataSource ID="SqlDataCarrito" runat="server" ConnectionString="<%$ ConnectionStrings:miconexion %>" SelectCommand="SELECT [nombreproducto], [precio], [cantidad], [precioxcantidad] FROM [Carrito]"></asp:SqlDataSource>
           

            
            
            
            
            
            <asp:Button ID="Comprar" runat="server" Text="Confirmar Compra" OnClick="Comprar_Click"/>
            <asp:Label ID="PruebaCompra" runat="server"></asp:Label>
            
            <asp:Label ID="CosteTotal" runat="server" Text="Total: "></asp:Label>
            
        </div>
    </div>
</asp:Content>
