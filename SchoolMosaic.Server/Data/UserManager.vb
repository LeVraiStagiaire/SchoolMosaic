Imports GSF.Data
Imports MySqlConnector

Public Class UserManager

    Private Shared DBConnection As MySqlConnection = BaseManager.DBConnection

    Public Shared Function CheckAdminPassword(Username As String, Password As String) As Boolean
        Dim Query As String = "SELECT * FROM users WHERE username='" + Username + "';"
        Dim Result As IDataReader = DBConnection.ExecuteReader(Query)
        While Result.Read()
            If Result.GetString(3) = "admin" And Password = Result.GetString(2) Then
                Result.Close()
                Return True
            End If
        End While
        Result.Close()
        Return False
    End Function

End Class
