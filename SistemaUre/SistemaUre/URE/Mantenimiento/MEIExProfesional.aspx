<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MEIExProfesional.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MEIExProfesional" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    <h1>
        Docente
        <small>Experiencia Profesional</small>

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
        <div class="panel-heading">Experiencia Profesional</div>
        <div class="panel-body">

            <div class="row">
                <div class="col-md-3">Empresa/Entidad:</div>
                <div class="col-md-7">
                    <asp:TextBox ID="txtEntidad" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="col-md-3">Cargo desempeñado:</div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtCargo" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

             
                <div class="col-md-1">Lugar :</div>
                <div class="col-md-2">
                    <asp:TextBox ID="txtLugar" CssClass="form-control" runat="server"></asp:TextBox>
                </div>                         
                            
            </div>
            <br>

             <div class="row">
                <div class="col-md-3">Fecha Desde:</div>
                <div class="col-md-2">
                    <asp:TextBox ID="txtFech_de" CssClass="form-control" runat="server" TextMode="Date"  ></asp:TextBox>
                </div>    
              
                 <div class="col-md-2">Fecha Hasta:</div>
                <div class="col-md-2">
                    <asp:TextBox ID="txtFech_has" CssClass="form-control" runat="server" TextMode="Date"  ></asp:TextBox>
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
                    <asp:Button ID="btnIngresar_expProf" runat="server" class="btn btn-lg btn-primary" Text="Agregar" OnClick="btnIngresar_expProf_Click" ></asp:Button>
                    <asp:Button ID="btnCancelar_expProf" runat="server" class="btn btn-lg btn-danger" Text="Cancelar"></asp:Button>

                </div>
                </div>
                <br />
                <div class="panel-body">
                </div>




    <asp:GridView ID="GridExpProfesional" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridExpProfesional_RowDeleting" >

        <Columns>
                <asp:TemplateField HeaderText="Código" Visible="true" HeaderStyle-Width="5%">
                    <ItemTemplate>
                        <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codi")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Entidad - Lugar" HeaderStyle-Width="30%">
                    <ItemTemplate>
                        <%#Eval("empresa_entidad")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtEntidad" runat="server" Text='<%#Eval("empresa_entidad")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="30%" />
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Cargo" HeaderStyle-Width="30%">
                    <ItemTemplate>
                        <%#Eval("cargo_desempeñado")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtCargo" runat="server" Text='<%#Eval("cargo_desempeñado")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="30%" />
                </asp:TemplateField>

                
                <asp:TemplateField HeaderText="Lugar" HeaderStyle-Width="30%">
                    <ItemTemplate>
                        <%#Eval("lug_experiencia")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtLugar" runat="server" Text='<%#Eval("lug_experiencia")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="30%" />
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Fecha Desde" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("fecha_inicio")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtFech_de" runat="server" Text='<%#Eval("fecha_inicio")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Fecha Hasta" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("fecha_fin")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtFech_has" runat="server" Text='<%#Eval("fecha_fin")%>'> </asp:TextBox>
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
