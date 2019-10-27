Public Class Form_Editor
    Dim Editing_Collection As New StringCollection
    Dim CurrentCategory As Integer = 0
    Dim CurrentEntry As Integer = 0
    Dim CurrentPath As String

    Sub LoadCollection(Optional Path As String = "")
        If Path = "" Then
            Dim temp_Path As String = IO.Path.GetTempFileName
            IO.File.Delete(temp_Path)
            IO.File.WriteAllBytes(temp_Path, My.Resources.DefaultStringCollection)
            Editing_Collection = JsonHelper.ToClass(Of StringCollection)(IO.File.ReadAllText(temp_Path))
            IO.File.Delete(temp_Path)
            Label_Editor.Text = "词库编辑器"
        Else
            Editing_Collection = JsonHelper.ToClass(Of StringCollection)(IO.File.ReadAllText(Path))
            Label_Editor.Text = "词库编辑器 - " & IO.Path.GetFileNameWithoutExtension(Path)
        End If

        If Editing_Collection.Categories.Count = 0 Then Exit Sub
        For i = 0 To Editing_Collection.Categories.Count - 1
            If Editing_Collection.Categories(i).Entries.Count = 0 Then Exit For
            For j = 0 To Editing_Collection.Categories(i).Entries.Count - 1
                Editing_Collection.categories(i).entries(j).emoticon = Editing_Collection.categories(i).entries(j).emoticon.Replace(vbLf, vbCrLf)
                Editing_Collection.categories(i).entries(j).emoticon = Editing_Collection.categories(i).entries(j).emoticon.Replace(vbCr & vbCrLf, vbCrLf)
                If Editing_Collection.categories(i).entries(j).description = Nothing Then Continue For
                Editing_Collection.categories(i).entries(j).description = Editing_Collection.categories(i).entries(j).description.Replace(vbLf, vbCrLf)
                Editing_Collection.categories(i).entries(j).description = Editing_Collection.categories(i).entries(j).description.Replace(vbCr & vbCrLf, vbCrLf)
            Next
        Next '行尾标准化

        CurrentCategory = 0
        CurrentEntry = 0
        CurrentPath = Path

        Show_AliasInformation()
        Show_Category()

        Save_Entry()
    End Sub '不写路径则读取默认的文件

    Sub Show_AliasInformation()
        Label_Alias.Text = "词库名称：" & Editing_Collection.Alias
        Try
            Label_Information.Text = "词库说明：" & Editing_Collection.Information(0)
        Catch ex As System.IndexOutOfRangeException
            Label_Information.Text = "词库说明："
        Catch ex As System.NullReferenceException
            Label_Information.Text = "词库说明："
        End Try
    End Sub

    Sub Show_EmoticonDescription(Category As Integer, Entry As Integer)
        'If Editing_Collection.Categories(CurrentCategory).Entries.Count = 0 Or Category = -1 Or Entry = -1 Then
        If Category = -1 Or Entry = -1 Then
            TextBox_Emoticon.Text = ""
            TextBox_Description.Text = ""
            Exit Sub
        End If
        TextBox_Emoticon.Text = Editing_Collection.Categories(Category).Entries(Entry).Emoticon
        TextBox_Description.Text = Editing_Collection.Categories(Category).Entries(Entry).Description
    End Sub

    Sub Edit_EmoticonDescription(Category As Integer, Entry As Integer)
        Editing_Collection.Categories(Category).Entries(Entry).Emoticon = TextBox_Emoticon.Text
        Editing_Collection.Categories(Category).Entries(Entry).Description = TextBox_Description.Text
    End Sub

    Sub Show_Entry(Category As Integer)
        If Category = -1 Then Exit Sub
        ListBox_Entry.Items.Clear()
        If Editing_Collection.Categories(Category).Entries.Count = 0 Then Exit Sub
        For i = 0 To Editing_Collection.Categories(Category).Entries.Count - 1
            ListBox_Entry.Items.Add(Editing_Collection.Categories(Category).Entries(i).Emoticon)
        Next
        'CurrentEntry = 0
        Show_EmoticonDescription(CurrentCategory, CurrentEntry)

        Label_Entry.Text = "文本 (" & Editing_Collection.Categories(CurrentCategory).Entries.Count & ")"
    End Sub

    Sub Show_Category()
        ListBox_Category.Items.Clear()
        If Editing_Collection.Categories.Count = 0 Then Exit Sub
        For i = 0 To Editing_Collection.Categories.Count - 1
            ListBox_Category.Items.Add(Editing_Collection.Categories(i).Name)
        Next
        CurrentEntry = 0
        Show_Entry(CurrentCategory)

        Label_Category.Text = "分组 (" & Editing_Collection.Categories.Count & ")"
    End Sub

    Sub Save_Entry()
        'Dim temp As Integer = CurrentEntry
        If CurrentEntry > ListBox_Entry.Items.Count - 1 Or CurrentEntry = -1 Then Exit Sub
        Editing_Collection.Categories(CurrentCategory).Entries(CurrentEntry).Emoticon = TextBox_Emoticon.Text
        Editing_Collection.Categories(CurrentCategory).Entries(CurrentEntry).Description = TextBox_Description.Text
        Show_Entry(CurrentCategory)

        ListBox_Entry.SelectedIndex = CurrentEntry
        ListBox_Category.SelectedIndex = CurrentCategory
    End Sub

    Private Sub Button_New_Click(sender As Object, e As EventArgs) Handles Button_New.Click
        LoadCollection()

        'CurrentCategory = 0
        'CurrentEntry = 0

        'Show_AliasInformation()
        'Show_Category()
    End Sub

    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_Load.Click
        Dim temp_OpenFileDialog As New OpenFileDialog With {
            .Filter = "以JSON格式存储的词库文件(*.json)|*.json",
            .Multiselect = False,
            .InitialDirectory = Application.StartupPath,
            .RestoreDirectory = True
        }
        temp_OpenFileDialog.ShowDialog()
        If Trim(temp_OpenFileDialog.FileName) <> "" Then
            LoadCollection(temp_OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        If CurrentPath = "" Then CurrentPath = Application.StartupPath & "\新词库文件.json"
        Dim temp_SaveFileDialog As New SaveFileDialog With {
            .Filter = "以JSON格式存储的词库文件(*.json)|*.json",
            .InitialDirectory = IO.Path.GetFullPath(CurrentPath),
            .RestoreDirectory = True,
            .CheckPathExists = True,
            .DefaultExt = "json",
            .FileName = IO.Path.GetFileName(CurrentPath)
        }
        temp_SaveFileDialog.ShowDialog()
        CurrentPath = temp_SaveFileDialog.FileName
        If Trim(temp_SaveFileDialog.FileName) <> "" Then
            IO.File.WriteAllText(CurrentPath, Newtonsoft.Json.JsonConvert.SerializeObject(Editing_Collection, Newtonsoft.Json.Formatting.Indented))
        End If
        MsgBox("保存成功！" & vbCrLf & CurrentPath, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Button_Quit_Click(sender As Object, e As EventArgs) Handles Button_Quit.Click
        Me.Close()
    End Sub

    Private Sub Button_Alias_Click(sender As Object, e As EventArgs) Handles Button_Alias.Click
        Dim temp_Alias As String = InputBox("请输入新的名称：")
        If Trim(temp_Alias) <> "" Then Editing_Collection.Alias = temp_Alias

        Show_AliasInformation()
    End Sub

    Private Sub Button_Information_Click(sender As Object, e As EventArgs) Handles Button_Information.Click
        Dim temp_Information As String = InputBox("请输入新的说明：")
        If Trim(temp_Information) <> "" Then Editing_Collection.Information = {temp_Information}

        Show_AliasInformation()
    End Sub

    Private Sub Form_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCollection()

        'ListBox_Category.SelectedIndex = 0
        'ListBox_Entry.SelectedIndex = 0
        'Show_AliasInformation()
        'Show_Category()
    End Sub

    Private Sub ListBox_Entry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Entry.SelectedIndexChanged
        CurrentEntry = ListBox_Entry.SelectedIndex
        Show_EmoticonDescription(CurrentCategory, CurrentEntry)
    End Sub

    Private Sub ListBox_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Category.SelectedIndexChanged
        CurrentCategory = ListBox_Category.SelectedIndex
        'If Editing_Collection.Categories(CurrentCategory).Entries.Count <> 0 Then CurrentEntry = 0 Else CurrentEntry = -1
        CurrentEntry = 0
        Show_Entry(CurrentCategory)

        ListBox_Entry.SelectedIndex = CurrentEntry
    End Sub

    Private Sub ListBox_Category_DoubleClick(sender As Object, e As EventArgs) Handles ListBox_Category.DoubleClick
        Dim temp As String = InputBox("请输入新的分组名：")
        If Trim(temp) <> "" Then
            Editing_Collection.Categories(CurrentCategory).Name = temp
            Show_Category()
            ListBox_Category.SelectedIndex = CurrentCategory
        End If
    End Sub

    Private Sub Label_Editor_Click(sender As Object, e As EventArgs) Handles Label_Editor.Click
        If Trim(CurrentPath) <> "" Then MsgBox("已打开词库文件：" & vbCrLf & CurrentPath, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
    End Sub

    Private Sub Button_SaveEntry_Click(sender As Object, e As EventArgs) Handles Button_SaveEntry.Click
        Save_Entry()
    End Sub

    Private Sub Button_Category_Add_Click(sender As Object, e As EventArgs) Handles Button_Category_Add.Click
        Editing_Collection.Add_Category(New Category({New Entry("（新文本）", "")}, "（新分组）"), CurrentCategory)
        CurrentCategory += 1
        Show_Category()

        Save_Entry()
    End Sub

    Private Sub Button_Category_Delete_Click(sender As Object, e As EventArgs) Handles Button_Category_Delete.Click
        If Editing_Collection.Categories.Count = 1 Then Exit Sub
        Editing_Collection.Delete_Category(CurrentCategory)
        If CurrentCategory >= Editing_Collection.Categories.Count Then CurrentCategory -= 1
        Show_Category()

        Save_Entry()
    End Sub

    Private Sub Button_Entry_Add_Click(sender As Object, e As EventArgs) Handles Button_Entry_Add.Click
        Editing_Collection.Categories(CurrentCategory).Add_Entry(New Entry("（新文本）", ""), CurrentEntry)
        CurrentEntry += 1
        Show_Entry(CurrentCategory)

        Save_Entry()
    End Sub

    Private Sub Button_Entry_Delete_Click(sender As Object, e As EventArgs) Handles Button_Entry_Delete.Click
        If Editing_Collection.Categories(CurrentCategory).Entries.Count = 1 Then Exit Sub
        Editing_Collection.Categories(CurrentCategory).Delete_Entry(CurrentEntry)
        If CurrentEntry >= Editing_Collection.Categories(CurrentCategory).Entries.Count Then CurrentEntry -= 1
        Show_Entry(CurrentCategory)

        Save_Entry()
    End Sub

    Private Sub Button_Category_Up_Click(sender As Object, e As EventArgs) Handles Button_Category_Up.Click
        If CurrentCategory = 0 Then Exit Sub
        Editing_Collection.Exchange_Category(CurrentCategory, CurrentCategory - 1)
        CurrentCategory -= 1
        Show_Category()

        Save_Entry()
    End Sub

    Private Sub Button_Category_Down_Click(sender As Object, e As EventArgs) Handles Button_Category_Down.Click
        If CurrentCategory = Editing_Collection.Categories.Count - 1 Then Exit Sub
        Editing_Collection.Exchange_Category(CurrentCategory, CurrentCategory + 1)
        CurrentCategory += 1
        Show_Category()

        Save_Entry()
    End Sub

    Private Sub Button_Entry_Up_Click(sender As Object, e As EventArgs) Handles Button_Entry_Up.Click
        If CurrentEntry = 0 Then Exit Sub
        Editing_Collection.Categories(CurrentCategory).Exchange_Entry(CurrentEntry, CurrentEntry - 1)
        CurrentEntry -= 1
        Show_Entry(CurrentCategory)

        Save_Entry()
    End Sub

    Private Sub Button_Entry_Down_Click(sender As Object, e As EventArgs) Handles Button_Entry_Down.Click
        If CurrentEntry = Editing_Collection.Categories(CurrentCategory).Entries.Count - 1 Then Exit Sub
        Editing_Collection.Categories(CurrentCategory).Exchange_Entry(CurrentEntry, CurrentEntry + 1)
        CurrentEntry += 1
        Show_Entry(CurrentCategory)

        Save_Entry()
    End Sub
End Class