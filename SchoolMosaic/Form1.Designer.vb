<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComServer = New GSF.Communication.TcpServer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServeurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DémarrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrêterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.AppLogo = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ServerStatus = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.OverviewTab = New System.Windows.Forms.TabPage()
        Me.OverviewList = New System.Windows.Forms.ListView()
        Me.UsernameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComputerColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateTimeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ConfigTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ConfigBanner = New System.Windows.Forms.Label()
        Me.EditConfigButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ServerDIsplayNameLabel = New System.Windows.Forms.Label()
        Me.ServerDisplayNameBox = New System.Windows.Forms.TextBox()
        Me.ServerPortLabel = New System.Windows.Forms.Label()
        Me.ServerPortBox = New System.Windows.Forms.NumericUpDown()
        CType(Me.ComServer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.AppLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.OverviewTab.SuspendLayout()
        Me.ConfigTab.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.ServerPortBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComServer
        '
        Me.ComServer.ConfigurationString = "Port=9800"
        Me.ComServer.PersistSettings = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.ServeurToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleBaseToolStripMenuItem, Me.OuvrirBaseToolStripMenuItem, Me.FermerBaseToolStripMenuItem, Me.ToolStripMenuItem1, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'NouvelleBaseToolStripMenuItem
        '
        Me.NouvelleBaseToolStripMenuItem.Name = "NouvelleBaseToolStripMenuItem"
        Me.NouvelleBaseToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NouvelleBaseToolStripMenuItem.Text = "&Nouvelle base..."
        '
        'OuvrirBaseToolStripMenuItem
        '
        Me.OuvrirBaseToolStripMenuItem.Name = "OuvrirBaseToolStripMenuItem"
        Me.OuvrirBaseToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OuvrirBaseToolStripMenuItem.Text = "&Ouvrir base..."
        '
        'FermerBaseToolStripMenuItem
        '
        Me.FermerBaseToolStripMenuItem.Enabled = False
        Me.FermerBaseToolStripMenuItem.Name = "FermerBaseToolStripMenuItem"
        Me.FermerBaseToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.FermerBaseToolStripMenuItem.Text = "&Fermer base"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(154, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.QuitterToolStripMenuItem.Text = "&Quitter"
        '
        'ServeurToolStripMenuItem
        '
        Me.ServeurToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DémarrerToolStripMenuItem, Me.ArrêterToolStripMenuItem})
        Me.ServeurToolStripMenuItem.Name = "ServeurToolStripMenuItem"
        Me.ServeurToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ServeurToolStripMenuItem.Text = "&Serveur"
        '
        'DémarrerToolStripMenuItem
        '
        Me.DémarrerToolStripMenuItem.Enabled = False
        Me.DémarrerToolStripMenuItem.Name = "DémarrerToolStripMenuItem"
        Me.DémarrerToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.DémarrerToolStripMenuItem.Text = "&Démarrer"
        '
        'ArrêterToolStripMenuItem
        '
        Me.ArrêterToolStripMenuItem.Enabled = False
        Me.ArrêterToolStripMenuItem.Name = "ArrêterToolStripMenuItem"
        Me.ArrêterToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ArrêterToolStripMenuItem.Text = "&Arrêter"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 426)
        Me.SplitContainer1.SplitterDistance = 95
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.AppLogo)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(800, 95)
        Me.SplitContainer2.SplitterDistance = 103
        Me.SplitContainer2.TabIndex = 0
        '
        'AppLogo
        '
        Me.AppLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppLogo.Image = Global.SchoolMosaic.Server.My.Resources.Resources.SchoolMosaic_Logo1
        Me.AppLogo.Location = New System.Drawing.Point(0, 0)
        Me.AppLogo.Name = "AppLogo"
        Me.AppLogo.Size = New System.Drawing.Size(103, 95)
        Me.AppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppLogo.TabIndex = 0
        Me.AppLogo.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ServerStatus)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(693, 95)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ServerStatus
        '
        Me.ServerStatus.AutoSize = True
        Me.ServerStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerStatus.Location = New System.Drawing.Point(8, 5)
        Me.ServerStatus.Name = "ServerStatus"
        Me.ServerStatus.Size = New System.Drawing.Size(164, 26)
        Me.ServerStatus.TabIndex = 0
        Me.ServerStatus.Text = "Serveur arrêté"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.OverviewTab)
        Me.TabControl1.Controls.Add(Me.ConfigTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(800, 327)
        Me.TabControl1.TabIndex = 0
        '
        'OverviewTab
        '
        Me.OverviewTab.Controls.Add(Me.OverviewList)
        Me.OverviewTab.Location = New System.Drawing.Point(23, 4)
        Me.OverviewTab.Name = "OverviewTab"
        Me.OverviewTab.Padding = New System.Windows.Forms.Padding(3)
        Me.OverviewTab.Size = New System.Drawing.Size(773, 319)
        Me.OverviewTab.TabIndex = 0
        Me.OverviewTab.Text = "Aperçu"
        Me.OverviewTab.UseVisualStyleBackColor = True
        '
        'OverviewList
        '
        Me.OverviewList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.UsernameColumn, Me.ComputerColumn, Me.DateTimeColumn})
        Me.OverviewList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OverviewList.HideSelection = False
        Me.OverviewList.Location = New System.Drawing.Point(3, 3)
        Me.OverviewList.Name = "OverviewList"
        Me.OverviewList.Size = New System.Drawing.Size(767, 313)
        Me.OverviewList.TabIndex = 0
        Me.OverviewList.UseCompatibleStateImageBehavior = False
        Me.OverviewList.View = System.Windows.Forms.View.Details
        '
        'UsernameColumn
        '
        Me.UsernameColumn.Text = "Nom d'utilisateur"
        Me.UsernameColumn.Width = 123
        '
        'ComputerColumn
        '
        Me.ComputerColumn.Text = "Poste"
        Me.ComputerColumn.Width = 115
        '
        'DateTimeColumn
        '
        Me.DateTimeColumn.Text = "Heure de connexion"
        Me.DateTimeColumn.Width = 108
        '
        'ConfigTab
        '
        Me.ConfigTab.Controls.Add(Me.TableLayoutPanel1)
        Me.ConfigTab.Location = New System.Drawing.Point(23, 4)
        Me.ConfigTab.Name = "ConfigTab"
        Me.ConfigTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ConfigTab.Size = New System.Drawing.Size(773, 319)
        Me.ConfigTab.TabIndex = 1
        Me.ConfigTab.Text = "Configuration"
        Me.ConfigTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ConfigBanner, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EditConfigButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(767, 313)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ConfigBanner
        '
        Me.ConfigBanner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfigBanner.Location = New System.Drawing.Point(3, 0)
        Me.ConfigBanner.Name = "ConfigBanner"
        Me.ConfigBanner.Size = New System.Drawing.Size(667, 35)
        Me.ConfigBanner.TabIndex = 0
        Me.ConfigBanner.Text = "Pour modifier la configuration, vous devez entrer un mot de passe administrateur"
        Me.ConfigBanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EditConfigButton
        '
        Me.EditConfigButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EditConfigButton.Location = New System.Drawing.Point(682, 6)
        Me.EditConfigButton.Name = "EditConfigButton"
        Me.EditConfigButton.Size = New System.Drawing.Size(75, 23)
        Me.EditConfigButton.TabIndex = 1
        Me.EditConfigButton.Text = "Modifier..."
        Me.EditConfigButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoScroll = True
        Me.FlowLayoutPanel2.Controls.Add(Me.ServerDIsplayNameLabel)
        Me.FlowLayoutPanel2.Controls.Add(Me.ServerDisplayNameBox)
        Me.FlowLayoutPanel2.Controls.Add(Me.ServerPortLabel)
        Me.FlowLayoutPanel2.Controls.Add(Me.ServerPortBox)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Enabled = False
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 38)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(667, 272)
        Me.FlowLayoutPanel2.TabIndex = 2
        Me.FlowLayoutPanel2.WrapContents = False
        '
        'ServerDIsplayNameLabel
        '
        Me.ServerDIsplayNameLabel.AutoSize = True
        Me.ServerDIsplayNameLabel.Location = New System.Drawing.Point(13, 10)
        Me.ServerDIsplayNameLabel.Name = "ServerDIsplayNameLabel"
        Me.ServerDIsplayNameLabel.Size = New System.Drawing.Size(143, 13)
        Me.ServerDIsplayNameLabel.TabIndex = 0
        Me.ServerDIsplayNameLabel.Text = "Nom d'affichage du serveur :"
        '
        'ServerDisplayNameBox
        '
        Me.ServerDisplayNameBox.Location = New System.Drawing.Point(13, 26)
        Me.ServerDisplayNameBox.Name = "ServerDisplayNameBox"
        Me.ServerDisplayNameBox.Size = New System.Drawing.Size(622, 20)
        Me.ServerDisplayNameBox.TabIndex = 1
        '
        'ServerPortLabel
        '
        Me.ServerPortLabel.AutoSize = True
        Me.ServerPortLabel.Location = New System.Drawing.Point(13, 59)
        Me.ServerPortLabel.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.ServerPortLabel.Name = "ServerPortLabel"
        Me.ServerPortLabel.Size = New System.Drawing.Size(32, 13)
        Me.ServerPortLabel.TabIndex = 2
        Me.ServerPortLabel.Text = "Port :"
        '
        'ServerPortBox
        '
        Me.ServerPortBox.Location = New System.Drawing.Point(13, 75)
        Me.ServerPortBox.Name = "ServerPortBox"
        Me.ServerPortBox.Size = New System.Drawing.Size(194, 20)
        Me.ServerPortBox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "SchoolMosaic Serveur"
        CType(Me.ComServer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.AppLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.OverviewTab.ResumeLayout(False)
        Me.ConfigTab.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.ServerPortBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComServer As GSF.Communication.TcpServer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NouvelleBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FermerBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServeurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DémarrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArrêterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents AppLogo As PictureBox
    Friend WithEvents ServerStatus As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents OverviewTab As TabPage
    Friend WithEvents ConfigTab As TabPage
    Friend WithEvents OverviewList As ListView
    Friend WithEvents UsernameColumn As ColumnHeader
    Friend WithEvents ComputerColumn As ColumnHeader
    Friend WithEvents DateTimeColumn As ColumnHeader
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ConfigBanner As Label
    Friend WithEvents EditConfigButton As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ServerDIsplayNameLabel As Label
    Friend WithEvents ServerDisplayNameBox As TextBox
    Friend WithEvents ServerPortLabel As Label
    Friend WithEvents ServerPortBox As NumericUpDown
End Class
