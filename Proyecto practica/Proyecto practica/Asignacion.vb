Imports MySql.Data.MySqlClient
Public Class Asignacion
    Dim id As String

    Public Sub leerClientes()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim da As MySqlDataAdapter
        Dim dt As New DataSet
        Dim com As MySqlCommand


        conn.Open()
        Dim sQuery = "select * from cliente; "
        com = New MySqlCommand(sQuery, conn)
        da = New MySqlDataAdapter(com)
        da.Fill(dt)
        ComboBoxIDC.DataSource = dt.Tables(0)
        ComboBoxIDC.DisplayMember = "nombre_cliente"
        ComboBoxIDC.ValueMember = "id_cliente"

    End Sub

    Public Sub leerGrupo()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim da As MySqlDataAdapter
        Dim dt As New DataSet
        Dim com As MySqlCommand


        conn.Open()
        Dim sQuery = "select * from grupo; "
        com = New MySqlCommand(sQuery, conn)
        da = New MySqlDataAdapter(com)
        da.Fill(dt)
        ComboBoxIDG.DataSource = dt.Tables(0)
        ComboBoxIDG.DisplayMember = "nombre_grupo"
        ComboBoxIDG.ValueMember = "id_grupo"

    End Sub


    Public Sub leerAsignaciones()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim com As MySqlCommand


        conn.Open()
        Dim sQuery = "select * from asignacion; "
        com = New MySqlCommand(sQuery, conn)
        da = New MySqlDataAdapter(com)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.AutoResizeColumns()

    End Sub


    Public Sub crearAsignacion()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "INSERT into asignacion(id_asignacion, fecha_asignacion, id_cliente, id_grupo) Values(@id, @fecha, @idcliente, @idgrupo)"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id", TextBoxIDA.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@fecha", DateTimePicker1.Value)
        com.Parameters.Add(param)
        param = New MySqlParameter("@idcliente", ComboBoxIDC.SelectedValue)
        com.Parameters.Add(param)
        param = New MySqlParameter("@idgrupo", ComboBoxIDG.SelectedValue)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha creado un nuevo registro de asignacion")

        TextBoxIDA.Text = ""

    End Sub

    Public Sub modificarAsignacion()
        ButtonAgregar.Enabled = False
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "UPDATE asignacion Set id_asignacion=@id, fecha_asignacion=@fecha, id_cliente=@idcliente, id_grupo=@idgrupo where id_asignacion=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        param = New MySqlParameter("@id", TextBoxIDA.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@fecha", DateTimePicker1.Value)
        com.Parameters.Add(param)
        param = New MySqlParameter("@idcliente", ComboBoxIDC.SelectedValue)
        com.Parameters.Add(param)
        param = New MySqlParameter("@idgrupo", ComboBoxIDG.SelectedValue)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha actualizado la asignación")
        ButtonAgregar.Enabled = True
        TextBoxIDA.Text = ""

    End Sub

    Public Sub eliminarAsignacion()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "DELETE from asignacion where id_asignacion=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha borrado la asignación")

        TextBoxIDA.Text = ""

    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        crearAsignacion()
        leerAsignaciones()

    End Sub

    Private Sub Asignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerClientes()
        leerGrupo()
        leerAsignaciones()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        modificarAsignacion()
        leerAsignaciones()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        eliminarAsignacion()
        leerAsignaciones()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex >= 0 And e.RowIndex < DataGridView1.Rows.Count - 1) Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            id = row.Cells(0).Value.ToString()
            TextBoxIDA.Text = row.Cells(0).Value.ToString()
            DateTimePicker1.Value = row.Cells(1).Value.ToString()
            ComboBoxIDC.Text = row.Cells(2).Value.ToString()
            ComboBoxIDG.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        menuprincipal.Show()
        Me.Close()

    End Sub
End Class