<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectBase
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
        Me.BaseSelectionLabel = New System.Windows.Forms.Label()
        Me.BaseSelectionBox = New System.Windows.Forms.ListBox()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BaseSelectionLabel
        '
        Me.BaseSelectionLabel.AutoSize = True
        Me.BaseSelectionLabel.Location = New System.Drawing.Point(13, 19)
        Me.BaseSelectionLabel.Name = "BaseSelectionLabel"
        Me.BaseSelectionLabel.Size = New System.Drawing.Size(167, 13)
        Me.BaseSelectionLabel.TabIndex = 0
        Me.BaseSelectionLabel.Text = "Veuillez choisir une base à ouvrir :"
        '
        'BaseSelectionBox
        '
        Me.BaseSelectionBox.FormattingEnabled = True
        Me.BaseSelectionBox.Location = New System.Drawing.Point(16, 44)
        Me.BaseSelectionBox.Name = "BaseSelectionBox"
        Me.BaseSelectionBox.Size = New System.Drawing.Size(404, 225)
        Me.BaseSelectionBox.TabIndex = 1
        '
        'OpenButton
        '
        Me.OpenButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OpenButton.Enabled = False
        Me.OpenButton.ForeColor = System.Drawing.Color.Green
        Me.OpenButton.Location = New System.Drawing.Point(344, 290)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenButton.TabIndex = 2
        Me.OpenButton.Text = "Ouvrir"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.ForeColor = System.Drawing.Color.Red
        Me.CancelButton.Location = New System.Drawing.Point(263, 290)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Annuler"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ImportButton
        '
        Me.ImportButton.ForeColor = System.Drawing.Color.Blue
        Me.ImportButton.Location = New System.Drawing.Point(16, 290)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(75, 23)
        Me.ImportButton.TabIndex = 2
        Me.ImportButton.Text = "Importer..."
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'SelectBase
        '
        Me.AcceptButton = Me.OpenButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(432, 325)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.BaseSelectionBox)
        Me.Controls.Add(Me.BaseSelectionLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sélectionnez une base"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BaseSelectionLabel As Label
    Friend WithEvents BaseSelectionBox As ListBox
    Friend WithEvents OpenButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents ImportButton As Button
End Class
