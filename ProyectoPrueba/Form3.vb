Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form3
    Private Sub Form3_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Sub QuerySelect()
        Dim sql As String = "Select * from Recetas"
        Dim cmd As New SqlCommand(sql, conn)
        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Recetas")
            Me.DataGridView1.DataSource = ds.Tables("Recetas")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Clean()
        cmb_categoria.Text = ""
        cmb_comensales.Text = ""
        cmb_tiempo.Text = ""
        cmb_tipo.Text = ""
        txt_ingrediente.Clear()

    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QuerySelect()

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Dim palabras_clave() As String = txt_ingrediente.Text.Split(","c) ' Separa las palabras clave por comas

        Dim sql As String = "SELECT * FROM Recetas WHERE"
        For i As Integer = 0 To palabras_clave.Length - 1
            ' El uso de += es para concatenar nuevos datos en la variable que ya tenemos
            sql += " Ingredientes LIKE '%" & palabras_clave(i).Trim() & "%'"
            If i < palabras_clave.Length - 1 Then
                sql += " OR"
            End If
        Next

        If cmb_categoria.Text <> "" Then
            sql += " AND Categoria LIKE '%" + cmb_categoria.Text + "%'"
        End If
        If cmb_comensales.Text <> "" Then
            sql += " AND NumComensales LIKE '%" + cmb_comensales.Text + "%'"
        End If
        If cmb_tipo.Text <> "" Then
            sql += " AND Tipo LIKE '%" + cmb_tipo.Text + "%'"
        End If
        If cmb_tiempo.Text <> "" Then
            sql += " AND Tiempo LIKE '%" + cmb_tiempo.Text + "%'"
        End If
        'Dim sql As String = "SELECT * FROM Recetas WHERE Ingredientes LIKE %" + txt_ingrediente.Text + "%"

        Dim cmd As New SqlCommand(sql, conn)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Recetas")
            Me.DataGridView1.DataSource = ds.Tables("Recetas")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class