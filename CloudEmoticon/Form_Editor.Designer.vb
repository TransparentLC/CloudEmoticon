<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Editor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Editor))
        Me.Label_Editor = New System.Windows.Forms.Label()
        Me.ListBox_Category = New System.Windows.Forms.ListBox()
        Me.Label_Category = New System.Windows.Forms.Label()
        Me.GroupBox_Editor = New System.Windows.Forms.GroupBox()
        Me.Label_Information = New System.Windows.Forms.Label()
        Me.Label_Alias = New System.Windows.Forms.Label()
        Me.Button_Information = New System.Windows.Forms.Button()
        Me.Button_Alias = New System.Windows.Forms.Button()
        Me.Label_Description = New System.Windows.Forms.Label()
        Me.TextBox_Description = New System.Windows.Forms.TextBox()
        Me.Label_Emoticon = New System.Windows.Forms.Label()
        Me.TextBox_Emoticon = New System.Windows.Forms.TextBox()
        Me.Button_Entry_Delete = New System.Windows.Forms.Button()
        Me.Button_Entry_Add = New System.Windows.Forms.Button()
        Me.Button_Entry_Down = New System.Windows.Forms.Button()
        Me.Button_Entry_Up = New System.Windows.Forms.Button()
        Me.ListBox_Entry = New System.Windows.Forms.ListBox()
        Me.Label_Entry = New System.Windows.Forms.Label()
        Me.Button_Category_Delete = New System.Windows.Forms.Button()
        Me.Button_Category_Add = New System.Windows.Forms.Button()
        Me.Button_Category_Down = New System.Windows.Forms.Button()
        Me.Button_Category_Up = New System.Windows.Forms.Button()
        Me.Button_New = New System.Windows.Forms.Button()
        Me.Button_Load = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Quit = New System.Windows.Forms.Button()
        Me.Button_SaveEntry = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox_Editor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Editor
        '
        Me.Label_Editor.Font = New System.Drawing.Font("微软雅黑", 18.0!)
        Me.Label_Editor.Location = New System.Drawing.Point(8, 8)
        Me.Label_Editor.Name = "Label_Editor"
        Me.Label_Editor.Size = New System.Drawing.Size(784, 31)
        Me.Label_Editor.TabIndex = 0
        Me.Label_Editor.Text = "词库编辑器"
        '
        'ListBox_Category
        '
        Me.ListBox_Category.FormattingEnabled = True
        Me.ListBox_Category.HorizontalScrollbar = True
        Me.ListBox_Category.ItemHeight = 21
        Me.ListBox_Category.Items.AddRange(New Object() {"000", "111", "222", "333", "444", "555", "666", "777", "888", "999", "aaa", "bbb", "ccc", "ddd", "eee", "fff"})
        Me.ListBox_Category.Location = New System.Drawing.Point(8, 48)
        Me.ListBox_Category.Name = "ListBox_Category"
        Me.ListBox_Category.Size = New System.Drawing.Size(144, 382)
        Me.ListBox_Category.TabIndex = 4
        '
        'Label_Category
        '
        Me.Label_Category.AutoSize = True
        Me.Label_Category.Location = New System.Drawing.Point(8, 24)
        Me.Label_Category.Name = "Label_Category"
        Me.Label_Category.Size = New System.Drawing.Size(42, 21)
        Me.Label_Category.TabIndex = 2
        Me.Label_Category.Text = "分组"
        '
        'GroupBox_Editor
        '
        Me.GroupBox_Editor.Controls.Add(Me.Button_SaveEntry)
        Me.GroupBox_Editor.Controls.Add(Me.Label_Information)
        Me.GroupBox_Editor.Controls.Add(Me.Label_Alias)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Information)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Alias)
        Me.GroupBox_Editor.Controls.Add(Me.Label_Description)
        Me.GroupBox_Editor.Controls.Add(Me.TextBox_Description)
        Me.GroupBox_Editor.Controls.Add(Me.Label_Emoticon)
        Me.GroupBox_Editor.Controls.Add(Me.TextBox_Emoticon)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Entry_Delete)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Entry_Add)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Entry_Down)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Entry_Up)
        Me.GroupBox_Editor.Controls.Add(Me.ListBox_Entry)
        Me.GroupBox_Editor.Controls.Add(Me.Label_Entry)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Category_Delete)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Category_Add)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Category_Down)
        Me.GroupBox_Editor.Controls.Add(Me.Button_Category_Up)
        Me.GroupBox_Editor.Controls.Add(Me.ListBox_Category)
        Me.GroupBox_Editor.Controls.Add(Me.Label_Category)
        Me.GroupBox_Editor.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox_Editor.Name = "GroupBox_Editor"
        Me.GroupBox_Editor.Size = New System.Drawing.Size(784, 504)
        Me.GroupBox_Editor.TabIndex = 3
        Me.GroupBox_Editor.TabStop = False
        '
        'Label_Information
        '
        Me.Label_Information.Location = New System.Drawing.Point(312, 464)
        Me.Label_Information.Name = "Label_Information"
        Me.Label_Information.Size = New System.Drawing.Size(392, 32)
        Me.Label_Information.TabIndex = 25
        Me.Label_Information.Text = "词库说明：\ｱｯｶﾘ～ﾝ/"
        Me.Label_Information.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Alias
        '
        Me.Label_Alias.Location = New System.Drawing.Point(312, 432)
        Me.Label_Alias.Name = "Label_Alias"
        Me.Label_Alias.Size = New System.Drawing.Size(392, 32)
        Me.Label_Alias.TabIndex = 24
        Me.Label_Alias.Text = "词库名称：\ｱｯｶﾘ～ﾝ/"
        Me.Label_Alias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button_Information
        '
        Me.Button_Information.Location = New System.Drawing.Point(704, 464)
        Me.Button_Information.Name = "Button_Information"
        Me.Button_Information.Size = New System.Drawing.Size(72, 32)
        Me.Button_Information.TabIndex = 18
        Me.Button_Information.Text = "修改"
        Me.Button_Information.UseVisualStyleBackColor = True
        '
        'Button_Alias
        '
        Me.Button_Alias.Location = New System.Drawing.Point(704, 432)
        Me.Button_Alias.Name = "Button_Alias"
        Me.Button_Alias.Size = New System.Drawing.Size(72, 32)
        Me.Button_Alias.TabIndex = 17
        Me.Button_Alias.Text = "修改"
        Me.Button_Alias.UseVisualStyleBackColor = True
        '
        'Label_Description
        '
        Me.Label_Description.AutoSize = True
        Me.Label_Description.Location = New System.Drawing.Point(312, 272)
        Me.Label_Description.Name = "Label_Description"
        Me.Label_Description.Size = New System.Drawing.Size(42, 21)
        Me.Label_Description.TabIndex = 22
        Me.Label_Description.Text = "注释"
        '
        'TextBox_Description
        '
        Me.TextBox_Description.Location = New System.Drawing.Point(312, 296)
        Me.TextBox_Description.Multiline = True
        Me.TextBox_Description.Name = "TextBox_Description"
        Me.TextBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Description.Size = New System.Drawing.Size(464, 102)
        Me.TextBox_Description.TabIndex = 15
        Me.TextBox_Description.Text = "000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "111" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "222" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "333"
        '
        'Label_Emoticon
        '
        Me.Label_Emoticon.AutoSize = True
        Me.Label_Emoticon.Location = New System.Drawing.Point(312, 24)
        Me.Label_Emoticon.Name = "Label_Emoticon"
        Me.Label_Emoticon.Size = New System.Drawing.Size(42, 21)
        Me.Label_Emoticon.TabIndex = 20
        Me.Label_Emoticon.Text = "内容"
        '
        'TextBox_Emoticon
        '
        Me.TextBox_Emoticon.Location = New System.Drawing.Point(312, 48)
        Me.TextBox_Emoticon.Multiline = True
        Me.TextBox_Emoticon.Name = "TextBox_Emoticon"
        Me.TextBox_Emoticon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Emoticon.Size = New System.Drawing.Size(464, 216)
        Me.TextBox_Emoticon.TabIndex = 14
        Me.TextBox_Emoticon.Text = "000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "111" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "222" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "333"
        '
        'Button_Entry_Delete
        '
        Me.Button_Entry_Delete.Location = New System.Drawing.Point(232, 464)
        Me.Button_Entry_Delete.Name = "Button_Entry_Delete"
        Me.Button_Entry_Delete.Size = New System.Drawing.Size(72, 32)
        Me.Button_Entry_Delete.TabIndex = 13
        Me.Button_Entry_Delete.Text = "删除"
        Me.Button_Entry_Delete.UseVisualStyleBackColor = True
        '
        'Button_Entry_Add
        '
        Me.Button_Entry_Add.Location = New System.Drawing.Point(160, 464)
        Me.Button_Entry_Add.Name = "Button_Entry_Add"
        Me.Button_Entry_Add.Size = New System.Drawing.Size(72, 32)
        Me.Button_Entry_Add.TabIndex = 12
        Me.Button_Entry_Add.Text = "增加"
        Me.Button_Entry_Add.UseVisualStyleBackColor = True
        '
        'Button_Entry_Down
        '
        Me.Button_Entry_Down.Location = New System.Drawing.Point(232, 432)
        Me.Button_Entry_Down.Name = "Button_Entry_Down"
        Me.Button_Entry_Down.Size = New System.Drawing.Size(72, 32)
        Me.Button_Entry_Down.TabIndex = 11
        Me.Button_Entry_Down.Text = "下移 ↓"
        Me.Button_Entry_Down.UseVisualStyleBackColor = True
        '
        'Button_Entry_Up
        '
        Me.Button_Entry_Up.Location = New System.Drawing.Point(160, 432)
        Me.Button_Entry_Up.Name = "Button_Entry_Up"
        Me.Button_Entry_Up.Size = New System.Drawing.Size(72, 32)
        Me.Button_Entry_Up.TabIndex = 10
        Me.Button_Entry_Up.Text = "↑ 上移"
        Me.Button_Entry_Up.UseVisualStyleBackColor = True
        '
        'ListBox_Entry
        '
        Me.ListBox_Entry.FormattingEnabled = True
        Me.ListBox_Entry.HorizontalScrollbar = True
        Me.ListBox_Entry.ItemHeight = 21
        Me.ListBox_Entry.Items.AddRange(New Object() {"000", "111", "222", "333", "444", "555", "666", "777", "888", "999", "aaa", "bbb", "ccc", "ddd", "eee", "fff"})
        Me.ListBox_Entry.Location = New System.Drawing.Point(160, 48)
        Me.ListBox_Entry.Name = "ListBox_Entry"
        Me.ListBox_Entry.Size = New System.Drawing.Size(144, 382)
        Me.ListBox_Entry.TabIndex = 9
        '
        'Label_Entry
        '
        Me.Label_Entry.AutoSize = True
        Me.Label_Entry.Location = New System.Drawing.Point(160, 24)
        Me.Label_Entry.Name = "Label_Entry"
        Me.Label_Entry.Size = New System.Drawing.Size(42, 21)
        Me.Label_Entry.TabIndex = 14
        Me.Label_Entry.Text = "文本"
        '
        'Button_Category_Delete
        '
        Me.Button_Category_Delete.Location = New System.Drawing.Point(80, 464)
        Me.Button_Category_Delete.Name = "Button_Category_Delete"
        Me.Button_Category_Delete.Size = New System.Drawing.Size(72, 32)
        Me.Button_Category_Delete.TabIndex = 8
        Me.Button_Category_Delete.Text = "删除"
        Me.Button_Category_Delete.UseVisualStyleBackColor = True
        '
        'Button_Category_Add
        '
        Me.Button_Category_Add.Location = New System.Drawing.Point(8, 464)
        Me.Button_Category_Add.Name = "Button_Category_Add"
        Me.Button_Category_Add.Size = New System.Drawing.Size(72, 32)
        Me.Button_Category_Add.TabIndex = 7
        Me.Button_Category_Add.Text = "增加"
        Me.Button_Category_Add.UseVisualStyleBackColor = True
        '
        'Button_Category_Down
        '
        Me.Button_Category_Down.Location = New System.Drawing.Point(80, 432)
        Me.Button_Category_Down.Name = "Button_Category_Down"
        Me.Button_Category_Down.Size = New System.Drawing.Size(72, 32)
        Me.Button_Category_Down.TabIndex = 6
        Me.Button_Category_Down.Text = "下移 ↓"
        Me.Button_Category_Down.UseVisualStyleBackColor = True
        '
        'Button_Category_Up
        '
        Me.Button_Category_Up.Location = New System.Drawing.Point(8, 432)
        Me.Button_Category_Up.Name = "Button_Category_Up"
        Me.Button_Category_Up.Size = New System.Drawing.Size(72, 32)
        Me.Button_Category_Up.TabIndex = 5
        Me.Button_Category_Up.Text = "↑ 上移"
        Me.Button_Category_Up.UseVisualStyleBackColor = True
        '
        'Button_New
        '
        Me.Button_New.Location = New System.Drawing.Point(8, 560)
        Me.Button_New.Name = "Button_New"
        Me.Button_New.Size = New System.Drawing.Size(88, 32)
        Me.Button_New.TabIndex = 2
        Me.Button_New.Text = "新建"
        Me.Button_New.UseVisualStyleBackColor = True
        '
        'Button_Load
        '
        Me.Button_Load.Location = New System.Drawing.Point(104, 560)
        Me.Button_Load.Name = "Button_Load"
        Me.Button_Load.Size = New System.Drawing.Size(88, 32)
        Me.Button_Load.TabIndex = 3
        Me.Button_Load.Text = "打开"
        Me.Button_Load.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(608, 560)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(88, 32)
        Me.Button_Save.TabIndex = 0
        Me.Button_Save.Text = "保存"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Quit
        '
        Me.Button_Quit.Location = New System.Drawing.Point(704, 560)
        Me.Button_Quit.Name = "Button_Quit"
        Me.Button_Quit.Size = New System.Drawing.Size(88, 32)
        Me.Button_Quit.TabIndex = 1
        Me.Button_Quit.Text = "退出"
        Me.Button_Quit.UseVisualStyleBackColor = True
        '
        'Button_SaveEntry
        '
        Me.Button_SaveEntry.Location = New System.Drawing.Point(704, 400)
        Me.Button_SaveEntry.Name = "Button_SaveEntry"
        Me.Button_SaveEntry.Size = New System.Drawing.Size(72, 31)
        Me.Button_SaveEntry.TabIndex = 16
        Me.Button_SaveEntry.Text = "保存"
        Me.Button_SaveEntry.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckFileExists = True
        '
        'Form_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Button_Quit)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_Load)
        Me.Controls.Add(Me.Button_New)
        Me.Controls.Add(Me.GroupBox_Editor)
        Me.Controls.Add(Me.Label_Editor)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Form_Editor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "词库编辑器"
        Me.GroupBox_Editor.ResumeLayout(False)
        Me.GroupBox_Editor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_Editor As Label
    Friend WithEvents ListBox_Category As ListBox
    Friend WithEvents Label_Category As Label
    Friend WithEvents GroupBox_Editor As GroupBox
    Friend WithEvents Button_New As Button
    Friend WithEvents Button_Load As Button
    Friend WithEvents Button_Save As Button
    Friend WithEvents Button_Quit As Button
    Friend WithEvents Button_Category_Delete As Button
    Friend WithEvents Button_Category_Add As Button
    Friend WithEvents Button_Category_Down As Button
    Friend WithEvents Button_Category_Up As Button
    Friend WithEvents Button_Entry_Delete As Button
    Friend WithEvents Button_Entry_Add As Button
    Friend WithEvents Button_Entry_Down As Button
    Friend WithEvents Button_Entry_Up As Button
    Friend WithEvents ListBox_Entry As ListBox
    Friend WithEvents Label_Entry As Label
    Friend WithEvents TextBox_Emoticon As TextBox
    Friend WithEvents Label_Description As Label
    Friend WithEvents TextBox_Description As TextBox
    Friend WithEvents Label_Emoticon As Label
    Friend WithEvents Label_Information As Label
    Friend WithEvents Label_Alias As Label
    Friend WithEvents Button_Information As Button
    Friend WithEvents Button_Alias As Button
    Friend WithEvents Button_SaveEntry As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
