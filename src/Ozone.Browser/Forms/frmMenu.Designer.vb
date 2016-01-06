<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits XDockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.pnl_top = New System.Windows.Forms.Panel()
        Me.AddressBox1 = New Awesomium.Windows.Forms.AddressBox()
        Me.pnl_top_right = New System.Windows.Forms.Panel()
        Me.btn_go = New System.Windows.Forms.Button()
        Me.pnl_top_left = New System.Windows.Forms.Panel()
        Me.btn_bookmark = New System.Windows.Forms.Button()
        Me.btn_refresh_stop = New System.Windows.Forms.Button()
        Me.btn_forward = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.pnl_top.SuspendLayout()
        Me.pnl_top_right.SuspendLayout()
        Me.pnl_top_left.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_top
        '
        Me.pnl_top.Controls.Add(Me.AddressBox1)
        Me.pnl_top.Controls.Add(Me.pnl_top_right)
        Me.pnl_top.Controls.Add(Me.pnl_top_left)
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(541, 27)
        Me.pnl_top.TabIndex = 0
        '
        'AddressBox1
        '
        Me.AddressBox1.AcceptsReturn = True
        Me.AddressBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AddressBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.AddressBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddressBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressBox1.Location = New System.Drawing.Point(135, 0)
        Me.AddressBox1.Name = "AddressBox1"
        Me.AddressBox1.Size = New System.Drawing.Size(379, 27)
        Me.AddressBox1.TabIndex = 0
        Me.AddressBox1.URL = New System.Uri("", System.UriKind.Relative)
        Me.AddressBox1.WebControl = Nothing
        '
        'pnl_top_right
        '
        Me.pnl_top_right.Controls.Add(Me.btn_go)
        Me.pnl_top_right.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_top_right.Location = New System.Drawing.Point(514, 0)
        Me.pnl_top_right.Name = "pnl_top_right"
        Me.pnl_top_right.Size = New System.Drawing.Size(27, 27)
        Me.pnl_top_right.TabIndex = 2
        Me.pnl_top_right.Visible = False
        '
        'btn_go
        '
        Me.btn_go.BackgroundImage = CType(resources.GetObject("btn_go.BackgroundImage"), System.Drawing.Image)
        Me.btn_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_go.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_go.FlatAppearance.BorderSize = 0
        Me.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_go.Location = New System.Drawing.Point(0, 0)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(27, 27)
        Me.btn_go.TabIndex = 0
        Me.btn_go.UseVisualStyleBackColor = True
        '
        'pnl_top_left
        '
        Me.pnl_top_left.Controls.Add(Me.btn_bookmark)
        Me.pnl_top_left.Controls.Add(Me.btn_refresh_stop)
        Me.pnl_top_left.Controls.Add(Me.btn_forward)
        Me.pnl_top_left.Controls.Add(Me.btn_back)
        Me.pnl_top_left.Controls.Add(Me.btn_menu)
        Me.pnl_top_left.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_top_left.Location = New System.Drawing.Point(0, 0)
        Me.pnl_top_left.Name = "pnl_top_left"
        Me.pnl_top_left.Size = New System.Drawing.Size(135, 27)
        Me.pnl_top_left.TabIndex = 1
        '
        'btn_bookmark
        '
        Me.btn_bookmark.BackgroundImage = Global.Ozone.Browser.My.Resources.Resources.bookmark_unchecked
        Me.btn_bookmark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_bookmark.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_bookmark.FlatAppearance.BorderSize = 0
        Me.btn_bookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bookmark.Location = New System.Drawing.Point(108, 0)
        Me.btn_bookmark.Name = "btn_bookmark"
        Me.btn_bookmark.Size = New System.Drawing.Size(27, 27)
        Me.btn_bookmark.TabIndex = 5
        Me.btn_bookmark.UseVisualStyleBackColor = True
        '
        'btn_refresh_stop
        '
        Me.btn_refresh_stop.BackgroundImage = Global.Ozone.Browser.My.Resources.Resources._32_refresh
        Me.btn_refresh_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_refresh_stop.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_refresh_stop.FlatAppearance.BorderSize = 0
        Me.btn_refresh_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh_stop.Location = New System.Drawing.Point(81, 0)
        Me.btn_refresh_stop.Name = "btn_refresh_stop"
        Me.btn_refresh_stop.Size = New System.Drawing.Size(27, 27)
        Me.btn_refresh_stop.TabIndex = 4
        Me.btn_refresh_stop.UseVisualStyleBackColor = True
        '
        'btn_forward
        '
        Me.btn_forward.BackgroundImage = CType(resources.GetObject("btn_forward.BackgroundImage"), System.Drawing.Image)
        Me.btn_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_forward.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_forward.FlatAppearance.BorderSize = 0
        Me.btn_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_forward.Location = New System.Drawing.Point(54, 0)
        Me.btn_forward.Name = "btn_forward"
        Me.btn_forward.Size = New System.Drawing.Size(27, 27)
        Me.btn_forward.TabIndex = 3
        Me.btn_forward.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_back.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Location = New System.Drawing.Point(27, 0)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(27, 27)
        Me.btn_back.TabIndex = 2
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_menu
        '
        Me.btn_menu.BackgroundImage = CType(resources.GetObject("btn_menu.BackgroundImage"), System.Drawing.Image)
        Me.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_menu.FlatAppearance.BorderSize = 0
        Me.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_menu.Location = New System.Drawing.Point(0, 0)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(27, 27)
        Me.btn_menu.TabIndex = 1
        Me.btn_menu.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 27)
        Me.Controls.Add(Me.pnl_top)
        Me.DockAreas = CType((WeifenLuo.WinFormsUI.Docking.DockAreas.Float Or WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop), WeifenLuo.WinFormsUI.Docking.DockAreas)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.Text = "Navigation"
        Me.pnl_top.ResumeLayout(False)
        Me.pnl_top.PerformLayout()
        Me.pnl_top_right.ResumeLayout(False)
        Me.pnl_top_left.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_top As Panel
    Friend WithEvents pnl_top_right As Panel
    Friend WithEvents btn_go As Button
    Friend WithEvents pnl_top_left As Panel
    Friend WithEvents AddressBox1 As Awesomium.Windows.Forms.AddressBox
    Friend WithEvents btn_menu As Button
    Friend WithEvents btn_bookmark As Button
    Friend WithEvents btn_refresh_stop As Button
    Friend WithEvents btn_forward As Button
    Friend WithEvents btn_back As Button
End Class
