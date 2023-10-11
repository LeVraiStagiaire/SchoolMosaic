Imports GSF.Data
Imports GSF.Data.Model
Imports MySqlConnector
Imports SchoolMosaic.Server.LocalizationManager

Public Class BaseManager

    Public Shared DBConnection As MySqlConnection
    Public Shared DatabaseLogger As New Logger("Database")

    ''' <summary>
    ''' Create a new instance of the BaseManager class
    ''' </summary>
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

    ''' <summary>
    ''' Open connection to database
    ''' </summary>
    Public Shared Sub OpenDatabase()
        DBConnection.Open()
    End Sub

    ''' <summary>
    ''' Close connection to database
    ''' </summary>
    Public Shared Sub CloseDatabase()
        DBConnection.Close()
    End Sub

    ''' <summary>
    ''' Create a new database
    ''' </summary>
    ''' <param name="Name">Database name</param>
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

    ''' <summary>
    ''' Set current database
    ''' </summary>
    ''' <param name="Name">Database name</param>
    Public Shared Sub UseDatabase(Name As String)
        Dim Command As New MySqlCommand("USE " + Name + ";", DBConnection)
        Try
            Command.ExecuteNonQuery()
        Catch ex As MySqlException
            DatabaseLogger.Fatal("Database " + Name + " selection failed", ex)
            MessageBox.Show(ex.Message + vbCrLf + ex.SqlState, GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Create a table in the current database
    ''' </summary>
    ''' <param name="TableName">Name of the table</param>
    ''' <param name="Columns">List of columns to add to the table</param>
    Public Shared Sub CreateTable(TableName As String, Columns As List(Of Column))
        Dim Query As String = "CREATE TABLE " + TableName + " ("
        For Each Column As Column In Columns
            Dim Attributes As String = ""
            For Each Attribute As Column.Attribute In Column.Attributes
                If Attribute = Column.Attribute.AutoIncrement Then
                    Attributes += "AUTO_INCREMENT "
                ElseIf Attribute = Column.Attribute.NotNull Then
                    Attributes += "NOT NULL "
                ElseIf Attribute = Column.Attribute.PrimaryKey Then
                    Attributes += "PRIMARY KEY "
                ElseIf Attribute = Column.Attribute.Unique Then
                    Attributes += "UNIQUE "
                End If
            Next
            Attributes = Attributes.Substring(0, Attributes.Length - 1)
            Query += Column.Name + " " + Column.Type + " " + Attributes + ", "
        Next
        Query = Query.Substring(0, Query.Length - 2) + ");"
        DatabaseLogger.Debug("Executing query: " + Query)
        Dim Command As New MySqlCommand(Query, DBConnection)
        Try
            Command.ExecuteNonQuery()
            DatabaseLogger.Debug("Table " + TableName + " created")
        Catch ex As MySqlException
            DatabaseLogger.Fatal("Table " + TableName + " creation failed", ex)
            MessageBox.Show(ex.Message + vbCrLf + ex.SqlState, GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Create a table in the current database and insert values
    ''' </summary>
    ''' <param name="TableName">Name of the table</param>
    ''' <param name="Columns">List of columns to add to the table</param>
    ''' <param name="Values">List of values to insert</param>
    Public Shared Sub CreateTable(TableName As String, Columns As List(Of Column), Values As List(Of List(Of String)))
        Dim CreateCommand As New MySqlCommand()
        Dim InsertCommand As New MySqlCommand()
        Dim Transaction As MySqlTransaction = DBConnection.BeginTransaction()
        Dim CreateQuery As String = "CREATE TABLE " + TableName + " ("
        For Each Column As Column In Columns
            Dim Attributes As String = ""
            For Each Attribute As Column.Attribute In Column.Attributes
                If Attribute = Column.Attribute.AutoIncrement Then
                    Attributes += "AUTO_INCREMENT "
                ElseIf Attribute = Column.Attribute.NotNull Then
                    Attributes += "NOT NULL "
                ElseIf Attribute = Column.Attribute.PrimaryKey Then
                    Attributes += "PRIMARY KEY "
                ElseIf Attribute = Column.Attribute.Unique Then
                    Attributes += "UNIQUE "
                End If
            Next
            Attributes = Attributes.Substring(0, Attributes.Length - 1)
            CreateQuery += Column.Name + " " + Column.Type + " " + Attributes + ", "
        Next
        CreateQuery = CreateQuery.Substring(0, CreateQuery.Length - 2) + ");"
        DatabaseLogger.Debug("Adding query: " + CreateQuery)
        CreateCommand.CommandText = CreateQuery
        CreateCommand.Connection = DBConnection
        CreateCommand.Transaction = Transaction
        CreateCommand.ExecuteNonQuery()
        DatabaseLogger.Debug("Sucess!")
        Dim InsertQuery As String = "INSERT INTO " + TableName + " VALUES "
        For Each Value As List(Of String) In Values
            InsertQuery += "("
            For Each Item As String In Value
                If Item = "NULL" Then
                    InsertQuery += Item + ", "
                Else
                    InsertQuery += "'" + Item + "', "
                End If
            Next
            InsertQuery = InsertQuery.Substring(0, InsertQuery.Length - 2) + "), "
        Next
        InsertQuery = InsertQuery.Substring(0, InsertQuery.Length - 2) + ";"
        DatabaseLogger.Debug("Adding query: " + InsertQuery)
        InsertCommand.CommandText = InsertQuery
        InsertCommand.Connection = DBConnection
        InsertCommand.Transaction = Transaction
        InsertCommand.ExecuteNonQuery()
        DatabaseLogger.Debug("Sucess!")
        DatabaseLogger.Debug("Commiting transaction...")
        Transaction.Commit()
        DatabaseLogger.Debug("Transaction commited")
    End Sub

    Public Shared Sub AddReferences(Table As String, References As List(Of Reference))
        For Each Reference As Reference In References
            Dim Query As String = "ALTER Table " + Table + " ADD CONSTRAINT FK_" + Table + "_" + Reference.Column + "_" + Reference.ForeignTable + "_" + Reference.ForeignColumn + " FOREIGN KEY (" + Reference.Column + ") REFERENCES " + Reference.ForeignTable + "(" + Reference.ForeignColumn + "), "
            Query = Query.Substring(0, Query.Length - 2) + ";"
            DatabaseLogger.Debug("Executing query: " + Query)
            Dim Command As New MySqlCommand(Query, DBConnection)
            Try
                Command.ExecuteNonQuery()
                DatabaseLogger.Debug("References added")
            Catch ex As MySqlException
                DatabaseLogger.Fatal("References addition failed", ex)
                MessageBox.Show(ex.Message + vbCrLf + ex.SqlState, GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next
    End Sub

    Public Shared Function GetBases() As List(Of String)
        Dim Dbs As New List(Of String)
        Dim DBsQuery As String = "SHOW DATABASES;"
        Dim DBsResult As IDataReader = DBConnection.ExecuteReader(DBsQuery)
        While DBsResult.Read
            If DBsResult.GetValue(0).ToString.StartsWith("sm_") Then
                Dbs.Add(DBsResult.GetValue(0).ToString.Substring(3))
            End If
        End While
        DBsResult.Close()
        Return Dbs
    End Function

    Public Shared Function GetConfig(ConfigName As String)
        Dim Query As String = "SELECT * FROM config WHERE name='" + ConfigName + "';"
        Dim Result As IDataReader = DBConnection.ExecuteReader(Query)
        While Result.Read
            Dim ReturnResult = Result.GetValue(2)
            Result.Close()
            Return ReturnResult
        End While
        Result.Close()
        DatabaseLogger.Error("No key found for " + ConfigName)
        Return New KeyNotFoundException("No key found for " + ConfigName)
    End Function

    Public Shared Sub SetConfig(ConfigName As String, Value As String)
        Dim Query As String = "UPDATE config SET value='" + Value + "' WHERE name='" + ConfigName + "';"
        Dim Command As New MySqlCommand(Query, DBConnection)
        Try
            Command.ExecuteNonQuery()
            DatabaseLogger.Debug("Config '" + ConfigName + "' changed to '" + Value + "'")
        Catch ex As Exception
            DatabaseLogger.Fatal("Error while changing '" + ConfigName + "'!", ex)
            MessageBox.Show("Une erreur est survenue lors de la modification de la configuration !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

Public Class Reference
    Public Column As String
    Public ForeignTable As String
    Public ForeignColumn As String

    Public Sub New(Column As String, ForeignTable As String, ForeignColumn As String)
        Me.Column = Column
        Me.ForeignTable = ForeignTable
        Me.ForeignColumn = ForeignColumn
    End Sub
End Class