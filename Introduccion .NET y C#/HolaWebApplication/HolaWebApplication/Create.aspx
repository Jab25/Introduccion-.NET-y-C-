<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="HolaWebApplication.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div>
	<h2>Agregar</h2>        
	<hr />
		<dl >
		<dt style="font-family: 'Bell MT'; font-size: medium">
			Nombre&nbsp;&nbsp;
			<asp:TextBox ID="txtNombre" runat="server" BorderStyle="Double" Width="146px"></asp:TextBox>
		</dt>
	</dl>
	<dl >
		<dt style="font-family: 'Bell MT'; font-size: medium">
			Clave&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
			<asp:TextBox ID="txtClave" runat="server" BorderStyle="Double" Width="144px"></asp:TextBox>
		</dt>
	</dl>
    <div>
		<div >
			<a href="Index.aspx">Regresar a la lista</a>
		    <br />
		</div>
	</div>
	   <div>
		<div >
	<asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" BackColor="#0066CC" ForeColor="Black" />
		&nbsp;
	<asp:Button ID="btnAgregar" runat="server" Text="Agregar" BackColor="#0066CC" />
		</div>
	</div>
		<div>
		<div >
		    <br />
		</div>
	</div>
</div>
</asp:Content>
