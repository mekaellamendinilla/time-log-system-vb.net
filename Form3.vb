Imports MySql.Data.MySqlClient

Public Class form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f2 As New Form2
        f2.Show()
        Me.Close()
    End Sub


    Private Function ValidateAdmin() As Boolean
        Try
            Using con As New MySqlConnection("server=localhost; username=root; password=; database=company_db")
                con.Open()
                Dim query As String = "
            SELECT * FROM admin_tbl 
            WHERE Username = @username AND Password_hash = @pass"

                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@username", txtuser.Text)
                cmd.Parameters.AddWithValue("@pass", txtpass.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    reader.Close()
                    Return True
                Else
                    reader.Close()
                    MessageBox.Show("Invalid Username or Password.")
                    Return False
                End If
            End Using

        Catch ROR As Exception
            MessageBox.Show("Login Error: " & ROR.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ValidateAdmin() Then
            Exit Sub
        Else
            Dim f1 As New Form1
            f1.Show()
            Dim f2 As New Form2
            f2.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class