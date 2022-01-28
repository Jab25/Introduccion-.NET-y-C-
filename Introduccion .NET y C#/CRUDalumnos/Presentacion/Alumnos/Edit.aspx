<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Presentacion.Alumnos.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
    <h2>ACTUALIZAR ALUMNO</h2>
    <hr />
    <div class="form-group">
        <asp:Label ID="Label10" runat="server" class="control-label col-md-2">ID</asp:Label>
        <div>
            <asp:TextBox ID="txtID" runat="server" Enabled="False" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
            <asp:Label ID="Label2" runat="server" class="control-label col-md-2">Nombre</asp:Label>
        <div>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <div>
            <asp:Label ID="Label3" runat="server" class="control-label col-md-2">Primer apellido</asp:Label>
            <asp:TextBox ID="txtPriApe" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" class="control-label col-md-2">Segundo apellido</asp:Label>
            <asp:TextBox ID="txtSegApe" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <div>
            <asp:Label ID="Label6" runat="server" class="control-label col-md-2">Correo</asp:Label>
            <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <div>
            <asp:Label ID="Label7" runat="server" class="control-label col-md-2">Telefono</asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server" placeholder="99-9999-9999" TextMode="Phone" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <div>
            <asp:Label ID="Label4" runat="server" class="control-label col-md-2">Fecha de nacimiento</asp:Label>
            <asp:TextBox ID="txtFecNac" runat="server" TextMode="Date" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <div>
            <asp:Label ID="Label5" runat="server" class="control-label col-md-2">CURP</asp:Label>
            <asp:TextBox ID="txtCURP" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
    </div>

    <div class="form-group">
        <div>
            <asp:Label ID="Label8" runat="server" class="control-label col-md-2">Estado</asp:Label>
            <asp:DropDownList ID="ddlEstado" runat="server" Height="35px" Width="317px" CssClass="form-control text-box single-line"></asp:DropDownList>
        </div>
    </div>

    <div class="form-group">
        <div>
            <asp:Label ID="Label9" runat="server" class="control-label col-md-2">Estatus</asp:Label>
            <asp:DropDownList ID="ddlEstatus" runat="server" Height="35px" Width="315px" CssClass="form-control text-box single-line"></asp:DropDownList>
        </div>
    </div>

    <div class="form-group">
        <div>
            <asp:Button ID="btnGuardar" runat="server" Text="Actualizar" OnClick="btnGuardar_Click" CssClass="btn btn-default"/>
        </div>
    </div>
    <div class="form-group">
        <div>
            <a href="Index.aspx">Regrese a la lista</a>
        </div>
    </div>        
</div> 
</asp:Content>
