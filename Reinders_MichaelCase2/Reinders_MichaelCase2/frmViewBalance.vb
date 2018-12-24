Public Class frmViewBalance
    Private Sub btnBalanceBack_Click(sender As Object, e As EventArgs) Handles btnBalanceBack.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub frmViewBalance_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        lblBalanceCheckingTotal.Text = "Your Checking Account has a balance of " & GlobalSettings.CurrentChecking.GetBalance.ToString("$#,###,###.##")
        lblBalanceSavingsTotal.Text = "Your Savings Account has a balance of " & GlobalSettings.CurrentSavings.GetBalance.ToString("$#,###,###.##")
        lblCreditCardBalance.Text = "Your Credit Card has a balance of " & GlobalSettings.CurrentCredit.CreditBalance.ToString("$#,###,###.##")
        lblCreditCardCredit.Text = "Availible Credit: " & GlobalSettings.CurrentCredit.AvailibleCredit.ToString("$#,###,###.##")
    End Sub
End Class