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
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetrieveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.grd = New System.Windows.Forms.ListBox()
        Me.BtnCompile = New System.Windows.Forms.Button()
        Me.BtnReference = New System.Windows.Forms.Button()
        Me.BtnSolution = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ReleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label1.Location = New System.Drawing.Point(11, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Version"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Path"
        '
        'txtPath
        '
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(68, 56)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(669, 20)
        Me.txtPath.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Compile"
        '
        'txtCompile
        '
        Me.txtCompile.Location = New System.Drawing.Point(68, 80)
        Me.txtCompile.Name = "txtCompile"
        Me.txtCompile.Size = New System.Drawing.Size(624, 20)
        Me.txtCompile.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Solution"
        '
        'txtSolution
        '
        Me.txtSolution.Location = New System.Drawing.Point(68, 129)
        Me.txtSolution.Name = "txtSolution"
        Me.txtSolution.Size = New System.Drawing.Size(624, 20)
        Me.txtSolution.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 340)
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
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripMenuItem2.Text = "|"
        '
        'RetrieveToolStripMenuItem
        '
        Me.RetrieveToolStripMenuItem.Name = "RetrieveToolStripMenuItem"
        Me.RetrieveToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.RetrieveToolStripMenuItem.Text = "Retrieve"
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
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar.Location = New System.Drawing.Point(0, 335)
        Me.ProgressBar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(749, 5)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Reference"
        '
        'txtReference
        '
        Me.txtReference.Location = New System.Drawing.Point(68, 105)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(624, 20)
        Me.txtReference.TabIndex = 12
        '
        'grd
        '
        Me.grd.FormattingEnabled = True
        Me.grd.Location = New System.Drawing.Point(68, 152)
        Me.grd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grd.Name = "grd"
        Me.grd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.grd.Size = New System.Drawing.Size(671, 173)
        Me.grd.TabIndex = 14
        '
        'BtnCompile
        '
        Me.BtnCompile.Location = New System.Drawing.Point(692, 80)
        Me.BtnCompile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnCompile.Name = "BtnCompile"
        Me.BtnCompile.Size = New System.Drawing.Size(47, 20)
        Me.BtnCompile.TabIndex = 17
        Me.BtnCompile.Text = "..."
        Me.BtnCompile.UseVisualStyleBackColor = True
        '
        'BtnReference
        '
        Me.BtnReference.Location = New System.Drawing.Point(692, 105)
        Me.BtnReference.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnReference.Name = "BtnReference"
        Me.BtnReference.Size = New System.Drawing.Size(47, 20)
        Me.BtnReference.TabIndex = 18
        Me.BtnReference.Text = "..."
        Me.BtnReference.UseVisualStyleBackColor = True
        '
        'BtnSolution
        '
        Me.BtnSolution.Location = New System.Drawing.Point(692, 129)
        Me.BtnSolution.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnSolution.Name = "BtnSolution"
        Me.BtnSolution.Size = New System.Drawing.Size(47, 20)
        Me.BtnSolution.TabIndex = 19
        Me.BtnSolution.Text = "..."
        Me.BtnSolution.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Projects"
        '
        'ReleaseToolStripMenuItem
        '
        Me.ReleaseToolStripMenuItem.Name = "ReleaseToolStripMenuItem"
        Me.ReleaseToolStripMenuItem.Size = New System.Drawing.Size(58, 22)
        Me.ReleaseToolStripMenuItem.Text = "Release"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(749, 362)
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
        Me.MinimumSize = New System.Drawing.Size(397, 211)
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
End Class
