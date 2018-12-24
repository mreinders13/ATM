Option Strict On
Public Class frmMenu
    Public Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GlobalSettings.CurrentChecking = New CheckingAccount(123, 1000)
        'GlobalSettings.CurrentSavings = New SavingsAccount(234, 1000)
        'GlobalSettings.CurrentCredit = New CreditCard(345, 1000)

    End Sub
    Private Sub btnMakeWithdrawl_Click(sender As Object, e As EventArgs) Handles btnMakeWithdrawl.Click
        Dim frm As New frmMakeWithdrawl
        frmMakeWithdrawl.Show()
        Me.Hide()
    End Sub

    Private Sub btnMakeDeposit_Click(sender As Object, e As EventArgs) Handles btnMakeDeposit.Click
        frmMakeDeposit.Show()
        Me.Hide()
    End Sub

    Private Sub btnImFinished_Click(sender As Object, e As EventArgs) Handles btnImFinished.Click
        Application.Exit()
    End Sub

    Private Sub btnMakeTransfer_Click(sender As Object, e As EventArgs) Handles btnMakeTransfer.Click
        frmTransferFunds.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnViewBalance.Click
        frmViewBalance.Show()
        Me.Hide()
    End Sub


End Class