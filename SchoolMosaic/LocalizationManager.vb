Public Class LocalizationManager

    Shared Resource As Resources.ResXResourceSet

    Public Shared Sub InitLanguage(Language As String)
        Select Case Language
            Case "fr"
                Resource = New Resources.ResXResourceSet(IO.Directory.GetCurrentDirectory() + "\Languages\Language.French.resx")
            Case "en"
                Throw New NotImplementedException("Language not supported at this time.")
            Case "de"
                Throw New NotImplementedException("Language not supported at this time.")
            Case Else
                Throw New NotImplementedException("Only French is supported at this time.")
        End Select
    End Sub

    Public Shared Function GetString(Key As String) As String
        Return Resource.GetString(Key)
    End Function

End Class
