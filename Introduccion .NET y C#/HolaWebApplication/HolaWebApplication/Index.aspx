<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HolaWebApplication.inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Indice</h3>
    <p>&nbsp;</p>

    &nbsp;

    <asp:DropDownList ID="listContenido" runat="server" Height="40px" Width="176px" OnSelectedIndexChanged="listContenido_SelectedIndexChanged"> 
        </asp:DropDownList>
    <br />
    <br />
    <br />
    <div>
        <div>
            <asp:LinkButton ID="btnAgregar" runat="server" href="Create.aspx" CssClass="btn btn-primary btn-sm" Height="23px" OnClick="btnAgregar_Click" Width="64px">Agregar</asp:LinkButton>        
        &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="btnDetalles" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnDetalles_Click" Height="22px" Width="61px">Detalles</asp:LinkButton>        
        &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="btnEditar" runat="server" CssClass="btn btn-primary btn-sm" OnClick="btnEditar_Click" Height="24px" Width="51px">Editar</asp:LinkButton>        
        &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="btnEliminar" runat="server" CssClass="btn btn-primary btn-sm" Height="23px" OnClick="btnEliminar_Click" Width="66px">Eliminar</asp:LinkButton>        
            <br />
        </div>
    </div>
</asp:Content>
