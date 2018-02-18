<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MAGradosEInst.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MAGradosEInst" %>
<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
      <h1>ADMINISTRATIVO     
        <small>Grados e Instruccionnes</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Level</a></li>
        <li class="active">Here</li>
      </ol>
        </asp:Content>

    <asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">


        <div class="panel panel-primary">
            <div class="panel-heading">
                <font size="4">DATOS PROFESIONALES</font>
            </div>
            <!--  <div class="panel-body">Panel Content</div> -->
            <br>
            <div class="btn-toolbar" role="toolbar">


                <div class="row">
                    <div class="col-md-2 col-md-offset-1">Primaria:</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox></div>
                    <div class="col-md-2">Secundaria:</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox7" CssClass="form-control" runat="server"></asp:TextBox></div>
                </div>
                <br />


                <div class="row">
                    <div class="col-md-2 col-md-offset-1">Titulo Profesional</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox></div>
                    <div class="col-md-2">Universidad</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox></div>
                </div>
                <br />

                <div class="row">
                    <div class="col-md-2 col-md-offset-1">Fecha</div>
                    <div class="col-md-3">
                        <div class='input-group date' id='datetimepicker7'>
                            <input class="form-control" id="ex7" type="date" />
                        </div>
                    </div>

                    <div class="col-md-2">Otra Profesion</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox6" CssClass="form-control" runat="server"></asp:TextBox></div>
                </div>

                <br />

                <div class="row">
                    <div class="col-md-1 col-md-offset-1">Colegio Profesional</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox></div>
                    <div class="col-md-1">N° de Colegiatura</div>
                    <div class="col-md-1">
                        <asp:TextBox ID="TextBox5" CssClass="form-control" runat="server"></asp:TextBox></div>
                    <div class="col-md-2">Fecha-Constancia de Habilitacion</div>
                    <div class="col-md-2">
                        <div class='input-group date' id='datetimepicker4'>
                            <input class="form-control" id="ex4" type="date" />
                        </div>
                    </div>
                </div>

                <br />

                <br />
                <div class="row">
                    <div class="col-md-2 col-md-offset-1">Maestria</div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="DropDownList7" CssClass="form-control" runat="server">
                            <asp:ListItem>Incompleta</asp:ListItem>
                            <asp:ListItem>Completa</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2">Mension</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox23" CssClass="form-control" runat="server"></asp:TextBox></div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-2 col-md-offset-1">Universidad</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox24" CssClass="form-control" runat="server"></asp:TextBox></div>
                    <div class="col-md-2">Fecha</div>
                    <div class="col-md-3">
                        <div class='input-group date' id='datetimepicker1'>
                            <input class="form-control" id="ex" type="date" />
                        </div>
                    </div>
                </div>


                <br />

                <div class="row">
                    <div class="col-md-2 col-md-offset-1">Doctorado</div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="DropDownList8" CssClass="form-control" runat="server">
                            <asp:ListItem>Incompleta</asp:ListItem>
                            <asp:ListItem>Completa</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2">Mension</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox8" CssClass="form-control" runat="server"></asp:TextBox></div>

                </div>
                <br />
                <div class="row">
                    <div class="col-md-2 col-md-offset-1">Universidad</div>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox9" CssClass="form-control" runat="server"></asp:TextBox></div>
                    <div class="col-md-2">Fecha</div>
                    <div class="col-md-3">
                        <div class='input-group date' id='datetimepicker2'>
                            <input class="form-control" id="ex2" type="date" />
                        </div>
                    </div>
                </div>

                <br />

            </div>
        </div>
        <br>
        
       
         


        <div class="panel panel-primary">
            <div class="panel-heading">DISTINCIONES RECIBIDAS</div>
            <!--  <div class="panel-body">Panel Content</div> -->
            <br>
            <div class="btn-toolbar" role="toolbar">
                <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#myModal3">
                    <span class="glyphicon glyphicon-plus-sign"></span>Agregar
                </button>
            </div>

            <div class="modal fade" id="myModal3" role="dialog" aria-labelledby="myModalLabel3" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                            <h4 class="modal-title">Agregar...</h4>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-md-4">Entidad :</div>
                                <div class="col-md-8">
                                    <asp:TextBox ID="TextBox14" CssClass="form-control" runat="server"></asp:TextBox></div>
                            </div>
                            <br />

                            <div class="row">
                                <div class="col-md-4">Distincion :</div>
                                <div class="col-md-8">
                                    <asp:TextBox ID="TextBox16" CssClass="form-control" runat="server"></asp:TextBox></div>
                            </div>
                            <br />



                            <div class="row">

                                <div class="col-md-2 col-md-offset-2">F. Desde:</div>
                                <div class="col-md-4">
                                    <div class='input-group date' id='datetimepicker11'>
                                        <input class="form-control" id="ex11" type="date" />
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="modal-footer">
                            <asp:Button ID="Button2" CssClass="col-md-2 btn btn-success" runat="server" Text="Agregar" />
                            <button class="btn btn-primary" data-dismiss="modal" aria-hidden="true">Cerrar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>



        <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h4 class="modal-title">Seleccione...</h4>


                    </div>
                    <div class="modal-body">

                        <div class="row">
                            <div class="col-md-2">Departamento</div>
                            <div class="col-md-4">
                                <asp:DropDownList ID="DropDownList4" CssClass="form-control" runat="server">
                                    <asp:ListItem>Lima</asp:ListItem>
                                    <asp:ListItem>Nose</asp:ListItem>
                                </asp:DropDownList>

                            </div>
                            <div class="col-md-2">Provincia</div>
                            <div class="col-md-4">
                                <asp:DropDownList ID="DropDownList5" CssClass="form-control" runat="server">
                                    <asp:ListItem>Huaura</asp:ListItem>
                                    <asp:ListItem>Nose x2</asp:ListItem>
                                </asp:DropDownList>

                            </div>
                            <div class="col-md-2">Distrito</div>
                            <div class="col-md-4">
                                <asp:DropDownList ID="DropDownList6" CssClass="form-control" runat="server">
                                    <asp:ListItem>Santa Maria</asp:ListItem>
                                    <asp:ListItem>Nose x3</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnAgregarLugarNacimiento" CssClass="col-md-2 btn btn-info" runat="server" Text="Agregar" />
                        <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Close</button>
                    </div>
                </div>
            </div>
        </div>

    <script type="text/javascript">
        $(function () {
            $('#datetimepicker1').datetimepicker({
                viewMode: 'years',
                format: 'MM/YYYY'
            });
        });
    </script>
</asp:Content>
<%--  --%>