<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManager
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
        Dim DockPanelSkin1 As WeifenLuo.WinFormsUI.Docking.DockPanelSkin = New WeifenLuo.WinFormsUI.Docking.DockPanelSkin()
        Dim AutoHideStripSkin1 As WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin = New WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin()
        Dim DockPanelGradient1 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient1 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPaneStripSkin1 As WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin = New WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin()
        Dim DockPaneStripGradient1 As WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient = New WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient()
        Dim TabGradient2 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPanelGradient2 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient3 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPaneStripToolWindowGradient1 As WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient = New WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient()
        Dim TabGradient4 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim TabGradient5 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim DockPanelGradient3 As WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
        Dim TabGradient6 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim TabGradient7 As WeifenLuo.WinFormsUI.Docking.TabGradient = New WeifenLuo.WinFormsUI.Docking.TabGradient()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManager))
        Me.DockPanel1 = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.VS2012LightTheme1 = New WeifenLuo.WinFormsUI.Docking.VS2012LightTheme()
        Me.SuspendLayout()
        '
        'DockPanel1
        '
        Me.DockPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Size = New System.Drawing.Size(885, 567)
        DockPanelGradient1.EndColor = System.Drawing.SystemColors.ControlLight
        DockPanelGradient1.StartColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        AutoHideStripSkin1.DockStripGradient = DockPanelGradient1
        TabGradient1.EndColor = System.Drawing.SystemColors.Control
        TabGradient1.StartColor = System.Drawing.SystemColors.Control
        TabGradient1.TextColor = System.Drawing.SystemColors.ControlDarkDark
        AutoHideStripSkin1.TabGradient = TabGradient1
        AutoHideStripSkin1.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        DockPanelSkin1.AutoHideStripSkin = AutoHideStripSkin1
        TabGradient2.EndColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        TabGradient2.StartColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        TabGradient2.TextColor = System.Drawing.Color.White
        DockPaneStripGradient1.ActiveTabGradient = TabGradient2
        DockPanelGradient2.EndColor = System.Drawing.SystemColors.Control
        DockPanelGradient2.StartColor = System.Drawing.SystemColors.Control
        DockPaneStripGradient1.DockStripGradient = DockPanelGradient2
        TabGradient3.EndColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(234, Byte), Integer))
        TabGradient3.StartColor = System.Drawing.SystemColors.Control
        TabGradient3.TextColor = System.Drawing.Color.Black
        DockPaneStripGradient1.InactiveTabGradient = TabGradient3
        DockPaneStripSkin1.DocumentGradient = DockPaneStripGradient1
        DockPaneStripSkin1.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        TabGradient4.EndColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        TabGradient4.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TabGradient4.StartColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        TabGradient4.TextColor = System.Drawing.Color.White
        DockPaneStripToolWindowGradient1.ActiveCaptionGradient = TabGradient4
        TabGradient5.EndColor = System.Drawing.SystemColors.ControlLightLight
        TabGradient5.StartColor = System.Drawing.SystemColors.ControlLightLight
        TabGradient5.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        DockPaneStripToolWindowGradient1.ActiveTabGradient = TabGradient5
        DockPanelGradient3.EndColor = System.Drawing.SystemColors.Control
        DockPanelGradient3.StartColor = System.Drawing.SystemColors.Control
        DockPaneStripToolWindowGradient1.DockStripGradient = DockPanelGradient3
        TabGradient6.EndColor = System.Drawing.SystemColors.ControlDark
        TabGradient6.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        TabGradient6.StartColor = System.Drawing.SystemColors.Control
        TabGradient6.TextColor = System.Drawing.SystemColors.GrayText
        DockPaneStripToolWindowGradient1.InactiveCaptionGradient = TabGradient6
        TabGradient7.EndColor = System.Drawing.SystemColors.Control
        TabGradient7.StartColor = System.Drawing.SystemColors.Control
        TabGradient7.TextColor = System.Drawing.SystemColors.GrayText
        DockPaneStripToolWindowGradient1.InactiveTabGradient = TabGradient7
        DockPaneStripSkin1.ToolWindowGradient = DockPaneStripToolWindowGradient1
        DockPanelSkin1.DockPaneStripSkin = DockPaneStripSkin1
        Me.DockPanel1.Skin = DockPanelSkin1
        Me.DockPanel1.TabIndex = 0
        Me.DockPanel1.Theme = Me.VS2012LightTheme1
        '
        'frmManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 567)
        Me.Controls.Add(Me.DockPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmManager"
        Me.Text = "Ozone Browser"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DockPanel1 As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents VS2012LightTheme1 As WeifenLuo.WinFormsUI.Docking.VS2012LightTheme
End Class
