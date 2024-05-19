Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form4
    Sub QuerySelect()
        Dim sql As String = "Select IdChef, Nombre, Apellido, Telefono, Puesto from Chefs"
        Dim cmd As New SqlCommand(sql, conn)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Chefs")
            Me.DataGridView1.DataSource = ds.Tables("Chefs")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QuerySelect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class