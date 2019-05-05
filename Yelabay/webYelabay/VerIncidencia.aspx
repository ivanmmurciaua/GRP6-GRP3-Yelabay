<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerIncidencia.aspx.cs" Inherits="webYelabay.VerIncidencia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <div id ="title">
            <h1>Incidencia: </h1>    
        </div>
        <div id="content">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Incidencias" BackColor="Transparent" BorderWidth="0" ForeColor="#3400FF"/>
            <h1>Envío Extraviado.</h1>
            
            <asp:Label ID="Texto" runat="server" Text="El día 20/04/2019 se registró que el envío no había sido entregado,
                ya que se había extraviado por el camino.
                La incidencia no requiero devolución, ya que..."></asp:Label>
        </div>
    </div>
</asp:Content>
