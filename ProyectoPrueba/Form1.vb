Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing


Public Class Form1
    Public dani As Integer = 0
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim password As String


        If txt_user.Text <> "" And txt_password.Text <> "" Then
            conn.Open()
            If conn.State = ConnectionState.Open Then
                cmd = conn.CreateCommand
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Ingreso"
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txt_user.Text
                cmd.ExecuteNonQuery()

                sqlread = cmd.ExecuteReader
                While sqlread.Read
                    bandera = 1
                    password = sqlread("Contraseña")
                    If txt_password.Text = password Then
                        Exit While ' Salir del bucle mientras se ha encontrado una coincidencia
                    End If
                End While

                If bandera = 0 Then
                    MsgBox("Usuario no encontrado...", Title:="Error")
                End If
                sqlread.Close()
                cmd.Dispose()
                conn.Close()
            Else
                MsgBox("Error en la conexion", Title:="Error")
            End If
        Else
            MsgBox("No puede dejar los espacios vacíos", Title:="Alerta")
        End If

        ' Verificar el tipo de usuario después de salir del bloque de conexión
        If bandera = 1 Then
            Try
                Dim sql As String = "SELECT * FROM chefs WHERE Usuario=@Usuario AND Contraseña=@Contraseña"
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Usuario", txt_user.Text)
                cmd.Parameters.AddWithValue("@Contraseña", txt_password.Text)

                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    Dim Puesto As String = reader("Puesto").ToString()
                    If Puesto = "Chef Ejecutivo" Then
                        dani = 1
                        Form2.Show()
                        Me.Hide()

                    Else
                        dani = 0
                        Form2.Show()
                        Me.Hide()
                    End If
                End If
                reader.Close()
                conn.Close()

            Catch ex As Exception
                MessageBox.Show("Error al intentar iniciar sesión: " & ex.Message)
                conn.Close()
            End Try
        End If
    End Sub


    '    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
    '        Dim password As String

    '        If txt_user.Text <> "" And txt_password.Text <> "" Then

    '            conn.Open()
    '            If conn.State = ConnectionState.Open Then

    '                cmd = conn.CreateCommand
    '                cmd.CommandType = CommandType.StoredProcedure
    '                cmd.CommandText = "Ingreso"
    '                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = txt_user.Text
    '                cmd.ExecuteNonQuery()

    '                sqlread = cmd.ExecuteReader
    '                While sqlread.Read
    '                    bandera = 1
    '                    password = sqlread("Contraseña")

    '                    If txt_password.Text = password Then
    '                        Form2.Show()
    '                        Me.Hide()
    '                    Else
    '                        MsgBox("Contraseña incorrecta", Title:="Error")
    '                    End If

    '                End While

    '                If bandera = 0 Then
    '                    MsgBox("Usuario no encontrado...", Title:="Error")
    '                End If
    '                sqlread.Close()
    '                cmd.Dispose()
    '                conn.Close()
    '            Else

    '                MsgBox("Error en la conexion", Title:="Error")

    '            End If

    '        Else

    '            MsgBox("No puede dejar los espacios vacíos", Title:="Alerta")
    '        End If

    '        '**********
    '        ''** Código en el botón de inicio de sesión en el FormularioPrincipal

    '        Try
    '            '**conn.Open()

    '            Dim sql As String = "SELECT * FROM chefs WHERE Usuario=@Usuario AND Contraseña=@Contraseña"
    '            Dim cmd As New SqlCommand(sql, conn)
    '            cmd.Parameters.AddWithValue("@Usuario", txt_user.Text)
    '            cmd.Parameters.AddWithValue("@Contraseña", txt_password.Text)

    '            conn.Open()
    '            Dim reader As SqlDataReader = cmd.ExecuteReader()
    '            If reader.HasRows Then
    '                reader.Read()
    '            End If

    '            Dim isEjecutivo As Boolean = False
    '            Dim Puesto As String = reader("Puesto").ToString()

    '            If Puesto = "Chef Ejecutivo" Then
    '                isEjecutivo = True
    '            End If

    '            reader.Close()
    '            conn.Close()

    '            If isEjecutivo Then
    '                Dim form As New Form7()
    '                form.Show()
    '                Me.Hide()

    '            Else
    '                Dim form As New Form2()
    '                form.Show()
    '                Me.Hide()
    '            End If

    '            '**Else
    '            '**MessageBox.Show("Usuario o contraseña incorrectos")
    '            '**reader.close
    '            '**conn.close()
    '            '*+End IF


    '        Catch ex As Exception
    '            '**MessageBox.Show("Error al intentar iniciar sesión: " & ex.Message)
    '            conn.Close()
    '        End Try
    '    End Sub

    '    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    End Sub
End Class
