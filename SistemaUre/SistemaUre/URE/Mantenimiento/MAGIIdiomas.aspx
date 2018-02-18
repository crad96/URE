<%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" AutoEventWireup="true" CodeBehind="MAGIIdiomas.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MAGIIdiomas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
     <h1>
       ADMINISTRATIVO
        <small>Idiomas</small>
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
        <div class="panel-heading">Idiomas</div>
        <div class="panel-body">

             <div class="row">
                    <div class="col-md-3 col-md-offset-3">Seleccione el idioma</div>
                    <div class="col-md-3">
                        <asp:DropDownList ID="ComIdioma" CssClass="form-control" runat="server">
                            <asp:ListItem>Ingles</asp:ListItem>
                            <asp:ListItem>Frances</asp:ListItem>
                            <asp:ListItem>Italiano</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <br />

                <div class="row">
                    <div class="col-md-1 col-md-offset-1">Habla</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="ComHabla" CssClass="form-control" runat="server">
                            <asp:ListItem>Si</asp:ListItem>
                            <asp:ListItem>No</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-1">Lee</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="ComLee" CssClass="form-control" runat="server">
                            <asp:ListItem>Si</asp:ListItem>
                            <asp:ListItem>No</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-1">Escribe</div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="ComEscribe" CssClass="form-control" runat="server">
                            <asp:ListItem>Si</asp:ListItem>
                            <asp:ListItem>No</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <br />

                <div class="row">
                    <div class="col-md-2 col-md-offset-1">Centro de estudios/Lugar</div>
                    <div class="col-md-5">
                        <asp:TextBox ID="txtLugar" CssClass="form-control" runat="server"></asp:TextBox></div>
                </div>
                <section />
                <br />    

        </div>
        <br>
  </div>
               
            <div class="col-md-offset-4">
                <div class="btn-toolbar" role="toolbar">
                    <asp:Button ID="btnIngresar_AdmiIdiomas" runat="server" class="btn btn-lg btn-primary" Text="Agregar" OnClick="btnIngresar_AdmiIdiomas_Click" ></asp:Button>
                    <asp:Button ID="btnCancelar_AdmiIdiomas" runat="server" class="btn btn-lg btn-danger" Text="Cancelar"></asp:Button>

                </div>
             </div>
                <br />
                


    <asp:GridView ID="GridIdioAdmin" runat="server" BackColor="White" BorderColor="#CCCCCC" AutoGenerateColumns="False" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnRowDeleting="GridIdioAdmin_RowDeleting">

         <Columns>
                <asp:TemplateField HeaderText="Codigo" Visible="true" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codi")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Idioma" HeaderStyle-Width="25%">
                    <ItemTemplate>
                        <%#Eval("desc_idioma")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="DropDownListIdioma" runat="server" Text='<%#Eval("desc_idioma")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="25%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="habla" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("habla")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="ComHabla" runat="server" Text='<%#Eval("habla")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Lee" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("lee")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="ComLee" runat="server" Text='<%#Eval("lee")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Escribe" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("escribe")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="ComEscribe" runat="server" Text='<%#Eval("escribe")%>'> </asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="10%" />
                </asp:TemplateField>

                <asp:TemplateField HeaderText="txtLugar" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <%#Eval("lugar")%>
                    </ItemTemplate>

                    <EditItemTemplate>
                        <asp:TextBox ID="txtLugar" runat="server" Text='<%#Eval("lugar")%>'> </asp:TextBox>
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
