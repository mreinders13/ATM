Option Strict On
Public Class frmKeyPad
    Private Sub btnKeypad1_Click(sender As Object, e As EventArgs) Handles btnKeypad1.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + "1")
    End Sub

    Private Sub btnKeypad2_Click(sender As Object, e As EventArgs) Handles btnKeypad2.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + "2")
    End Sub

    Private Sub btnKeypad3_Click(sender As Object, e As EventArgs) Handles btnKeypad3.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + "3")
    End Sub

    Private Sub btnKeypad4_Click(sender As Object, e As EventArgs) Handles btnKeypad4.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + "4")
    End Sub

    Private Sub btnKeypad5_Click(sender As Object, e As EventArgs) Handles btnKeypad5.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + "5")
    End Sub

    Private Sub btnKeypad6_Click(sender As Object, e As EventArgs) Handles btnKeypad6.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + "6")
    End Sub

    Private Sub btnKeypad7_Click(sender As Object, e As EventArgs) Handles btnKeypad7.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + "7")
    End Sub

    Private Sub btnKeypad8_Click(sender As Object, e As EventArgs) Handles btnKeypad8.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + "8")
    End Sub

    Private Sub btnKeypad9_Click(sender As Object, e As EventArgs) Handles btnKeypad9.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + "9")
    End Sub

    Private Sub btnKeypad0_Click(sender As Object, e As EventArgs) Handles btnKeypad0.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + "0")
    End Sub

    Private Sub btnKeypadClear_Click(sender As Object, e As EventArgs) Handles btnKeypadClear.Click
        txtKeypadResult.Text = ""
    End Sub

    Private Sub btnKeypadBackspace_Click(sender As Object, e As EventArgs) Handles btnKeypadBackspace.Click
        txtKeypadResult.Text = (txtKeypadResult.Text + ".")
    End Sub
    Private Sub btnKeypadPINEnter_Click(sender As Object, e As EventArgs) Handles btnKeypadPINEnter.Click
        GlobalSettings.CurrentChecking = New CheckingAccount(123, 1000)
        GlobalSettings.CurrentSavings = New SavingsAccount(234, 1000)
        GlobalSettings.CurrentCredit = New CreditCard(345, 1000)
        GlobalSettings.HiddenKeyPadVariable = 0
        Me.Hide()
        frmPIN.Hide()
        Dim frm As New frmMenu
        frm.Show()
    End Sub


    Private Sub txtKeypadResult_TextChanged(sender As Object, e As EventArgs) Handles txtKeypadResult.TextChanged
        If (txtKeypadResult.Text = "") Then
            GlobalSettings.HiddenKeyPadVariable = 0
        Else
            GlobalSettings.HiddenKeyPadVariable = System.Convert.ToDouble(txtKeypadResult.Text)
        End If
    End Sub

    Public Sub ResetTextBox()
        txtKeypadResult.Text = ""
    End Sub
End Class
