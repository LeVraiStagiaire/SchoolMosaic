Imports SchoolMosaic.Server.BaseManager
Imports SchoolMosaic.Server.LocalizationManager
Public Class Form1

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
            ApplicationLogger.Info("Table 'courses' created")
            ApplicationLogger.Info("Finished creating database " + NewBaseDialog.BaseNameBox.Text)
            CloseDatabase()
            If MessageBox.Show("La base à bien été créée. Souhaitez-vous l'ouvrir ?", "Terminé", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            End If
        End If
    End Sub
End Class
