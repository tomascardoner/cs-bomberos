Imports iTextSharp.text

Partial Public Class TipografiaEstilo
    Friend ReadOnly Property Estilo() As Integer
        Get
            Dim _estilo As Integer = Font.UNDEFINED

            If Me.Negrita And Me.Italica Then
                _estilo = Font.BOLDITALIC
            ElseIf Me.Negrita Then
                _estilo = Font.Bold
            ElseIf Me.Italica Then
                _estilo = Font.Italic
            End If
            If Me.Subrayada Then
                _estilo = _estilo Or Font.Underline
            End If
            If Me.Tachada Then
                _estilo = _estilo Or Font.STRIKETHRU
            End If

            Return _estilo
        End Get
    End Property
End Class