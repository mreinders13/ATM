Option Strict On
Public Class frmMakeDeposit
    Public fkey As frmKeyPad
    Private Sub frmMakeDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the KeyPad in the deposit panel
        'Dim fkey As frmKeyPad
        fkey = New frmKeyPad()
        'fkey.lblDKeypadDescription.Text = "Please enter the amount you would like to deposit and click OK."
        fkey.TopLevel = False
        fkey.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        fkey.WindowState = FormWindowState.Normal
        fkey.Visible = True
        DepositPanel.Controls.Add(fkey)
        btnDAnotherTransaction.Hide()
    End Sub

    Private Sub btnDFromChecking_Click(sender As Object, e As EventArgs) Handles btnDFromChecking.Click

        If (GlobalSettings.HiddenKeyPadVariable > 0) Then
            If (ValidateAmount.IsPositiveDouble(GlobalSettings.HiddenKeyPadVariable)) Then
                GlobalSettings.CurrentChecking.MakeDeposit(GlobalSettings.HiddenKeyPadVariable)
                MessageBox.Show("You have successfully deposited $" & GlobalSettings.HiddenKeyPadVariable.ToString("#,###,###.##") & " to your Checeking Account", "Deposit Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnDFromSavings.Hide()
                btnDFromChecking.Hide()
                DepositPanel.Enabled = False
                btnDAnotherTransaction.Show()
            Else
                MessageBox.Show("Your Deposit was unsuccessful due to insufficient funds. Please try again.",
                            "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DepositPanel.Enabled = True
                GlobalSettings.HiddenKeyPadVariable = 0
                fkey.ResetTextBox()
                btnDFromChecking.Show()
                btnDFromSavings.Show()
                btnDAnotherTransaction.Hide()
            End If
        Else
            MessageBox.Show("Please enter a positive amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DepositPanel.Enabled = True
            GlobalSettings.HiddenKeyPadVariable = 0
            fkey.ResetTextBox()
            btnDFromChecking.Show()
            btnDFromSavings.Show()
            btnDAnotherTransaction.Hide()
        End If
    End Sub

    Private Sub btnDFinished_Click(sender As Object, e As EventArgs) Handles btnDFinished.Click
        DepositPanel.Enabled = True
        GlobalSettings.HiddenKeyPadVariable = 0
        fkey.ResetTextBox()
        btnDFromChecking.Show()
        btnDFromSavings.Show()
        btnDAnotherTransaction.Hide()
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnDFromSavings_Click(sender As Object, e As EventArgs) Handles btnDFromSavings.Click

        If (GlobalSettings.HiddenKeyPadVariable > 0) Then
            If (ValidateAmount.IsPositiveDouble(GlobalSettings.HiddenKeyPadVariable)) Then
                GlobalSettings.CurrentSavings.MakeDeposit(GlobalSettings.HiddenKeyPadVariable)
                MessageBox.Show("You have successfully deposited $" & GlobalSettings.HiddenKeyPadVariable.ToString("#,###,###.##") & " to your Savings Account.", "Deposit Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnDFromSavings.Hide()
                btnDFromChecking.Hide()
                DepositPanel.Enabled = False
                btnDAnotherTransaction.Show()
            Else
                MessageBox.Show("Your Deposit was unsuccessful due to insufficient funds. Please try again.",
                            "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DepositPanel.Enabled = True
                GlobalSettings.HiddenKeyPadVariable = 0
                fkey.ResetTextBox()
                btnDFromChecking.Show()
                btnDFromSavings.Show()
                btnDAnotherTransaction.Hide()
            End If
        Else
            MessageBox.Show("Please enter a positive amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DepositPanel.Enabled = True
            GlobalSettings.HiddenKeyPadVariable = 0
            fkey.ResetTextBox()
            btnDFromChecking.Show()
            btnDFromSavings.Show()
            btnDAnotherTransaction.Hide()
        End If
    End Sub

    Private Sub btnDAnotherTransaction_Click(sender As Object, e As EventArgs) Handles btnDAnotherTransaction.Click

        DepositPanel.Enabled = True
        GlobalSettings.HiddenKeyPadVariable = 0
        fkey.ResetTextBox()
        btnDFromChecking.Show()
        btnDFromSavings.Show()
        btnDAnotherTransaction.Hide()
    End Sub
End Class