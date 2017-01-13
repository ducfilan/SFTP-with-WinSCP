<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilesPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowseFiles = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.stsInfo = New System.Windows.Forms.StatusStrip()
        Me.stsInfoprgrUpload = New System.Windows.Forms.ToolStripProgressBar()
        Me.stsInfolblServerName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsInfolblUserName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtPathToUpload = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDeleteSelectedFile = New System.Windows.Forms.Button()
        Me.btnFetchServerDirectoryToDelete = New System.Windows.Forms.Button()
        Me.trvFoldersRemoteToDelete = New System.Windows.Forms.TreeView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRenameSelectedFile = New System.Windows.Forms.Button()
        Me.btnFetchServerDirectoryToRename = New System.Windows.Forms.Button()
        Me.trvFoldersRemoteToRename = New System.Windows.Forms.TreeView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnViewInfoSelectedFile = New System.Windows.Forms.Button()
        Me.btnFetchServerDirectoryToViewInfo = New System.Windows.Forms.Button()
        Me.trvFoldersRemoteToViewInfo = New System.Windows.Forms.TreeView()
        Me.stsInfo.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.TabPage3.SuspendLayout
        Me.TabPage4.SuspendLayout
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select files to upload"
        '
        'txtFilesPath
        '
        Me.txtFilesPath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtFilesPath.Location = New System.Drawing.Point(128, 11)
        Me.txtFilesPath.Multiline = true
        Me.txtFilesPath.Name = "txtFilesPath"
        Me.txtFilesPath.Size = New System.Drawing.Size(528, 123)
        Me.txtFilesPath.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(712, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Upload to SFTP Server Demo Application | H-Duc@BEEPLANETZ"
        '
        'btnBrowseFiles
        '
        Me.btnBrowseFiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnBrowseFiles.Location = New System.Drawing.Point(662, 9)
        Me.btnBrowseFiles.Name = "btnBrowseFiles"
        Me.btnBrowseFiles.Size = New System.Drawing.Size(108, 23)
        Me.btnBrowseFiles.TabIndex = 3
        Me.btnBrowseFiles.Text = "Browse Files"
        Me.btnBrowseFiles.UseVisualStyleBackColor = true
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Multiselect = true
        '
        'stsInfo
        '
        Me.stsInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsInfoprgrUpload, Me.stsInfolblServerName, Me.stsInfolblUserName})
        Me.stsInfo.Location = New System.Drawing.Point(0, 339)
        Me.stsInfo.Name = "stsInfo"
        Me.stsInfo.Size = New System.Drawing.Size(784, 23)
        Me.stsInfo.TabIndex = 4
        Me.stsInfo.Text = "StatusStrip1"
        '
        'stsInfoprgrUpload
        '
        Me.stsInfoprgrUpload.Name = "stsInfoprgrUpload"
        Me.stsInfoprgrUpload.Size = New System.Drawing.Size(100, 17)
        '
        'stsInfolblServerName
        '
        Me.stsInfolblServerName.Name = "stsInfolblServerName"
        Me.stsInfolblServerName.Size = New System.Drawing.Size(56, 18)
        Me.stsInfolblServerName.Text = "Server: "
        '
        'stsInfolblUserName
        '
        Me.stsInfolblUserName.Name = "stsInfolblUserName"
        Me.stsInfolblUserName.Size = New System.Drawing.Size(92, 18)
        Me.stsInfolblUserName.Text = "|  UserName: "
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 293)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtPathToUpload)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnUpload)
        Me.TabPage1.Controls.Add(Me.txtFilesPath)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnBrowseFiles)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 267)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Upload"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'txtPathToUpload
        '
        Me.txtPathToUpload.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtPathToUpload.Location = New System.Drawing.Point(128, 148)
        Me.txtPathToUpload.Name = "txtPathToUpload"
        Me.txtPathToUpload.Size = New System.Drawing.Size(528, 19)
        Me.txtPathToUpload.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(6, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Specify Relative Path"
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpload.BackColor = System.Drawing.Color.LimeGreen
        Me.btnUpload.Font = New System.Drawing.Font("MS UI Gothic", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnUpload.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUpload.Location = New System.Drawing.Point(281, 175)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(220, 86)
        Me.btnUpload.TabIndex = 4
        Me.btnUpload.Text = "START UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = false
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnDeleteSelectedFile)
        Me.TabPage2.Controls.Add(Me.btnFetchServerDirectoryToDelete)
        Me.TabPage2.Controls.Add(Me.trvFoldersRemoteToDelete)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 267)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Delete"
        Me.TabPage2.UseVisualStyleBackColor = true
        '
        'btnDeleteSelectedFile
        '
        Me.btnDeleteSelectedFile.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDeleteSelectedFile.BackColor = System.Drawing.Color.Red
        Me.btnDeleteSelectedFile.Font = New System.Drawing.Font("MS UI Gothic", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnDeleteSelectedFile.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDeleteSelectedFile.Location = New System.Drawing.Point(548, 142)
        Me.btnDeleteSelectedFile.Name = "btnDeleteSelectedFile"
        Me.btnDeleteSelectedFile.Size = New System.Drawing.Size(220, 86)
        Me.btnDeleteSelectedFile.TabIndex = 6
        Me.btnDeleteSelectedFile.Text = "DELETE SELECTED"
        Me.btnDeleteSelectedFile.UseVisualStyleBackColor = false
        '
        'btnFetchServerDirectoryToDelete
        '
        Me.btnFetchServerDirectoryToDelete.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFetchServerDirectoryToDelete.BackColor = System.Drawing.Color.LimeGreen
        Me.btnFetchServerDirectoryToDelete.Font = New System.Drawing.Font("MS UI Gothic", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnFetchServerDirectoryToDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnFetchServerDirectoryToDelete.Location = New System.Drawing.Point(548, 38)
        Me.btnFetchServerDirectoryToDelete.Name = "btnFetchServerDirectoryToDelete"
        Me.btnFetchServerDirectoryToDelete.Size = New System.Drawing.Size(220, 86)
        Me.btnFetchServerDirectoryToDelete.TabIndex = 5
        Me.btnFetchServerDirectoryToDelete.Text = "FETCH"
        Me.btnFetchServerDirectoryToDelete.UseVisualStyleBackColor = false
        '
        'trvFoldersRemoteToDelete
        '
        Me.trvFoldersRemoteToDelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.trvFoldersRemoteToDelete.Location = New System.Drawing.Point(8, 6)
        Me.trvFoldersRemoteToDelete.Name = "trvFoldersRemoteToDelete"
        Me.trvFoldersRemoteToDelete.Size = New System.Drawing.Size(534, 255)
        Me.trvFoldersRemoteToDelete.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtNewName)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.btnRenameSelectedFile)
        Me.TabPage3.Controls.Add(Me.btnFetchServerDirectoryToRename)
        Me.TabPage3.Controls.Add(Me.trvFoldersRemoteToRename)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(776, 267)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Rename"
        Me.TabPage3.UseVisualStyleBackColor = true
        '
        'txtNewName
        '
        Me.txtNewName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtNewName.Location = New System.Drawing.Point(97, 11)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(445, 19)
        Me.txtNewName.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(8, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "New File Name"
        '
        'btnRenameSelectedFile
        '
        Me.btnRenameSelectedFile.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRenameSelectedFile.BackColor = System.Drawing.Color.Red
        Me.btnRenameSelectedFile.Font = New System.Drawing.Font("MS UI Gothic", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnRenameSelectedFile.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnRenameSelectedFile.Location = New System.Drawing.Point(548, 142)
        Me.btnRenameSelectedFile.Name = "btnRenameSelectedFile"
        Me.btnRenameSelectedFile.Size = New System.Drawing.Size(220, 86)
        Me.btnRenameSelectedFile.TabIndex = 9
        Me.btnRenameSelectedFile.Text = "RENAME SELECTED"
        Me.btnRenameSelectedFile.UseVisualStyleBackColor = false
        '
        'btnFetchServerDirectoryToRename
        '
        Me.btnFetchServerDirectoryToRename.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFetchServerDirectoryToRename.BackColor = System.Drawing.Color.LimeGreen
        Me.btnFetchServerDirectoryToRename.Font = New System.Drawing.Font("MS UI Gothic", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnFetchServerDirectoryToRename.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnFetchServerDirectoryToRename.Location = New System.Drawing.Point(548, 38)
        Me.btnFetchServerDirectoryToRename.Name = "btnFetchServerDirectoryToRename"
        Me.btnFetchServerDirectoryToRename.Size = New System.Drawing.Size(220, 86)
        Me.btnFetchServerDirectoryToRename.TabIndex = 8
        Me.btnFetchServerDirectoryToRename.Text = "FETCH"
        Me.btnFetchServerDirectoryToRename.UseVisualStyleBackColor = false
        '
        'trvFoldersRemoteToRename
        '
        Me.trvFoldersRemoteToRename.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.trvFoldersRemoteToRename.Location = New System.Drawing.Point(8, 38)
        Me.trvFoldersRemoteToRename.Name = "trvFoldersRemoteToRename"
        Me.trvFoldersRemoteToRename.Size = New System.Drawing.Size(534, 223)
        Me.trvFoldersRemoteToRename.TabIndex = 7
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnViewInfoSelectedFile)
        Me.TabPage4.Controls.Add(Me.btnFetchServerDirectoryToViewInfo)
        Me.TabPage4.Controls.Add(Me.trvFoldersRemoteToViewInfo)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(776, 267)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Dir"
        Me.TabPage4.UseVisualStyleBackColor = true
        '
        'btnViewInfoSelectedFile
        '
        Me.btnViewInfoSelectedFile.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnViewInfoSelectedFile.BackColor = System.Drawing.Color.LimeGreen
        Me.btnViewInfoSelectedFile.Font = New System.Drawing.Font("MS UI Gothic", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnViewInfoSelectedFile.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnViewInfoSelectedFile.Location = New System.Drawing.Point(548, 142)
        Me.btnViewInfoSelectedFile.Name = "btnViewInfoSelectedFile"
        Me.btnViewInfoSelectedFile.Size = New System.Drawing.Size(220, 86)
        Me.btnViewInfoSelectedFile.TabIndex = 9
        Me.btnViewInfoSelectedFile.Text = "VIEW INFO"
        Me.btnViewInfoSelectedFile.UseVisualStyleBackColor = false
        '
        'btnFetchServerDirectoryToViewInfo
        '
        Me.btnFetchServerDirectoryToViewInfo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFetchServerDirectoryToViewInfo.BackColor = System.Drawing.Color.LimeGreen
        Me.btnFetchServerDirectoryToViewInfo.Font = New System.Drawing.Font("MS UI Gothic", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
        Me.btnFetchServerDirectoryToViewInfo.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnFetchServerDirectoryToViewInfo.Location = New System.Drawing.Point(548, 38)
        Me.btnFetchServerDirectoryToViewInfo.Name = "btnFetchServerDirectoryToViewInfo"
        Me.btnFetchServerDirectoryToViewInfo.Size = New System.Drawing.Size(220, 86)
        Me.btnFetchServerDirectoryToViewInfo.TabIndex = 8
        Me.btnFetchServerDirectoryToViewInfo.Text = "FETCH"
        Me.btnFetchServerDirectoryToViewInfo.UseVisualStyleBackColor = false
        '
        'trvFoldersRemoteToViewInfo
        '
        Me.trvFoldersRemoteToViewInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.trvFoldersRemoteToViewInfo.Location = New System.Drawing.Point(8, 6)
        Me.trvFoldersRemoteToViewInfo.Name = "trvFoldersRemoteToViewInfo"
        Me.trvFoldersRemoteToViewInfo.Size = New System.Drawing.Size(534, 255)
        Me.trvFoldersRemoteToViewInfo.TabIndex = 7
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.stsInfo)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Main"
        Me.stsInfo.ResumeLayout(false)
        Me.stsInfo.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage3.ResumeLayout(false)
        Me.TabPage3.PerformLayout
        Me.TabPage4.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFilesPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBrowseFiles As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents stsInfo As StatusStrip
    Friend WithEvents stsInfoprgrUpload As ToolStripProgressBar
    Friend WithEvents stsInfolblServerName As ToolStripStatusLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnUpload As Button
    Friend WithEvents txtPathToUpload As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents stsInfolblUserName As ToolStripStatusLabel
    Friend WithEvents trvFoldersRemoteToDelete As TreeView
    Friend WithEvents btnFetchServerDirectoryToDelete As Button
    Friend WithEvents btnDeleteSelectedFile As Button
    Friend WithEvents btnRenameSelectedFile As Button
    Friend WithEvents btnFetchServerDirectoryToRename As Button
    Friend WithEvents trvFoldersRemoteToRename As TreeView
    Friend WithEvents txtNewName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnViewInfoSelectedFile As Button
    Friend WithEvents btnFetchServerDirectoryToViewInfo As Button
    Friend WithEvents trvFoldersRemoteToViewInfo As TreeView
End Class
