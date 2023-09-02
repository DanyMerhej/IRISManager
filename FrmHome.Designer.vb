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
        Me.txtVersion.Enabled = False
        Me.txtVersion.Location = New System.Drawing.Point(68, 31)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(669, 20)
        Me.txtVersion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Version"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Path"
        '
        'txtPath
        '
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(68, 55)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(669, 20)
        Me.txtPath.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Compile"
        '
        'txtCompile
        '
        Me.txtCompile.Location = New System.Drawing.Point(68, 79)
        Me.txtCompile.Name = "txtCompile"
        Me.txtCompile.Size = New System.Drawing.Size(624, 20)
        Me.txtCompile.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Solution"
        '
        'txtSolution
        '
        Me.txtSolution.Location = New System.Drawing.Point(68, 127)
        Me.txtSolution.Name = "txtSolution"
        Me.txtSolution.Size = New System.Drawing.Size(624, 20)
        Me.txtSolution.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 332)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 8, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(749, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.RetrieveToolStripMenuItem, Me.ToolStripMenuItem2, Me.CompileToolStripMenuItem, Me.ReferenceToolStripMenuItem, Me.BuildToolStripMenuItem, Me.ToolStripMenuItem1, Me.ReleaseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(749, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenJSONToolStripMenuItem, Me.ChangeVersionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenJSONToolStripMenuItem
        '
        Me.OpenJSONToolStripMenuItem.Name = "OpenJSONToolStripMenuItem"
        Me.OpenJSONToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.OpenJSONToolStripMenuItem.Text = "Open JSON"
        '
        'ChangeVersionToolStripMenuItem
        '
        Me.ChangeVersionToolStripMenuItem.Name = "ChangeVersionToolStripMenuItem"
        Me.ChangeVersionToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ChangeVersionToolStripMenuItem.Text = "Change Version"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'RetrieveToolStripMenuItem
        '
        Me.RetrieveToolStripMenuItem.Name = "RetrieveToolStripMenuItem"
        Me.RetrieveToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.RetrieveToolStripMenuItem.Text = "Retrieve"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripMenuItem2.Text = "|"
        '
        'CompileToolStripMenuItem
        '
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(64, 22)
        Me.CompileToolStripMenuItem.Text = "Compile"
        '
        'ReferenceToolStripMenuItem
        '
        Me.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem"
        Me.ReferenceToolStripMenuItem.Size = New System.Drawing.Size(71, 22)
        Me.ReferenceToolStripMenuItem.Text = "Reference"
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(46, 22)
        Me.BuildToolStripMenuItem.Text = "Build"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'ReleaseToolStripMenuItem
        '
        Me.ReleaseToolStripMenuItem.Name = "ReleaseToolStripMenuItem"
        Me.ReleaseToolStripMenuItem.Size = New System.Drawing.Size(58, 22)
        Me.ReleaseToolStripMenuItem.Text = "Release"
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar.Location = New System.Drawing.Point(0, 327)
        Me.ProgressBar.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(749, 5)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Reference"
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(68, 103)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(624, 20)
        Me.txtReference.TabIndex = 12
        '
        'grd
        '
        Me.grd.FormattingEnabled = True
        Me.grd.Location = New System.Drawing.Point(68, 225)
        Me.grd.Margin = New System.Windows.Forms.Padding(2)
        Me.grd.Name = "grd"
        Me.grd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.grd.Size = New System.Drawing.Size(671, 95)
        Me.grd.TabIndex = 14
        '
        'BtnCompile
        '
        Me.BtnCompile.Location = New System.Drawing.Point(692, 79)
        Me.BtnCompile.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCompile.Name = "BtnCompile"
        Me.BtnCompile.Size = New System.Drawing.Size(47, 20)
        Me.BtnCompile.TabIndex = 17
        Me.BtnCompile.Text = "..."
        Me.BtnCompile.UseVisualStyleBackColor = True
        '
        'BtnReference
        '
        Me.BtnReference.Location = New System.Drawing.Point(692, 103)
        Me.BtnReference.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReference.Name = "BtnReference"
        Me.BtnReference.Size = New System.Drawing.Size(47, 20)
        Me.BtnReference.TabIndex = 18
        Me.BtnReference.Text = "..."
        Me.BtnReference.UseVisualStyleBackColor = True
        '
        'BtnSolution
        '
        Me.BtnSolution.Location = New System.Drawing.Point(692, 127)
        Me.BtnSolution.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSolution.Name = "BtnSolution"
        Me.BtnSolution.Size = New System.Drawing.Size(47, 20)
        Me.BtnSolution.TabIndex = 19
        Me.BtnSolution.Text = "..."
        Me.BtnSolution.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Projects"
        '
        'BtnPublisher
        '
        Me.BtnPublisher.Location = New System.Drawing.Point(692, 151)
        Me.BtnPublisher.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPublisher.Name = "BtnPublisher"
        Me.BtnPublisher.Size = New System.Drawing.Size(47, 20)
        Me.BtnPublisher.TabIndex = 24
        Me.BtnPublisher.Text = "..."
        Me.BtnPublisher.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Publisher"
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(68, 151)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(624, 20)
        Me.txtPublisher.TabIndex = 22
        '
        'BtnPublishTo
        '
        Me.BtnPublishTo.Location = New System.Drawing.Point(692, 175)
        Me.BtnPublishTo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPublishTo.Name = "BtnPublishTo"
        Me.BtnPublishTo.Size = New System.Drawing.Size(47, 20)
        Me.BtnPublishTo.TabIndex = 27
        Me.BtnPublishTo.Text = "..."
        Me.BtnPublishTo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Publish To"
        '
        'txtPublishTo
        '
        Me.txtPublishTo.Location = New System.Drawing.Point(68, 175)
        Me.txtPublishTo.Name = "txtPublishTo"
        Me.txtPublishTo.Size = New System.Drawing.Size(624, 20)
        Me.txtPublishTo.TabIndex = 25
        '
        'BtnMSBuild
        '
        Me.BtnMSBuild.Location = New System.Drawing.Point(692, 199)
        Me.BtnMSBuild.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMSBuild.Name = "BtnMSBuild"
        Me.BtnMSBuild.Size = New System.Drawing.Size(47, 20)
        Me.BtnMSBuild.TabIndex = 30
        Me.BtnMSBuild.Text = "..."
        Me.BtnMSBuild.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "MSBuild"
        '
        'txtMSBuild
        '
        Me.txtMSBuild.Location = New System.Drawing.Point(68, 199)
        Me.txtMSBuild.Name = "txtMSBuild"
        Me.txtMSBuild.Size = New System.Drawing.Size(624, 20)
        Me.txtMSBuild.TabIndex = 28
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(749, 354)
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
        Me.MinimumSize = New System.Drawing.Size(393, 199)
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
End Class
