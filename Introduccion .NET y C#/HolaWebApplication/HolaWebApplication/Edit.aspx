<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="HolaWebApplication.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
	<h2>Actualizar</h2>
        <p>&nbsp;</p>        
		<dl >
		<dt style="font-family: 'Bell MT'; font-size: medium">
			Nombre&nbsp;&nbsp;&nbsp;&nbsp;
		    <asp:TextBox ID="txtNombre" runat="server" BorderStyle="Double" Width="225px"></asp:TextBox>
		</dt>
	</dl>
	<dl >
		<dt style="font-family: 'Bell MT'; font-size: medium">
			Clave&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
		    <asp:TextBox ID="txtClave" runat="server" BorderStyle="Double" Width="223px"></asp:TextBox>
		</dt>
	</dl>
    <div>
		<div >
			<a href="Index.aspx">Regresar a la lista</a>
		</div>
	</div>
	   <div>
		<div >
	&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
	<asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" BackColor="#0066CC" />
		</div>
	</div>
</div>
</asp:Content>
