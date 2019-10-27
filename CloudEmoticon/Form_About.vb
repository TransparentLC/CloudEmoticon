Public Class Form_About
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Dim DoNotClick As Boolean = False

    Private Sub Form_About_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Hide()
    End Sub

    Private Sub Label_Title_Click(sender As Object, e As EventArgs) Handles Label_Title.Click
        If Rnd() < 0.1 Then
            If DoNotClick Then
                For i = 1 To 100
                    SendMessage(Me.Handle, &H319, Me.Handle, &HA0000)
                Next '模仿紫岛彩蛋：把音量调到最大～
                My.Computer.Audio.Play(My.Resources.tnnaii_h_island_c, AudioPlayMode.Background)
            Else
                Label_Title.Text = "不要再按啦！( `д´)"
                DoNotClick = True
            End If
        End If
    End Sub

    Private Sub Label_Github_Click(sender As Object, e As EventArgs) Handles Label_Github.Click
        Process.Start("https://github.com/TransparentLC/CloudEmoticon")
    End Sub

    Private Sub Label_CloudEmoticon_Click(sender As Object, e As EventArgs) Handles Label_CloudEmoticon.Click
        Process.Start("https://emoticon.moe/")
    End Sub
End Class