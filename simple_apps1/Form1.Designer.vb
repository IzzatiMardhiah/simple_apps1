<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTimes = New System.Windows.Forms.ComboBox()
        Me.cmdWake = New System.Windows.Forms.Button()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many do i have to tell" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you to wakeup?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboTimes
        '
        Me.cboTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTimes.FormattingEnabled = True
        Me.cboTimes.Items.AddRange(New Object() {"1,", "2,", "3,", "4,", "5,", "6,", "7"})
        Me.cboTimes.Location = New System.Drawing.Point(191, 92)
        Me.cboTimes.Name = "cboTimes"
        Me.cboTimes.Size = New System.Drawing.Size(46, 23)
        Me.cboTimes.TabIndex = 1
        '
        'cmdWake
        '
        Me.cmdWake.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdWake.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdWake.Location = New System.Drawing.Point(187, 188)
        Me.cmdWake.Name = "cmdWake"
        Me.cmdWake.Size = New System.Drawing.Size(96, 23)
        Me.cmdWake.TabIndex = 3
        Me.cmdWake.Text = "Wake me up!"
        Me.cmdWake.UseVisualStyleBackColor = False
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 15
        Me.lstOut.Location = New System.Drawing.Point(12, 154)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(149, 94)
        Me.lstOut.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 279)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.cmdWake)
        Me.Controls.Add(Me.cboTimes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboTimes As ComboBox
    Friend WithEvents cmdWake As Button
    Friend WithEvents lstOut As ListBox
End Class
