<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MDescanso.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MDescanso" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <br />
    <h1>
        DESCANSO MÉDICOS
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Level</a></li>
        <li class="active">Here</li>
      </ol>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <!-- Main content -->

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



    <!-- Panel Desmerito -->

    <div class="panel panel-primary">
        <div class="panel-heading">DESMÉRITO</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-2">Nº de Resolución:</div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtNumReso" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />

            <div class="row">
                <div class="col-md-2">Descripción :</div>
                <div class="col-md-2">
                    <asp:TextBox ID="txtDescrip" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-2">Fecha Registro :</div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtfecha_registro" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                </div>
            </div>
            <br />

            <div class="row">
                <div class="col-md-2">Fecha Resolución :</div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtfecha_resolucion" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                </div>
                <br />

                <div class="col-md-1">Agregar Imagen :</div>
                <div class="col-md-1">
                    <img src="../../Recursos/images/documento.png" style="margin: 10px" height="71"
                        width="100" />
                    <asp:FileUpload ID="imaDes" runat="server" />

                </div>
            </div>
            <br />


        </div>
        <br />
        <script type="text/javascript">
            function ConfirmaButon(mensaje) {
                return confirm(mensaje);
            }
        </script>
   </div>


   <div class="col-md-offset-4"> 
        <div class="btn-toolbar" role="toolbar">
           <asp:Button ID="btnIngresar_MDescanso" runat="server"  long="10px"    CssClass="btn btn-lg btn-primary" Text="Agregar" OnClick="btnIngresar_MDescanso_Click" ></asp:Button>
           <asp:Button ID="btnCancelar_MDescanso" runat="server" class="btn btn-lg btn-danger" Text="Cancelar"></asp:Button>

        </div>  
   </div>
    <!-- Tabla -->
        <div class="panel-body">

        </div>
     <br />

 
    <asp:GridView ID="GridDescanso" runat="server" class="table table-striped tab-content" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None"
        OnRowDeleting="GridDescanso_RowDeleting" >

        <Columns>
                <asp:TemplateField HeaderText="Codigo" Visible="true" HeaderStyle-Width="8%">
                    <ItemTemplate>
                        <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codi")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Nº Resolucion" HeaderStyle-Width="30%">
                    <ItemTemplate>
                        <%#Eval("num_resolution")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtNumReso" runat="server" Text='<%#Eval("num_resolution")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="30%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Descripcion" HeaderStyle-Width="50%">
                    <ItemTemplate>
                        <%#Eval("Descripcion")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtDescrip" runat="server" Text='<%#Eval("Descripcion")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="50%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Fec Registro" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("fecha_registro")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtfecha_registro" runat="server" Text='<%#Eval("fecha_registro")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Fec Resolucion" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("fecha_resol")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtfecha_resolucion" runat="server" Text='<%#Eval("fecha_resol")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Direc_Fot" HeaderStyle-Width="10%">
                    <%--<ItemTemplate>
                        <%#Eval("foto")%>
                    </ItemTemplate>--%>

                    <ItemTemplate>
                        <asp:HyperLink ID="imaDes" runat="server" NavigateUrl='<%#Eval("foto","~/Files/Resolucion/{0}")%>' 
                            Text='<%# Eval("foto") %>'> </asp:HyperLink>
                    </ItemTemplate>
                    <HeaderStyle Width="30%" />
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

