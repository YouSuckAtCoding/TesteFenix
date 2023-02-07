Imports System.Data.SqlClient
Imports ModelLibrary

Public Class CategoriaRepository
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Private Function CreateConnection() As SqlCommand
        Dim constants As Contants = New Contants()
        myConn = New SqlConnection(constants.ConnectionString)
        myCmd = myConn.CreateCommand
        Return myCmd
    End Function

    Public Function GetAllCategorias() As List(Of Categoria)
        Dim Categorias As List(Of Categoria) = New List(Of Categoria)
        myCmd = CreateConnection()
        myCmd.CommandText = "Exec spCategoria_GetAll"
        Try
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            Do While myReader.Read()

                Dim cat As Categoria = New Categoria()
                cat.Id = myReader.GetValue(0)
                cat.Name = myReader.GetValue(1)

                Categorias.Add(cat)

            Loop
        Catch ex As Exception
            Dim message As String = ex.Message
        Finally
            myReader.Close()
            myConn.Close()
        End Try


        Return Categorias
    End Function

    Public Function CreateCategoria(ByVal newCategoria As Categoria) As Boolean
        Dim res As Boolean
        myCmd = CreateConnection()

        Try
            myConn.Open()
            Dim insertCommand As New SqlCommand("Exec spCategoria_Create @name", myConn)
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@name", .SqlDbType = Data.SqlDbType.NVarChar, .Size = 100, .Value = newCategoria.Name})


            insertCommand.ExecuteNonQuery()

        Catch ex As Exception
            Dim message As String = ex.Message
            res = False
        Finally

            myConn.Close()
            res = True
        End Try


        Return res
    End Function

    Public Function GetCategoriaByName(ByVal name As String) As Categoria
        Dim Categorias As List(Of Categoria) = New List(Of Categoria)
        myCmd = CreateConnection()
        myCmd.CommandText = "Exec spCategoria_GetByName " & name
        Try
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            Do While myReader.Read()

                Dim cat As Categoria = New Categoria()
                cat.Id = myReader.GetValue(0)
                cat.Name = myReader.GetValue(1)

                Categorias.Add(cat)

            Loop
        Catch ex As Exception
            Dim message As String = ex.Message
        Finally
            myReader.Close()
            myConn.Close()
        End Try


        Return Categorias.FirstOrDefault()
    End Function
    Public Function DeleteCategoria(ByVal Id As Integer) As Boolean
        Dim res As Boolean
        myCmd = CreateConnection()

        Try
            myConn.Open()
            Dim insertCommand As New SqlCommand("Exec spCategoria_Delete @id", myConn)
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@id", .SqlDbType = Data.SqlDbType.Int, .Value = Id})
            insertCommand.ExecuteNonQuery()

        Catch ex As Exception
            Dim message As String = ex.Message
            res = False
        Finally

            myConn.Close()
            res = True
        End Try
        Return res
    End Function
End Class
