Imports MySql.Data.MySqlClient
Module conn
    Public con As New MySqlConnection

    Sub opencon()
        con.ConnectionString = "server=localhost; username=root; password=; database=company_db"
        con.Open()
    End Sub
End Module
