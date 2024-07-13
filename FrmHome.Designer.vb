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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHome))
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCompile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSolution = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
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
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenJSONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBoxRelease = New System.Windows.Forms.ToolStripComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetrieveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChbxSelectAll = New System.Windows.Forms.CheckBox()
        Me.lblSelectAll = New System.Windows.Forms.Label()
        Me.BuildTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.BtnCompile = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grd = New System.Windows.Forms.ListBox()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtVersion.Location = New System.Drawing.Point(94, 11)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(669, 21)
        Me.txtVersion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Version"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Path"
        '
        'txtPath
        '
        Me.txtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtPath.Location = New System.Drawing.Point(94, 39)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(669, 21)
        Me.txtPath.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(9, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Compile"
        '
        'txtCompile
        '
        Me.txtCompile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCompile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtCompile.Location = New System.Drawing.Point(94, 67)
        Me.txtCompile.Name = "txtCompile"
        Me.txtCompile.Size = New System.Drawing.Size(669, 21)
        Me.txtCompile.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(9, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Solution"
        '
        'txtSolution
        '
        Me.txtSolution.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtSolution.Location = New System.Drawing.Point(94, 123)
        Me.txtSolution.Name = "txtSolution"
        Me.txtSolution.Size = New System.Drawing.Size(669, 21)
        Me.txtSolution.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(9, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Reference"
        '
        'txtReference
        '
        Me.txtReference.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtReference.Location = New System.Drawing.Point(94, 95)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(669, 21)
        Me.txtReference.TabIndex = 12
        '
        'BtnReference
        '
        Me.BtnReference.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReference.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnReference.BackgroundImage = CType(resources.GetObject("BtnReference.BackgroundImage"), System.Drawing.Image)
        Me.BtnReference.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReference.Font = New System.Drawing.Font("Pristina", 10.0!)
        Me.BtnReference.Location = New System.Drawing.Point(740, 95)
        Me.BtnReference.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReference.Name = "BtnReference"
        Me.BtnReference.Size = New System.Drawing.Size(23, 21)
        Me.BtnReference.TabIndex = 18
        Me.BtnReference.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnReference.UseVisualStyleBackColor = False
        '
        'BtnSolution
        '
        Me.BtnSolution.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSolution.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnSolution.BackgroundImage = CType(resources.GetObject("BtnSolution.BackgroundImage"), System.Drawing.Image)
        Me.BtnSolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSolution.Font = New System.Drawing.Font("Pristina", 10.0!)
        Me.BtnSolution.Location = New System.Drawing.Point(740, 123)
        Me.BtnSolution.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSolution.Name = "BtnSolution"
        Me.BtnSolution.Size = New System.Drawing.Size(23, 21)
        Me.BtnSolution.TabIndex = 19
        Me.BtnSolution.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSolution.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(8, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Projects"
        '
        'BtnPublisher
        '
        Me.BtnPublisher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPublisher.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnPublisher.BackgroundImage = CType(resources.GetObject("BtnPublisher.BackgroundImage"), System.Drawing.Image)
        Me.BtnPublisher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPublisher.Font = New System.Drawing.Font("Pristina", 10.0!)
        Me.BtnPublisher.Location = New System.Drawing.Point(740, 151)
        Me.BtnPublisher.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPublisher.Name = "BtnPublisher"
        Me.BtnPublisher.Size = New System.Drawing.Size(23, 21)
        Me.BtnPublisher.TabIndex = 24
        Me.BtnPublisher.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPublisher.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(9, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Publisher"
        '
        'txtPublisher
        '
        Me.txtPublisher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtPublisher.Location = New System.Drawing.Point(94, 151)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(669, 21)
        Me.txtPublisher.TabIndex = 22
        '
        'BtnPublishTo
        '
        Me.BtnPublishTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPublishTo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnPublishTo.BackgroundImage = CType(resources.GetObject("BtnPublishTo.BackgroundImage"), System.Drawing.Image)
        Me.BtnPublishTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPublishTo.Font = New System.Drawing.Font("Pristina", 10.0!)
        Me.BtnPublishTo.Location = New System.Drawing.Point(740, 179)
        Me.BtnPublishTo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPublishTo.Name = "BtnPublishTo"
        Me.BtnPublishTo.Size = New System.Drawing.Size(23, 21)
        Me.BtnPublishTo.TabIndex = 27
        Me.BtnPublishTo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPublishTo.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(9, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Publish To"
        '
        'txtPublishTo
        '
        Me.txtPublishTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPublishTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtPublishTo.Location = New System.Drawing.Point(94, 179)
        Me.txtPublishTo.Name = "txtPublishTo"
        Me.txtPublishTo.Size = New System.Drawing.Size(669, 21)
        Me.txtPublishTo.TabIndex = 25
        '
        'BtnMSBuild
        '
        Me.BtnMSBuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMSBuild.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnMSBuild.BackgroundImage = CType(resources.GetObject("BtnMSBuild.BackgroundImage"), System.Drawing.Image)
        Me.BtnMSBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMSBuild.Font = New System.Drawing.Font("Pristina", 10.0!)
        Me.BtnMSBuild.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMSBuild.Location = New System.Drawing.Point(740, 207)
        Me.BtnMSBuild.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnMSBuild.Name = "BtnMSBuild"
        Me.BtnMSBuild.Size = New System.Drawing.Size(23, 21)
        Me.BtnMSBuild.TabIndex = 30
        Me.BtnMSBuild.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnMSBuild.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(9, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "MSBuild"
        '
        'txtMSBuild
        '
        Me.txtMSBuild.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMSBuild.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtMSBuild.Location = New System.Drawing.Point(94, 207)
        Me.txtMSBuild.Name = "txtMSBuild"
        Me.txtMSBuild.Size = New System.Drawing.Size(669, 21)
        Me.txtMSBuild.TabIndex = 28
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.SystemColors.Menu
        Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ToolStripComboBoxRelease})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip3.Size = New System.Drawing.Size(1017, 32)
        Me.MenuStrip3.TabIndex = 0
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenJSONToolStripMenuItem, Me.ChangeVersionToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(48, 32)
        Me.FileToolStripMenuItem.Text = "File "
        '
        'OpenJSONToolStripMenuItem
        '
        Me.OpenJSONToolStripMenuItem.Name = "OpenJSONToolStripMenuItem"
        Me.OpenJSONToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.OpenJSONToolStripMenuItem.Text = "Open JSON"
        '
        'ChangeVersionToolStripMenuItem
        '
        Me.ChangeVersionToolStripMenuItem.Name = "ChangeVersionToolStripMenuItem"
        Me.ChangeVersionToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ChangeVersionToolStripMenuItem.Text = "Change Version"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(51, 32)
        Me.EditToolStripMenuItem.Text = "&Edit "
        Me.EditToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 32)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        Me.ToolsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkModeToolStripMenuItem})
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'DarkModeToolStripMenuItem
        '
        Me.DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        Me.DarkModeToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.DarkModeToolStripMenuItem.Text = "Dark Mode"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ToolStripComboBoxRelease
        '
        Me.ToolStripComboBoxRelease.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripComboBoxRelease.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ToolStripComboBoxRelease.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ToolStripComboBoxRelease.AutoSize = False
        Me.ToolStripComboBoxRelease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxRelease.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ToolStripComboBoxRelease.Margin = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.ToolStripComboBoxRelease.MaxDropDownItems = 30
        Me.ToolStripComboBoxRelease.Name = "ToolStripComboBoxRelease"
        Me.ToolStripComboBoxRelease.Size = New System.Drawing.Size(144, 23)
        Me.ToolStripComboBoxRelease.Sorted = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Menu
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.RetrieveToolStripMenuItem, Me.CompileToolStripMenuItem, Me.ReferenceToolStripMenuItem, Me.BuildToolStripMenuItem, Me.ReleaseToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 32)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.Size = New System.Drawing.Size(118, 399)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.UpdateToolStripMenuItem.Text = "   Update"
        Me.UpdateToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RetrieveToolStripMenuItem
        '
        Me.RetrieveToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.RetrieveToolStripMenuItem.Name = "RetrieveToolStripMenuItem"
        Me.RetrieveToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.RetrieveToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.RetrieveToolStripMenuItem.Text = "   Retrieve"
        Me.RetrieveToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompileToolStripMenuItem
        '
        Me.CompileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CompileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.CompileToolStripMenuItem.Text = "   Compile"
        Me.CompileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReferenceToolStripMenuItem
        '
        Me.ReferenceToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ReferenceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem"
        Me.ReferenceToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.ReferenceToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.ReferenceToolStripMenuItem.Text = "   Reference"
        Me.ReferenceToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BuildToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.BuildToolStripMenuItem.Text = "   Build"
        Me.BuildToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReleaseToolStripMenuItem
        '
        Me.ReleaseToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu
        Me.ReleaseToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ReleaseToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReleaseToolStripMenuItem.Name = "ReleaseToolStripMenuItem"
        Me.ReleaseToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.ReleaseToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.ReleaseToolStripMenuItem.Text = "   Release"
        Me.ReleaseToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChbxSelectAll
        '
        Me.ChbxSelectAll.AutoSize = True
        Me.ChbxSelectAll.Location = New System.Drawing.Point(72, 48)
        Me.ChbxSelectAll.Name = "ChbxSelectAll"
        Me.ChbxSelectAll.Size = New System.Drawing.Size(15, 14)
        Me.ChbxSelectAll.TabIndex = 39
        Me.ChbxSelectAll.UseVisualStyleBackColor = True
        '
        'lblSelectAll
        '
        Me.lblSelectAll.AutoSize = True
        Me.lblSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSelectAll.Location = New System.Drawing.Point(6, 45)
        Me.lblSelectAll.Name = "lblSelectAll"
        Me.lblSelectAll.Size = New System.Drawing.Size(66, 17)
        Me.lblSelectAll.TabIndex = 40
        Me.lblSelectAll.Text = "Select All"
        '
        'BuildTimer
        '
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 8, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1017, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar.Location = New System.Drawing.Point(0, 453)
        Me.ProgressBar.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(1017, 5)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 11
        '
        'BtnCompile
        '
        Me.BtnCompile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCompile.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnCompile.BackgroundImage = Global.IRISManager.My.Resources.Resources.FolderIcon
        Me.BtnCompile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCompile.Font = New System.Drawing.Font("Pristina", 10.0!)
        Me.BtnCompile.Location = New System.Drawing.Point(740, 67)
        Me.BtnCompile.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCompile.Name = "BtnCompile"
        Me.BtnCompile.Size = New System.Drawing.Size(23, 21)
        Me.BtnCompile.TabIndex = 17
        Me.BtnCompile.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCompile.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(121, 35)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(896, 393)
        Me.TabControl1.TabIndex = 41
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtVersion)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtPath)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtCompile)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.BtnMSBuild)
        Me.TabPage1.Controls.Add(Me.txtSolution)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtMSBuild)
        Me.TabPage1.Controls.Add(Me.txtReference)
        Me.TabPage1.Controls.Add(Me.BtnPublishTo)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.BtnCompile)
        Me.TabPage1.Controls.Add(Me.txtPublishTo)
        Me.TabPage1.Controls.Add(Me.BtnReference)
        Me.TabPage1.Controls.Add(Me.BtnPublisher)
        Me.TabPage1.Controls.Add(Me.BtnSolution)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtPublisher)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(888, 367)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Control"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grd)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.ChbxSelectAll)
        Me.TabPage2.Controls.Add(Me.lblSelectAll)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(888, 367)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Work Space"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grd
        '
        Me.grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.grd.FormattingEnabled = True
        Me.grd.ItemHeight = 15
        Me.grd.Location = New System.Drawing.Point(93, 9)
        Me.grd.Margin = New System.Windows.Forms.Padding(2)
        Me.grd.Name = "grd"
        Me.grd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.grd.Size = New System.Drawing.Size(788, 349)
        Me.grd.TabIndex = 14
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1017, 458)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ProgressBar)
        Me.MinimumSize = New System.Drawing.Size(389, 187)
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReference As TextBox
    Friend WithEvents BtnCompile As Button
    Friend WithEvents BtnReference As Button
    Friend WithEvents BtnSolution As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnPublisher As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents BtnPublishTo As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPublishTo As TextBox
    Friend WithEvents BtnMSBuild As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMSBuild As TextBox
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenJSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeVersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetrieveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReferenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReleaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBoxRelease As ToolStripComboBox
    Friend WithEvents ChbxSelectAll As CheckBox
    Friend WithEvents lblSelectAll As Label
    Friend WithEvents BuildTimer As Timer
    Friend WithEvents DarkModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents grd As ListBox
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
