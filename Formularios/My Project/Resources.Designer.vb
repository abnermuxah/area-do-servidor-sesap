﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Esse código foi gerado por uma ferramenta.
'
'     As alterações feitas nesse arquivo poderão causar comportamento incorreto e serão perdidas se
'     o código for regenerado.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My.Resources

    'Esta classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    'por meio de uma ferramenta como ResGen ou Visual Studio.
    'Para adicionar ou remover um membro, edite o arquivo .ResX e execute novamente ResGen
    'com a opção /str ou recrie seu projeto VS.
    '<summary>
    '  Uma classe de recurso fortemente tipado para pesquisar cadeias de caracteres localizadas, etc.
    '</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"), _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

        '<summary>
        '  Retorna a instância de ResourceManager no cache usada por essa classe.
        '</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Formularios.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        '<summary>
        '  Substitui a propriedade CurrentUICulture do thread atual para todas
        '  as pesquisas de recursos que usam essa classe de recursos fortemente tipados.
        '</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As Global.System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property
    End Module
End Namespace
