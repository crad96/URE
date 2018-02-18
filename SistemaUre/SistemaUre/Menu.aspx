<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="SistemaUre.Menu1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPrincipal" runat="server">

    <section id="Section-1" class="fullbg">
<div class="section-divider">
</div>
<div class="container">
<div class="row">
	<div class="page-header text-center col-sm-12 col-lg-12 color-white animated fade">
		<h1>Modulos</h1>
		<p class="lead">
			 Modulos del Sistema Unidad de Registro y Escalafon
		</p>
	</div>
</div>
<div class="row color-white">
	<div class="col-md-12 animated fadeInUpNow">

       <asp:Panel ID="PanelDocente" runat="server">
		<asp:LinkButton ID="BTNDOCENTE" runat="server" OnClick="BTNDOCENTE_Click">
            <div class="boxservice">
			    <i class="fa fa-user"></i>
			    <h3>Modulo Docente</h3>
			    <p>
				    Ingresar, actualizar y eliminar registros de Docentes.
			    </p>
		        </div>
         </asp:LinkButton>
       </asp:Panel>

        <asp:Panel ID="PanelAdministrativo" runat="server">
            <asp:LinkButton ID="BTNADMINISTRATIVO" runat="server" OnClick="BTNADMINISTRATIVO_Click">
		        <div class="boxservice">
			        <i class="fa fa-user"></i>
			        <h3>Modulo Administrativo</h3>
			        <p>
				        Ingresar, actualizar y eliminar registros de Administrativo.
			        </p>
		        </div>
            </asp:LinkButton>
        </asp:Panel>

        <asp:Panel ID="PanelMantenimiento" runat="server">
            <asp:LinkButton ID="BTNMANTENIMIENTO" runat="server">
		        <div class="boxservice rightb">
			        <i class="fa fa-list-alt"></i>
			        <h3>Mantenimiento</h3>
			        <p>
				        Ingresar, actualizar y eliminar registros (Mantenimiento)              
			        </p>
		        </div>
            </asp:LinkButton>
        </asp:Panel>

        <asp:Panel ID="PanelReporte" runat="server">
            <asp:LinkButton ID="BTNREPORTE" runat="server">
		        <div class="boxservice rightb">
			        <i class="fa fa-list-alt"></i>
			        <h3>Reporte</h3>
			        <p>
				        Seccion de  Reportes Generales (Idea de Kattyyyyyyyyyyyyyyyy)
			        </p>
		        </div>
            </asp:LinkButton>
        </asp:Panel>
	</div>
</div>
<!-- end row -->
</div>
</section> 

</asp:Content>
