Imports System.Configuration
Imports GSF.Collections
Imports SchoolMosaic.Server.BaseManager
Imports SchoolMosaic.Server.LocalizationManager
Public Class Form1

    Dim DBConnection As New MySqlConnection
    Dim GUILogger As New Logger("GUI")
    Dim ApplicationLogger As New Logger("Application")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GUILogger.Info("Initializing language...")
        GUILogger.Debug("Getting entry for FichierToolStripMenuItem")
        FichierToolStripMenuItem.Text = GetString("FileMenu")
        GUILogger.Debug("Getting entry for NouvelleBaseToolStripMenuItem")
        NouvelleBaseToolStripMenuItem.Text = GetString("NewBaseMenu")
        GUILogger.Debug("Getting entry for OuvrirBaseToolStripMenuItem")
        OuvrirBaseToolStripMenuItem.Text = GetString("OpenBaseMenu")
        GUILogger.Debug("Getting entry for FermerBaseToolStripMenuItem")
        FermerBaseToolStripMenuItem.Text = GetString("CloseBaseMenu")
        GUILogger.Debug("Getting entry for QuitterToolStripMenuItem")
        QuitterToolStripMenuItem.Text = GetString("ExitMenu")
        GUILogger.Debug("Getting entry for ServeurToolStripMenuItem")
        ServeurToolStripMenuItem.Text = GetString("ServerMenu")
        GUILogger.Debug("Getting entry for DémarrerToolStripMenuItem")
        DémarrerToolStripMenuItem.Text = GetString("StartMenu")
        GUILogger.Debug("Getting entry for ArrêterToolStripMenuItem")
        ArrêterToolStripMenuItem.Text = GetString("StopMenu")
        GUILogger.Debug("Getting entry for ServerStatus")
        ServerStatus.Text = GetString("ServerStatusOff")
        GUILogger.Debug("Getting entry for OverviewTab")
        OverviewTab.Text = GetString("OverviewTab")
        GUILogger.Debug("Getting entry for ConfigTab")
        ConfigTab.Text = GetString("ConfigTab")
        GUILogger.Debug("Getting entry for OverviewList")
        OverviewList.Columns(0).Text = GetString("UsernameColumn")
        OverviewList.Columns(1).Text = GetString("ComputerColumn")
        OverviewList.Columns(2).Text = GetString("DateTimeColumn")
        GUILogger.Debug("Getting entry for ConfigBanner")
        ConfigBanner.Text = GetString("ConfigurationBanner")
        GUILogger.Debug("Getting entry for EditConfigButton")
        EditConfigButton.Text = GetString("ModifyButton")
        GUILogger.Debug("Getting entry for ServerDisplayNameLabel")
        ServerDIsplayNameLabel.Text = GetString("ServerDisplayNameLabel")
        GUILogger.Debug("Getting entry for ServerPortLabel")
        ServerPortLabel.Text = GetString("ServerPortLabel")
        DBConnection.ConnectionString = "server=127.0.0.1;uid=root;pwd=0;"
        ApplicationLogger.Info("Testing connection to database...")
    End Sub

    Private Sub NouvelleBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelleBaseToolStripMenuItem.Click
        Dim NewBaseDialog As New NewBase
        GUILogger.Debug("Opening new base dialog")
        If NewBaseDialog.ShowDialog() = DialogResult.OK Then
            GUILogger.Debug("Result: OK")
            CreateDatabase(NewBaseDialog.BaseNameBox.Text)
            Dim Columns As New List(Of Column) From {
                New Column("id", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.AutoIncrement, Column.Attribute.NotNull, Column.Attribute.PrimaryKey}),
                New Column("username", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("password", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("role", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull})
            }
            CreateTable("users", New List(Of Column) From {
                New Column("id", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.AutoIncrement, Column.Attribute.NotNull, Column.Attribute.PrimaryKey}),
                New Column("username", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("password", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("role", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull})
            }, New List(Of List(Of String)) From {New List(Of String) From {"NULL"}})
            Using cmd5 As New MySqlCommand("CREATE TABLE `config` (`id` int(11) NOT NULL AUTO_INCREMENT,`name` varchar(255) NOT NULL,`value` varchar(255) NOT NULL,PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=utf8;", DBConnection)
                        cmd5.Transaction = cmd
                        cmd5.ExecuteNonQuery()
                    End Using
                    Using cmd6 As New MySqlCommand("INSERT INTO `users` (`id`, `username`, `password`, `role`) VALUES (NULL, 'admin', '@p', 'admin');", DBConnection)
                        cmd6.Parameters.AddWithValue("@p", NewBaseDialog.AdminPasswordBox.Text)
                        cmd6.Transaction = cmd
                        cmd6.ExecuteNonQuery()
                    End Using
                    Using cmd7 As New MySqlCommand("INSERT INTO `config` (`id`, `name`, `value`) VALUES (NULL, 'server_display_name', '@dn'), (NULL, 'days_of_work', '@dow'), (NULL, 'first_day', '@fd');", DBConnection)
                        cmd7.Parameters.AddWithValue("@dn", NewBaseDialog.BaseNameBox.Text)
                        Dim dow As String = ""
                        If NewBaseDialog.Monday.Checked Then dow += "1"
                        If NewBaseDialog.Tuesday.Checked Then dow += "2"
                        If NewBaseDialog.Wednesday.Checked Then dow += "3"
                        If NewBaseDialog.Thursday.Checked Then dow += "4"
                        If NewBaseDialog.Friday.Checked Then dow += "5"
                        If NewBaseDialog.Saturday.Checked Then dow += "6"
                        If NewBaseDialog.Sunday.Checked Then dow += "7"
                        cmd7.Parameters.AddWithValue("@dow", dow)
                        cmd7.Parameters.AddWithValue("@fd", NewBaseDialog.FirstDayBox.SelectedItem)
                        cmd7.Transaction = cmd
                        cmd7.ExecuteNonQuery()
                    End Using
                    ApplicationLogger.Debug("Executing query...")
                    cmd.Commit()
                    ApplicationLogger.Debug("Query executed")
                    ApplicationLogger.Info("Base created successfully")
                Catch ex As MySqlException
                    cmd.Rollback()
                    ApplicationLogger.Fatal("Error while creating base", ex)
                    MessageBox.Show(ex.Message + vbCrLf + ex.SqlState, GetString("DatabaseCreationErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
            DBConnection.Close()
        End If
    End Sub
End Class
