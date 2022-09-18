Public Class menuprincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Entrenadores.Show()
        Me.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clientes.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Pagos.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Grupos.Show()
        Me.Close()

    End Sub

    Private Sub menuprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hola MUNDO
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Usuarios.Show()
        Me.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Asignacion.Show()
        Me.Close()

    End Sub
End Class