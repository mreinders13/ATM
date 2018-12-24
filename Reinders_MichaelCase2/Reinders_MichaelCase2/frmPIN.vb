Option Strict On
Public Class frmPIN

    Private Sub frmPIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the KeyPad in the deposit panel
        Dim fkey As frmKeyPad
        fkey = New frmKeyPad()
        fkey.TopLevel = False
        fkey.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        fkey.WindowState = FormWindowState.Normal
        fkey.Visible = True
        fkey.btnKeypadBackspace.Visible = True
        fkey.btnKeypadPINEnter.Visible = True
        PINPanel.Controls.Add(fkey)
    End Sub
End Class