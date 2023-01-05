<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Me.pnMenu = New System.Windows.Forms.Panel()
        Me.drPn3 = New System.Windows.Forms.Panel()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.drbtnActiveDirectory = New System.Windows.Forms.Button()
        Me.drPn2 = New System.Windows.Forms.Panel()
        Me.btnRemoteRegistryEdit = New System.Windows.Forms.Button()
        Me.drbtnTroubleshootingTools = New System.Windows.Forms.Button()
        Me.drPn1 = New System.Windows.Forms.Panel()
        Me.btnUserDataMigration = New System.Windows.Forms.Button()
        Me.drbtnUtilityTools = New System.Windows.Forms.Button()
        Me.pnIcon = New System.Windows.Forms.Panel()
        Me.lbAppVersion = New System.Windows.Forms.Label()
        Me.lbAppName = New System.Windows.Forms.Label()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.pnHeader = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.pbAppIcon = New System.Windows.Forms.PictureBox()
        Me.pnMenu.SuspendLayout()
        Me.drPn3.SuspendLayout()
        Me.drPn2.SuspendLayout()
        Me.drPn1.SuspendLayout()
        Me.pnIcon.SuspendLayout()
        CType(Me.pbAppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnMenu
        '
        Me.pnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pnMenu.Controls.Add(Me.drPn3)
        Me.pnMenu.Controls.Add(Me.drPn2)
        Me.pnMenu.Controls.Add(Me.drPn1)
        Me.pnMenu.Controls.Add(Me.pnIcon)
        Me.pnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnMenu.Name = "pnMenu"
        Me.pnMenu.Size = New System.Drawing.Size(186, 577)
        Me.pnMenu.TabIndex = 0
        '
        'drPn3
        '
        Me.drPn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.drPn3.Controls.Add(Me.btnCreateUser)
        Me.drPn3.Controls.Add(Me.drbtnActiveDirectory)
        Me.drPn3.Dock = System.Windows.Forms.DockStyle.Top
        Me.drPn3.Location = New System.Drawing.Point(0, 228)
        Me.drPn3.MaximumSize = New System.Drawing.Size(186, 84)
        Me.drPn3.MinimumSize = New System.Drawing.Size(186, 42)
        Me.drPn3.Name = "drPn3"
        Me.drPn3.Size = New System.Drawing.Size(186, 42)
        Me.drPn3.TabIndex = 5
        '
        'btnCreateUser
        '
        Me.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnCreateUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCreateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateUser.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUser.ForeColor = System.Drawing.Color.White
        Me.btnCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateUser.Location = New System.Drawing.Point(0, 42)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(186, 42)
        Me.btnCreateUser.TabIndex = 2
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCreateUser.UseVisualStyleBackColor = False
        '
        'drbtnActiveDirectory
        '
        Me.drbtnActiveDirectory.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.drbtnActiveDirectory.Dock = System.Windows.Forms.DockStyle.Top
        Me.drbtnActiveDirectory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.drbtnActiveDirectory.FlatAppearance.BorderSize = 2
        Me.drbtnActiveDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drbtnActiveDirectory.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drbtnActiveDirectory.ForeColor = System.Drawing.Color.White
        Me.drbtnActiveDirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.drbtnActiveDirectory.Location = New System.Drawing.Point(0, 0)
        Me.drbtnActiveDirectory.MaximumSize = New System.Drawing.Size(186, 84)
        Me.drbtnActiveDirectory.MinimumSize = New System.Drawing.Size(186, 42)
        Me.drbtnActiveDirectory.Name = "drbtnActiveDirectory"
        Me.drbtnActiveDirectory.Size = New System.Drawing.Size(186, 42)
        Me.drbtnActiveDirectory.TabIndex = 4
        Me.drbtnActiveDirectory.Text = "Active Directory"
        Me.drbtnActiveDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.drbtnActiveDirectory.UseVisualStyleBackColor = False
        '
        'drPn2
        '
        Me.drPn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.drPn2.Controls.Add(Me.btnRemoteRegistryEdit)
        Me.drPn2.Controls.Add(Me.drbtnTroubleshootingTools)
        Me.drPn2.Dock = System.Windows.Forms.DockStyle.Top
        Me.drPn2.Location = New System.Drawing.Point(0, 186)
        Me.drPn2.MaximumSize = New System.Drawing.Size(186, 84)
        Me.drPn2.MinimumSize = New System.Drawing.Size(186, 42)
        Me.drPn2.Name = "drPn2"
        Me.drPn2.Size = New System.Drawing.Size(186, 42)
        Me.drPn2.TabIndex = 4
        '
        'btnRemoteRegistryEdit
        '
        Me.btnRemoteRegistryEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnRemoteRegistryEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRemoteRegistryEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnRemoteRegistryEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoteRegistryEdit.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoteRegistryEdit.ForeColor = System.Drawing.Color.White
        Me.btnRemoteRegistryEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemoteRegistryEdit.Location = New System.Drawing.Point(0, 42)
        Me.btnRemoteRegistryEdit.Name = "btnRemoteRegistryEdit"
        Me.btnRemoteRegistryEdit.Size = New System.Drawing.Size(186, 42)
        Me.btnRemoteRegistryEdit.TabIndex = 2
        Me.btnRemoteRegistryEdit.Text = "Remote registry edit"
        Me.btnRemoteRegistryEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRemoteRegistryEdit.UseVisualStyleBackColor = False
        '
        'drbtnTroubleshootingTools
        '
        Me.drbtnTroubleshootingTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.drbtnTroubleshootingTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.drbtnTroubleshootingTools.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.drbtnTroubleshootingTools.FlatAppearance.BorderSize = 2
        Me.drbtnTroubleshootingTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drbtnTroubleshootingTools.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drbtnTroubleshootingTools.ForeColor = System.Drawing.Color.White
        Me.drbtnTroubleshootingTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.drbtnTroubleshootingTools.Location = New System.Drawing.Point(0, 0)
        Me.drbtnTroubleshootingTools.MaximumSize = New System.Drawing.Size(186, 84)
        Me.drbtnTroubleshootingTools.MinimumSize = New System.Drawing.Size(186, 42)
        Me.drbtnTroubleshootingTools.Name = "drbtnTroubleshootingTools"
        Me.drbtnTroubleshootingTools.Size = New System.Drawing.Size(186, 42)
        Me.drbtnTroubleshootingTools.TabIndex = 4
        Me.drbtnTroubleshootingTools.Text = "Troubleshooting Tools"
        Me.drbtnTroubleshootingTools.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.drbtnTroubleshootingTools.UseVisualStyleBackColor = False
        '
        'drPn1
        '
        Me.drPn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.drPn1.Controls.Add(Me.btnUserDataMigration)
        Me.drPn1.Controls.Add(Me.drbtnUtilityTools)
        Me.drPn1.Dock = System.Windows.Forms.DockStyle.Top
        Me.drPn1.Location = New System.Drawing.Point(0, 144)
        Me.drPn1.MaximumSize = New System.Drawing.Size(186, 84)
        Me.drPn1.MinimumSize = New System.Drawing.Size(186, 42)
        Me.drPn1.Name = "drPn1"
        Me.drPn1.Size = New System.Drawing.Size(186, 42)
        Me.drPn1.TabIndex = 0
        '
        'btnUserDataMigration
        '
        Me.btnUserDataMigration.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnUserDataMigration.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserDataMigration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnUserDataMigration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserDataMigration.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserDataMigration.ForeColor = System.Drawing.Color.White
        Me.btnUserDataMigration.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUserDataMigration.Location = New System.Drawing.Point(0, 42)
        Me.btnUserDataMigration.Name = "btnUserDataMigration"
        Me.btnUserDataMigration.Size = New System.Drawing.Size(186, 42)
        Me.btnUserDataMigration.TabIndex = 2
        Me.btnUserDataMigration.Text = "User data migration"
        Me.btnUserDataMigration.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnUserDataMigration.UseVisualStyleBackColor = False
        '
        'drbtnUtilityTools
        '
        Me.drbtnUtilityTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.drbtnUtilityTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.drbtnUtilityTools.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.drbtnUtilityTools.FlatAppearance.BorderSize = 2
        Me.drbtnUtilityTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drbtnUtilityTools.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drbtnUtilityTools.ForeColor = System.Drawing.Color.White
        Me.drbtnUtilityTools.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.drbtnUtilityTools.Location = New System.Drawing.Point(0, 0)
        Me.drbtnUtilityTools.MaximumSize = New System.Drawing.Size(186, 84)
        Me.drbtnUtilityTools.MinimumSize = New System.Drawing.Size(186, 42)
        Me.drbtnUtilityTools.Name = "drbtnUtilityTools"
        Me.drbtnUtilityTools.Size = New System.Drawing.Size(186, 42)
        Me.drbtnUtilityTools.TabIndex = 4
        Me.drbtnUtilityTools.Text = "Utility Tools"
        Me.drbtnUtilityTools.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.drbtnUtilityTools.UseVisualStyleBackColor = False
        '
        'pnIcon
        '
        Me.pnIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnIcon.Controls.Add(Me.lbAppVersion)
        Me.pnIcon.Controls.Add(Me.lbAppName)
        Me.pnIcon.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnIcon.Location = New System.Drawing.Point(0, 0)
        Me.pnIcon.Name = "pnIcon"
        Me.pnIcon.Size = New System.Drawing.Size(186, 144)
        Me.pnIcon.TabIndex = 0
        '
        'lbAppVersion
        '
        Me.lbAppVersion.AutoSize = True
        Me.lbAppVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAppVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lbAppVersion.Location = New System.Drawing.Point(70, 116)
        Me.lbAppVersion.Name = "lbAppVersion"
        Me.lbAppVersion.Size = New System.Drawing.Size(38, 12)
        Me.lbAppVersion.TabIndex = 2
        Me.lbAppVersion.Text = "v1.0.0"
        '
        'lbAppName
        '
        Me.lbAppName.AutoSize = True
        Me.lbAppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAppName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lbAppName.Location = New System.Drawing.Point(22, 100)
        Me.lbAppName.Name = "lbAppName"
        Me.lbAppName.Size = New System.Drawing.Size(146, 16)
        Me.lbAppName.TabIndex = 1
        Me.lbAppName.Text = "Desktop Dashboard"
        '
        'pnMain
        '
        Me.pnMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(186, 0)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(765, 577)
        Me.pnMain.TabIndex = 3
        '
        'pnHeader
        '
        Me.pnHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pnHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHeader.Location = New System.Drawing.Point(186, 0)
        Me.pnHeader.Name = "pnHeader"
        Me.pnHeader.Size = New System.Drawing.Size(765, 30)
        Me.pnHeader.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Timer2
        '
        Me.Timer2.Interval = 15
        '
        'Timer3
        '
        Me.Timer3.Interval = 15
        '
        'pbAppIcon
        '
        Me.pbAppIcon.Image = Global.DesktopDashBoard.My.Resources.Resources.user
        Me.pbAppIcon.Location = New System.Drawing.Point(60, 22)
        Me.pbAppIcon.Name = "pbAppIcon"
        Me.pbAppIcon.Size = New System.Drawing.Size(63, 63)
        Me.pbAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAppIcon.TabIndex = 2
        Me.pbAppIcon.TabStop = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 577)
        Me.Controls.Add(Me.pnHeader)
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.pbAppIcon)
        Me.Controls.Add(Me.pnMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnMenu.ResumeLayout(False)
        Me.drPn3.ResumeLayout(False)
        Me.drPn2.ResumeLayout(False)
        Me.drPn1.ResumeLayout(False)
        Me.pnIcon.ResumeLayout(False)
        Me.pnIcon.PerformLayout()
        CType(Me.pbAppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnMenu As Panel
    Friend WithEvents pnIcon As Panel
    Friend WithEvents lbAppVersion As Label
    Friend WithEvents lbAppName As Label
    Friend WithEvents btnUserDataMigration As Button
    Friend WithEvents pbAppIcon As PictureBox
    Friend WithEvents pnMain As Panel
    Friend WithEvents drPn1 As Panel
    Friend WithEvents pnHeader As Panel
    Friend WithEvents drbtnUtilityTools As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents drPn3 As Panel
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents drbtnActiveDirectory As Button
    Friend WithEvents drPn2 As Panel
    Friend WithEvents btnRemoteRegistryEdit As Button
    Friend WithEvents drbtnTroubleshootingTools As Button
    Friend WithEvents Timer3 As Timer
End Class
