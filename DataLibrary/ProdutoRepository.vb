Imports System.Data
Imports System.Data.SqlClient
Imports ModelLibrary

Public Class ProdutoRepository

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Private Function CreateConnection() As SqlCommand
        Dim constants As Contants = New Contants()
        myConn = New SqlConnection(constants.ConnectionString)
        myCmd = myConn.CreateCommand
        Return myCmd
    End Function
    Public Function GetAllProdutos() As DataSet
        Dim Products As List(Of Produto) = New List(Of Produto)
        myCmd = CreateConnection()
        myCmd.CommandText = "Exec spProduto_GetAll"
        Dim ds As DataSet = New DataSet()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter("Exec spProduto_GetAll", myConn)
        adapter.Fill(ds, "Produto")


        myConn.Close()



        Return ds
    End Function
    Public Function GetProdutosByCategoria(ByVal categoria As Integer) As DataSet
        Dim Products As List(Of Produto) = New List(Of Produto)
        myCmd = CreateConnection()
        Dim ds As DataSet = New DataSet()
        Dim adapter As SqlDataAdapter = New SqlDataAdapter("Exec spProduto_GetByCategoria " & categoria, myConn)
        adapter.Fill(ds, "Produto")


        myConn.Close()



        Return ds
    End Function
    Public Function GetProdutoById(ByVal id As Integer) As Produto
        Dim Products As List(Of Produto) = New List(Of Produto)
        myCmd = CreateConnection()
        myCmd.CommandText = "Exec spProduto_GetById " & id
        Try
            myConn.Open()
            myReader = myCmd.ExecuteReader()
            Do While myReader.Read()

                Dim prod As Produto = New Produto()
                prod.Id = myReader.GetValue(0)
                prod.Name = myReader.GetValue(1)
                prod.PublishDate = myReader.GetValue(2)
                prod.Description = myReader.GetValue(3)
                prod.Category = myReader.GetValue(4)
                prod.Image = myReader.GetValue(5)
                prod.Price = myReader.GetValue(6)
                prod.Brand = myReader.GetValue(7)
                Products.Add(prod)
            Loop
        Catch ex As Exception

        Finally
            myReader.Close()
            myConn.Close()
        End Try


        Return Products.FirstOrDefault()
    End Function

    Public Function CreateProduto(ByVal newInstrumento As Produto) As Boolean
        Dim res As Boolean
        myCmd = CreateConnection()

        Try
            myConn.Open()
            Dim insertCommand As New SqlCommand("Exec spProduto_Create @name, @date, @description,
                                                @category,@image, @price, @brand", myConn)
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@name", .SqlDbType = Data.SqlDbType.NVarChar, .Size = 100, .Value = newInstrumento.Name})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@date", .SqlDbType = Data.SqlDbType.DateTime, .Value = newInstrumento.PublishDate})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@description", .SqlDbType = Data.SqlDbType.NVarChar, .Size = 200, .Value = newInstrumento.Description})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@category", .SqlDbType = Data.SqlDbType.Int, .Size = 20, .Value = newInstrumento.Category})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@image", .SqlDbType = Data.SqlDbType.NVarChar, .Size = 20, .Value = newInstrumento.Image})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@price", .SqlDbType = Data.SqlDbType.Money, .Value = newInstrumento.Price})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@brand", .SqlDbType = Data.SqlDbType.NVarChar, .Size = 20, .Value = newInstrumento.Brand})
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

    Public Function UpdateProduto(ByVal id As Integer, ByVal newInstrumento As Produto)
        Dim res As Boolean
        myCmd = CreateConnection()

        Try
            myConn.Open()
            Dim insertCommand As New SqlCommand("Exec spProduto_Update @id, @name, @date, @description,
                                                @category,@image, @price, @brand", myConn)
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@id", .SqlDbType = Data.SqlDbType.Int, .Value = id})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@name", .SqlDbType = Data.SqlDbType.NVarChar, .Size = 100, .Value = newInstrumento.Name})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@date", .SqlDbType = Data.SqlDbType.DateTime, .Value = newInstrumento.PublishDate})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@description", .SqlDbType = Data.SqlDbType.NVarChar, .Size = 200, .Value = newInstrumento.Description})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@category", .SqlDbType = Data.SqlDbType.Int, .Size = 20, .Value = newInstrumento.Category})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@image", .SqlDbType = Data.SqlDbType.NVarChar, .Size = 20, .Value = newInstrumento.Image})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@price", .SqlDbType = Data.SqlDbType.Money, .Value = newInstrumento.Price})
            insertCommand.Parameters.Add(New SqlParameter With {.ParameterName = "@brand", .SqlDbType = Data.SqlDbType.NVarChar, .Size = 20, .Value = newInstrumento.Brand})
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
    Public Function DeleteProduto(ByVal Id As Integer) As Boolean
        Dim res As Boolean
        myCmd = CreateConnection()

        Try
            myConn.Open()
            Dim insertCommand As New SqlCommand("Exec spProduto_Delete @id", myConn)
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
