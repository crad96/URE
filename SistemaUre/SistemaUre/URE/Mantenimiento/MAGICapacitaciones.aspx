<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MAGICapacitaciones.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MAGICapacitaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    <h1>
        ADMINISTRATIVO
        <small>Capacitaciones</small>
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
 
<div class="container">
    <div class="row">
        <div class="col-xs-11">


            <div class="panel panel-primary">
                <div class="panel-heading">CAPACITACIONES</div>
                <div class="panel-body">

                    <div class="row">
                        <div class="col-md-3" >Institución:</div>
                        <div class="col-md-8">
                            <asp:TextBox ID="txtIns" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <br />

                    <div class="row">
                        <div class="col-md-3">Nombre de Capacitación :</div>
                        <div class="col-md-8">
                            <asp:TextBox ID="txtNomCapa" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <br />

                    <div class="row">
                        <div class="col-md-3">Fecha de obtención:</div>
                        <div class="col-md-3">
                            <asp:TextBox ID="txtFechOb" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                        </div>


                        <div class="col-md-3">Nº de horas :</div>
                        <div class="col-md-2">
                            <asp:TextBox ID="txtNHor" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>


                </div>
                <br>
            </div>


         </div>
     </div>
  </div>
  
           
            <div class="col-md-offset-4"> 
                <div class="btn-toolbar" role="toolbar">
                    <asp:Button ID="btnIngresar_ACapacitaciones" runat="server" class="btn btn-lg btn-primary" Text="Agregar" OnClick="btnIngresar_ACapacitaciones_Click" ></asp:Button>
                    <asp:Button ID="btnCancelar_ACapacitaciones" runat="server" class="btn btn-lg btn-danger" Text="Cancelar"></asp:Button>

                </div>
            </div>
                <br />
                <div class="panel-body">
                </div>
        


    <asp:GridView ID="GridAdminCapac" runat="server" AutoGenerateColumns="False">

         <Columns>
                <asp:TemplateField HeaderText="Código" Visible="true" HeaderStyle-Width="5%">
                    <ItemTemplate>
                        <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codi")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Institución Organizadora" HeaderStyle-Width="30%">
                    <ItemTemplate>
                        <%#Eval("institucion")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtIns" runat="server" Text='<%#Eval("institucion")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="30%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Curso/Diplomado" HeaderStyle-Width="30%">
                    <ItemTemplate>
                        <%#Eval("nomb_curs")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtNomCapa" runat="server" Text='<%#Eval("nomb_curs")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="30%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="N° Horas" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("n_hora")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtNHor" runat="server" Text='<%#Eval("n_hora")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Fecha" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("fecha_obtencion")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtFechOb" runat="server" Text='<%#Eval("fecha_obtencion")%>'> </asp:TextBox>
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
