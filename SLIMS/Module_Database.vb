Imports System.Data.OleDb

Public Class AccessDatabaseReader
    Private connectionString As String

    Public Sub New(databasePath As String)
        ' Konstruktor untuk inisialisasi path database
        Dim provider = "Microsoft.ACE.OLEDB.12.0"
        Dim source = "|datadirectory|/DB_SLIMS.mdb"
        connectionString = "Provider=" & provider & ";Data Source=" & source
    End Sub

    Public Function ReadDataFromTable(tableName As String, columnName As String) As List(Of String)
        Dim result As New List(Of String)

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM " & tableName

            Using command As New OleDbCommand(query, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim columnValue As String = reader(columnName).ToString()
                        result.Add(columnValue)
                    End While
                End Using
            End Using
        End Using

        Return result
    End Function
End Class
