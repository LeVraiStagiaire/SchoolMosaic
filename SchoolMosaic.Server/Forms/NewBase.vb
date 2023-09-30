Imports SchoolMosaic.Server.LocalizationManager
Public Class NewBase
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Close()
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim ItsOK As Boolean = True
        Dim Checked As Boolean = False
        If Monday.Checked Then Checked = True
        If Tuesday.Checked Then Checked = True
        If Wednesday.Checked Then Checked = True
        If Thursday.Checked Then Checked = True
        If Friday.Checked Then Checked = True
        If Saturday.Checked Then Checked = True
        If Sunday.Checked Then Checked = True
        If AdminPasswordBox.Text = "" Then
            ItsOK = False
            MessageBox.Show(GetString("EnterAdminPassword"), GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If AdminPasswordBox.Text <> RepeatPasswordBox.Text Then
            ItsOK = False
            MessageBox.Show(GetString("PasswordsDontMatch"), GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If BaseNameBox.Text = "" Then
            ItsOK = False
            MessageBox.Show(GetString("EnterBaseName"), GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Checked = False Then
            ItsOK = False
            MessageBox.Show(GetString("SelectADay"), GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If ItsOK Then
            Me.DialogResult = DialogResult.OK
            Close()
        End If
    End Sub

    Private Sub NewBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstDayBox.SelectedIndex = 0
        DailySessionNumber.SelectedIndex = 7
    End Sub
End Class