Public Class Form2
    Private Sub btn_recetas_Click(sender As Object, e As EventArgs) Handles btn_recetas.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.dani = 1 Then
            PictureBox4.Visible = True
            Label6.Visible = True
        Else
            PictureBox4.Visible = False
            Label6.Visible = False

        End If
    End Sub

    Private Sub btn_chefs_Click(sender As Object, e As EventArgs) Handles btn_chefs.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form8.Show()
    End Sub
End Class