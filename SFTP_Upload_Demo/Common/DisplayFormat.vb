Imports SFTP_Upload_Demo.Base

Namespace Common
    Public Class DisplayFormat : Inherits SingletonBase(Of DisplayFormat)

        Private Sub New()
        End Sub

        Public Function FormatBytes(bytesCaller As ULong) As String
            Dim doubleBytes As Double
            Try
                Select Case bytesCaller
                    Case Is >= 1099511627776
                        doubleBytes = CDbl(bytesCaller / 1099511627776) 'TB
                        Return FormatNumber(doubleBytes, 2) & " TB"
                    Case 1073741824 To 1099511627775
                        doubleBytes = CDbl(bytesCaller / 1073741824) 'GB
                        Return FormatNumber(doubleBytes, 2) & " GB"
                    Case 1048576 To 1073741823
                        doubleBytes = CDbl(bytesCaller / 1048576) 'MB
                        Return FormatNumber(doubleBytes, 2) & " MB"
                    Case 1024 To 1048575
                        doubleBytes = CDbl(bytesCaller / 1024) 'KB
                        Return FormatNumber(doubleBytes, 2) & " KB"
                    Case 0 To 1023
                        doubleBytes = bytesCaller ' bytes
                        Return FormatNumber(doubleBytes, 2) & " bytes"
                    Case Else
                        Return ""
                End Select
            Catch
                Return ""
            End Try

        End Function
    End Class
End Namespace