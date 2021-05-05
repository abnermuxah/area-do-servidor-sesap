'Imports System
'Imports System.Data
Namespace MEURHSESAP
    Public Module Funcoes
        Public Function Converte_TextoData(ByVal str As String) As Date
            Dim dt As Date
            Dim format As New Globalization.CultureInfo("fr-FR", True)
            If str <> "" Then
                dt = Convert.ToDateTime(str, format)
            End If
            Return dt
        End Function

        Public Function Converte_DataTexto(ByVal dt As Date) As String
            Dim format As New Globalization.CultureInfo("fr-FR", False)
            Dim str As String = ""
            If Not IsDBNull(dt) Then
                str = Mid(Convert.ToString(dt, format), 1, 10)
            End If
            Return str
        End Function

        Public Function Testa_Data(ByVal str As String) As Boolean
            Dim dt As Date
            Dim format As New Globalization.CultureInfo("fr-FR", True)
            Try
                dt = Convert.ToDateTime(str, format)
            Catch
                Return False
            End Try
            Return True
        End Function

        Public Function Converte_StrInt(ByVal str As String) As Integer
            Dim vInt As Integer
            vInt = CInt(IIf(IsNumeric(str), str, 0))
            Return vInt
        End Function


        Public Function Formata_Valor(ByVal aVlr As String) As String
            Dim vRet As String = ""
            Dim vTam As Integer = 0
            If (aVlr <> "0.00") And (aVlr <> "") Then
                vTam = Len(aVlr)
                If vTam > 3 Then
                    vRet = Replace(Mid(aVlr, 1, vTam - 3), ",", "") & Replace(Mid(aVlr, vTam - 2), ".", ",")
                    vTam = Len(vRet)
                    vRet = Replace(Mid(vRet, 1, vTam - 3), ".", "") & Replace(Mid(vRet, vTam - 2), ".", ",")
                    vRet = Format(Decimal.Parse(vRet), "###,##0.00")
                Else
                    vRet = Replace(aVlr, ".", ",")
                    vRet = Format(Decimal.Parse(vRet), "###,##0.00")
                End If
            End If
            Return vRet
        End Function

        Public Function Converte_DecSql(ByVal aVlr As String) As String
            Dim vRet As String = "0"
            Dim vTam As Integer = 0

            If aVlr <> "" Then
                vTam = Len(aVlr)
                If vTam > 3 Then
                    vRet = Replace(Mid(aVlr, 1, vTam - 3), ".", "") & Replace(Mid(aVlr, vTam - 2), ",", ".")
                Else
                    vRet = Replace(aVlr, ",", ".")
                End If
            End If
            Return vRet
        End Function

        Public Function Prepara_Lista(ByVal aLista As Object, ByVal aObj As Object) As Object
            aObj.DataSource = aLista
            aObj.DataValueField = aLista.Columns(0).ColumnName()
            aObj.DataTextField = aLista.Columns(1).ColumnName()
            aObj.DataBind()
            Return aObj
        End Function

        Public Function Prepara_ListaChaveComposta(ByVal aLista As Object, ByVal aObj As Object, ByVal aCol As String) As Object
            aObj.DataSource = aLista
            aObj.DataValueField = aLista.Columns(0).ColumnName() & "-" & aLista.Columns(aCol).ColumnsName()
            aObj.DataTextField = aLista.Columns(1).ColumnName()
            aObj.DataBind()
            aObj.items.Insert(0, "<SELECIONAR>")
            aObj.items(0).Value = 0
            aObj.SelectedIndex = 0
            Return aObj

        End Function

        Public Function Prepara_ListaComSelecionar(ByVal aLista As Object, ByVal aObj As Object) As Object

            aObj.DataSource = aLista
            aObj.DataValueField = aLista.Columns(0).ColumnName()
            aObj.DataTextField = aLista.Columns(1).ColumnName()
            aObj.DataBind()
            aObj.items.Insert(0, "<SELECIONAR>")
            aObj.items(0).Value = 0
            aObj.SelectedIndex = 0

            Return aObj
        End Function

        Public Function Prepara_Mensagem(ByVal aMens As Object, ByVal aTexto As String, ByVal aCor As Integer) As Object
            aMens.text = aTexto
            If aCor = 1 Then
                aMens.ForeColor = aMens.ForeColor.Blue()
            Else
                aMens.ForeColor = aMens.ForeColor.Red()
            End If
            Return aMens
        End Function

        Public Function Restaura_Lista(ByVal aLista As Object, ByVal aCod As Integer) As Integer
            Dim i As Integer
            For i = 0 To aLista.Items.Count - 1
                If aLista.Items(i).Value = aCod Then
                    Exit For
                Else
                    Dim a As String = aLista.Items(i).Value
                End If
            Next
            Return i
        End Function

        '        Public Sub Libera_Acoes(ByVal aAcoes As Object, ByVal aFrm As Object)
        '           Dim vCtr As Object
        '          Dim vCtb As Object
        '         Dim vCtp As Object
        '
        '           For Each vCtr In aFrm.Controls
        '              If UCase(vCtr.GetType.Name) = "HTMLFORM" Then
        '                 For Each vCtb In vCtr.Controls
        '                    If (UCase(vCtb.GetType.Name) = "BUTTON" Or UCase(vCtb.GetType.Name) = "LINKBUTTON") And vCtb.Visible = True Then
        '                       If vCtb.CommandArgument <> "1" Then
        '                          vCtb.Visible = False
        '                         Dim dr As DataRow
        '                        For Each dr In aAcoes.Rows
        '                           If (dr.Item("BotaoAcao") = vCtb.ID.ToString) Then
        '                              vCtb.Visible = True
        '                             Exit For
        '                        End If
        '                   Next
        '              End If
        '                End If
        '           Next
        '        End If
        '    Next
        ' End Sub


        Public Sub Libera_Acoes(ByVal aAcoes As Object, ByVal aFrm As Object)
            Dim vCtr As Object
            For Each vCtr In aFrm.Controls
                If UCase(vCtr.GetType.Name) = "HTMLFORM" Then
                    Trata_Visibilidade(aAcoes, vCtr)
                End If
            Next

        End Sub


        Public Sub Trata_Visibilidade(ByVal aAcoes As Object, ByVal aCtr As Object)
            Dim vCtb As Object

            For Each vCtb In aCtr.Controls
                If (UCase(vCtb.GetType.Name) = "BUTTON" Or UCase(vCtb.GetType.Name) = "LINKBUTTON") And vCtb.Visible = True Then
                    If vCtb.CommandArgument <> "1" Then
                        vCtb.Visible = False
                        Dim dr As DataRow
                        For Each dr In aAcoes.Rows
                            If (UCase(dr.Item("BotaoAcao")) = UCase(vCtb.ID.ToString)) Then
                                vCtb.Visible = True
                                Exit For
                            End If
                        Next
                    End If
                ElseIf vCtb.Controls.Count > 0 And UCase(vCtb.GetType.Name) = "PANEL" Then
                    Trata_Visibilidade(aAcoes, vCtb)
                End If
            Next


        End Sub

        Public Function Replicate(ByVal c As String, ByVal n As Integer) As String
            Dim i As Integer
            Dim str As String
            str = ""
            For i = 1 To n
                str &= c
            Next
            Return str
        End Function

        Public Function TiraAcento(ByVal sTexto As String) As String
            'Retorna o texto sem acentuação 
            Dim Carac_esp, C_especial, C_subst As String
            Dim F_tam As Integer, F_pos As Integer
            Dim conta_letra As Integer
            Dim Fonte As String

            Fonte = sTexto
            C_especial = "áàãâäÁÀÃÂÄóòõôöÓÒÕÔÖÉÈÊËéèêëíìïÍÌÏúùûüÚÙÛÜçÇ')(~*"""
            C_subst = "aaaaaAAAAAoooooOOOOOEEEEeeeeiiiIIIuuuuUUUUcC______"

            F_tam = Len(Fonte)

            For conta_letra = 1 To F_tam
                Carac_esp = Mid$(Fonte, conta_letra, 1)
                F_pos = InStr(1, C_especial, Carac_esp, vbBinaryCompare)
                If F_pos > 0 Then
                    Mid(Fonte, conta_letra, 1) = Mid(C_subst, F_pos, 1)
                End If
            Next conta_letra
            Fonte = Replace(Fonte, "_", "")
            TiraAcento = Fonte
        End Function
        Function JavaSetFocus(ByVal sCampo As String) As String
            Dim strMsg As String = ""
            strMsg = "<SCRIPT language='javascript'> "
            strMsg = strMsg & "document.all['" & sCampo & "'].focus();"
            strMsg = strMsg & "</SCRIPT>"
            Return strMsg
        End Function

        Function JavaMsgBox(ByVal sMensagem As String) As String
            Dim strMsg As String = ""
            sMensagem = TiraAcento(sMensagem)
            strMsg = "<SCRIPT language='javascript'> " & Chr(13)
            strMsg = strMsg & "alert('" & sMensagem & "')" & Chr(13)
            strMsg = strMsg & "</SCRIPT>"
            Return strMsg
        End Function
        Function JavaReportComFormato(ByVal sRel As String, ByVal sPam As String, ByVal sQte As String, ByVal sTipo As String) As String
            Dim strMsg As String = ""
            strMsg = "<script language='javascript'> " & Chr(13)
            strMsg = strMsg & "window.open(" & """" & "Visualizador.aspx?rpt=" & sRel & "&Param=" & sPam & "&Ind=" & sQte & "&Formato=" & sTipo & """" & ","
            strMsg = strMsg & """""" & "," & """" & "top=0,left=0,height=550,width=800,status=no,toolbar=no,resizable=1,menubar=no,location=no,channelmode=no" & """" & ")"
            strMsg = strMsg & "</script>"
            Return strMsg
        End Function
        Function JavaReport(ByVal sRel As String, ByVal sPam As String, ByVal sQte As String) As String
            Dim strMsg As String = ""
            strMsg = "<script language='javascript'> " & Chr(13)
            strMsg = strMsg & "window.open(" & """" & "Visualizador.aspx?rpt=" & sRel & "&Param=" & sPam & "&Ind=" & sQte & """" & ","
            strMsg = strMsg & """""" & "," & """" & "top=0,left=0,height=550,width=790,status=no,toolbar=no,resizable=1,menubar=no,location=no,channelmode=no" & """" & ")"
            strMsg = strMsg & "</script>"
            Return strMsg
        End Function

        Function JavaAbreWindow(ByVal sForm As String) As String
            Dim strMsg As String = ""
            strMsg = "<SCRIPT language='javascript'> " & Chr(13)
            strMsg = strMsg & "window.open(" & """" & sForm & """" & ","
            strMsg = strMsg & """""" & "," & """" & "top=0,left=0,height=470,width=790,status=no,toolbar=no,menubar=1,scrollbars=yes,location=no,channelmode=no" & """" & ")"
            strMsg = strMsg & "</SCRIPT>"
            Return strMsg
        End Function


        Function JavaFechaWindow() As String
            Dim strMsg As String = ""
            strMsg = "<SCRIPT language='javascript'> " & Chr(13)
            strMsg = strMsg & "self.close()"
            strMsg = strMsg & "</SCRIPT>"
            Return strMsg
        End Function

        Function JavaExecuta(ByVal aComando As String) As String
            Dim strMsg As String = ""
            strMsg = "<SCRIPT language='javascript'> " & Chr(13)
            strMsg = strMsg & aComando & "</SCRIPT>"
            Return strMsg
        End Function

        Function RetornaHorasPlantao(ByVal sPlantao As String) As Integer
            Dim vHoras As Integer
            'vLista(i) = "" Or UCase(vLista(i)) = "M" Or UCase(vLista(i)) = "T" Or UCase(vLista(i)) = "D" Or UCase(vLista(i)) = "N" Or UCase(vLista(i)) = "P" Or UCase(vLista(i)) = "W" Or UCase(vLista(i)) = "Y"
            If sPlantao = "M" Or sPlantao = "T" Then
                vHoras = 6
            ElseIf sPlantao = "D" Or sPlantao = "N" Then
                vHoras = 12
            ElseIf sPlantao = "P" Then
                vHoras = 24
            ElseIf sPlantao = "W" Or sPlantao = "Y" Then
                vHoras = 18
            Else
                vHoras = 0
            End If
            Return vHoras
        End Function
    End Module
End Namespace
