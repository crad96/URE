<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MEIInvestigacion.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MEIInvestigacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
      <h1>
        DOCENTE
        <small>Investigaciones</small>
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
        <div class="panel-heading">Especialización</div>
        <div class="panel-body">

            <div class="row">
                <div class="col-md-2">Titulo:</div>
                <div class="col-md-9">
                    <asp:TextBox ID="txtTitulo" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="col-md-2">Entidad:</div>
                <div class="col-md-4">
                    <asp:TextBox ID="txtEntidad" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-2">Año:</div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtao" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <br>

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
                    <asp:Button ID="btnIngresar_Investigacion" runat="server" class="btn btn-lg btn-primary" Text="Agregar" OnClick="btnIngresar_Investigacion_Click"></asp:Button>
                    <asp:Button ID="btnCancelar_Investigacion" runat="server" class="btn btn-lg btn-danger" Text="Cancelar"></asp:Button>

                </div>
                 </div>
                <br />
                <div class="panel-body">
                </div>
       


        <asp:GridView ID="GridInvest" runat="server" AutoGenerateColumns="False"
            OnRowDeleting="GridInvest_RowDeleting">

        
            <Columns>
                <asp:TemplateField HeaderText="Código" Visible="true" HeaderStyle-Width="5%">
                    <ItemTemplate>
                        <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codi")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Titulo" HeaderStyle-Width="49%">
                    <ItemTemplate>
                        <%#Eval("titulo")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtTitulo" runat="server" Text='<%#Eval("titulo")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="49%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Entidad" HeaderStyle-Width="28%">
                    <ItemTemplate>
                        <%#Eval("entidad")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtEntidad" runat="server" Text='<%#Eval("entidad")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="28%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Año" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <%#Eval("año")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtao" runat="server" Text='<%#Eval("año")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="7%" />
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

        </asp:GridView >

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
