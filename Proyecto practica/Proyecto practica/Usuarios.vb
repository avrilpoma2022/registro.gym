Imports MySql.Data.MySqlClient
Public Class Usuarios
    Public Sub leerUsuarios()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim com As MySqlCommand


        conn.Open()
        Dim sQuery = "select * from usuarios; "
        com = New MySqlCommand(sQuery, conn)
        da = New MySqlDataAdapter(com)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.AutoResizeColumns()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        menuprincipal.Show()
        Me.Close()

    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerUsuarios()

    End Sub
End Class