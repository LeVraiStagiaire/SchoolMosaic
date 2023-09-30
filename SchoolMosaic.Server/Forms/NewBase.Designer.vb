<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBase
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.WorkDays = New System.Windows.Forms.Label()
        Me.Monday = New System.Windows.Forms.CheckBox()
        Me.Tuesday = New System.Windows.Forms.CheckBox()
        Me.Wednesday = New System.Windows.Forms.CheckBox()
        Me.Thursday = New System.Windows.Forms.CheckBox()
        Me.Friday = New System.Windows.Forms.CheckBox()
        Me.Saturday = New System.Windows.Forms.CheckBox()
        Me.Sunday = New System.Windows.Forms.CheckBox()
        Me.DailySessions = New System.Windows.Forms.Label()
        Me.DailySessionsText1 = New System.Windows.Forms.Label()
        Me.DailySessionNumber = New System.Windows.Forms.ComboBox()
        Me.DailySessionText2 = New System.Windows.Forms.Label()
        Me.DailySessionTime = New System.Windows.Forms.NumericUpDown()
        Me.DailySessionText3 = New System.Windows.Forms.Label()
        Me.DailySessionText4 = New System.Windows.Forms.Label()
        Me.DailySessionStart = New System.Windows.Forms.DateTimePicker()
        Me.DailySessionText5 = New System.Windows.Forms.Label()
        Me.DailySessionStop = New System.Windows.Forms.DateTimePicker()
        Me.LunchBreakBox = New System.Windows.Forms.CheckBox()
        Me.LunchBreakStart = New System.Windows.Forms.DateTimePicker()
        Me.LunchBreakText2 = New System.Windows.Forms.Label()
        Me.LunchBreakStop = New System.Windows.Forms.DateTimePicker()
        Me.FirstDayBox = New System.Windows.Forms.ComboBox()
        Me.FirstDayLabel = New System.Windows.Forms.Label()
        Me.AdminPasswordLabel = New System.Windows.Forms.Label()
        Me.AdminPasswordBox = New System.Windows.Forms.MaskedTextBox()
        Me.RepeatPasswordLabel = New System.Windows.Forms.Label()
        Me.RepeatPasswordBox = New System.Windows.Forms.MaskedTextBox()
        Me.BaseNameLabel = New System.Windows.Forms.Label()
        Me.BaseNameBox = New System.Windows.Forms.TextBox()
        CType(Me.DailySessionTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CreateButton
        '
        Me.CreateButton.ForeColor = System.Drawing.Color.Green
        Me.CreateButton.Location = New System.Drawing.Point(362, 515)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateButton.TabIndex = 19
        Me.CreateButton.Text = "&Créer"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.ForeColor = System.Drawing.Color.Red
        Me.CancelButton.Location = New System.Drawing.Point(281, 515)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 20
        Me.CancelButton.Text = "&Annuler"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'WorkDays
        '
        Me.WorkDays.AutoSize = True
        Me.WorkDays.Location = New System.Drawing.Point(24, 31)
        Me.WorkDays.Name = "WorkDays"
        Me.WorkDays.Size = New System.Drawing.Size(82, 13)
        Me.WorkDays.TabIndex = 2
        Me.WorkDays.Text = "Jours travaillés :"
        '
        'Monday
        '
        Me.Monday.AutoSize = True
        Me.Monday.Checked = True
        Me.Monday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Monday.Location = New System.Drawing.Point(27, 54)
        Me.Monday.Name = "Monday"
        Me.Monday.Size = New System.Drawing.Size(52, 17)
        Me.Monday.TabIndex = 1
        Me.Monday.Text = "Lundi"
        Me.Monday.UseVisualStyleBackColor = True
        '
        'Tuesday
        '
        Me.Tuesday.AutoSize = True
        Me.Tuesday.Checked = True
        Me.Tuesday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Tuesday.Location = New System.Drawing.Point(27, 77)
        Me.Tuesday.Name = "Tuesday"
        Me.Tuesday.Size = New System.Drawing.Size(52, 17)
        Me.Tuesday.TabIndex = 2
        Me.Tuesday.Text = "Mardi"
        Me.Tuesday.UseVisualStyleBackColor = True
        '
        'Wednesday
        '
        Me.Wednesday.AutoSize = True
        Me.Wednesday.Checked = True
        Me.Wednesday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Wednesday.Location = New System.Drawing.Point(27, 100)
        Me.Wednesday.Name = "Wednesday"
        Me.Wednesday.Size = New System.Drawing.Size(67, 17)
        Me.Wednesday.TabIndex = 3
        Me.Wednesday.Text = "Mercredi"
        Me.Wednesday.UseVisualStyleBackColor = True
        '
        'Thursday
        '
        Me.Thursday.AutoSize = True
        Me.Thursday.Checked = True
        Me.Thursday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Thursday.Location = New System.Drawing.Point(27, 124)
        Me.Thursday.Name = "Thursday"
        Me.Thursday.Size = New System.Drawing.Size(51, 17)
        Me.Thursday.TabIndex = 4
        Me.Thursday.Text = "Jeudi"
        Me.Thursday.UseVisualStyleBackColor = True
        '
        'Friday
        '
        Me.Friday.AutoSize = True
        Me.Friday.Checked = True
        Me.Friday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Friday.Location = New System.Drawing.Point(148, 54)
        Me.Friday.Name = "Friday"
        Me.Friday.Size = New System.Drawing.Size(68, 17)
        Me.Friday.TabIndex = 5
        Me.Friday.Text = "Vendredi"
        Me.Friday.UseVisualStyleBackColor = True
        '
        'Saturday
        '
        Me.Saturday.AutoSize = True
        Me.Saturday.Location = New System.Drawing.Point(148, 77)
        Me.Saturday.Name = "Saturday"
        Me.Saturday.Size = New System.Drawing.Size(61, 17)
        Me.Saturday.TabIndex = 6
        Me.Saturday.Text = "Samedi"
        Me.Saturday.UseVisualStyleBackColor = True
        '
        'Sunday
        '
        Me.Sunday.AutoSize = True
        Me.Sunday.Location = New System.Drawing.Point(148, 100)
        Me.Sunday.Name = "Sunday"
        Me.Sunday.Size = New System.Drawing.Size(74, 17)
        Me.Sunday.TabIndex = 7
        Me.Sunday.Text = "Dimanche"
        Me.Sunday.UseVisualStyleBackColor = True
        '
        'DailySessions
        '
        Me.DailySessions.AutoSize = True
        Me.DailySessions.Location = New System.Drawing.Point(24, 176)
        Me.DailySessions.Name = "DailySessions"
        Me.DailySessions.Size = New System.Drawing.Size(111, 13)
        Me.DailySessions.TabIndex = 10
        Me.DailySessions.Text = "Séances journalières :"
        '
        'DailySessionsText1
        '
        Me.DailySessionsText1.AutoSize = True
        Me.DailySessionsText1.Location = New System.Drawing.Point(41, 209)
        Me.DailySessionsText1.Name = "DailySessionsText1"
        Me.DailySessionsText1.Size = New System.Drawing.Size(102, 13)
        Me.DailySessionsText1.TabIndex = 11
        Me.DailySessionsText1.Text = "Chaque jour compte"
        '
        'DailySessionNumber
        '
        Me.DailySessionNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DailySessionNumber.FormattingEnabled = True
        Me.DailySessionNumber.Items.AddRange(New Object() {"1 séance", "2 séances", "3 séances", "4 séances", "5 séances", "6 séances", "7 séances", "8 séances", "9 séances", "10 séances", "11 séances", "12 séances", "13 séances", "14 séances", "15 séances"})
        Me.DailySessionNumber.Location = New System.Drawing.Point(148, 206)
        Me.DailySessionNumber.Name = "DailySessionNumber"
        Me.DailySessionNumber.Size = New System.Drawing.Size(121, 21)
        Me.DailySessionNumber.TabIndex = 9
        '
        'DailySessionText2
        '
        Me.DailySessionText2.AutoSize = True
        Me.DailySessionText2.Location = New System.Drawing.Point(275, 209)
        Me.DailySessionText2.Name = "DailySessionText2"
        Me.DailySessionText2.Size = New System.Drawing.Size(19, 13)
        Me.DailySessionText2.TabIndex = 13
        Me.DailySessionText2.Text = "de"
        '
        'DailySessionTime
        '
        Me.DailySessionTime.Increment = New Decimal(New Integer() {30, 0, 0, 0})
        Me.DailySessionTime.Location = New System.Drawing.Point(300, 207)
        Me.DailySessionTime.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.DailySessionTime.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DailySessionTime.Name = "DailySessionTime"
        Me.DailySessionTime.Size = New System.Drawing.Size(56, 20)
        Me.DailySessionTime.TabIndex = 10
        Me.DailySessionTime.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'DailySessionText3
        '
        Me.DailySessionText3.AutoSize = True
        Me.DailySessionText3.Location = New System.Drawing.Point(362, 209)
        Me.DailySessionText3.Name = "DailySessionText3"
        Me.DailySessionText3.Size = New System.Drawing.Size(46, 13)
        Me.DailySessionText3.TabIndex = 15
        Me.DailySessionText3.Text = "minutes."
        '
        'DailySessionText4
        '
        Me.DailySessionText4.AutoSize = True
        Me.DailySessionText4.Location = New System.Drawing.Point(41, 237)
        Me.DailySessionText4.Name = "DailySessionText4"
        Me.DailySessionText4.Size = New System.Drawing.Size(32, 13)
        Me.DailySessionText4.TabIndex = 16
        Me.DailySessionText4.Text = "Entre"
        '
        'DailySessionStart
        '
        Me.DailySessionStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DailySessionStart.Location = New System.Drawing.Point(82, 234)
        Me.DailySessionStart.Name = "DailySessionStart"
        Me.DailySessionStart.ShowUpDown = True
        Me.DailySessionStart.Size = New System.Drawing.Size(147, 20)
        Me.DailySessionStart.TabIndex = 11
        Me.DailySessionStart.Value = New Date(2023, 8, 29, 8, 0, 0, 0)
        '
        'DailySessionText5
        '
        Me.DailySessionText5.AutoSize = True
        Me.DailySessionText5.Location = New System.Drawing.Point(235, 237)
        Me.DailySessionText5.Name = "DailySessionText5"
        Me.DailySessionText5.Size = New System.Drawing.Size(16, 13)
        Me.DailySessionText5.TabIndex = 18
        Me.DailySessionText5.Text = "et"
        '
        'DailySessionStop
        '
        Me.DailySessionStop.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DailySessionStop.Location = New System.Drawing.Point(257, 234)
        Me.DailySessionStop.Name = "DailySessionStop"
        Me.DailySessionStop.ShowUpDown = True
        Me.DailySessionStop.Size = New System.Drawing.Size(146, 20)
        Me.DailySessionStop.TabIndex = 12
        Me.DailySessionStop.Value = New Date(2023, 8, 29, 17, 0, 0, 0)
        '
        'LunchBreakBox
        '
        Me.LunchBreakBox.AutoSize = True
        Me.LunchBreakBox.Checked = True
        Me.LunchBreakBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LunchBreakBox.Location = New System.Drawing.Point(44, 269)
        Me.LunchBreakBox.Name = "LunchBreakBox"
        Me.LunchBreakBox.Size = New System.Drawing.Size(137, 17)
        Me.LunchBreakBox.TabIndex = 13
        Me.LunchBreakBox.Text = "Pause méridienne entre"
        Me.LunchBreakBox.UseVisualStyleBackColor = True
        '
        'LunchBreakStart
        '
        Me.LunchBreakStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.LunchBreakStart.Location = New System.Drawing.Point(187, 266)
        Me.LunchBreakStart.Name = "LunchBreakStart"
        Me.LunchBreakStart.ShowUpDown = True
        Me.LunchBreakStart.Size = New System.Drawing.Size(94, 20)
        Me.LunchBreakStart.TabIndex = 14
        Me.LunchBreakStart.Value = New Date(2023, 8, 29, 12, 0, 0, 0)
        '
        'LunchBreakText2
        '
        Me.LunchBreakText2.AutoSize = True
        Me.LunchBreakText2.Location = New System.Drawing.Point(287, 269)
        Me.LunchBreakText2.Name = "LunchBreakText2"
        Me.LunchBreakText2.Size = New System.Drawing.Size(16, 13)
        Me.LunchBreakText2.TabIndex = 20
        Me.LunchBreakText2.Text = "et"
        '
        'LunchBreakStop
        '
        Me.LunchBreakStop.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.LunchBreakStop.Location = New System.Drawing.Point(309, 266)
        Me.LunchBreakStop.Name = "LunchBreakStop"
        Me.LunchBreakStop.ShowUpDown = True
        Me.LunchBreakStop.Size = New System.Drawing.Size(94, 20)
        Me.LunchBreakStop.TabIndex = 15
        Me.LunchBreakStop.Value = New Date(2023, 8, 29, 13, 0, 0, 0)
        '
        'FirstDayBox
        '
        Me.FirstDayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FirstDayBox.FormattingEnabled = True
        Me.FirstDayBox.Items.AddRange(New Object() {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi"})
        Me.FirstDayBox.Location = New System.Drawing.Point(260, 75)
        Me.FirstDayBox.Name = "FirstDayBox"
        Me.FirstDayBox.Size = New System.Drawing.Size(143, 21)
        Me.FirstDayBox.TabIndex = 8
        '
        'FirstDayLabel
        '
        Me.FirstDayLabel.AutoSize = True
        Me.FirstDayLabel.Location = New System.Drawing.Point(257, 54)
        Me.FirstDayLabel.Name = "FirstDayLabel"
        Me.FirstDayLabel.Size = New System.Drawing.Size(136, 13)
        Me.FirstDayLabel.TabIndex = 22
        Me.FirstDayLabel.Text = "Premier jour de la semaine :"
        '
        'AdminPasswordLabel
        '
        Me.AdminPasswordLabel.AutoSize = True
        Me.AdminPasswordLabel.Location = New System.Drawing.Point(27, 331)
        Me.AdminPasswordLabel.Name = "AdminPasswordLabel"
        Me.AdminPasswordLabel.Size = New System.Drawing.Size(145, 13)
        Me.AdminPasswordLabel.TabIndex = 23
        Me.AdminPasswordLabel.Text = "Mot de passe administrateur :"
        '
        'AdminPasswordBox
        '
        Me.AdminPasswordBox.Location = New System.Drawing.Point(30, 348)
        Me.AdminPasswordBox.Name = "AdminPasswordBox"
        Me.AdminPasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.AdminPasswordBox.Size = New System.Drawing.Size(373, 20)
        Me.AdminPasswordBox.TabIndex = 16
        '
        'RepeatPasswordLabel
        '
        Me.RepeatPasswordLabel.AutoSize = True
        Me.RepeatPasswordLabel.Location = New System.Drawing.Point(27, 388)
        Me.RepeatPasswordLabel.Name = "RepeatPasswordLabel"
        Me.RepeatPasswordLabel.Size = New System.Drawing.Size(128, 13)
        Me.RepeatPasswordLabel.TabIndex = 25
        Me.RepeatPasswordLabel.Text = "Répéter le mot de passe :"
        '
        'RepeatPasswordBox
        '
        Me.RepeatPasswordBox.Location = New System.Drawing.Point(30, 404)
        Me.RepeatPasswordBox.Name = "RepeatPasswordBox"
        Me.RepeatPasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.RepeatPasswordBox.Size = New System.Drawing.Size(373, 20)
        Me.RepeatPasswordBox.TabIndex = 17
        '
        'BaseNameLabel
        '
        Me.BaseNameLabel.AutoSize = True
        Me.BaseNameLabel.Location = New System.Drawing.Point(27, 455)
        Me.BaseNameLabel.Name = "BaseNameLabel"
        Me.BaseNameLabel.Size = New System.Drawing.Size(87, 13)
        Me.BaseNameLabel.TabIndex = 26
        Me.BaseNameLabel.Text = "Nom de la base :"
        '
        'BaseNameBox
        '
        Me.BaseNameBox.Location = New System.Drawing.Point(30, 472)
        Me.BaseNameBox.Name = "BaseNameBox"
        Me.BaseNameBox.Size = New System.Drawing.Size(373, 20)
        Me.BaseNameBox.TabIndex = 18
        '
        'NewBase
        '
        Me.AcceptButton = Me.CreateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 550)
        Me.Controls.Add(Me.BaseNameBox)
        Me.Controls.Add(Me.BaseNameLabel)
        Me.Controls.Add(Me.RepeatPasswordLabel)
        Me.Controls.Add(Me.RepeatPasswordBox)
        Me.Controls.Add(Me.AdminPasswordBox)
        Me.Controls.Add(Me.AdminPasswordLabel)
        Me.Controls.Add(Me.FirstDayLabel)
        Me.Controls.Add(Me.FirstDayBox)
        Me.Controls.Add(Me.LunchBreakText2)
        Me.Controls.Add(Me.LunchBreakBox)
        Me.Controls.Add(Me.DailySessionText5)
        Me.Controls.Add(Me.DailySessionStop)
        Me.Controls.Add(Me.LunchBreakStop)
        Me.Controls.Add(Me.LunchBreakStart)
        Me.Controls.Add(Me.DailySessionStart)
        Me.Controls.Add(Me.DailySessionText4)
        Me.Controls.Add(Me.DailySessionText3)
        Me.Controls.Add(Me.DailySessionTime)
        Me.Controls.Add(Me.DailySessionText2)
        Me.Controls.Add(Me.DailySessionNumber)
        Me.Controls.Add(Me.DailySessionsText1)
        Me.Controls.Add(Me.DailySessions)
        Me.Controls.Add(Me.Sunday)
        Me.Controls.Add(Me.Saturday)
        Me.Controls.Add(Me.Friday)
        Me.Controls.Add(Me.Thursday)
        Me.Controls.Add(Me.Wednesday)
        Me.Controls.Add(Me.Tuesday)
        Me.Controls.Add(Me.Monday)
        Me.Controls.Add(Me.WorkDays)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.CreateButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nouvelle base"
        CType(Me.DailySessionTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CreateButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents WorkDays As Label
    Friend WithEvents Monday As CheckBox
    Friend WithEvents Tuesday As CheckBox
    Friend WithEvents Wednesday As CheckBox
    Friend WithEvents Thursday As CheckBox
    Friend WithEvents Friday As CheckBox
    Friend WithEvents Saturday As CheckBox
    Friend WithEvents Sunday As CheckBox
    Friend WithEvents DailySessions As Label
    Friend WithEvents DailySessionsText1 As Label
    Friend WithEvents DailySessionNumber As ComboBox
    Friend WithEvents DailySessionText2 As Label
    Friend WithEvents DailySessionTime As NumericUpDown
    Friend WithEvents DailySessionText3 As Label
    Friend WithEvents DailySessionText4 As Label
    Friend WithEvents DailySessionStart As DateTimePicker
    Friend WithEvents DailySessionText5 As Label
    Friend WithEvents DailySessionStop As DateTimePicker
    Friend WithEvents LunchBreakBox As CheckBox
    Friend WithEvents LunchBreakStart As DateTimePicker
    Friend WithEvents LunchBreakText2 As Label
    Friend WithEvents LunchBreakStop As DateTimePicker
    Friend WithEvents FirstDayBox As ComboBox
    Friend WithEvents FirstDayLabel As Label
    Friend WithEvents AdminPasswordLabel As Label
    Friend WithEvents AdminPasswordBox As MaskedTextBox
    Friend WithEvents RepeatPasswordLabel As Label
    Friend WithEvents RepeatPasswordBox As MaskedTextBox
    Friend WithEvents BaseNameLabel As Label
    Friend WithEvents BaseNameBox As TextBox
End Class
