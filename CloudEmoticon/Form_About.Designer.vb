<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_About
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_About))
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.PictureBox_Icon = New System.Windows.Forms.PictureBox()
        Me.Label_Description = New System.Windows.Forms.Label()
        Me.Label_Github = New System.Windows.Forms.Label()
        Me.Label_CloudEmoticon = New System.Windows.Forms.Label()
        CType(Me.PictureBox_Icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Title.Location = New System.Drawing.Point(40, 32)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(314, 80)
        Me.Label_Title.TabIndex = 1
        Me.Label_Title.Text = "CloudEmoticon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ver 1.3"
        Me.Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox_Icon
        '
        Me.PictureBox_Icon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox_Icon.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_Icon.BackgroundImage = Global.CloudEmoticon.My.Resources.Resources.Icon_80px
        Me.PictureBox_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_Icon.Location = New System.Drawing.Point(360, 32)
        Me.PictureBox_Icon.Name = "PictureBox_Icon"
        Me.PictureBox_Icon.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Icon.TabIndex = 2
        Me.PictureBox_Icon.TabStop = False
        '
        'Label_Description
        '
        Me.Label_Description.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.Label_Description.Location = New System.Drawing.Point(46, 125)
        Me.Label_Description.Name = "Label_Description"
        Me.Label_Description.Size = New System.Drawing.Size(394, 47)
        Me.Label_Description.TabIndex = 3
        Me.Label_Description.Text = "““云颜文字””桌面版 非官方客户端" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "制作者：✨小透明・宸✨"
        Me.Label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Github
        '
        Me.Label_Github.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_Github.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline)
        Me.Label_Github.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label_Github.Location = New System.Drawing.Point(84, 184)
        Me.Label_Github.Name = "Label_Github"
        Me.Label_Github.Size = New System.Drawing.Size(150, 32)
        Me.Label_Github.TabIndex = 4
        Me.Label_Github.Text = "GitHub 仓库"
        Me.Label_Github.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_CloudEmoticon
        '
        Me.Label_CloudEmoticon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label_CloudEmoticon.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline)
        Me.Label_CloudEmoticon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label_CloudEmoticon.Location = New System.Drawing.Point(240, 184)
        Me.Label_CloudEmoticon.Name = "Label_CloudEmoticon"
        Me.Label_CloudEmoticon.Size = New System.Drawing.Size(150, 32)
        Me.Label_CloudEmoticon.TabIndex = 5
        Me.Label_CloudEmoticon.Text = "““云颜文字””主页"
        Me.Label_CloudEmoticon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 240)
        Me.Controls.Add(Me.Label_CloudEmoticon)
        Me.Controls.Add(Me.Label_Github)
        Me.Controls.Add(Me.Label_Description)
        Me.Controls.Add(Me.PictureBox_Icon)
        Me.Controls.Add(Me.Label_Title)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_About"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox_Icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label_Title As Label
    Friend WithEvents PictureBox_Icon As PictureBox
    Friend WithEvents Label_Description As Label
    Friend WithEvents Label_Github As Label
    Friend WithEvents Label_CloudEmoticon As Label
End Class
