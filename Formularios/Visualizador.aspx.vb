Imports MEURHSESAP
Imports System.Configuration
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class visualizador
    Inherits System.Web.UI.Page
    Protected WithEvents rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rpt = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '
        'rpt
        '
        Me.rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        Me.rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        Me.rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Upper
        Me.rpt.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        Dim strPathRpt, strArquivo, strRpt, strParam, vExt, vTipo As String
        Dim strQte As Integer
        Dim mExport As ExportOptions
        Dim mDiskFileDestination As New DiskFileDestinationOptions()
        Dim strFormato As String
        strRpt = Request.QueryString("rpt")
        strParam = Request.QueryString("Param")
        strQte = Request.QueryString("Ind")
        strFormato = Request.QueryString("Formato")

        strPathRpt = Request.PhysicalApplicationPath
        strPathRpt = strPathRpt.Replace("Formularios", "Relatorios")
        'strPathRpt = "C:\Inetpub\wwwroot\RHEventosWeb\Relatorios\"



        rpt.Load(strPathRpt & strRpt)
        rpt.DataSourceConnections.Item(0).SetConnection("SRVRHBD\SQLSESAPRH,1433", "DBRHSaude", "sa", "Port@1crhS3s@p")
        vTipo = "application/pdf"
        If strFormato = "5" Or strFormato = "" Then
            vExt = ".pdf"
            vTipo = "application/pdf"
        ElseIf strFormato = "3" Then
            vExt = ".doc"
            vTipo = "application/doc"
        ElseIf strFormato = "4" Then
            vExt = ".xls"
            vTipo = "application/vnd.ms-excel"
        End If



        strArquivo = strPathRpt & Replace(strRpt, ".", "_") & Date.Now.Hour & Date.Now.Minute & Date.Now.Second & Date.Now.Millisecond & vExt

        mDiskFileDestination.DiskFileName = strArquivo
        mExport = rpt.ExportOptions

        With mExport
            .DestinationOptions = mDiskFileDestination
            .ExportDestinationType = ExportDestinationType.DiskFile
            If strFormato = "" Or strFormato = "5" Then
                .ExportFormatType = ExportFormatType.PortableDocFormat
            ElseIf strFormato = "4" Then
                .ExportFormatType = ExportFormatType.ExcelRecord
            ElseIf strFormato = "3" Then
                .ExportFormatType = ExportFormatType.WordForWindows
            End If
            '.ExportFormatType = ExportFormatType.PortableDocFormat

        End With

        Dim aSTR() As Object = Split(strParam, "@")
        Dim i As Integer = 0

        If strQte > 0 Then
            Dim oPv As New CrystalDecisions.Shared.ParameterValues
            Dim oPd As New CrystalDecisions.Shared.ParameterDiscreteValue
            For i = 0 To strQte - 1
                oPd.Value = aSTR(i)
                oPv.Add(oPd)
                rpt.DataDefinition.ParameterFields(i).ApplyCurrentValues(oPv)
            Next
        End If
        rpt.Export()

        With Response
            .ClearContent()
            .ClearHeaders()
            .WriteFile(strArquivo, vbFalse)
            .Flush()
            .Close()
        End With
        System.IO.File.Delete(strArquivo)
    End Sub


End Class
