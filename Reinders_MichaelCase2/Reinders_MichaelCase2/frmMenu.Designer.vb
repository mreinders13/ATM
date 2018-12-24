<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnMakeWithdrawl = New System.Windows.Forms.Button()
        Me.btnMakeDeposit = New System.Windows.Forms.Button()
        Me.btnMakeTransfer = New System.Windows.Forms.Button()
        Me.btnViewBalance = New System.Windows.Forms.Button()
        Me.lblWelcomeBack = New System.Windows.Forms.Label()
        Me.btnImFinished = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMakeWithdrawl
        '
        Me.btnMakeWithdrawl.Location = New System.Drawing.Point(178, 45)
        Me.btnMakeWithdrawl.Name = "btnMakeWithdrawl"
        Me.btnMakeWithdrawl.Size = New System.Drawing.Size(139, 50)
        Me.btnMakeWithdrawl.TabIndex = 0
        Me.btnMakeWithdrawl.Text = "Make Withdrawl"
        Me.btnMakeWithdrawl.UseVisualStyleBackColor = True
        '
        'btnMakeDeposit
        '
        Me.btnMakeDeposit.Location = New System.Drawing.Point(178, 101)
        Me.btnMakeDeposit.Name = "btnMakeDeposit"
        Me.btnMakeDeposit.Size = New System.Drawing.Size(139, 50)
        Me.btnMakeDeposit.TabIndex = 1
        Me.btnMakeDeposit.Text = "Make Deposit"
        Me.btnMakeDeposit.UseVisualStyleBackColor = True
        '
        'btnMakeTransfer
        '
        Me.btnMakeTransfer.Location = New System.Drawing.Point(15, 101)
        Me.btnMakeTransfer.Name = "btnMakeTransfer"
        Me.btnMakeTransfer.Size = New System.Drawing.Size(139, 50)
        Me.btnMakeTransfer.TabIndex = 2
        Me.btnMakeTransfer.Text = "Transfer Funds"
        Me.btnMakeTransfer.UseVisualStyleBackColor = True
        '
        'btnViewBalance
        '
        Me.btnViewBalance.Location = New System.Drawing.Point(15, 45)
        Me.btnViewBalance.Name = "btnViewBalance"
        Me.btnViewBalance.Size = New System.Drawing.Size(139, 50)
        Me.btnViewBalance.TabIndex = 4
        Me.btnViewBalance.Text = "View Balance"
        Me.btnViewBalance.UseVisualStyleBackColor = True
        '
        'lblWelcomeBack
        '
        Me.lblWelcomeBack.AutoSize = True
        Me.lblWelcomeBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeBack.Location = New System.Drawing.Point(12, 12)
        Me.lblWelcomeBack.Name = "lblWelcomeBack"
        Me.lblWelcomeBack.Size = New System.Drawing.Size(317, 17)
        Me.lblWelcomeBack.TabIndex = 5
        Me.lblWelcomeBack.Text = "Welcome Back! What woud you like to do today? "
        '
        'btnImFinished
        '
        Me.btnImFinished.Location = New System.Drawing.Point(178, 202)
        Me.btnImFinished.Name = "btnImFinished"
        Me.btnImFinished.Size = New System.Drawing.Size(139, 50)
        Me.btnImFinished.TabIndex = 6
        Me.btnImFinished.Text = "I'm Finished"
        Me.btnImFinished.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 266)
        Me.Controls.Add(Me.btnImFinished)
        Me.Controls.Add(Me.lblWelcomeBack)
        Me.Controls.Add(Me.btnViewBalance)
        Me.Controls.Add(Me.btnMakeTransfer)
        Me.Controls.Add(Me.btnMakeDeposit)
        Me.Controls.Add(Me.btnMakeWithdrawl)
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMakeWithdrawl As Button
    Friend WithEvents btnMakeDeposit As Button
    Friend WithEvents btnMakeTransfer As Button
    Friend WithEvents btnViewBalance As Button
    Friend WithEvents lblWelcomeBack As Label
    Friend WithEvents btnImFinished As Button
End Class
