<%@ Page Title="" Language="C#" MasterPageFile="~/URE/CRUD/CRUD.Master" AutoEventWireup="true" CodeBehind="CRUDCargo.aspx.cs" Inherits="SistemaUre.URE.CRUD.CRUDCargo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">CARGO ACADEMICO</div>
        <div class="panel-body">
            <div class="row">
                <div class="col-md-2">Descripcion :</div>
                <div class="col-md-2">
                    <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server"></asp:TextBox></div>
            </div>

        </div>
        <br />
        <script type="text/javascript">
            function ConfirmaButon(mensaje) {
                return confirm(mensaje);
            }
        </script>

        <div class="btn-toolbar" role="toolbar">
            <asp:Button ID="btnIngresar_Cargo" runat="server" class="btn btn-lg btn-primary" OnClientClick="return ConfirmaButon('quieres Ingresar ?')" Text="Agregar" OnClick="btnIngresar_Cargo_Click"></asp:Button>
        </div>
        <br />
 <div class="panel-body">

     <asp:GridView ID="List_Cargo_G" runat="server" class="table table-striped tab-content" AutoGenerateColumns="False" Width="100%" OnRowCancelingEdit="List__RowCancelingEdit" OnRowUpdating="List__RowUpdating" OnRowDeleting="List_Cargo_G_RowDeleting" OnRowEditing="List_Cargo_G_RowEditing" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="List_Cargo_G_SelectedIndexChanged">
             
         <AlternatingRowStyle BackColor="White" />
             
        <Columns>

           <asp:TemplateField HeaderText="Codigo">
                <ItemTemplate>
                    <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codigo")%>'></asp:Label>                   
                   
                </ItemTemplate>

            </asp:TemplateField>

            <asp:TemplateField HeaderText="Cargo Academico">
                <ItemTemplate>                
                    <%# Eval("descripcion")%>                   
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtDescripcion" Text='<%# Eval("descripcion")%>' runat="server"/>
                </EditItemTemplate>

            </asp:TemplateField>

            <asp:TemplateField HeaderText="Accion">

                <ItemTemplate>
                    <asp:Button ID="btnEdit" CommandName="Edit" class="btn btn-success" runat="server" Text="Edit  " />
                    <asp:Button ID="btnDelete" CommandName="delete" class="btn btn-danger"  OnClientClick="return ConfirmaButon('Seguro de Eliminar ?')" runat="server" Text="Delete" />

                    
                </ItemTemplate>

                <EditItemTemplate>
                    <asp:LinkButton ID="btnSalir" CommandName="Update" runat="server" Text="Update"/> 
                    <asp:LinkButton ID="btnCan" CommandName="Cancel" runat="server" Text="Cancel" />                    
                </EditItemTemplate>

            </asp:TemplateField>

        </Columns>
         <EditRowStyle BackColor="#F5F7FB" />
         <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
         <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
         <RowStyle BackColor="#EFF3FB" />
         <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
         <SortedAscendingCellStyle BackColor="#F5F7FB" />
         <SortedAscendingHeaderStyle BackColor="#6D95E1" />
         <SortedDescendingCellStyle BackColor="#E9EBEF" />
         <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
    
 </div>


 </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>

