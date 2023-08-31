Imports MySqlConnector
Imports SchoolMosaic.Server.LocalizationManager
Public Class Form1

    Dim DBConnection As New MySqlConnection
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
        DBConnection.ConnectionString = "server=127.0.0.1;uid=root;pwd=0;"
        Try
            ' Try to connect to the database
            DBConnection.Open()
            DBConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message + vbCrLf + ex.SqlState, GetString("DatabaseConnectionErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

    Private Sub NouvelleBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelleBaseToolStripMenuItem.Click
        Dim NewBaseDialog As New NewBase
        If NewBaseDialog.ShowDialog() = DialogResult.OK Then
            DBConnection.Open()
            Using cmd As MySqlTransaction = DBConnection.BeginTransaction()
                Try
                    Using cmd2 As New MySqlCommand("CREATE DATABASE " + NewBaseDialog.BaseNameBox.Text + ";", DBConnection)
                        cmd2.Transaction = cmd
                        cmd2.ExecuteNonQuery()
                    End Using
                    Using cmd3 As New MySqlCommand("USE " + NewBaseDialog.BaseNameBox.Text + ";", DBConnection)
                        cmd3.Transaction = cmd
                        cmd3.ExecuteNonQuery()
                    End Using
                    Using cmd4 As New MySqlCommand("CREATE TABLE `users` (`id` int(11) NOT NULL AUTO_INCREMENT,`username` varchar(255) NOT NULL,`password` varchar(255) NOT NULL,`role` varchar(255),PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=utf8;", DBConnection)
                        cmd4.Transaction = cmd
                        cmd4.ExecuteNonQuery()
                    End Using
                    Using cmd5 As New MySqlCommand("CREATE TABLE `config` (`id` int(11) NOT NULL AUTO_INCREMENT,`name` varchar(255) NOT NULL,`value` varchar(255) NOT NULL,PRIMARY KEY (`id`)) ENGINE=InnoDB DEFAULT CHARSET=utf8;", DBConnection)
                        cmd5.Transaction = cmd
                        cmd5.ExecuteNonQuery()
                    End Using
                    Using cmd6 As New MySqlCommand("INSERT INTO `users` (`id`, `username`, `password`, `role`) VALUES (NULL, 'admin', '" + NewBaseDialog.AdminPasswordBox.Text + "', 'admin');", DBConnection)
                        cmd6.Transaction = cmd
                        cmd6.ExecuteNonQuery()
                    End Using
                    cmd.Commit()
                Catch ex As MySqlException
                    cmd.Rollback()
                    MessageBox.Show(ex.Message + vbCrLf + ex.SqlState, GetString("DatabaseCreationErrorTitle"), MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
            DBConnection.Close()
        End If
    End Sub
End Class
