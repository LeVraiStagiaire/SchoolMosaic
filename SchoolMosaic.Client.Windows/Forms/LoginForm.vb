Public Class LoginForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedIndices(0) = ListView1.Items.Count - 1 Then
            MessageBox.Show("'Ajouter' séléctionné")
        End If
    End Sub
End Class