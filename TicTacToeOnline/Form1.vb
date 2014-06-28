Public Class frmMain

    Private mobjPen As New System.Drawing.Pen(Brushes.Black, 3)
    Private mobjGraphic As System.Drawing.Graphics
    Private mintPlayer As enumTurn
    Private mstrPlayer As String

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
    End Sub

    Private Sub cmdNewGame_Click(sender As Object, e As EventArgs) Handles cmdNewGame.Click
        mintPlayer = enumTurn.TurnO
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Playerturn()
            Button7.Text = mstrPlayer
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Playerturn()
            Button8.Text = mstrPlayer
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Playerturn()
            Button9.Text = mstrPlayer
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Playerturn()
            Button6.Text = mstrPlayer
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Playerturn()
            Button5.Text = mstrPlayer
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Playerturn()
            Button3.Text = mstrPlayer
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Playerturn()
            Button1.Text = mstrPlayer
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Playerturn()
            Button2.Text = mstrPlayer
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Playerturn()
            Button4.Text = mstrPlayer
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class
