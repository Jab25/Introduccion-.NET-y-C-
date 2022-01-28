<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="HolaWebApplication.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
	<h2>Eliminar</h2>        
	<hr />
	<dl >
		<dt style="font-size: medium; font-family: 'Bell MT'">
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
			<asp:Label ID="lblid" runat="server" BorderStyle="Double" Width="139px"></asp:Label>
		</dt>
	</dl>
		<dl >
		<dt style="font-size: medium; font-family: 'Bell MT'">
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			Nombre&nbsp;
			<asp:Label ID="lblNombre" runat="server" BorderStyle="Double" Width="138px"></asp:Label>
		</dt>
	</dl>
	<dl >
		<dt style="font-size: medium; font-family: 'Bell MT'">
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			Clave&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="lblClave" runat="server" BorderStyle="Double" Width="133px"></asp:Label>
		</dt>
	</dl>
    <div>
		<div >
			<a href="Index.aspx">Regresar a la lista</a>
		</div>
	</div>
	   <div>
		<div >
	<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" BackColor="#0066CC" />
		</div>
	</div>
</div>
</asp:Content>
