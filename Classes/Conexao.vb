'Imports System.Data.SqlClient
Namespace MEURHSESAP
    Public Class Conexao
        Dim vConSql As SqlClient.SqlConnection

        Public Sub New()
            vConSql = New SqlClient.SqlConnection

        End Sub

        Public Function AbreBanco() As Object
            'CONEXAO LOCAL
            'vConSql.ConnectionString = "Data Source=SALASITUA\SAUDEHOMOLOGA; Initial Catalog= DbRHSaude; User id=sa; Password=crh103;"
            'CONEXAO SERVIDOR SRVBDRH
            vConSql.ConnectionString = "Data Source=SRVRHBD\SQLSESAPRH,1433; Initial Catalog= DbRHSaude; User id=sa; Password=Port@1crhS3s@p;"
            vConSql.Open()
            Return vConSql

        End Function

        Public Sub FechaBanco()
            vConSql.Close()
        End Sub

    End Class
End Namespace
