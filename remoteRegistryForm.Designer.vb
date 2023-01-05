<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tbPcName = New System.Windows.Forms.TextBox()
        Me.lbPcName = New System.Windows.Forms.Label()
        Me.buChangeRegistry = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbPcName
        '
        Me.tbPcName.Location = New System.Drawing.Point(103, 24)
        Me.tbPcName.Name = "tbPcName"
        Me.tbPcName.Size = New System.Drawing.Size(119, 20)
        Me.tbPcName.TabIndex = 0
        '
        'lbPcName
        '
        Me.lbPcName.AutoSize = True
        Me.lbPcName.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbPcName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbPcName.Location = New System.Drawing.Point(11, 24)
        Me.lbPcName.Name = "lbPcName"
        Me.lbPcName.Size = New System.Drawing.Size(83, 23)
        Me.lbPcName.TabIndex = 1
        Me.lbPcName.Text = "PC Name:"
        '
        'buChangeRegistry
        '
        Me.buChangeRegistry.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.buChangeRegistry.Location = New System.Drawing.Point(235, 24)
        Me.buChangeRegistry.Name = "buChangeRegistry"
        Me.buChangeRegistry.Size = New System.Drawing.Size(130, 31)
        Me.buChangeRegistry.TabIndex = 2
        Me.buChangeRegistry.Text = "Change Registry"
        Me.buChangeRegistry.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.buChangeRegistry)
        Me.Panel1.Controls.Add(Me.lbPcName)
        Me.Panel1.Controls.Add(Me.tbPcName)
        Me.Panel1.Location = New System.Drawing.Point(231, 225)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 110)
        Me.Panel1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(891, 578)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbPcName As TextBox
    Friend WithEvents lbPcName As Label
    Friend WithEvents buChangeRegistry As Button
    Friend WithEvents Panel1 As Panel
End Class
