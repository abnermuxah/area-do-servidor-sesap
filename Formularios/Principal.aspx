<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Principal.aspx.vb" Inherits="Formularios.Principal" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		 <title>Login MEURHSESAP Sesap</title>

        <link rel="shortcut icon" href="figuras/susIcon.svg" type="image/x-icon">
        <script type="text/javascript" src="https://kit.fontawesome.com/6aed1488f5.js" ></script>
        <script type="text/javascript" src="Scripts/jquery-3.0.0.slim.min.js"></script>
        <script type="text/javascript" src="Scripts/popper.min.js"></script>
         <link href="Content/bootstrap.min.css" rel="stylesheet" />
        <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
        <style type="text/css">
            .header {
                max-width: 400px;
            }

            html,
            body {
                height:400px;
            }

            .borda {
                border: #0080c7 solid 5px;
            }

            .azulSesap {
                background-color: #0080c7;
                font-size:small;
            }

            .footer {
                background-color: darkgray;
                font-size:small;

            }
        </style>
	</HEAD>
<body class="bg-light">

    <div class="align-middle mt-5">
        <div class="azulSesap mx-auto borda p-2 header mt-5 text-center text-light">
            <i class="fas fa-address-card fa-4x"></i>
            <h3 > MEU RH SESAP</h3>
            <h5 >Area Restrita do Servidor SESAP</h5>
        </div>
        <section class="header shadow-md borda mx-auto bg-white p-3 rounded" >
        <form id="Form1" method="post" runat="server" >
            <div class="form-group py-2">
                <label for="txtUsuario">
                    <i class="fas fa-user"></i>
                    <b>Usuário</b>
                </label>
                <asp:textbox id="txtUsuario" class="form-control" runat="server"   MaxLength="11" placeholder="Digite seu CPF"></asp:textbox>
            </div>
            <div class="form-group py-2">
                <label for="txtSenha">
                    <i class="fas fa-lock"></i>
                    <b>Senha</b>
                </label>
                <asp:textbox id="txtSenha" type="password"  class="form-control" runat="server"  MaxLength="15" TextMode="Password" placeholder="Digite sua senha"></asp:textbox>
            </div>
            <div class="row">
                <asp:button id="btnEnviar" class="btn btn-primary azulSesap col-sm-10 mx-auto" runat="server"  Text="Enviar"></asp:button>
            </div>
            <P align="center"><asp:label id="lblMensagem" runat="server" ForeColor="Red" Font-Size="Smaller" Font-Names="Tahoma"
									Width="242px" Height="14px"></asp:label></P>
            </div>
            <asp:literal id="litJava" runat="server"></asp:literal>
            <div >
                <footer class="azulSesap header borda mx-auto text-light text-center">
                <p >
                    <a class="text-light" href="http://www.rn.gov.br" target="_blank">
                        <strong>GOVERNO DO RN</strong>
                        - © 2021
                    </a><br>
                    <a class="text-light" href="http://www.Saude.rn.gov.br" target="_blank"> <strong > SIGTE/CGTES/SESAP-RN</strong> - Versão 2.0 </a> 
                </p>
                </footer> 
		    </div>
            <div >
        </form>
		</section>
    </div>


</body>

</html>
