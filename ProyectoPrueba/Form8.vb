Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel

Public Class Form8

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            conn.Open()
            ' Definir el comando SQL para insertar la receta
            Dim sql As String = "INSERT INTO Recetas (Categoria, NombreReceta, NumComensales, Tiempo, Tipo, Ingredientes) " &
                            "VALUES (@Categoria, @NombreReceta, @NumComensales, @Tiempo, @Tipo, @Ingredientes)"
            Dim cmd As New SqlCommand(sql, conn)

            ' Asignar los valores a los parámetros del comando
            cmd.Parameters.AddWithValue("@Categoria", cmb_categoria1.Text)
            cmd.Parameters.AddWithValue("@NombreReceta", TextBoxReceta.Text)
            cmd.Parameters.AddWithValue("@NumComensales", cmb_comensales1.Text)
            cmd.Parameters.AddWithValue("@Tiempo", cmb_tiempo1.Text)
            cmd.Parameters.AddWithValue("@Tipo", cmb_tipo1.Text)
            cmd.Parameters.AddWithValue("@Ingredientes", TextBox3.Text)

            ' Ejecutar el comando SQL
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Receta agregada correctamente.")
            Else
                MessageBox.Show("No se pudo agregar la receta.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al agregar la receta: " & ex.Message)
        Finally
            ' Cerrar la conexión
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            conn.Open()
            Dim sql As String = "UPDATE Recetas SET Categoria=@Categoria, NombreReceta=@NombreReceta, NumComensales=@NumComensales, Tiempo=@Tiempo, Tipo=@Tipo, Ingredientes=@Ingredientes WHERE IdReceta=@IdReceta"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Categoria", cmb_categoria1.Text)
            cmd.Parameters.AddWithValue("@NombreReceta", TextBoxReceta.Text)
            cmd.Parameters.AddWithValue("@NumComensales", cmb_comensales1.Text)
            cmd.Parameters.AddWithValue("@Tiempo", cmb_tiempo1.Text)
            cmd.Parameters.AddWithValue("@Tipo", cmb_tipo1.Text)
            cmd.Parameters.AddWithValue("@Ingredientes", TextBox3.Text)
            cmd.Parameters.AddWithValue("@IdReceta", TextBox1.Text)

            'Ejecutar komando
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("Receta actualizada correctamente.")
            Else
                MessageBox.Show("No se pudo actualizar la receta.")

            End If

            'conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar la receta: " & ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            'Definir el comando SQL para buscar una receta por ID
            Dim sql As String = "SELECT * FROM Recetas WHERE IdReceta = @IdReceta"
            Dim cmd As New SqlCommand(sql, conn)

            'Asignar el valor del parámetro del comando
            cmd.Parameters.AddWithValue("@IdReceta", TextBox1.Text)

            'Ejecutar el comando SQL y obtener un objeto SqlDataReader
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            'Verificar si se encontróuna receta con el ID proporcionado
            If reader.HasRows Then
                'Recorrer las filas del resultado de la consulta
                While reader.Read()
                    'Asignar los valores de la fila a los controles correspondientes en el formulario
                    cmb_categoria1.Text = reader("Categoria").ToString()
                    TextBox3.Text = reader("NombreReceta").ToString()
                    cmb_comensales1.Text = reader("NumComensales").ToString()
                    cmb_tiempo1.Text = reader("Tiempo").ToString()
                    cmb_tipo1.Text = reader("Tipo").ToString()
                    TextBoxReceta.Text = reader("Ingredientes").ToString()
                End While
            Else
                MessageBox.Show("No se encontróuna receta con el ID proporcionado.")

            End If

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error al buscar la receta: " & ex.Message)
        End Try
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.Show()
        Me.Hide()
    End Sub
End Class