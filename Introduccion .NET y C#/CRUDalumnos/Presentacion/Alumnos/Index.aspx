<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Alumnos.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>LISTADO DEL ALUMNOS</h2>        
	<hr />

    <div class="form-group">
        <div>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary"/>
        </div>
    </div>
    <div class="form-group">
        <div>
    <asp:GridView ID="gvLista" runat="server" AllowPaging="True" BorderStyle="None" GridLines="Horizontal" OnPageIndexChanging="gvLista_PageIndexChanging" OnRowCommand="gvLista_RowCommand" OnSelectedIndexChanged="gvLista_SelectedIndexChanged1" PageSize="8" AutoGenerateColumns="False" EnableModelValidation="False" Width="100%">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="primerApellido" HeaderText="Primer Apellido" />
            <asp:BoundField DataField="segundoApellido" HeaderText="Segundo Apellido" />
            <asp:BoundField DataField="correo" HeaderText="Correo" />
            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
            <asp:BoundField DataField="Estado" HeaderText="Estado Origen" />
            <asp:BoundField DataField="Estatus" HeaderText="Estatus" />
            <asp:ButtonField CommandName="Detalles" Text="Detalles">
            <ControlStyle CssClass="btn btn-warning" />
            </asp:ButtonField>
            <asp:ButtonField CommandName="Editar" Text="Editar">
            <ControlStyle CssClass="btn btn-success" />
            </asp:ButtonField>
            <asp:ButtonField CommandName="Eliminar" Text="Eliminar">
            <ControlStyle CssClass="btn btn-danger" />
            </asp:ButtonField>
        </Columns>
        <EditRowStyle BorderStyle="None" />
        <PagerStyle BorderStyle="None" />
        <RowStyle BorderStyle="None" />
        <SelectedRowStyle BorderStyle="Solid" />
    </asp:GridView>
            </div>
        </div>
</asp:Content>
