Imports System.Runtime.InteropServices


Module modCommon

    Public LinkedWindows As New List(Of IntPtr)
    Public StartingWorkingArea As Rectangle
    Public TaskBarState As Integer
    Public cancelAlert As Boolean = True
    Public shutDownOptions As New cWrapExitWindows
    Public myDesktop As frmStartup
    Public curBusiness As modBusiness
    Public SysListView As IntPtr
    Public hTrayIcons As IntPtr
    Public hTrayParent As IntPtr
    Public myIconSaver As New frmIconSaver
    Public muteAlert As Boolean = False
    Public alertType As Integer
    Public alertColor As Color
    Public alertSound As String
    Dim inAlert As Boolean = False
    Dim CurTopWindow As Integer
    Dim alertThread As Threading.Thread
    Public closing As Boolean = False
    Public myAlertForm As New frmAlerts()
    Public shellMode As Boolean = False
    Public alertSoundMode As Microsoft.VisualBasic.AudioPlayMode = AudioPlayMode.WaitToComplete

#Region " API Calls "

#Region " External Application Window Handling "

    'Bring a window to the front
    <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="SetForegroundWindow")> _
   Public Function SetForegroundWindow(ByVal hWnd As IntPtr) As Integer
    End Function
    <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="GetForegroundWindow")> _
       Public Function GetForegroundWindow() As Integer
    End Function 'Import for "End Program" function

    Public Structure POINTAPI
        Dim X As Integer
        Dim Y As Integer
    End Structure

    Public Structure RECT
        Dim Left_Renamed As Integer
        Dim Top_Renamed As Integer
        Dim Right_Renamed As Integer
        Dim Bottom_Renamed As Integer
    End Structure

    Public Structure WINDOWPLACEMENT
        Dim Length As Integer
        Dim flags As Integer
        Dim ShowCmd As Integer
        Dim ptMinPosition As POINTAPI
        Dim ptMaxPosition As POINTAPI
        Dim rcNormalPosition As RECT
    End Structure

    Public Enum WindowStates
        NORMAL = 1
        MINIMIZED = 2
        MAXIMIZED = 3
        NOACTIVATE = 4
    End Enum


    Public Declare Function SetWindowPlacement Lib "user32" (ByVal hwnd As Integer, ByRef lpwndpl As WINDOWPLACEMENT) As Integer

    Public Declare Function GetWindowPlacement Lib "user32" (ByVal hwnd As Integer, ByRef lpwndpl As WINDOWPLACEMENT) As Integer



#End Region

#Region " Working Area "
    'Constants for setting the "working area" (the area programs load)
    Public Const SPI_SETWORKAREA = 47
    Public Const SPIF_SENDWININICHANGE = &H2
    Public Const SPIF_UPDATEINIFILE = &H1
    Public Const SPIF_change = SPIF_UPDATEINIFILE Or SPIF_SENDWININICHANGE
    'Constants for hiding minimized windows in shell mode
    Public Const SPI_GETMINIMIZEDMETRICS = &H2B
    Public Const SPI_SETMINIMIZEDMETRICS = &H2C

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MinimizedMetrics
        Public cbSize As UInteger
        Public iWidth As Integer
        Public iHorzGap As Integer
        Public iVertGap As Integer
        Public iArrange As MinimizedMetricsArrangement
    End Structure

    <Flags()> _
    Public Enum MinimizedMetricsArrangement
        BottomLeft = 0
        BottomRight = 1
        TopLeft = 2
        TopRight = 3
        Left = 0
        Right = 0
        Up = 4
        Down = 4
        Hide = 8
    End Enum

    'used to set the working area
    <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="SystemParametersInfoA")> _
    Public Function SystemParametersInfo(ByVal uAction As UInteger, ByVal uParam As UInteger, ByVal lpvParam As IntPtr, ByVal fuWinIni As UInteger) As Int32
    End Function
#End Region

#Region " Hide/Show Taskbar "
    Public Declare Function ShowWindow Lib "user32" _
    (ByVal hwnd As IntPtr, ByVal nCmdShow As Integer) As Integer

    Public Declare Function FindWindow Lib "user32" _
        Alias "FindWindowA" (ByVal lpClassName As String, _
        ByVal lpWindowName As String) As IntPtr

    Public Const SW_HIDE As Integer = 0
    Public Const SW_SHOW As Integer = 5

