Imports System.Net.NetworkInformation
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Xml
Public Class copyUserDataForm
    Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Private Sub buGetNewStatus_Click(sender As Object, e As EventArgs) Handles buGetNewStatus.Click
        Dim strNewPc As String = stNewPcName.Text
        Dim statusResult As pingPc = New pingPc()

        'Ping Pc
        statusResult.pingReply(strNewPc)
        If statusResult.pingResult = "Success" Then
            successPrompt(strNewPc)
        ElseIf statusResult.pingResult = "TimedOut" Then
            timedOutPrompt(strNewPc)
        End If
    End Sub

    Private Sub buGetOldStatus_Click(sender As Object, e As EventArgs) Handles buGetOldStatus.Click
        Dim strOldPc As String = stOldPcName.Text
        Dim statusResult As pingPc = New pingPc()

        'Ping Pc
        statusResult.pingReply(strOldPc)
        If statusResult.pingResult = "Success" Then
            successPrompt(strOldPc)
        ElseIf statusResult.pingResult = "TimedOut" Then
            timedOutPrompt(strOldPc)
        End If
    End Sub

    Private Sub buGetName_Click(sender As Object, e As EventArgs) Handles buGetName.Click
        Dim strUserName As String = stCustomerNTID.Text
        Dim userNameOutput As String = ""

        'Get user's name from AD
        userNameOutput = getUsername(strUserName)
        If userNameOutput = "" Then
            invalidUsernamePrompt(strUserName)
        Else
            validUsernamePrompt(strUserName, userNameOutput)
        End If
    End Sub

    Private Sub buEdgBookmarks_Click(sender As Object, e As EventArgs) Handles buEdgBookmarks.Click
        Dim strNewPc As String = stNewPcName.Text
        Dim strOldPc As String = stOldPcName.Text
        Dim strUserName As String = stCustomerNTID.Text

        'Ping PC
        Dim statusResultNew As pingPc = New pingPc()
        Dim statusResultOld As pingPc = New pingPc()
        statusResultNew.pingReply(strNewPc)
        statusResultOld.pingReply(strOldPc)

        If statusResultNew.pingResult = "TimedOut" Then
            timedOutPrompt(strNewPc)
        End If
        If statusResultOld.pingResult = "TimedOut" Then
            timedOutPrompt(strOldPc)
        End If
        If getUsername(strUserName) = "" Then
            invalidUsernamePrompt(strUserName)
        End If
        If statusResultNew.pingResult = "Success" And statusResultOld.pingResult = "Success" And getUsername(strUserName) <> "" Then
            Dim promptAnswer As Integer = getPrompt(strNewPc, strOldPc, strUserName)
            Dim edgeMessage As String = "Edge Bookmarks"
            If promptAnswer = 6 Then                                                   'User clicked 'Yes' for proceed prompt
                Dim edgeDefault As Integer = 2                                         'Copy 3 items
                Dim strPath(1, edgeDefault) As String
                strPath = edgePath(strOldPc, strNewPc, strUserName, edgeDefault)
                copyItem(strPath, edgeDefault)
                transferSuccessPrompt(edgeMessage)
            Else
                transferCanceledPrompt(edgeMessage)
            End If
        End If
    End Sub

    Private Sub buChromeBookmarks_Click(sender As Object, e As EventArgs) Handles buChromeBookmarks.Click
        Dim strNewPc As String = stNewPcName.Text
        Dim strOldPc As String = stOldPcName.Text
        Dim strUserName As String = stCustomerNTID.Text

        'Ping PC
        Dim statusResultNew As pingPc = New pingPc()
        Dim statusResultOld As pingPc = New pingPc()
        statusResultNew.pingReply(strNewPc)
        statusResultOld.pingReply(strOldPc)

        If statusResultNew.pingResult = "TimedOut" Then
            timedOutPrompt(strNewPc)
        End If
        If statusResultOld.pingResult = "TimedOut" Then
            timedOutPrompt(strOldPc)
        End If
        If getUsername(strUserName) = "" Then
            invalidUsernamePrompt(strUserName)
        End If
        If statusResultNew.pingResult = "Success" And statusResultOld.pingResult = "Success" And getUsername(strUserName) <> "" Then
            Dim promptAnswer As Integer = getPrompt(strNewPc, strOldPc, strUserName)
            Dim chromeMessage As String = "Chrome Bookmarks"
            If promptAnswer = 6 Then                                                   'User clicked 'Yes' for proceed prompt
                Dim chromeDefault As Integer = 1                                       'Copy 2 items
                Dim strPath(1, chromeDefault) As String
                strPath = chromePath(strOldPc, strNewPc, strUserName, chromeDefault)
                copyItem(strPath, chromeDefault)
                transferSuccessPrompt(chromeMessage)
            Else
                transferCanceledPrompt(chromeMessage)
            End If
        End If
    End Sub

    Private Sub buOutlookSignatures_Click(sender As Object, e As EventArgs) Handles buOutlookSignatures.Click
        Dim strNewPc As String = stNewPcName.Text
        Dim strOldPc As String = stOldPcName.Text
        Dim strUserName As String = stCustomerNTID.Text

        'Ping PC
        Dim statusResultNew As pingPc = New pingPc()
        Dim statusResultOld As pingPc = New pingPc()
        statusResultNew.pingReply(strNewPc)
        statusResultOld.pingReply(strOldPc)

        If statusResultNew.pingResult = "TimedOut" Then
            timedOutPrompt(strNewPc)
        End If
        If statusResultOld.pingResult = "TimedOut" Then
            timedOutPrompt(strOldPc)
        End If
        If getUsername(strUserName) = "" Then
            invalidUsernamePrompt(strUserName)
        End If
        If statusResultNew.pingResult = "Success" And statusResultOld.pingResult = "Success" And getUsername(strUserName) <> "" Then
            Dim promptAnswer As Integer = getPrompt(strNewPc, strOldPc, strUserName)
            Dim outlookSignaturesMessage As String = "Outlook Signatures"
            If promptAnswer = 6 Then                                                    'User clicked for proceed prompt 'Yes'
                Dim outlookSigDefault As Integer = 0                                    'Copy 1 item
                Dim strPath(1, outlookSigDefault) As String
                strPath = outlookSigPath(strOldPc, strNewPc, strUserName, outlookSigDefault)
                copyDirectory(strPath, outlookSigDefault)
                transferSuccessPrompt(outlookSignaturesMessage)
            Else
                transferCanceledPrompt(outlookSignaturesMessage)
            End If
        End If
    End Sub

    Private Sub buFileExplorerQuickAccess_Click(sender As Object, e As EventArgs) Handles buFileExplorerQuickAccess.Click
        Dim strNewPc As String = stNewPcName.Text
        Dim strOldPc As String = stOldPcName.Text
        Dim strUserName As String = stCustomerNTID.Text

        'Ping PC
        Dim statusResultNew As pingPc = New pingPc()
        Dim statusResultOld As pingPc = New pingPc()
        statusResultNew.pingReply(strNewPc)
        statusResultOld.pingReply(strOldPc)

        If statusResultNew.pingResult = "TimedOut" Then
            timedOutPrompt(strNewPc)
        End If
        If statusResultOld.pingResult = "TimedOut" Then
            timedOutPrompt(strOldPc)
        End If
        If getUsername(strUserName) = "" Then
            invalidUsernamePrompt(strUserName)
        End If
        If statusResultNew.pingResult = "Success" And statusResultOld.pingResult = "Success" And getUsername(strUserName) <> "" Then
            Dim promptAnswer As Integer = getPrompt(strNewPc, strOldPc, strUserName)
            Dim quickAccessMessage As String = "Outlook Signatures"
            If promptAnswer = 6 Then                                                    'User clicked for proceed prompt 'Yes'
                Dim quickAccessDefault As Integer = 0                                   'Copy 1 item
                Dim strPath(1, quickAccessDefault) As String
                strPath = quickAccessPath(strOldPc, strNewPc, strUserName, quickAccessDefault)
                copyDirectory(strPath, quickAccessDefault)
                transferSuccessPrompt(quickAccessMessage)
            Else
                transferCanceledPrompt(quickAccessMessage)
            End If
        End If
    End Sub
End Class