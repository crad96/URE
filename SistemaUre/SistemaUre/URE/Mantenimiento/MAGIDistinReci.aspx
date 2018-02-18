<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MAGIDistinReci.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MAGIDistinReci" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    <h1>
       ADMINISTRATIVO
        <small>Distinciones Recibidas</small>
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
        <div class="panel-heading">DISTINCION RECIBIDAS</div>
        <div class="panel-body">

            <div class="row">
                <div class="col-md-2">Entidad:</div>
                <div class="col-md-8">
                    <asp:TextBox ID="txtentidad" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="col-md-2">Distinción:</div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtdistincion" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-1">Fecha:</div>
                <div class="col-md-2">
                    <asp:TextBox ID="txtFecha" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                </div>
            </div>
            <br>

        </div>
        <br>
 </div>

              <div class="col-md-offset-4">
                <div class="btn-toolbar" role="toolbar">
                    <asp:Button ID="btnIngresar_DistinReci" runat="server" class="btn btn-lg btn-primary" Text="Agregar" OnClick="btnIngresar_DistinReci_Click"></asp:Button>
                    <asp:Button ID="btnCancelar_DistinReci" runat="server" class="btn btn-lg btn-danger" Text="Cancelar"></asp:Button>

                </div>
              </div>
                <br />
              
       

    <asp:GridView ID="GridAdmiDisReci" runat="server" AutoGenerateColumns="false" OnRowDeleting="GridAdmiDisReci_RowDeleting">
        
        <Columns>
                <asp:TemplateField HeaderText="Codigo" Visible="true" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codi")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Entidad" HeaderStyle-Width="25%">
                    <ItemTemplate>
                        <%#Eval("entidad")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtentidad" runat="server" Text='<%#Eval("entidad")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="25%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Distincion" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("distincion")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtdistincion" runat="server" Text='<%#Eval("distincion")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Fecha" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("fecha")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtFecha" runat="server" Text='<%#Eval("fecha")%>'> </asp:TextBox>
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
