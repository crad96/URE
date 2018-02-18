<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MEIPublicaciones.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MEIPublicaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    <h1>
        DOCENTE
        <small>Publicaciones</small>
      </h1>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

            <div style="vertical-align: 50%">
        <div class="row">
            <div class="col-md-3 col-md-offset-3">
                <asp:TextBox ID="txtdniPe" CssClass="form-control" runat="server" ></asp:TextBox>                                          
            </div>
             <div class="col-md-1">                           
                <asp:Button ID="btn_BuscarPo" runat="server" class="btn btn-lg btn-primary" Text="Buscar" OnClick="btn_BuscarPo_Click" ></asp:Button>                             
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
        <div class="panel-heading">Publicaciones</div>
        <div class="panel-body">

            <div class="row">
                <div class="col-md-3">Titulo de Publicación:</div>
                <div class="col-md-9">
                    <asp:TextBox ID="txtTitulo" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="col-md-3">Editorial:</div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtEditorial" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-2">Ciudad:</div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtCiudad" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <br>

            <div class="row">
                <div class="col-md-3">Indexada:</div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtIndexad" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-1">Fecha:</div>
                  <div class="col-md-2">
                    <asp:TextBox ID="txtFech" CssClass="form-control" runat="server" TextMode="Date" ></asp:TextBox>
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
                    <asp:Button ID="btnIngresar_public" runat="server" class="btn btn-lg btn-primary" Text="Agregar" OnClick="btnIngresar_public_Click"></asp:Button>
                    <asp:Button ID="btnCancelar_public" runat="server" class="btn btn-lg btn-danger" Text="Cancelar"></asp:Button>

                </div>
         </div>
                <br />
                <div class="panel-body">
                </div>




    <asp:GridView ID="GridPublicaciones" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridPublicaciones_RowDeleting">

        <Columns>
                <asp:TemplateField HeaderText="Código" Visible="true" HeaderStyle-Width="5%">
                    <ItemTemplate>
                        <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codi")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText=" Título Publicación" HeaderStyle-Width="30%">
                    <ItemTemplate>
                        <%#Eval("titulo_publicacion")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtTitulo" runat="server" Text='<%#Eval("titulo_publicacion")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="30%" />
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Editorial" HeaderStyle-Width="30%">
                    <ItemTemplate>
                        <%#Eval("editorial")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditorial" runat="server" Text='<%#Eval("editorial")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="30%" />
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Ciudad" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("ciudad")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtCiudad" runat="server" Text='<%#Eval("ciudad")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Fecha" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("fecha")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtFech" runat="server" Text='<%#Eval("fecha")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Indexada" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("indexada")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtIndexad" runat="server" Text='<%#Eval("indexada")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
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
