Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json
Imports System.Diagnostics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Security.Cryptography
Imports Infragistics.Win.FormattedLinkLabel
Imports System.Threading

Public Class FrmHome
    Inherits Form
    Dim json As String
    Dim config As Variables
    Dim fileList As New List(Of String)
    Dim jsonFolderPath As String = "Config"
    Dim LogFolderPath As String = "Log"
    Dim MainJSONFile As String = "appsettings.json"
    Dim ConfigPath As String = Application.StartupPath & "\" & jsonFolderPath & "\" & MainJSONFile
    Dim LogPath As String = Application.StartupPath & "\" & LogFolderPath
    Dim jsonFiles As String()
    Dim targetExtension As String
    Dim LastVersion As String
    Dim NewVersion As String
    Dim LastRevision As Int32
    Dim NewRevision As Int32
    Dim LogVersion As String
    Private Const OutputParameter As String = "Output"
    Private Const ReferenceParameter As String = "Reference"
    Private PreviousDates As String = ""
    Private currentDate As DateTime = DateTime.Now
    Private WithEvents colorProgressBar As New ColorProgressBar()

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "IRIS Manager"
        lblStatus.Text = "Ready"
        ProgressBar.Maximum = 100
        json = File.ReadAllText(ConfigPath)
        config = JsonConvert.DeserializeObject(Of Variables)(json)
        Dim jsonFiles = Directory.GetFiles(Application.StartupPath & "\" & jsonFolderPath, "*.json").
        Where(Function(file) Path.GetFileName(file) <> MainJSONFile).ToArray()
        ToolStripComboBoxRelease.Items.AddRange(jsonFiles.Select(Function(file) Path.GetFileName(file)).ToArray())
        Me.FillTextBoxes(config)
        ApplyThemeFromConfig()
    End Sub

    Private Sub FillTextBoxes(ByVal _Json As Variables)
        Me.txtVersion.Text = _Json.Version.VersionName
        Me.txtPath.Text = _Json.Version.VersionPath
        Me.txtCompile.Text = _Json.Version.VersionCompilePath
        txtCompile.Controls.Add(BtnCompile)
        BtnCompile.Dock = DockStyle.Fill
        BtnCompile.Dock = DockStyle.Right
        BtnCompile.Width = 21
        Me.txtReference.Text = _Json.Version.VersionReferencePath
        txtReference.Controls.Add(BtnReference)
        BtnReference.Dock = DockStyle.Fill
        BtnReference.Dock = DockStyle.Right
        BtnReference.Width = 21
        Me.txtSolution.Text = _Json.Version.VersionMainSolutionPath
        txtSolution.Controls.Add(BtnSolution)
        BtnSolution.Dock = DockStyle.Fill
        BtnSolution.Dock = DockStyle.Right
        BtnSolution.Width = 21
        Me.txtPublisher.Text = _Json.Version.PublisherPath
        txtPublisher.Controls.Add(BtnPublisher)
        BtnPublisher.Dock = DockStyle.Fill
        BtnPublisher.Dock = DockStyle.Right
        BtnPublisher.Width = 21
        Me.txtPublishTo.Text = _Json.Version.PublishPath
        txtPublishTo.Controls.Add(BtnPublishTo)
        BtnPublishTo.Dock = DockStyle.Fill
        BtnPublishTo.Dock = DockStyle.Right
        BtnPublishTo.Width = 21
        Me.txtMSBuild.Text = _Json.Version.MSBuildPath
        txtMSBuild.Controls.Add(BtnMSBuild)
        BtnMSBuild.Dock = DockStyle.Fill
        BtnMSBuild.Dock = DockStyle.Right
        BtnMSBuild.Width = 21
        Me.targetExtension = _Json.Version.ProjectExtension
    End Sub

    Private Sub FillJson(ByVal _Json As Variables, ByVal _Path As String)
        Try
            Me.colorProgressBar.Value = 0
            _Json.Version.VersionName = Me.txtVersion.Text
            _Json.Version.VersionPath = Me.txtPath.Text
            _Json.Version.VersionCompilePath = Me.txtCompile.Text
            _Json.Version.VersionReferencePath = Me.txtReference.Text
            _Json.Version.VersionMainSolutionPath = Me.txtSolution.Text
            _Json.Version.PublisherPath = Me.txtPublisher.Text
            _Json.Version.PublishPath = Me.txtPublishTo.Text
            _Json.Version.MSBuildPath = Me.txtMSBuild.Text
            _Json.Version.ProjectExtension = Me.targetExtension
            Dim updatedJson As String = JsonConvert.SerializeObject(_Json, Xml.Formatting.Indented)
            File.WriteAllText(_Path, updatedJson)
            Me.colorProgressBar.Value = 100
            BuildTimer.Interval = 3000
            BuildTimer.Start()
            lblStatus.Text = "New JSON saved successfully"
        Catch ex As Exception
            lblStatus.Text = "Error saving changes"
        End Try
    End Sub

    Private Sub ChangeCompileReferencePath(ByVal _Parameter As String)
        Me.colorProgressBar.Value = 0

        If grd.Items.Count > 0 AndAlso grd.SelectedItems.Count > 0 Then
            For Each selectedItem As Object In grd.SelectedItems
                If File.Exists(selectedItem) Then
                    Dim projectXml As New XmlDocument()
                    projectXml.Load(selectedItem)
                    Dim nsmgr As XmlNamespaceManager = GetNamespaceManager(projectXml)
                    Dim PathNode As XmlNode = projectXml.SelectSingleNode("//ns:" & _Parameter & "Path", GetNamespaceManager(projectXml))
                    If PathNode IsNot Nothing Then
                        Select Case _Parameter
                            Case OutputParameter
                                PathNode.InnerText = Me.txtCompile.Text
                            Case ReferenceParameter
                                PathNode.InnerText = Me.txtReference.Text
                        End Select
                    Else
                        Dim newPropertyGroup As XmlElement = projectXml.CreateElement("PropertyGroup", projectXml.DocumentElement.NamespaceURI)
                        Dim newPathNode As XmlElement = projectXml.CreateElement(_Parameter & "Path", projectXml.DocumentElement.NamespaceURI)

                        Select Case _Parameter
                            Case OutputParameter
                                newPathNode.InnerText = Me.txtCompile.Text
                            Case ReferenceParameter
                                newPathNode.InnerText = Me.txtReference.Text
                        End Select

                        newPropertyGroup.AppendChild(newPathNode)
                        projectXml.DocumentElement.AppendChild(newPropertyGroup)
                    End If
                    projectXml.Save(selectedItem)
                    Me.colorProgressBar.Value += 100 \ grd.SelectedItems.Count
                Else
                    lblStatus.Text = "Project file not found"
                End If
            Next
            lblStatus.Text = "Paths updated successfully"
        Else
            lblStatus.Text = "Choose projects before proceeding"
        End If
        Me.colorProgressBar.Value = 100
        BuildTimer.Interval = 3000
        BuildTimer.Start()
    End Sub

    Private Function GetNamespaceManager(ByVal xmlDoc As XmlDocument) As XmlNamespaceManager
        Dim nsMgr As New XmlNamespaceManager(xmlDoc.NameTable)
        nsMgr.AddNamespace("ns", xmlDoc.DocumentElement.NamespaceURI)
        Return nsMgr
    End Function

    Sub ProcessFiles(folderPath As String, extension As String)
        Try
            Dim files As String() = Directory.GetFiles(folderPath, "*" & extension)
            For Each file As String In files
                fileList.AddRange(files)
            Next

            Dim subFolders As String() = Directory.GetDirectories(folderPath)
            For Each subFolder As String In subFolders
                ProcessFiles(subFolder, extension)
            Next
        Catch ex As Exception
            lblStatus.Text = "Error occured while retrieving files" & vbCrLf & ex.Message
        End Try
    End Sub

    Private Function GetPath(ByVal _WithFilePath As Boolean, ByVal _Path As String) As String
        Dim selectedPath As String = _Path
        Dim folderBrowser As New FolderBrowserDialog
        Dim openFileDialog As New OpenFileDialog

        folderBrowser.SelectedPath = selectedPath
        If _WithFilePath Then
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                selectedPath = openFileDialog.FileName
            End If
        Else
            If folderBrowser.ShowDialog() = DialogResult.OK Then
                selectedPath = folderBrowser.SelectedPath
            End If
        End If
        Return selectedPath
    End Function

    Private Sub ExecuteCmdCommand(processStartInfo As ProcessStartInfo, ByVal _FileName As String, ByVal _Arguments As String)
        processStartInfo.FileName = _FileName
        processStartInfo.Arguments = _Arguments
        processStartInfo.RedirectStandardOutput = True
        processStartInfo.RedirectStandardError = True
        processStartInfo.UseShellExecute = False
        processStartInfo.CreateNoWindow = True

        Using process As New Process()
            process.StartInfo = processStartInfo
            process.Start()
            Dim output As String = process.StandardOutput.ReadToEnd()
            Dim errorOutput As String = process.StandardError.ReadToEnd()
            process.WaitForExit()
        End Using
    End Sub

    Private Sub ChangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuildToolStripMenuItem.Click
        Me.colorProgressBar.Value = 0
        If grd.Items.Count > 0 Then
            Refresh()
            For Each selectedItem As Object In grd.SelectedItems
                Dim projectPath As String = selectedItem
                lblStatus.Text = $"Building {Path.GetFileName(projectPath)}..."
                Application.DoEvents()
                Me.colorProgressBar.Value += 100 \ grd.SelectedItems.Count
                Me.ExecuteCmdCommand(New ProcessStartInfo(), config.Version.MSBuildPath, $"""{projectPath}"" /t:Rebuild /p:Configuration=Debug")
            Next
            lblStatus.Text = "Build successfull"
        Else
            lblStatus.Text = "Choose projects to build"
        End If
        Me.colorProgressBar.Value = 100
        BuildTimer.Interval = 3000
        BuildTimer.Start()

    End Sub
    Private Sub BuildTimer_Tick(sender As Object, e As EventArgs) Handles BuildTimer.Tick
        BuildTimer.Stop()
        Me.colorProgressBar.Value = 0
        lblStatus.Text = "Ready"
    End Sub

    Private Sub ReleaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReleaseToolStripMenuItem.Click
        Me.colorProgressBar.Value = 0
        Me.lblStatus.Text = "Publishing ..."
        Me.lblStatus.Text = Me.GetLastAndNewVersion()
        If Me.lblStatus.Text = "" Then
            Me.lblStatus.Text = "Last version found : " & LastVersion & "." & LastRevision
            Refresh()

            config.Version.ApplicationRevision = Me.NewRevision
            config.Version.ApplicationVersion = Me.NewVersion
            FillJson(config, ConfigPath)

            If ToolStripComboBoxRelease.SelectedItem IsNot Nothing Then
                Dim selectedFileName As String = ToolStripComboBoxRelease.SelectedItem.ToString()
                Dim selectedFilePath As String = Path.Combine(jsonFolderPath, selectedFileName)
                Dim jsonData As String = File.ReadAllText(selectedFilePath)
                Dim deserializedData As Variables = JsonConvert.DeserializeObject(Of Variables)(jsonData)
                deserializedData.Version.ApplicationRevision = Me.NewRevision
                deserializedData.Version.ApplicationVersion = Me.NewVersion
                Me.FillJson(deserializedData, selectedFilePath)
            End If

            Me.ExecuteCmdCommand(New ProcessStartInfo(), config.Version.MSBuildPath, $"""{config.Version.PublisherPath}"" /t:clean /t:publish /p:Configuration=Release /p:PublishDir=""{config.Version.PublishPath}""")
            lblStatus.Text = "Publish successfull"


            Me.WriteLog()
            lblStatus.Text &= " / Logged in: " & Me.LogVersion

            Me.colorProgressBar.Value = 100
            BuildTimer.Interval = 3000
            BuildTimer.Start()
        End If
    End Sub

    Private Sub RetrieveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetrieveToolStripMenuItem.Click
        fileList.Clear()
        grd.DataSource = Nothing
        Me.ProcessFiles(Me.txtPath.Text, targetExtension)
        If fileList.Count > 0 Then
            grd.DataSource = fileList
            lblStatus.Text = "Found a new list to process"
            Me.TabControl1.SelectedTab = TabPage2
        Else
            grd.DataSource = Nothing
            lblStatus.Text = "Nothing found"
        End If
    End Sub

    Private Function GetLastAndNewVersion() As String
        Try
            Me.LogVersion = ""
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(Me.txtPublisher.Text)
            Dim namespaceManager As New XmlNamespaceManager(xmlDoc.NameTable)
            namespaceManager.AddNamespace("ns", "http://schemas.microsoft.com/developer/msbuild/2003")
            Dim applicationVersionNode As XmlNode = xmlDoc.SelectSingleNode("//ns:ApplicationVersion", namespaceManager)
            Dim ApplicationRevisionNode As XmlNode = xmlDoc.SelectSingleNode("//ns:ApplicationRevision", namespaceManager)
            If applicationVersionNode IsNot Nothing AndAlso ApplicationRevisionNode IsNot Nothing Then
                Dim applicationVersion As String = applicationVersionNode.InnerText
                Dim ApplicationRevision As String = ApplicationRevisionNode.InnerText
                Dim inputString As String = applicationVersion
                Dim lastIndex As Integer = inputString.LastIndexOf(".")
                If lastIndex >= 0 Then
                    Dim result As String = inputString.Substring(0, lastIndex)
                    Me.LastVersion = result
                Else
                    Me.LastVersion = applicationVersion
                End If
                Me.LastRevision = ApplicationRevision

                If Now.Year & "." & DateTime.Now.ToString("MM") & "." & DateTime.Now.ToString("dd") & "." & "%2a" <> applicationVersionNode.InnerText Then
                    applicationVersionNode.InnerText = Now.Year & "." & DateTime.Now.ToString("MM") & "." & DateTime.Now.ToString("dd") & "." & "%2a"
                    ApplicationRevisionNode.InnerText = 1
                Else
                    ApplicationRevisionNode.InnerText = LastRevision + 1
                End If
                Me.NewVersion = applicationVersionNode.InnerText
                Me.NewRevision = ApplicationRevisionNode.InnerText
                Me.LogVersion = Now.Year & "_" & DateTime.Now.ToString("MM") & "_" & DateTime.Now.ToString("dd") & "_" & Me.NewRevision
                xmlDoc.Save(Me.txtPublisher.Text)
            Else
                Return "No ApplicationVersion or ApplicationRevision node found"
            End If

        Catch ex As Exception
            Return ex.Message
        End Try
        Return ""
    End Function

    Private Sub ToolStripComboBoxRelease_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBoxRelease.SelectedIndexChanged
        If ToolStripComboBoxRelease.SelectedItem IsNot Nothing Then
            Dim selectedFileName As String = ToolStripComboBoxRelease.SelectedItem.ToString()
            Dim selectedFilePath As String = Path.Combine(jsonFolderPath, selectedFileName)
            Try
                Dim jsonData As String = File.ReadAllText(selectedFilePath)
                Dim deserializedData As Variables = JsonConvert.DeserializeObject(Of Variables)(jsonData)
                Me.FillTextBoxes(deserializedData)
                Me.FillJson(deserializedData, selectedFilePath)
            Catch ex As Exception
                lblStatus.Text = "Error reading JSON file: " & ex.Message
            End Try
        Else
            lblStatus.Text = "Please select a JSON file from the list."
        End If
    End Sub

#Region "Write Log"
    Private Function WriteLog() As Boolean
        Dim folderPathNew As String = config.Version.PublishPath & "\Application Files\Pixel.Iris2.Publisher_" & Me.LogVersion

        Dim dateIndex As Integer = LogVersion.LastIndexOf("_")
        Dim dateresult As String = LogVersion.Substring(0, dateIndex)
        Dim versionresult As Integer = LogVersion.Split("_"c).Last()

        Dim basefolder As String = config.Version.PublishPath & "\Application Files\"
        Dim targetFolderName As String = $"Pixel.Iris2.Publisher_{dateresult}_{versionresult}"

        Dim previousVersion As Integer = FindLatestAvailableVersion(basefolder, dateresult, versionresult)
        Dim previousFolderName As String
        If previousVersion <> -1 Then
            If dateresult = Me.currentDate.ToString("yyyy_MM_dd") Then
                previousFolderName = $"Pixel.Iris2.Publisher_{dateresult}_{previousVersion}"
            Else
                previousFolderName = $"Pixel.Iris2.Publisher_{Me.PreviousDates}_{previousVersion}"
            End If
            Dim folderPathOld As String = Path.Combine(basefolder, previousFolderName)

            Dim LogName As String = folderPathNew.Substring(folderPathNew.IndexOf("_") + 1)
            Dim logFilePath As String = Me.LogPath & "\" & LogName & ".txt"
            If Not System.IO.File.Exists(logFilePath) Then
                System.IO.File.Create(logFilePath).Dispose()
            End If
            Using writer As New StreamWriter(logFilePath)
                writer.WriteLine($"Version number: {Me.LogVersion}")
                writer.WriteLine($"Date: {Year(DateTime.Now) & "/" & Month(DateTime.Now) & "/" & (DateTime.Now).Day & " " & DateAndTime.TimeString }")
                writer.WriteLine()
                Dim filesOld = Directory.GetFiles(folderPathOld, "*", SearchOption.TopDirectoryOnly)
                Dim filesNew = Directory.GetFiles(folderPathNew, "*", SearchOption.TopDirectoryOnly)
                Dim updatedFiles = GetUpdatedFiles(filesOld, filesNew)
                If updatedFiles.Count > 0 Then
                    writer.WriteLine("Updated Files:")
                    For Each updatedFile In updatedFiles
                        Dim fileName = Path.GetFileName(updatedFile)
                        writer.WriteLine($"  {fileName} - Updated on {File.GetLastWriteTime(updatedFile)}")
                    Next
                    writer.WriteLine()
                End If

            End Using
        Else
            Console.WriteLine("No previous version found.")
        End If
        Return True
    End Function

    Private Function GetUpdatedFiles(filesOld As String(), filesNew As String()) As List(Of String)
        Dim updatedFiles As New List(Of String)
        For Each fileOld In filesOld
            Dim fileNew = filesNew.FirstOrDefault(Function(f) String.Equals(Path.GetFileName(fileOld), Path.GetFileName(f), StringComparison.OrdinalIgnoreCase))
            If fileNew IsNot Nothing Then
                If Not FilesAreEqual(fileOld, fileNew) Then
                    updatedFiles.Add(fileNew)
                End If
            End If
        Next
        Return updatedFiles
    End Function

    Private Function FilesAreEqual(file1 As String, file2 As String) As Boolean
        If New FileInfo(file1).Length <> New FileInfo(file2).Length Then
            Return False
        End If
        Using hash1 = MD5.Create(), hash2 = MD5.Create()
            Using stream1 = File.OpenRead(file1), stream2 = File.OpenRead(file2)
                Dim hashValue1 = hash1.ComputeHash(stream1)
                Dim hashValue2 = hash2.ComputeHash(stream2)
                For i As Integer = 0 To hashValue1.Length - 1
                    If hashValue1(i) <> hashValue2(i) Then
                        Return False
                    End If
                Next
            End Using
        End Using
        Return True
    End Function

    Private Function FindLatestAvailableVersion(baseFolder As String, targetDate As String, currentVersion As Integer) As Integer
        Dim versionToCheck As Integer = currentVersion - 1

        While versionToCheck >= 1
            Dim folderNameToCheck As String = $"Pixel.Iris2.Publisher_{targetDate}_{versionToCheck}"
            Dim folderPathToCheck As String = Path.Combine(baseFolder, folderNameToCheck)

            If Directory.Exists(folderPathToCheck) Then
                Return versionToCheck
            End If

            versionToCheck -= 1
        End While

        While True
            Dim formatCurrentDate As String = Me.currentDate.ToString("yyyy_MM_dd")

            Dim latestVersionOfPreviousDay As Integer = GetLatestVersionOfPreviousDay(baseFolder, formatCurrentDate)

            If latestVersionOfPreviousDay <> -1 Then
                Return latestVersionOfPreviousDay
            End If
        End While
    End Function

    Private Function GetLatestVersionOfPreviousDay(baseFolder As String, yesterdayDateString As String) As Integer
        Me.PreviousDates = yesterdayDateString
        Dim folders = Directory.GetDirectories(baseFolder, $"Pixel.Iris2.Publisher_{yesterdayDateString}_*")

        Dim versions As New List(Of Integer)()
        For Each folder In folders
            Dim versionString = folder.Split("_"c).Last()
            Dim version As Integer
            If Integer.TryParse(versionString, version) Then
                versions.Add(version)
            End If
        Next

        If versions.Count > 0 Then
            Return versions.Max()
        Else
            Return -1
        End If
    End Function

#End Region

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.FillJson(config, ConfigPath)
    End Sub
    Private Sub OpenJSONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenJSONToolStripMenuItem.Click
        Process.Start(ConfigPath)
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub CompileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompileToolStripMenuItem.Click
        Me.ChangeCompileReferencePath(OutputParameter)
    End Sub
    Private Sub ReferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferenceToolStripMenuItem.Click
        Me.ChangeCompileReferencePath(ReferenceParameter)
    End Sub
    Private Sub ChangeVersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeVersionToolStripMenuItem.Click
        Me.txtPath.Text = GetPath(False, Me.txtPath.Text)
        Me.txtVersion.Text = Path.GetFileName(txtPath.Text)
    End Sub
    Private Sub BtnCompile_Click(sender As Object, e As EventArgs) Handles BtnCompile.Click
        Me.txtCompile.Text = GetPath(False, Me.txtCompile.Text)
    End Sub
    Private Sub BtnReference_Click(sender As Object, e As EventArgs) Handles BtnReference.Click
        Me.txtReference.Text = GetPath(False, Me.txtReference.Text)
    End Sub
    Private Sub BtnSolution_Click(sender As Object, e As EventArgs) Handles BtnSolution.Click
        Me.txtSolution.Text = GetPath(True, Me.txtSolution.Text)
    End Sub
    Private Sub BtnPublisher_Click(sender As Object, e As EventArgs) Handles BtnPublisher.Click
        Me.txtPublisher.Text = GetPath(True, Me.txtPublisher.Text)
    End Sub
    Private Sub BtnPublishTo_Click(sender As Object, e As EventArgs) Handles BtnPublishTo.Click
        Me.txtPublishTo.Text = GetPath(False, Me.txtPublishTo.Text)
    End Sub
    Private Sub BtnMSBuild_Click(sender As Object, e As EventArgs) Handles BtnMSBuild.Click
        Me.txtMSBuild.Text = GetPath(True, Me.txtMSBuild.Text)
    End Sub
    Private Sub Grd_DoubleClick(sender As Object, e As EventArgs) Handles grd.DoubleClick
        If grd.SelectedItems IsNot Nothing Then
            Dim selectedPath As String = grd.SelectedItem.ToString
            Dim directoryPath As String = Path.GetDirectoryName(selectedPath)
            Process.Start("explorer.exe", directoryPath)
        End If
    End Sub

    Private Sub ChbxSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles ChbxSelectAll.CheckedChanged
        For i As Integer = 0 To grd.Items.Count - 1
            grd.SetSelected(i, ChbxSelectAll.Checked)
        Next
    End Sub
#Region "Dark/Light Mode"
    Private Sub DarkModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkModeToolStripMenuItem.Click
        ToggleDarkMode()
    End Sub
    Private Sub ToggleDarkMode()
        If config.Version.ThemeMode = "Light" Then
            ApplyDarkMode()
        Else
            ApplyLightMode()
        End If
    End Sub

    Private Sub ToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.MouseEnter, RetrieveToolStripMenuItem.MouseEnter, CompileToolStripMenuItem.MouseEnter, ReferenceToolStripMenuItem.MouseEnter, BuildToolStripMenuItem.MouseEnter, ReleaseToolStripMenuItem.MouseEnter, FileToolStripMenuItem.MouseEnter, EditToolStripMenuItem.MouseEnter, ToolsToolStripMenuItem.MouseEnter
        '' Change the background color when the mouse enters
        'If config.Version.ThemeMode = "Dark" Then
        '    Dim menuItem As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        '    menuItem.ForeColor = SystemColors.ControlText ' Set your desired text color
        'End If
    End Sub
    Private Sub ToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.MouseLeave, RetrieveToolStripMenuItem.MouseLeave, CompileToolStripMenuItem.MouseLeave, ReferenceToolStripMenuItem.MouseLeave, BuildToolStripMenuItem.MouseLeave, ReleaseToolStripMenuItem.MouseLeave, FileToolStripMenuItem.MouseLeave, EditToolStripMenuItem.MouseLeave, ToolsToolStripMenuItem.MouseLeave
        '' Change the background color when the mouse enters
        'If config.Version.ThemeMode = "Dark" Then
        '    Dim menuItem As ToolStripMenuItem = DirectCast(sender, ToolStripMenuItem)
        '    menuItem.ForeColor = SystemColors.ControlLightLight ' Set your desired text color
        'End If
    End Sub

    Private Sub ApplyDarkMode()
        'Me.BackColor = Color.FromArgb(52, 53, 65)
        'colorProgressBar.ProgressBarColor = Color.Yellow

        'For Each control As Control In Me.Controls
        '    control.BackColor = Color.FromArgb(52, 53, 65)
        '    control.ForeColor = Color.White
        'Next
        ''Panel2.BackColor = SystemColors.ControlText
        ''Panel3.BackColor = SystemColors.ControlText
        ''Panel6.BackColor = SystemColors.ControlText
        'StatusStrip1.BackColor = SystemColors.ControlText
        'MenuStrip1.BackgroundImage = Nothing
        'MenuStrip1.BackColor = SystemColors.ControlText
        'MenuStrip3.BackColor = SystemColors.ControlText
        'ReleaseToolStripMenuItem.BackColor = SystemColors.ControlText
        'FileToolStripMenuItem.BackColor = SystemColors.ControlText
        'For Each ToolStripMenuItem As ToolStripMenuItem In {UpdateToolStripMenuItem, RetrieveToolStripMenuItem, CompileToolStripMenuItem, ReferenceToolStripMenuItem, BuildToolStripMenuItem, ReleaseToolStripMenuItem}
        '    ToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        'Next
        'For Each ToolStripMenuItem As ToolStripMenuItem In {FileToolStripMenuItem, EditToolStripMenuItem, ToolsToolStripMenuItem}
        '    ToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        'Next
        'DarkModeToolStripMenuItem.Text = "Light Mode"

        'config.Version.ThemeMode = "Dark"
        'FillJson(config, ConfigPath)
    End Sub

    Private Sub ApplyLightMode()
        'Me.BackColor = Color.FromArgb(199, 215, 231)
        'colorProgressBar.ProgressBarColor = Color.FromArgb(20, 237, 251)
        'For Each control As Control In Me.Controls
        '    control.BackColor = SystemColors.Control
        '    control.ForeColor = SystemColors.ControlText
        'Next
        'MenuStrip3.BackColor = SystemColors.Menu
        'FileToolStripMenuItem.BackColor = SystemColors.Menu
        'MenuStrip1.BackgroundImage = My.Resources.PaleBlue
        'MenuStrip1.BackColor = Color.FromArgb(199, 215, 231)
        'MenuStrip3.BackColor = Color.FromArgb(199, 215, 231)
        ''Panel2.BackColor = SystemColors.ActiveCaption
        ''Panel3.BackColor = SystemColors.ActiveCaption
        'For Each label As Label In {Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, lblSelectAll}
        '    label.BackColor = Color.FromArgb(199, 215, 231)
        'Next
        'For Each ToolStripMenuItem As ToolStripMenuItem In {UpdateToolStripMenuItem, RetrieveToolStripMenuItem, CompileToolStripMenuItem, ReferenceToolStripMenuItem, BuildToolStripMenuItem, ReleaseToolStripMenuItem}
        '    ToolStripMenuItem.ForeColor = SystemColors.ControlText
        'Next
        'For Each ToolStripMenuItem As ToolStripMenuItem In {FileToolStripMenuItem, EditToolStripMenuItem, ToolsToolStripMenuItem}
        '    ToolStripMenuItem.ForeColor = SystemColors.ControlText
        'Next
        'DarkModeToolStripMenuItem.Text = "Dark Mode"
        'config.Version.ThemeMode = "Light"
        'FillJson(config, ConfigPath)
    End Sub

    Private Sub ApplyThemeFromConfig()
        'If config IsNot Nothing AndAlso config.Version IsNot Nothing Then
        '    If config.Version.ThemeMode = "Dark" Then
        '        ApplyDarkMode()
        '    Else
        '        ApplyLightMode()
        '    End If
        'End If
    End Sub

#End Region

#Region "Blue Progress Bar"
    Public Sub New()
        InitializeComponent()
        'Control Progress Bar Size
        colorProgressBar.Location = New Point(0, 453)
        colorProgressBar.Size = New Size(1017, 10)
        ' Add Progress Bar
        Me.Controls.Add(colorProgressBar)
        'Progress Bar Design
        colorProgressBar.BringToFront()
        StatusStrip1.Dock = DockStyle.Bottom
        colorProgressBar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
    End Sub
#End Region

End Class

