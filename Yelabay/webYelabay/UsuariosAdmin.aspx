<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UsuariosAdmin.aspx.cs" Inherits="webYelabay.UsuariosAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Usuarios Administrador</h1>
        </div>
        <div id="content">
            <div class="usu-admin">
            <asp:GridView ID="GridUsuariosAdmin" runat="server" AutoGenerateColumns="False" ShowFooter="true" DataKeyNames="id"
                OnRowCommand="GridUsuariosAdmin_RowCommand" OnRowEditing="GridUsuariosAdmin_RowEditing" OnRowCancelingEdit="GridUsuariosAdmin_RowCancelingEdit" 
                OnRowUpdating="GridUsuariosAdmin_RowUpdating" OnRowDeleting="GridUsuariosAdmin_RowDeleting"
                
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
                    
                    <asp:TemplateField HeaderText="id">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("id") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textUsuarioID" Text='<%# Eval("id") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textUsuarioIDFooter"  runat="server" />
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

                    <asp:TemplateField HeaderText="Apellidos">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("apellido1") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textApellidos" Text='<%# Eval("apellido1") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textApellidosFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="NIF">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("nif") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textNif" Text='<%# Eval("nif") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textNifFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Email">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("email") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textEmail" Text='<%# Eval("email") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textEmailFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Contraseña">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("contrasenya") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textContraseña" Text='<%# Eval("contrasenya") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textContraseñaFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Direccion/tipo">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("tipo") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textDireccion" Text='<%# Eval("tipo") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textDireccionFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nick">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("nick") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textNick" Text='<%# Eval("nick") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textNickFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Telefono">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("telefono") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textTelefono" Text='<%# Eval("telefono") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textTelefonoFooter"  runat="server" />
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
