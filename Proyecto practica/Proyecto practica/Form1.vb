Imports System.Runtime.InteropServices

Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim comando As MySqlCommand = New MySqlCommand


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        registrarse.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        comando.Connection = conexion
        Try
            conexion.ConnectionString = "Server = localhost; Database = godsfist; Uid = root; Pwd =;"
            conexion.Open()

        Catch ex As Exception

        End Try
        comando.CommandText = "SELECT * FROM usuarios WHERE usuario = '" + TextBox1.Text + "' AND contraseña = '" + TextBox2.Text + "'"
        Dim r As MySqlDataReader
        r = comando.ExecuteReader
        If r.HasRows <> False Then
            r.Read()
            Me.Hide()
            menuprincipal.Show()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
            TextBox2.Clear()
            TextBox2.Focus()

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
