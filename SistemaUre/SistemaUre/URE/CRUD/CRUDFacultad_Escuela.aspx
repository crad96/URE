<%@ Page Title="" Language="C#" MasterPageFile="~/URE/CRUD/CRUD.Master"  EnableEventValidation="false" AutoEventWireup="true" CodeBehind="CRUDFacultad_Escuela.aspx.cs" Inherits="SistemaUre.URE.CRUD.CRUDFacultad_Escuela" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">

     <div class="panel panel-primary">
        <div class="panel-heading">FACULTAD</div>
    <asp:Panel ID="Panel_Facultad_vista" runat="server" Width="100%" Height="100%" Visible="true">
    <asp:GridView ID="GridViewListar_Facultad" runat="server" AutoGenerateColumns="False" OnRowEditing="GridViewListar_Facultad_RowEditing" OnRowCancelingEdit="GridViewListar_Facultad_RowCancelingEdit" OnRowUpdating="GridViewListar_Facultad_RowUpdating" 
        CellPadding="4" ForeColor="#333333" GridLines="None"  Width="100%" OnRowDeleting="GridViewListar_Facultad_RowDeleting">
             
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
             
        <Columns>
            <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate>
                    <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codigo")%>'></asp:Label>                   
                   
                </ItemTemplate>

            </asp:TemplateField>

            <asp:TemplateField HeaderText="Facultad">
                <ItemTemplate>                
                    <%# Eval("descripcion")%>                   
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtDescripcion" Text='<%# Eval("descripcion")%>' runat="server"/>
                </EditItemTemplate>

            </asp:TemplateField>

            <asp:TemplateField HeaderText="Estado">
                <ItemTemplate> 
                    <asp:Label ID="lblestado" runat="server" Text='<%# Eval("estado")%>'></asp:Label>                                                      
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Edit">

                <ItemTemplate>
                    <asp:LinkButton ID="btnUpd" CommandName="Edit" runat="server" Text="Edit "/>
                    <asp:LinkButton ID="BTNcambiar_estado" CommandName="delete" runat="server" Text=" Estado"/>
                    
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:LinkButton ID="btnSa" CommandName="Update" runat="server" Text="Update"/> 
                    <asp:LinkButton ID="btnCan" CommandName="Cancel" runat="server" Text="Cancel" />                    
                </EditItemTemplate>

            </asp:TemplateField>

        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>
</asp:Panel>
        <br>
        <div class="btn-toolbar" role="toolbar">
            <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#myModal">
             <span class="glyphicon glyphicon-plus-sign"></span> Agregar</button>


            
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
                      <div class="col-md-2">Nombre de Facultad :</div>
                      <div class="col-md-10"><asp:TextBox ID="txtDesc_Facultad" CssClass="form-control" runat="server"></asp:TextBox></div>            
                  </div>
                </div>

            <div class="modal-footer">
                <asp:Button ID="btnAgregarFacu" CssClass="col-md-2 btn btn-success" runat="server" Text="Agregar" OnClick="btnAgregarFacu_Click" />
                <button class="btn btn-primary" data-dismiss="modal" aria-hidden="true">Cerrar</button>
                
            </div>
        </div>
       </div>
  </div>
 </div>

     <br />
     <br />
    
