Imports MySql.Data.MySqlClient


Public Class Grupos

    Dim id As String

    Public Sub leerEntrenadores()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim da As MySqlDataAdapter
        Dim dt As New DataSet
        Dim com As MySqlCommand


        conn.Open()
        Dim sQuery = "select * from entrenadores; "
        com = New MySqlCommand(sQuery, conn)
        da = New MySqlDataAdapter(com)
        da.Fill(dt)
        ComboBox1.DataSource = dt.Tables(0)
        ComboBox1.DisplayMember = "Nombre"
        ComboBox1.ValueMember = "id_entrenador"

    End Sub


    Public Sub leerGrupos()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim com As MySqlCommand


        conn.Open()
        Dim sQuery = "select * from grupo; "
        com = New MySqlCommand(sQuery, conn)
        da = New MySqlDataAdapter(com)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.AutoResizeColumns()

    End Sub


    Public Sub crearGrupo()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "INSERT into grupo(id_grupo, nombre_grupo, id_entrenador) Values(@id, @nom, @identrenador)"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id", TextBoxIDG.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@nom", TextBoxNombre.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@identrenador", ComboBox1.SelectedValue)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha creado un nuevo registro de grupo")

        TextBoxIDG.Text = ""
        TextBoxNombre.Text = ""

    End Sub

    Public Sub modificarGrupo()
        ButtonAgregar.Enabled = False
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "UPDATE grupo Set id_grupo=@id, nombre_grupo=@nom, id_entrenador=@identrenador where id_grupo=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        param = New MySqlParameter("@id", TextBoxIDG.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@nom", TextBoxNombre.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@identrenador", ComboBox1.SelectedValue)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha actualizado el grupo")
        ButtonAgregar.Enabled = True
        TextBoxIDG.Text = ""
        TextBoxNombre.Text = ""

    End Sub

    Public Sub eliminarGrupo()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "DELETE from grupo where id_grupo=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha borrado el grupo")

        TextBoxIDG.Text = ""
        TextBoxNombre.Text = ""

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        menuprincipal.Show()
        Me.Close()


    End Sub

    Private Sub Grupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerEntrenadores()
        leerGrupos()


    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        crearGrupo()
        leerGrupos()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex >= 0 And e.RowIndex < DataGridView1.Rows.Count - 1) Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            id = row.Cells(0).Value.ToString()
            TextBoxIDG.Text = row.Cells(0).Value.ToString()
            TextBoxNombre.Text = row.Cells(1).Value.ToString()
            ComboBox1.Text = row.Cells(2).Value.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        modificarGrupo()
        leerGrupos()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        eliminarGrupo()
        leerGrupos()

    End Sub
End Class