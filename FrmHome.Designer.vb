<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCompile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSolution = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenJSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetrieveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBoxRelease = New System.Windows.Forms.ToolStripComboBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.grd = New System.Windows.Forms.ListBox()
        Me.BtnCompile = New System.Windows.Forms.Button()
        Me.BtnReference = New System.Windows.Forms.Button()
        Me.BtnSolution = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnPublisher = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.BtnPublishTo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPublishTo = New System.Windows.Forms.TextBox()
        Me.BtnMSBuild = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMSBuild = New System.Windows.Forms.TextBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(125, 57)
        Me.txtVersion.Margin = New System.Windows.Forms.Padding(6)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(1223, 29)
        Me.txtVersion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Version"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Path"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(125, 102)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(1223, 29)
        Me.txtPath.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Compile"
        '
        'txtCompile
        '
        Me.txtCompile.Location = New System.Drawing.Point(125, 146)
        Me.txtCompile.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCompile.Name = "txtCompile"
        Me.txtCompile.Size = New System.Drawing.Size(1141, 29)
        Me.txtCompile.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 234)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Solution"
        '
        'txtSolution
        '
        Me.txtSolution.Location = New System.Drawing.Point(125, 234)
        Me.txtSolution.Margin = New System.Windows.Forms.Padding(6)
        Me.txtSolution.Name = "txtSolution"
        Me.txtSolution.Size = New System.Drawing.Size(1141, 29)
        Me.txtSolution.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 632)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 15, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1373, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.RetrieveToolStripMenuItem, Me.ToolStripMenuItem2, Me.CompileToolStripMenuItem, Me.ReferenceToolStripMenuItem, Me.BuildToolStripMenuItem, Me.ToolStripMenuItem1, Me.ReleaseToolStripMenuItem, Me.ToolStripComboBoxRelease})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1373, 46)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenJSONToolStripMenuItem, Me.ChangeVersionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(62, 38)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenJSONToolStripMenuItem
        '
        Me.OpenJSONToolStripMenuItem.Name = "OpenJSONToolStripMenuItem"
        Me.OpenJSONToolStripMenuItem.Size = New System.Drawing.Size(276, 40)
        Me.OpenJSONToolStripMenuItem.Text = "Open JSON"
        '
        'ChangeVersionToolStripMenuItem
        '
        Me.ChangeVersionToolStripMenuItem.Name = "ChangeVersionToolStripMenuItem"
        Me.ChangeVersionToolStripMenuItem.Size = New System.Drawing.Size(276, 40)
        Me.ChangeVersionToolStripMenuItem.Text = "Change Version"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(276, 40)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(98, 38)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'RetrieveToolStripMenuItem
        '
        Me.RetrieveToolStripMenuItem.Name = "RetrieveToolStripMenuItem"
        Me.RetrieveToolStripMenuItem.Size = New System.Drawing.Size(105, 38)
        Me.RetrieveToolStripMenuItem.Text = "Retrieve"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(36, 38)
        Me.ToolStripMenuItem2.Text = "|"
        '
        'CompileToolStripMenuItem
        '
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(107, 38)
        Me.CompileToolStripMenuItem.Text = "Compile"
        '
        'ReferenceToolStripMenuItem
        '
        Me.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem"
        Me.ReferenceToolStripMenuItem.Size = New System.Drawing.Size(123, 38)
        Me.ReferenceToolStripMenuItem.Text = "Reference"
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(77, 38)
        Me.BuildToolStripMenuItem.Text = "Build"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(36, 38)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'ReleaseToolStripMenuItem
        '
        Me.ReleaseToolStripMenuItem.Name = "ReleaseToolStripMenuItem"
        Me.ReleaseToolStripMenuItem.Size = New System.Drawing.Size(101, 38)
        Me.ReleaseToolStripMenuItem.Text = "Release"
        '
        'ToolStripComboBoxRelease
        '
        Me.ToolStripComboBoxRelease.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripComboBoxRelease.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ToolStripComboBoxRelease.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ToolStripComboBoxRelease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxRelease.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ToolStripComboBoxRelease.MaxDropDownItems = 30
        Me.ToolStripComboBoxRelease.Name = "ToolStripComboBoxRelease"
        Me.ToolStripComboBoxRelease.Size = New System.Drawing.Size(400, 38)
        Me.ToolStripComboBoxRelease.Sorted = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar.Location = New System.Drawing.Point(0, 623)
        Me.ProgressBar.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(1373, 9)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Reference"
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(125, 190)
        Me.txtReference.Margin = New System.Windows.Forms.Padding(6)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(1141, 29)
        Me.txtReference.TabIndex = 12
        '
        'grd
        '
        Me.grd.FormattingEnabled = True
        Me.grd.ItemHeight = 24
        Me.grd.Location = New System.Drawing.Point(125, 415)
        Me.grd.Margin = New System.Windows.Forms.Padding(4)
        Me.grd.Name = "grd"
        Me.grd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.grd.Size = New System.Drawing.Size(1227, 172)
        Me.grd.TabIndex = 14
        '
        'BtnCompile
        '
        Me.BtnCompile.Location = New System.Drawing.Point(1269, 146)
        Me.BtnCompile.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCompile.Name = "BtnCompile"
        Me.BtnCompile.Size = New System.Drawing.Size(86, 37)
        Me.BtnCompile.TabIndex = 17
        Me.BtnCompile.Text = "..."
        Me.BtnCompile.UseVisualStyleBackColor = True
        '
        'BtnReference
        '
        Me.BtnReference.Location = New System.Drawing.Point(1269, 190)
        Me.BtnReference.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReference.Name = "BtnReference"
        Me.BtnReference.Size = New System.Drawing.Size(86, 37)
        Me.BtnReference.TabIndex = 18
        Me.BtnReference.Text = "..."
        Me.BtnReference.UseVisualStyleBackColor = True
        '
        'BtnSolution
        '
        Me.BtnSolution.Location = New System.Drawing.Point(1269, 234)
        Me.BtnSolution.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSolution.Name = "BtnSolution"
        Me.BtnSolution.Size = New System.Drawing.Size(86, 37)
        Me.BtnSolution.TabIndex = 19
        Me.BtnSolution.Text = "..."
        Me.BtnSolution.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 415)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 25)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Projects"
        '
        'BtnPublisher
        '
        Me.BtnPublisher.Location = New System.Drawing.Point(1269, 279)
        Me.BtnPublisher.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPublisher.Name = "BtnPublisher"
        Me.BtnPublisher.Size = New System.Drawing.Size(86, 37)
        Me.BtnPublisher.TabIndex = 24
        Me.BtnPublisher.Text = "..."
        Me.BtnPublisher.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 279)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 25)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Publisher"
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(125, 279)
        Me.txtPublisher.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(1141, 29)
        Me.txtPublisher.TabIndex = 22
        '
        'BtnPublishTo
        '
        Me.BtnPublishTo.Location = New System.Drawing.Point(1269, 323)
        Me.BtnPublishTo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPublishTo.Name = "BtnPublishTo"
        Me.BtnPublishTo.Size = New System.Drawing.Size(86, 37)
        Me.BtnPublishTo.TabIndex = 27
        Me.BtnPublishTo.Text = "..."
        Me.BtnPublishTo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 323)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Publish To"
        '
        'txtPublishTo
        '
        Me.txtPublishTo.Location = New System.Drawing.Point(125, 323)
        Me.txtPublishTo.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPublishTo.Name = "txtPublishTo"
        Me.txtPublishTo.Size = New System.Drawing.Size(1141, 29)
        Me.txtPublishTo.TabIndex = 25
        '
        'BtnMSBuild
        '
        Me.BtnMSBuild.Location = New System.Drawing.Point(1269, 367)
        Me.BtnMSBuild.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMSBuild.Name = "BtnMSBuild"
        Me.BtnMSBuild.Size = New System.Drawing.Size(86, 37)
        Me.BtnMSBuild.TabIndex = 30
        Me.BtnMSBuild.Text = "..."
        Me.BtnMSBuild.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 367)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "MSBuild"
        '
        'txtMSBuild
        '
        Me.txtMSBuild.Location = New System.Drawing.Point(125, 367)
        Me.txtMSBuild.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMSBuild.Name = "txtMSBuild"
        Me.txtMSBuild.Size = New System.Drawing.Size(1141, 29)
        Me.txtMSBuild.TabIndex = 28
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1373, 654)
        Me.Controls.Add(Me.BtnMSBuild)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMSBuild)
        Me.Controls.Add(Me.BtnPublishTo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPublishTo)
        Me.Controls.Add(Me.BtnPublisher)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnSolution)
        Me.Controls.Add(Me.BtnReference)
        Me.Controls.Add(Me.BtnCompile)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSolution)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCompile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVersion)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(700, 313)
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtVersion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCompile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSolution As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenJSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CompileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReferenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReference As TextBox
    Friend WithEvents grd As ListBox
    Friend WithEvents RetrieveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeVersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnCompile As Button
    Friend WithEvents BtnReference As Button
    Friend WithEvents BtnSolution As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReleaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnPublisher As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents BtnPublishTo As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPublishTo As TextBox
    Friend WithEvents BtnMSBuild As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMSBuild As TextBox
    Friend WithEvents ToolStripComboBoxRelease As ToolStripComboBox
End Class
