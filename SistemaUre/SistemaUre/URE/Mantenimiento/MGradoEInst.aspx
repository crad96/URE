 <%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MGradoEInst.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MGradoEInst" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
      <h1>DOCENTE 
        <small>Grados e Instruccionnes</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Level</a></li>
        <li class="active">Here</li>
      </ol>
        </asp:Content>

    <asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">        
        
        <div style="vertical-align: 50%">
            <div class="row">
                 <div class="col-md-4 col-md-offset-3">
                  <input id="txtDNI" type="text" class="form-control" placeholder="Ingrese DNI"/>
                 </div>
            </div>
       </div>
       <br />
     
        <div class="row" >
                 <div class="col-md-4 col-md-offset-3">
                     <asp:TextBox ID="TextBox3" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox></div>   
        </div>
        <br>

        
        

      <div class="panel panel-primary">
         <div class="panel-heading">
             <font size=4>DATOS PROFESIONALES</font>
         </div>
        <!--  <div class="panel-body">Panel Content</div> -->
          <br>
          <div class="btn-toolbar" role="toolbar">

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
              <br>
              <br>

              <div class="row">
                  <div align="center">
                      <table>
                          <tr>
                              <td>
                                  <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-danger" Width="100px" Text="Guardar" />
                              </td>
                              <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                              <td>
                                  <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Width="100px" Text="Cancelar" />
                              </td>
                          </tr>
                      </table>
                  </div>
              </div>


          </div>
      </div>

        <br />



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