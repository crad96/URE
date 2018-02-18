<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MDFamilia.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MDFamilia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    <h1>
        Docente
        <small>Registro Familiares</small>
    </h1>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div style="vertical-align: 50%">
        <div class="row">
            <div class="col-md-4 col-md-offset-3">
                <input id="txtDNI" type="text" class="form-control" placeholder="Ingrese DNI" />
            </div>
        </div>
    </div>
    <br />

    <div class="row">
        <div class="col-md-4 col-md-offset-3">
            <asp:TextBox ID="TextBox3" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
        </div>
    </div>
    <br>

    <!-- --------------- Panel--------- -->
    <div class="panel panel-primary">
        <div class="panel-heading">Familia</div>
        <div class="panel-body">

             <div class="row">                   
                    <div class="col-md-2">DNI :</div>
                    <div class="col-md-5"><asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox></div>
                </div>
                <br>
                 
                <div class="row">
                     <div class="col-md-2">A.Paterno :</div>
                     <div class="col-md-4"><asp:TextBox ID="TextBox11" CssClass="form-control" runat="server"></asp:TextBox></div>
                     <div class="col-md-2">A.Materno :</div>
                     <div class="col-md-4"><asp:TextBox ID="TextBox14" CssClass="form-control" runat="server"></asp:TextBox></div>                            
                </div>
                 <br>


                 <div class="row">                    
                     <div class="col-md-2">Nombres :</div>
                     <div class="col-md-4"><asp:TextBox ID="TextBox30" CssClass="form-control" runat="server"></asp:TextBox></div>
                     <div class="col-md-2">Edad :</div>
                     <div class="col-md-2"><asp:TextBox ID="TextBox16" CssClass="form-control" runat="server"></asp:TextBox></div>          
                </div>
                <br>

                <div class="row">
                    <div class="col-md-2">Departamento</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="DropDownList12" CssClass="form-control" runat="server">
                          <asp:ListItem>Lima</asp:ListItem>
                          <asp:ListItem>Nose</asp:ListItem>
                        </asp:DropDownList>

                    </div>
                    <div class="col-md-2">Provincia</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="DropDownList13" CssClass="form-control" runat="server">
                              <asp:ListItem>Huaura</asp:ListItem>
                              <asp:ListItem>Nose x2</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <br><br>
                    <div class="col-md-2">Distrito</div>
                    <div class="col-md-4">
                        <asp:DropDownList ID="DropDownList14" CssClass="form-control" runat="server">
                            <asp:ListItem>Santa Maria</asp:ListItem>
                            <asp:ListItem>Nose x3</asp:ListItem>
                        </asp:DropDownList>
                    </div>
              
                    <div class="col-md-2">Fecha Nac :</div>
                     <div class="col-md-2">
                        <div class='input-group date' id='datetimepicker3'>
                             <input class="form-control" id="ex3" type="date"/>
                        </div></div>                    
               </div>
                <br>
                
                <div class="row">
                    <div class="col-md-2">Tipo Familia:</div>
                     <div class="col-md-2"><asp:TextBox ID="TextBox27" CssClass="form-control" runat="server"></asp:TextBox></div> 
                     <div class="col-md-2">Instrucción:</div>
                     <div class="col-md-2"><asp:TextBox ID="TextBox19" CssClass="form-control" runat="server"></asp:TextBox></div>                    
                     <div class="col-md-2">Ocupación :</div>
                     <div class="col-md-2"><asp:TextBox ID="TextBox25" CssClass="form-control" runat="server"></asp:TextBox></div>          
                </div>
                <br>

                <div class="row">
                    <div class="col-md-2">Profesión :</div>
                     <div class="col-md-5"><asp:TextBox ID="TextBox21" CssClass="form-control" runat="server"></asp:TextBox></div>
                     <div class="col-md-2">Lugar de Trabajo :</div>
                     <div class="col-md-3"><asp:TextBox ID="TextBox26" CssClass="form-control" runat="server"></asp:TextBox></div>
                                               
                </div>
             
        </div>


        <script type="text/javascript">
            function ConfirmaButon(mensaje) {
                return confirm(mensaje);
            }
        </script>

        <div class="btn-toolbar" role="toolbar">
            <asp:Button ID="btnIngresar_Especializacion" runat="server" class="btn btn-lg btn-primary"  Text="Agregar"></asp:Button>
            <asp:Button ID="btnCancelar_Especializacion" runat="server" class="btn btn-lg btn-danger"  Text="Cancelar"></asp:Button>
       
        </div>
        <br />
        <div class="panel-body">
        </div>


 </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
