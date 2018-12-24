Option Strict On
Public Class GlobalSettings
    Public Shared CurrentCustomer As Customer
    Public Shared CurrentChecking As CheckingAccount
    Public Shared CurrentSavings As SavingsAccount
    Public Shared CurrentCredit As CreditCard
    Public Shared CurrentMenu As frmMenu
    Public Shared CurrentKeypad As frmKeyPad


    '****************************This stores the variable from the KeyPad****************************
    Public Shared HiddenKeyPadVariable As Double
    Public ReadOnly Property KeyPadVariable As Double
        Get
            Return HiddenKeyPadVariable
        End Get
    End Property
End Class
