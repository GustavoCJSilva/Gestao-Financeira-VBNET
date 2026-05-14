Public Module ValidadorCPF
    Public Function ValidadorCPF(cpf As String) As Boolean
        Dim cpfLimpo As String = cpf.Replace(".", "").Replace("-", "")

        If cpfLimpo.Length <> 11 Then Return False

        Dim repetido As Boolean = True
        For i As Integer = 1 To 10
            If cpfLimpo(i) <> cpfLimpo(0) Then
                repetido = False
                Exit For
            End If
        Next
        If repetido Then Return False

        Dim soma As Integer = 0
        Dim resto As Integer = 0
        Dim digito1 As Integer = 0
        Dim digito2 As Integer = 0
        Dim base As String = cpfLimpo.Substring(0, 9)

        For i As Integer = 0 To 8
            soma += Val(base(i)) * (10 - i)
        Next
        resto = soma Mod 11
        If resto < 2 Then
            digito1 = 0
        Else
            digito1 = 11 - resto
        End If

        If Val(cpfLimpo(9)) <> digito1 Then Return False

        soma = 0
        base = base & digito1
        For i As Integer = 0 To 9
            soma += Val(base(i)) * (11 - i)
        Next
        resto = soma Mod 11
        If resto < 2 Then
            digito2 = 0
        Else
            digito2 = 11 - resto
        End If

        If Val(cpfLimpo(10)) <> digito2 Then Return False

        Return True
    End Function
End Module