<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerTodasIncidencias.aspx.cs" Inherits="webYelabay.VerTodasIncidencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Incidencias:</h1>
        </div>
        <div id="content">
            <h1>Lista de incidencias registradas en el servidor:
            </h1>



            <asp:Table ID="TablaIncidencias" runat="server" Width="100%" BackColor="AliceBlue">

                <asp:TableRow> 
                 <asp:TableCell>Incidencia</asp:TableCell> 
                 <asp:TableCell>Fecha</asp:TableCell> 
                 <asp:TableCell>Devolución</asp:TableCell>
                </asp:TableRow>

                <asp:TableRow> 
                 <asp:TableCell>
                     <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Envío Extraviado" BackColor="Transparent" BorderWidth="0" ForeColor="#3400FF"/>
                 </asp:TableCell> 
                 <asp:TableCell>20/04/2019</asp:TableCell> 
                 <asp:TableCell>NO</asp:TableCell>
                </asp:TableRow>

                <asp:TableRow> 
                 <asp:TableCell>
                     <asp:Button ID="Button2" runat="server"  Text="Pieza equivocada" BackColor="Transparent" BorderWidth="0" ForeColor="#3400FF"/>
                 </asp:TableCell> 
                 <asp:TableCell>26/04/2019</asp:TableCell> 
                 <asp:TableCell>NO</asp:TableCell>
                </asp:TableRow>

                <asp:TableRow> 
                 <asp:TableCell>
                     <asp:Button ID="Button3" runat="server"  Text="Periférico no funciona" BackColor="Transparent" BorderWidth="0" ForeColor="#3400FF" />
                 </asp:TableCell> 
                 <asp:TableCell>29/04/2019</asp:TableCell> 
                 <asp:TableCell>SÍ</asp:TableCell>
                </asp:TableRow>

            </asp:Table>
            
        </div>
    </div>
</asp:Content>