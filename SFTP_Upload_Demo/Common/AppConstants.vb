Namespace Common
    Public Class AppConstants
        Public Shared ReadOnly SftpServerName As String = My.Settings.Default.Server
        Public Shared ReadOnly SftpServerUserName As String = My.Settings.Default.UserName
        Public Shared ReadOnly SftpServerPassword As String = My.Settings.Default.Password
        Public Shared ReadOnly SftpServerPath As String = My.Settings.Default.ServerUploadPath
        Public Shared ReadOnly ServerRootPath As String = My.Settings.Default.ServerRootPath
    End Class
End Namespace