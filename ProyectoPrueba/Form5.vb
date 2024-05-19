Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel


Public Class Form5
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ''conn.Open()
            'Definir el comando SQL para buscar una receta por ID
            Dim sql As String = "SELECT * FROM Recetas WHERE IdReceta = @IdReceta"
            Dim cmd As New SqlCommand(sql)

            'Asignar el valor del parámetro del comando
            cmd.Parameters.AddWithValue("@IdReceta", TextBox1.Text)

            'Ejecutar el comando SQL y obtener un objeto SqlDataReader
            Dim reader As SqlDataReader = ejecutaSelect(cmd)

            'Verificar si se encontróuna receta con el ID proporcionado
            If reader.HasRows Then

                'Recorrer las filas del resultado de la consulta
                While reader.Read()

                    'Asignar los valores de la fila a los controles correspondientes en el formulario
                    cmb_categoria1.Text = reader("Categoria").ToString()
                    TextBox2.Text = reader("NombreReceta").ToString()
                    cmb_comensales1.Text = reader("NumComensales").ToString()
                    cmb_tiempo1.Text = reader("Tiempo").ToString()
                    cmb_tipo1.Text = reader("Tipo").ToString()
                    TextBox3.Text = reader("Ingredientes").ToString()
                End While
            Else
                MessageBox.Show("No se encontróuna receta con el ID proporcionado.")
            End If
            'Cerrar el objeto SqlDataReader y la conexión
            reader.Close()
            ''conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar la receta: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Variables Globales'
        Dim objapp As Excel.Application
        Dim objbook As Excel.Workbook
        Dim objbooks As Excel.Workbooks
        Dim objsheets As Excel.Sheets
        Dim objsheet As Excel.Worksheet

        objapp = New Excel.Application()
        objbooks = objapp.Workbooks
        objbook = objbooks.Add
        objsheets = objbook.Worksheets
        objsheet = objsheets(1)

        'Id
        objsheet.Range("A4").Value = "Id Receta: "
        objsheet.Range("B4:B4").Merge()
        objsheet.Range("B4").Font.Bold = True
        objsheet.Range("B4").Value = TextBox1.Text

        'Nombre
        objsheet.Range("A5").Value = "Nombre de la receta: "
        objsheet.Range("B5:G5").Merge()
        objsheet.Range("B5").Font.Bold = True
        objsheet.Range("B5:E5").Value = TextBox2.Text



        'Categoria
        objsheet.Range("A6").Value = "Categoria:"
        objsheet.Range("B6:G6").Merge()
        objsheet.Range("B6").Font.Bold = True
        objsheet.Range("B6:G6").Value = cmb_categoria1.Text

        'Num comensales'
        objsheet.Range("A7").Value = "Numero de comensales: "
        objsheet.Range("B7:G7").Merge()
        objsheet.Range("B7").Font.Bold = True
        objsheet.Range("B7:G7").Value = cmb_comensales1.Text
        objsheet.Range("B7:G7").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft



        'Tiempo 
        objsheet.Range("A8").Value = "Tiempo: "
        objsheet.Range("B8:G8").Merge()
        objsheet.Range("B8").Font.Bold = True
        objsheet.Range("B8:G8").Value = cmb_tiempo1.Text

        'Tipo
        objsheet.Range("A9").Value = "Tipo: "
        objsheet.Range("B9:G9").Merge()
        objsheet.Range("B9").Font.Bold = True
        objsheet.Range("B9:G9").Value = cmb_tipo1.Text

        'Ingredientes
        objsheet.Range("A10").Value = "Ingredientes: "
        objsheet.Range("B10:G14").Merge()
        objsheet.Range("B10").Font.Bold = True
        objsheet.Range("B10:G14").Value = TextBox3.Text
        objsheet.Range("B10:G14").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objsheet.Range("B10:G14").WrapText = True
        objsheet.Range("B10:G14").VerticalAlignment = Excel.Constants.xlTop

        '
        objapp.Visible = True
        objapp.UserControl = True

        objsheet.PrintPreview()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class