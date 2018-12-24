<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewBalance
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
        Me.lblBalanceChecking = New System.Windows.Forms.Label()
        Me.lblBalanceCredit = New System.Windows.Forms.Label()
        Me.lblBalanceSavings = New System.Windows.Forms.Label()
        Me.lblBalanceCheckingTotal = New System.Windows.Forms.Label()
        Me.lblBalanceSavingsTotal = New System.Windows.Forms.Label()
        Me.lblCreditCardBalance = New System.Windows.Forms.Label()
        Me.lblCreditCardCredit = New System.Windows.Forms.Label()
        Me.btnBalanceBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBalanceChecking
        '
        Me.lblBalanceChecking.AutoSize = True
        Me.lblBalanceChecking.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceChecking.Location = New System.Drawing.Point(13, 13)
        Me.lblBalanceChecking.Name = "lblBalanceChecking"
        Me.lblBalanceChecking.Size = New System.Drawing.Size(125, 17)
        Me.lblBalanceChecking.TabIndex = 0
        Me.lblBalanceChecking.Text = "Checking Account:"
        '
        'lblBalanceCredit
        '
        Me.lblBalanceCredit.AutoSize = True
        Me.lblBalanceCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceCredit.Location = New System.Drawing.Point(13, 146)
        Me.lblBalanceCredit.Name = "lblBalanceCredit"
        Me.lblBalanceCredit.Size = New System.Drawing.Size(104, 17)
        Me.lblBalanceCredit.TabIndex = 1
        Me.lblBalanceCredit.Text = "Credit Account:"
        '
        'lblBalanceSavings
        '
        Me.lblBalanceSavings.AutoSize = True
        Me.lblBalanceSavings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalanceSavings.Location = New System.Drawing.Point(12, 78)
        Me.lblBalanceSavings.Name = "lblBalanceSavings"
        Me.lblBalanceSavings.Size = New System.Drawing.Size(117, 17)
        Me.lblBalanceSavings.TabIndex = 2
        Me.lblBalanceSavings.Text = "Savings Account:"
        '
        'lblBalanceCheckingTotal
        '
        Me.lblBalanceCheckingTotal.Location = New System.Drawing.Point(33, 43)
        Me.lblBalanceCheckingTotal.Name = "lblBalanceCheckingTotal"
        Me.lblBalanceCheckingTotal.Size = New System.Drawing.Size(266, 35)
        Me.lblBalanceCheckingTotal.TabIndex = 3
        Me.lblBalanceCheckingTotal.Text = "Your checking account has a balance of: "
        '
        'lblBalanceSavingsTotal
        '
        Me.lblBalanceSavingsTotal.Location = New System.Drawing.Point(32, 114)
        Me.lblBalanceSavingsTotal.Name = "lblBalanceSavingsTotal"
        Me.lblBalanceSavingsTotal.Size = New System.Drawing.Size(267, 32)
        Me.lblBalanceSavingsTotal.TabIndex = 4
        Me.lblBalanceSavingsTotal.Text = "Your savings account has a balance of: "
        '
        'lblCreditCardBalance
        '
        Me.lblCreditCardBalance.Location = New System.Drawing.Point(34, 179)
        Me.lblCreditCardBalance.Name = "lblCreditCardBalance"
        Me.lblCreditCardBalance.Size = New System.Drawing.Size(265, 40)
        Me.lblCreditCardBalance.TabIndex = 5
        Me.lblCreditCardBalance.Text = "Your credit card account has a balance of: "
        '
        'lblCreditCardCredit
        '
        Me.lblCreditCardCredit.Location = New System.Drawing.Point(33, 219)
        Me.lblCreditCardCredit.Name = "lblCreditCardCredit"
        Me.lblCreditCardCredit.Size = New System.Drawing.Size(266, 40)
        Me.lblCreditCardCredit.TabIndex = 6
        Me.lblCreditCardCredit.Text = "Availible Credit: "
        '
        'btnBalanceBack
        '
        Me.btnBalanceBack.Location = New System.Drawing.Point(12, 262)
        Me.btnBalanceBack.Name = "btnBalanceBack"
        Me.btnBalanceBack.Size = New System.Drawing.Size(134, 52)
        Me.btnBalanceBack.TabIndex = 34
        Me.btnBalanceBack.Text = "Back"
        Me.btnBalanceBack.UseVisualStyleBackColor = True
        '
        'frmViewBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 321)
        Me.Controls.Add(Me.btnBalanceBack)
        Me.Controls.Add(Me.lblCreditCardCredit)
        Me.Controls.Add(Me.lblCreditCardBalance)
        Me.Controls.Add(Me.lblBalanceSavingsTotal)
        Me.Controls.Add(Me.lblBalanceCheckingTotal)
        Me.Controls.Add(Me.lblBalanceSavings)
        Me.Controls.Add(Me.lblBalanceCredit)
        Me.Controls.Add(Me.lblBalanceChecking)
        Me.Name = "frmViewBalance"
        Me.Text = "frmViewBalance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBalanceChecking As Label
    Friend WithEvents lblBalanceCredit As Label
    Friend WithEvents lblBalanceSavings As Label
    Friend WithEvents lblBalanceCheckingTotal As Label
    Friend WithEvents lblBalanceSavingsTotal As Label
    Friend WithEvents lblCreditCardBalance As Label
    Friend WithEvents lblCreditCardCredit As Label
    Friend WithEvents btnBalanceBack As Button
End Class
