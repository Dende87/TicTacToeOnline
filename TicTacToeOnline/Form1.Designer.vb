<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmdNewGame = New System.Windows.Forms.Button()
        Me.pnlGameField = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UctlLine2 = New TicTacToeOnline.uctlLine()
        Me.UctlLine4 = New TicTacToeOnline.uctlLine()
        Me.UctlLine3 = New TicTacToeOnline.uctlLine()
        Me.UctlLine1 = New TicTacToeOnline.uctlLine()
        Me.lblTurn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlGameField.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdNewGame
        '
        Me.cmdNewGame.Location = New System.Drawing.Point(442, 12)
        Me.cmdNewGame.Name = "cmdNewGame"
        Me.cmdNewGame.Size = New System.Drawing.Size(75, 23)
        Me.cmdNewGame.TabIndex = 0
        Me.cmdNewGame.Text = "Neues Spiel"
        Me.cmdNewGame.UseVisualStyleBackColor = True
        '
        'pnlGameField
        '
        Me.pnlGameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGameField.Controls.Add(Me.Button9)
        Me.pnlGameField.Controls.Add(Me.Button6)
        Me.pnlGameField.Controls.Add(Me.Button3)
        Me.pnlGameField.Controls.Add(Me.Button8)
        Me.pnlGameField.Controls.Add(Me.Button5)
        Me.pnlGameField.Controls.Add(Me.Button2)
        Me.pnlGameField.Controls.Add(Me.Button7)
        Me.pnlGameField.Controls.Add(Me.Button4)
        Me.pnlGameField.Controls.Add(Me.Button1)
        Me.pnlGameField.Controls.Add(Me.UctlLine2)
        Me.pnlGameField.Controls.Add(Me.UctlLine4)
        Me.pnlGameField.Controls.Add(Me.UctlLine3)
        Me.pnlGameField.Controls.Add(Me.UctlLine1)
        Me.pnlGameField.Location = New System.Drawing.Point(46, 45)
        Me.pnlGameField.Name = "pnlGameField"
        Me.pnlGameField.Size = New System.Drawing.Size(300, 300)
        Me.pnlGameField.TabIndex = 1
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(3, 209)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(79, 86)
        Me.Button9.TabIndex = 1
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(3, 102)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(79, 90)
        Me.Button6.TabIndex = 1
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 82)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(99, 209)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(93, 86)
        Me.Button8.TabIndex = 1
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(99, 102)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 90)
        Me.Button5.TabIndex = 1
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(99, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 82)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(209, 209)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(86, 86)
        Me.Button7.TabIndex = 1
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(209, 102)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 90)
        Me.Button4.TabIndex = 1
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(209, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 82)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UctlLine2
        '
        Me.UctlLine2.Location = New System.Drawing.Point(-1, 198)
        Me.UctlLine2.Name = "UctlLine2"
        Me.UctlLine2.Size = New System.Drawing.Size(300, 5)
        Me.UctlLine2.TabIndex = 0
        '
        'UctlLine4
        '
        Me.UctlLine4.Location = New System.Drawing.Point(198, -1)
        Me.UctlLine4.Name = "UctlLine4"
        Me.UctlLine4.Size = New System.Drawing.Size(5, 300)
        Me.UctlLine4.TabIndex = 0
        '
        'UctlLine3
        '
        Me.UctlLine3.Location = New System.Drawing.Point(88, -1)
        Me.UctlLine3.Name = "UctlLine3"
        Me.UctlLine3.Size = New System.Drawing.Size(5, 300)
        Me.UctlLine3.TabIndex = 0
        '
        'UctlLine1
        '
        Me.UctlLine1.Location = New System.Drawing.Point(-1, 91)
        Me.UctlLine1.Name = "UctlLine1"
        Me.UctlLine1.Size = New System.Drawing.Size(300, 5)
        Me.UctlLine1.TabIndex = 0
        '
        'lblTurn
        '
        Me.lblTurn.AutoSize = True
        Me.lblTurn.Location = New System.Drawing.Point(380, 111)
        Me.lblTurn.Name = "lblTurn"
        Me.lblTurn.Size = New System.Drawing.Size(57, 13)
        Me.lblTurn.TabIndex = 2
        Me.lblTurn.Text = "O fängt an"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "3"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 429)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTurn)
        Me.Controls.Add(Me.pnlGameField)
        Me.Controls.Add(Me.cmdNewGame)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic Tac Toe - Online"
        Me.pnlGameField.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdNewGame As System.Windows.Forms.Button
    Friend WithEvents pnlGameField As System.Windows.Forms.Panel
    Friend WithEvents UctlLine1 As TicTacToeOnline.uctlLine
    Friend WithEvents UctlLine2 As TicTacToeOnline.uctlLine
    Friend WithEvents UctlLine4 As TicTacToeOnline.uctlLine
    Friend WithEvents UctlLine3 As TicTacToeOnline.uctlLine
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblTurn As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
