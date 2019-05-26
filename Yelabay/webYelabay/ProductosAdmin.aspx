<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="ProductosAdmin.aspx.cs" Inherits="webYelabay.ProductosAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Productos Administrador</h1>
        </div>
        <div id="content">
            <div class ="ped-admin">
            <asp:GridView ID="GridProductosAdmin" runat="server" AutoGenerateColumns="False" ShowFooter="true" DataKeyNames="id"
                OnRowCommand="GridProductosAdmin_RowCommand" OnRowEditing="GridProductosAdmin_RowEditing" OnRowCancelingEdit="GridProductosAdmin_RowCancelingEdit" 
                OnRowUpdating="GridProductosAdmin_RowUpdating" OnRowDeleting="GridProductosAdmin_RowDeleting"
                
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="99%">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />

                <Columns>

                    <asp:TemplateField HeaderText="id">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("id") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textProductoID" Text='<%# Eval("id") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textProductoIDFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nombre">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("nombre") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textNombre" Text='<%# Eval("nombre") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textNombreFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio (€)">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("precio") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textPrecio" Text='<%# Eval("precio") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textPrecioFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Id Marca">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fkmarca") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textFKMarca" Text='<%# Eval("fkmarca") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textFKMarcaFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    

                    <asp:TemplateField HeaderText="Id Categoria">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fkcategoria") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textFKCategoria" Text='<%# Eval("fkcategoria") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textFKCategoriaFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Stock">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("stock") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textStock" Text='<%# Eval("stock") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textStockFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Oferta">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("oferta") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textOferta" Text='<%# Eval("oferta") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textOfertaFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Descripcion">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("descripcion") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textDescripcion" Text='<%# Eval("descripcion") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textDescripcionFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Foto">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("foto") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textFoto" Text='<%# Eval("foto") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textFotoFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                   


                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="images/EditarIcon.png" runat="server" CommandName="Edit" ToolTip="Edit" Height="20px" Width="20px" />
                            <asp:ImageButton ImageUrl="images/BorrarIcon.png" runat="server" CommandName="Delete" ToolTip="Delete" Height="20px" Width="20px" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="images/GuardarIcon.png" runat="server" CommandName="Update" ToolTip="Update" Height="20px" Width="20px" />
                            <asp:ImageButton ImageUrl="images/CancelarIcon.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Height="20px" Width="20px" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:ImageButton ImageUrl="images/AñadirIcon.png" runat="server" CommandName="Añadir" ToolTip="Añadir" Height="20px" Width="20px" />
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="LabelMensajeExito" Text="" runat="server" ForeColor="Green"></asp:Label>
            <br />
            <asp:Label ID="LabelMensajeError" Text="" runat="server" ForeColor="Red"></asp:Label>
        </div>
        </div>
    </div>
</asp:Content>
