﻿Imports System.Collections.Immutable
Imports CodeCracker.Extensions
Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.Diagnostics
Imports Microsoft.CodeAnalysis.VisualBasic
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

<DiagnosticAnalyzer(LanguageNames.VisualBasic)>
Public Class ParameterRefactoryAnalyzer
    Inherits DiagnosticAnalyzer

    Friend Const Title = "You should use a class."
    Friend Const MessageFormat = "When the method has more than three parameters, use a class."
    Friend Const Category = SupportedCategories.Refactoring

    Friend Shared Rule As New DiagnosticDescriptor(
        DiagnosticId.ParameterRefactory.ToDiagnosticId,
        Title,
        MessageFormat,
        Category,
        DiagnosticSeverity.Hidden,
        isEnabledByDefault:=True
    )

    Public Overrides ReadOnly Property SupportedDiagnostics As ImmutableArray(Of DiagnosticDescriptor)
        Get
            Return ImmutableArray.Create(Rule)
        End Get
    End Property

    Public Overrides Sub Initialize(context As AnalysisContext)
        context.RegisterSyntaxNodeAction(AddressOf AnalyzeNode, SyntaxKind.SubStatement, SyntaxKind.FunctionStatement)
    End Sub

    Public Sub AnalyzeNode(context As SyntaxNodeAnalysisContext)
        Dim method = DirectCast(context.Node, MethodBlockBaseSyntax)
        If method.Begin.Modifiers.Any(SyntaxKind.FriendKeyword) Then Exit Sub

        ' Check for extension method
        For Each attributeList In method.Begin.AttributeLists
            For Each attribute In attributeList.Attributes
                If attribute.Name.ToString() = "Extension" Then Exit Sub
            Next
        Next

        Dim contentParameter = method.Begin.ParameterList
        If contentParameter.Parameters.Any() OrElse
                contentParameter.Parameters.Count <= 3 Then Exit Sub

        For Each parameter In contentParameter.Parameters
            For Each modifier In parameter.Modifiers
                If modifier.IsKind(SyntaxKind.ByRefKeyword) OrElse
                        modifier.IsKind(SyntaxKind.ParamArrayKeyword) Then
                    Exit Sub
                End If
            Next
        Next

        Dim diag = Diagnostic.Create(Rule, contentParameter.GetLocation())
        context.ReportDiagnostic(diag)
    End Sub
End Class
