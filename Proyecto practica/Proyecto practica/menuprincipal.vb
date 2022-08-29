Public Class menuprincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Entrenadores.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cliente.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Pagos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Grupos.Show()

    End Sub
End Class