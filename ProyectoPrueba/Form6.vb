Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String = "UPDATE Recetas SET calificacion = @calificacion WHERE idreceta = @idreceta"

        Dim command As New SqlCommand(query, conn)
        command.Parameters.AddWithValue("@calificacion", ComboBox1.SelectedItem.ToString())
        command.Parameters.AddWithValue("@idreceta", TextBox1.Text)

        Try
            conn.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            MessageBox.Show("Se ha actualizado la calificación de la receta.")

        Catch ex As Exception
            MessageBox.Show("Error al actualizar la calificación de la receta: " & ex.Message)
        End Try
        conn.Close()
        'Calificar una receta

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class