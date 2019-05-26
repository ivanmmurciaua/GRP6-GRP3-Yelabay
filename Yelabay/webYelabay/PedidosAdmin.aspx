<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PedidosAdmin.aspx.cs" Inherits="webYelabay.PedidosAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Pedidos Administrador</h1>
        </div>
        <div id="content">
            <div class="pro-admin">
            <asp:GridView ID="GridPedidosAdmin" runat="server" AutoGenerateColumns="False" ShowFooter="true" DataKeyNames="id"
                OnRowCommand="GridPedidosAdmin_RowCommand" OnRowEditing="GridPedidosAdmin_RowEditing" OnRowCancelingEdit="GridPedidosAdmin_RowCancelingEdit" 
                OnRowUpdating="GridPedidosAdmin_RowUpdating" OnRowDeleting="GridPedidosAdmin_RowDeleting"
                
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="90%">
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
                    <asp:TemplateField HeaderText="id" SortExpression="id">
                        <ItemTemplate>
                            <asp:LinkButton ID="BotonVerPedidoDetalles" OnClick="BotonVerPedidoDetalles_Click" Text='<%# Eval("id") %>' runat="server">LinkButton</asp:LinkButton>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textID" Text='<%# Eval("id") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textIDFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha de compra">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fechacompra") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textFechaCompra" Text='<%# Eval("fechacompra") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textFechaCompraFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha de empaquetado">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fechaempaquetado") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textFechaEmpaquetado" Text='<%# Eval("fechaempaquetado") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textFechaEmpaquetadoFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha de envio">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fechaenvio") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textFechaEnvio" Text='<%# Eval("fechaenvio") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textFechaEnvioFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Fecha de entrega">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fechaentrega") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textFechaEntrega" Text='<%# Eval("fechaentrega") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textFechaEntregaFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Direccion">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("direccion") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textDireccion" Text='<%# Eval("direccion") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textDireccionFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Ciudad">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("ciudad") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textCiudad" Text='<%# Eval("ciudad") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textCiudadFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Pais">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("pais") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textPais" Text='<%# Eval("pais") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textPaisFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Id Usuario">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fkusuario") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textUsuario" Text='<%# Eval("fkusuario") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textUsuarioFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Id Ag. Transportes">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fkagtrans") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textAT" Text='<%# Eval("fkagtrans") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textATFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Precio sin IVA">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("preciosiniva") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textPrecioSinIva" Text='<%# Eval("preciosiniva") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textPrecioSinIvaFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IVA">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("iva") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textIva" Text='<%# Eval("iva") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textIvaFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Precio con IVA">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("precioconiva") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textPrecioConIva" Text='<%# Eval("precioconiva") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textPrecioConIvaFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    

                    <asp:TemplateField HeaderText="Estado">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("estado") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textEstado" Text='<%# Eval("estado") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textEstadoFooter"  runat="server" />
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