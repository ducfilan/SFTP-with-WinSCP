Imports SFTP_Upload_Demo.Common
Imports SFTP_Upload_Demo.My
Imports WinSCP

Public Class FormMain
    Private Sub btnBrowseFiles_Click(sender As Object, e As EventArgs) Handles btnBrowseFiles.Click
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            txtFilesPath.Text = String.Join(Environment.NewLine, OpenFileDialog.FileNames)
        End If
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stsInfolblServerName.Text += MySettings.Default.Server
        stsInfolblUserName.Text += MySettings.Default.UserName
        txtPathToUpload.Text = MySettings.Default.ServerUploadPath
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        UploadFiles(OpenFileDialog.FileNames, txtPathToUpload.Text)
    End Sub

    Private Sub UploadFiles(fileNames As String(), pathOnServerToUpload As String)
        stsInfoprgrUpload.Value = 0

        Dim totalFilesCount As Integer = fileNames.Count
        Dim transferedFilesCount = 0

        For Each fileName As String In fileNames
            If FtpTransfer.Instance.UploadSftp(fileName, pathOnServerToUpload) Then
                transferedFilesCount += 1
                stsInfoprgrUpload.Value = Int(transferedFilesCount * 100 / totalFilesCount)
            End If
        Next

        MessageBox.Show(Me, "All selected files are uploaded successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnFetchServerDirectory_Click(sender As Object, e As EventArgs) Handles btnFetchServerDirectoryToDelete.Click
        trvFoldersRemoteToDelete.Nodes.Clear()

        Dim fileInfos As IEnumerable(Of RemoteFileInfo) = FtpTransfer.Instance.GetRemoteDirectoryFileInfo()

        AddFileToTree(fileInfos, trvFoldersRemoteToDelete.Nodes)

        trvFoldersRemoteToDelete.ExpandAll()
    End Sub

    Private Sub AddFileToTree(fileInfos As IEnumerable(Of RemoteFileInfo), nodeToAdd As TreeNodeCollection)
        For Each fileInfo As RemoteFileInfo In fileInfos
            Dim currentNodeNumber = nodeToAdd.Add(New TreeNode(fileInfo.Name))

            If fileInfo.IsDirectory Then
                AddFileToTree(FtpTransfer.Instance.GetRemoteDirectoryFileInfo(fileInfo.FullName), nodeToAdd(currentNodeNumber).Nodes)
            End If
        Next
    End Sub

    Private Sub btnDeleteSelectedFile_Click(sender As Object, e As EventArgs) Handles btnDeleteSelectedFile.Click
        Dim selectedFilePathInServer = AppConstants.ServerRootPath + trvFoldersRemoteToDelete.SelectedNode.FullPath.Replace("\", "/")
        trvFoldersRemoteToDelete.SelectedNode.Remove()

        FtpTransfer.Instance.DeleteFile(selectedFilePathInServer)
    End Sub

    Private Sub btnFetchServerDirectoryToRename_MouseClick(sender As Object, e As MouseEventArgs) Handles btnFetchServerDirectoryToRename.MouseClick
        trvFoldersRemoteToRename.Nodes.Clear()

        Dim fileInfos As IEnumerable(Of RemoteFileInfo) = FtpTransfer.Instance.GetRemoteDirectoryFileInfo()

        AddFileToTree(fileInfos, trvFoldersRemoteToRename.Nodes)

        trvFoldersRemoteToRename.ExpandAll()
    End Sub

    Private Sub btnRenameSelectedFile_Click(sender As Object, e As EventArgs) Handles btnRenameSelectedFile.Click
        Dim selectedFilePathInServer = AppConstants.ServerRootPath + trvFoldersRemoteToRename.SelectedNode.FullPath.Replace("\", "/")
        trvFoldersRemoteToRename.SelectedNode.Text = txtNewName.Text

        FtpTransfer.Instance.RenameFile(selectedFilePathInServer, txtNewName.Text)
    End Sub

    Private Sub btnFetchServerDirectoryToViewInfo_Click(sender As Object, e As EventArgs) Handles btnFetchServerDirectoryToViewInfo.Click
        trvFoldersRemoteToViewInfo.Nodes.Clear()

        Dim fileInfos As IEnumerable(Of RemoteFileInfo) = FtpTransfer.Instance.GetRemoteDirectoryFileInfo()

        AddFileToTree(fileInfos, trvFoldersRemoteToViewInfo.Nodes)

        trvFoldersRemoteToViewInfo.ExpandAll()
    End Sub

    Private Sub btnViewInfoSelectedFile_Click(sender As Object, e As EventArgs) Handles btnViewInfoSelectedFile.Click
        Dim selectedFilePathInServer = AppConstants.ServerRootPath + trvFoldersRemoteToViewInfo.SelectedNode.FullPath.Replace("\", "/")

        Dim fileInfo As RemoteFileInfo = FtpTransfer.Instance.ViewInfoFile(selectedFilePathInServer)

        Dim fileInfoInText As String = "FullName: " + fileInfo.FullName + Environment.NewLine +
            "File size: " + DisplayFormat.Instance.FormatBytes(fileInfo.Length) + Environment.NewLine +
            "Last modified: " + fileInfo.LastWriteTime.ToString("F")

        MessageBox.Show(Me, fileInfoInText, "File Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

