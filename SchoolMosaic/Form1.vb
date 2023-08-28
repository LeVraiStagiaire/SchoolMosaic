Imports SchoolMosaic.Server.LocalizationManager
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FichierToolStripMenuItem.Text = GetString("FileMenu")
        NouvelleBaseToolStripMenuItem.Text = GetString("NewBaseMenu")
        OuvrirBaseToolStripMenuItem.Text = GetString("OpenBaseMenu")
        FermerBaseToolStripMenuItem.Text = GetString("CloseBaseMenu")
        QuitterToolStripMenuItem.Text = GetString("ExitMenu")
        ServeurToolStripMenuItem.Text = GetString("ServerMenu")
        DémarrerToolStripMenuItem.Text = GetString("StartMenu")
        ArrêterToolStripMenuItem.Text = GetString("StopMenu")
        ServerStatus.Text = GetString("ServerStatusOff")
        OverviewTab.Text = GetString("OverviewTab")
        ConfigTab.Text = GetString("ConfigTab")
        OverviewList.Columns(0).Text = GetString("UsernameColumn")
        OverviewList.Columns(1).Text = GetString("ComputerColumn")
        OverviewList.Columns(2).Text = GetString("DateTimeColumn")
        ConfigBanner.Text = GetString("ConfigurationBanner")
        EditConfigButton.Text = GetString("ModifyButton")
        ServerDIsplayNameLabel.Text = GetString("ServerDisplayNameLabel")
        ServerPortLabel.Text = GetString("ServerPortLabel")
    End Sub
End Class
