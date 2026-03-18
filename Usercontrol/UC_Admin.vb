Imports MySql.Data.MySqlClient

Public Class UC_Admin
    Private Sub UC_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadattendance()
    End Sub
    Private Sub pnlAdmin_Paint(sender As Object, e As PaintEventArgs) Handles pnlAdmin.Paint

    End Sub
    Private Sub LoadAttendance()
        Try
            Using con As New MySqlConnection("server=localhost; username=root; password=; database=company_db")
                con.Open()

                Dim query As String = "
                SELECT 
                    CONCAT(e.Firstname, ' ', e.Lastname) AS Name,
                    SUM(CASE WHEN t.logintime IS NOT NULL THEN 1 ELSE 0 END) AS Present,
                    SUM(CASE WHEN t.logintime IS NULL THEN 1 ELSE 0 END) AS Absent,
                    SUM(
                        CASE
                            WHEN TIME(t.logintime) > '07:05:00' AND TIME(t.logintime) < '12:00:00' THEN 1
                            WHEN TIME(t.logintime) > '19:05:00' AND TIME(t.logintime) <= '23:59:59' THEN 1
                            ELSE 0
                        END
                    ) AS Late,
                    COUNT(t.workdate) AS 'Total Present'
                FROM employee_tbl e
                LEFT JOIN Time t ON e.User_id = t.User_id
                GROUP BY e.User_id, e.Firstname, e.Lastname
                ORDER BY e.Lastname"

                Dim adapter As New MySqlDataAdapter(query, con)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dgv1TotalPresent.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading attendance: " & ex.Message)
        End Try
    End Sub

    Private Sub searchname(search As String)
        Try
            Using con As New MySqlConnection("server=localhost; username=root; password=; database=company_db")
                con.Open()

                Dim query As String = "
                SELECT 
                    CONCAT(e.Firstname, ' ', e.Lastname) AS Name,
                    SUM(CASE WHEN t.logintime IS NOT NULL THEN 1 ELSE 0 END) AS Present,
                    SUM(CASE WHEN t.logintime IS NULL THEN 1 ELSE 0 END) AS Absent,
                    SUM(
                        CASE
                            WHEN TIME(t.logintime) > '07:05:00' AND TIME(t.logintime) < '12:00:00' THEN 1
                            WHEN TIME(t.logintime) > '19:05:00' AND TIME(t.logintime) <= '23:59:59' THEN 1
                            ELSE 0
                        END
                    ) AS Late,
                    COUNT(t.workdate) AS 'Total Present'
                FROM employee_tbl e
                LEFT JOIN Time t ON e.User_id = t.User_id
                WHERE CONCAT(e.Firstname, ' ', e.Lastname) LIKE @search
                GROUP BY e.User_id, e.Firstname, e.Lastname
                ORDER BY e.Lastname"

                Dim adapter As New MySqlDataAdapter(query, con)
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & search & "%")

                Dim dt As New DataTable()
                adapter.Fill(dt)

                dgv1TotalPresent.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearchForAdmin_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSearchForAdmin.MouseClick
        If txtSearchForAdmin.Text = "Search" Then
            txtSearchForAdmin.Text = ""
            txtSearchForAdmin.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchForAdmin_LostFocus(sender As Object, e As EventArgs) Handles txtSearchForAdmin.LostFocus
        If txtSearchForAdmin.Text = "" Then
            txtSearchForAdmin.Text = "Search"
            txtSearchForAdmin.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtSearchForAdmin_TextChanged(sender As Object, e As EventArgs) Handles txtSearchForAdmin.TextChanged
        If txtSearchForAdmin.Text.Trim() = "" Or txtSearchForAdmin.Text = "Search" Then
            Exit Sub
        Else
            searchname(txtSearchForAdmin.Text)
        End If
    End Sub

    Private Sub dgv2TotalEmployees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 
    End Sub


End Class
