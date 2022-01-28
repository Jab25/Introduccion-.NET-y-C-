<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Alumnos.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="form-horizontal">
	<h2>DATOS DEL ALUMNO</h2>        
	<hr />
	<dl class="dl-horizontal">
		<dt>
			id
		</dt>
		<dd>
			<asp:Label ID="lblID" runat="server" Text="-"></asp:Label>
		</dd>
	</dl>

    <dl class="dl-horizontal">
		<dt>
			Nombre
		</dt>
		<dd>
			<asp:Label ID="lblNombre" runat="server" Text="-"></asp:Label>
		</dd>
	</dl>

    <dl class="dl-horizontal">
		<dt>
			Primer apellido
		</dt>
		<dd>
			<asp:Label ID="lblPriApe" runat="server" Text="-"></asp:Label>
		</dd>
	</dl>

    <dl class="dl-horizontal">
		<dt>
			Segundo apellido
		</dt>
		<dd>
			<asp:Label ID="lblSegApe" runat="server" Text="-"></asp:Label>
		</dd>
	</dl>

    <dl class="dl-horizontal">
		<dt>
			Correo
		</dt>
		<dd>
			<asp:Label ID="lblCorreo" runat="server" Text="-"></asp:Label>
		</dd>
	</dl>

    <dl class="dl-horizontal">
		<dt>
			Telefono
		</dt>
		<dd>
			<asp:Label ID="lblTelefono" runat="server" Text="-"></asp:Label>
		</dd>
	</dl>

	<dl class="dl-horizontal">
		<dt>
			Fecha de nacimiento
		</dt>
		<dd>
			<asp:Label ID="lblFecNac" runat="server" Text="-"></asp:Label>
		</dd>
	</dl>

	<dl class="dl-horizontal">
		<dt>
			CURP
		</dt>
		<dd>
			<asp:Label ID="lblCURP" runat="server" Text="-"></asp:Label>
		</dd>
	</dl>

	<dl class="dl-horizontal">
		<dt>
			Estado
		</dt>
		<dd>
			<asp:Label ID="lblEstado" runat="server" Text="-"></asp:Label>
		</dd>
	</dl>

	<dl class="dl-horizontal">
		<dt>
			Estatus
		</dt>
		<dd>
			<asp:Label ID="lblEstatus" runat="server" Text="-"></asp:Label>
		</dd>
	</dl>

	<div class="form-group">
		<div class="col-md-2">
			<a href="Index.aspx">Regrese a la lista</a>
		</div>
	</div>
</div>
</asp:Content>
