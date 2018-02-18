<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MEIExpDocenteUni.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MEIExpDocenteUni" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
      <h1>
        DOCENTE
        <small>Experciencia Docente Universitaria </small>
      </h1>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div style="vertical-align: 50%">
        <div class="row">
            <div class="col-md-3 col-md-offset-3">
                <asp:TextBox ID="txtdniPe" CssClass="form-control" runat="server" ></asp:TextBox>                                          
            </div>
             <div class="col-md-1">                           
                <asp:Button ID="btn_BuscarPo" runat="server" class="btn btn-lg btn-primary" Text="Buscar" OnClick="btn_BuscarPo_Click"></asp:Button>                             
            </div>
            <br>
             <div class="col-md-3 col-md-offset-3">   
                 <asp:Label ID="lblMensaje" text="" runat="server" ForeColor="Red"></asp:Label>                       
            </div>

        </div>
    </div>
    <br />

    <div class="row">
        <div class="col-md-4 col-md-offset-3">
            <asp:TextBox ID="txtNombresCom" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
        </div>
    </div>
    <br>

    <!-- --------------- Panel--------- -->
    <div class="panel panel-primary">
        <div class="panel-heading">Especialización</div>
        <div class="panel-body">

                <div class="row">
                    <div class="col-md-3">Universidad :</div>
                    <div class="col-md-9">
                        <asp:DropDownList ID="Combouni" CssClass="form-control" runat="server">
                            <asp:ListItem>Principal</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                </div>
                <br>
                <div class="row">
                    <div class="col-md-3">Actidad/ Cátedra:</div>
                    <div class="col-md-9">
                        <asp:TextBox ID="txtactividad" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <br>

                <div class="row">
                    <div class="col-md-3">Fecha Desde :</div>             
                       <div class="col-md-9">
                        <asp:TextBox ID="txtFechaDes" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                    </div> 
                </div>
                <br>
                <div class="row">
                    <div class="col-md-3">Fecha Hasta :</div>
                    <div class="col-md-9">
                        <asp:TextBox ID="txtFechaHas" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                    </div> 
                </div>
           </div>
           <br>
</div>
                <script type="text/javascript">
                    function ConfirmaButon(mensaje) {
                        return confirm(mensaje);
                    }
                </script>

              <div class="Col-md-offset-4">
                <div class="btn-toolbar" role="toolbar">
                    <asp:Button ID="btnIngresar_Especializacion" runat="server" class="btn btn-lg btn-primary" Text="Agregar" OnClick="btnIngresar_Especializacion_Click"></asp:Button>
                    <asp:Button ID="btnCancelar_Especializacion" runat="server" class="btn btn-lg btn-danger" Text="Cancelar"></asp:Button>

                </div>
              </div>
                <br />
                <div class="panel-body">
                </div>




    <asp:GridView ID="GridExperienciaDoc" runat="server" BackColor="White" BorderColor="#CCCCCC" AutoGenerateColumns="False" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowDeleting="GridExperienciaDoc_RowDeleting">

        <Columns>
            <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate>
                    <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codi")%>'></asp:Label>                                      
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Universidad">
                <ItemTemplate>                
                    <%# Eval("universidad")%>                   
                </ItemTemplate>
               <EditItemTemplate>
                    <asp:TextBox ID="Combouni" Text='<%# Eval("universidad")%>' runat="server"/>
               </EditItemTemplate>
                <HeaderStyle Width="40%" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Actividad">
                <ItemTemplate>                
                    <%# Eval("desc_actividad")%>                   
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label ID="txtactividad" runat="server" Text='<%# Eval("desc_actividad")%>'></asp:Label>                                                  
                 </EditItemTemplate>
                <HeaderStyle Width="20%" />
            </asp:TemplateField>



            <asp:TemplateField HeaderText="Fec Desde">
                <ItemTemplate>                
                    <%# Eval("fecha_desde")%>                   
                </ItemTemplate>
                 <EditItemTemplate>
                    <asp:Label ID="txtFechaDes" runat="server" Text='<%# Eval("fecha_desde")%>'></asp:Label>                                                      
                 </EditItemTemplate>
                <HeaderStyle Width="20%" />
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Fec Hasta">
                <ItemTemplate>                
                    <%# Eval("fecha_hasta")%>                   
                </ItemTemplate>
                 <EditItemTemplate>
                    <asp:Label ID="txtFechaHas" runat="server" Text='<%# Eval("fecha_hasta")%>'></asp:Label>                                                      
                 </EditItemTemplate>
                <HeaderStyle Width="20%" />
            </asp:TemplateField>


             <asp:TemplateField HeaderText="Accion">

                    <ItemTemplate>
                      
                        <asp:Button ID="btnDelete" CommandName="delete" class="btn btn-danger" OnClientClick="return ConfirmaButon('Seguro de Eliminar ?')" runat="server" Text="Delete" />


                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:LinkButton ID="btnSalir" CommandName="Update" runat="server" Text="Update" />
                        <asp:LinkButton ID="btnCan" CommandName="Cancel" runat="server" Text="Cancel" />
                    </EditItemTemplate>

                </asp:TemplateField>

        </Columns>
   <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />


    </asp:GridView>






</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
