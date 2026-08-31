Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnhps.Click
        txtnama.Clear()
        txtkom.Clear()
        txtnim.Clear()
    End Sub

    Private Sub btntamp_Click(sender As Object, e As EventArgs) Handles btntamp.Click
        MessageBox.Show("Guten Morgen" & vbCrLf &
                    "Nama  :" & txtnama.Text & vbCrLf &
                    "NIM  :" & txtnim.Text & vbCrLf &
                    "KOM  :" & txtkom.Text
     )
    End Sub

    Private Sub btnkel_Click(sender As Object, e As EventArgs) Handles btnkel.Click
        Me.Close()
    End Sub
End Class
