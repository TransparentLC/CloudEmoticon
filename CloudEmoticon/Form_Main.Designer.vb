<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Main))
        Me.NotifyIcon_Main = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip_Main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowForm_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Load_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadFromFile_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadOnline_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConvertFromText_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Editor_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSkin_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Skin_Material_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Skin_Scorpio_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Skin_Catwalk_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Skin_Akari_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Skin_Sagiri_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Skin_KotoHonoUmi_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Skin_Custom_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenConfigFolder_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Config_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.About_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exit_ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel_Display = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_Display_0 = New System.Windows.Forms.Label()
        Me.Label_Display_3 = New System.Windows.Forms.Label()
        Me.Label_Display_4 = New System.Windows.Forms.Label()
        Me.Label_Display_5 = New System.Windows.Forms.Label()
        Me.Label_Display_6 = New System.Windows.Forms.Label()
        Me.Label_Display_7 = New System.Windows.Forms.Label()
        Me.Label_Display_8 = New System.Windows.Forms.Label()
        Me.Label_Display_9 = New System.Windows.Forms.Label()
        Me.Label_Key_1 = New System.Windows.Forms.Label()
        Me.Label_Key_2 = New System.Windows.Forms.Label()
        Me.Label_Key_3 = New System.Windows.Forms.Label()
        Me.Label_Key_4 = New System.Windows.Forms.Label()
        Me.Label_Key_5 = New System.Windows.Forms.Label()
        Me.Label_Key_6 = New System.Windows.Forms.Label()
        Me.Label_Key_7 = New System.Windows.Forms.Label()
        Me.Label_Key_8 = New System.Windows.Forms.Label()
        Me.Label_Key_9 = New System.Windows.Forms.Label()
        Me.Label_Key_0 = New System.Windows.Forms.Label()
        Me.Label_Display_1 = New System.Windows.Forms.Label()
        Me.Label_Display_2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel_Page = New System.Windows.Forms.TableLayoutPanel()
        Me.Label_FileName = New System.Windows.Forms.Label()
        Me.Label_Page = New System.Windows.Forms.Label()
        Me.PictureBox_Background = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip_Main.SuspendLayout()
        Me.TableLayoutPanel_Display.SuspendLayout()
        Me.TableLayoutPanel_Page.SuspendLayout()
        CType(Me.PictureBox_Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon_Main
        '
        Me.NotifyIcon_Main.BalloonTipText = "按Ctrl+Shift+E弹出窗口～"
        Me.NotifyIcon_Main.BalloonTipTitle = "CloudEmoticon"
        Me.NotifyIcon_Main.ContextMenuStrip = Me.ContextMenuStrip_Main
        Me.NotifyIcon_Main.Icon = CType(resources.GetObject("NotifyIcon_Main.Icon"), System.Drawing.Icon)
        Me.NotifyIcon_Main.Text = "CloudEmoticon"
        Me.NotifyIcon_Main.Visible = True
        '
        'ContextMenuStrip_Main
        '
        Me.ContextMenuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowForm_ToolStripMenuItem, Me.Load_ToolStripMenuItem, Me.ChangeSkin_ToolStripMenuItem, Me.ToolStripSeparator1, Me.OpenConfigFolder_ToolStripMenuItem, Me.Config_ToolStripMenuItem, Me.ToolStripSeparator3, Me.About_ToolStripMenuItem, Me.Exit_ToolStripMenuItem})
        Me.ContextMenuStrip_Main.Name = "ContextMenuStrip_Main"
        Me.ContextMenuStrip_Main.Size = New System.Drawing.Size(161, 170)
        '
        'ShowForm_ToolStripMenuItem
        '
        Me.ShowForm_ToolStripMenuItem.Name = "ShowForm_ToolStripMenuItem"
        Me.ShowForm_ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ShowForm_ToolStripMenuItem.Text = "显示窗口"
        '
        'Load_ToolStripMenuItem
        '
        Me.Load_ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadFromFile_ToolStripMenuItem, Me.LoadOnline_ToolStripMenuItem, Me.ToolStripSeparator2, Me.ConvertFromText_ToolStripMenuItem, Me.Editor_ToolStripMenuItem})
        Me.Load_ToolStripMenuItem.Name = "Load_ToolStripMenuItem"
        Me.Load_ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.Load_ToolStripMenuItem.Text = "载入词库文件"
        '
        'LoadFromFile_ToolStripMenuItem
        '
        Me.LoadFromFile_ToolStripMenuItem.Name = "LoadFromFile_ToolStripMenuItem"
        Me.LoadFromFile_ToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.LoadFromFile_ToolStripMenuItem.Text = "选择本地文件"
        '
        'LoadOnline_ToolStripMenuItem
        '
        Me.LoadOnline_ToolStripMenuItem.Name = "LoadOnline_ToolStripMenuItem"
        Me.LoadOnline_ToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.LoadOnline_ToolStripMenuItem.Text = "手动输入路径 / 链接"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'ConvertFromText_ToolStripMenuItem
        '
        Me.ConvertFromText_ToolStripMenuItem.Name = "ConvertFromText_ToolStripMenuItem"
        Me.ConvertFromText_ToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ConvertFromText_ToolStripMenuItem.Text = "从文本文档 (*.txt) 转换"
        '
        'Editor_ToolStripMenuItem
        '
        Me.Editor_ToolStripMenuItem.Name = "Editor_ToolStripMenuItem"
        Me.Editor_ToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.Editor_ToolStripMenuItem.Text = "词库编辑器"
        '
        'ChangeSkin_ToolStripMenuItem
        '
        Me.ChangeSkin_ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Skin_Material_ToolStripMenuItem, Me.Skin_Scorpio_ToolStripMenuItem, Me.Skin_Catwalk_ToolStripMenuItem, Me.Skin_Akari_ToolStripMenuItem, Me.Skin_Sagiri_ToolStripMenuItem, Me.Skin_KotoHonoUmi_ToolStripMenuItem, Me.ToolStripSeparator4, Me.Skin_Custom_ToolStripMenuItem})
        Me.ChangeSkin_ToolStripMenuItem.Name = "ChangeSkin_ToolStripMenuItem"
        Me.ChangeSkin_ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ChangeSkin_ToolStripMenuItem.Text = "更改皮肤"
        '
        'Skin_Material_ToolStripMenuItem
        '
        Me.Skin_Material_ToolStripMenuItem.Name = "Skin_Material_ToolStripMenuItem"
        Me.Skin_Material_ToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.Skin_Material_ToolStripMenuItem.Text = "Material"
        '
        'Skin_Scorpio_ToolStripMenuItem
        '
        Me.Skin_Scorpio_ToolStripMenuItem.Name = "Skin_Scorpio_ToolStripMenuItem"
        Me.Skin_Scorpio_ToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.Skin_Scorpio_ToolStripMenuItem.Text = "Scorpio"
        '
        'Skin_Catwalk_ToolStripMenuItem
        '
        Me.Skin_Catwalk_ToolStripMenuItem.Name = "Skin_Catwalk_ToolStripMenuItem"
        Me.Skin_Catwalk_ToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.Skin_Catwalk_ToolStripMenuItem.Text = "Catwalk"
        '
        'Skin_Akari_ToolStripMenuItem
        '
        Me.Skin_Akari_ToolStripMenuItem.Name = "Skin_Akari_ToolStripMenuItem"
        Me.Skin_Akari_ToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.Skin_Akari_ToolStripMenuItem.Text = "Akari"
        '
        'Skin_Sagiri_ToolStripMenuItem
        '
        Me.Skin_Sagiri_ToolStripMenuItem.Name = "Skin_Sagiri_ToolStripMenuItem"
        Me.Skin_Sagiri_ToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.Skin_Sagiri_ToolStripMenuItem.Text = "Sagiri"
        '
        'Skin_KotoHonoUmi_ToolStripMenuItem
        '
        Me.Skin_KotoHonoUmi_ToolStripMenuItem.Name = "Skin_KotoHonoUmi_ToolStripMenuItem"
        Me.Skin_KotoHonoUmi_ToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.Skin_KotoHonoUmi_ToolStripMenuItem.Text = "KotoHonoUmi"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(156, 6)
        '
        'Skin_Custom_ToolStripMenuItem
        '
        Me.Skin_Custom_ToolStripMenuItem.Name = "Skin_Custom_ToolStripMenuItem"
        Me.Skin_Custom_ToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.Skin_Custom_ToolStripMenuItem.Text = "自定义的皮肤"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'OpenConfigFolder_ToolStripMenuItem
        '
        Me.OpenConfigFolder_ToolStripMenuItem.Name = "OpenConfigFolder_ToolStripMenuItem"
        Me.OpenConfigFolder_ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.OpenConfigFolder_ToolStripMenuItem.Text = "打开配置文件夹"
        '
        'Config_ToolStripMenuItem
        '
        Me.Config_ToolStripMenuItem.Name = "Config_ToolStripMenuItem"
        Me.Config_ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.Config_ToolStripMenuItem.Text = "设置"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(157, 6)
        '
        'About_ToolStripMenuItem
        '
        Me.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem"
        Me.About_ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.About_ToolStripMenuItem.Text = "关于"
        '
        'Exit_ToolStripMenuItem
        '
        Me.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem"
        Me.Exit_ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.Exit_ToolStripMenuItem.Text = "退出"
        '
        'TableLayoutPanel_Display
        '
        Me.TableLayoutPanel_Display.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel_Display.ColumnCount = 2
        Me.TableLayoutPanel_Display.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel_Display.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Display_0, 0, 9)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Display_3, 0, 2)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Display_4, 0, 3)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Display_5, 0, 4)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Display_6, 0, 5)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Display_7, 0, 6)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Display_8, 0, 7)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Display_9, 0, 8)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Key_1, 1, 0)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Key_2, 1, 1)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Key_3, 1, 2)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Key_4, 1, 3)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Key_5, 1, 4)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Key_6, 1, 5)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Key_7, 1, 6)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Key_8, 1, 7)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Key_9, 1, 8)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Key_0, 1, 9)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Display_1, 0, 0)
        Me.TableLayoutPanel_Display.Controls.Add(Me.Label_Display_2, 0, 1)
        Me.TableLayoutPanel_Display.Location = New System.Drawing.Point(0, 88)
        Me.TableLayoutPanel_Display.Name = "TableLayoutPanel_Display"
        Me.TableLayoutPanel_Display.RowCount = 10
        Me.TableLayoutPanel_Display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel_Display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel_Display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel_Display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel_Display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel_Display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel_Display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel_Display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel_Display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel_Display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel_Display.Size = New System.Drawing.Size(384, 424)
        Me.TableLayoutPanel_Display.TabIndex = 3
        '
        'Label_Display_0
        '
        Me.Label_Display_0.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Display_0.AutoSize = True
        Me.Label_Display_0.BackColor = System.Drawing.Color.Transparent
        Me.Label_Display_0.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Display_0.Location = New System.Drawing.Point(3, 385)
        Me.Label_Display_0.Name = "Label_Display_0"
        Me.Label_Display_0.Size = New System.Drawing.Size(301, 31)
        Me.Label_Display_0.TabIndex = 10
        Me.Label_Display_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Display_3
        '
        Me.Label_Display_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Display_3.AutoSize = True
        Me.Label_Display_3.BackColor = System.Drawing.Color.Transparent
        Me.Label_Display_3.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Display_3.Location = New System.Drawing.Point(3, 89)
        Me.Label_Display_3.Name = "Label_Display_3"
        Me.Label_Display_3.Size = New System.Drawing.Size(301, 31)
        Me.Label_Display_3.TabIndex = 2
        Me.Label_Display_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Display_4
        '
        Me.Label_Display_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Display_4.AutoSize = True
        Me.Label_Display_4.BackColor = System.Drawing.Color.Transparent
        Me.Label_Display_4.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Display_4.Location = New System.Drawing.Point(3, 131)
        Me.Label_Display_4.Name = "Label_Display_4"
        Me.Label_Display_4.Size = New System.Drawing.Size(301, 31)
        Me.Label_Display_4.TabIndex = 3
        Me.Label_Display_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Display_5
        '
        Me.Label_Display_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Display_5.AutoSize = True
        Me.Label_Display_5.BackColor = System.Drawing.Color.Transparent
        Me.Label_Display_5.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Display_5.Location = New System.Drawing.Point(3, 173)
        Me.Label_Display_5.Name = "Label_Display_5"
        Me.Label_Display_5.Size = New System.Drawing.Size(301, 31)
        Me.Label_Display_5.TabIndex = 4
        Me.Label_Display_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Display_6
        '
        Me.Label_Display_6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Display_6.AutoSize = True
        Me.Label_Display_6.BackColor = System.Drawing.Color.Transparent
        Me.Label_Display_6.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Display_6.Location = New System.Drawing.Point(3, 215)
        Me.Label_Display_6.Name = "Label_Display_6"
        Me.Label_Display_6.Size = New System.Drawing.Size(301, 31)
        Me.Label_Display_6.TabIndex = 5
        Me.Label_Display_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Display_7
        '
        Me.Label_Display_7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Display_7.AutoSize = True
        Me.Label_Display_7.BackColor = System.Drawing.Color.Transparent
        Me.Label_Display_7.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Display_7.Location = New System.Drawing.Point(3, 257)
        Me.Label_Display_7.Name = "Label_Display_7"
        Me.Label_Display_7.Size = New System.Drawing.Size(301, 31)
        Me.Label_Display_7.TabIndex = 6
        Me.Label_Display_7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Display_8
        '
        Me.Label_Display_8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Display_8.AutoSize = True
        Me.Label_Display_8.BackColor = System.Drawing.Color.Transparent
        Me.Label_Display_8.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Display_8.Location = New System.Drawing.Point(3, 299)
        Me.Label_Display_8.Name = "Label_Display_8"
        Me.Label_Display_8.Size = New System.Drawing.Size(301, 31)
        Me.Label_Display_8.TabIndex = 7
        Me.Label_Display_8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Display_9
        '
        Me.Label_Display_9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Display_9.AutoSize = True
        Me.Label_Display_9.BackColor = System.Drawing.Color.Transparent
        Me.Label_Display_9.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Display_9.Location = New System.Drawing.Point(3, 341)
        Me.Label_Display_9.Name = "Label_Display_9"
        Me.Label_Display_9.Size = New System.Drawing.Size(301, 31)
        Me.Label_Display_9.TabIndex = 8
        Me.Label_Display_9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Key_1
        '
        Me.Label_Key_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Key_1.AutoSize = True
        Me.Label_Key_1.BackColor = System.Drawing.Color.Transparent
        Me.Label_Key_1.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Key_1.ForeColor = System.Drawing.Color.Silver
        Me.Label_Key_1.Location = New System.Drawing.Point(310, 7)
        Me.Label_Key_1.Name = "Label_Key_1"
        Me.Label_Key_1.Size = New System.Drawing.Size(71, 28)
        Me.Label_Key_1.TabIndex = 9
        Me.Label_Key_1.Text = "1"
        Me.Label_Key_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Key_2
        '
        Me.Label_Key_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Key_2.AutoSize = True
        Me.Label_Key_2.BackColor = System.Drawing.Color.Transparent
        Me.Label_Key_2.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Key_2.ForeColor = System.Drawing.Color.Silver
        Me.Label_Key_2.Location = New System.Drawing.Point(310, 49)
        Me.Label_Key_2.Name = "Label_Key_2"
        Me.Label_Key_2.Size = New System.Drawing.Size(71, 28)
        Me.Label_Key_2.TabIndex = 9
        Me.Label_Key_2.Text = "2"
        Me.Label_Key_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Key_3
        '
        Me.Label_Key_3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Key_3.AutoSize = True
        Me.Label_Key_3.BackColor = System.Drawing.Color.Transparent
        Me.Label_Key_3.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Key_3.ForeColor = System.Drawing.Color.Silver
        Me.Label_Key_3.Location = New System.Drawing.Point(310, 91)
        Me.Label_Key_3.Name = "Label_Key_3"
        Me.Label_Key_3.Size = New System.Drawing.Size(71, 28)
        Me.Label_Key_3.TabIndex = 9
        Me.Label_Key_3.Text = "3"
        Me.Label_Key_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Key_4
        '
        Me.Label_Key_4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Key_4.AutoSize = True
        Me.Label_Key_4.BackColor = System.Drawing.Color.Transparent
        Me.Label_Key_4.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Key_4.ForeColor = System.Drawing.Color.Silver
        Me.Label_Key_4.Location = New System.Drawing.Point(310, 133)
        Me.Label_Key_4.Name = "Label_Key_4"
        Me.Label_Key_4.Size = New System.Drawing.Size(71, 28)
        Me.Label_Key_4.TabIndex = 9
        Me.Label_Key_4.Text = "4"
        Me.Label_Key_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Key_5
        '
        Me.Label_Key_5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Key_5.AutoSize = True
        Me.Label_Key_5.BackColor = System.Drawing.Color.Transparent
        Me.Label_Key_5.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Key_5.ForeColor = System.Drawing.Color.Silver
        Me.Label_Key_5.Location = New System.Drawing.Point(310, 175)
        Me.Label_Key_5.Name = "Label_Key_5"
        Me.Label_Key_5.Size = New System.Drawing.Size(71, 28)
        Me.Label_Key_5.TabIndex = 9
        Me.Label_Key_5.Text = "5"
        Me.Label_Key_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Key_6
        '
        Me.Label_Key_6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Key_6.AutoSize = True
        Me.Label_Key_6.BackColor = System.Drawing.Color.Transparent
        Me.Label_Key_6.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Key_6.ForeColor = System.Drawing.Color.Silver
        Me.Label_Key_6.Location = New System.Drawing.Point(310, 217)
        Me.Label_Key_6.Name = "Label_Key_6"
        Me.Label_Key_6.Size = New System.Drawing.Size(71, 28)
        Me.Label_Key_6.TabIndex = 9
        Me.Label_Key_6.Text = "6"
        Me.Label_Key_6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Key_7
        '
        Me.Label_Key_7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Key_7.AutoSize = True
        Me.Label_Key_7.BackColor = System.Drawing.Color.Transparent
        Me.Label_Key_7.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Key_7.ForeColor = System.Drawing.Color.Silver
        Me.Label_Key_7.Location = New System.Drawing.Point(310, 259)
        Me.Label_Key_7.Name = "Label_Key_7"
        Me.Label_Key_7.Size = New System.Drawing.Size(71, 28)
        Me.Label_Key_7.TabIndex = 9
        Me.Label_Key_7.Text = "7"
        Me.Label_Key_7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Key_8
        '
        Me.Label_Key_8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Key_8.AutoSize = True
        Me.Label_Key_8.BackColor = System.Drawing.Color.Transparent
        Me.Label_Key_8.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Key_8.ForeColor = System.Drawing.Color.Silver
        Me.Label_Key_8.Location = New System.Drawing.Point(310, 301)
        Me.Label_Key_8.Name = "Label_Key_8"
        Me.Label_Key_8.Size = New System.Drawing.Size(71, 28)
        Me.Label_Key_8.TabIndex = 9
        Me.Label_Key_8.Text = "8"
        Me.Label_Key_8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Key_9
        '
        Me.Label_Key_9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Key_9.AutoSize = True
        Me.Label_Key_9.BackColor = System.Drawing.Color.Transparent
        Me.Label_Key_9.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Key_9.ForeColor = System.Drawing.Color.Silver
        Me.Label_Key_9.Location = New System.Drawing.Point(310, 343)
        Me.Label_Key_9.Name = "Label_Key_9"
        Me.Label_Key_9.Size = New System.Drawing.Size(71, 28)
        Me.Label_Key_9.TabIndex = 9
        Me.Label_Key_9.Text = "9"
        Me.Label_Key_9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Key_0
        '
        Me.Label_Key_0.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Key_0.AutoSize = True
        Me.Label_Key_0.BackColor = System.Drawing.Color.Transparent
        Me.Label_Key_0.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Key_0.ForeColor = System.Drawing.Color.Silver
        Me.Label_Key_0.Location = New System.Drawing.Point(310, 387)
        Me.Label_Key_0.Name = "Label_Key_0"
        Me.Label_Key_0.Size = New System.Drawing.Size(71, 28)
        Me.Label_Key_0.TabIndex = 9
        Me.Label_Key_0.Text = "0"
        Me.Label_Key_0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Display_1
        '
        Me.Label_Display_1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Display_1.AutoSize = True
        Me.Label_Display_1.BackColor = System.Drawing.Color.Transparent
        Me.Label_Display_1.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Display_1.Location = New System.Drawing.Point(3, 5)
        Me.Label_Display_1.Name = "Label_Display_1"
        Me.Label_Display_1.Size = New System.Drawing.Size(301, 31)
        Me.Label_Display_1.TabIndex = 0
        Me.Label_Display_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Display_2
        '
        Me.Label_Display_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Display_2.AutoSize = True
        Me.Label_Display_2.BackColor = System.Drawing.Color.Transparent
        Me.Label_Display_2.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Display_2.Location = New System.Drawing.Point(3, 47)
        Me.Label_Display_2.Name = "Label_Display_2"
        Me.Label_Display_2.Size = New System.Drawing.Size(301, 31)
        Me.Label_Display_2.TabIndex = 1
        Me.Label_Display_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel_Page
        '
        Me.TableLayoutPanel_Page.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel_Page.ColumnCount = 1
        Me.TableLayoutPanel_Page.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_Page.Controls.Add(Me.Label_FileName, 0, 0)
        Me.TableLayoutPanel_Page.Controls.Add(Me.Label_Page, 0, 1)
        Me.TableLayoutPanel_Page.Location = New System.Drawing.Point(0, 520)
        Me.TableLayoutPanel_Page.Name = "TableLayoutPanel_Page"
        Me.TableLayoutPanel_Page.RowCount = 2
        Me.TableLayoutPanel_Page.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_Page.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_Page.Size = New System.Drawing.Size(384, 72)
        Me.TableLayoutPanel_Page.TabIndex = 4
        '
        'Label_FileName
        '
        Me.Label_FileName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_FileName.AutoSize = True
        Me.Label_FileName.BackColor = System.Drawing.Color.Transparent
        Me.Label_FileName.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_FileName.ForeColor = System.Drawing.Color.Silver
        Me.Label_FileName.Location = New System.Drawing.Point(3, 4)
        Me.Label_FileName.Name = "Label_FileName"
        Me.Label_FileName.Size = New System.Drawing.Size(378, 28)
        Me.Label_FileName.TabIndex = 0
        Me.Label_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Page
        '
        Me.Label_Page.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Page.AutoSize = True
        Me.Label_Page.BackColor = System.Drawing.Color.Transparent
        Me.Label_Page.Font = New System.Drawing.Font("微软雅黑 Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_Page.ForeColor = System.Drawing.Color.Silver
        Me.Label_Page.Location = New System.Drawing.Point(3, 40)
        Me.Label_Page.Name = "Label_Page"
        Me.Label_Page.Size = New System.Drawing.Size(378, 28)
        Me.Label_Page.TabIndex = 0
        Me.Label_Page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox_Background
        '
        Me.PictureBox_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox_Background.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox_Background.Name = "PictureBox_Background"
        Me.PictureBox_Background.Size = New System.Drawing.Size(384, 80)
        Me.PictureBox_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_Background.TabIndex = 5
        Me.PictureBox_Background.TabStop = False
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(383, 735)
        Me.Controls.Add(Me.PictureBox_Background)
        Me.Controls.Add(Me.TableLayoutPanel_Page)
        Me.Controls.Add(Me.TableLayoutPanel_Display)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("微软雅黑", 16.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Main"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.ContextMenuStrip_Main.ResumeLayout(False)
        Me.TableLayoutPanel_Display.ResumeLayout(False)
        Me.TableLayoutPanel_Display.PerformLayout()
        Me.TableLayoutPanel_Page.ResumeLayout(False)
        Me.TableLayoutPanel_Page.PerformLayout()
        CType(Me.PictureBox_Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon_Main As NotifyIcon
    Friend WithEvents TableLayoutPanel_Display As TableLayoutPanel
    Friend WithEvents Label_Display_1 As Label
    Friend WithEvents Label_Key_1 As Label
    Friend WithEvents Label_Display_2 As Label
    Friend WithEvents Label_Display_3 As Label
    Friend WithEvents Label_Display_4 As Label
    Friend WithEvents Label_Display_5 As Label
    Friend WithEvents Label_Display_6 As Label
    Friend WithEvents Label_Display_7 As Label
    Friend WithEvents Label_Display_8 As Label
    Friend WithEvents Label_Display_9 As Label
    Friend WithEvents Label_Display_0 As Label
    Friend WithEvents Label_Key_2 As Label
    Friend WithEvents Label_Key_3 As Label
    Friend WithEvents Label_Key_4 As Label
    Friend WithEvents Label_Key_5 As Label
    Friend WithEvents Label_Key_6 As Label
    Friend WithEvents Label_Key_7 As Label
    Friend WithEvents Label_Key_8 As Label
    Friend WithEvents Label_Key_9 As Label
    Friend WithEvents Label_Key_0 As Label
    Friend WithEvents TableLayoutPanel_Page As TableLayoutPanel
    Friend WithEvents Label_FileName As Label
    Friend WithEvents Label_Page As Label
    Friend WithEvents ContextMenuStrip_Main As ContextMenuStrip
    Friend WithEvents ShowForm_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Exit_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Load_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox_Background As PictureBox
    Friend WithEvents ChangeSkin_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Skin_Akari_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Skin_Material_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Skin_Scorpio_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Skin_Catwalk_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Skin_KotoHonoUmi_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Skin_Sagiri_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents About_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadFromFile_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadOnline_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ConvertFromText_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenConfigFolder_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Config_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Skin_Custom_ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Editor_ToolStripMenuItem As ToolStripMenuItem
End Class
