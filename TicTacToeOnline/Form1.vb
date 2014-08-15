Public Class frmMain

  Private mintPlayer As enumTurn
  Private mstrPlayer As String
  Private Const mstrEmpty As String = ""

  Public Sub New()

    ' Dieser Aufruf ist für den Designer erforderlich.
    InitializeComponent()

  End Sub

  Private Sub cmdNewGame_Click(sender As Object, e As EventArgs) Handles cmdNewGame.Click
    Try

      mintPlayer = enumTurn.TurnO
      lblTurn.Text = "O ist dran"

      lblWinner.Text = mstrEmpty

      cmdC1.Enabled = True
      cmdC1.Text = mstrEmpty

      cmdB1.Enabled = True
      cmdB1.Text = mstrEmpty

      cmdA1.Enabled = True
      cmdA1.Text = mstrEmpty

      cmdC2.Enabled = True
      cmdC2.Text = mstrEmpty

      cmdB2.Enabled = True
      cmdB2.Text = mstrEmpty

      cmdA2.Enabled = True
      cmdA2.Text = mstrEmpty

      cmdC3.Enabled = True
      cmdC3.Text = mstrEmpty

      cmdB3.Enabled = True
      cmdB3.Text = mstrEmpty

      cmdA3.Enabled = True
      cmdA3.Text = mstrEmpty

    Catch ex As Exception
      MessageBox.Show(ex.ToString)
    End Try
  End Sub

  Private Sub Button_Click(sender As Object, e As EventArgs) Handles cmdA1.Click, cmdA2.Click, cmdA3.Click, cmdB1.Click, cmdB2.Click, cmdB3.Click, cmdC1.Click, cmdC2.Click, cmdC3.Click
    Try
      Playerturn()

      If sender Is cmdA1 Then
        cmdA1.Text = mstrPlayer
        cmdA1.Enabled = False
      ElseIf sender Is cmdA2 Then
        cmdA2.Text = mstrPlayer
        cmdA2.Enabled = False
      ElseIf sender Is cmdA3 Then
        cmdA3.Text = mstrPlayer
        cmdA3.Enabled = False
      ElseIf sender Is cmdB1 Then
        cmdB1.Text = mstrPlayer
        cmdB1.Enabled = False
      ElseIf sender Is cmdB2 Then
        cmdB2.Text = mstrPlayer
        cmdB2.Enabled = False
      ElseIf sender Is cmdB3 Then
        cmdB3.Text = mstrPlayer
        cmdB3.Enabled = False
      ElseIf sender Is cmdC1 Then
        cmdC1.Text = mstrPlayer
        cmdC1.Enabled = False
      ElseIf sender Is cmdC2 Then
        cmdC2.Text = mstrPlayer
        cmdC2.Enabled = False
      ElseIf sender Is cmdC3 Then
        cmdC3.Text = mstrPlayer
        cmdC3.Enabled = False
      End If

      CheckWin()

    Catch ex As Exception
      MessageBox.Show(ex.ToString)
    End Try
  End Sub

  Private Sub Playerturn()

    If mintPlayer = enumTurn.TurnO Then
      mstrPlayer = "O"
      lblTurn.Text = "X ist dran"
      mintPlayer = enumTurn.TurnX
    Else
      mstrPlayer = "X"
      lblTurn.Text = "O ist dran"
      mintPlayer = enumTurn.TurnO
    End If

  End Sub

  Private Sub CheckWin()

    If cmdA1.Text.Equals("X") AndAlso cmdA2.Text.Equals("X") AndAlso cmdA3.Text.Equals("X") Then
      lblWinner.Text = "X hat gewonnen!"
    End If

    If cmdA1.Text.Equals("X") AndAlso cmdB2.Text.Equals("X") AndAlso cmdC3.Text.Equals("X") Then
      lblWinner.Text = "X hat gewonnen!"
    End If

    If cmdA1.Text.Equals("X") AndAlso cmdB1.Text.Equals("X") AndAlso cmdC1.Text.Equals("X") Then
      lblWinner.Text = "X hat gewonnen!"
    End If

    If cmdB1.Text.Equals("X") AndAlso cmdB2.Text.Equals("X") AndAlso cmdB3.Text.Equals("X") Then
      lblWinner.Text = "X hat gewonnen!"
    End If

    If cmdC1.Text.Equals("X") AndAlso cmdC2.Text.Equals("X") AndAlso cmdC3.Text.Equals("X") Then
      lblWinner.Text = "X hat gewonnen!"
    End If

    If cmdA2.Text.Equals("X") AndAlso cmdB2.Text.Equals("X") AndAlso cmdC2.Text.Equals("X") Then
      lblWinner.Text = "X hat gewonnen!"
    End If

    If cmdA3.Text.Equals("X") AndAlso cmdB3.Text.Equals("X") AndAlso cmdC3.Text.Equals("X") Then
      lblWinner.Text = "X hat gewonnen!"
    End If

    If cmdA3.Text.Equals("X") AndAlso cmdB2.Text.Equals("X") AndAlso cmdC1.Text.Equals("X") Then
      lblWinner.Text = "X hat gewonnen!"
    End If

    If cmdA1.Text.Equals("O") AndAlso cmdA2.Text.Equals("O") AndAlso cmdA3.Text.Equals("O") Then
      lblWinner.Text = "O hat gewonnen!"
    End If

    If cmdA1.Text.Equals("O") AndAlso cmdB2.Text.Equals("O") AndAlso cmdC3.Text.Equals("O") Then
      lblWinner.Text = "O hat gewonnen!"
    End If

    If cmdA1.Text.Equals("O") AndAlso cmdB1.Text.Equals("O") AndAlso cmdC1.Text.Equals("O") Then
      lblWinner.Text = "O hat gewonnen!"
    End If

    If cmdB1.Text.Equals("O") AndAlso cmdB2.Text.Equals("O") AndAlso cmdB3.Text.Equals("O") Then
      lblWinner.Text = "O hat gewonnen!"
    End If

    If cmdC1.Text.Equals("O") AndAlso cmdC2.Text.Equals("O") AndAlso cmdC3.Text.Equals("O") Then
      lblWinner.Text = "O hat gewonnen!"
    End If

    If cmdA2.Text.Equals("O") AndAlso cmdB2.Text.Equals("O") AndAlso cmdC2.Text.Equals("O") Then
      lblWinner.Text = "O hat gewonnen!"
    End If

    If cmdA3.Text.Equals("O") AndAlso cmdB3.Text.Equals("O") AndAlso cmdC3.Text.Equals("O") Then
      lblWinner.Text = "O hat gewonnen!"
    End If

    If cmdA3.Text.Equals("O") AndAlso cmdB2.Text.Equals("O") AndAlso cmdC1.Text.Equals("O") Then
      lblWinner.Text = "O hat gewonnen!"
    End If

  End Sub

End Class
