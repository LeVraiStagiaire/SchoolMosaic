Imports SchoolMosaic.Server.BaseManager
Imports SchoolMosaic.Server.LocalizationManager
Public Class MainForm

    Dim GUILogger As New Logger("GUI")
    Dim ApplicationLogger As New Logger("Application")
    Dim ServerLogger As New Logger("TCPServer")

    Dim AdminLoggedIn As Boolean = False
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
        ServerStatus.Text = GetString("NoBase")
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

        ConfigTab.Enabled = False
    End Sub

    Private Sub NouvelleBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouvelleBaseToolStripMenuItem.Click
        Dim NewBaseDialog As New NewBase
        GUILogger.Debug("Opening new base dialog")
        If NewBaseDialog.ShowDialog() = DialogResult.OK Then
            GUILogger.Debug("Result: OK")
            ApplicationLogger.Info("Creating new database " + NewBaseDialog.BaseNameBox.Text + "...")
            OpenDatabase()
            CreateDatabase(NewBaseDialog.BaseNameBox.Text)
            ApplicationLogger.Info("Database " + NewBaseDialog.BaseNameBox.Text + " created")
            ApplicationLogger.Info("Creating table 'users'")
            CreateTable("users", New List(Of Column) From {
                New Column("id", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.PrimaryKey, Column.Attribute.AutoIncrement}),
                New Column("username", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("password", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("role", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull})
            },
            New List(Of List(Of String)) From {
                New List(Of String) From {
                    "NULL",
                    "admin",
                    NewBaseDialog.AdminPasswordBox.Text,
                    "admin"
                }
            })
            ApplicationLogger.Info("Table 'users' created")
            ApplicationLogger.Info("Creating table 'config'")
            CreateTable("config", New List(Of Column) From {
                New Column("id", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.PrimaryKey, Column.Attribute.AutoIncrement, Column.Attribute.NotNull}),
                New Column("name", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("value", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull})
            },
            New List(Of List(Of String)) From {
                New List(Of String) From {
                    "NULL",
                    "server_display_name",
                    NewBaseDialog.BaseNameBox.Text
                },
                New List(Of String) From {
                    "NULL",
                    "days_of_work",
                    If(NewBaseDialog.Monday.Checked, "1", "") + If(NewBaseDialog.Tuesday.Checked, "2", "") + If(NewBaseDialog.Wednesday.Checked, "3", "") + If(NewBaseDialog.Thursday.Checked, "4", "") + If(NewBaseDialog.Friday.Checked, "5", "") + If(NewBaseDialog.Saturday.Checked, "6", "") + If(NewBaseDialog.Sunday.Checked, "7", "")
                },
                New List(Of String) From {
                    "NULL",
                    "first_day",
                    NewBaseDialog.FirstDayBox.SelectedItem
                },
                New List(Of String) From {
                    "NULL",
                    "server_port",
                    "23654"
                }
            })
            ApplicationLogger.Info("Table 'config' created")
            ApplicationLogger.Info("Creating table 'students'")
            CreateTable("students", New List(Of Column) From {
                New Column("id", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.PrimaryKey, Column.Attribute.AutoIncrement, Column.Attribute.NotNull}),
                New Column("firstname", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("lastname", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("birthday", "date", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("address", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("phone", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("email", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("class", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.NotNull})
            })
            ApplicationLogger.Info("Table 'students' created")
            ApplicationLogger.Info("Creating table 'classes'")
            CreateTable("classes", New List(Of Column) From {
                New Column("id", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.PrimaryKey, Column.Attribute.AutoIncrement, Column.Attribute.NotNull}),
                New Column("displayname", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("level", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("teacher", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.NotNull})
            })
            ApplicationLogger.Info("Table 'classes' created")
            ApplicationLogger.Info("Creating table 'teachers'")
            CreateTable("teachers", New List(Of Column) From {
                New Column("id", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.PrimaryKey, Column.Attribute.AutoIncrement, Column.Attribute.NotNull}),
                New Column("firstname", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("lastname", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("birthday", "date", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("address", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("phone", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("email", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("subject", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull})
            })
            ApplicationLogger.Info("Table 'teachers' created")
            ApplicationLogger.Info("Creating table 'courses'")
            CreateTable("courses", New List(Of Column) From {
                New Column("id", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.PrimaryKey, Column.Attribute.AutoIncrement, Column.Attribute.NotNull}),
                New Column("subject", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("teacher", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("class", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("room", "varchar(255)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("day", "int(11)", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("start", "time", New List(Of Column.Attribute) From {Column.Attribute.NotNull}),
                New Column("end", "time", New List(Of Column.Attribute) From {Column.Attribute.NotNull})
            })
            ApplicationLogger.Info("Table 'courses' created")
            ApplicationLogger.Debug("Creating tables references")
            AddReferences("students", New List(Of Reference) From {
                New Reference("class", "classes", "id")
            })
            AddReferences("classes", New List(Of Reference) From {
                New Reference("teacher", "teachers", "id")
            })
            AddReferences("courses", New List(Of Reference) From {
                New Reference("teacher", "teachers", "id"),
                New Reference("class", "classes", "id")
            })
            ApplicationLogger.Info("Finished creating database " + NewBaseDialog.BaseNameBox.Text)
            If MessageBox.Show("La base à bien été créée. Souhaitez-vous l'ouvrir ?", "Terminé", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                FermerBaseToolStripMenuItem.Enabled = True
                DémarrerToolStripMenuItem.Enabled = True
                ServerStatus.Text = GetString("ServerStatusOff")
                ConfigTab.Enabled = True
                ServerDisplayNameBox.Text = GetConfig("server_display_name")
                ServerPortBox.Value = GetConfig("server_port")
            Else
                CloseDatabase()
            End If
        End If
    End Sub

    Private Sub EditConfigButton_Click(sender As Object, e As EventArgs) Handles EditConfigButton.Click
        If AdminLoggedIn Then
            SetConfig("server_display_name", ServerDisplayNameBox.Text)
            SetConfig("server_port", ServerPortBox.Value.ToString)
            EditConfigButton.Text = "Modifier..."
            AdminLoggedIn = False
            FlowLayoutPanel2.Enabled = False
        Else
            GUILogger.Debug("Opening AdminLogin dialog...")
            If AdminLogin.ShowDialog = DialogResult.OK Then
                GUILogger.Debug("Result: OK")
                ApplicationLogger.Debug("Checking provided username and password...")
                If UserManager.CheckAdminPassword(AdminLogin.UsernameText.Text, AdminLogin.PasswordText.Text) Then
                    ApplicationLogger.Debug("Provided user is admin and password is correct")
                    AdminLogin.UsernameText.Clear()
                    AdminLogin.PasswordText.Clear()
                    FlowLayoutPanel2.Enabled = True
                    AdminLoggedIn = True
                    EditConfigButton.Text = "Appliquer"
                Else
                    ApplicationLogger.Debug("Provided user is not admin or password is incorrect")
                    MessageBox.Show("Le mot de pass entré est incorrect ou l'utilisateur n'est pas administrateur. Veuillez réessayer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    EditConfigButton.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub OuvrirBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirBaseToolStripMenuItem.Click
        If SelectBase.ShowDialog() = DialogResult.OK Then
            OpenDatabase()
            UseDatabase("sm_" + SelectBase.BaseSelectionBox.SelectedItems(0).ToString)
            SelectBase.BaseSelectionBox.Items.Clear()
            FermerBaseToolStripMenuItem.Enabled = True
            DémarrerToolStripMenuItem.Enabled = True
            ServerDisplayNameBox.Text = GetConfig("server_display_name")
            ServerPortBox.Value = GetConfig("server_port")
            ServerStatus.Text = GetString("ServerStatusOff")
            ConfigTab.Enabled = True
        End If
    End Sub

    Private Sub FermerBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FermerBaseToolStripMenuItem.Click
        CloseDatabase()
        ConfigTab.Enabled = False
        ServerDisplayNameBox.Clear()
        ServerPortBox.Value = 1
        ServerStatus.Text = GetString("NoBase")
        FermerBaseToolStripMenuItem.Enabled = False
        DémarrerToolStripMenuItem.Enabled = False
    End Sub

    Private Sub DémarrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DémarrerToolStripMenuItem.Click
        ComServer.ConfigurationString = "Port=" + GetConfig("server_port")
        ServerLogger.Debug("Initializing server...")
        ComServer.Initialize()
        ServerLogger.Debug("Server initialized!")
        ServerLogger.Info("Starting TCP server...")
        ComServer.Start()
    End Sub

    Private Sub ComServer_ServerStarted(sender As Object, e As EventArgs) Handles ComServer.ServerStarted
        ServerLogger.Info("TCP server started!")
        ServerStatus.Text = GetString("ServerStatusOn")
        DémarrerToolStripMenuItem.Enabled = False
        ArrêterToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ArrêterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrêterToolStripMenuItem.Click
        ServerLogger.Info("Stopping TCP server...")
        ComServer.Stop()
    End Sub

    Private Sub ComServer_ServerStopped(sender As Object, e As EventArgs) Handles ComServer.ServerStopped
        ServerLogger.Info("TCP server stopped!")
        ServerStatus.Text = GetString("ServerStatusOff")
        DémarrerToolStripMenuItem.Enabled = True
        ArrêterToolStripMenuItem.Enabled = False
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        If ComServer.CurrentState = GSF.Communication.ServerState.Running Then
            ComServer.Stop()
        End If
        End
    End Sub
End Class
