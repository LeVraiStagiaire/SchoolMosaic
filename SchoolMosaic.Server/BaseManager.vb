Imports GSF.Data.Model
Imports MySqlConnector
Imports SchoolMosaic.Server.LocalizationManager

Public Class BaseManager

    Public Shared DBConnection As MySqlConnection
    Public Shared DatabaseLogger As New Logger("Database")

    Public Sub New()
        DatabaseLogger.Debug("Initializing database connection...")
        DBConnection = New MySqlConnection With {
            .ConnectionString = "server=127.0.0.1;uid=root;pwd=0;"
        }
        Try
            DBConnection.Open()
            DBConnection.Close()
            DatabaseLogger.Debug("Database connection successful")
        Catch ex As MySqlException
            DatabaseLogger.Fatal("Database connection failed", ex)
            MessageBox.Show(ex.Message + vbCrLf + ex.SqlState, GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    Public Shared Sub CreateDatabase(Name As String)
        DatabaseLogger.Debug("Creating database " + Name + "...")
        Dim Command As New MySqlCommand("CREATE DATABASE " + Name + ";", DBConnection)
        Try
            Command.ExecuteNonQuery()
            UseDatabase(Name)
            DatabaseLogger.Debug("Database " + Name + " created")
        Catch ex As MySqlException
            DatabaseLogger.Fatal("Database " + Name + " creation failed", ex)
            MessageBox.Show(ex.Message + vbCrLf + ex.SqlState, GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Shared Sub UseDatabase(Name As String)
        Dim Command As New MySqlCommand("USE " + Name + ";", DBConnection)
        Try
            Command.ExecuteNonQuery()
        Catch ex As MySqlException
            DatabaseLogger.Fatal("Database " + Name + " selection failed", ex)
            MessageBox.Show(ex.Message + vbCrLf + ex.SqlState, GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Sub CreateTable(TableName As String, Columns As List(Of Column))
        DatabaseLogger.Debug("Creating table " + TableName + "...")
        Dim Query As String = "CREATE TABLE " + TableName + " ("
        For Each Column As Column In Columns
            Dim Attributes As String = ""
            For Each Attribute As Column.Attribute In Column.Attributes
                Attributes += Attribute.ToString() + " "
            Next
            Query += Column.Name + " " + Column.Type + " " + Attributes + ", "
        Next
        Query = Query.Substring(0, Query.Length - 2) + ");"
        Dim Command As New MySqlCommand(Query, DBConnection)
        Try
            Command.ExecuteNonQuery()
            DatabaseLogger.Debug("Table " + TableName + " created")
        Catch ex As MySqlException
            DatabaseLogger.Fatal("Table " + TableName + " creation failed", ex)
            MessageBox.Show(ex.Message + vbCrLf + ex.SqlState, GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Sub CreateTable(TableName As String, Columns As List(Of Column), Values As List(Of List(Of String)))
        Dim CreateCommand As New MySqlCommand()
        Dim InsertCommand As New MySqlCommand()
        Dim Transaction As MySqlTransaction = DBConnection.BeginTransaction()
        Dim CreateQuery As String = "CREATE TABLE " + TableName + " ("
        For Each Column As Column In Columns
            Dim Attributes As String = ""
            For Each Attribute As Column.Attribute In Column.Attributes
                Attributes += Attribute.ToString() + " "
            Next
            CreateQuery += Column.Name + " " + Column.Type + " " + Attributes + ", "
        Next
        CreateQuery += CreateQuery.Substring(0, CreateQuery.Length - 2) + ");"
        CreateCommand.CommandText = CreateQuery
        CreateCommand.Connection = DBConnection
        CreateCommand.Transaction = Transaction
        CreateCommand.ExecuteNonQuery()
        Dim InsertQuery As String = "INSERT INTO " + TableName + " VALUES "
        For Each Value As List(Of String) In Values
            InsertQuery += "("
            For Each Item As String In Value
                InsertQuery += "'" + Item + "', "
            Next
            InsertQuery = InsertQuery.Substring(0, InsertQuery.Length - 2) + "), "
        Next
        InsertQuery = InsertQuery.Substring(0, InsertQuery.Length - 2) + ";"
        InsertCommand.CommandText = InsertQuery
        InsertCommand.Connection = DBConnection
        InsertCommand.Transaction = Transaction
        InsertCommand.ExecuteNonQuery()
        Transaction.Commit()
    End Sub
End Class

Public Class Column
    Public Name As String
    Public Type As String
    Public Attributes As List(Of Attribute)

    Public Sub New(Name As String, Type As String, Optional Attributes As List(Of Attribute) = Nothing)
        Me.Name = Name
        Me.Type = Type
        Me.Attributes = Attributes
    End Sub

    Public Enum Attribute
        PrimaryKey
        NotNull
        Unique
        AutoIncrement
    End Enum
End Class
