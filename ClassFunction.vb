Imports System.Net.NetworkInformation
Imports System.DirectoryServices
Imports System.DirectoryServices.ActiveDirectory

Module Module1
    Public Class pingPc
        Public ping As New Ping
        Public pingResult As String
        Public Sub pingReply(ByVal pingPc As String)
            Try
                Dim reply As PingReply = ping.Send(pingPc, 1000)
                pingResult = reply.Status.ToString
            Catch ex As Exception
                MessageBox.Show("Invalid PC Name Entry" & vbCrLf & "'" & pingPc & "'" & " is Invalid PC Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class

    Public Function successPrompt(ByVal successPc As String)
        MessageBox.Show(successPc.ToUpper & " is Online", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return Nothing
    End Function

    Public Function timedOutPrompt(ByVal timedOutPc As String)
        MessageBox.Show(timedOutPc.ToUpper & " is Offline" & vbCrLf & "Please Verify Connectivity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return Nothing
    End Function

    Public Function getPrompt(ByVal newPc As String, ByVal oldPc As String, ByVal userId As String) As Integer
        Dim promptAnswer As String = MsgBox("Please Confirm Below Again" & vbCrLf & "New PC: " & newPc.ToUpper & vbCrLf & "Old PC : " & oldPc.ToUpper & vbCrLf _
                              & "User     : " & getUsername(userId), vbQuestion + vbYesNo + vbDefaultButton2, "Please Confrim")
        Return promptAnswer 'promptAnswer will return value as Integer yes/no to be used for if statement
    End Function

    Public Function validUsernamePrompt(ByVal inputUsername As String, ByVal nameOutput As String)
        MessageBox.Show(inputUsername.ToUpper & "'s Name is: " & nameOutput, "Username", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return Nothing
    End Function

    Public Function invalidUsernamePrompt(ByVal invalidUsername As String)
        MessageBox.Show("Invalid User Name entry" & vbCrLf & "'" & invalidUsername.ToUpper & "'" & " is Invalid Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return Nothing
    End Function

    Public Function getUsername(ByVal inputUsername As String) As String
        Dim returnValue As String = ""
        Try
            'Query active directory from Sysmte.DirectoryServices class
            Dim userName As String = inputUsername
            Dim strPath As New System.DirectoryServices.DirectoryEntry
            Dim objDirSearcher As New System.DirectoryServices.DirectorySearcher(strPath)
            Dim objCollSearchResult As System.DirectoryServices.SearchResultCollection
            Dim objSearchResult As System.DirectoryServices.SearchResult
            Dim objCollResultProperty As System.DirectoryServices.ResultPropertyCollection
            Dim objCollResultPropertyValue As System.DirectoryServices.ResultPropertyValueCollection

            objDirSearcher.Filter = ("(&(objectclass=user)(samaccountname=" & userName & "))")
            objCollSearchResult = objDirSearcher.FindAll()

            Select Case (objCollSearchResult.Count)
                Case 0
                    'exit function
                Case Is > 1
                    'exit function
                Case Is = 1
                    objSearchResult = objCollSearchResult.Item(0)
                    objCollResultProperty = objSearchResult.Properties
                    objCollResultPropertyValue = objCollResultProperty.Item("name")  'find name property from ActiveDirectory
                    returnValue = objCollResultPropertyValue.Item(0)
            End Select

            objDirSearcher.Dispose()
            objCollSearchResult.Dispose()
            objSearchResult = Nothing
            objCollResultProperty = Nothing
            objCollResultPropertyValue = Nothing
        Catch ex As System.Exception
            Dim strMess As String
            strMess = ex.Message
        End Try
        Return returnValue
    End Function

    Public Function copyItem(ByVal sourcePath(,) As String, ByVal maxCount As Integer)
        For y = 0 To maxCount
            My.Computer.FileSystem.CopyFile(sourcePath(0, y), sourcePath(1, y), Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        Next
        Return Nothing
    End Function

    Public Function copyDirectory(ByVal sourcePath(,) As String, ByVal maxCount As Integer)
        For y = 0 To maxCount
            My.Computer.FileSystem.CopyDirectory(sourcePath(0, y), sourcePath(1, y), Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        Next
        Return Nothing
    End Function

    Public Function transferSuccessPrompt(ByVal inputApp As String)
        MessageBox.Show(inputApp & " Transfer Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return Nothing
    End Function

    Public Function transferCanceledPrompt(ByVal inputApp As String)
        MessageBox.Show(inputApp & " Transfer Canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Return Nothing
    End Function

    'Files Path
    '------------------------------------------------------------------------------------------------------------------------------------------------
    Public Function edgePath(ByVal oldPc As String, ByVal newPc As String, ByVal inputUserName As String, ByVal edgeMax As Integer) As Array
        Dim path(1, edgeMax) As String
        path(0, 0) = "\\" & oldPc & "\c$\users\" & inputUserName & "\appdata\local\microsoft\edge\user data\default\bookmarks"
        path(0, 1) = "\\" & oldPc & "\c$\users\" & inputUserName & "\appdata\local\microsoft\edge\user data\default\bookmarks.bak"
        path(0, 2) = "\\" & oldPc & "\c$\users\" & inputUserName & "\appdata\local\microsoft\edge\user data\default\bookmarks.msbak"
        path(1, 0) = "\\" & newPc & "\c$\users\" & inputUserName & "\appdata\local\microsoft\edge\user data\default\bookmarks"
        path(1, 1) = "\\" & newPc & "\c$\users\" & inputUserName & "\appdata\local\microsoft\edge\user data\default\bookmarks.bak"
        path(1, 2) = "\\" & newPc & "\c$\users\" & inputUserName & "\appdata\local\microsoft\edge\user data\default\bookmarks.msbak"

        Dim returnSourcePath(1, edgeMax) As String
        For x = 0 To 1
            For y = 0 To edgeMax
                returnSourcePath(x, y) = path(x, y)
            Next
        Next

        Return returnSourcePath
    End Function

    Public Function chromePath(ByVal oldPc As String, ByVal newPc As String, ByVal inputUserName As String, ByVal chromeMax As Integer) As Array
        Dim path(1, chromeMax) As String
        path(0, 0) = "\\" & oldPc & "\c$\users\" & inputUserName & "\appdata\local\google\chrome\user data\default\bookmarks"
        path(0, 1) = "\\" & oldPc & "\c$\users\" & inputUserName & "\appdata\local\google\chrome\user data\default\bookmarks.bak"
        path(1, 0) = "\\" & newPc & "\c$\users\" & inputUserName & "\appdata\local\google\chrome\user data\default\bookmarks"
        path(1, 1) = "\\" & newPc & "\c$\users\" & inputUserName & "\appdata\local\google\chrome\user data\default\bookmarks.bak"

        Dim returnSourcePath(1, chromeMax) As String
        For x = 0 To 1
            For y = 0 To chromeMax
                returnSourcePath(x, y) = path(x, y)
            Next
        Next

        Return returnSourcePath
    End Function

    Public Function outlookSigPath(ByVal oldPc As String, ByVal newPc As String, ByVal inputUserName As String, ByVal outlookSigMax As Double) As Array
        Dim strPath(1, outlookSigMax) As String
        strPath(0, 0) = "\\" & oldPc & "\c$\users\" & inputUserName & "\appdata\roaming\microsoft\Signatures"
        strPath(1, 0) = "\\" & newPc & "\c$\users\" & inputUserName & "\appdata\roaming\microsoft\Signatures"

        Dim returnSourcePath(1, outlookSigMax) As String
        For x = 0 To 1
            For y = 0 To outlookSigMax
                returnSourcePath(x, y) = strPath(x, y)
            Next
        Next

        Return returnSourcePath
    End Function

    Public Function quickAccessPath(ByVal oldPc As String, ByVal newPc As String, ByVal inputUserName As String, ByVal quickAccessMax As Double) As Array
        Dim strPath(1, quickAccessMax) As String
        strPath(0, 0) = "\\" & oldPc & "\c$\users\" & inputUserName & "\appdata\roaming\microsoft\Windows\Recent\automaticDestinations"
        strPath(1, 0) = "\\" & newPc & "\c$\users\" & inputUserName & "\appdata\roaming\microsoft\Windows\Recent\automaticDestinations"

        Dim returnSourcePath(1, quickAccessMax) As String
        For x = 0 To 1
            For y = 0 To quickAccessMax
                returnSourcePath(x, y) = strPath(x, y)
            Next
        Next

        Return returnSourcePath
    End Function
End Module