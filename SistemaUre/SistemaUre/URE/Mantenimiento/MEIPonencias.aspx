<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MEIPonencias.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MEIPonencias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    <h1>
        DOCENTE
        <small>Ponencias </small>
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
                <div class="col-md-3">Nombre Ponencia:</div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtNPonencias" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="col-md-3">Evento donde se presentó:</div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtEven" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

            </div>
            <br>


            <div class="row">
                <div class="col-md-3">Ciudad:</div>
                <div class="col-md-2">
                    <asp:TextBox ID="txtCiudad" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-1">Fecha:</div>
                <div class="col-md-2">
                    <asp:TextBox ID="txtFech_po" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
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
                    <asp:Button ID="btnIngresar_Ponencia" runat="server" class="btn btn-lg btn-primary" Text="Agregar" OnClick="btnIngresar_Ponencia_Click1" ></asp:Button>
                    <asp:Button ID="btnCancelar_Ponencia" runat="server" class="btn btn-lg btn-danger" Text="Cancelar"></asp:Button>

                </div>
        </div>
                
                <br />
                <div class="panel-body">
                </div>


        <asp:GridView ID="GridPonencias" runat="server" BackColor="White" BorderColor="#CCCCCC" AutoGenerateColumns="False" BorderStyle="None" BorderWidth="1px" CellPadding="3"
           OnRowUpdating="GridPonencias_RowUpdating" OnRowCancelingEdit="GridPonencias_RowCancelingEdit" OnRowEditing="GridPonencias_RowEditing" OnRowDeleting="GridPonencias_RowDeleting">


            <Columns>
                <asp:TemplateField HeaderText="Codigo" Visible="true" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codi")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Nombre de Ponencia" HeaderStyle-Width="25%">
                    <ItemTemplate>
                        <%#Eval("nombrePonencia")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtNPonencias" runat="server" Text='<%#Eval("nombrePonencia")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="25%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Evento" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("evento")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtEven" runat="server" Text='<%#Eval("evento")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
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
                        <asp:TextBox ID="txtFech_po" runat="server" Text='<%#Eval("fecha")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>
             
            
                <asp:TemplateField HeaderText="Accion">

                    <ItemTemplate>                        
                        <asp:Button ID="btnEdit" CommandName="Edit" class="btn btn-success" runat="server" Text="Edit  " />
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