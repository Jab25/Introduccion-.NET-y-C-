<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentacion.Alumnos.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-vertical">
    <h2>AGREGAR ALUMNO</h2>
    <hr />
    <div class="form-group">
        <asp:Label ID="Label2" runat="server" class="control-label col-md-2">Nombre</asp:label>
        <div>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Llenar todos los campos" ControlToValidate="txtNombre" CssClass="text-danger"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="Label3" runat="server" class="control-label col-md-2">Primer apellido</asp:Label>
        <div>
            <asp:TextBox ID="txtPriApe" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Llenar todos los campos" ControlToValidate="txtPriApe" CssClass="text-danger"></asp:RequiredFieldValidator>
   </div>
   <div class="form-group">
        <asp:Label ID="Label1" runat="server" class="control-label col-md-2">Segundo apellido</asp:Label>
        <div>
            <asp:TextBox ID="txtSegApe" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <asp:Label ID="Label6" runat="server" class="control-label col-md-2">Correo</asp:Label>
        <div>
            <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Llenar todos los campos" ControlToValidate="txtCorreo" CssClass="text-danger"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="Label7" runat="server" class="control-label col-md-2">Telefono</asp:Label>
        <div>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Ingresar solo 10 digitos" ControlToValidate="txtTelefono" CssClass="text-danger" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="Label4" runat="server" class="control-label col-md-2">Fecha de nacimiento</asp:Label>
        <div>
            <asp:TextBox ID="txtFecNac" runat="server" CssClass="form-control text-box single-line" TextMode="Date"></asp:TextBox>
        </div>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtFecNac" CssClass="text-danger" ErrorMessage="Fuera del limite" MaximumValue="2000/12/31" MinimumValue="1990/01/01" Type="Date"></asp:RangeValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="Label5" runat="server" class="control-label col-md-2">CURP</asp:Label>
        <div>
            <asp:TextBox ID="txtCURP" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
            <asp:RegularExpressionValidator ID="ValidarCurp" runat="server" ErrorMessage="No cumple con el formato" ControlToValidate="txtCURP" CssClass="text-danger" ValidationExpression="[A-Z]{4}[0-9]{6}[H|M][A-Z]{2}[B-DF-HJ-NP-TV-Z]{3}[A-Z&amp;0-9]{2}"></asp:RegularExpressionValidator>
    </div>
    <div class="form-group">
        <asp:Label ID="Label8" runat="server" class="control-label col-md-2">Estado</asp:Label>
        <div>
            <asp:DropDownList ID="ddlEstado" runat="server" Height="35px" Width="317px" CssClass="form-control text-box single-line"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <asp:Label ID="Label9" runat="server" class="control-label col-md-2">Estatus</asp:Label>
        <div>
            <asp:DropDownList ID="ddlEstatus" runat="server" CssClass="form-control text-box single-line" Height="35px" Width="315px"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <div>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-default" OnClick="btnGuardar_Click"/>
        </div>
    </div>
    <div class="form-group">
        <div>
            <a href="Index.aspx">Regrese a la lista</a>
        </div>
    </div> 
</div>
</asp:Content>