<asp:Panel ID="PanelEscuela" runat="server">

    <div class="panel panel-primary">
        <div class="panel-heading">ESCUELA</div>
            
    <asp:GridView ID="GridViewListar_Escuela" runat="server" AutoGenerateColumns="False" OnRowEditing="GridViewListar_Escuela_RowEditing" OnRowCancelingEdit="GridViewListar_Escuela_RowCancelingEdit" OnRowUpdating="GridViewListar_Escuela_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None"
        Width="100%" OnRowDeleting="GridViewListar_Escuela_RowDeleting">
             
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
             
        <Columns>
            <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate>
                    <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codigo")%>'></asp:Label>                   
                   
                </ItemTemplate>

            </asp:TemplateField>

            <asp:TemplateField HeaderText="Escuela">
                <ItemTemplate>                
                    <%# Eval("descripcion_escuela")%>                   
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtDescripcion" Text='<%# Eval("descripcion_escuela")%>' runat="server"/>
                </EditItemTemplate>

            </asp:TemplateField>

            <asp:TemplateField HeaderText="Estado">
                <ItemTemplate> 
                    <asp:Label ID="lblestado" runat="server" Text='<%# Eval("estado")%>'></asp:Label>               
                                       
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Actualizar">
                <ItemTemplate>
                    <asp:LinkButton ID="btnUpd" CommandName="Edit" runat="server" Text="Edit"/>
                    <asp:LinkButton ID="btnCambiar" CommandName="delete" runat="server">Cambiar</asp:LinkButton>
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:LinkButton ID="btnSa" CommandName="Update" runat="server" Text="Update"/> 
                    <asp:LinkButton ID="btnCan" CommandName="Cancel" runat="server" Text="Cancel" />
                </EditItemTemplate>
            </asp:TemplateField>

        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>

        <br>
        <div class="btn-toolbar" role="toolbar">
            <asp:LinkButton ID="btnAgregar_Escuela" runat="server" class="btn btn-danger" data-toggle="modal" data-target="#myModal2">
                 <span class="glyphicon glyphicon-plus-sign"></span>
                Agregar Nueva Escuela
            </asp:LinkButton>

            

        </div>

        <div class="modal fade" id="myModal2" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Agregar...</h4>
              </div>
                <div class="modal-body">
                  <div class="row">                                    
                      <div class="col-md-2">Nombre de Escuela :</div>
                      <div class="col-md-10"><asp:TextBox ID="txtEscuela" CssClass="form-control" runat="server"></asp:TextBox></div>            
                  </div>
                  <div class="row">                                    
                      <div class="col-md-2">Nombre de Facultad :</div>
                      <div class="col-md-10">
                          <asp:DropDownList ID="ComboBoxFacultad" CssClass="form-control" runat="server"></asp:DropDownList></div>            
                  </div>

                </div>

            <div class="modal-footer">
                <asp:Button ID="btnAgregar" CssClass="col-md-2 btn btn-success" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                <button class="btn btn-primary" data-dismiss="modal" aria-hidden="true">Cerrar</button>
            </div>
        </div>
       </div>
  </div>
 </div>
</asp:Panel>


    


        <div class="modal fade" id="myModalUpdate_Facultad" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Update Facultad</h4>
              </div>
              <div class="modal-body">
                  <div class="row">                                    
                      <div class="col-md-2">Nombre Facultad :</div>
                      <div class="col-md-10"><asp:TextBox ID="txtFacultad" CssClass="form-control" runat="server"></asp:TextBox></div>            
                  </div>
                </div>

            <div class="modal-footer">
                <asp:Button ID="btnAgregar_Facultad" CssClass="col-md-2 btn btn-success" runat="server" Text="Agregar"/>
                <button class="btn btn-primary" data-dismiss="modal" aria-hidden="true">Cerrar</button>
            </div>
        </div>
       </div>
  </div>




        <div class="modal fade" id="myModalUpdate_Escuela" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title">Update Escuela</h4>
              </div>
              <div class="modal-body">
                  <div class="row">                                    
                      <div class="col-md-2">Nombre Escuela :</div>
                      <div class="col-md-10"><asp:TextBox ID="txtEscuelaUpdate" CssClass="form-control" runat="server"></asp:TextBox></div>            
                  </div>
                </div>

            <div class="modal-footer">
                <asp:Button ID="Button1" CssClass="col-md-2 btn btn-success" runat="server" Text="Agregar"/>
                <button class="btn btn-primary" data-dismiss="modal" aria-hidden="true">Cerrar</button>
            </div>
        </div>
       </div>
  </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
