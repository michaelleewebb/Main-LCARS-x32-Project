<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPic))
        Me.tmrShow = New System.Windows.Forms.Timer(Me.components)
        Me.picturebox1 = New System.Windows.Forms.PictureBox
        Me.panel1 = New System.Windows.Forms.Panel
        Me.ArrowButton2 = New LCARS.Controls.ArrowButton
        Me.ArrowButton1 = New LCARS.Controls.ArrowButton
        Me.dwn = New LCARS.Controls.FlatButton
        Me.up = New LCARS.Controls.FlatButton
        Me.FlatButton2 = New LCARS.Controls.FlatButton
        Me.FlatButton8 = New LCARS.Controls.FlatButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rht = New LCARS.Controls.FlatButton
        Me.FlatButton13 = New LCARS.Controls.FlatButton
        Me.lft = New LCARS.Controls.FlatButton
        Me.FlatButton1 = New LCARS.Controls.FlatButton
        Me.abPrev = New LCARS.Controls.ArrowButton
        Me.abNext = New LCARS.Controls.ArrowButton
        Me.lblInfo = New System.Windows.Forms.Label
        Me.fbZoomOut = New LCARS.Controls.FlatButton
        Me.fbZoomIn = New LCARS.Controls.FlatButton
        Me.pbZoom = New LCARS.Controls.PieButton
        Me.fbActual = New LCARS.Controls.FlatButton
        Me.FlatButton6 = New LCARS.Controls.FlatButton
        Me.sbExitMyComp = New LCARS.Controls.StandardButton
        Me.tbTitle = New LCARS.Controls.TextButton
        Me.Elbow3 = New LCARS.Controls.Elbow
        Me.fbInfo1 = New LCARS.Controls.FlatButton
        Me.Elbow4 = New LCARS.Controls.Elbow
        Me.Elbow2 = New LCARS.Controls.Elbow
        Me.FlatButton4 = New LCARS.Controls.FlatButton
        Me.fbRes = New LCARS.Controls.FlatButton
        Me.Elbow1 = New LCARS.Controls.Elbow
        Me.StandardButton1 = New LCARS.Controls.StandardButton
        Me.sbBrowse = New LCARS.Controls.StandardButton
        Me.sbShow = New LCARS.Controls.StandardButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.tmrup = New System.Windows.Forms.Timer(Me.components)
        Me.tmrdown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox
        CType(Me.picturebox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrShow
        '
        Me.tmrShow.Interval = 5000
        '
        'picturebox1
        '
        Me.picturebox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picturebox1.BackColor = System.Drawing.Color.Black
        Me.picturebox1.Location = New System.Drawing.Point(3, 3)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(349, 486)
        Me.picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picturebox1.TabIndex = 0
        Me.picturebox1.TabStop = False
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.Controls.Add(Me.ArrowButton2)
        Me.panel1.Controls.Add(Me.ArrowButton1)
        Me.panel1.Controls.Add(Me.dwn)
        Me.panel1.Controls.Add(Me.up)
        Me.panel1.Controls.Add(Me.FlatButton2)
        Me.panel1.Controls.Add(Me.FlatButton8)
        Me.panel1.Location = New System.Drawing.Point(663, 388)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(44, 200)
        Me.panel1.TabIndex = 12
        '
        'ArrowButton2
        '
        Me.ArrowButton2.ArrowDirection = LCARS.LCARSarrowDirection.Down
        Me.ArrowButton2.AutoEllipsis = Nothing
        Me.ArrowButton2.BackgroundImage = CType(resources.GetObject("ArrowButton2.BackgroundImage"), System.Drawing.Image)
        Me.ArrowButton2.Beeping = False
        Me.ArrowButton2.ButtonText = ""
        Me.ArrowButton2.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ArrowButton2.ButtonTextHeight = 14
        Me.ArrowButton2.Clickable = True
        Me.ArrowButton2.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.ArrowButton2.Data = Nothing
        Me.ArrowButton2.Data2 = Nothing
        Me.ArrowButton2.FlashInterval = 500
        Me.ArrowButton2.holdDraw = False
        Me.ArrowButton2.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArrowButton2.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.ArrowButton2.lblTextSize = New System.Drawing.Point(32, 32)
        Me.ArrowButton2.lblTextVisible = True
        Me.ArrowButton2.Lit = True
        Me.ArrowButton2.Location = New System.Drawing.Point(6, 168)
        Me.ArrowButton2.Name = "ArrowButton2"
        Me.ArrowButton2.RedAlert = LCARS.LCARSalert.Normal
        Me.ArrowButton2.Size = New System.Drawing.Size(32, 32)
        Me.ArrowButton2.TabIndex = 71
        '
        'ArrowButton1
        '
        Me.ArrowButton1.ArrowDirection = LCARS.LCARSarrowDirection.Up
        Me.ArrowButton1.AutoEllipsis = Nothing
        Me.ArrowButton1.BackgroundImage = CType(resources.GetObject("ArrowButton1.BackgroundImage"), System.Drawing.Image)
        Me.ArrowButton1.Beeping = False
        Me.ArrowButton1.ButtonText = ""
        Me.ArrowButton1.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ArrowButton1.ButtonTextHeight = 14
        Me.ArrowButton1.Clickable = True
        Me.ArrowButton1.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.ArrowButton1.Data = Nothing
        Me.ArrowButton1.Data2 = Nothing
        Me.ArrowButton1.FlashInterval = 500
        Me.ArrowButton1.holdDraw = False
        Me.ArrowButton1.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArrowButton1.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.ArrowButton1.lblTextSize = New System.Drawing.Point(32, 32)
        Me.ArrowButton1.lblTextVisible = True
        Me.ArrowButton1.Lit = True
        Me.ArrowButton1.Location = New System.Drawing.Point(6, 0)
        Me.ArrowButton1.Name = "ArrowButton1"
        Me.ArrowButton1.RedAlert = LCARS.LCARSalert.Normal
        Me.ArrowButton1.Size = New System.Drawing.Size(32, 32)
        Me.ArrowButton1.TabIndex = 71
        '
        'dwn
        '
        Me.dwn.AutoEllipsis = False
        Me.dwn.BackgroundImage = CType(resources.GetObject("dwn.BackgroundImage"), System.Drawing.Image)
        Me.dwn.Beeping = False
        Me.dwn.ButtonText = ""
        Me.dwn.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.dwn.ButtonTextHeight = 14
        Me.dwn.Clickable = True
        Me.dwn.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.dwn.Data = Nothing
        Me.dwn.Data2 = Nothing
        Me.dwn.FlashInterval = 500
        Me.dwn.holdDraw = False
        Me.dwn.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dwn.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.dwn.lblTextSize = New System.Drawing.Point(32, 25)
        Me.dwn.lblTextVisible = True
        Me.dwn.Lit = True
        Me.dwn.Location = New System.Drawing.Point(6, 137)
        Me.dwn.Name = "dwn"
        Me.dwn.RedAlert = LCARS.LCARSalert.Normal
        Me.dwn.Size = New System.Drawing.Size(32, 25)
        Me.dwn.TabIndex = 14
        '
        'up
        '
        Me.up.AutoEllipsis = False
        Me.up.BackgroundImage = CType(resources.GetObject("up.BackgroundImage"), System.Drawing.Image)
        Me.up.Beeping = False
        Me.up.ButtonText = ""
        Me.up.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.up.ButtonTextHeight = 14
        Me.up.Clickable = True
        Me.up.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.up.Data = Nothing
        Me.up.Data2 = Nothing
        Me.up.FlashInterval = 500
        Me.up.holdDraw = False
        Me.up.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.up.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.up.lblTextSize = New System.Drawing.Point(32, 25)
        Me.up.lblTextVisible = True
        Me.up.Lit = True
        Me.up.Location = New System.Drawing.Point(6, 38)
        Me.up.Name = "up"
        Me.up.RedAlert = LCARS.LCARSalert.Normal
        Me.up.Size = New System.Drawing.Size(32, 25)
        Me.up.TabIndex = 11
        '
        'FlatButton2
        '
        Me.FlatButton2.AutoEllipsis = False
        Me.FlatButton2.BackgroundImage = CType(resources.GetObject("FlatButton2.BackgroundImage"), System.Drawing.Image)
        Me.FlatButton2.Beeping = False
        Me.FlatButton2.ButtonText = "NAV"
        Me.FlatButton2.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FlatButton2.ButtonTextHeight = 14
        Me.FlatButton2.Clickable = False
        Me.FlatButton2.Color = LCARS.LCARScolorStyles.NavigationFunction
        Me.FlatButton2.Data = Nothing
        Me.FlatButton2.Data2 = Nothing
        Me.FlatButton2.FlashInterval = 500
        Me.FlatButton2.holdDraw = False
        Me.FlatButton2.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton2.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.FlatButton2.lblTextSize = New System.Drawing.Point(44, 32)
        Me.FlatButton2.lblTextVisible = True
        Me.FlatButton2.Lit = True
        Me.FlatButton2.Location = New System.Drawing.Point(0, 84)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.RedAlert = LCARS.LCARSalert.Normal
        Me.FlatButton2.Size = New System.Drawing.Size(44, 32)
        Me.FlatButton2.TabIndex = 10
        Me.FlatButton2.Text = "NAV"
        '
        'FlatButton8
        '
        Me.FlatButton8.AutoEllipsis = False
        Me.FlatButton8.BackgroundImage = CType(resources.GetObject("FlatButton8.BackgroundImage"), System.Drawing.Image)
        Me.FlatButton8.Beeping = False
        Me.FlatButton8.ButtonText = ""
        Me.FlatButton8.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.FlatButton8.ButtonTextHeight = 14
        Me.FlatButton8.Clickable = False
        Me.FlatButton8.Color = LCARS.LCARScolorStyles.NavigationFunction
        Me.FlatButton8.Data = Nothing
        Me.FlatButton8.Data2 = Nothing
        Me.FlatButton8.FlashInterval = 500
        Me.FlatButton8.holdDraw = False
        Me.FlatButton8.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton8.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.FlatButton8.lblTextSize = New System.Drawing.Point(32, 61)
        Me.FlatButton8.lblTextVisible = True
        Me.FlatButton8.Lit = True
        Me.FlatButton8.Location = New System.Drawing.Point(6, 69)
        Me.FlatButton8.Name = "FlatButton8"
        Me.FlatButton8.RedAlert = LCARS.LCARSalert.Normal
        Me.FlatButton8.Size = New System.Drawing.Size(32, 61)
        Me.FlatButton8.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.rht)
        Me.Panel2.Controls.Add(Me.FlatButton13)
        Me.Panel2.Controls.Add(Me.lft)
        Me.Panel2.Controls.Add(Me.FlatButton1)
        Me.Panel2.Controls.Add(Me.abPrev)
        Me.Panel2.Controls.Add(Me.abNext)
        Me.Panel2.Location = New System.Drawing.Point(585, 466)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 44)
        Me.Panel2.TabIndex = 13
        '
        'rht
        '
        Me.rht.AutoEllipsis = False
        Me.rht.BackgroundImage = CType(resources.GetObject("rht.BackgroundImage"), System.Drawing.Image)
        Me.rht.Beeping = False
        Me.rht.ButtonText = ""
        Me.rht.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rht.ButtonTextHeight = 14
        Me.rht.Clickable = True
        Me.rht.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.rht.Data = Nothing
        Me.rht.Data2 = Nothing
        Me.rht.FlashInterval = 500
        Me.rht.holdDraw = False
        Me.rht.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rht.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.rht.lblTextSize = New System.Drawing.Point(20, 32)
        Me.rht.lblTextVisible = True
        Me.rht.Lit = True
        Me.rht.Location = New System.Drawing.Point(141, 6)
        Me.rht.Name = "rht"
        Me.rht.RedAlert = LCARS.LCARSalert.Normal
        Me.rht.Size = New System.Drawing.Size(20, 32)
        Me.rht.TabIndex = 78
        '
        'FlatButton13
        '
        Me.FlatButton13.AutoEllipsis = False
        Me.FlatButton13.BackgroundImage = CType(resources.GetObject("FlatButton13.BackgroundImage"), System.Drawing.Image)
        Me.FlatButton13.Beeping = False
        Me.FlatButton13.ButtonText = ""
        Me.FlatButton13.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.FlatButton13.ButtonTextHeight = 14
        Me.FlatButton13.Clickable = False
        Me.FlatButton13.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.FlatButton13.Data = Nothing
        Me.FlatButton13.Data2 = Nothing
        Me.FlatButton13.FlashInterval = 500
        Me.FlatButton13.holdDraw = False
        Me.FlatButton13.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton13.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.FlatButton13.lblTextSize = New System.Drawing.Point(20, 32)
        Me.FlatButton13.lblTextVisible = True
        Me.FlatButton13.Lit = True
        Me.FlatButton13.Location = New System.Drawing.Point(90, 6)
        Me.FlatButton13.Name = "FlatButton13"
        Me.FlatButton13.RedAlert = LCARS.LCARSalert.Normal
        Me.FlatButton13.Size = New System.Drawing.Size(20, 32)
        Me.FlatButton13.TabIndex = 73
        '
        'lft
        '
        Me.lft.AutoEllipsis = False
        Me.lft.BackgroundImage = CType(resources.GetObject("lft.BackgroundImage"), System.Drawing.Image)
        Me.lft.Beeping = False
        Me.lft.ButtonText = ""
        Me.lft.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lft.ButtonTextHeight = 14
        Me.lft.Clickable = True
        Me.lft.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.lft.Data = Nothing
        Me.lft.Data2 = Nothing
        Me.lft.FlashInterval = 500
        Me.lft.holdDraw = False
        Me.lft.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lft.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.lft.lblTextSize = New System.Drawing.Point(20, 32)
        Me.lft.lblTextVisible = True
        Me.lft.Lit = True
        Me.lft.Location = New System.Drawing.Point(38, 6)
        Me.lft.Name = "lft"
        Me.lft.RedAlert = LCARS.LCARSalert.Normal
        Me.lft.Size = New System.Drawing.Size(20, 32)
        Me.lft.TabIndex = 72
        '
        'FlatButton1
        '
        Me.FlatButton1.AutoEllipsis = False
        Me.FlatButton1.BackgroundImage = CType(resources.GetObject("FlatButton1.BackgroundImage"), System.Drawing.Image)
        Me.FlatButton1.Beeping = False
        Me.FlatButton1.ButtonText = ""
        Me.FlatButton1.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.FlatButton1.ButtonTextHeight = 14
        Me.FlatButton1.Clickable = False
        Me.FlatButton1.Color = LCARS.LCARScolorStyles.NavigationFunction
        Me.FlatButton1.Data = Nothing
        Me.FlatButton1.Data2 = Nothing
        Me.FlatButton1.FlashInterval = 500
        Me.FlatButton1.holdDraw = False
        Me.FlatButton1.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton1.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.FlatButton1.lblTextSize = New System.Drawing.Point(72, 32)
        Me.FlatButton1.lblTextVisible = True
        Me.FlatButton1.Lit = True
        Me.FlatButton1.Location = New System.Drawing.Point(63, 6)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.RedAlert = LCARS.LCARSalert.Normal
        Me.FlatButton1.Size = New System.Drawing.Size(72, 32)
        Me.FlatButton1.TabIndex = 4
        '
        'abPrev
        '
        Me.abPrev.ArrowDirection = LCARS.LCARSarrowDirection.Left
        Me.abPrev.AutoEllipsis = Nothing
        Me.abPrev.BackgroundImage = CType(resources.GetObject("abPrev.BackgroundImage"), System.Drawing.Image)
        Me.abPrev.Beeping = False
        Me.abPrev.ButtonText = ""
        Me.abPrev.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.abPrev.ButtonTextHeight = 14
        Me.abPrev.Clickable = True
        Me.abPrev.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.abPrev.Data = Nothing
        Me.abPrev.Data2 = Nothing
        Me.abPrev.FlashInterval = 500
        Me.abPrev.holdDraw = False
        Me.abPrev.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.abPrev.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.abPrev.lblTextSize = New System.Drawing.Point(31, 32)
        Me.abPrev.lblTextVisible = True
        Me.abPrev.Lit = True
        Me.abPrev.Location = New System.Drawing.Point(1, 6)
        Me.abPrev.Name = "abPrev"
        Me.abPrev.RedAlert = LCARS.LCARSalert.Normal
        Me.abPrev.Size = New System.Drawing.Size(31, 32)
        Me.abPrev.TabIndex = 2
        '
        'abNext
        '
        Me.abNext.ArrowDirection = LCARS.LCARSarrowDirection.Right
        Me.abNext.AutoEllipsis = Nothing
        Me.abNext.BackgroundImage = CType(resources.GetObject("abNext.BackgroundImage"), System.Drawing.Image)
        Me.abNext.Beeping = False
        Me.abNext.ButtonText = ""
        Me.abNext.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.abNext.ButtonTextHeight = 14
        Me.abNext.Clickable = True
        Me.abNext.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.abNext.Data = Nothing
        Me.abNext.Data2 = Nothing
        Me.abNext.FlashInterval = 500
        Me.abNext.holdDraw = False
        Me.abNext.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.abNext.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.abNext.lblTextSize = New System.Drawing.Point(32, 32)
        Me.abNext.lblTextVisible = True
        Me.abNext.Lit = True
        Me.abNext.Location = New System.Drawing.Point(167, 6)
        Me.abNext.Name = "abNext"
        Me.abNext.RedAlert = LCARS.LCARSalert.Normal
        Me.abNext.Size = New System.Drawing.Size(32, 32)
        Me.abNext.TabIndex = 3
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.Font = New System.Drawing.Font("LCARS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Orange
        Me.lblInfo.Location = New System.Drawing.Point(553, 61)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(221, 104)
        Me.lblInfo.TabIndex = 64
        '
        'fbZoomOut
        '
        Me.fbZoomOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbZoomOut.BackgroundImage = CType(resources.GetObject("fbZoomOut.BackgroundImage"), System.Drawing.Image)
        Me.fbZoomOut.Beeping = False
        Me.fbZoomOut.ButtonText = "−"
        Me.fbZoomOut.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.fbZoomOut.ButtonTextHeight = 14
        Me.fbZoomOut.Clickable = True
        Me.fbZoomOut.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.fbZoomOut.Data = Nothing
        Me.fbZoomOut.Data2 = Nothing
        Me.fbZoomOut.FlashInterval = 500
        Me.fbZoomOut.holdDraw = False
        Me.fbZoomOut.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbZoomOut.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.fbZoomOut.lblTextSize = New System.Drawing.Point(40, 40)
        Me.fbZoomOut.lblTextVisible = True
        Me.fbZoomOut.Lit = True
        Me.fbZoomOut.Location = New System.Drawing.Point(557, 306)
        Me.fbZoomOut.Name = "fbZoomOut"
        Me.fbZoomOut.RedAlert = LCARS.LCARSalert.Normal
        Me.fbZoomOut.Size = New System.Drawing.Size(40, 40)
        Me.fbZoomOut.TabIndex = 69
        Me.fbZoomOut.Text = "−"
        '
        'fbZoomIn
        '
        Me.fbZoomIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbZoomIn.BackgroundImage = CType(resources.GetObject("fbZoomIn.BackgroundImage"), System.Drawing.Image)
        Me.fbZoomIn.Beeping = False
        Me.fbZoomIn.ButtonText = "+"
        Me.fbZoomIn.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.fbZoomIn.ButtonTextHeight = 14
        Me.fbZoomIn.Clickable = True
        Me.fbZoomIn.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.fbZoomIn.Data = Nothing
        Me.fbZoomIn.Data2 = Nothing
        Me.fbZoomIn.FlashInterval = 500
        Me.fbZoomIn.holdDraw = False
        Me.fbZoomIn.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbZoomIn.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.fbZoomIn.lblTextSize = New System.Drawing.Point(40, 40)
        Me.fbZoomIn.lblTextVisible = True
        Me.fbZoomIn.Lit = True
        Me.fbZoomIn.Location = New System.Drawing.Point(648, 306)
        Me.fbZoomIn.Name = "fbZoomIn"
        Me.fbZoomIn.RedAlert = LCARS.LCARSalert.Normal
        Me.fbZoomIn.Size = New System.Drawing.Size(40, 40)
        Me.fbZoomIn.TabIndex = 67
        Me.fbZoomIn.Text = "+"
        '
        'pbZoom
        '
        Me.pbZoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbZoom.BackgroundImage = CType(resources.GetObject("pbZoom.BackgroundImage"), System.Drawing.Image)
        Me.pbZoom.Beeping = False
        Me.pbZoom.ButtonStyle = LCARS.Controls.PieButton.PieButtonStyles.UpperLeft
        Me.pbZoom.ButtonText = "ZOOM"
        Me.pbZoom.ButtonTextAlign = System.Drawing.ContentAlignment.TopRight
        Me.pbZoom.ButtonTextHeight = 14
        Me.pbZoom.CircleLocation = New System.Drawing.Point(130, 140)
        Me.pbZoom.CircleRadius = 110
        Me.pbZoom.Clickable = False
        Me.pbZoom.Color = LCARS.LCARScolorStyles.LCARSDisplayOnly
        Me.pbZoom.Data = Nothing
        Me.pbZoom.Data2 = Nothing
        Me.pbZoom.FlashInterval = 500
        Me.pbZoom.holdDraw = False
        Me.pbZoom.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbZoom.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.pbZoom.lblTextSize = New System.Drawing.Point(131, 95)
        Me.pbZoom.lblTextVisible = True
        Me.pbZoom.Lit = True
        Me.pbZoom.Location = New System.Drawing.Point(557, 352)
        Me.pbZoom.Name = "pbZoom"
        Me.pbZoom.RedAlert = LCARS.LCARSalert.Normal
        Me.pbZoom.Size = New System.Drawing.Size(131, 95)
        Me.pbZoom.TabIndex = 66
        Me.pbZoom.Text = "ZOOM"
        '
        'fbActual
        '
        Me.fbActual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbActual.BackgroundImage = CType(resources.GetObject("fbActual.BackgroundImage"), System.Drawing.Image)
        Me.fbActual.Beeping = False
        Me.fbActual.ButtonText = "FULL"
        Me.fbActual.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.fbActual.ButtonTextHeight = 14
        Me.fbActual.Clickable = True
        Me.fbActual.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.fbActual.Data = Nothing
        Me.fbActual.Data2 = Nothing
        Me.fbActual.FlashInterval = 500
        Me.fbActual.holdDraw = False
        Me.fbActual.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbActual.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.fbActual.lblTextSize = New System.Drawing.Point(40, 40)
        Me.fbActual.lblTextVisible = True
        Me.fbActual.Lit = True
        Me.fbActual.Location = New System.Drawing.Point(603, 306)
        Me.fbActual.Name = "fbActual"
        Me.fbActual.RedAlert = LCARS.LCARSalert.Normal
        Me.fbActual.Size = New System.Drawing.Size(40, 40)
        Me.fbActual.TabIndex = 68
        Me.fbActual.Text = "FULL"
        '
        'FlatButton6
        '
        Me.FlatButton6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton6.AutoEllipsis = False
        Me.FlatButton6.BackgroundImage = CType(resources.GetObject("FlatButton6.BackgroundImage"), System.Drawing.Image)
        Me.FlatButton6.Beeping = True
        Me.FlatButton6.ButtonText = ""
        Me.FlatButton6.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.FlatButton6.ButtonTextHeight = 14
        Me.FlatButton6.Clickable = False
        Me.FlatButton6.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.FlatButton6.Data = Nothing
        Me.FlatButton6.Data2 = Nothing
        Me.FlatButton6.FlashInterval = 500
        Me.FlatButton6.holdDraw = False
        Me.FlatButton6.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton6.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.FlatButton6.lblTextSize = New System.Drawing.Point(50, 334)
        Me.FlatButton6.lblTextVisible = True
        Me.FlatButton6.Lit = True
        Me.FlatButton6.Location = New System.Drawing.Point(473, 185)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.RedAlert = LCARS.LCARSalert.Normal
        Me.FlatButton6.Size = New System.Drawing.Size(50, 334)
        Me.FlatButton6.TabIndex = 22
        '
        'sbExitMyComp
        '
        Me.sbExitMyComp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbExitMyComp.AutoEllipsis = False
        Me.sbExitMyComp.BackgroundImage = CType(resources.GetObject("sbExitMyComp.BackgroundImage"), System.Drawing.Image)
        Me.sbExitMyComp.Beeping = False
        Me.sbExitMyComp.ButtonStyle = LCARS.Controls.StandardButton.LCARSbuttonStyles.RoundedSquare
        Me.sbExitMyComp.ButtonText = "X"
        Me.sbExitMyComp.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sbExitMyComp.ButtonTextHeight = 14
        Me.sbExitMyComp.Clickable = True
        Me.sbExitMyComp.Color = LCARS.LCARScolorStyles.FunctionOffline
        Me.sbExitMyComp.Data = Nothing
        Me.sbExitMyComp.Data2 = Nothing
        Me.sbExitMyComp.FlashInterval = 500
        Me.sbExitMyComp.holdDraw = False
        Me.sbExitMyComp.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbExitMyComp.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.sbExitMyComp.lblTextSize = New System.Drawing.Point(33, 32)
        Me.sbExitMyComp.lblTextVisible = True
        Me.sbExitMyComp.Lit = True
        Me.sbExitMyComp.Location = New System.Drawing.Point(760, 6)
        Me.sbExitMyComp.Name = "sbExitMyComp"
        Me.sbExitMyComp.RedAlert = LCARS.LCARSalert.Normal
        Me.sbExitMyComp.Size = New System.Drawing.Size(33, 32)
        Me.sbExitMyComp.TabIndex = 63
        Me.sbExitMyComp.Text = "X"
        '
        'tbTitle
        '
        Me.tbTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTitle.BackgroundImage = CType(resources.GetObject("tbTitle.BackgroundImage"), System.Drawing.Image)
        Me.tbTitle.Beeping = False
        Me.tbTitle.ButtonText = "LCARS"
        Me.tbTitle.ButtonTextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.tbTitle.ButtonTextHeight = 32
        Me.tbTitle.ButtonType = LCARS.Controls.TextButton.TextButtonType.DoublePills
        Me.tbTitle.Clickable = False
        Me.tbTitle.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.tbTitle.Data = Nothing
        Me.tbTitle.Data2 = Nothing
        Me.tbTitle.FlashInterval = 500
        Me.tbTitle.holdDraw = False
        Me.tbTitle.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTitle.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.tbTitle.lblTextSize = New System.Drawing.Point(746, 31)
        Me.tbTitle.lblTextVisible = False
        Me.tbTitle.Lit = True
        Me.tbTitle.Location = New System.Drawing.Point(8, 6)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.RedAlert = LCARS.LCARSalert.Normal
        Me.tbTitle.Size = New System.Drawing.Size(746, 31)
        Me.tbTitle.TabIndex = 62
        Me.tbTitle.Text = "LCARS"
        '
        'Elbow3
        '
        Me.Elbow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Elbow3.AutoEllipsis = False
        Me.Elbow3.BackgroundImage = CType(resources.GetObject("Elbow3.BackgroundImage"), System.Drawing.Image)
        Me.Elbow3.Beeping = True
        Me.Elbow3.ButtonHeight = 10
        Me.Elbow3.ButtonText = ""
        Me.Elbow3.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Elbow3.ButtonTextHeight = 14
        Me.Elbow3.ButtonWidth = 50
        Me.Elbow3.Clickable = False
        Me.Elbow3.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.Elbow3.Data = Nothing
        Me.Elbow3.Data2 = Nothing
        Me.Elbow3.ElbowRatio = New System.Drawing.Point(1, 1)
        Me.Elbow3.ElbowStyle = LCARS.Controls.Elbow.LCARSelbowStyles.LowerRight
        Me.Elbow3.FlashInterval = 500
        Me.Elbow3.holdDraw = False
        Me.Elbow3.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Elbow3.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.Elbow3.lblTextSize = New System.Drawing.Point(72, 68)
        Me.Elbow3.lblTextVisible = True
        Me.Elbow3.Lit = True
        Me.Elbow3.Location = New System.Drawing.Point(451, 525)
        Me.Elbow3.Name = "Elbow3"
        Me.Elbow3.RedAlert = LCARS.LCARSalert.Normal
        Me.Elbow3.Size = New System.Drawing.Size(72, 68)
        Me.Elbow3.TabIndex = 23
        '
        'fbInfo1
        '
        Me.fbInfo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbInfo1.AutoEllipsis = False
        Me.fbInfo1.BackgroundImage = CType(resources.GetObject("fbInfo1.BackgroundImage"), System.Drawing.Image)
        Me.fbInfo1.Beeping = True
        Me.fbInfo1.ButtonText = ""
        Me.fbInfo1.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.fbInfo1.ButtonTextHeight = 14
        Me.fbInfo1.Clickable = False
        Me.fbInfo1.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.fbInfo1.Data = Nothing
        Me.fbInfo1.Data2 = Nothing
        Me.fbInfo1.FlashInterval = 500
        Me.fbInfo1.holdDraw = False
        Me.fbInfo1.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbInfo1.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.fbInfo1.lblTextSize = New System.Drawing.Point(50, 57)
        Me.fbInfo1.lblTextVisible = True
        Me.fbInfo1.Lit = True
        Me.fbInfo1.Location = New System.Drawing.Point(473, 122)
        Me.fbInfo1.Name = "fbInfo1"
        Me.fbInfo1.RedAlert = LCARS.LCARSalert.Normal
        Me.fbInfo1.Size = New System.Drawing.Size(50, 57)
        Me.fbInfo1.TabIndex = 21
        '
        'Elbow4
        '
        Me.Elbow4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Elbow4.AutoEllipsis = False
        Me.Elbow4.BackgroundImage = CType(resources.GetObject("Elbow4.BackgroundImage"), System.Drawing.Image)
        Me.Elbow4.Beeping = True
        Me.Elbow4.ButtonHeight = 10
        Me.Elbow4.ButtonText = ""
        Me.Elbow4.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Elbow4.ButtonTextHeight = 14
        Me.Elbow4.ButtonWidth = 50
        Me.Elbow4.Clickable = False
        Me.Elbow4.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.Elbow4.Data = Nothing
        Me.Elbow4.Data2 = Nothing
        Me.Elbow4.ElbowRatio = New System.Drawing.Point(1, 1)
        Me.Elbow4.ElbowStyle = LCARS.Controls.Elbow.LCARSelbowStyles.UpperRight
        Me.Elbow4.FlashInterval = 500
        Me.Elbow4.holdDraw = False
        Me.Elbow4.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Elbow4.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.Elbow4.lblTextSize = New System.Drawing.Point(72, 68)
        Me.Elbow4.lblTextVisible = True
        Me.Elbow4.Lit = True
        Me.Elbow4.Location = New System.Drawing.Point(451, 48)
        Me.Elbow4.Name = "Elbow4"
        Me.Elbow4.RedAlert = LCARS.LCARSalert.Normal
        Me.Elbow4.Size = New System.Drawing.Size(72, 68)
        Me.Elbow4.TabIndex = 20
        '
        'Elbow2
        '
        Me.Elbow2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Elbow2.AutoEllipsis = False
        Me.Elbow2.BackgroundImage = CType(resources.GetObject("Elbow2.BackgroundImage"), System.Drawing.Image)
        Me.Elbow2.Beeping = True
        Me.Elbow2.ButtonHeight = 10
        Me.Elbow2.ButtonText = ""
        Me.Elbow2.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Elbow2.ButtonTextHeight = 14
        Me.Elbow2.ButtonWidth = 50
        Me.Elbow2.Clickable = False
        Me.Elbow2.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.Elbow2.Data = Nothing
        Me.Elbow2.Data2 = Nothing
        Me.Elbow2.ElbowRatio = New System.Drawing.Point(1, 1)
        Me.Elbow2.ElbowStyle = LCARS.Controls.Elbow.LCARSelbowStyles.LowerLeft
        Me.Elbow2.FlashInterval = 500
        Me.Elbow2.holdDraw = False
        Me.Elbow2.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Elbow2.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.Elbow2.lblTextSize = New System.Drawing.Point(72, 68)
        Me.Elbow2.lblTextVisible = True
        Me.Elbow2.Lit = True
        Me.Elbow2.Location = New System.Drawing.Point(12, 520)
        Me.Elbow2.Name = "Elbow2"
        Me.Elbow2.RedAlert = LCARS.LCARSalert.Normal
        Me.Elbow2.Size = New System.Drawing.Size(72, 68)
        Me.Elbow2.TabIndex = 19
        '
        'FlatButton4
        '
        Me.FlatButton4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatButton4.AutoEllipsis = False
        Me.FlatButton4.BackgroundImage = CType(resources.GetObject("FlatButton4.BackgroundImage"), System.Drawing.Image)
        Me.FlatButton4.Beeping = True
        Me.FlatButton4.ButtonText = ""
        Me.FlatButton4.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.FlatButton4.ButtonTextHeight = 14
        Me.FlatButton4.Clickable = False
        Me.FlatButton4.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.FlatButton4.Data = Nothing
        Me.FlatButton4.Data2 = Nothing
        Me.FlatButton4.FlashInterval = 500
        Me.FlatButton4.holdDraw = False
        Me.FlatButton4.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton4.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.FlatButton4.lblTextSize = New System.Drawing.Point(50, 334)
        Me.FlatButton4.lblTextVisible = True
        Me.FlatButton4.Lit = True
        Me.FlatButton4.Location = New System.Drawing.Point(12, 180)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.RedAlert = LCARS.LCARSalert.Normal
        Me.FlatButton4.Size = New System.Drawing.Size(50, 334)
        Me.FlatButton4.TabIndex = 18
        '
        'fbRes
        '
        Me.fbRes.AutoEllipsis = False
        Me.fbRes.BackgroundImage = CType(resources.GetObject("fbRes.BackgroundImage"), System.Drawing.Image)
        Me.fbRes.Beeping = True
        Me.fbRes.ButtonText = ""
        Me.fbRes.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.fbRes.ButtonTextHeight = 14
        Me.fbRes.Clickable = False
        Me.fbRes.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.fbRes.Data = Nothing
        Me.fbRes.Data2 = Nothing
        Me.fbRes.FlashInterval = 500
        Me.fbRes.holdDraw = False
        Me.fbRes.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbRes.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.fbRes.lblTextSize = New System.Drawing.Point(50, 57)
        Me.fbRes.lblTextVisible = True
        Me.fbRes.Lit = True
        Me.fbRes.Location = New System.Drawing.Point(12, 117)
        Me.fbRes.Name = "fbRes"
        Me.fbRes.RedAlert = LCARS.LCARSalert.Normal
        Me.fbRes.Size = New System.Drawing.Size(50, 57)
        Me.fbRes.TabIndex = 17
        '
        'Elbow1
        '
        Me.Elbow1.AutoEllipsis = False
        Me.Elbow1.BackgroundImage = CType(resources.GetObject("Elbow1.BackgroundImage"), System.Drawing.Image)
        Me.Elbow1.Beeping = True
        Me.Elbow1.ButtonHeight = 10
        Me.Elbow1.ButtonText = ""
        Me.Elbow1.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Elbow1.ButtonTextHeight = 14
        Me.Elbow1.ButtonWidth = 50
        Me.Elbow1.Clickable = False
        Me.Elbow1.Color = LCARS.LCARScolorStyles.MiscFunction
        Me.Elbow1.Data = Nothing
        Me.Elbow1.Data2 = Nothing
        Me.Elbow1.ElbowRatio = New System.Drawing.Point(1, 1)
        Me.Elbow1.ElbowStyle = LCARS.Controls.Elbow.LCARSelbowStyles.UpperLeft
        Me.Elbow1.FlashInterval = 500
        Me.Elbow1.holdDraw = False
        Me.Elbow1.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Elbow1.lblTextLoc = New System.Drawing.Point(0, 0)
        Me.Elbow1.lblTextSize = New System.Drawing.Point(72, 68)
        Me.Elbow1.lblTextVisible = True
        Me.Elbow1.Lit = True
        Me.Elbow1.Location = New System.Drawing.Point(12, 43)
        Me.Elbow1.Name = "Elbow1"
        Me.Elbow1.RedAlert = LCARS.LCARSalert.Normal
        Me.Elbow1.Size = New System.Drawing.Size(72, 68)
        Me.Elbow1.TabIndex = 16
        '
        'StandardButton1
        '
        Me.StandardButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StandardButton1.AutoEllipsis = False
        Me.StandardButton1.BackgroundImage = CType(resources.GetObject("StandardButton1.BackgroundImage"), System.Drawing.Image)
        Me.StandardButton1.Beeping = False
        Me.StandardButton1.ButtonStyle = LCARS.Controls.StandardButton.LCARSbuttonStyles.Pill
        Me.StandardButton1.ButtonText = ""
        Me.StandardButton1.ButtonTextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.StandardButton1.ButtonTextHeight = 14
        Me.StandardButton1.Clickable = False
        Me.StandardButton1.Color = LCARS.LCARScolorStyles.StaticTan
        Me.StandardButton1.Data = Nothing
        Me.StandardButton1.Data2 = Nothing
        Me.StandardButton1.FlashInterval = 500
        Me.StandardButton1.holdDraw = False
        Me.StandardButton1.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StandardButton1.lblTextLoc = New System.Drawing.Point(100, 0)
        Me.StandardButton1.lblTextSize = New System.Drawing.Point(0, 200)
        Me.StandardButton1.lblTextVisible = True
        Me.StandardButton1.Lit = True
        Me.StandardButton1.Location = New System.Drawing.Point(585, 388)
        Me.StandardButton1.Name = "StandardButton1"
        Me.StandardButton1.RedAlert = LCARS.LCARSalert.Normal
        Me.StandardButton1.Size = New System.Drawing.Size(200, 200)
        Me.StandardButton1.TabIndex = 11
        '
        'sbBrowse
        '
        Me.sbBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbBrowse.AutoEllipsis = False
        Me.sbBrowse.BackgroundImage = CType(resources.GetObject("sbBrowse.BackgroundImage"), System.Drawing.Image)
        Me.sbBrowse.Beeping = False
        Me.sbBrowse.ButtonStyle = LCARS.Controls.StandardButton.LCARSbuttonStyles.Pill
        Me.sbBrowse.ButtonText = "BROWSE"
        Me.sbBrowse.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbBrowse.ButtonTextHeight = 14
        Me.sbBrowse.Clickable = True
        Me.sbBrowse.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.sbBrowse.Data = Nothing
        Me.sbBrowse.Data2 = Nothing
        Me.sbBrowse.FlashInterval = 500
        Me.sbBrowse.holdDraw = False
        Me.sbBrowse.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbBrowse.lblTextLoc = New System.Drawing.Point(17, 0)
        Me.sbBrowse.lblTextSize = New System.Drawing.Point(95, 35)
        Me.sbBrowse.lblTextVisible = True
        Me.sbBrowse.Lit = True
        Me.sbBrowse.Location = New System.Drawing.Point(624, 185)
        Me.sbBrowse.Name = "sbBrowse"
        Me.sbBrowse.RedAlert = LCARS.LCARSalert.Normal
        Me.sbBrowse.Size = New System.Drawing.Size(130, 35)
        Me.sbBrowse.TabIndex = 10
        Me.sbBrowse.Text = "BROWSE"
        '
        'sbShow
        '
        Me.sbShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbShow.AutoEllipsis = False
        Me.sbShow.BackgroundImage = CType(resources.GetObject("sbShow.BackgroundImage"), System.Drawing.Image)
        Me.sbShow.Beeping = False
        Me.sbShow.ButtonStyle = LCARS.Controls.StandardButton.LCARSbuttonStyles.Pill
        Me.sbShow.ButtonText = "START SLIDE SHOW"
        Me.sbShow.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbShow.ButtonTextHeight = 14
        Me.sbShow.Clickable = True
        Me.sbShow.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.sbShow.Data = Nothing
        Me.sbShow.Data2 = Nothing
        Me.sbShow.FlashInterval = 500
        Me.sbShow.holdDraw = False
        Me.sbShow.lblTextAnchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbShow.lblTextLoc = New System.Drawing.Point(17, 0)
        Me.sbShow.lblTextSize = New System.Drawing.Point(95, 35)
        Me.sbShow.lblTextVisible = True
        Me.sbShow.Lit = True
        Me.sbShow.Location = New System.Drawing.Point(623, 226)
        Me.sbShow.Name = "sbShow"
        Me.sbShow.RedAlert = LCARS.LCARSalert.Normal
        Me.sbShow.Size = New System.Drawing.Size(130, 35)
        Me.sbShow.TabIndex = 9
        Me.sbShow.Text = "START SLIDE SHOW"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(700, 306)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 13)
        Me.TextBox1.TabIndex = 76
        Me.TextBox1.Text = "0"
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(700, 332)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(74, 13)
        Me.TextBox2.TabIndex = 77
        Me.TextBox2.Text = "0"
        Me.TextBox2.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.picturebox1)
        Me.Panel3.Location = New System.Drawing.Point(90, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(355, 492)
        Me.Panel3.TabIndex = 70
        '
        'tmrup
        '
        '
        'tmrdown
        '
        '
        'tmrleft
        '
        '
        'tmrright
        '
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(693, 61)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 78
        Me.TextBox3.Visible = False
        '
        'frmPic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.fbZoomOut)
        Me.Controls.Add(Me.fbZoomIn)
        Me.Controls.Add(Me.pbZoom)
        Me.Controls.Add(Me.fbActual)
        Me.Controls.Add(Me.FlatButton6)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.sbExitMyComp)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.Elbow3)
        Me.Controls.Add(Me.fbInfo1)
        Me.Controls.Add(Me.Elbow4)
        Me.Controls.Add(Me.Elbow2)
        Me.Controls.Add(Me.FlatButton4)
        Me.Controls.Add(Me.fbRes)
        Me.Controls.Add(Me.Elbow1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StandardButton1)
        Me.Controls.Add(Me.sbBrowse)
        Me.Controls.Add(Me.sbShow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPic"
        Me.Text = "Photo Viewer"
        CType(Me.picturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picturebox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrShow As System.Windows.Forms.Timer
    Friend WithEvents sbShow As LCARS.Controls.StandardButton
    Friend WithEvents sbBrowse As LCARS.Controls.StandardButton
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents dwn As LCARS.Controls.FlatButton
    Friend WithEvents up As LCARS.Controls.FlatButton
    Friend WithEvents FlatButton2 As LCARS.Controls.FlatButton
    Friend WithEvents FlatButton8 As LCARS.Controls.FlatButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FlatButton1 As LCARS.Controls.FlatButton
    Friend WithEvents abPrev As LCARS.Controls.ArrowButton
    Friend WithEvents abNext As LCARS.Controls.ArrowButton
    Friend WithEvents StandardButton1 As LCARS.Controls.StandardButton
    Friend WithEvents Elbow1 As LCARS.Controls.Elbow
    Friend WithEvents fbRes As LCARS.Controls.FlatButton
    Friend WithEvents FlatButton4 As LCARS.Controls.FlatButton
    Friend WithEvents Elbow2 As LCARS.Controls.Elbow
    Friend WithEvents Elbow3 As LCARS.Controls.Elbow
    Friend WithEvents FlatButton6 As LCARS.Controls.FlatButton
    Friend WithEvents fbInfo1 As LCARS.Controls.FlatButton
    Friend WithEvents Elbow4 As LCARS.Controls.Elbow
    Friend WithEvents tbTitle As LCARS.Controls.TextButton
    Friend WithEvents sbExitMyComp As LCARS.Controls.StandardButton
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents pbZoom As LCARS.Controls.PieButton
    Friend WithEvents fbZoomIn As LCARS.Controls.FlatButton
    Friend WithEvents fbActual As LCARS.Controls.FlatButton
    Friend WithEvents ArrowButton2 As LCARS.Controls.ArrowButton
    Friend WithEvents ArrowButton1 As LCARS.Controls.ArrowButton
    Friend WithEvents fbZoomOut As LCARS.Controls.FlatButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents rht As LCARS.Controls.FlatButton
    Friend WithEvents FlatButton13 As LCARS.Controls.FlatButton
    Friend WithEvents lft As LCARS.Controls.FlatButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tmrup As System.Windows.Forms.Timer
    Friend WithEvents tmrdown As System.Windows.Forms.Timer
    Friend WithEvents tmrleft As System.Windows.Forms.Timer
    Friend WithEvents tmrright As System.Windows.Forms.Timer
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
