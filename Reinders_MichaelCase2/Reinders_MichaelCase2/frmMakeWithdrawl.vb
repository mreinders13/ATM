Option Strict On
Public Class frmMakeWithdrawl

    Private fkey As frmKeyPad

    Private Sub frmMakeWithdrawl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the KeyPad in the withdrawl panel
        fkey = New frmKeyPad()
        fkey.TopLevel = False
        fkey.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        fkey.WindowState = FormWindowState.Normal
        fkey.Visible = True
        withdrawlPanel.Controls.Add(fkey)
        btnWAnotherTransaction.Hide()

    End Sub
    Private Sub btnWFromChecking_Click(sender As Object, e As EventArgs) Handles btnWFromChecking.Click

        If (GlobalSettings.HiddenKeyPadVariable < GlobalSettings.CurrentChecking.HiddenAccountBalance) Then
            If (ValidateAmount.IsPositiveDouble(GlobalSettings.HiddenKeyPadVariable)) Then
                GlobalSettings.CurrentChecking.MakeWithdrawal(GlobalSettings.HiddenKeyPadVariable)
                MessageBox.Show("You have successfully withdrawn $" & GlobalSettings.HiddenKeyPadVariable.ToString("#,###,###.##") & " from your Checking Account.", "Withdrawl Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnWFromSavings.Hide()
                btnWFromChecking.Hide()
                withdrawlPanel.Enabled = False
                btnWAnotherTransaction.Show()
            Else
                MessageBox.Show("Please enter a positive amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
            MessageBox.Show("Your Withdrawl was unsuccessful due to insufficient funds. Please try again.",
            "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
            fkey.ResetTextBox()
        End If

    End Sub

    Private Sub btnWFinished_Click(sender As Object, e As EventArgs) Handles btnWFinished.Click
        withdrawlPanel.Enabled = True
        GlobalSettings.HiddenKeyPadVariable = 0
        btnWFromChecking.Show()
        btnWFromSavings.Show()
        btnWAnotherTransaction.Hide()
        fkey.ResetTextBox()
        frmMenu.Show()
        frmKeyPad.Hide()
        Me.Hide()
    End Sub

    Private Sub btnWAnotherTransaction_Click(sender As Object, e As EventArgs) Handles _
        btnWAnotherTransaction.Click
        withdrawlPanel.Enabled = True
        GlobalSettings.HiddenKeyPadVariable = 0
        btnWFromChecking.Show()
        btnWFromSavings.Show()
        btnWAnotherTransaction.Hide()
        fkey.ResetTextBox()
    End Sub

    Private Sub btnWFromSavings_Click(sender As Object, e As EventArgs) Handles btnWFromSavings.Click

        If (GlobalSettings.HiddenKeyPadVariable < GlobalSettings.CurrentSavings.HiddenAccountBalance) Then
            If (ValidateAmount.IsPositiveDouble(GlobalSettings.HiddenKeyPadVariable)) Then
                GlobalSettings.CurrentSavings.MakeWithdrawal(GlobalSettings.HiddenKeyPadVariable)
                MessageBox.Show("You have successfully withdrawn $" & GlobalSettings.HiddenKeyPadVariable.ToString("#,###,###.##") & " from your Savings Account", "Withdrawl Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnWFromSavings.Hide()
                btnWFromChecking.Hide()
                withdrawlPanel.Enabled = False
                btnWAnotherTransaction.Show()
            Else
                MessageBox.Show("Please enter a positive amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Else
            MessageBox.Show("Your Withdrawl was unsuccessful due to insufficient funds. Please try again.",
            "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
            fkey.ResetTextBox()
        End If
    End Sub


End Class