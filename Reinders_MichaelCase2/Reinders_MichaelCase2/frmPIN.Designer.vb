<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPIN
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
        Me.PINPanel = New System.Windows.Forms.Panel()
        Me.lblPINInstruction = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PINPanel
        '
        Me.PINPanel.Location = New System.Drawing.Point(13, 51)
        Me.PINPanel.Name = "PINPanel"
        Me.PINPanel.Size = New System.Drawing.Size(208, 319)
        Me.PINPanel.TabIndex = 0
        '
        'lblPINInstruction
        '
        Me.lblPINInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPINInstruction.Location = New System.Drawing.Point(25, 9)
        Me.lblPINInstruction.Name = "lblPINInstruction"
        Me.lblPINInstruction.Size = New System.Drawing.Size(184, 39)
        Me.lblPINInstruction.TabIndex = 0
        Me.lblPINInstruction.Text = "Please Enter your PIN number and press Enter"
        '
        'frmPIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 382)
        Me.Controls.Add(Me.lblPINInstruction)
        Me.Controls.Add(Me.PINPanel)
        Me.Name = "frmPIN"
        Me.Text = "PIN"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PINPanel As Panel
    Friend WithEvents lblPINInstruction As Label
End Class
