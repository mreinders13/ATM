<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransferFunds
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
        Me.cbTransferFrom = New System.Windows.Forms.ComboBox()
        Me.cbTransferTo = New System.Windows.Forms.ComboBox()
        Me.TransferFundsPanel = New System.Windows.Forms.Panel()
        Me.lblTransferFrom = New System.Windows.Forms.Label()
        Me.lblTransferTo = New System.Windows.Forms.Label()
        Me.btnMakeTransfer = New System.Windows.Forms.Button()
        Me.btnTAnotherTransaction = New System.Windows.Forms.Button()
        Me.btnTFinished = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbTransferFrom
        '
        Me.cbTransferFrom.FormattingEnabled = True
        Me.cbTransferFrom.Items.AddRange(New Object() {"", "Checking", "Savings", "Credit"})
        Me.cbTransferFrom.Location = New System.Drawing.Point(329, 12)
        Me.cbTransferFrom.Name = "cbTransferFrom"
        Me.cbTransferFrom.Size = New System.Drawing.Size(103, 21)
        Me.cbTransferFrom.TabIndex = 0
        '
        'cbTransferTo
        '
        Me.cbTransferTo.FormattingEnabled = True
        Me.cbTransferTo.Items.AddRange(New Object() {"", "Checking", "Savings", "Credit"})
        Me.cbTransferTo.Location = New System.Drawing.Point(329, 39)
        Me.cbTransferTo.Name = "cbTransferTo"
        Me.cbTransferTo.Size = New System.Drawing.Size(103, 21)
        Me.cbTransferTo.TabIndex = 1
        '
        'TransferFundsPanel
        '
        Me.TransferFundsPanel.Location = New System.Drawing.Point(12, 12)
        Me.TransferFundsPanel.Name = "TransferFundsPanel"
        Me.TransferFundsPanel.Size = New System.Drawing.Size(200, 256)
        Me.TransferFundsPanel.TabIndex = 2
        '
        'lblTransferFrom
        '
        Me.lblTransferFrom.Location = New System.Drawing.Point(218, 12)
        Me.lblTransferFrom.Name = "lblTransferFrom"
        Me.lblTransferFrom.Size = New System.Drawing.Size(105, 21)
        Me.lblTransferFrom.TabIndex = 3
        Me.lblTransferFrom.Text = "Transfer Funds from:"
        Me.lblTransferFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTransferTo
        '
        Me.lblTransferTo.Location = New System.Drawing.Point(218, 39)
        Me.lblTransferTo.Name = "lblTransferTo"
        Me.lblTransferTo.Size = New System.Drawing.Size(105, 21)
        Me.lblTransferTo.TabIndex = 4
        Me.lblTransferTo.Text = "Transfer Funds to:"
        Me.lblTransferTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMakeTransfer
        '
        Me.btnMakeTransfer.Location = New System.Drawing.Point(329, 67)
        Me.btnMakeTransfer.Name = "btnMakeTransfer"
        Me.btnMakeTransfer.Size = New System.Drawing.Size(103, 23)
        Me.btnMakeTransfer.TabIndex = 5
        Me.btnMakeTransfer.Text = "Make Transfer"
        Me.btnMakeTransfer.UseVisualStyleBackColor = True
        '
        'btnTAnotherTransaction
        '
        Me.btnTAnotherTransaction.Location = New System.Drawing.Point(298, 131)
        Me.btnTAnotherTransaction.Name = "btnTAnotherTransaction"
        Me.btnTAnotherTransaction.Size = New System.Drawing.Size(134, 52)
        Me.btnTAnotherTransaction.TabIndex = 32
        Me.btnTAnotherTransaction.Text = "Another Transaction"
        Me.btnTAnotherTransaction.UseVisualStyleBackColor = True
        '
        'btnTFinished
        '
        Me.btnTFinished.Location = New System.Drawing.Point(298, 216)
        Me.btnTFinished.Name = "btnTFinished"
        Me.btnTFinished.Size = New System.Drawing.Size(134, 52)
        Me.btnTFinished.TabIndex = 33
        Me.btnTFinished.Text = "Back to Menu"
        Me.btnTFinished.UseVisualStyleBackColor = True
        '
        'frmTransferFunds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 280)
        Me.Controls.Add(Me.btnTFinished)
        Me.Controls.Add(Me.btnTAnotherTransaction)
        Me.Controls.Add(Me.btnMakeTransfer)
        Me.Controls.Add(Me.lblTransferTo)
        Me.Controls.Add(Me.lblTransferFrom)
        Me.Controls.Add(Me.TransferFundsPanel)
        Me.Controls.Add(Me.cbTransferTo)
        Me.Controls.Add(Me.cbTransferFrom)
        Me.Name = "frmTransferFunds"
        Me.Text = "TransferFunds"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbTransferFrom As ComboBox
    Friend WithEvents cbTransferTo As ComboBox
    Friend WithEvents TransferFundsPanel As Panel
    Friend WithEvents lblTransferFrom As Label
    Friend WithEvents lblTransferTo As Label
    Friend WithEvents btnMakeTransfer As Button
    Friend WithEvents btnTAnotherTransaction As Button
    Friend WithEvents btnTFinished As Button
End Class
