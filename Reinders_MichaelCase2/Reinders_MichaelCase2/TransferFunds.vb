Public Class frmTransferFunds
    Private fkey As frmKeyPad
    Private Sub btnMakeTransfer_Click(sender As Object, e As EventArgs) Handles btnMakeTransfer.Click
        If (cbTransferTo.SelectedItem = "" Or cbTransferFrom.SelectedItem = "") Then
            MessageBox.Show("Make sure you have selected which accounts to transfer money between. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ResetTransferAccounts()
            fkey.ResetTextBox()
        Else
            If (GlobalSettings.HiddenKeyPadVariable > 0) Then
                '*****Withdrawl from account
                If (cbTransferFrom.SelectedItem = "Checking") Then
                    If (GlobalSettings.HiddenKeyPadVariable <= GlobalSettings.CurrentChecking.HiddenAccountBalance) Then
                        GlobalSettings.CurrentChecking.MakeWithdrawal(GlobalSettings.HiddenKeyPadVariable)
                        MessageBox.Show("You have sucessfully transfered $" & GlobalSettings.HiddenKeyPadVariable.ToString("#,###,###.##") _
                                    & " to your Checking Account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '******disable another transaction
                        cbTransferFrom.Enabled = False
                        cbTransferTo.Enabled = False
                        TransferFundsPanel.Enabled = False
                        btnMakeTransfer.Enabled = False
                        btnTAnotherTransaction.Visible = True
                    Else
                        MessageBox.Show("Your Transfer was unsuccessful due to insufficient funds in your Checking Account. Please try again.",
                        "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ResetTransferAccounts()
                        fkey.ResetTextBox()
                    End If
                ElseIf (cbTransferFrom.SelectedItem = "Savings") Then
                    If (GlobalSettings.HiddenKeyPadVariable <= GlobalSettings.CurrentSavings.HiddenAccountBalance) Then
                        GlobalSettings.CurrentSavings.MakeWithdrawal(GlobalSettings.HiddenKeyPadVariable)
                        MessageBox.Show("You have sucessfully transfered $" & GlobalSettings.HiddenKeyPadVariable.ToString("#,###,###.##") _
                        & " to your Savings Account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '******disable another transaction
                        cbTransferFrom.Enabled = False
                        cbTransferTo.Enabled = False
                        TransferFundsPanel.Enabled = False
                        btnMakeTransfer.Enabled = False
                        btnTAnotherTransaction.Visible = True
                    Else
                        MessageBox.Show("Your Transfer was unsuccessful due to insufficient funds in your Savings Account. Please try again.",
                        "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ResetTransferAccounts()
                        fkey.ResetTextBox()
                    End If
                ElseIf (cbTransferFrom.SelectedItem = "Credit") Then
                    If (GlobalSettings.HiddenKeyPadVariable <= GlobalSettings.CurrentCredit.AvailibleCredit) Then
                        GlobalSettings.CurrentCredit.CreditCharge(GlobalSettings.HiddenKeyPadVariable)
                        MessageBox.Show("You have made a payment of $" & GlobalSettings.HiddenKeyPadVariable.ToString("#,###,###.##") _
                        & " to your Credit Card.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '******disable another transaction
                        cbTransferFrom.Enabled = False
                        cbTransferTo.Enabled = False
                        TransferFundsPanel.Enabled = False
                        btnMakeTransfer.Enabled = False
                        btnTAnotherTransaction.Visible = True
                    Else
                        MessageBox.Show("Your Transfer was unsuccessful due to an insufficient amount of remaining credit in your Credit Card Account. Please try again.",
                        "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ResetTransferAccounts()
                        fkey.ResetTextBox()
                    End If
                End If
                '***********************Deposit to account
                If (cbTransferTo.SelectedItem = "Checking") Then
                    GlobalSettings.CurrentChecking.MakeDeposit(GlobalSettings.HiddenKeyPadVariable)

                ElseIf (cbTransferTo.SelectedItem = "Savings") Then
                    GlobalSettings.CurrentSavings.MakeDeposit(GlobalSettings.HiddenKeyPadVariable)

                ElseIf (cbTransferTo.SelectedItem = "Credit") Then
                    GlobalSettings.CurrentCredit.CreditPayment(GlobalSettings.HiddenKeyPadVariable)

                End If
            Else
                MessageBox.Show("Please enter a positive amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbTransferFrom.Enabled = True
                cbTransferTo.Enabled = True
                TransferFundsPanel.Enabled = True
                btnMakeTransfer.Enabled = True
                btnTAnotherTransaction.Visible = False
                fkey.ResetTextBox()
                ResetTransferAccounts()
            End If
        End If
    End Sub

    Private Sub btnTAnotherTransaction_Click(sender As Object, e As EventArgs) Handles btnTAnotherTransaction.Click
        cbTransferFrom.Enabled = True
        cbTransferFrom.SelectedItem = ""
        cbTransferTo.Enabled = True
        cbTransferTo.SelectedItem = ""
        TransferFundsPanel.Enabled = True
        btnMakeTransfer.Enabled = True
        btnTAnotherTransaction.Visible = False
        fkey.ResetTextBox()
        ResetTransferAccounts()
    End Sub

    Private Sub btnTFinished_Click(sender As Object, e As EventArgs) Handles btnTFinished.Click
        '******disable another transaction
        cbTransferFrom.Enabled = True
        cbTransferTo.Enabled = True
        TransferFundsPanel.Enabled = True
        btnMakeTransfer.Enabled = True
        btnTAnotherTransaction.Visible = False
        fkey.ResetTextBox()
        ResetTransferAccounts()
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub frmTransferFunds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnTAnotherTransaction.Visible = False
        'Load the KeyPad in the Transfer Funds panel
        fkey = New frmKeyPad()
        fkey.TopLevel = False
        fkey.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        fkey.WindowState = FormWindowState.Normal
        fkey.Visible = True
        TransferFundsPanel.Controls.Add(fkey)
    End Sub
    Public Sub ResetTransferAccounts()
        cbTransferFrom.SelectedItem = ""
        cbTransferTo.SelectedItem = ""
    End Sub

End Class