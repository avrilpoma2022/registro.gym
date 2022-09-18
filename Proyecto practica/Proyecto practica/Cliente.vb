Imports MySql.Data.MySqlClient
Public Class Clientes

    Dim id As String


    Public Sub leerCliente()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim com As MySqlCommand


        conn.Open()
        Dim sQuery = "select * from cliente; "
        com = New MySqlCommand(sQuery, conn)
        da = New MySqlDataAdapter(com)
        da.Fill(dt)
        DataGridView2.DataSource = dt
        DataGridView2.Refresh()
        DataGridView2.AutoResizeColumns()

    End Sub


    Public Sub crearCliente()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "INSERT into cliente(id_cliente, Edad, sexo, telefono, peso, nombre_cliente) Values(@id, @edad, @sexo, @tel, @peso, @nom)"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id", TextBoxIDC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@nom", TextBoxNombreC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@edad", TextBoxEdadC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@tel", TextBoxTelefonoC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@sexo", ComboBoxSexoC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@peso", TextBoxPesoC.Text)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha creado un nuevo registro de cliente")

        TextBoxIDC.Text = ""
        TextBoxNombreC.Text = ""
        TextBoxTelefonoC.Text = ""
        TextBoxEdadC.Text = ""
        TextBoxPesoC.Text = ""

    End Sub

    Public Sub modificarCliente()
        ButtonAgregar.Enabled = False
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "UPDATE cliente Set id_cliente=@id, Edad=@edad, sexo=@edad, telefono=@tel,  peso=@peso, nombre_cliente=@nom where id_cliente=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        param = New MySqlParameter("@id", TextBoxIDC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@nom", TextBoxNombreC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@edad", TextBoxEdadC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@tel", TextBoxTelefonoC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@sexo", ComboBoxSexoC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@peso", TextBoxPesoC.Text)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha actualizado el cliente")
        ButtonAgregar.Enabled = True
        TextBoxIDC.Text = ""
        TextBoxNombreC.Text = ""
        TextBoxTelefonoC.Text = ""
        TextBoxEdadC.Text = ""
        TextBoxPesoC.Text = ""

    End Sub

    Public Sub eliminarCliente()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "DELETE from cliente where id_cliente=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha borrado el cliente")

        TextBoxIDC.Text = ""
        TextBoxNombreC.Text = ""
        TextBoxTelefonoC.Text = ""
        TextBoxEdadC.Text = ""
        TextBoxPesoC.Text = ""

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonRegresar.Click
        menuprincipal.Show()
        Me.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        crearCliente()
        leerCliente()

    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerCliente()

    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        modificarCliente()
        leerCliente()

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        eliminarCliente()
        leerCliente()

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If (e.RowIndex >= 0 And e.RowIndex < DataGridView2.Rows.Count - 1) Then
            Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            id = row.Cells(0).Value.ToString()
            TextBoxIDC.Text = row.Cells(0).Value.ToString()
            TextBoxEdadC.Text = row.Cells(1).Value.ToString()
            ComboBoxSexoC.Text = row.Cells(2).Value.ToString()
            TextBoxTelefonoC.Text = row.Cells(3).Value.ToString()
            TextBoxPesoC.Text = row.Cells(4).Value.ToString()
            TextBoxNombreC.Text = row.Cells(5).Value.ToString()
        End If
    End Sub
End Class