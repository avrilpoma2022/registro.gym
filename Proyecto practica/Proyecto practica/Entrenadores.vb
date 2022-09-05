Imports MySql.Data.MySqlClient

Public Class Entrenadores


    Dim id As String

    Public Sub leerEntrenadores()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim com As MySqlCommand


        conn.Open()
        Dim sQuery = "select * from entrenadores; "
        com = New MySqlCommand(sQuery, conn)
        da = New MySqlDataAdapter(com)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.AutoResizeColumns()

    End Sub



    Public Sub crearEntrenador()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "INSERT into entrenadores(id_entrenador, Nombre, Edad, telefono, Estado) Values(@id, @nom, @edad, @tel, @estado)"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id", TextBoxIDE.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@nom", TextBoxNombreE.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@edad", TextBoxEdad.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@tel", TextBoxTelefono.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@estado", ComboBox1.Text)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha creado un nuevo registro de entrenador")

        TextBoxIDE.Text = ""
        TextBoxNombreE.Text = ""
        TextBoxTelefono.Text = ""
        TextBoxEdad.Text = ""

    End Sub

    Public Sub modificarEntrenador()
        ButtonAgregar.Enabled = False
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "UPDATE entrenadores Set id_entrenador=@id, nombre=@nom, edad=@edad, telefono=@tel,  estado=@estado where id_entrenador=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        param = New MySqlParameter("@id", TextBoxIDE.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@nom", TextBoxNombreE.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@edad", TextBoxEdad.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@tel", TextBoxTelefono.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@estado", ComboBox1.Text)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha actualizado el entrenador")
        ButtonAgregar.Enabled = True;
        TextBoxIDE.Text = ""
        TextBoxNombreE.Text = ""
        TextBoxTelefono.Text = ""
        TextBoxEdad.Text = ""

    End Sub

    Public Sub eliminarEntrenador()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "DELETE from entrenadores where id_entrenador=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha borrado el entrenador")

        TextBoxIDE.Text = ""
        TextBoxNombreE.Text = ""
        TextBoxTelefono.Text = ""
        TextBoxEdad.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        crearEntrenador()
        leerEntrenadores()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Entrenadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerEntrenadores()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonRegresar.Click

        menuprincipal.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex >= 0 And e.RowIndex < DataGridView1.Rows.Count - 1) Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            id = row.Cells(0).Value.ToString()
            TextBoxIDE.Text = row.Cells(0).Value.ToString()
            TextBoxNombreE.Text = row.Cells(1).Value.ToString()
            TextBoxEdad.Text = row.Cells(2).Value.ToString()
            TextBoxTelefono.Text = row.Cells(3).Value.ToString()
            ComboBox1.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        modificarEntrenador()

        leerEntrenadores()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        eliminarEntrenador()
        leerEntrenadores()

    End Sub
End Class