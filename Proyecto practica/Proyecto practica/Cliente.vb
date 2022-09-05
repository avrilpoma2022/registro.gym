Imports MySql.Data.MySqlClient
Public Class Cliente

    Dim id As String

    Public Sub leerClientes()
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



    Public Sub crearClientes()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "INSERT into cliente(id_cliente, Edad, sexo, telefono, peso, nombre_cliente) Values(@id, @edad, @sexo, @tel, @peso, @nom)"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id", TextBoxIDC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@edad", TextBoxEdad.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@sexo", ComboBoxSexo.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@tel", TextBoxTelefono.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@peso", TextBoxPeso.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@nom", TextBoxNombre.Text)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha creado un nuevo registro de cliente")

        TextBoxIDC.Text = ""
        TextBoxNombre.Text = ""
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
        Dim sQuery = "UPDATE cliente Set id_entrenador=@id, nombre=@nom, edad=@edad, telefono=@tel,  estado=@estado where id_entrenador=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        param = New MySqlParameter("@id", TextBoxIDC.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@nom", TextBoxNombre.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@edad", TextBoxEdad.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@tel", TextBoxTelefono.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@estado", ComboBoxSexo.Text)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha actualizado el entrenador")
        ButtonAgregar.Enabled = True;
        TextBoxIDC.Text = ""
        TextBoxNombre.Text = ""
        TextBoxTelefono.Text = ""
        TextBoxEdad.Text = ""

    End Sub

    Public Sub eliminarEntrenador()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "DELETE from cliente where id_entrenador=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha borrado el entrenador")

        TextBoxIDC.Text = ""
        TextBoxNombre.Text = ""
        TextBoxTelefono.Text = ""
        TextBoxEdad.Text = ""


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonRegresar.Click
        menuprincipal.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        crearClientes()
        leerClientes()

    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerClientes()

    End Sub
End Class