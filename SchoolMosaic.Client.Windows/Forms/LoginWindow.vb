Public Class LoginWindow
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        LoginForm.ShowDialog()
    End Sub
End Class
