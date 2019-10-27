Public Class Form_Config
    Private Sub Form_Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_Path.Text = My.Settings.LoadedFilePath
        'CheckBox_Online.Checked = My.Settings.LoadedFileOnline
        NumericUpDown_FormTransitionTime.Value = My.Settings.FormTransitionTime
        NumericUpDown_FormWidthRatio.Value = My.Settings.FormWidthRatio
        TextBox_SkinPicture.Text = My.Settings.CustomSkinPicturePath
        CheckBox_CopyToClipboard.Checked = My.Settings.CopyToClipboard
        Button_SkinBackgroundColor.ForeColor = My.Settings.CustomSkinBackgroundColor
        Button_SkinBackgroundColor.Text = My.Settings.CustomSkinBackgroundColor.R & ", " & My.Settings.CustomSkinBackgroundColor.G & ", " & My.Settings.CustomSkinBackgroundColor.B
        Button_SkinTextPrimaryColor.ForeColor = My.Settings.CustomSkinTextPrimaryColor
        Button_SkinTextPrimaryColor.Text = My.Settings.CustomSkinTextPrimaryColor.R & ", " & My.Settings.CustomSkinTextPrimaryColor.G & ", " & My.Settings.CustomSkinTextPrimaryColor.B
        Button_SkinTextSecondaryColor.ForeColor = My.Settings.CustomSkinTextSecondaryColor
        Button_SkinTextSecondaryColor.Text = My.Settings.CustomSkinTextSecondaryColor.R & ", " & My.Settings.CustomSkinTextSecondaryColor.G & ", " & My.Settings.CustomSkinTextSecondaryColor.B
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button_Apply_Click(sender As Object, e As EventArgs) Handles Button_Apply.Click
        'If Trim(TextBox_Path.Text) = "" Then
        '    MsgBox("输入的词库文件路径是空白的。", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        '    Exit Sub
        'ElseIf (Not CheckBox_Online.Checked) And (Not IO.File.Exists(TextBox_Path.Text)) Then
        '    MsgBox("输入的词库文件路径无效。" & vbCrLf & "如果输入的是链接，请选择““在线读取””", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        '    Exit Sub
        'ElseIf (Not (TextBox_Path.Text = My.Settings.LoadedFilePath And CheckBox_Online.Checked = My.Settings.LoadedFileOnline)) Then
        '    My.Settings.LoadedFilePath = TextBox_Path.Text
        '    My.Settings.LoadedFileOnline = CheckBox_Online.Checked
        '    Form_Main.LoadStrings(My.Settings.LoadedFilePath, My.Settings.LoadedFileOnline)
        '    Form_Main.Form_Update()
        'End If

        If Trim(TextBox_Path.Text) = "" Then
            MsgBox("输入的词库文件路径是空白的。", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
            'ElseIf IO.File.Exists(TextBox_Path.Text) Then
            '    My.Settings.LoadedFileOnline = False
            'Else
            '    My.Settings.LoadedFileOnline = True
        End If
        If My.Settings.LoadedFilePath <> TextBox_Path.Text Then
            My.Settings.LoadedFilePath = TextBox_Path.Text
            Form_Main.LoadStrings(My.Settings.LoadedFilePath)
            Form_Main.Form_Update()
        End If

        My.Settings.FormTransitionTime = NumericUpDown_FormTransitionTime.Value

        My.Settings.FormWidthRatio = NumericUpDown_FormWidthRatio.Value
        Form_Main.LocateAllControls(GetSkinFromID(My.Settings.CurrentSkinID))

        My.Settings.CopyToClipboard = CheckBox_CopyToClipboard.Checked

        If Trim(TextBox_SkinPicture.Text) = "" Then
            My.Settings.CustomSkinPicturePath = ""
        ElseIf (Not IO.File.Exists(TextBox_SkinPicture.Text)) Then
            MsgBox("背景图片路径错误。", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            My.Settings.CustomSkinPicturePath = TextBox_SkinPicture.Text
        End If

        My.Settings.CustomSkinBackgroundColor = Button_SkinBackgroundColor.ForeColor
        My.Settings.CustomSkinTextPrimaryColor = Button_SkinTextPrimaryColor.ForeColor
        My.Settings.CustomSkinTextSecondaryColor = Button_SkinTextSecondaryColor.ForeColor

        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Button_SkinPicture_Click(sender As Object, e As EventArgs) Handles Button_SkinPicture.Click
        Dim temp_OpenFileDialog As New OpenFileDialog With {
            .Filter = "图像文件(*.gif;*.jpg;*.jpeg;*.bmp;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.png",
            .Multiselect = False,
            .InitialDirectory = Application.StartupPath,
            .RestoreDirectory = True
        }
        temp_OpenFileDialog.ShowDialog()
        TextBox_SkinPicture.Text = temp_OpenFileDialog.FileName
    End Sub

    Private Sub Button_SkinBackgroundColor_Click(sender As Object, e As EventArgs) Handles Button_SkinBackgroundColor.Click
        Dim temp_ColorDialog As New ColorDialog With {
        .AnyColor = True,
        .FullOpen = True,
        .Color = My.Settings.CustomSkinBackgroundColor
        }
        temp_ColorDialog.ShowDialog()
        Button_SkinBackgroundColor.ForeColor = temp_ColorDialog.Color
        Button_SkinBackgroundColor.Text = temp_ColorDialog.Color.R & ", " & temp_ColorDialog.Color.G & ", " & temp_ColorDialog.Color.B
    End Sub

    Private Sub Button_SkinTextPrimaryColor_Click(sender As Object, e As EventArgs) Handles Button_SkinTextPrimaryColor.Click
        Dim temp_ColorDialog As New ColorDialog With {
        .AnyColor = True,
        .FullOpen = True,
        .Color = My.Settings.CustomSkinTextPrimaryColor
        }
        temp_ColorDialog.ShowDialog()
        Button_SkinTextPrimaryColor.ForeColor = temp_ColorDialog.Color
        Button_SkinTextPrimaryColor.Text = temp_ColorDialog.Color.R & ", " & temp_ColorDialog.Color.G & ", " & temp_ColorDialog.Color.B
    End Sub

    Private Sub Button_SkinTextSecondaryColor_Click(sender As Object, e As EventArgs) Handles Button_SkinTextSecondaryColor.Click
        Dim temp_ColorDialog As New ColorDialog With {
        .AnyColor = True,
        .FullOpen = True,
        .Color = My.Settings.CustomSkinTextSecondaryColor
        }
        temp_ColorDialog.ShowDialog()
        Button_SkinTextSecondaryColor.ForeColor = temp_ColorDialog.Color
        Button_SkinTextSecondaryColor.Text = temp_ColorDialog.Color.R & ", " & temp_ColorDialog.Color.G & ", " & temp_ColorDialog.Color.B
    End Sub

    Private Sub Button_Path_Click(sender As Object, e As EventArgs) Handles Button_Path.Click
        Dim temp_OpenFileDialog As New OpenFileDialog With {
            .Filter = "以JSON格式存储的词库文件(*.json)|*.json",
            .Multiselect = False,
            .InitialDirectory = Application.StartupPath,
            .RestoreDirectory = True
        }
        temp_OpenFileDialog.ShowDialog()
        If Trim(temp_OpenFileDialog.FileName) <> "" Then
            TextBox_Path.Text = temp_OpenFileDialog.FileName
            'CheckBox_Online.Checked = False
        End If
    End Sub

    Private Sub CheckBox_CopyToClipboard_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_CopyToClipboard.CheckedChanged

    End Sub
End Class