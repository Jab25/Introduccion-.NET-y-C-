<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Alumnos.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
    <asp:Label ID="lblHidden" runat="server" Text=""></asp:Label>
    <ajaxToolkit:ModalPopupExtender ID="mpeModal" runat="server" TargetControlID="lblHidden" PopupControlID="myModalservidor" DropShadow="true" BackgroundCssClass="modalBackground"></ajaxToolkit:ModalPopupExtender>

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

	<asp:Button id="btnIMSS" OnClick ="btnIMSS_Click" runat ="server" type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModalservidor" Text="IMSS" />
	<button type="button" runat="server" class="btn btn-info" OnClick="LLamaAJAXPost();" data-toggle="modal" data-target="#myModalcliente">ISR</button>

<div id="myModalservidor">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Cálculo del IMSS</h4>
                    <asp:Button ID="btnX" runat="server" Text="&times;" class="close" />
                </div>
                <!-- Cuerpo de la Modal -->
                <div class="modal-body">
		  <dl class="dl-horizontal">
			<dt>
				Enfermedades y Maternidad: 
			</dt>
			<dd>
				<asp:Label ID="EM" runat="server" Text="-"></asp:Label>
			</dd>
		</dl>
		  <dl class="dl-horizontal">
			<dt>
				Invalidez y Vida: 
			</dt>
			<dd>
				<asp:Label ID="IV" runat="server" Text="-"></asp:Label>
			</dd>
		</dl>
		  <dl class="dl-horizontal">
			<dt>
				Retiro: 
			</dt>
			<dd>
				<asp:Label ID="RO" runat="server" Text="-"></asp:Label>
			</dd>
		</dl>
		  <dl class="dl-horizontal">
			<dt>
				Cesantia: 
			</dt>
			<dd>
				<asp:Label ID="CA" runat="server" Text="-"></asp:Label>
			</dd>
		</dl>
		  <dl class="dl-horizontal">
			<dt>
				Credito Infonavit: 
			</dt>
			<dd>
				<asp:Label ID="CI" runat="server" Text="-"></asp:Label>
			</dd>
		</dl>
                <!-- Modal footer -->
                <div class="modal-footer">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cerrar" CssClass="btn btn-danger" />
                </div>
            </div>
				</div>
			</div>
	</div>

	<div class="form-group">
		<div class="col-md-2">
			<a href="Index.aspx">Regrese a la lista</a>
		</div>
		</div>

	 <!-- Ventana Modal -->
    <div class="modal" id="myModalcliente">
        <div class="modal-dialog">
            <div class="modal-content">

                <!-- Encabezado Modal -->
                <div class="modal-header">
                    <h4 class="modal-title">Calculo de ISR</h4>
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                </div>

                <!-- Curepo de la Modal -->
                <div class="modal-body">    
                    <dl>
                        <dt>límite inferior: 
                        </dt>
                        <dd>
                            <asp:Label ID="lblLimInt" runat="server" Text="Label"></asp:Label>
                        </dd>
                    </dl>
                </div>

				<div class="modal-body">    
                    <dl>
                        <dt>límite superior: 
                        </dt>
                        <dd>
                            <asp:Label ID="lblsup" runat="server" Text="Label"></asp:Label>
                        </dd>
                    </dl>
                </div>

				<div class="modal-body">    
                    <dl>
                        <dt>cuota Fija: 
                        </dt>
                        <dd>
                            <asp:Label ID="lblcuota" runat="server" Text="Label"></asp:Label>
                        </dd>
                    </dl>
                </div>

				<div class="modal-body">    
                    <dl>
                        <dt>excedente: 
                        </dt>
                        <dd>
                            <asp:Label ID="lblexede" runat="server" Text="Label"></asp:Label>
                        </dd>
                    </dl>
                </div>

				<div class="modal-body">    
                    <dl>
                        <dt>subsidio: 
                        </dt>
                        <dd>
                            <asp:Label ID="lblsub" runat="server" Text="Label"></asp:Label>
                        </dd>
                    </dl>
                </div>

				<div class="modal-body">    
                    <dl>
                        <dt>impuesto: 
                        </dt>
                        <dd>
                            <asp:Label ID="lblimpuest" runat="server" Text="Label"></asp:Label>
                        </dd>
                    </dl>
                </div>
                <!-- Modal footer -->
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                </div>

            </div>
        </div>
    </div>



	<script type="text/javascript">
	function LLamaAJAXPost() {
        var urlws = 'https://localhost:44381/alumno.asmx/CalcularISR'

        const valores = window.location.search;
        const urlParams = new URLSearchParams(valores);
        var id = urlParams.get("id");
        var alumno = { id: parseInt(id) };
        var parametros = JSON.stringify(alumno);

            $.ajax({
                type: 'POST',
                url: urlws,
                data: parametros,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: RecibeObjeto,
                error: errorGenerico
            });

        }
		
        function RecibeObjeto(data) {
            try {
                imss = data.d;
                if (imss != null) {
                    $('#<%=lblLimInt.ClientID%>').html(imss.límiteinferior);
                    $('#<%=lblsup.ClientID%>').html(imss.límitesuperior);
                    $('#<%=lblcuota.ClientID%>').html(imss.cuotaFija);
                    $('#<%=lblexede.ClientID%>').html(imss.excedente);
                    $('#<%=lblsub.ClientID%>').html(imss.subsidio);
                    $('#<%=lblimpuest.ClientID%>').html(imss.impuesto);
                    $('#myModalISR').modal('show');
                }
                else {
                    alert('La respuesta recibida del Web Service es incorrecta ' + data.d);
                }
            }
            catch (ex) {
                alumno = [];
                alert('Error al recibir los datos');
            }
        }
        function errorGenerico(jqXHR, exception) {
            var msg = '';
            if (jqXHR.status === 0) {
                msg = 'No está conectado, favor de verificar su conexión.';
            }
            else if (jqXHR.status === 404) {
                msg = 'Página no encontrada [404]';
            }
            else if (jqXHR.status === 500) {
                msg = 'Error no hay conexión al servidor [500]';
            }
            else if (jqXHR.status === 'parseerror') {
                msg = 'El parseo del JSON es erróneo.';
            }
            else if (jqXHR.status === 'timeout') {
                $('body').addClass('loaded');
            }
            else if (jqXHR.status === 'abort') {
                msg = 'La petición Ajax fue abortada.';
            }
            else {
                msg = 'Error no conocido. ';
                console.log(exception);
            }
            alert(msg);
        }
    </script>
</div>
</asp:Content>
