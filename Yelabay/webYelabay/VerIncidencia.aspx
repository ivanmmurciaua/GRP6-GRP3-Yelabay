<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerIncidencia.aspx.cs" Inherits="webYelabay.VerIncidencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Mis Reclamaciones:</h1>
        </div>
        <div id="content">


            <asp:GridView ID="GridIncidenciasUser" runat="server" AutoGenerateColumns="False" ShowFooter="true" DataKeyNames="id"

                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="90%" Height="270px" OnSelectedIndexChanged="GridIncidenciasUser_SelectedIndexChanged">
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
                    <asp:TemplateField HeaderText="Fecha">
                        <ItemTemplate>
                             <asp:Label Text='<%# Eval("fechareclamacion") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="textFecha" Text='<%# Eval("fechareclamacion") %>' runat="server" />
                        </EditItemTemplate>
                       
                    </asp:TemplateField> 

                    <asp:TemplateField HeaderText="Motivo de la Reclamación">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("reclamacion") %>' runat="server"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                                <asp:TextBox ID="textMotivo" Text='<%# Eval("reclamacion") %>' runat="server" />
                        </EditItemTemplate>
                     
                        
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>

            <br />
        </div>
    </div>
</asp:Content>
