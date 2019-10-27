<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Config
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Config))
        Me.Label_Config = New System.Windows.Forms.Label()
        Me.TextBox_Path = New System.Windows.Forms.TextBox()
        Me.Label_Path = New System.Windows.Forms.Label()
        Me.Label_FormTransitionTime = New System.Windows.Forms.Label()
        Me.NumericUpDown_FormTransitionTime = New System.Windows.Forms.NumericUpDown()
        Me.Button_Apply = New System.Windows.Forms.Button()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.NumericUpDown_FormWidthRatio = New System.Windows.Forms.NumericUpDown()
        Me.Label_FormWidthRatio = New System.Windows.Forms.Label()
        Me.GroupBox_Manual = New System.Windows.Forms.GroupBox()
        Me.Button_Path = New System.Windows.Forms.Button()
        Me.GroupBox_Skin = New System.Windows.Forms.GroupBox()
        Me.Button_SkinTextSecondaryColor = New System.Windows.Forms.Button()
        Me.Button_SkinTextPrimaryColor = New System.Windows.Forms.Button()
        Me.Button_SkinBackgroundColor = New System.Windows.Forms.Button()
        Me.Label_SkinTextSecondaryColor = New System.Windows.Forms.Label()
        Me.Label_SkinTextPrimaryColor = New System.Windows.Forms.Label()
        Me.Label_SkinBackgroundColor = New System.Windows.Forms.Label()
        Me.Button_SkinPicture = New System.Windows.Forms.Button()
        Me.Label_SkinPicture = New System.Windows.Forms.Label()
        Me.TextBox_SkinPicture = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.CheckBox_CopyToClipboard = New System.Windows.Forms.CheckBox()
        CType(Me.NumericUpDown_FormTransitionTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_FormWidthRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Manual.SuspendLayout()
        Me.GroupBox_Skin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Config
        '
        Me.Label_Config.AutoSize = True
        Me.Label_Config.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Config.Location = New System.Drawing.Point(8, 8)
        Me.Label_Config.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Config.Name = "Label_Config"
        Me.Label_Config.Size = New System.Drawing.Size(62, 31)
        Me.Label_Config.TabIndex = 0
        Me.Label_Config.Text = "设置"
        '
        'TextBox_Path
        '
        Me.TextBox_Path.Location = New System.Drawing.Point(120, 29)
        Me.TextBox_Path.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_Path.Name = "TextBox_Path"
        Me.TextBox_Path.Size = New System.Drawing.Size(432, 29)
        Me.TextBox_Path.TabIndex = 1
        '
        'Label_Path
        '
        Me.Label_Path.AutoSize = True
        Me.Label_Path.Location = New System.Drawing.Point(8, 32)
        Me.Label_Path.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Path.Name = "Label_Path"
        Me.Label_Path.Size = New System.Drawing.Size(106, 21)
        Me.Label_Path.TabIndex = 2
        Me.Label_Path.Text = "词库文件路径"
        '
        'Label_FormTransitionTime
        '
        Me.Label_FormTransitionTime.AutoSize = True
        Me.Label_FormTransitionTime.Location = New System.Drawing.Point(8, 74)
        Me.Label_FormTransitionTime.Name = "Label_FormTransitionTime"
        Me.Label_FormTransitionTime.Size = New System.Drawing.Size(170, 21)
        Me.Label_FormTransitionTime.TabIndex = 4
        Me.Label_FormTransitionTime.Text = "窗口滑动时间（毫秒）"
        '
        'NumericUpDown_FormTransitionTime
        '
        Me.NumericUpDown_FormTransitionTime.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDown_FormTransitionTime.Location = New System.Drawing.Point(176, 71)
        Me.NumericUpDown_FormTransitionTime.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumericUpDown_FormTransitionTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FormTransitionTime.Name = "NumericUpDown_FormTransitionTime"
        Me.NumericUpDown_FormTransitionTime.Size = New System.Drawing.Size(128, 29)
        Me.NumericUpDown_FormTransitionTime.TabIndex = 5
        Me.NumericUpDown_FormTransitionTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_FormTransitionTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button_Apply
        '
        Me.Button_Apply.Location = New System.Drawing.Point(448, 360)
        Me.Button_Apply.Name = "Button_Apply"
        Me.Button_Apply.Size = New System.Drawing.Size(88, 32)
        Me.Button_Apply.TabIndex = 6
        Me.Button_Apply.Text = "确定"
        Me.Button_Apply.UseVisualStyleBackColor = True
        '
        'Button_Cancel
        '
        Me.Button_Cancel.Location = New System.Drawing.Point(544, 360)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(88, 32)
        Me.Button_Cancel.TabIndex = 7
        Me.Button_Cancel.Text = "取消"
        Me.Button_Cancel.UseVisualStyleBackColor = True
        '
        'NumericUpDown_FormWidthRatio
        '
        Me.NumericUpDown_FormWidthRatio.DecimalPlaces = 2
        Me.NumericUpDown_FormWidthRatio.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.NumericUpDown_FormWidthRatio.Location = New System.Drawing.Point(424, 71)
        Me.NumericUpDown_FormWidthRatio.Name = "NumericUpDown_FormWidthRatio"
        Me.NumericUpDown_FormWidthRatio.Size = New System.Drawing.Size(192, 29)
        Me.NumericUpDown_FormWidthRatio.TabIndex = 9
        Me.NumericUpDown_FormWidthRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown_FormWidthRatio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label_FormWidthRatio
        '
        Me.Label_FormWidthRatio.AutoSize = True
        Me.Label_FormWidthRatio.Location = New System.Drawing.Point(312, 74)
        Me.Label_FormWidthRatio.Name = "Label_FormWidthRatio"
        Me.Label_FormWidthRatio.Size = New System.Drawing.Size(106, 21)
        Me.Label_FormWidthRatio.TabIndex = 8
        Me.Label_FormWidthRatio.Text = "窗口宽度比例"
        '
        'GroupBox_Manual
        '
        Me.GroupBox_Manual.Controls.Add(Me.CheckBox_CopyToClipboard)
        Me.GroupBox_Manual.Controls.Add(Me.Button_Path)
        Me.GroupBox_Manual.Controls.Add(Me.NumericUpDown_FormTransitionTime)
        Me.GroupBox_Manual.Controls.Add(Me.Label_Path)
        Me.GroupBox_Manual.Controls.Add(Me.NumericUpDown_FormWidthRatio)
        Me.GroupBox_Manual.Controls.Add(Me.Label_FormWidthRatio)
        Me.GroupBox_Manual.Controls.Add(Me.TextBox_Path)
        Me.GroupBox_Manual.Controls.Add(Me.Label_FormTransitionTime)
        Me.GroupBox_Manual.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox_Manual.Name = "GroupBox_Manual"
        Me.GroupBox_Manual.Size = New System.Drawing.Size(624, 152)
        Me.GroupBox_Manual.TabIndex = 10
        Me.GroupBox_Manual.TabStop = False
        Me.GroupBox_Manual.Text = "常规"
        '
        'Button_Path
        '
        Me.Button_Path.Location = New System.Drawing.Point(560, 29)
        Me.Button_Path.Name = "Button_Path"
        Me.Button_Path.Size = New System.Drawing.Size(56, 29)
        Me.Button_Path.TabIndex = 2
        Me.Button_Path.Text = "浏览"
        Me.Button_Path.UseVisualStyleBackColor = True
        '
        'GroupBox_Skin
        '
        Me.GroupBox_Skin.Controls.Add(Me.Button_SkinTextSecondaryColor)
        Me.GroupBox_Skin.Controls.Add(Me.Button_SkinTextPrimaryColor)
        Me.GroupBox_Skin.Controls.Add(Me.Button_SkinBackgroundColor)
        Me.GroupBox_Skin.Controls.Add(Me.Label_SkinTextSecondaryColor)
        Me.GroupBox_Skin.Controls.Add(Me.Label_SkinTextPrimaryColor)
        Me.GroupBox_Skin.Controls.Add(Me.Label_SkinBackgroundColor)
        Me.GroupBox_Skin.Controls.Add(Me.Button_SkinPicture)
        Me.GroupBox_Skin.Controls.Add(Me.Label_SkinPicture)
        Me.GroupBox_Skin.Controls.Add(Me.TextBox_SkinPicture)
        Me.GroupBox_Skin.Location = New System.Drawing.Point(8, 208)
        Me.GroupBox_Skin.Name = "GroupBox_Skin"
        Me.GroupBox_Skin.Size = New System.Drawing.Size(624, 144)
        Me.GroupBox_Skin.TabIndex = 11
        Me.GroupBox_Skin.TabStop = False
        Me.GroupBox_Skin.Text = "自定义皮肤"
        '
        'Button_SkinTextSecondaryColor
        '
        Me.Button_SkinTextSecondaryColor.Location = New System.Drawing.Point(384, 104)
        Me.Button_SkinTextSecondaryColor.Name = "Button_SkinTextSecondaryColor"
        Me.Button_SkinTextSecondaryColor.Size = New System.Drawing.Size(232, 29)
        Me.Button_SkinTextSecondaryColor.TabIndex = 12
        Me.Button_SkinTextSecondaryColor.Text = "255, 255, 255"
        Me.Button_SkinTextSecondaryColor.UseVisualStyleBackColor = True
        '
        'Button_SkinTextPrimaryColor
        '
        Me.Button_SkinTextPrimaryColor.Location = New System.Drawing.Point(72, 104)
        Me.Button_SkinTextPrimaryColor.Name = "Button_SkinTextPrimaryColor"
        Me.Button_SkinTextPrimaryColor.Size = New System.Drawing.Size(232, 29)
        Me.Button_SkinTextPrimaryColor.TabIndex = 11
        Me.Button_SkinTextPrimaryColor.Text = "255, 255, 255"
        Me.Button_SkinTextPrimaryColor.UseVisualStyleBackColor = True
        '
        'Button_SkinBackgroundColor
        '
        Me.Button_SkinBackgroundColor.Location = New System.Drawing.Point(72, 69)
        Me.Button_SkinBackgroundColor.Name = "Button_SkinBackgroundColor"
        Me.Button_SkinBackgroundColor.Size = New System.Drawing.Size(232, 29)
        Me.Button_SkinBackgroundColor.TabIndex = 10
        Me.Button_SkinBackgroundColor.Text = "255, 255, 255"
        Me.Button_SkinBackgroundColor.UseVisualStyleBackColor = True
        '
        'Label_SkinTextSecondaryColor
        '
        Me.Label_SkinTextSecondaryColor.AutoSize = True
        Me.Label_SkinTextSecondaryColor.Location = New System.Drawing.Point(320, 107)
        Me.Label_SkinTextSecondaryColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_SkinTextSecondaryColor.Name = "Label_SkinTextSecondaryColor"
        Me.Label_SkinTextSecondaryColor.Size = New System.Drawing.Size(58, 21)
        Me.Label_SkinTextSecondaryColor.TabIndex = 9
        Me.Label_SkinTextSecondaryColor.Text = "副色调"
        '
        'Label_SkinTextPrimaryColor
        '
        Me.Label_SkinTextPrimaryColor.AutoSize = True
        Me.Label_SkinTextPrimaryColor.Location = New System.Drawing.Point(8, 107)
        Me.Label_SkinTextPrimaryColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_SkinTextPrimaryColor.Name = "Label_SkinTextPrimaryColor"
        Me.Label_SkinTextPrimaryColor.Size = New System.Drawing.Size(58, 21)
        Me.Label_SkinTextPrimaryColor.TabIndex = 8
        Me.Label_SkinTextPrimaryColor.Text = "主色调"
        '
        'Label_SkinBackgroundColor
        '
        Me.Label_SkinBackgroundColor.AutoSize = True
        Me.Label_SkinBackgroundColor.Location = New System.Drawing.Point(8, 72)
        Me.Label_SkinBackgroundColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_SkinBackgroundColor.Name = "Label_SkinBackgroundColor"
        Me.Label_SkinBackgroundColor.Size = New System.Drawing.Size(58, 21)
        Me.Label_SkinBackgroundColor.TabIndex = 7
        Me.Label_SkinBackgroundColor.Text = "背景色"
        '
        'Button_SkinPicture
        '
        Me.Button_SkinPicture.Location = New System.Drawing.Point(560, 29)
        Me.Button_SkinPicture.Name = "Button_SkinPicture"
        Me.Button_SkinPicture.Size = New System.Drawing.Size(56, 29)
        Me.Button_SkinPicture.TabIndex = 6
        Me.Button_SkinPicture.Text = "浏览"
        Me.Button_SkinPicture.UseVisualStyleBackColor = True
        '
        'Label_SkinPicture
        '
        Me.Label_SkinPicture.AutoSize = True
        Me.Label_SkinPicture.Location = New System.Drawing.Point(8, 32)
        Me.Label_SkinPicture.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_SkinPicture.Name = "Label_SkinPicture"
        Me.Label_SkinPicture.Size = New System.Drawing.Size(74, 21)
        Me.Label_SkinPicture.TabIndex = 5
        Me.Label_SkinPicture.Text = "皮肤图片"
        '
        'TextBox_SkinPicture
        '
        Me.TextBox_SkinPicture.Location = New System.Drawing.Point(88, 29)
        Me.TextBox_SkinPicture.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_SkinPicture.Name = "TextBox_SkinPicture"
        Me.TextBox_SkinPicture.ReadOnly = True
        Me.TextBox_SkinPicture.Size = New System.Drawing.Size(464, 29)
        Me.TextBox_SkinPicture.TabIndex = 4
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        '
        'CheckBox_CopyToClipboard
        '
        Me.CheckBox_CopyToClipboard.AutoSize = True
        Me.CheckBox_CopyToClipboard.Location = New System.Drawing.Point(13, 112)
        Me.CheckBox_CopyToClipboard.Name = "CheckBox_CopyToClipboard"
        Me.CheckBox_CopyToClipboard.Size = New System.Drawing.Size(173, 25)
        Me.CheckBox_CopyToClipboard.TabIndex = 10
        Me.CheckBox_CopyToClipboard.Text = "输入后复制到剪贴板"
        Me.CheckBox_CopyToClipboard.UseVisualStyleBackColor = True
        '
        'Form_Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(640, 400)
        Me.Controls.Add(Me.GroupBox_Skin)
        Me.Controls.Add(Me.GroupBox_Manual)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Apply)
        Me.Controls.Add(Me.Label_Config)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Form_Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设置"
        CType(Me.NumericUpDown_FormTransitionTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_FormWidthRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Manual.ResumeLayout(False)
        Me.GroupBox_Manual.PerformLayout()
        Me.GroupBox_Skin.ResumeLayout(False)
        Me.GroupBox_Skin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Config As Label
    Friend WithEvents TextBox_Path As TextBox
    Friend WithEvents Label_Path As Label
    Friend WithEvents Label_FormTransitionTime As Label
    Friend WithEvents NumericUpDown_FormTransitionTime As NumericUpDown
    Friend WithEvents Button_Apply As Button
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents NumericUpDown_FormWidthRatio As NumericUpDown
    Friend WithEvents Label_FormWidthRatio As Label
    Friend WithEvents GroupBox_Manual As GroupBox
    Friend WithEvents GroupBox_Skin As GroupBox
    Friend WithEvents Button_SkinPicture As Button
    Friend WithEvents Label_SkinPicture As Label
    Friend WithEvents TextBox_SkinPicture As TextBox
    Friend WithEvents Label_SkinBackgroundColor As Label
    Friend WithEvents Label_SkinTextPrimaryColor As Label
    Friend WithEvents Button_SkinTextSecondaryColor As Button
    Friend WithEvents Button_SkinTextPrimaryColor As Button
    Friend WithEvents Button_SkinBackgroundColor As Button
    Friend WithEvents Label_SkinTextSecondaryColor As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button_Path As Button
    Friend WithEvents CheckBox_CopyToClipboard As CheckBox
End Class
