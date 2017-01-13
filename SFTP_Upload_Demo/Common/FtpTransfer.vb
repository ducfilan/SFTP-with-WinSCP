Imports SFTP_Upload_Demo.Base
Imports WinSCP

Namespace Common
    Public Class FtpTransfer : Inherits SingletonBase(Of FtpTransfer)
        Private Sub New()
        End Sub

        Private _sessionOption As SessionOptions = Nothing
        Private ReadOnly Property SessionOption As SessionOptions
            Get
                If _sessionOption Is Nothing Then
                    _sessionOption = New SessionOptions With {
                        .Protocol = Protocol.Sftp,
                        .HostName = AppConstants.SftpServerName,
                        .UserName = AppConstants.SftpServerUserName,
                        .Password = AppConstants.SftpServerPassword
                    }
                End If

                Return _sessionOption
            End Get
        End Property

        Public Function UploadSftp(fileName As String, Optional serverPath As String = Nothing) As Boolean
            If serverPath Is Nothing Then
                serverPath = AppConstants.SftpServerPath
            End If

            Try
                Using session As New Session
                    SessionOption.SshHostKeyFingerprint = session.ScanFingerprint(New SessionOptions With {.Protocol = Protocol.Sftp, .HostName = AppConstants.SftpServerName})
                    session.Open(SessionOption)

                    Dim transferOptions As New TransferOptions
                    transferOptions.TransferMode = TransferMode.Binary

                    Dim transferResult As TransferOperationResult = session.PutFiles(fileName, serverPath, False, transferOptions)

                    ' Throw on any error
                    transferResult.Check()

                    Return transferResult.IsSuccess
                End Using
            Catch e As Exception
                Return False
            End Try
        End Function

        Public Function GetRemoteDirectoryFileInfo(Optional directoryToAdd As String = Nothing, Optional isEnumerateAllDirectories As Boolean = False) As IEnumerable(Of RemoteFileInfo)
            If directoryToAdd Is Nothing Then
                directoryToAdd = AppConstants.ServerRootPath
            End If
            Try
                Using session As New Session
                    SessionOption.SshHostKeyFingerprint = session.ScanFingerprint(New SessionOptions With {.Protocol = Protocol.Sftp, .HostName = AppConstants.SftpServerName})
                    session.Open(SessionOption)

                    Dim enumerateOptions = EnumerationOptions.MatchDirectories
                    If isEnumerateAllDirectories Then
                        enumerateOptions = EnumerationOptions.EnumerateDirectories Or EnumerationOptions.AllDirectories
                    End If

                    Return session.EnumerateRemoteFiles(directoryToAdd, Nothing, enumerateOptions).ToList()
                End Using
            Catch ex As Exception
                Return New List(Of RemoteFileInfo)()
            End Try
        End Function

        Public Function DeleteFile(filePath As String) As Boolean
            Try
                Using session As New Session
                    SessionOption.SshHostKeyFingerprint = session.ScanFingerprint(New SessionOptions With {.Protocol = Protocol.Sftp, .HostName = AppConstants.SftpServerName})
                    session.Open(SessionOption)

                    session.RemoveFiles(filePath)

                    Return True
                End Using
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function RenameFile(filePath As String, newName As String) As Boolean
            Try
                Dim newFilePath = filePath.Substring(0, filePath.Length - filePath.Split("/").Last().Length) + newName

                Using session As New Session
                    SessionOption.SshHostKeyFingerprint = session.ScanFingerprint(New SessionOptions With {.Protocol = Protocol.Sftp, .HostName = AppConstants.SftpServerName})
                    session.Open(SessionOption)

                    session.MoveFile(filePath, newFilePath)

                    Return True
                End Using
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function ViewInfoFile(filePath As String) As RemoteFileInfo
            Try
                Using session As New Session
                    SessionOption.SshHostKeyFingerprint = session.ScanFingerprint(New SessionOptions With {.Protocol = Protocol.Sftp, .HostName = AppConstants.SftpServerName})
                    session.Open(SessionOption)

                    Return session.GetFileInfo(filePath)
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
    End Class
End Namespace