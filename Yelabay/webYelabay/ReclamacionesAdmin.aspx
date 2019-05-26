<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ReclamacionesAdmin.aspx.cs" Inherits="webYelabay.ReclamacionesAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        left: -15px;
        top: 200px;
    }
        .auto-style2 {
            margin-right: 41px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer" class="auto-style1">
        <div id ="title">
                <h1>Reclamaciones</h1>
            </div>
        <div class="rec-admin">
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            
            <asp:GridView ID="GridReclamacionesAdmin" runat="server" OnRowDeleting="GridUsuariosAdmin_RowDeleting" OnRowCancelingEdit="GridUsuariosAdmin_RowCancelingEdit" DataKeyNames="id"
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" Width="522px" CssClass="auto-style2">
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
                            <asp:TextBox ID="textReclamacionRe" Text='<%# Eval("id") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textReclamacionReFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>


                     <asp:TemplateField HeaderText="Reclamaciones">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("reclamacion") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textReclamacionRe" Text='<%# Eval("reclamacion") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textReclamacionReFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Usuario">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fkusuario") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textReclamacionUs" Text='<%# Eval("fkusuario") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textReclamacionUsFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Fecha reclamacion">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("fechareclamacion") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textReclamacionFe" Text='<%# Eval("fechareclamacion") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="textReclamacionFeFooter"  runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>


                     <asp:TemplateField>
                        <ItemTemplate>
                    
                            <asp:ImageButton ImageUrl="images/BorrarIcon.png" runat="server" CommandName="Delete" ToolTip="Delete" Height="20px" Width="20px" />
                        </ItemTemplate>
                        <EditItemTemplate>
                           
                            <asp:ImageButton ImageUrl="images/CancelarIcon.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Height="20px" Width="20px" />
                        </EditItemTemplate>
                        
                    </asp:TemplateField>

                </Columns>
            </asp:GridView>
            <asp:Label ID="Label1" runat="server" CssClass="ErrorMessage"></asp:Label>
            <asp:Label ID="Label2" runat="server" CssClass="ErrorMessage"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            </div>
           
            
           
           
            
        </div>
    </div>
</asp:Content>
