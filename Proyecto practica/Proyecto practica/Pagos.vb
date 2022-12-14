Imports MySql.Data.MySqlClient
Public Class Pagos

    Dim id As String

    Public Sub leerCliente()
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


    Public Sub leerPago()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable
        Dim com As MySqlCommand


        conn.Open()
        Dim sQuery = "select * from pagos; "
        com = New MySqlCommand(sQuery, conn)
        da = New MySqlDataAdapter(com)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        DataGridView1.AutoResizeColumns()

    End Sub


    Public Sub crearPago()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "INSERT into pagos(id_pago, fecha_pago, proximopago, monto, tipo, id_cliente) Values(@id, @fecha, @proximo, @monto, @tipo, @idcliente)"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id", TextBoxIDP.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@fecha", DateTimePickerFecha.Value)
        com.Parameters.Add(param)
        param = New MySqlParameter("@proximo", DateTimePickerProximo.Value)
        com.Parameters.Add(param)
        param = New MySqlParameter("@monto", Decimal.Parse(TextBoxMonto.Text))
        com.Parameters.Add(param)
        param = New MySqlParameter("@tipo", ComboBoxTipo.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@idcliente", ComboBoxIDC.SelectedValue)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha creado un nuevo registro de pago")

        TextBoxIDP.Text = ""
        TextBoxMonto.Text = ""
        ComboBoxIDC.Text = ""
        ComboBoxTipo.Text = ""

    End Sub

    Public Sub modificarPago()
        ButtonAgregar.Enabled = False
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "UPDATE pagos Set id_pago=@id, fecha_pago=@fecha, proximopago=@proximo, monto=@monto, id_cliente=@idcliente where id_pago=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        param = New MySqlParameter("@id", TextBoxIDP.Text)
        com.Parameters.Add(param)
        param = New MySqlParameter("@fecha", DateTimePickerFecha.Value)
        com.Parameters.Add(param)
        param = New MySqlParameter("@proximo", DateTimePickerProximo.Value)
        com.Parameters.Add(param)
        param = New MySqlParameter("@monto", Decimal.Parse(TextBoxMonto.Text))
        com.Parameters.Add(param)
        param = New MySqlParameter("@tipo", ComboBoxTipo.SelectedValue)
        com.Parameters.Add(param)
        param = New MySqlParameter("@idcliente", ComboBoxIDC.SelectedValue)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha actualizado el pago")
        ButtonAgregar.Enabled = True
        TextBoxIDP.Text = ""
        TextBoxMonto.Text = ""

    End Sub

    Public Sub eliminarPago()
        Dim cadenaconex = "Server=localhost;Database=godsfist;User id=root; Password=;"
        Dim conn As New MySqlConnection(cadenaconex)
        Dim com As MySqlCommand
        Dim param As MySqlParameter


        conn.Open()
        Dim sQuery = "DELETE from pagos where id_pago=@id2"
        com = New MySqlCommand(sQuery, conn)
        param = New MySqlParameter("@id2", id)
        com.Parameters.Add(param)
        com.ExecuteNonQuery()
        MessageBox.Show("Se ha borrado el pago")

        TextBoxIDP.Text = ""
        TextBoxMonto.Text = ""

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        crearPago()
        leerPago()


    End Sub

    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerCliente()
        leerPago()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        menuprincipal.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        modificarPago()
        leerPago()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex >= 0 And e.RowIndex < DataGridView1.Rows.Count - 1) Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            id = row.Cells(0).Value.ToString()
            TextBoxIDP.Text = row.Cells(0).Value.ToString()
            DateTimePickerFecha.Value = row.Cells(1).Value
            DateTimePickerProximo.Value = row.Cells(2).Value
            TextBoxMonto.Text = row.Cells(3).Value.ToString()
            ComboBoxTipo.Text = row.Cells(4).Value.ToString()
            ComboBoxIDC.SelectedValue = Convert.ToInt32(row.Cells(5).Value.ToString())
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        eliminarPago()
        leerPago()

    End Sub
End Class