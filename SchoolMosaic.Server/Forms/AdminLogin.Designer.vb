<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Me.WarningImage = New System.Windows.Forms.PictureBox()
        Me.WarningText = New System.Windows.Forms.Label()
        Me.UsernameText = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.WarningImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WarningImage
        '
        Me.WarningImage.Image = Global.SchoolMosaic.Server.My.Resources.Resources.srchadmin_202
        Me.WarningImage.Location = New System.Drawing.Point(31, 31)
        Me.WarningImage.Name = "WarningImage"
        Me.WarningImage.Size = New System.Drawing.Size(32, 32)
        Me.WarningImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.WarningImage.TabIndex = 0
        Me.WarningImage.TabStop = False
        '
        'WarningText
        '
        Me.WarningText.Location = New System.Drawing.Point(70, 31)
        Me.WarningText.Name = "WarningText"
        Me.WarningText.Size = New System.Drawing.Size(246, 32)
        Me.WarningText.TabIndex = 1
        Me.WarningText.Text = "Vous devez entrer un mot de passe administrateur pour pouvoir effectuer cette act" &
    "ion :"
        '
        'UsernameText
        '
        Me.UsernameText.Location = New System.Drawing.Point(31, 111)
        Me.UsernameText.Name = "UsernameText"
        Me.UsernameText.Size = New System.Drawing.Size(285, 20)
        Me.UsernameText.TabIndex = 1
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(31, 92)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(90, 13)
        Me.UsernameLabel.TabIndex = 3
        Me.UsernameLabel.Text = "Nom d'utilisateur :"
        '
        'PasswordText
        '
        Me.PasswordText.Location = New System.Drawing.Point(31, 173)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordText.Size = New System.Drawing.Size(285, 20)
        Me.PasswordText.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(31, 154)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(77, 13)
        Me.PasswordLabel.TabIndex = 3
        Me.PasswordLabel.Text = "Mot de passe :"
        '
        'OKButton
        '
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKButton.ForeColor = System.Drawing.Color.Green
        Me.OKButton.Location = New System.Drawing.Point(256, 221)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 3
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.ForeColor = System.Drawing.Color.Red
        Me.CancelButton.Location = New System.Drawing.Point(175, 220)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 4
        Me.CancelButton.Text = "&Annuler"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AdminLogin
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(343, 256)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.UsernameText)
        Me.Controls.Add(Me.WarningText)
        Me.Controls.Add(Me.WarningImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrez un mot de passe"
        CType(Me.WarningImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WarningImage As PictureBox
    Friend WithEvents WarningText As Label
    Friend WithEvents UsernameText As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents CancelButton As Button
End Class
