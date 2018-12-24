<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMakeDeposit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDFinished = New System.Windows.Forms.Button()
        Me.btnDAnotherTransaction = New System.Windows.Forms.Button()
        Me.btnDFromSavings = New System.Windows.Forms.Button()
        Me.btnDFromChecking = New System.Windows.Forms.Button()
        Me.DepositPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDFinished
        '
        Me.btnDFinished.Location = New System.Drawing.Point(247, 270)
        Me.btnDFinished.Name = "btnDFinished"
        Me.btnDFinished.Size = New System.Drawing.Size(134, 52)
        Me.btnDFinished.TabIndex = 52
        Me.btnDFinished.Text = "Back to Menu"
        Me.btnDFinished.UseVisualStyleBackColor = True
        '
        'btnDAnotherTransaction
        '
        Me.btnDAnotherTransaction.Location = New System.Drawing.Point(247, 180)
        Me.btnDAnotherTransaction.Name = "btnDAnotherTransaction"
        Me.btnDAnotherTransaction.Size = New System.Drawing.Size(134, 52)
        Me.btnDAnotherTransaction.TabIndex = 51
        Me.btnDAnotherTransaction.Text = "Another Transaction"
        Me.btnDAnotherTransaction.UseVisualStyleBackColor = True
        '
        'btnDFromSavings
        '
        Me.btnDFromSavings.Location = New System.Drawing.Point(247, 123)
        Me.btnDFromSavings.Name = "btnDFromSavings"
        Me.btnDFromSavings.Size = New System.Drawing.Size(134, 52)
        Me.btnDFromSavings.TabIndex = 50
        Me.btnDFromSavings.Text = "To Savings"
        Me.btnDFromSavings.UseVisualStyleBackColor = True
        '
        'btnDFromChecking
        '
        Me.btnDFromChecking.Location = New System.Drawing.Point(247, 65)
        Me.btnDFromChecking.Name = "btnDFromChecking"
        Me.btnDFromChecking.Size = New System.Drawing.Size(134, 52)
        Me.btnDFromChecking.TabIndex = 49
        Me.btnDFromChecking.Text = "To Checking"
        Me.btnDFromChecking.UseVisualStyleBackColor = True
        '
        'DepositPanel
        '
        Me.DepositPanel.Location = New System.Drawing.Point(12, 65)
        Me.DepositPanel.Name = "DepositPanel"
        Me.DepositPanel.Size = New System.Drawing.Size(212, 254)
        Me.DepositPanel.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 53)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Please enter the amount below and press Ok. Then specify which account to withdra" &
    "wl from by clicking ""from checking"" or ""from savings."""
        '
        'frmMakeDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 328)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DepositPanel)
        Me.Controls.Add(Me.btnDFinished)
        Me.Controls.Add(Me.btnDAnotherTransaction)
        Me.Controls.Add(Me.btnDFromSavings)
        Me.Controls.Add(Me.btnDFromChecking)
        Me.Name = "frmMakeDeposit"
        Me.Text = "frmMakeDeposit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDFinished As Button
    Friend WithEvents btnDAnotherTransaction As Button
    Friend WithEvents btnDFromSavings As Button
    Friend WithEvents btnDFromChecking As Button
    Friend WithEvents DepositPanel As Panel
    Friend WithEvents Label1 As Label
End Class
