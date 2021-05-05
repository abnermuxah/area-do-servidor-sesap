
<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Menu.Master" CodeBehind="FichaFuncional.aspx.vb" Inherits="Formularios.FichaFuncional" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="align-content:center; height:50%; width:50%">
                <asp:literal id="LitJava" runat="server"></asp:literal>
                <h4 style="text-shadow: #000 1px 1px 1px, #FFF -1px -1px 1px;">FICHA FUNCIONAL</h4>
                <HR color="#0099cc" SIZE="1">

                <div class="form-group row">
                    <div class="col-md-3 mb-2">
                         <label for="txtMatricula">Matricula</label>
                          <asp:textbox id="txtMatricula" tabIndex="1" class="form-control"  runat="server"  disabled="true" Width="100px"></asp:textbox>
                    </div>
                    <div class="col-md-3 mb-2 col-2">
                         <label for="txtVinculo">Vinculo</label>
                          <asp:textbox id="txtVinculo" tabIndex="2" class="form-control"  runat="server"  MaxLength="1" Width="40px"></asp:textbox>
                    </div>
           
                </div>   
                <div class="form-row">
                     <div class="col-10">
                            <label for="txtNome">Nome</label>
                          <asp:textbox id="txtNome" tabIndex="3" class="form-control"  runat="server" disabled="true" Width="100%"></asp:textbox>
                     </div>
                </div>
		        <HR color="#0099cc" SIZE="1">
		        <asp:button id="btnImprimir"  tabIndex="13" runat="server" class="btn btn-primary"  Text="Imprimir"></asp:button>
                <CR:CrystalReportViewer ID="Report" runat="server" />
    
            </div>
</asp:Content>
 
