 <%@ Page Title="" Language="C#" MasterPageFile="~/URE/Mantenimiento/Mantenimiento.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="MDocente.aspx.cs" Inherits="SistemaUre.URE.Mantenimiento.MDocente" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Title" runat="server">
    <h1>DOCENTE
        <small>Mantenimiento Docente</small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Level</a></li>
        <li class="active">Here</li>
    </ol>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">


    <div class="panel panel-primary">
        <div class="panel-body">



            <div class="row" style="padding-bottom:8px; ">
            
            <div class="col-md-2"><asp:Label ID="Label1" runat="server"  Text="Apellido Paterno :" style="font-weight: bold;"></asp:Label></div>
            <div class="col-md-2"><asp:TextBox ID="txtAPa" CssClass="form-control" runat="server" ></asp:TextBox></div>
            <div class="col-md-2"><asp:Label ID="Label2" runat="server" Text="Apellido Materno :" style="font-weight: bold;"></asp:Label></div>
            <div class="col-md-2"><asp:TextBox ID="txtAMa" CssClass="form-control" runat="server"></asp:TextBox></div>
            <div class="col-md-2"><asp:Label ID="Label3" runat="server" Text="Nombres :" style="font-weight: bold;"></asp:Label></div>
            <div class="col-md-2"><asp:TextBox ID="txtNom" CssClass="form-control" runat="server"></asp:TextBox></div>
        </div>
     
        <div class="row" >
            <div class="col-md-2"><asp:Label ID="Label4" runat="server" Text="DNI :" style="font-weight: bold;"></asp:Label> </div>
            <div class="col-md-2"><asp:TextBox ID="txtDNIdocente" CssClass="form-control" runat="server"></asp:TextBox></div>
            <div class="col-md-2"> <asp:Label ID="Label5" runat="server" Text="Sexo :" style="font-weight: bold;"></asp:Label></div>
            <div class="col-md-2"><asp:DropDownList ID="ddlsexo" CssClass="form-control" runat="server">
                <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                <asp:ListItem Value="f">femenino</asp:ListItem>
                <asp:ListItem Value="m">masculino</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-md-2"> <asp:Label ID="Label6" runat="server" Text="Fecha Nacimiento :" style="font-weight: bold;"></asp:Label></div>
             <div class="col-md-2">
                    <asp:TextBox ID="txtFech_nac" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>       
             </div>
            </div>

    <hr style="border: 1px solid #337ab7;   border-radius: 300px ;    height: 0px;    text-align: center;"/>

       <div class="row" >
           <div class="col-md-2"><asp:Label ID="Label7" runat="server" Text="Dto. Nacimiento:" style="font-weight: bold;"></asp:Label></div>
           <div class="col-md-2"><asp:DropDownList ID="dptnac" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dptnac_SelectedIndexChanged" AppendDataBoundItems="true" >
                    <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                 </asp:DropDownList>
                    </div>
                    <div class="col-md-2"><asp:Label ID="Label8" runat="server" Text="Provincia Nacimiento :" style="font-weight: bold;"></asp:Label></div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="provnac" CssClass="form-control"  runat="server" AutoPostBack="true" OnSelectedIndexChanged="provnac_SelectedIndexChanged" AppendDataBoundItems="true" >
                             <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                        </asp:DropDownList>
                       
                    </div>
                    <div class="col-md-2"> <asp:Label ID="Label9" runat="server" Text="Distrito Nacimiento:" style="font-weight: bold;"></asp:Label></div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="disnac" CssClass="form-control" AutoPostBack="true" runat="server" AppendDataBoundItems="true" >
                            <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                        </asp:DropDownList>
                    </div>
          </div>
                 
     <hr style="border: 1px solid #337ab7;   border-radius: 300px ;    height: 0px;    text-align: center;"/>   


         <div class="row" style="padding-bottom:8px;">                   
            <div class="col-md-2"><asp:Label ID="Label10" runat="server" Text="Domicilio :" style="font-weight: bold;"></asp:Label></div>
            <div class="col-md-6"><asp:TextBox ID="txtdomincilio" CssClass="form-control" runat="server"></asp:TextBox></div>
              <div class="col-md-1"><asp:Label ID="Label11" runat="server" Text="Tenencia :" style="font-weight: bold;"></asp:Label></div>
             <div class="col-md-3">
                 <asp:RadioButton  CssClass="radio-inline" ID ="alquilado" Text="Alquilado" GroupName="tenencia" runat="server" />
                 <asp:RadioButton  CssClass="radio-inline" ID ="propio" Text="Propio" GroupName="tenencia" runat="server" />                                         
             </div> 
            </div>

          

           <div class="row" style="padding-bottom:8px;">
              <div class="col-md-2"><asp:Label ID="Label12" runat="server" Text="Departamento :" style="font-weight: bold;"></asp:Label></div>
               <div class="col-md-2">
                  <asp:DropDownList ID="deptolu" CssClass="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="deptolu_SelectedIndexChanged" >
                    <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
   
                  </asp:DropDownList>
               </div>
                    <div class="col-md-2"><asp:Label ID="Label13" runat="server" Text="Provincia:" style="font-weight: bold;"></asp:Label></div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="provlu" CssClass="form-control" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="provlu_SelectedIndexChanged">
                              <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-2"><asp:Label ID="Label14" runat="server" Text="Distrito:" style="font-weight: bold;"></asp:Label></div>
                    <div class="col-md-2">
                        <asp:DropDownList ID="distlu" CssClass="form-control" runat="server" AutoPostBack="true" AppendDataBoundItems="true">
                            <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                        </asp:DropDownList>
                    </div>
          </div>

          <div class="row" style="padding-bottom:8px;">        
                                     
              <div class="col-md-2" style="font-weight: bold;">Vive en :</div>
              <div class="col-md-6">
                  <asp:RadioButton  CssClass="radio-inline" ID ="residencial" Text="Residencial" GroupName="vive" runat="server" />
                <asp:RadioButton  CssClass="radio-inline" ID ="urbanizacion" Text="Urbanizacion" GroupName="vive" runat="server" />
                  <asp:RadioButton  CssClass="radio-inline" ID ="pjoven" Text="Pueblo joven" GroupName="vive" runat="server" />
                <asp:RadioButton  CssClass="radio-inline" ID ="otro" Text="Otros" GroupName="vive" runat="server" />
                                        
              </div> 
           </div>  
                  

           <hr style="border: 1px solid #337ab7;   border-radius: 300px ;    height: 0px;    text-align: center;"/>  


    
        <div class="row" style="padding-bottom:8px;">
             <div class="col-md-2" style="font-weight: bold;">Fecha Ingreso :</div>
             <div class="col-md-2">
                     <asp:TextBox ID="txt_fecha" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>   </div>
            <div class="col-md-2" style="font-weight: bold;">Area Trabajo :</div>
            <div class="col-md-2"><asp:DropDownList ID="ddlareatrabajo" AppendDataBoundItems="true" AutoPostBack="true" CssClass="form-control" runat="server">
               <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                </asp:DropDownList></div>
            <div class="col-md-2" style="font-weight: bold;">Cargo :</div>
            <div class="col-md-2"><asp:DropDownList ID="ddlcargo" AppendDataBoundItems="true" AutoPostBack="true" CssClass="form-control" runat="server">
                 <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                
                </asp:DropDownList></div>
            
        </div>
    
        <div class="row" style="padding-bottom:8px;">
            <div class="col-md-2" style="font-weight: bold;">Grupo Nivel :</div>
            <div class="col-md-2" ><asp:DropDownList ID="ddlnivel" AppendDataBoundItems="true" AutoPostBack="true" CssClass="form-control" runat="server">
                 <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                </asp:DropDownList></div>
            <div class="col-md-2" style="font-weight: bold;">Categoria :</div>
           <div class="col-md-2"><asp:DropDownList ID="ddlcategoria" AppendDataBoundItems="true" AutoPostBack="true" CssClass="form-control" runat="server">
                 <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                
                </asp:DropDownList></div>
            <div class="col-md-2" style="font-weight: bold;">Dedicacion :</div>
            <div class="col-md-2" style="font-weight: bold;"><asp:DropDownList ID="ddldedicacion" AppendDataBoundItems="true" AutoPostBack="true" CssClass="form-control" runat="server">
                 <asp:ListItem Value="0">-Seleccione uno-</asp:ListItem>
                </asp:DropDownList></div>
        </div>
   
         <div class="row" style="padding:5px;">
            <div class="col-md-2" style="font-weight: bold;">Nacionalidad :</div>
            <div class="col-md-2"><asp:TextBox ID="txtNaciona" CssClass="form-control" runat="server"></asp:TextBox></div>
              <div class="col-md-2" style="font-weight: bold;">Teléfono :</div>
            <div class="col-md-2"><asp:TextBox ID="txtTel" CssClass="form-control" runat="server"></asp:TextBox></div>
             
        </div>

    <div class="row" style="padding-bottom:8px;">
              <div class="col-md-2" style="font-weight: bold;">Estado Civil :</div>
            <div class="col-md-2"><asp:DropDownList ID="ddlestadocivil" CssClass="form-control" runat="server">
                <asp:ListItem Value="soltero">Soltero</asp:ListItem>
                <asp:ListItem Value="casado">Casado</asp:ListItem>
                <asp:ListItem Value="viudo">Viudo</asp:ListItem>
                <asp:ListItem Value="divorciado">Divorciado</asp:ListItem>
                </asp:DropDownList></div>
            <div class="col-md-2" style="font-weight: bold;">  Carnet-Seguro :</div>
            <div class="col-md-2"><asp:TextBox ID="txtSeguro" CssClass="form-control" runat="server"></asp:TextBox></div>
            <div class="col-md-2" style="font-weight: bold;">Grupo Sanguineo :</div>
            <div class="col-md-2"><asp:TextBox ID="txtGSangui" CssClass="form-control" runat="server"></asp:TextBox></div> 
          
                      
        </div>
       
    
        <div class="row" style="padding:5px;">
          
            <div class="col-md-2" style="font-weight: bold;">Celular :</div>
            <div class="col-md-2"><asp:TextBox ID="txtCelular" CssClass="form-control" runat="server"></asp:TextBox></div>
             <div class="col-md-2" style="font-weight: bold;">Correo :</div>
            <div class="col-md-6"><asp:TextBox TextMode="Email" ID ="txtCorreo" CssClass="form-control" runat="server"></asp:TextBox></div>
           
            
        </div>
     
     <div class="row" style="padding:5px;">
            <div class="col-md-2" style="font-weight: bold;">Código Trabajo :</div>
            <div class="col-md-2"><asp:TextBox ID="txtCodTra" CssClass="form-control" runat="server"></asp:TextBox></div>
            <div class="col-md-2" style="font-weight: bold;">Código Plaza :</div>
            <div class="col-md-2"><asp:TextBox ID="txtCodPla" CssClass="form-control" runat="server"></asp:TextBox></div>
            <div class="col-md-2" style="font-weight: bold;">Código Legajo :</div>
            <div class="col-md-2"><asp:TextBox ID="txtCodLe" CssClass="form-control" runat="server"></asp:TextBox></div>
        </div>
  

      </div>
    </div>
            
            
        <script type="text/javascript">
           function ConfirmaButon(mensaje) {
               return confirm(mensaje);
           }
        </script>




    <div class="col col-md-offset-4" style="padding:10px">
        <div class="btn-toolbar " role="toolbar">
            <asp:Button ID="btnIngresar_docente" runat="server" class=" btn btn-lg btn-primary"  Text="Agregar" OnClick="btnIngresar_docente_Click"></asp:Button>
            <asp:Button ID="btncancelar_docente" runat="server" class="btn btn-lg btn-danger"  Text="Cancelar" OnClick="btncancelar_docente_Click"></asp:Button>  
     </div>
        </div>      

       
</asp:Content>



