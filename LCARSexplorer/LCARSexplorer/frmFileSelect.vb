Imports System.IO
Imports LCARS.UI
Imports Microsoft.Win32
Public Class frmFileSelect

    Dim curPath As String = ""
    Dim CurItems As New exCollection
    Dim beeping As Boolean = False
    Dim bpp As Integer 'buttons per page
    Dim pageCount As Integer
    Dim curPage As Integer
    Dim extensions() As String = {}
    Dim myResult As Windows.Forms.DialogResult
    Dim oloc As Point

    Private Sub sbUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbUp.Click

        If curPath <> "" Then
            curPath = curPath.Substring(0, Len(curPath) - 1)
            If InStr(curPath, "\") > 0 Then
                curPath = curPath.Substring(0, InStrRev(curPath, "\") - 1)
                If curPath.Length = 2 Then
                    curPath += "\"
                End If
                loadDir(curPath)
            Else
                sbUp.Lit = False
                curPath = ""
                loadMyComp()
            End If
        End If
    End Sub
    Private Sub loadMyComp()
        Dim myDrives() As DriveInfo = DriveInfo.GetDrives
        gridMyComp.ControlSize = New Size((gridMyComp.Width - 38) \ 2, 30)
        gridMyComp.Clear()


        hpLocation.ButtonText = "MY COMPUTER"
        Me.Text = "MY COMPUTER"

        For Each myDrive As DriveInfo In myDrives
            Dim myButton As New LCARS.LightweightControls.LCComplexButton 'LCARS.Controls.ComplexButton
            myButton.HoldDraw = True

            If myDrive.IsReady Then
                myButton.Color = LCARS.LCARScolorStyles.NavigationFunction
                myButton.Text = myDrive.VolumeLabel & " (" & myDrive.Name & ")"
                myButton.SideText = ToDriveSize(myDrive.TotalSize)
                If My.Settings.ClickMode = "Single" Then
                    AddHandler myButton.Click, AddressOf drive_click
                Else
                    AddHandler myButton.DoubleClick, AddressOf drive_click
                End If
            Else
                myButton.Color = LCARS.LCARScolorStyles.FunctionOffline
                myButton.Text = "DRIVE OFFLINE (" & myDrive.Name & ")"
                myButton.SideText = "--"
                If My.Settings.ClickMode = "Single" Then
                    AddHandler myButton.Click, AddressOf myErrorAlert
                Else
                    AddHandler myButton.DoubleClick, AddressOf myErrorAlert
                End If
            End If

            'AddHandler myButton.MouseDown, AddressOf drive_MouseDown
            'AddHandler myButton.MouseUp, AddressOf drive_MouseUp

            myButton.Data = myDrive.Name
            myButton.Beeping = beeping
            myButton.HoldDraw = False

            gridMyComp.Add(myButton)
        Next

    End Sub
    Private Function ToDriveSize(ByVal bytes As Decimal, Optional ByVal Round As Boolean = False) As String
        Dim mySize As String = ""
        Dim SizeCount As Decimal = bytes
        Dim Remainder As Integer = 0
        Dim SizeType As String = "B"


        If SizeCount > 1024 Then
            SizeType = "KB"
            SizeCount = SizeCount / 1024

            If SizeCount > 1024 Then
                SizeType = "MB"
                SizeCount = SizeCount / 1024

                If SizeCount > 1024 Then
                    SizeType = "GB"
                    SizeCount = SizeCount / 1024

                    If SizeCount > 1024 Then
                        SizeType = "TB"
                        SizeCount = SizeCount / 1024

                        If SizeCount > 1024 Then
                            SizeType = "HB"
                            SizeCount = SizeCount / 1024
                        End If
                    End If
                End If
            End If
        End If

        If Round = True Then
            Return Math.Round(SizeCount) & SizeType
        Else
            Return SizeCount.ToString("N2") & SizeType
        End If
    End Function

    Private Sub drive_click(ByVal sender As Object, ByVal e As EventArgs)
        loadDir(CType(sender, LCARS.LightweightControls.LCComplexButton).Data)
    End Sub

    Public Sub loadDir(ByVal newpath As String)
        If newpath = "" Then
            loadMyComp()
        Else
            sbUp.Lit = True

            Dim myDir As DirectoryInfo = New DirectoryInfo(newpath)

            curPath = newpath
            CurItems.Clear()

            Dim title As String = System.IO.Path.GetFileNameWithoutExtension(curPath)
            If title <> "" Then
                hpLocation.ButtonText = title
                Me.Text = title
            Else
                hpLocation.ButtonText = newpath
                Me.Text = newpath
            End If


            'get directories and add them to the list
            For Each curDir As DirectoryInfo In myDir.GetDirectories
                Try
                    If (My.Settings.check = True) Then
                        curDir.GetDirectories()
                    End If
                    Dim dirAttr As FileAttributes = curDir.Attributes
                    If (dirAttr <> FileAttributes.Hidden Or My.Settings.showHidden = True) Then
                        CurItems.Add(curDir, "dir")
                    End If
                Catch ex As Exception

                End Try
            Next
            'get files and add them to the list
            For Each curFile As FileInfo In myDir.GetFiles
                Try
                    If (My.Settings.check = True) Then
                        Dim blank As String = curFile.Extension
                    End If
                    Dim fileAttr As FileAttributes = curFile.Attributes
                    If (fileAttr <> FileAttributes.Hidden Or My.Settings.showHidden = True) Then
                        Dim i As Integer = 1
                        While (i < extensions.Length)
                            If (curFile.Extension = extensions(i) And curFile.Extension <> "") Then
                                CurItems.Add(curFile, "file")
                            End If
                            i += 1
                        End While
                    End If
                Catch ex As Exception
                End Try
            Next

            gridMyComp.Clear()
            gridMyComp.ControlSize = New Size(300, 30)
            For intloop As Integer = 0 To CurItems.Count - 1

                Dim curItem As exCollectionItem = CurItems.Item(intloop)
                Dim myButton As New LCARS.LightweightControls.LCComplexButton()

                myButton.HoldDraw = True

                If curItem.Key = "dir" Then
                    Try
                        myButton.Color = LCARS.LCARScolorStyles.NavigationFunction
                        myButton.SideText = curItem.Value.GetDirectories.GetUpperBound(0) + 1 & "." & curItem.Value.GetFiles.GetUpperBound(0) + 1
                        If My.Settings.ClickMode = "Single" Then
                            AddHandler myButton.Click, AddressOf drive_click
                        Else
                            AddHandler myButton.DoubleClick, AddressOf drive_click
                        End If
                    Catch ex As Exception
                        myButton.SideText = "--"
                        myButton.Color = LCARS.LCARScolorStyles.FunctionOffline
                        If My.Settings.ClickMode = "Single" Then
                            AddHandler myButton.Click, AddressOf myErrorAlert
                        Else
                            AddHandler myButton.DoubleClick, AddressOf myErrorAlert
                        End If
                    End Try

                Else
                    Try
                        If My.Settings.ColorFiles Then
                            Dim mycolors() As String = myButton.ColorsAvailable.getColors
                            mycolors(2) = frmMyComp.getExtColor(System.IO.Path.GetExtension(curItem.Value.name))
                            myButton.ColorsAvailable.setColors(mycolors)
                        End If

                        myButton.Color = LCARS.LCARScolorStyles.MiscFunction
                        Dim ext As String = System.IO.Path.GetExtension(curItem.Value.FullName).Replace(".", "")
                        If ext <> "" Then
                            If ext.Length > 6 Then
                                ext = ext.Substring(1, 6) & "."
                            End If
                            myButton.SideText = ext.ToUpper  'ToDriveSize(curItem.Value.Length, True)
                        Else
                            myButton.SideText = "---"
                        End If
                        If My.Settings.ClickMode = "Single" Then
                            AddHandler myButton.Click, AddressOf myFile_Click
                        Else
                            AddHandler myButton.DoubleClick, AddressOf myFile_Click
                        End If

                    Catch ex As Exception
                        myButton.SideText = "--"
                        myButton.Color = LCARS.LCARScolorStyles.FunctionOffline
                        If My.Settings.ClickMode = "Single" Then
                            AddHandler myButton.Click, AddressOf myErrorAlert
                        Else
                            AddHandler myButton.DoubleClick, AddressOf myErrorAlert
                        End If
                    End Try

                End If

                myButton.Text = curItem.Value.name
                myButton.Data = curItem.Value.FullName
                myButton.Beeping = beeping
                myButton.HoldDraw = False

                gridMyComp.Add(myButton)

            Next

        End If

    End Sub


    Private Sub myFile_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        lblCurrentSelected.Text = sender.data
    End Sub
    Private Sub frmFileSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCurrentSelected.Text = ""
        loadDir(curPath)
    End Sub

    Private Sub sbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbCancel.Click
        Result = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub sbOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbOK.Click
        If (lblCurrentSelected.Text <> "") Then
            result = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
    Public Sub New(Optional ByVal startDir As String = "", Optional ByVal filters As String = "", Optional ByVal title As String = "")
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        curPath = startDir
        While (filters.Length > 0)
            Dim index As Integer = filters.IndexOf(",")
            If (index <> 0) Then
                extensions = extend(extensions, filters.Substring(0, index))
                fbExt.Text += filters.Substring(0, index) & vbNewLine
                filters = filters.Remove(0, index + 1)
            End If
        End While
        hpPrompt.Text = title
    End Sub
    Public Property Result() As Windows.Forms.DialogResult
        Get
            Return myResult
        End Get
        Set(ByVal value as Windows.Forms.DialogResult)
            myResult = value
        End Set
    End Property
    Public ReadOnly Property ReturnPath() As String
        Get
            Return lblCurrentSelected.Text
        End Get
    End Property
    Private Function extend(ByVal array() As String, ByVal item As String) As String()
        ReDim Preserve array(array.Length + 1)
        array(array.Length - 1) = item
        Return array
    End Function
    'moving dialog box

    Private Sub elbTop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles elbTop.MouseDown
        oloc = New Point(MousePosition.X, MousePosition.Y)
    End Sub

    Private Sub elbTop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles elbTop.MouseMove
        If MouseButtons = Windows.Forms.MouseButtons.Left Then
            Me.Left += MousePosition.X - oloc.X
            Me.Top += MousePosition.Y - oloc.Y
            oloc = New Point(MousePosition.X, MousePosition.Y)
            Application.DoEvents()
        End If
    End Sub
    Private Sub myErrorAlert(ByVal sender As Object, ByVal e As System.EventArgs)
        LCARS.Alerts.ActivateAlert("Red", Me.Handle)
        MsgBox("Error: Access Denied", MsgBoxStyle.Critical, "Access Denied")
        LCARS.Alerts.DeactivateAlert(Me.Handle)
    End Sub
    'Changes page on mouse scroll
    Private Sub Me_MouseScroll(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If gridMyComp.CurrentPage > 0 Then
                gridMyComp.CurrentPage -= 1
            End If
        Else
            If gridMyComp.CurrentPage - 1 < gridMyComp.PageCount Then
                gridMyComp.CurrentPage += 1
            End If
        End If
    End Sub

End Class
