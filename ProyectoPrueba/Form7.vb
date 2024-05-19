Public Class Form7
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form8.Show()

    End Sub

    Private Sub btn_recetas_Click(sender As Object, e As EventArgs) Handles btn_recetas.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class