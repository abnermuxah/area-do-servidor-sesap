Imports MEURHSESAP
Imports System
Public Class Principal
    Inherits System.Web.UI.Page
    Protected WithEvents txtUsuario As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnEnviar As System.Web.UI.WebControls.Button
    Protected WithEvents btnLimpar As System.Web.UI.WebControls.Button
    Protected WithEvents lblMensagem As System.Web.UI.WebControls.Label
    Protected WithEvents litJava As System.Web.UI.WebControls.Literal
    Protected WithEvents txtSenha As System.Web.UI.WebControls.TextBox

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        litJava.Text = ""
        If Not IsPostBack Then
            ' litJava.Text = JavaSetFocus(txtUsuario.ClientID)
        End If
    End Sub


    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        litJava.Text = ""
        Me.Session.Clear()
        'If txtUsuario.Text <> "48160423420" Then
        'lblMensagem.Text = Prepara_Mensagem(lblMensagem, "Sistema Paralizado para Manutenção", 2)
        'Exit Sub
        'End If

        If IsNumeric(txtUsuario.Text) Then
            Dim oLogin As New Usuario(CLng(txtUsuario.Text), txtSenha.Text)
            Try
                If Not oLogin.Verifica_CPF(CLng(txtUsuario.Text)) Then
                    lblMensagem.Text = "CPF Inválido"
                ElseIf Not oLogin.Valido Then
                    lblMensagem.Text = "Usuário sem Permissão"
                Else
                    If oLogin.MudaSenha = 1 Then
                        Session("Usuario") = CLng(txtUsuario.Text)
                        Response.Redirect("MudarSenha.aspx")
                    Else
                        Session("Usuario") = CLng(txtUsuario.Text)
                        Session("Senha") = txtSenha.Text
                        Session("NomeUsuario") = oLogin.NomeUsuario
                        Session("Matricula") = oLogin.MAtricula
                        Response.Redirect("Menu.ASPX")
                    End If
                End If
            Catch ex As Exception
                lblMensagem.Text = ex.Message
            End Try
        Else
            lblMensagem.Text = "Usuário deve ser Numérico"
        End If

    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        txtUsuario.Text = ""
        txtSenha.Text = ""
        lblMensagem.Text = ""
        litJava.Text = JavaSetFocus(txtUsuario.ClientID)
    End Sub

    Protected Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class
