Public Module Module_Skin
    Public Skin_Custom As New Skin(New Bitmap(840, 400),
                                   Color.FromArgb(255, 0, 0, 0),
                                   Color.FromArgb(255, 255, 255, 255),
                                   Color.FromArgb(255, 127, 127, 127))
    Public Skin_Akari As New Skin(My.Resources.Akari,
                                Color.FromArgb(255, 112, 108, 107),
                                Color.FromArgb(255, 235, 235, 235),
                                Color.FromArgb(255, 170, 170, 170))
    Public Skin_Material As New Skin(My.Resources.Material,
                                Color.FromArgb(255, 250, 250, 250),
                                Color.FromArgb(255, 68, 68, 68),
                                Color.FromArgb(255, 153, 153, 153))
    Public Skin_Scorpio As New Skin(My.Resources.Scorpio,
                                Color.FromArgb(255, 0, 0, 0),
                                Color.FromArgb(255, 216, 216, 216),
                                Color.FromArgb(255, 96, 96, 96))
    Public Skin_Catwalk As New Skin(My.Resources.Catwalk,
                                Color.FromArgb(255, 35, 53, 65),
                                Color.FromArgb(255, 250, 250, 250),
                                Color.FromArgb(255, 91, 122, 146))
    Public Skin_Sagiri As New Skin(My.Resources.Sagiri,
                                Color.FromArgb(255, 92, 182, 189),
                                Color.FromArgb(255, 250, 250, 250),
                                Color.FromArgb(255, 170, 231, 236))
    Public Skin_KotoHonoUmi As New Skin(My.Resources.KotoHonoUmi,
                                Color.FromArgb(255, 183, 139, 94),
                                Color.FromArgb(255, 250, 250, 250),
                                Color.FromArgb(255, 231, 195, 157))

    Public Enum SkinID
        Custom
        Akari
        Material
        Scorpio
        Catwalk
        Sagiri
        KotoHonoUmi
    End Enum

    Public Function GetSkinFromID(SkinID As SkinID) As Skin
        Select Case SkinID
            Case SkinID.Custom
                Return Skin_Custom
            Case SkinID.Akari
                Return Skin_Akari
            Case SkinID.Material
                Return Skin_Material
            Case SkinID.Scorpio
                Return Skin_Scorpio
            Case SkinID.Catwalk
                Return Skin_Catwalk
            Case SkinID.Sagiri
                Return Skin_Sagiri
            Case SkinID.KotoHonoUmi
                Return Skin_KotoHonoUmi
            Case Else
                Return Nothing
        End Select
    End Function

    Public Structure Skin
        Dim BackgroundImage As Bitmap '上方的横幅图
        Dim BackgroundColor As Color '背景颜色
        Dim TextPrimaryColor As Color '文字主颜色
        Dim TextSecondaryColor As Color '文字副颜色
        Sub New(BackgroundImage As Bitmap, BackgroundColor As Color, TextPrimaryColor As Color, TextSecondaryColor As Color)
            Me.BackgroundImage = BackgroundImage
            Me.BackgroundColor = BackgroundColor
            Me.TextPrimaryColor = TextPrimaryColor
            Me.TextSecondaryColor = TextSecondaryColor
        End Sub
    End Structure
End Module
