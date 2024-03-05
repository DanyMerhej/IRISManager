Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json
Imports System.Diagnostics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Security.Cryptography

Public Class FrmHome
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

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = "Ready"
        ProgressBar.Maximum = 100
        json = File.ReadAllText(ConfigPath)
        config = JsonConvert.DeserializeObject(Of Variables)(json)
        Dim jsonFiles = Directory.GetFiles(Application.StartupPath & "\" & jsonFolderPath, "*.json").
        Where(Function(file) Path.GetFileName(file) <> MainJSONFile).ToArray()
        ToolStripComboBoxRelease.Items.AddRange(jsonFiles.Select(Function(file) Path.GetFileName(file)).ToArray())
        'ToolStripComboBoxRelease.SelectedItem = MainJSONFile
        Me.FillTextBoxes(config)
    End Sub
    Private Sub FillTextBoxes(ByVal _Json As Variables)
        Me.txtVersion.Text = _Json.Version.VersionName
        Me.txtPath.Text = _Json.Version.VersionPath
        Me.txtCompile.Text = _Json.Version.VersionCompilePath
        Me.txtReference.Text = _Json.Version.VersionReferencePath
        Me.txtSolution.Text = _Json.Version.VersionMainSolutionPath
        Me.txtPublisher.Text = _Json.Version.PublisherPath
        Me.txtPublishTo.Text = _Json.Version.PublishPath
        Me.txtMSBuild.Text = _Json.Version.MSBuildPath
        Me.targetExtension = _Json.Version.ProjectExtension
    End Sub
    Private Sub FillJson(ByVal _Json As Variables, ByVal _Path As String)
        Try
            Me.ProgressBar.Value = 0
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
            Me.ProgressBar.Value = 100
            lblStatus.Text = "New JSON saved successfully"
        Catch ex As Exception
            lblStatus.Text = "Error saving changes"
        End Try
    End Sub
    Private Sub ChangeCompileReferencePath(ByVal _Parameter As String)
        Me.ProgressBar.Value = 0

        If grd.Items.Count > 0 AndAlso grd.SelectedItems.Count > 0 Then
            For Each selectedItem As Object In grd.SelectedItems
                If File.Exists(selectedItem) Then
                    Dim projectXml As New XmlDocument()
                    projectXml.Load(selectedItem)
                    Dim userProjectPath As String = Path.ChangeExtension(selectedItem, ".vbproj.user")
                    Dim userProjectXml As New XmlDocument()
                    If File.Exists(userProjectPath) Then
                        userProjectXml.Load(userProjectPath)
                    End If
                    Dim outputPathNode As XmlNode = projectXml.SelectSingleNode("//ns:" & OutputParameter & "Path", GetNamespaceManager(projectXml))
                    If outputPathNode IsNot Nothing Then
                        outputPathNode.InnerText = Me.txtCompile.Text
                    End If
                    Dim referencePathNode As XmlNode = userProjectXml.SelectSingleNode("//ns:" & ReferenceParameter & "Path", GetNamespaceManager(userProjectXml))
                    If referencePathNode IsNot Nothing Then
                        referencePathNode.InnerText = Me.txtReference.Text
                    End If
                    projectXml.Save(selectedItem)
                    userProjectXml.Save(userProjectPath)
                    Me.ProgressBar.Value += 100 \ grd.SelectedItems.Count
                Else
                    lblStatus.Text = "Project file not found"
                End If
            Next
            lblStatus.Text = "Paths updated successfully"
        Else
            lblStatus.Text = "Choose projects before proceeding"
        End If

        Me.ProgressBar.Value = 100
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
        Me.ProgressBar.Value = 0
        If grd.Items.Count > 0 Then
            lblStatus.Text = "Building ..."
            Refresh()
            For Each selectedItem As Object In grd.SelectedItems
                Me.ProgressBar.Value += 100 \ grd.SelectedItems.Count
                Dim projectPath As String = selectedItem
                Me.ExecuteCmdCommand(New ProcessStartInfo(), config.Version.MSBuildPath, $"""{projectPath}"" /t:Rebuild /p:Configuration=Debug")
                lblStatus.Text = "Build successfull"
            Next
        Else
            lblStatus.Text = "Choose projects to build"
        End If
        Me.ProgressBar.Value = 100
    End Sub
    Private Sub ReleaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReleaseToolStripMenuItem.Click
        Me.ProgressBar.Value = 0
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

            Me.ProgressBar.Value = 100
        End If
    End Sub
    Private Sub RetrieveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetrieveToolStripMenuItem.Click
        fileList.Clear()
        grd.DataSource = Nothing
        Me.ProcessFiles(Me.txtPath.Text, targetExtension)
        If fileList.Count > 0 Then
            grd.DataSource = fileList
            lblStatus.Text = "Found a new list to process"
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

#Region "Log"
    Private Function WriteLog() As Boolean

        Dim folderPathNew As String = config.Version.PublishPath & "\Application Files\Pixel.Iris2.Publisher_" & Me.LogVersion

        Dim datestring As Integer = LogVersion.LastIndexOf("_")

        Dim dateresult As String = LogVersion.Substring(0, datestring)
        Dim versionresult As Integer = LogVersion.Split("_"c).Last()

        Dim basefolder As String = config.Version.PublishPath & "\Application Files\"
        Dim targetFolderName As String = $"Pixel.Iris2.Publisher_{dateresult}_{versionresult}"

        Dim previousVersion As Integer = FindLatestAvailableVersion(basefolder, dateresult, versionresult)
        If previousVersion <> -1 Then
            Dim previousFolderName As String = $"Pixel.Iris2.Publisher_{dateresult}_{previousVersion}"

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
                        writer.WriteLine($"  {updatedFile} - Updated on {File.GetLastWriteTime(updatedFile)}")
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

        Dim yesterday As DateTime = DateTime.Now.AddDays(-1)
        Dim formatyesterday As String = yesterday.ToString("yyyy_MM_dd")

        Return FindLatestAvailableVersion(baseFolder, formatyesterday, currentVersion)
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
        If ChbxSelectAll.Checked Then
            For i As Integer = 0 To grd.Items.Count - 1
                grd.SetSelected(i, True)
            Next
        Else
            For i As Integer = 0 To grd.Items.Count - 1
                grd.SetSelected(i, False)
            Next
        End If
    End Sub
End Class
