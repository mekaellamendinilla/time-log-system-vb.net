Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor

Public Class Form2
    Private Sub resetpage()
        txtid.Clear()
        txtpass.Clear()
        txtid.Focus()
    End Sub


    Private Function ValidateEmployee() As Boolean
        Try
            Using con As New MySqlConnection("server=localhost; username=root; password=; database=company_db")
                con.Open()

                Dim query As String = "
                SELECT * FROM employee_tbl
                WHERE User_id = @id AND Password = @pass"

                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", txtid.Text)
                cmd.Parameters.AddWithValue("@pass", txtpass.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                Dim valid As Boolean = reader.HasRows
                reader.Close()

                If Not valid Then
                    MessageBox.Show("Invalid ID or Password.")
                End If

                Return valid
            End Using
        Catch ex As Exception
            MessageBox.Show("Login Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub Timein1_Click_1(sender As Object, e As EventArgs) Handles Timein1.Click
        If Not ValidateEmployee() Then Exit Sub

        Try
            Using con As New MySqlConnection("server=localhost; username=root; password=; database=company_db")
                con.Open()
                Dim checkinfo As New MySqlCommand("
                SELECT COUNT(*) FROM time
                WHERE User_id = @uid 
                AND workdate = CURDATE()", con)

                checkinfo.Parameters.AddWithValue("@uid", txtid.Text)

                Dim count As Integer = Convert.ToInt32(checkinfo.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("You already timed in today!")
                    Exit Sub
                End If

                Dim insertCmd As New MySqlCommand("
                INSERT INTO time(User_id, logintime, workdate)
                VALUES (@uid, @login, @date)", con)

                insertCmd.Parameters.AddWithValue("@uid", txtid.Text)
                insertCmd.Parameters.AddWithValue("@login", DateTime.Now)
                insertCmd.Parameters.AddWithValue("@date", DateTime.Now.Date)

                'insertCmd.Parameters.AddWithValue("@login", DateTime.Now.ToString("hh:mm:ss tt"))
                'insertCmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"))

                insertCmd.ExecuteNonQuery()
                MessageBox.Show("Time-In Recorded")
            End Using

        Catch ex As Exception
            MessageBox.Show("Time-In Error: " & ex.Message)

        Finally
            resetpage()
        End Try
    End Sub

    Private Sub Timeout1_Click_1(sender As Object, e As EventArgs) Handles Timeout1.Click
        If Not ValidateEmployee() Then Exit Sub

        Try
            Using con As New MySqlConnection("server=localhost; username=root; password=; database=company_db")
                con.Open()
                Dim query As String = "
            UPDATE time 
            SET logouttime = @logout
            WHERE user_id = @uid
            AND workdate = @date
            AND logouttime IS NULL"

                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@uid", txtid.Text)
                cmd.Parameters.AddWithValue("@logout", DateTime.Now)
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date)

                'cmd.Parameters.AddWithValue("@logout", DateTime.Now.ToString("hh:mm:ss tt"))
                'cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd "))

                Dim rows = cmd.ExecuteNonQuery()

                If rows > 0 Then
                    MessageBox.Show("Time-Out Recorded")
                Else
                    MessageBox.Show("no Time-In found!")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Time-Out Error" & ex.Message)

        Finally
            resetpage()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f3 As New form3
        f3.Show()
        Me.Dispose()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Time1.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Date1.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub
End Class
