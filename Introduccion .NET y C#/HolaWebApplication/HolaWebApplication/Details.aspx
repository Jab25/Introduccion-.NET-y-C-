<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="HolaWebApplication.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
	<h2>Detalles</h2>        
	<hr />
	<dl >
		<dt style="font-family: 'Bell MT'; font-size: medium">
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="lblid" runat="server" BorderStyle="Double" Width="160px"></asp:Label>
		</dt>
	</dl>
		<dl >
		<dt style="font-family: 'Bell MT'; font-size: medium">
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			Nombre&nbsp;
			<asp:Label ID="lblNombre" runat="server" BorderStyle="Double" Width="160px"></asp:Label>
		&nbsp;</dt>
	</dl>
	<dl >
		<dt style="font-family: 'Bell MT'; font-size: medium">
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			Clave&nbsp;&nbsp;&nbsp; &nbsp;
			<asp:Label ID="lblClave" runat="server" BorderStyle="Double" Width="160px"></asp:Label>
		</dt>
	</dl>
    <div>
		<div >
			<a href="Index.aspx">Regresar a la lista</a>
		</div>
	</div>
</div>
</asp:Content>
