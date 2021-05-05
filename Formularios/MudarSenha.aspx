<%@ Page Language="vb" AutoEventWireup="false" Codebehind="MudarSenha.aspx.vb" Inherits="Formularios.MudarSenha" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Mudar Senha</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="estilo.css" type="text/css" rel="stylesheet">
		<link href="Content/bootstrap.min.css" rel="stylesheet" />
	</HEAD>
	<body>
		<div class="container" style="margin-top:5px; margin-left:4px; ">
		<FORM id="Form1" method="post" runat="server">
			<P align="left">
				<asp:Literal id="litJava" runat="server"></asp:Literal></P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>			
			<TABLE id="Table4" style="WIDTH: 100%;"  align="center" border="0">
				<TR>
					<TD align="center">
						<TABLE id="Table1" style="WIDTH: 246px; HEIGHT: 10px" width="246" border="0">
							<TR>
								<TD class="auto-style1" >
									<h5><STRONG>&nbsp;Mudar Senha</STRONG></h5>
									<HR color="#0099cc" SIZE="1">
								</TD>
							</TR>
						</TABLE>
						<TABLE id="Table2" style="WIDTH: 245px; HEIGHT: 54px" width="245" border="0">
							<TR>
								<TD style="WIDTH: 15%; ">
									<P align="left">Senha Atual </P>
								</TD>
								<TD ><asp:TextBox id="txtSenhaAtual" runat="server" Width="135px" TextMode="Password" MaxLength="11"></asp:TextBox>
								</TD>
							</TR>
							<TR>
								<TD >Nova Senha </TD>
								<TD ><asp:TextBox id="txtNovaSenha" runat="server" Width="135px" TextMode="Password" MaxLength="15"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD >Confirmação </TD>
								<TD ><asp:TextBox id="txtConfirma" runat="server" Width="135px" TextMode="Password" MaxLength="15"></asp:TextBox></TD>
							</TR>
						</TABLE>
						<TABLE id="Table3" style="WIDTH: 246px; HEIGHT: 30px" width="246" border="0">
							<TR>
								<TD align="center">
									<HR width="100%" color="#0099cc" SIZE="1">
									&nbsp;
									<asp:Button id="btnEnviar" runat="server" class="btn-secondary"  Text="Enviar"></asp:Button>
									<asp:Button id="btnLimpar" runat="server" class="btn-secondary"  Text="Limpar"></asp:Button>
									<asp:Button id="btnSair" runat="server"   Class="btn-secondary"  Text="Sair"></asp:Button></TD>
							</TR>
						</TABLE>
						<P align="center">
							<asp:label id="lblMensagem" runat="server" Height="14px" Width="100%" ForeColor="Red" ></asp:label></P>
					</TD>
				</TR>
			</TABLE>
		</FORM>
		</div>
	</body>
</HTML>
