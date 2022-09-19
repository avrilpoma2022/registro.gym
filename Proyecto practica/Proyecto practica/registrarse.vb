Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration.ConfigurationManager
Imports System.Configuration
Imports System.Runtime.InteropServices
Public Class registrarse
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Dim conn As New MySqlConnection
    Dim objetoconexion As New conexion
    Dim cmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox8.Text = TextBox7.Text Then
            conn = objetoconexion.AbrirCon
            Try
                cmd = conn.CreateCommand
                cmd.CommandText = "INSERT INTO usuarios(nombre, apellidos, telefono, correo, direccion, usuario, contraseña) VALUES('" & TextBox9.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "');"
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Dispose()

                TextBox9.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()

            Catch ex As Exception

            End Try
            Me.Close()
            Form1.Show()
        Else
            MessageBox.Show("Las contraseñas no coinciden")
            TextBox8.Clear()
            TextBox8.Focus()
        End If
    End Sub

    Private Sub registrarse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub
End Class