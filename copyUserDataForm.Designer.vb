<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class copyUserDataForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buEdgBookmarks = New System.Windows.Forms.Button()
        Me.buFileExplorerQuickAccess = New System.Windows.Forms.Button()
        Me.buChromeBookmarks = New System.Windows.Forms.Button()
        Me.buOutlookSignatures = New System.Windows.Forms.Button()
        Me.buGetName = New System.Windows.Forms.Button()
        Me.buGetOldStatus = New System.Windows.Forms.Button()
        Me.buGetNewStatus = New System.Windows.Forms.Button()
        Me.stCustomerNTID = New System.Windows.Forms.TextBox()
        Me.stOldPcName = New System.Windows.Forms.TextBox()
        Me.stNewPcName = New System.Windows.Forms.TextBox()
        Me.lbCustomerNTID = New System.Windows.Forms.Label()
        Me.lbOldPcName = New System.Windows.Forms.Label()
        Me.lbNewPcName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel1.Controls.Add(Me.buEdgBookmarks)
        Me.Panel1.Controls.Add(Me.buFileExplorerQuickAccess)
        Me.Panel1.Controls.Add(Me.buChromeBookmarks)
        Me.Panel1.Controls.Add(Me.buOutlookSignatures)
        Me.Panel1.Controls.Add(Me.buGetName)
        Me.Panel1.Controls.Add(Me.buGetOldStatus)
        Me.Panel1.Controls.Add(Me.buGetNewStatus)
        Me.Panel1.Controls.Add(Me.stCustomerNTID)
        Me.Panel1.Controls.Add(Me.stOldPcName)
        Me.Panel1.Controls.Add(Me.stNewPcName)
        Me.Panel1.Controls.Add(Me.lbCustomerNTID)
        Me.Panel1.Controls.Add(Me.lbOldPcName)
        Me.Panel1.Controls.Add(Me.lbNewPcName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 577)
        Me.Panel1.TabIndex = 0
        '
        'buEdgBookmarks
        '
        Me.buEdgBookmarks.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buEdgBookmarks.Location = New System.Drawing.Point(124, 305)
        Me.buEdgBookmarks.Name = "buEdgBookmarks"
        Me.buEdgBookmarks.Size = New System.Drawing.Size(250, 35)
        Me.buEdgBookmarks.TabIndex = 26
        Me.buEdgBookmarks.Text = "Edge Bookmarks"
        Me.buEdgBookmarks.UseVisualStyleBackColor = True
        '
        'buFileExplorerQuickAccess
        '
        Me.buFileExplorerQuickAccess.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buFileExplorerQuickAccess.Location = New System.Drawing.Point(391, 362)
        Me.buFileExplorerQuickAccess.Name = "buFileExplorerQuickAccess"
        Me.buFileExplorerQuickAccess.Size = New System.Drawing.Size(250, 35)
        Me.buFileExplorerQuickAccess.TabIndex = 25
        Me.buFileExplorerQuickAccess.Text = "File Explorer Quick Access"
        Me.buFileExplorerQuickAccess.UseVisualStyleBackColor = True
        '
        'buChromeBookmarks
        '
        Me.buChromeBookmarks.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buChromeBookmarks.Location = New System.Drawing.Point(124, 362)
        Me.buChromeBookmarks.Name = "buChromeBookmarks"
        Me.buChromeBookmarks.Size = New System.Drawing.Size(250, 35)
        Me.buChromeBookmarks.TabIndex = 24
        Me.buChromeBookmarks.Text = "Chrome Bookmarks"
        Me.buChromeBookmarks.UseVisualStyleBackColor = True
        '
        'buOutlookSignatures
        '
        Me.buOutlookSignatures.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buOutlookSignatures.Location = New System.Drawing.Point(391, 305)
        Me.buOutlookSignatures.Name = "buOutlookSignatures"
        Me.buOutlookSignatures.Size = New System.Drawing.Size(250, 35)
        Me.buOutlookSignatures.TabIndex = 23
        Me.buOutlookSignatures.Text = "Outlook Signatures"
        Me.buOutlookSignatures.UseVisualStyleBackColor = True
        '
        'buGetName
        '
        Me.buGetName.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buGetName.Location = New System.Drawing.Point(431, 246)
        Me.buGetName.Name = "buGetName"
        Me.buGetName.Size = New System.Drawing.Size(210, 30)
        Me.buGetName.TabIndex = 22
        Me.buGetName.Text = "Customer Name"
        Me.buGetName.UseVisualStyleBackColor = True
        '
        'buGetOldStatus
        '
        Me.buGetOldStatus.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buGetOldStatus.Location = New System.Drawing.Point(431, 213)
        Me.buGetOldStatus.Name = "buGetOldStatus"
        Me.buGetOldStatus.Size = New System.Drawing.Size(210, 30)
        Me.buGetOldStatus.TabIndex = 21
        Me.buGetOldStatus.Text = "Old PC Online Status"
        Me.buGetOldStatus.UseVisualStyleBackColor = True
        '
        'buGetNewStatus
        '
        Me.buGetNewStatus.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buGetNewStatus.Location = New System.Drawing.Point(431, 180)
        Me.buGetNewStatus.Name = "buGetNewStatus"
        Me.buGetNewStatus.Size = New System.Drawing.Size(210, 30)
        Me.buGetNewStatus.TabIndex = 20
        Me.buGetNewStatus.Text = "New PC Online Status"
        Me.buGetNewStatus.UseVisualStyleBackColor = True
        '
        'stCustomerNTID
        '
        Me.stCustomerNTID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stCustomerNTID.Location = New System.Drawing.Point(262, 250)
        Me.stCustomerNTID.Name = "stCustomerNTID"
        Me.stCustomerNTID.Size = New System.Drawing.Size(156, 22)
        Me.stCustomerNTID.TabIndex = 19
        '
        'stOldPcName
        '
        Me.stOldPcName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stOldPcName.Location = New System.Drawing.Point(262, 217)
        Me.stOldPcName.Name = "stOldPcName"
        Me.stOldPcName.Size = New System.Drawing.Size(156, 22)
        Me.stOldPcName.TabIndex = 18
        '
        'stNewPcName
        '
        Me.stNewPcName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stNewPcName.Location = New System.Drawing.Point(262, 184)
        Me.stNewPcName.Name = "stNewPcName"
        Me.stNewPcName.Size = New System.Drawing.Size(156, 22)
        Me.stNewPcName.TabIndex = 17
        '
        'lbCustomerNTID
        '
        Me.lbCustomerNTID.AutoSize = True
        Me.lbCustomerNTID.BackColor = System.Drawing.Color.Transparent
        Me.lbCustomerNTID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCustomerNTID.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCustomerNTID.ForeColor = System.Drawing.Color.White
        Me.lbCustomerNTID.Location = New System.Drawing.Point(124, 248)
        Me.lbCustomerNTID.Name = "lbCustomerNTID"
        Me.lbCustomerNTID.Size = New System.Drawing.Size(131, 25)
        Me.lbCustomerNTID.TabIndex = 16
        Me.lbCustomerNTID.Text = "Customer NTID:"
        '
        'lbOldPcName
        '
        Me.lbOldPcName.AutoSize = True
        Me.lbOldPcName.BackColor = System.Drawing.Color.Transparent
        Me.lbOldPcName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOldPcName.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOldPcName.ForeColor = System.Drawing.Color.White
        Me.lbOldPcName.Location = New System.Drawing.Point(124, 215)
        Me.lbOldPcName.Name = "lbOldPcName"
        Me.lbOldPcName.Size = New System.Drawing.Size(115, 25)
        Me.lbOldPcName.TabIndex = 15
        Me.lbOldPcName.Text = "Old PC Name:"
        '
        'lbNewPcName
        '
        Me.lbNewPcName.AutoSize = True
        Me.lbNewPcName.BackColor = System.Drawing.Color.Transparent
        Me.lbNewPcName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbNewPcName.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNewPcName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbNewPcName.Location = New System.Drawing.Point(124, 182)
        Me.lbNewPcName.Name = "lbNewPcName"
        Me.lbNewPcName.Size = New System.Drawing.Size(121, 25)
        Me.lbNewPcName.TabIndex = 14
        Me.lbNewPcName.Text = "New PC Name:"
        '
        'copyUserDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(765, 577)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "copyUserDataForm"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents buEdgBookmarks As Button
    Friend WithEvents buFileExplorerQuickAccess As Button
    Friend WithEvents buChromeBookmarks As Button
    Friend WithEvents buOutlookSignatures As Button
    Friend WithEvents buGetName As Button
    Friend WithEvents buGetOldStatus As Button
    Friend WithEvents buGetNewStatus As Button
    Friend WithEvents stCustomerNTID As TextBox
    Friend WithEvents stOldPcName As TextBox
    Friend WithEvents stNewPcName As TextBox
    Friend WithEvents lbCustomerNTID As Label
    Friend WithEvents lbOldPcName As Label
    Friend WithEvents lbNewPcName As Label
End Class
