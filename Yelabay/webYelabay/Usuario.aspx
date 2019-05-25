<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="webYelabay.Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id ="innerContainer">
        <br />
        <br />
        <br />
        <div id ="title">
            <div class="center">
                <h1><asp:Image ID="Image1" runat="server" ImageUrl="images/VectorPerfil.png" Height="50px" Width="84px" /></h1>
                <h1>Mis datos</h1>
                <h1><asp:Image ID="Image2" runat="server" ImageUrl="images/VectorPerfil.png" Height="50px" Width="84px" /></h1>
            </div>
        </div>
    </div>
    <div id="content">
        <div class="invisibleRow">
                <div class="invisibleCol">
                    <asp:Button ID="ButtonModify" style="background:#249cf4" runat="server" Text="Actualizar Información" OnClick="ButtonModify_Click" />
                </div>
                <div class="invisibleCol">
                    <asp:Button ID="ButtonPedidos" style="background:#249cf4" runat="server" Text="Ver mis pedidos" OnClick="ButtonPedidos_Click" />
                </div>
                <div class="invisibleCol">
                    <asp:Button ID="ButtonReclamaciones" style="background:#249cf4" runat="server" Text="Ver mis reclamaciones" OnClick="ButtonReclamaciones_Click" />
                </div>
                <div class="invisibleCol">
                    <asp:Button ID="ButtonNuevaReclamacion" style="background:#249cf4" runat="server" Text="Crear nueva reclamación" OnClick="ButtonNuevaReclamacion_Click" />
                </div>
        </div>
        <div class="invisibleRow">
            <div class="invisibleCol"><b>Nombre:</b></div>
            <div class="invisibleCol">
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </div>
            <asp:Label ID="LabelErrorName" runat="server" CssClass="ErrorMessage" Text="¡Nombre Obligatorio! Solo debe contener letras."></asp:Label>
        </div>
        <div class="invisibleRow">
                <div class="invisibleCol"><b>Apellidos:</b></div>
                <div class="invisibleCol">
                    <asp:TextBox ID="TextBoxLastname" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="LabelErrorLastname" runat="server" CssClass="ErrorMessage" Text="¡Apellido Obligatorios! Solo deben contener letras."></asp:Label>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol"><b>Teléfono:</b></div>
                <div class="invisibleCol">
                    <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
                </div>
                <asp:Label ID="LabelErrorPhone" runat="server" CssClass="ErrorMessage" Text="¡Teléfono NO válido!"></asp:Label>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol"><b>Correo electronico:</b></div>
                <div class="invisibleCol">
                    <asp:Label ID="LabelEmail" runat="server" ></asp:Label>
                </div>
            </div>
            <div class="invisibleRow">
                <div class="invisibleCol"><b>Nick:</b></div>
                <div class="invisibleCol">
                    <asp:Label ID="LabelUsername" runat="server" ></asp:Label>
                </div>
            </div>
        </div>
</asp:Content>

