<%@ Page Title="" Language="C#" MasterPageFile="~/URE/CRUD/CRUD.Master" AutoEventWireup="true" CodeBehind="CRUDIdiomas.aspx.cs" Inherits="SistemaUre.URE.CRUD.CRUDIdiomas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div class="panel panel-primary">
        <div class="panel-heading">IDIOMAS</div>
        <!--  <div class="panel-body">Panel Content</div> -->
        <br>
        <div class="btn-toolbar" role="toolbar">
            <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#myModal">
             <span class="glyphicon glyphicon-plus-sign"></span> Agregar
            </button>
        </div>

        <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Agregar...</h4>
              </div>
                <div class="modal-body">
                  <div class="row">                                    
                      <div class="col-md-2">Idioma:</div>
                      <div class="col-md-10"><asp:TextBox ID="TextBox9" CssClass="form-control" runat="server"></asp:TextBox></div>            
                  </div>

                   <div class="row">                    
                    <div class="col-md-2">Vive en :</div>
                    <div class="col-md-6">
                       <label class="radio-inline"><input type="radio" name="optradio3">Edificio</label>
                       <label class="radio-inline"><input type="radio" name="optradio4">Calle</label>        
                        <asp:CheckBox ID="CheckBox1" runat="server" />                                                         
                     </div> 
                </div>


                </div>

            <div class="modal-footer">
                <asp:Button ID="btnAgregarFacu" CssClass="col-md-2 btn btn-success" runat="server" Text="Agregar" />
                <button class="btn btn-primary" data-dismiss="modal" aria-hidden="true">Cerrar</button>
            </div>
        </div>
       </div>
  </div>
 </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
