Option Strict On
Public Class CheckingAccount
    Public HiddenCheckingAccountID As Integer
    Public HiddenAccountBalance As Double

    Public Sub New(argID As Integer, argBeginningBalance As Double)
        HiddenCheckingAccountID = argID
        HiddenAccountBalance = argBeginningBalance

    End Sub

    Public ReadOnly Property GetID As Integer
        Get
            Return HiddenCheckingAccountID
        End Get
    End Property

    Public ReadOnly Property GetBalance As Double
        Get
            Return HiddenAccountBalance
        End Get
    End Property

    Public Function MakeWithdrawal(ByVal amount As Double) As Double
        HiddenAccountBalance = HiddenAccountBalance - amount
        Return HiddenAccountBalance
    End Function

    Public Function MakeDeposit(ByVal amount As Double) As Double
        HiddenAccountBalance = HiddenAccountBalance + amount
        Return HiddenAccountBalance
    End Function
End Class
