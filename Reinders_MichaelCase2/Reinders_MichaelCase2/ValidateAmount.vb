Module ValidateAmount
    Public Function IsPositiveDouble(argValue As Double) As Boolean
        Dim Result As Double
        If (System.Double.TryParse(argValue, Result)) Then
            If (Result > 0) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Module
