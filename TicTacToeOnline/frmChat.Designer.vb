<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.cmdClose = New System.Windows.Forms.Button()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.TextBox2 = New System.Windows.Forms.TextBox()
    Me.TextBox3 = New System.Windows.Forms.TextBox()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'cmdClose
    '
    Me.cmdClose.Location = New System.Drawing.Point(429, 425)
    Me.cmdClose.Name = "cmdClose"
    Me.cmdClose.Size = New System.Drawing.Size(75, 23)
    Me.cmdClose.TabIndex = 0
    Me.cmdClose.Text = "Close"
    Me.cmdClose.UseVisualStyleBackColor = True
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(12, 12)
    Me.TextBox1.Multiline = True
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(361, 354)
    Me.TextBox1.TabIndex = 1
    '
    'TextBox2
    '
    Me.TextBox2.Location = New System.Drawing.Point(12, 374)
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(471, 20)
    Me.TextBox2.TabIndex = 2
    '
    'TextBox3
    '
    Me.TextBox3.Location = New System.Drawing.Point(379, 12)
    Me.TextBox3.Name = "TextBox3"
    Me.TextBox3.Size = New System.Drawing.Size(125, 20)
    Me.TextBox3.TabIndex = 3
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(379, 38)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(125, 23)
    Me.Button1.TabIndex = 4
    Me.Button1.Text = "Button1"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(379, 67)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(125, 23)
    Me.Button2.TabIndex = 4
    Me.Button2.Text = "Button1"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'Button3
    '
    Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.Button3.Font = New System.Drawing.Font("Arial", 7.0!)
    Me.Button3.Location = New System.Drawing.Point(485, 374)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(25, 20)
    Me.Button3.TabIndex = 5
    Me.Button3.Text = "S"
    Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
    Me.Button3.UseVisualStyleBackColor = True
    '
    'frmChat
    '
    Me.AcceptButton = Me.cmdClose
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(516, 460)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.TextBox3)
    Me.Controls.Add(Me.TextBox2)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.cmdClose)
    Me.Name = "frmChat"
    Me.Text = "frmChat"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmdClose As System.Windows.Forms.Button
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
