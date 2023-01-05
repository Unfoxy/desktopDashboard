Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar


Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Drop Panel Height
    Dim drPn1Size As Integer = 42
    Dim drPn2Size As Integer = 42
    Dim drPn3Size As Integer = 42
    '-------------------------------------------------------------------------------------Utility Tools Drop Down
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If drPn1Size > 84 Then
            Timer1.Stop()
        Else
            Me.drPn1.Size = New Size(Me.drPn1.Size.Width, drPn1Size)
            drPn1Size += 10
        End If
    End Sub
    'Private Sub drbtnUtilityTools_MouseHover(sender As Object, e As EventArgs) Handles drbtnUtilityTools.MouseHover
    '    Me.drPn2.Size = New Size(Me.drPn2.Size.Width, drPn2Size)
    '    Me.drPn3.Size = New Size(Me.drPn3.Size.Width, drPn3Size)
    '    Timer1.Start()
    'End Sub
    Private Sub drbtnUtilityTools_Click(sender As Object, e As EventArgs) Handles drbtnUtilityTools.Click
        Me.drPn2.Size = New Size(Me.drPn2.Size.Width, drPn2Size)
        Me.drPn3.Size = New Size(Me.drPn3.Size.Width, drPn3Size)
        Timer1.Start()
    End Sub
    'Private Sub drbtnUtilityTools_MouseLeave(sender As Object, e As EventArgs) Handles drbtnUtilityTools.MouseLeave
    '    Timer1.Stop()
    '    drPn1Size = 42
    'End Sub
    'Private Sub drbtnUtilityTools_MouseClick(sender As Object, e As MouseEventArgs) Handles drbtnUtilityTools.MouseClick
    '    Timer1.Stop()
    '    drPn1Size = 42
    'End Sub
    'Private Sub drbtnUtilityTools_MouseCaptureChanged(sender As Object, e As EventArgs) Handles drbtnUtilityTools.MouseCaptureChanged
    '    Timer1.Stop()
    '    drPn1Size = 42
    'End Sub
    Private Sub btnPcSetUp_Click(sender As Object, e As EventArgs) Handles btnUserDataMigration.Click

        With copyUserDataForm
            .TopLevel = False
            pnMain.Controls.Add(copyUserDataForm)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnRemoteRegistryEdit_Click(sender As Object, e As EventArgs) Handles btnRemoteRegistryEdit.Click

        With Form1
            .TopLevel = False
            pnMain.Controls.Add(Form1)
            .BringToFront()
            .Show()
        End With
    End Sub
    '-------------------------------------------------------------------------------------Troubleshooting Tools Drop Down
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If drPn2Size > 84 Then
            Timer2.Stop()
        Else
            Me.drPn2.Size = New Size(Me.drPn2.Size.Width, drPn2Size)
            drPn2Size += 10

        End If
    End Sub
    'Private Sub drbtnTroubleshootingTools_MouseHover(sender As Object, e As EventArgs) Handles drbtnTroubleshootingTools.MouseHover
    '    Me.drPn1.Size = New Size(Me.drPn1.Size.Width, drPn1Size)
    '    Me.drPn3.Size = New Size(Me.drPn3.Size.Width, drPn3Size)
    '    Timer2.Start()
    'End Sub
    Private Sub drbtnTroubleshootingTools_Click(sender As Object, e As EventArgs) Handles drbtnTroubleshootingTools.Click
        Me.drPn1.Size = New Size(Me.drPn1.Size.Width, drPn1Size)
        Me.drPn3.Size = New Size(Me.drPn3.Size.Width, drPn3Size)
        Timer2.Start()
    End Sub

    Private Sub drbtnTroubleshootingTools_MouseLeave(sender As Object, e As EventArgs) Handles drbtnTroubleshootingTools.MouseLeave
        Timer2.Stop()
        drPn2Size = 42
    End Sub
    '-------------------------------------------------------------------------------------Active Directory Drop Down
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If drPn3Size > 84 Then
            Timer3.Stop()
        Else
            Me.drPn3.Size = New Size(Me.drPn3.Size.Width, drPn3Size)
            drPn3Size += 10
        End If
    End Sub
    'Private Sub drbtnActiveDirectory_MouseHover(sender As Object, e As EventArgs) Handles drbtnActiveDirectory.MouseHover
    '    Me.drPn1.Size = New Size(Me.drPn1.Size.Width, drPn1Size)
    '    Me.drPn2.Size = New Size(Me.drPn2.Size.Width, drPn2Size)
    '    Timer3.Start()
    'End Sub
    Private Sub drbtnActiveDirectory_Click(sender As Object, e As EventArgs) Handles drbtnActiveDirectory.Click
        Me.drPn1.Size = New Size(Me.drPn1.Size.Width, drPn1Size)
        Me.drPn2.Size = New Size(Me.drPn2.Size.Width, drPn2Size)
        Timer3.Start()
    End Sub
    Private Sub drbtnActiveDirectory_MouseLeave(sender As Object, e As EventArgs) Handles drbtnActiveDirectory.MouseLeave
        Timer3.Stop()
        drPn3Size = 42
    End Sub
End Class
