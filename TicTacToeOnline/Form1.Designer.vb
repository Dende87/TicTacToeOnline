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
    Me.cmdA3 = New System.Windows.Forms.Button()
    Me.cmdA2 = New System.Windows.Forms.Button()
    Me.cmdA1 = New System.Windows.Forms.Button()
    Me.cmdB3 = New System.Windows.Forms.Button()
    Me.cmdB2 = New System.Windows.Forms.Button()
    Me.cmdB1 = New System.Windows.Forms.Button()
    Me.cmdC3 = New System.Windows.Forms.Button()
    Me.cmdC2 = New System.Windows.Forms.Button()
    Me.cmdC1 = New System.Windows.Forms.Button()
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
    Me.lblWinner = New System.Windows.Forms.Label()
    Me.cmdOpenChat = New System.Windows.Forms.Button()
    Me.pnlGameField.SuspendLayout()
    Me.SuspendLayout()
    '
    'cmdNewGame
    '
    Me.cmdNewGame.Location = New System.Drawing.Point(355, 45)
    Me.cmdNewGame.Name = "cmdNewGame"
    Me.cmdNewGame.Size = New System.Drawing.Size(75, 23)
    Me.cmdNewGame.TabIndex = 0
    Me.cmdNewGame.Text = "Neues Spiel"
    Me.cmdNewGame.UseVisualStyleBackColor = True
    '
    'pnlGameField
    '
    Me.pnlGameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnlGameField.Controls.Add(Me.cmdA3)
    Me.pnlGameField.Controls.Add(Me.cmdA2)
    Me.pnlGameField.Controls.Add(Me.cmdA1)
    Me.pnlGameField.Controls.Add(Me.cmdB3)
    Me.pnlGameField.Controls.Add(Me.cmdB2)
    Me.pnlGameField.Controls.Add(Me.cmdB1)
    Me.pnlGameField.Controls.Add(Me.cmdC3)
    Me.pnlGameField.Controls.Add(Me.cmdC2)
    Me.pnlGameField.Controls.Add(Me.cmdC1)
    Me.pnlGameField.Controls.Add(Me.UctlLine2)
    Me.pnlGameField.Controls.Add(Me.UctlLine4)
    Me.pnlGameField.Controls.Add(Me.UctlLine3)
    Me.pnlGameField.Controls.Add(Me.UctlLine1)
    Me.pnlGameField.Location = New System.Drawing.Point(46, 45)
    Me.pnlGameField.Name = "pnlGameField"
    Me.pnlGameField.Size = New System.Drawing.Size(300, 300)
    Me.pnlGameField.TabIndex = 1
    '
    'cmdA3
    '
    Me.cmdA3.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdA3.Location = New System.Drawing.Point(3, 209)
    Me.cmdA3.Name = "cmdA3"
    Me.cmdA3.Size = New System.Drawing.Size(79, 86)
    Me.cmdA3.TabIndex = 1
    Me.cmdA3.UseVisualStyleBackColor = True
    '
    'cmdA2
    '
    Me.cmdA2.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdA2.Location = New System.Drawing.Point(3, 102)
    Me.cmdA2.Name = "cmdA2"
    Me.cmdA2.Size = New System.Drawing.Size(79, 90)
    Me.cmdA2.TabIndex = 1
    Me.cmdA2.UseVisualStyleBackColor = True
    '
    'cmdA1
    '
    Me.cmdA1.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdA1.Location = New System.Drawing.Point(3, 3)
    Me.cmdA1.Name = "cmdA1"
    Me.cmdA1.Size = New System.Drawing.Size(79, 82)
    Me.cmdA1.TabIndex = 1
    Me.cmdA1.UseVisualStyleBackColor = True
    '
    'cmdB3
    '
    Me.cmdB3.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdB3.Location = New System.Drawing.Point(99, 209)
    Me.cmdB3.Name = "cmdB3"
    Me.cmdB3.Size = New System.Drawing.Size(93, 86)
    Me.cmdB3.TabIndex = 1
    Me.cmdB3.UseVisualStyleBackColor = True
    '
    'cmdB2
    '
    Me.cmdB2.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdB2.Location = New System.Drawing.Point(99, 102)
    Me.cmdB2.Name = "cmdB2"
    Me.cmdB2.Size = New System.Drawing.Size(93, 90)
    Me.cmdB2.TabIndex = 1
    Me.cmdB2.UseVisualStyleBackColor = True
    '
    'cmdB1
    '
    Me.cmdB1.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdB1.Location = New System.Drawing.Point(99, 3)
    Me.cmdB1.Name = "cmdB1"
    Me.cmdB1.Size = New System.Drawing.Size(93, 82)
    Me.cmdB1.TabIndex = 1
    Me.cmdB1.UseVisualStyleBackColor = True
    '
    'cmdC3
    '
    Me.cmdC3.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdC3.Location = New System.Drawing.Point(209, 209)
    Me.cmdC3.Name = "cmdC3"
    Me.cmdC3.Size = New System.Drawing.Size(86, 86)
    Me.cmdC3.TabIndex = 1
    Me.cmdC3.UseVisualStyleBackColor = True
    '
    'cmdC2
    '
    Me.cmdC2.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdC2.Location = New System.Drawing.Point(209, 102)
    Me.cmdC2.Name = "cmdC2"
    Me.cmdC2.Size = New System.Drawing.Size(86, 90)
    Me.cmdC2.TabIndex = 1
    Me.cmdC2.UseVisualStyleBackColor = True
    '
    'cmdC1
    '
    Me.cmdC1.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdC1.Location = New System.Drawing.Point(209, 3)
    Me.cmdC1.Name = "cmdC1"
    Me.cmdC1.Size = New System.Drawing.Size(86, 82)
    Me.cmdC1.TabIndex = 1
    Me.cmdC1.UseVisualStyleBackColor = True
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
    Me.lblTurn.Location = New System.Drawing.Point(352, 92)
    Me.lblTurn.Name = "lblTurn"
    Me.lblTurn.Size = New System.Drawing.Size(0, 13)
    Me.lblTurn.TabIndex = 2
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
    'lblWinner
    '
    Me.lblWinner.AutoSize = True
    Me.lblWinner.Location = New System.Drawing.Point(352, 118)
    Me.lblWinner.Name = "lblWinner"
    Me.lblWinner.Size = New System.Drawing.Size(0, 13)
    Me.lblWinner.TabIndex = 3
    '
    'cmdOpenChat
    '
    Me.cmdOpenChat.Location = New System.Drawing.Point(355, 322)
    Me.cmdOpenChat.Name = "cmdOpenChat"
    Me.cmdOpenChat.Size = New System.Drawing.Size(75, 23)
    Me.cmdOpenChat.TabIndex = 4
    Me.cmdOpenChat.Text = "Open Chat"
    Me.cmdOpenChat.UseVisualStyleBackColor = True
    '
    'frmMain
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(445, 396)
    Me.Controls.Add(Me.cmdOpenChat)
    Me.Controls.Add(Me.lblWinner)
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
    Friend WithEvents cmdA3 As System.Windows.Forms.Button
    Friend WithEvents cmdA2 As System.Windows.Forms.Button
    Friend WithEvents cmdA1 As System.Windows.Forms.Button
    Friend WithEvents cmdB3 As System.Windows.Forms.Button
    Friend WithEvents cmdB2 As System.Windows.Forms.Button
    Friend WithEvents cmdB1 As System.Windows.Forms.Button
    Friend WithEvents cmdC3 As System.Windows.Forms.Button
    Friend WithEvents cmdC1 As System.Windows.Forms.Button
    Friend WithEvents cmdC2 As System.Windows.Forms.Button
    Friend WithEvents lblTurn As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents lblWinner As System.Windows.Forms.Label
  Friend WithEvents cmdOpenChat As System.Windows.Forms.Button

End Class
