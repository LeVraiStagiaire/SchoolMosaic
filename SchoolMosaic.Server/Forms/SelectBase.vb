Imports SchoolMosaic.Server.BaseManager
Public Class SelectBase
    Private Sub SelectBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenDatabase()
        BaseSelectionBox.Items.AddRange(GetBases().ToArray)
        CloseDatabase()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BaseSelectionBox.SelectedIndexChanged
        OpenButton.Enabled = (BaseSelectionBox.SelectedItems.Count = 1)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles BaseSelectionBox.DoubleClick
        OpenButton.PerformClick()
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Dim SelectDialog As New Microsoft.WindowsAPICodePack.Dialogs.CommonOpenFileDialog() With {
            .Title = "Importer une base",
            .Multiselect = False
        }
        SelectDialog.Filters.Add(New Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogFilter("Base SchoolMosaic", ".smbase"))
        If SelectDialog.ShowDialog() = Microsoft.WindowsAPICodePack.Dialogs.CommonFileDialogResult.Ok Then

        End If
    End Sub
End Class