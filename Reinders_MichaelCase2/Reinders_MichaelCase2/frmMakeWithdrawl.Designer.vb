<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakeWithdrawl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnWFromChecking = New System.Windows.Forms.Button()
        Me.btnWFromSavings = New System.Windows.Forms.Button()
        Me.btnWAnotherTransaction = New System.Windows.Forms.Button()
        Me.btnWFinished = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.withdrawlPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'btnWFromChecking
        '
        Me.btnWFromChecking.Location = New System.Drawing.Point(222, 63)
        Me.btnWFromChecking.Name = "btnWFromChecking"
        Me.btnWFromChecking.Size = New System.Drawing.Size(134, 52)
        Me.btnWFromChecking.TabIndex = 29
        Me.btnWFromChecking.Text = "From Checking"
        Me.btnWFromChecking.UseVisualStyleBackColor = True
        '
        'btnWFromSavings
        '
        Me.btnWFromSavings.Location = New System.Drawing.Point(222, 121)
        Me.btnWFromSavings.Name = "btnWFromSavings"
        Me.btnWFromSavings.Size = New System.Drawing.Size(134, 52)
        Me.btnWFromSavings.TabIndex = 30
        Me.btnWFromSavings.Text = "From Savings"
        Me.btnWFromSavings.UseVisualStyleBackColor = True
        '
        'btnWAnotherTransaction
        '
        Me.btnWAnotherTransaction.Location = New System.Drawing.Point(222, 179)
        Me.btnWAnotherTransaction.Name = "btnWAnotherTransaction"
        Me.btnWAnotherTransaction.Size = New System.Drawing.Size(134, 52)
        Me.btnWAnotherTransaction.TabIndex = 31
        Me.btnWAnotherTransaction.Text = "Another Transaction"
        Me.btnWAnotherTransaction.UseVisualStyleBackColor = True
        '
        'btnWFinished
        '
        Me.btnWFinished.Location = New System.Drawing.Point(222, 269)
        Me.btnWFinished.Name = "btnWFinished"
        Me.btnWFinished.Size = New System.Drawing.Size(134, 52)
        Me.btnWFinished.TabIndex = 32
        Me.btnWFinished.Text = "Back to Menu"
        Me.btnWFinished.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 51)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Please enter the amount below and press Ok. Then specify which account to withdra" &
    "wl from by clicking ""from checking"" or ""from savings."""
        '
        'withdrawlPanel
        '
        Me.withdrawlPanel.Location = New System.Drawing.Point(3, 63)
        Me.withdrawlPanel.Name = "withdrawlPanel"
        Me.withdrawlPanel.Size = New System.Drawing.Size(213, 258)
        Me.withdrawlPanel.TabIndex = 33
        '
        'frmMakeWithdrawl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 329)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.withdrawlPanel)
        Me.Controls.Add(Me.btnWFinished)
        Me.Controls.Add(Me.btnWAnotherTransaction)
        Me.Controls.Add(Me.btnWFromSavings)
        Me.Controls.Add(Me.btnWFromChecking)
        Me.Name = "frmMakeWithdrawl"
        Me.Text = "frmMakeWithdrawl"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnWFromChecking As Button
    Friend WithEvents btnWFromSavings As Button
    Friend WithEvents btnWAnotherTransaction As Button
    Friend WithEvents btnWFinished As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents withdrawlPanel As FlowLayoutPanel
End Class
