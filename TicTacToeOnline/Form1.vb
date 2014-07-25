Public Class frmMain

    Private mintPlayer As enumTurn
    Private mstrPlayer As String

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

    End Sub

    Private Sub cmdNewGame_Click(sender As Object, e As EventArgs) Handles cmdNewGame.Click
        mintPlayer = enumTurn.TurnO
        lblTurn.Text = "O ist dran"

        lblWinner.Text = ""

        cmdC1.Enabled = True
        cmdC1.Text = ""

        cmdB1.Enabled = True
        cmdB1.Text = ""

        cmdA1.Enabled = True
        cmdA1.Text = ""

        cmdC2.Enabled = True
        cmdC2.Text = ""

        cmdB2.Enabled = True
        cmdB2.Text = ""

        cmdA2.Enabled = True
        cmdA2.Text = ""

        cmdC3.Enabled = True
        cmdC3.Text = ""

        cmdB3.Enabled = True
        cmdB3.Text = ""

        cmdA3.Enabled = True
        cmdA3.Text = ""
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles cmdC3.Click
        Try
            Playerturn()
            cmdC3.Text = mstrPlayer
            cmdC3.Enabled = False

            CheckWin()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles cmdB3.Click
        Try
            Playerturn()
            cmdB3.Text = mstrPlayer
            cmdB3.Enabled = False

            CheckWin()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles cmdA3.Click
        Try
            Playerturn()
            cmdA3.Text = mstrPlayer
            cmdA3.Enabled = False
            CheckWin()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles cmdA2.Click
        Try
            Playerturn()
            cmdA2.Text = mstrPlayer
            cmdA2.Enabled = False
            CheckWin()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles cmdB2.Click
        Try
            Playerturn()
            cmdB2.Text = mstrPlayer
            cmdB2.Enabled = False
            CheckWin()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdA1.Click
        Try
            Playerturn()
            cmdA1.Text = mstrPlayer
            cmdA1.Enabled = False
            CheckWin()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdC1.Click
        Try
            Playerturn()
            cmdC1.Text = mstrPlayer
            cmdC1.Enabled = False
            CheckWin()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdB1.Click
        Try
            Playerturn()
            cmdB1.Text = mstrPlayer
            cmdB1.Enabled = False
            CheckWin()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdC2.Click
        Try
            Playerturn()
            cmdC2.Text = mstrPlayer
            cmdC2.Enabled = False
            CheckWin()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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
