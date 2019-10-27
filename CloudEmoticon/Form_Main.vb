Imports Transitions

Public Class Form_Main
    'Public FormTransitionTime As Integer = 250 '窗口滑动时间
    'Public FormWidthRatio As Single = 0.25 '窗口宽度与屏幕的比例
    Public Online_Timeout As Integer = 5000 '在线下载超时时间，毫秒

    Const DefaultSkinID As Integer = SkinID.Akari

    Dim CurrentCollection As StringCollection '当前的字符串列表
    Dim CurrentCategory As Integer
    Dim CurrentEntryPage As Integer
    Dim LoadedFilePath As String '读取的文件路径
    Dim Paste As Boolean = False
    Dim PastedString As String

    Declare Auto Function RegisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Integer, ByVal fsModifier As UInt32, ByVal vk As UInt32) As Boolean '钦定热键
    Declare Auto Function UnregisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Integer) As Boolean '取消热键

    Dim temp_timer As New Timer()

    'Private Function ReadStringFromFile(FilePath As String) As List(Of String)
    '    Dim ReturnList As New List(Of String)
    '    Dim _file As New IO.StreamReader(FilePath)
    '    Dim oneLine As String
    '    oneLine = _file.ReadLine()
    '    While (oneLine <> "")
    '        ReturnList.Add(oneLine)
    '        oneLine = _file.ReadLine()
    '    End While
    '    _file.Close()
    '    Return ReturnList
    'End Function '逐行读取文本，跳过空行

    Private Function GetEntryPageCount() As Integer
        Return Math.Ceiling(CurrentCollection.Categories(CurrentCategory).Entries.Count / 10)
    End Function '获取总页数

    Private Sub Form_Appear()
        Me.Show()
        Dim t As New Transition(New TransitionType_EaseInEaseOut(My.Settings.FormTransitionTime))
        t.add(Me, "Left", My.Computer.Screen.Bounds.Width - Me.Width)
        t.run()
    End Sub '让窗口滑出来

    Private Sub Form_Hide()
        Dim t As New Transition(New TransitionType_EaseInEaseOut(My.Settings.FormTransitionTime))
        t.add(Me, "Left", My.Computer.Screen.Bounds.Width)
        t.run()

        temp_timer.Interval = My.Settings.FormTransitionTime
        temp_timer.Start()
    End Sub '让窗口滑回去

    Private Sub AfterWaitingForTransition()
        temp_timer.Stop()
        Me.Hide()
        If Paste And PastedString <> "" Then
            If My.Settings.CopyToClipboard Then My.Computer.Clipboard.SetText(PastedString)
            'SendKeys.Send("^V")
            SendKeys.Send(FormatStringToSend(PastedString))
        End If
        Paste = False
    End Sub '等窗口滑出屏幕外了再隐藏，并在隐藏后进行粘贴

    Public Function FormatStringToSend([String] As String) As String
        Dim FormattedString As String = ""
        For Each c As Char In [String].ToCharArray
            If "+^%~(){}".ToCharArray.Contains(c) Then
                FormattedString &= "{" & c & "}"
            Else
                FormattedString &= c
            End If
        Next
        Return FormattedString
    End Function '对使用SendKeys.Send()输出的字符串进行转义

    Public Sub LocateAllControls(Skin As Skin)
        If Skin.Equals(GetSkinFromID(SkinID.Custom)) Then
            With Skin_Custom
                .BackgroundImage = New Bitmap(My.Settings.CustomSkinPicturePath)
                .BackgroundColor = My.Settings.CustomSkinBackgroundColor
                .TextPrimaryColor = My.Settings.CustomSkinTextPrimaryColor
                .TextSecondaryColor = My.Settings.CustomSkinTextSecondaryColor
            End With
            Skin = GetSkinFromID(SkinID.Custom)
        End If

        With Me
            .Left = My.Computer.Screen.Bounds.Width
            .Top = 0
            .Width = My.Computer.Screen.Bounds.Width * My.Settings.FormWidthRatio
            .Height = My.Computer.Screen.Bounds.Height
            .BackColor = Skin.BackgroundColor
        End With

        With PictureBox_Background
            .BackgroundImage = Skin.BackgroundImage
            .Left = 0
            .Top = 0
            .Width = Me.Width
            .Height = Me.Width / Skin.BackgroundImage.Width * Skin.BackgroundImage.Height
        End With

        With TableLayoutPanel_Display
            .Left = Me.Width * 0.1
            .Top = PictureBox_Background.Height
            .Width = Me.Width * 0.8
            .Height = (Me.Height - PictureBox_Background.Height) * 0.85
        End With

        Label_Display_1.ForeColor = Skin.TextPrimaryColor
        Label_Display_2.ForeColor = Skin.TextPrimaryColor
        Label_Display_3.ForeColor = Skin.TextPrimaryColor
        Label_Display_4.ForeColor = Skin.TextPrimaryColor
        Label_Display_5.ForeColor = Skin.TextPrimaryColor
        Label_Display_6.ForeColor = Skin.TextPrimaryColor
        Label_Display_7.ForeColor = Skin.TextPrimaryColor
        Label_Display_8.ForeColor = Skin.TextPrimaryColor
        Label_Display_9.ForeColor = Skin.TextPrimaryColor
        Label_Display_0.ForeColor = Skin.TextPrimaryColor

        Label_Key_1.ForeColor = Skin.TextSecondaryColor
        Label_Key_2.ForeColor = Skin.TextSecondaryColor
        Label_Key_3.ForeColor = Skin.TextSecondaryColor
        Label_Key_4.ForeColor = Skin.TextSecondaryColor
        Label_Key_5.ForeColor = Skin.TextSecondaryColor
        Label_Key_6.ForeColor = Skin.TextSecondaryColor
        Label_Key_7.ForeColor = Skin.TextSecondaryColor
        Label_Key_8.ForeColor = Skin.TextSecondaryColor
        Label_Key_9.ForeColor = Skin.TextSecondaryColor
        Label_Key_0.ForeColor = Skin.TextSecondaryColor

        Label_FileName.ForeColor = Skin.TextSecondaryColor
        Label_Page.ForeColor = Skin.TextSecondaryColor

        With TableLayoutPanel_Page
            .Left = Me.Width * 0.05
            .Top = TableLayoutPanel_Display.Top + TableLayoutPanel_Display.Height
            .Width = Me.Width * 0.9
            .Height = (Me.Height - .Top) * 0.75
        End With
    End Sub '重新确定所有控件位置和属性

    Public Sub Form_Update()
        If ((CurrentEntryPage) * 10 + 1) <= CurrentCollection.Categories(CurrentCategory).Entries.Count Then Label_Display_1.Text = CurrentCollection.Categories(CurrentCategory).Entries((CurrentEntryPage) * 10 + 1 - 1).Emoticon Else Label_Display_1.Text = ""
        If ((CurrentEntryPage) * 10 + 2) <= CurrentCollection.Categories(CurrentCategory).Entries.Count Then Label_Display_2.Text = CurrentCollection.Categories(CurrentCategory).Entries((CurrentEntryPage) * 10 + 2 - 1).Emoticon Else Label_Display_2.Text = ""
        If ((CurrentEntryPage) * 10 + 3) <= CurrentCollection.Categories(CurrentCategory).Entries.Count Then Label_Display_3.Text = CurrentCollection.Categories(CurrentCategory).Entries((CurrentEntryPage) * 10 + 3 - 1).Emoticon Else Label_Display_3.Text = ""
        If ((CurrentEntryPage) * 10 + 4) <= CurrentCollection.Categories(CurrentCategory).Entries.Count Then Label_Display_4.Text = CurrentCollection.Categories(CurrentCategory).Entries((CurrentEntryPage) * 10 + 4 - 1).Emoticon Else Label_Display_4.Text = ""
        If ((CurrentEntryPage) * 10 + 5) <= CurrentCollection.Categories(CurrentCategory).Entries.Count Then Label_Display_5.Text = CurrentCollection.Categories(CurrentCategory).Entries((CurrentEntryPage) * 10 + 5 - 1).Emoticon Else Label_Display_5.Text = ""
        If ((CurrentEntryPage) * 10 + 6) <= CurrentCollection.Categories(CurrentCategory).Entries.Count Then Label_Display_6.Text = CurrentCollection.Categories(CurrentCategory).Entries((CurrentEntryPage) * 10 + 6 - 1).Emoticon Else Label_Display_6.Text = ""
        If ((CurrentEntryPage) * 10 + 7) <= CurrentCollection.Categories(CurrentCategory).Entries.Count Then Label_Display_7.Text = CurrentCollection.Categories(CurrentCategory).Entries((CurrentEntryPage) * 10 + 7 - 1).Emoticon Else Label_Display_7.Text = ""
        If ((CurrentEntryPage) * 10 + 8) <= CurrentCollection.Categories(CurrentCategory).Entries.Count Then Label_Display_8.Text = CurrentCollection.Categories(CurrentCategory).Entries((CurrentEntryPage) * 10 + 8 - 1).Emoticon Else Label_Display_8.Text = ""
        If ((CurrentEntryPage) * 10 + 9) <= CurrentCollection.Categories(CurrentCategory).Entries.Count Then Label_Display_9.Text = CurrentCollection.Categories(CurrentCategory).Entries((CurrentEntryPage) * 10 + 9 - 1).Emoticon Else Label_Display_9.Text = ""
        If ((CurrentEntryPage) * 10 + 10) <= CurrentCollection.Categories(CurrentCategory).Entries.Count Then Label_Display_0.Text = CurrentCollection.Categories(CurrentCategory).Entries((CurrentEntryPage) * 10 + 10 - 1).Emoticon Else Label_Display_0.Text = ""

        If CurrentCollection.alias = "" Then
            Label_FileName.Text = IO.Path.GetFileNameWithoutExtension(LoadedFilePath) + " - " + CurrentCollection.categories(CurrentCategory).name
        Else
            Label_FileName.Text = CurrentCollection.alias + " - " + CurrentCollection.categories(CurrentCategory).name
        End If
        Label_Page.Text = (CurrentCategory + 1) & " / " & CurrentCollection.categories.Count & " 组   " & (CurrentEntryPage + 1) & " / " & GetEntryPageCount() & " 页"
    End Sub '重新显示所有文本内容

    Public Sub LoadStrings(Path As String, Optional Temp As Boolean = False, Optional StartUp As Boolean = False)
        Dim temp_Path As String = IO.Path.GetTempFileName
        IO.File.Delete(temp_Path)

        Try
            My.Computer.Network.DownloadFile(Path, temp_Path, False, Online_Timeout)
        Catch ex As Exception
            If Trim(Path) <> "" Then MsgBox("读取失败。" & vbCrLf & "请检查文件路径、链接是否正确有效。" & vbCrLf & "如果输入了链接进行在线读取，也可能是网络链接中断所致。", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            If StartUp Then
                IO.File.WriteAllBytes(temp_Path, My.Resources.DefaultStringCollection)
                LoadedFilePath = ""
                My.Settings.LoadedFilePath = LoadedFilePath
                'My.Settings.LoadedFileOnline = Online
                My.Settings.Save()
                CurrentCollection = JsonHelper.ToClass(Of StringCollection)(IO.File.ReadAllText(temp_Path))
                IO.File.Delete(temp_Path)
                ShowTip()
                Exit Sub
            End If
        End Try

        LoadedFilePath = Path
        CurrentCollection = JsonHelper.ToClass(Of StringCollection)(IO.File.ReadAllText(temp_Path))
        IO.File.Delete(temp_Path)

        CurrentCategory = 0
        CurrentEntryPage = 0

        If Temp Then LoadedFilePath = ""
        My.Settings.LoadedFilePath = LoadedFilePath
        'My.Settings.LoadedFileOnline = Online
        My.Settings.Save()
        ShowTip()
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'temp_timer.Interval = My.Settings.FormTransitionTime
        AddHandler temp_timer.Tick, AddressOf AfterWaitingForTransition
        'If IO.File.Exists(My.Settings.LoadedFilePath) Then
        '    LoadStrings(My.Settings.LoadedFilePath)
        'Else
        '    If Trim(My.Settings.LoadedFilePath) <> "" Then MsgBox("读取失败。" & vbCrLf & "请检查文件路径、链接是否正确有效。" & vbCrLf & "如果输入了链接进行在线读取，也可能是网络链接中断所致。", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

        '    'MessageBox.Show(ex.Message)
        '    Dim temp_Path As String = IO.Path.GetTempFileName
        '    IO.File.WriteAllBytes(temp_Path, My.Resources.DefaultStringCollection)
        '    LoadStrings(temp_Path, True)
        '    IO.File.Delete(temp_Path)
        '    LoadedFilePath = ""
        'End If

        If Trim(My.Settings.LoadedFilePath) = "" Then
            Dim temp_Path As String = IO.Path.GetTempFileName
            IO.File.WriteAllBytes(temp_Path, My.Resources.DefaultStringCollection)
            LoadStrings(temp_Path, True)
            IO.File.Delete(temp_Path)
            LoadedFilePath = ""
        Else
            LoadStrings(My.Settings.LoadedFilePath, False, True)
        End If

        If (Not (IO.File.Exists(My.Settings.CustomSkinPicturePath)) And My.Settings.CurrentSkinID = SkinID.Custom) Then
            My.Settings.CurrentSkinID = DefaultSkinID
        End If

        Form_Update()
        LocateAllControls(GetSkinFromID(My.Settings.CurrentSkinID)) '顺便钦定了默认皮肤

        'Alt = 1, Control = 2, Shift = 4
        '这里钦定的热键是Ctrl+Shift+E
        RegisterHotKey(Me.Handle, 2333, &H6, Keys.E)

        Form_Hide()
    End Sub

    Private Sub ShowTip()
        If LoadedFilePath <> "" Then
            NotifyIcon_Main.BalloonTipText = "已载入词库文件：" & IO.Path.GetFileName(LoadedFilePath) & vbCrLf & "按Ctrl+Shift+E弹出窗口～"
        Else
            NotifyIcon_Main.BalloonTipText = "未载入词库文件" & vbCrLf & "右键单击托盘进行载入～"
        End If
        NotifyIcon_Main.ShowBalloonTip(5000)
    End Sub

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = &H312 Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "2333"
                    Form_Appear()
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub NotifyIcon_Main_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon_Main.MouseDoubleClick
        Form_Appear()
    End Sub

    Private Sub Form_Main_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Form_Hide()
    End Sub

    Private Sub Form_Main_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "-"
                If CurrentEntryPage <> 0 Then CurrentEntryPage -= 1
                Form_Update()
            Case "="
                If (CurrentEntryPage) + 1 < GetEntryPageCount() Then CurrentEntryPage += 1
                Form_Update()
            Case "["
                If CurrentCategory <> 0 Then
                    CurrentCategory -= 1
                    CurrentEntryPage = 0
                End If
                Form_Update()
            Case "]"
                If (CurrentCategory + 1) < CurrentCollection.Categories.Count Then
                    CurrentCategory += 1
                    CurrentEntryPage = 0
                End If
                Form_Update()
            Case "1"
                PastedString = Label_Display_1.Text
                Paste = True
                Form_Hide()
            Case "2"
                PastedString = Label_Display_2.Text
                Paste = True
                Form_Hide()
            Case "3"
                PastedString = Label_Display_3.Text
                Paste = True
                Form_Hide()
            Case "4"
                PastedString = Label_Display_4.Text
                Paste = True
                Form_Hide()
            Case "5"
                PastedString = Label_Display_5.Text
                Paste = True
                Form_Hide()
            Case "6"
                PastedString = Label_Display_6.Text
                Paste = True
                Form_Hide()
            Case "7"
                PastedString = Label_Display_7.Text
                Paste = True
                Form_Hide()
            Case "8"
                PastedString = Label_Display_8.Text
                Paste = True
                Form_Hide()
            Case "9"
                PastedString = Label_Display_9.Text
                Paste = True
                Form_Hide()
            Case "0"
                PastedString = Label_Display_0.Text
                Paste = True
                Form_Hide()
            Case Chr(&H1B) 'Escape
                Form_Hide()
        End Select
    End Sub

    Private Sub Form_Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        NotifyIcon_Main.Dispose()
        UnregisterHotKey(Me.Handle, 2333)
    End Sub

    Private Sub NotifyIcon_Main_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon_Main.MouseClick
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip_Main.Show()
        End If
    End Sub

    Private Sub ShowFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowForm_ToolStripMenuItem.Click
        Form_Appear()
    End Sub

    Private Sub Exit_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Exit_ToolStripMenuItem.Click
        My.Settings.Save()
        End
    End Sub

    Private Sub Skin_Akari_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Skin_Akari_ToolStripMenuItem.Click
        My.Settings.CurrentSkinID = SkinID.Akari
        LocateAllControls(GetSkinFromID(My.Settings.CurrentSkinID))
    End Sub

    Private Sub Skin_Material_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Skin_Material_ToolStripMenuItem.Click
        My.Settings.CurrentSkinID = SkinID.Material
        LocateAllControls(GetSkinFromID(My.Settings.CurrentSkinID))
    End Sub

    Private Sub Skin_Scorpio_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Skin_Scorpio_ToolStripMenuItem.Click
        My.Settings.CurrentSkinID = SkinID.Scorpio
        LocateAllControls(GetSkinFromID(My.Settings.CurrentSkinID))
    End Sub

    Private Sub Skin_Catwalk_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Skin_Catwalk_ToolStripMenuItem.Click
        My.Settings.CurrentSkinID = SkinID.Catwalk
        LocateAllControls(GetSkinFromID(My.Settings.CurrentSkinID))
    End Sub

    Private Sub Skin_KotoHonoUmi_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Skin_KotoHonoUmi_ToolStripMenuItem.Click
        My.Settings.CurrentSkinID = SkinID.KotoHonoUmi
        LocateAllControls(GetSkinFromID(My.Settings.CurrentSkinID))
    End Sub

    Private Sub Skin_Sagiri_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Skin_Sagiri_ToolStripMenuItem.Click
        My.Settings.CurrentSkinID = SkinID.Sagiri
        LocateAllControls(GetSkinFromID(My.Settings.CurrentSkinID))
    End Sub

    Private Sub Skin_Custom_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Skin_Custom_ToolStripMenuItem.Click
        If My.Settings.CustomSkinPicturePath = "" Then
            MsgBox("没有设定背景图片。", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        ElseIf (Not IO.File.Exists(My.Settings.CustomSkinPicturePath)) Then
            MsgBox("背景图片路径错误。", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Else
            My.Settings.CurrentSkinID = SkinID.Custom
            LocateAllControls(GetSkinFromID(My.Settings.CurrentSkinID))
        End If
    End Sub

    Private Sub About_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles About_ToolStripMenuItem.Click
        Form_About.Show()
    End Sub

    Private Sub LoadOnline_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadOnline_ToolStripMenuItem.Click
        Dim URL = InputBox("请输入词库文件路径 / 链接：")
        If Trim(URL) <> "" Then
            LoadStrings(URL)
            Form_Update()
        End If
    End Sub

    Private Sub LoadFromFile_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFromFile_ToolStripMenuItem.Click
        Dim temp_OpenFileDialog As New OpenFileDialog With {
            .Filter = "以JSON格式存储的词库文件(*.json)|*.json",
            .Multiselect = False,
            .InitialDirectory = Application.StartupPath,
            .RestoreDirectory = True
        }
        temp_OpenFileDialog.ShowDialog()
        If Trim(temp_OpenFileDialog.FileName) <> "" Then
            LoadStrings(temp_OpenFileDialog.FileName)
            Form_Update()
        End If
    End Sub

    Private Sub ConvertFromText_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertFromText_ToolStripMenuItem.Click
        Dim temp_OpenFileDialog As New OpenFileDialog With {
            .Filter = "文本文档(*.txt)|*.txt",
            .Multiselect = False,
            .InitialDirectory = Application.StartupPath,
            .RestoreDirectory = True
        }
        temp_OpenFileDialog.ShowDialog()
        If temp_OpenFileDialog.FileName = "" Then Exit Sub

        Dim Lines As String() = IO.File.ReadAllLines(temp_OpenFileDialog.FileName)

        Dim temp_StringBuilder As New Text.StringBuilder()
        Dim temp_StringWriter As New IO.StringWriter(temp_StringBuilder)
        Dim temp_JSONTextWriter As New Newtonsoft.Json.JsonTextWriter(temp_StringWriter)

        With temp_JSONTextWriter
            .WriteStartObject()
            .WritePropertyName("alias")
            .WriteValue(IO.Path.GetFileNameWithoutExtension(temp_OpenFileDialog.FileName))
            .WritePropertyName("categories")
            .WriteStartArray()
            .WriteStartObject()
            .WritePropertyName("entries")
            .WriteStartArray()
            For i = 0 To Lines.Count - 1
                .WriteStartObject()
                .WritePropertyName("emoticon")
                .WriteValue(Lines(i))
                .WriteEndObject()
            Next
            .WriteEnd()
            .WritePropertyName("name")
            .WriteValue("已转换")
            .WriteEndObject()
            .WriteEnd()
            .WriteEndObject()
        End With
        IO.File.WriteAllText(IO.Path.ChangeExtension(temp_OpenFileDialog.FileName, "json"), temp_StringBuilder.ToString)
        MsgBox("已转换完成。" & vbCrLf & "转换后的词库文件路径为：" & IO.Path.ChangeExtension(temp_OpenFileDialog.FileName, "json"), MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
    End Sub

    Private Sub OpenConfigFolder_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenConfigFolder_ToolStripMenuItem.Click
        Process.Start("explorer.exe", IO.Path.GetDirectoryName(System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath))
    End Sub

    Private Sub Config_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Config_ToolStripMenuItem.Click
        Form_Config.Show()
    End Sub

    Private Sub Editor_ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Editor_ToolStripMenuItem.Click
        Form_Editor.Show()
    End Sub
End Class
