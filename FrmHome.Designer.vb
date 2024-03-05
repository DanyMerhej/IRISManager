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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHome))
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
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBoxRelease = New System.Windows.Forms.ToolStripComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetrieveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ChbxSelectAll = New System.Windows.Forms.CheckBox()
        Me.lblSelectAll = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtVersion.Location = New System.Drawing.Point(244, 70)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(669, 21)
        Me.txtVersion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(159, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Version"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(159, 98)
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
        Me.txtPath.Location = New System.Drawing.Point(244, 98)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(669, 21)
        Me.txtPath.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(159, 126)
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
        Me.txtCompile.Location = New System.Drawing.Point(244, 126)
        Me.txtCompile.Name = "txtCompile"
        Me.txtCompile.Size = New System.Drawing.Size(624, 21)
        Me.txtCompile.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(159, 182)
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
        Me.txtSolution.Location = New System.Drawing.Point(244, 182)
        Me.txtSolution.Name = "txtSolution"
        Me.txtSolution.Size = New System.Drawing.Size(624, 21)
        Me.txtSolution.TabIndex = 6
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
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(159, 154)
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
        Me.txtReference.Location = New System.Drawing.Point(244, 154)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(624, 21)
        Me.txtReference.TabIndex = 12
        '
        'grd
        '
        Me.grd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.grd.FormattingEnabled = True
        Me.grd.ItemHeight = 15
        Me.grd.Location = New System.Drawing.Point(244, 296)
        Me.grd.Margin = New System.Windows.Forms.Padding(2)
        Me.grd.Name = "grd"
        Me.grd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.grd.Size = New System.Drawing.Size(671, 94)
        Me.grd.TabIndex = 14
        '
        'BtnCompile
        '
        Me.BtnCompile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCompile.Location = New System.Drawing.Point(868, 126)
        Me.BtnCompile.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCompile.Name = "BtnCompile"
        Me.BtnCompile.Size = New System.Drawing.Size(47, 20)
        Me.BtnCompile.TabIndex = 17
        Me.BtnCompile.Text = "..."
        Me.BtnCompile.UseVisualStyleBackColor = True
        '
        'BtnReference
        '
        Me.BtnReference.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReference.Location = New System.Drawing.Point(868, 154)
        Me.BtnReference.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReference.Name = "BtnReference"
        Me.BtnReference.Size = New System.Drawing.Size(47, 20)
        Me.BtnReference.TabIndex = 18
        Me.BtnReference.Text = "..."
        Me.BtnReference.UseVisualStyleBackColor = True
        '
        'BtnSolution
        '
        Me.BtnSolution.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSolution.Location = New System.Drawing.Point(868, 182)
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
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(159, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Projects"
        '
        'BtnPublisher
        '
        Me.BtnPublisher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPublisher.Location = New System.Drawing.Point(868, 210)
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
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(159, 210)
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
        Me.txtPublisher.Location = New System.Drawing.Point(244, 210)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(624, 21)
        Me.txtPublisher.TabIndex = 22
        '
        'BtnPublishTo
        '
        Me.BtnPublishTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPublishTo.Location = New System.Drawing.Point(868, 238)
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
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(159, 238)
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
        Me.txtPublishTo.Location = New System.Drawing.Point(244, 238)
        Me.txtPublishTo.Name = "txtPublishTo"
        Me.txtPublishTo.Size = New System.Drawing.Size(624, 21)
        Me.txtPublishTo.TabIndex = 25
        '
        'BtnMSBuild
        '
        Me.BtnMSBuild.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMSBuild.Location = New System.Drawing.Point(868, 266)
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
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(159, 266)
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
        Me.txtMSBuild.Location = New System.Drawing.Point(244, 266)
        Me.txtMSBuild.Name = "txtMSBuild"
        Me.txtMSBuild.Size = New System.Drawing.Size(624, 21)
        Me.txtMSBuild.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MenuStrip3)
        Me.Panel1.Location = New System.Drawing.Point(111, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 54)
        Me.Panel1.TabIndex = 32
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.SystemColors.Menu
        Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ToolStripComboBoxRelease})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Padding = New System.Windows.Forms.Padding(20, 14, 0, 2)
        Me.MenuStrip3.Size = New System.Drawing.Size(906, 48)
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
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(162, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 32)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        Me.ToolsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(147, 24)
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
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1336, 15)
        Me.Panel2.TabIndex = 33
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Location = New System.Drawing.Point(3, 15)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(156, 39)
        Me.Panel5.TabIndex = 36
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Location = New System.Drawing.Point(0, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(15, 434)
        Me.Panel3.TabIndex = 34
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.MenuStrip1)
        Me.Panel4.Controls.Add(Me.btnSelectAll)
        Me.Panel4.Location = New System.Drawing.Point(15, 52)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(128, 391)
        Me.Panel4.TabIndex = 35
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
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 26)
        Me.MenuStrip1.Size = New System.Drawing.Size(118, 391)
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
        Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
        Me.CompileToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.CompileToolStripMenuItem.Text = "   Compile"
        Me.CompileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReferenceToolStripMenuItem
        '
        Me.ReferenceToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem"
        Me.ReferenceToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.ReferenceToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.ReferenceToolStripMenuItem.Text = "   Reference"
        Me.ReferenceToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.BuildToolStripMenuItem.Text = "   Build"
        Me.BuildToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReleaseToolStripMenuItem
        '
        Me.ReleaseToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ReleaseToolStripMenuItem.Name = "ReleaseToolStripMenuItem"
        Me.ReleaseToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4)
        Me.ReleaseToolStripMenuItem.Size = New System.Drawing.Size(117, 33)
        Me.ReleaseToolStripMenuItem.Text = "   Release"
        Me.ReleaseToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSelectAll
        '
        Me.btnSelectAll.BackColor = System.Drawing.SystemColors.Menu
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSelectAll.Location = New System.Drawing.Point(32, 279)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(77, 25)
        Me.btnSelectAll.TabIndex = 38
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel6.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel6.Location = New System.Drawing.Point(15, 15)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(118, 39)
        Me.Panel6.TabIndex = 37
        '
        'ChbxSelectAll
        '
        Me.ChbxSelectAll.AutoSize = True
        Me.ChbxSelectAll.Location = New System.Drawing.Point(225, 373)
        Me.ChbxSelectAll.Name = "ChbxSelectAll"
        Me.ChbxSelectAll.Size = New System.Drawing.Size(15, 14)
        Me.ChbxSelectAll.TabIndex = 39
        Me.ChbxSelectAll.UseVisualStyleBackColor = True
        '
        'lblSelectAll
        '
        Me.lblSelectAll.AutoSize = True
        Me.lblSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSelectAll.Location = New System.Drawing.Point(159, 370)
        Me.lblSelectAll.Name = "lblSelectAll"
        Me.lblSelectAll.Size = New System.Drawing.Size(66, 17)
        Me.lblSelectAll.TabIndex = 40
        Me.lblSelectAll.Text = "Select All"
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1017, 458)
        Me.Controls.Add(Me.lblSelectAll)
        Me.Controls.Add(Me.ChbxSelectAll)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
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
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSolution)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCompile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVersion)
        Me.MinimumSize = New System.Drawing.Size(389, 187)
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
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
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReference As TextBox
    Friend WithEvents grd As ListBox
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
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenJSONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeVersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetrieveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReferenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReleaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents ToolStripComboBoxRelease As ToolStripComboBox
    Friend WithEvents ChbxSelectAll As CheckBox
    Friend WithEvents lblSelectAll As Label
End Class