#End Region

#Region " Send Data to Other Windows "
    <StructLayout(LayoutKind.Sequential)> _
  Public Structure COPYDATASTRUCT
        Public dwData As IntPtr
        Public cdData As Integer
        Public lpData As IntPtr
    End Structure
    Public Const WM_COPYDATA As Integer = &H4A
#End Region

#Region " Inter-Window Communications "

    Public Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Public InterMsgID As Integer
    Public Const HWND_BROADCAST As Integer = &HFFFF

#End Region

#Region " Get Window List "

    Delegate Function EnumCallBack(ByVal hwnd As Integer, ByVal lParam As Integer) As Integer

    Declare Function EnumWindows Lib "user32" (ByVal lpEnumFunc As EnumCallBack, ByVal lParam As Integer) As Integer


    Declare Function GetParent Lib "user32" (ByVal hwnd As Integer) As Integer
    Declare Function GetWindow Lib "user32" (ByVal hwnd As Integer, ByVal wCmd As Integer) As Integer
    Public Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    Public Declare Auto Function SetWindowLong Lib "User32.Dll" (ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
    Declare Function IsWindowVisible Lib "user32" (ByVal hwnd As Integer) As Integer
    '
    ' Constants used with APIs
    '
    Public Const GW_OWNER As Short = 4
    Public Const GWL_EXSTYLE As Integer = (-20)
    Public Const GWL_STYLE As Integer = (-16)
    Public Const WS_EX_TOOLWINDOW As Short = &H80S
    Public Const WS_EX_APPWINDOW As Integer = &H40000
    Public Const WS_EX_TRANSPARENT As Integer = &H20
    Public Const TBSTYLE_TRANSPARENT As Integer = &H8000

    Dim myListBox As ListBox


#End Region

#Region " Log In Notification "
    'These functions are used to tell the computer that the shell is up and running.

    Public Enum EventAccessRights
        EVENT_ALL_ACCESS = &H1F0003
        EVENT_MODIFY_STATE = &H2
    End Enum

    <DllImport("kernel32.dll")> _
    Public Function OpenEvent(ByVal dwDesiredAcess As Integer, ByVal bInheritHandle As Boolean, ByVal lpName As String) As IntPtr
    End Function

    <DllImport("kernel32.dll")> _
    Public Function SetEvent(ByVal hEevent As IntPtr) As Boolean
    End Function

    <DllImport("kernel32.dll")> _
    Public Function CloseHandle(ByVal hObject As IntPtr) As Boolean
    End Function

#End Region

#Region " Close App "

    Private Const WM_CLOSE As Integer = &H10
    Private Const SC_CLOSE As Integer = &HF060
    Public Const WM_SYSCOMMAND As Integer = &H112

    Public Declare Function PostMessage Lib "user32.dll" Alias "PostMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer

#End Region

#Region " Cover Desktop "
    Public Declare Function SetParent Lib "user32.dll" (ByVal hWndChild As Integer, ByVal hWndNewParent As Integer) As Integer

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
   Public Function FindWindowEx(ByVal parentHandle As IntPtr, ByVal childAfter As IntPtr, ByVal lclassName As String, ByVal windowTitle As IntPtr) As IntPtr
    End Function
#End Region

#Region " Get Window based on coordinates "

    Public Declare Auto Function WindowFromPoint Lib "user32" (ByVal point As POINTAPI) As IntPtr

#End Region

#Region " Get/Set Autohide and AlwaysOnTop Settings (Taskbar) "

    Public Structure APPBARDATA
        Public cbSize As Integer
        Public hwnd As Integer
        Public uCallbackMessage As Integer
        Public uEdge As Integer
        Public rc As RECT
        Public lParam As Integer
    End Structure

    Private Const ABM_GETSTATE As Int32 = &H4
    Private Const ABM_SETSTATE As Int32 = &HA

    'Autohide
    Private Const ABS_AUTOHIDE As Int32 = &H1
    'Always on Top
    Private Const ABS_ALWAYSONTOP As Int32 = &H2

    Private Declare Function SHAppBarMessage Lib "shell32.dll" _
        (ByVal dwMessage As Integer, ByRef pData As APPBARDATA) As Integer

#End Region

#Region " Get My Videos folder "
    Public Function GetMyVideosPath() As String
        Dim result As String = GetSetting("LCARS x32", "Application", "Videos", "")
        If result = "" Then
            Try
                Dim myReg As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser
                myReg = myReg.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\explorer\Shell Folders\", False)
                result = myReg.GetValue("My Video")
                SaveSetting("LCARS x32", "Application", "Videos", result)
            Catch ex As Exception
            End Try
            If result = "" Then
                Dim res As DialogResult = MsgBox("Unable to find ""My Videos"". Would you like to manually set the path?", MsgBoxStyle.YesNo)
                If res = DialogResult.Yes Then
                    result = InputBox("Input the complete path to your ""My Videos"" directory:", "Input My Videos directory")
                    SaveSetting("LCARS x32", "Application", "Videos", result)
                End If
            End If
        End If

        Return result
    End Function
#End Region

#Region " Hide Windows components "

    'All code from PInvoke.net

    <Flags()> _
Public Enum SetWindowPosFlags As UInteger
        ''' <summary>If the calling thread and the thread that owns the window are attached to different input queues,
        ''' the system posts the request to the thread that owns the window. This prevents the calling thread from
        ''' blocking its execution while other threads process the request.</summary>
        ''' <remarks>SWP_ASYNCWINDOWPOS</remarks>
        SynchronousWindowPosition = &H4000
        ''' <summary>Prevents generation of the WM_SYNCPAINT message.</summary>
        ''' <remarks>SWP_DEFERERASE</remarks>
        DeferErase = &H2000
        ''' <summary>Draws a frame (defined in the window's class description) around the window.</summary>
        ''' <remarks>SWP_DRAWFRAME</remarks>
        DrawFrame = &H20
        ''' <summary>Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to
        ''' the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE
        ''' is sent only when the window's size is being changed.</summary>
        ''' <remarks>SWP_FRAMECHANGED</remarks>
        FrameChanged = &H20
        ''' <summary>Hides the window.</summary>
        ''' <remarks>SWP_HIDEWINDOW</remarks>
        HideWindow = &H80
        ''' <summary>Does not activate the window. If this flag is not set, the window is activated and moved to the
        ''' top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter
        ''' parameter).</summary>
        ''' <remarks>SWP_NOACTIVATE</remarks>
        DoNotActivate = &H10
        ''' <summary>Discards the entire contents of the client area. If this flag is not specified, the valid
        ''' contents of the client area are saved and copied back into the client area after the window is sized or
        ''' repositioned.</summary>
        ''' <remarks>SWP_NOCOPYBITS</remarks>
        DoNotCopyBits = &H100
        ''' <summary>Retains the current position (ignores X and Y parameters).</summary>
        ''' <remarks>SWP_NOMOVE</remarks>
        IgnoreMove = &H2
        ''' <summary>Does not change the owner window's position in the Z order.</summary>
        ''' <remarks>SWP_NOOWNERZORDER</remarks>
        DoNotChangeOwnerZOrder = &H200
        ''' <summary>Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to
        ''' the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent
        ''' window uncovered as a result of the window being moved. When this flag is set, the application must
        ''' explicitly invalidate or redraw any parts of the window and parent window that need redrawing.</summary>
        ''' <remarks>SWP_NOREDRAW</remarks>
        DoNotRedraw = &H8
        ''' <summary>Same as the SWP_NOOWNERZORDER flag.</summary>
        ''' <remarks>SWP_NOREPOSITION</remarks>
        DoNotReposition = &H200
        ''' <summary>Prevents the window from receiving the WM_WINDOWPOSCHANGING message.</summary>
        ''' <remarks>SWP_NOSENDCHANGING</remarks>
        DoNotSendChangingEvent = &H400
        ''' <summary>Retains the current size (ignores the cx and cy parameters).</summary>
        ''' <remarks>SWP_NOSIZE</remarks>
        IgnoreResize = &H1
        ''' <summary>Retains the current Z order (ignores the hWndInsertAfter parameter).</summary>
        ''' <remarks>SWP_NOZORDER</remarks>
        IgnoreZOrder = &H4
        ''' <summary>Displays the window.</summary>
        ''' <remarks>SWP_SHOWWINDOW</remarks>
        ShowWindow = &H40
    End Enum
    Public Declare Function SetWindowPos Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal hWndInsertAfter As IntPtr, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal uFlags As SetWindowPosFlags) As Boolean

#End Region

#End Region

    Public Sub setBusiness(ByRef business As modBusiness)
        curBusiness = business
    End Sub

    Public Sub SetWallpaper(ByVal wall As Image)
        myDesktop.pnlDesktop.BackgroundImage = wall
    End Sub

    Public Sub setWallpaperSizeMode(ByVal sizemode As ImageLayout)
        myDesktop.pnlDesktop.BackgroundImageLayout = sizemode
    End Sub



    Public Sub SetAutoHide(ByVal hide As Integer)
        CType(curBusiness.myForm, IAutohide).SetAutoHide(hide)
    End Sub

    Public Sub SetDesktop(ByVal desktop As Form)
        myDesktop = desktop
    End Sub

    Public Sub GeneralAlert(ByVal type As Integer)
        If inAlert Then
            'Code for canceling, then starting new alert
            alertThread.Abort()
        End If
        cancelAlert = True
        Dim alertstring As String = GetSetting("LCARS x32", "Alerts", type.ToString(), "Red|#FF0000|" & Application.StartupPath & "\red_alert.wav")
        Dim startIndex As Integer = alertstring.IndexOf("|")
        alertColor = ColorTranslator.FromHtml(alertstring.Substring(startIndex + 1, 7))
        alertSound = alertstring.Substring(startIndex + 9)
        Dim alertables As Collection = GetAlertPanels(curBusiness.myForm)
        alertThread = New Threading.Thread(AddressOf MainAlert)
        cancelAlert = False
        alertThread.Start(alertables)
        For Each mywindow As IntPtr In LinkedWindows
            SendMessage(mywindow, InterMsgID, type, 11)
        Next
    End Sub

    Private Function GetAlertPanels(ByVal baseControl As Control) As Collection
        Dim Alertables As New Collection
        Dim LCARSbutton As New LCARS.LCARSbuttonClass
        Dim LCARStype As Type = LCARSbutton.GetType
        Dim buffer As Integer

        'check for child controls and set them to alert also.
        For Each myControl As Control In baseControl.Controls
            If myControl.Controls.Count > 0 Then
                If Not myControl.GetType.IsSubclassOf(LCARStype) And Not myControl.Tag Is Nothing And myControl.Tag <> "" And Integer.TryParse(myControl.Tag, buffer) = True Then
                    'it has a tag and is a container, so start it alerting!
                    Alertables.Add(myControl)
                End If
                If Not myControl.GetType.IsSubclassOf(LCARStype) Then
                    Dim subAlertables As New Collection
                    subAlertables = GetAlertPanels(myControl)

                    For Each subControl As Control In subAlertables
                        Alertables.Add(subControl)
                    Next
                End If

            End If
        Next

        If Not baseControl.Tag Is Nothing And baseControl.Tag <> "" And Integer.TryParse(baseControl.Tag, buffer) = True Then
            Alertables.Add(baseControl)
        End If

        Return Alertables
    End Function

    Private Sub MainAlert(ByVal alertables As Collection)
        Dim LCARSbutton As New LCARS.LCARSbuttonClass
        Dim LCARStype As Type = LCARSbutton.GetType
        Dim intloop As Integer
        Dim buffer As Integer
        alertSoundMode = GetSetting("LCARS x32", "Application", "AlertSoundMode", AudioPlayMode.WaitToComplete)
        inAlert = True
        Dim highestTag As Integer = 0

        For Each myControl As Control In alertables
            If Not myControl.Tag Is Nothing And myControl.Tag <> "" And Integer.TryParse(myControl.Tag, buffer) = True Then
                If buffer > highestTag Then
                    highestTag = buffer
                End If
            End If
        Next
        Dim mySoundPath As String = alertSound
        'do the alert until cancelAlert is set to true:
        Do Until cancelAlert = True
            Dim soundThread As New Threading.Thread(AddressOf AlertSoundSub)
            If Not (mySoundPath = "") Then
                soundThread.Start(mySoundPath)
            End If

            For intloop = 0 To highestTag
                For Each myBaseControl As Control In alertables

                    If cancelAlert = True Then
                        Exit Do
                    End If

                    For Each myButton As Control In myBaseControl.Controls

                        If cancelAlert = True Then
                            Exit Do
                        End If
                        Dim myLCARSButton As LCARS.LCARSbuttonClass = TryCast(myButton, LCARS.LCARSbuttonClass)
                        If Not myLCARSButton Is Nothing Then
                            With myLCARSButton
                                If .CustomAlertColor <> alertColor Then
                                    .CustomAlertColor = alertColor
                                End If
                                If myButton.Tag = intloop Then
                                    .RedAlert = LCARS.LCARSalert.White
                                    Application.DoEvents()
                                Else
                                    If .RedAlert <> LCARS.LCARSalert.Custom Then
                                        .RedAlert = LCARS.LCARSalert.Custom
                                        Application.DoEvents()
                                    End If
                                End If
                            End With
                        End If

                        Application.DoEvents()
                    Next
                Next
                Threading.Thread.Sleep(50)
            Next
            If Not mySoundPath = "" Then
                soundThread.Join()
            End If
        Loop

        For Each myBaseControl As Control In alertables
            For Each mybutton As Control In myBaseControl.Controls
                If mybutton.GetType.IsSubclassOf(LCARStype) Then
                    With CType(mybutton, LCARS.LCARSbuttonClass)
                        .RedAlert = LCARS.LCARSalert.Normal
                    End With
                End If
            Next
        Next
        inAlert = False
        For Each mywindow As IntPtr In LinkedWindows
            SendMessage(mywindow, InterMsgID, 0, 7)
        Next
    End Sub

    Public Sub AlertSoundSub(ByVal soundPath As String)
        Try
            My.Computer.Audio.Play(soundPath, alertSoundMode)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub GetTaskbarSettings()
        'gets the AutoHide and AlwayOnTop settings of the taskbar, then sets the taskbar to "AlwaysOnTop"
        'If this wasn't done and the user has the taskbar set to "AutoHide" in Vista, LCARS x32 would 
        'constantly be fighting explorer for control of the WorkingArea.
        Dim TaskbarSettings As APPBARDATA

        TaskbarSettings.cbSize = Len(TaskbarSettings)
        TaskBarState = SHAppBarMessage(ABM_GETSTATE, TaskbarSettings)

        TaskbarSettings.lParam = ABS_ALWAYSONTOP
        SHAppBarMessage(ABM_SETSTATE, TaskbarSettings)
    End Sub

    Public Sub CloseWindow(ByVal hwnd As IntPtr)
        PostMessage(hwnd, WM_SYSCOMMAND, SC_CLOSE, 0)
        PostMessage(hwnd, WM_SYSCOMMAND, WM_CLOSE, 0)
    End Sub

    Public Sub ShowTaskBar(ByVal StartVisible As Boolean)
        Dim TaskbarHandle As IntPtr
        Dim StartButtonHandle As IntPtr

        TaskbarHandle = FindWindow("Shell_TrayWnd", "")
        StartButtonHandle = FindWindow("Button", "Start")

        If StartVisible Then
            ShowWindow(TaskbarHandle, SW_SHOW)
            ShowWindow(StartButtonHandle, SW_SHOW)
        Else
            ShowWindow(TaskbarHandle, SW_HIDE)
            ShowWindow(StartButtonHandle, SW_HIDE)
        End If
    End Sub

    Public Sub SetWindowState(ByVal hwnd As IntPtr, ByVal newState As WindowStates)
        Dim myPlacement As New WINDOWPLACEMENT()
        myPlacement.Length = Len(myPlacement)
        GetWindowPlacement(hwnd.ToInt32, myPlacement)

        If newState = WindowStates.NORMAL And myPlacement.flags = 2 Then
            newState = WindowStates.MAXIMIZED
        End If

        myPlacement.ShowCmd = newState
        SetWindowPlacement(hwnd.ToInt32, myPlacement)
    End Sub

    Public Sub SetTopWindow(ByVal hWnd As IntPtr)
        SetForegroundWindow(hWnd)
        CurTopWindow = hWnd
    End Sub

    Public Function getWindowState(ByVal hwnd As IntPtr) As WindowStates
        Dim myPlacement As New WINDOWPLACEMENT
        myPlacement.Length = Len(myPlacement)
        GetWindowPlacement(hwnd.ToInt32, myPlacement)
        Return myPlacement.ShowCmd
    End Function

    Public Function GetTopWindow() As Integer
        Return CurTopWindow
    End Function

    Public Sub resizeWorkingArea(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        Dim myArea As New RECT
        myArea.Left_Renamed = x
        myArea.Top_Renamed = y
        myArea.Right_Renamed = x + width
        myArea.Bottom_Renamed = y + height

        Dim ptr As IntPtr = IntPtr.Zero

        ptr = Marshal.AllocHGlobal(Marshal.SizeOf(myArea))

        Marshal.StructureToPtr(myArea, ptr, False)


        Dim i As Integer = SystemParametersInfo(SPI_SETWORKAREA, Marshal.SizeOf(myArea), ptr, SPIF_change)
        'If frmAlerts.Visible Then
        frmAlerts.Bounds = New Rectangle(x, y, width, height)
        'End If
    End Sub

    Public Sub SendDataToLinkedWindows(ByVal messageType As IntPtr, ByVal message As IntPtr)
        If LinkedWindows.Count > 0 Then
            For Each targetHandle As IntPtr In LinkedWindows
                Dim res As Integer = PostMessage(targetHandle, messageType, myDesktop.Handle, message)
            Next
        End If
    End Sub

    Public Sub CloseLCARS()
        SetParent(hTrayIcons, myIconSaver.Handle)

        Dim TaskbarSettings As APPBARDATA

        SendDataToLinkedWindows(InterMsgID, 13)
        'If LinkedWindows.GetUpperBound(0) > -1 Then
        '    For Each targetHandle As Integer In LinkedWindows
        '        Dim res As Integer = PostMessage(targetHandle, InterMsgID, myDesktop.Handle, 13)
        '    Next
        'End If


        '  If myForm.Location = New Point(0, 0) Then
        If Process.GetProcessesByName("explorer").Length > 0 Then
            ShowTaskBar(True)
            TaskbarSettings.cbSize = Len(TaskbarSettings)
            SHAppBarMessage(ABM_GETSTATE, TaskbarSettings)

            TaskbarSettings.lParam = TaskBarState

            SHAppBarMessage(ABM_SETSTATE, TaskbarSettings) 'put the taskbar's "AutoHide" setting back to what it was

        End If
        ' End If


        curBusiness.mainTimer.Enabled = False
        If Not curBusiness.myForm Is Nothing Then
            curBusiness.myForm.Dispose()
        End If
        If Not StartingWorkingArea = New Rectangle(0, 0, 0, 0) Then
            With StartingWorkingArea
                resizeWorkingArea(.X, .Y, .Width, .Height)
            End With
        End If

        Dim hwndProgMan As IntPtr = FindWindow("ProgMan", Nothing)
        Dim hwndSHELLDLL_DefView As IntPtr = FindWindowEx(hwndProgMan, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero)
        If hwndSHELLDLL_DefView = IntPtr.Zero Then
            Dim count As Integer = 0
            Dim parent As IntPtr = GetParent(hwndProgMan)
            Do
                If count > 14 Then
                    Exit Do
                End If
                hwndProgMan = FindWindowEx(parent, hwndProgMan, "WorkerW", IntPtr.Zero)
                'Debug.Print("WorkerW handle: " & Hex(hwndProgMan.ToInt32()))
                hwndSHELLDLL_DefView = FindWindowEx(hwndProgMan, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero)
                'Debug.Print("ShellDLL DefView handle: " & Hex(hwndSHELLDLL_DefView.ToInt32()))
                count += 1
            Loop While hwndSHELLDLL_DefView = IntPtr.Zero
        End If

        SetParent(SysListView, hwndSHELLDLL_DefView)
        Dim myStyle As Integer = GetWindowLong(hTrayIcons, GWL_STYLE)
        myStyle = myStyle Or TBSTYLE_TRANSPARENT

        SetWindowLong(hTrayIcons, GWL_STYLE, myStyle)

        SetParent(hTrayIcons, hTrayParent)


        myDesktop.Close()
        End

    End Sub

End Module
