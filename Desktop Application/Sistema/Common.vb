Module Common

    Friend Sub SelectAllText(control As Object)
        Select Case control.GetType()
            Case GetType(TextBox)
                CType(control, TextBox).SelectAll()
            Case GetType(MaskedTextBox)
                CType(control, MaskedTextBox).SelectAll()
            Case GetType(NumericUpDown)
                CType(control, NumericUpDown).Select(0, CType(control, NumericUpDown).Text.Length)
        End Select
    End Sub
End Module
