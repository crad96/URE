<%@ Page Title="" Language="C#" MasterPageFile="~/URE/CRUD/CRUD.Master" AutoEventWireup="true" CodeBehind="CRUDDedicacion.aspx.cs" Inherits="SistemaUre.URE.CRUD.CRUDDedicacion" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">

    <div class="panel panel-primary">
        <div class="panel-heading">Mante Dedicacion</div>
        <asp:Panel ID="Panel_Dedicacion_vista" runat="server" Width="100%" Height="100%" Visible="true">
            <asp:GridView ID="GridViewListar_Dedicacion" runat="server" AutoGenerateColumns="False" OnRowEditing="GridViewListar_Dedicacion_RowEditing" OnRowUpdating="GridViewListar_Dedicacion_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None"
                Width="100%" OnRowCancelingEdit="GridViewListar_Dedicacion_RowCancelingEdit" OnRowDeleting="GridViewListar_Dedicacion_RowDeleting">

                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

                <Columns>
                    <asp:TemplateField HeaderText="Codigo">
                        <ItemTemplate>
                            <asp:Label ID="lblcodigo" runat="server" Text='<%# Eval("codigo")%>'></asp:Label>

                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Dedicacion">
                        <ItemTemplate>
                            <%# Eval("descripcion")%>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDescripcion" Text='<%# Eval("descripcion")%>' runat="server" />
                        </EditItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Estado">
                        <ItemTemplate>
                            <asp:Label ID="lblestado" runat="server" Text='<%# Eval("estado")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Edit">

                        <ItemTemplate>
                            <asp:LinkButton ID="btnUpd" CommandName="Edit" runat="server" Text="Edit " />
                            <%--<asp:LinkButton ID="BTNcambiar_estado" CommandName="delete" runat="server" Text=" Estado" />--%>

                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:LinkButton ID="btnSa" CommandName="Update" runat="server" Text="Update" />
                            <asp:LinkButton ID="btnCan" CommandName="Cancel" runat="server" Text="Cancel" />
                        </EditItemTemplate>

                    </asp:TemplateField>

                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </asp:Panel>
        <br>
        <div class="btn-toolbar" role="toolbar">
            <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#myModal">
                <span class="glyphicon glyphicon-plus-sign"></span>Agregar</button>



        </div>

        <div class="modal fade" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h4 class="modal-title">Ingrese nueva Dedicacion</h4>
                    </div>
                    <div class="modal-body">
                        <div class="row">
                            <div class="col-md-2">Dedicacion :</div>
                            <div class="col-md-10">
                                <asp:TextBox ID="txtDesc_Dedicacion" CssClass="form-control" runat="server"></asp:TextBox></div>
                        </div>
                    </div>

                    <asp:DropDownList ID="DropDownListEstado" runat="server">
                        <asp:ListItem Value="DOCENTE"></asp:ListItem>
                        <asp:ListItem Value="ADMINISTRATIVO"></asp:ListItem>
                    </asp:DropDownList>


                    <div class="modal-footer">
                        <asp:Button ID="btnAgregarDedi" CssClass="col-md-2 btn btn-success" runat="server" Text="Agregar" OnClick="btnAgregarDedi_Click" />
                        <button class="btn btn-primary" data-dismiss="modal" aria-hidden="true">Cerrar</button>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Footer" runat="server">
</asp:Content>
