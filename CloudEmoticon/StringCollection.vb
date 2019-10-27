Public Class StringCollection
    Public Property [alias] As String
    Public Property information As String()
    Public Property categories As Category()

    Sub Exchange_Category(Index1 As Integer, Index2 As Integer)
        Dim temp As Category = Categories(Index1)
        Categories(Index1) = Categories(Index2)
        Categories(Index2) = temp
    End Sub

    Sub Add_Category(Item As Category, Optional AfterIndex As Integer = -1)
        Dim New_Category As Category() = {Nothing}
        Array.Resize(New_Category, Categories.Count + 1)

        If AfterIndex <= -1 Then
            Array.Copy(Categories, 0, New_Category, 0, Categories.Count)
            Array.Copy({Item}, 0, New_Category, Categories.Count, 1)
        Else
            Array.Copy(Categories, 0, New_Category, 0, AfterIndex + 1)
            Array.Copy({Item}, 0, New_Category, AfterIndex + 1, 1)
            Array.Copy(Categories.Skip(AfterIndex + 1).ToArray, 0, New_Category, AfterIndex + 2, Categories.Skip(AfterIndex + 1).ToArray.Count)
        End If

        Categories = New_Category
    End Sub

    Sub Delete_Category(Index As Integer)
        Dim New_Category As Category() = {Nothing}
        Array.Resize(New_Category, Categories.Count - 1)

        If Index = 0 Then
            Array.Copy(Categories, 1, New_Category, 0, Categories.Count - 1)
        ElseIf Index = Categories.Count - 1 Then
            Array.Copy(Categories, 0, New_Category, 0, Categories.Count - 1)
        Else
            Array.Copy(Categories, 0, New_Category, 0, Index)
            Array.Copy(Categories, Index + 1, New_Category, Index, Categories.Count - Index - 1)
        End If

        Categories = New_Category
    End Sub
End Class

Public Class entry
    Public Property emoticon As String
    Public Property description As String

    Sub New(Emoticon As String, Description As String)
        Me.Emoticon = Emoticon
        Me.Description = Description
    End Sub
End Class

Public Class category
    Public Property entries As entry()
    Public Property name As String

    Sub New(Entries As entry(), Name As String)
        Me.Entries = Entries
        Me.Name = Name
    End Sub

    Sub Exchange_Entry(Index1 As Integer, Index2 As Integer)
        Dim temp As entry = Entries(Index1)
        Entries(Index1) = Entries(Index2)
        Entries(Index2) = temp
    End Sub

    Sub Add_Entry(Item As entry, Optional AfterIndex As Integer = -1)
        Dim New_Entries As entry() = {Nothing}
        Array.Resize(New_Entries, Entries.Count + 1)

        If AfterIndex <= -1 Then
            Array.Copy(Entries, 0, New_Entries, 0, Entries.Count)
            Array.Copy({Item}, 0, New_Entries, Entries.Count, 1)
        Else
            Array.Copy(Entries, 0, New_Entries, 0, AfterIndex + 1)
            Array.Copy({Item}, 0, New_Entries, AfterIndex + 1, 1)
            Array.Copy(Entries.Skip(AfterIndex + 1).ToArray, 0, New_Entries, AfterIndex + 2, Entries.Skip(AfterIndex + 1).ToArray.Count)
        End If

        Entries = New_Entries
    End Sub

    Sub Delete_Entry(Index As Integer)
        Dim New_Entries As entry() = {Nothing}
        Array.Resize(New_Entries, Entries.Count - 1)

        If Index = 0 Then
            Array.Copy(Entries, 1, New_Entries, 0, Entries.Count - 1)
        ElseIf Index = Entries.Count - 1 Then
            Array.Copy(Entries, 0, New_Entries, 0, Entries.Count - 1)
        Else
            Array.Copy(Entries, 0, New_Entries, 0, Index)
            Array.Copy(Entries, Index + 1, New_Entries, Index, Entries.Count - Index - 1)
        End If

        Entries = New_Entries
    End Sub
End Class