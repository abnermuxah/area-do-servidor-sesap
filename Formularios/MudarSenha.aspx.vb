Imports MEURHSESAP
Public Class MudarSenha
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents litJava As System.Web.UI.WebControls.Literal
    Protected WithEvents txtNovaSenha As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtSenhaAtual As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnLimpar As System.Web.UI.WebControls.Button
    Protected WithEvents btnEnviar As System.Web.UI.WebControls.Button
    Protected WithEvents lblMensagem As System.Web.UI.WebControls.Label
    Protected WithEvents txtConfirma As System.Web.UI.WebControls.TextBox
    Protected WithEvents Image1 As System.Web.UI.WebControls.Image
    Protected WithEvents btnSair As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Session("Usuario") = 0 Then
            Response.Redirect("EncerraSessao.aspx")
        End If
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        If txtNovaSenha.Text <> txtConfirma.Text Then
            lblMensagem.Text = "Confirmação de senha não confere"
        Else
            Dim oLogin As New Usuario(Session("Usuario"), txtSenhaAtual.Text)
            Try
                If Not oLogin.Valido Then
                    lblMensagem.Text = "Usuário sem Permissão"
                Else
                    oLogin.Senha = txtNovaSenha.Text
                    oLogin.AlterarSenha()
                    Session("Senha") = txtNovaSenha.Text
                    Session("NomeUsuario") = oLogin.NomeUsuario
                    Session("Matricula") = oLogin.MAtricula
                    Response.Redirect("Menu.aspx")
                End If
            Catch ex As Exception
                lblMensagem.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        txtSenhaAtual.Text = ""
        txtNovaSenha.Text = ""
        txtConfirma.Text = ""
        lblMensagem.Text = ""
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Response.End()
    End Sub
End Class
