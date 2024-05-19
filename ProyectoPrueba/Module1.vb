Imports System.Data.SqlClient
Module Module1
    'La variable conn es la que permite conectarnos a nuestro SQL
    'data source = donde esta conectada nuestra base de datos
    Public conn As New SqlClient.SqlConnection("data source = DESKTOP-NS0DOBO\SQLEXPRESS; initial catalog= RECETASPROYECTO; integrated security= SSPI; persist security info = false; trusted_connection = yes;")
    'Nos permite ejecutar los comandos que tienen que ver con los 
    'procedimientos almacenados de sql
    Public cmd As SqlClient.SqlCommand
    'permite leer los datos
    Public sqlread As SqlClient.SqlDataReader
    Public Query As String
    Public w As Integer
    Public bandera As Integer = 0

    Public Function ejecutaSelect(cmd As SqlCommand) As SqlDataReader
        Dim dr As SqlDataReader
        conn.Open()
        cmd.Connection = conn
        dr = cmd.ExecuteReader()

        conn.Close()
        Return dr
    End Function
End Module


