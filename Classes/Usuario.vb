Namespace MEURHSESAP
    Public Structure Transacao
        Dim Menu As String
        Dim submenu As String
        Dim Pagina As String

    End Structure

    Public Class Usuario

        Private aPermissoes() As Transacao
        Private vUsuario As Long
        Private vSenha As String
        Private vMudaSenha As Integer
        Private vNomeUsuario As String
        Private vMAtricula As String
        Private vLista As ArrayList
        Private vAcoes As DataTable
        Private vConn As Conexao
        Dim vNomeTransacao As String

        Public Property Usuario() As Integer
            Get
                Return vUsuario
            End Get
            Set(ByVal Value As Integer)
                vUsuario = Value
            End Set
        End Property
        Public Property Senha() As String
            Get
                Return vSenha
            End Get
            Set(ByVal Value As String)
                vSenha = Value
            End Set
        End Property



        Public ReadOnly Property MudaSenha() As Integer
            Get
                Return vMudaSenha
            End Get
        End Property

        Public ReadOnly Property MAtricula() As Integer
            Get
                Return vMAtricula
            End Get
        End Property

        Public ReadOnly Property NomeUsuario() As String
            Get
                Return vNomeUsuario
            End Get
        End Property

        Public Sub New()
            vConn = New Conexao
        End Sub

        Public Sub New(ByVal pUser As String, ByVal pSenha As String)
            vUsuario = pUser
            vSenha = pSenha
            vConn = New Conexao
        End Sub



        Public Function Valido() As Boolean
            GetPermissao()
            If vNomeUsuario <> "" Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Sub GetPermissao()
            Dim vSql As New SqlClient.SqlCommand
            Dim dr As SqlClient.SqlDataReader
            Try
                vSql.CommandType = CommandType.StoredProcedure
                vSql.CommandText = "pr_Ger_CadastroServidor_Permissao"
                vSql.Parameters.AddWithValue("@Usuario", vUsuario)
                vSql.Parameters.AddWithValue("@Senha", vSenha)

                vSql.Connection = vConn.AbreBanco

                dr = vSql.ExecuteReader
                While dr.Read
                    vNomeUsuario = dr("Nome")
                    vMudaSenha = dr("MudaSenha")
                    vMatricula = dr("Matricula")
                End While
            Catch ex As Exception
                Throw New System.Exception(ex.Message)
            Finally
                vConn.FechaBanco()
                dr.Close()
            End Try
        End Sub

        Public Sub AlterarSenha()
            Dim vConn As New Conexao
            Dim vSql As New SqlClient.SqlCommand
            vSql.CommandType = CommandType.StoredProcedure
            vSql.CommandText = "pr_Ger_CadastroServidor_UpSenha"
            vSql.Parameters.AddWithValue("@CPF", vUsuario)
            vSql.Parameters.AddWithValue("@Senha", vSenha)
            Try
                vSql.Connection = vConn.AbreBanco
                vSql.ExecuteNonQuery()
            Catch ex As Exception
                Throw New System.Exception("Problema na Alteracao de Senha : " & ex.Message)
            Finally
                vConn.FechaBanco()
            End Try
        End Sub


        Function Verifica_CPF(ByVal CpfInt As Long) As Boolean
            Dim i As Integer
            Dim controle As String
            Dim soma As Integer
            Dim Cpf As String

            Cpf = Right("00000000000" + RTrim(CStr(CpfInt)), 11)

            If Len(RTrim(Cpf)) <> 11 Then
                Return False
            End If

            Dim ii As Integer
            Dim contini As Integer
            Dim contfim As Integer
            Dim digito As Integer

            digito = 0
            controle = ""
            contini = 2
            contfim = 10
            ii = 1

            Do While ii <= 2
                soma = 0
                i = contini
                Do While i <= contfim
                    soma = soma + (CInt(Mid$(Cpf, i - ii, 1)) * (contfim + 1 + ii - i))
                    i = i + 1
                Loop
                If ii = 2 Then
                    soma = soma + (2 * digito)
                End If
                digito = (soma * 10) Mod 11
                If digito = 10 Then
                    digito = 0
                End If
                controle = controle + CStr(digito)
                contini = 3
                contfim = 11
                ii = ii + 1
            Loop
            If controle <> Mid$(Cpf, 10, 2) Then
                Return False
            End If

            Return True

        End Function

    End Class

End Namespace
