<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Formularios.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Teste Pagina</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container" style="margin-top:5px; margin-left:4px; ">
    <form>
        <div class="auto-style1" >
			<h4><STRONG>&nbsp;Cadastro teste</STRONG></h4>
			<HR color="#0099cc" SIZE="1">
		</div>
          <div class="form-group row">
            <label for="txtUsuario" class="col-sm-2 col-form-label">Teste</label>
            <div class="col-sm-10">
              <asp:textbox id="txtUsuario" class="form-control" runat="server"   MaxLength="11"  Width="100%"></asp:textbox>
            </div>
          </div>
          <div class="form-group row">
            <label for="Textbox1" class="col-sm-2 col-form-label">Teste 01</label>
            <div class="col-sm-10">
              <asp:textbox id="Textbox1" class="form-control" runat="server"   MaxLength="11"  Width="100%"></asp:textbox>
            </div>
          </div>
        
            <div class="form-group row">
              
              <th>Radios</th>
                <div class="form-check">
                    <asp:radiobuttonlist id="rdbSituacao" runat="server"  Width="200px" AutoPostBack="True"  RepeatDirection="Vertical" RepeatLayout="Flow">
		                <asp:ListItem Value="1" Selected="True">Ativo&nbsp;&nbsp;</asp:ListItem>
				        <asp:ListItem Value="2">Inativo</asp:ListItem>
		            </asp:radiobuttonlist>
                </div>
       
            </div>

          <div class="form-group row">
            <div class="col-sm-2">Checkbox</div>
            <div class="col-sm-10">
              <div class="form-check">
                <asp:CheckBox id="ckbMudarSenha" runat="server" Width="200px"	Text="Força Alteração?"></asp:CheckBox>
                
              </div>
            </div>
          </div>
          <Div class= "group-row">
				<asp:button id="btnIncluir" runat="server" class="btn-secondary" Text="Incluir" Visible="False"></asp:button>
				<asp:button id="btnAlterar" runat="server" class="btn-secondary" Text="Alterar" Visible="False"></asp:button>
				<asp:button id="btnExcluir" runat="server" class="btn-secondary" Text="Excluir" Visible="False"></asp:button>
				<asp:button id="btnLimpar" runat="server" class="btn-secondary" CommandArgument="1" Text="Limpar" ></asp:button></TD>
		  </Div>
		  <div>
			<th>
				<asp:label id="lblMensagem" runat="server" ForeColor="Red"></asp:label>
			</th>
		 </div>
          
</form>
</body>
</html>
