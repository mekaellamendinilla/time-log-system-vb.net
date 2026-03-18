Imports MySql.Data.MySqlClient

Public Class UC_LogHistory

    Private Sub UC_LogHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLogHistory(txtdatfilter.Value.Date, "")
        LoadLogHistory()
        dgvLogHistory.Columns("TimeIn").DefaultCellStyle.Format = "hh:mm tt"
        dgvLogHistory.Columns("TimeOut").DefaultCellStyle.Format = "hh:mm tt"
    End Sub

    Private Sub LoadLogHistory(Optional filterDate As Date? = Nothing, Optional searchText As String = "")
        Try
            Using con As New MySqlConnection("server=localhost; username=root; password=; database=company_db")
                con.Open()

                Dim query As String = "
                    SELECT 
                    e.User_id AS ID,
                    CONCAT(e.Firstname, ' ', e.Middle_name, ' ', e.Lastname) AS FullName,
                    t.workdate AS Date,
                    t.logintime AS TimeIn,
                    t.logouttime AS TimeOut,
                    TIMESTAMPDIFF(HOUR, t.logintime, t.logouttime) AS TotalHours
                    FROM employee_tbl e
                    JOIN Time t ON e.User_id = t.User_id
                    WHERE t.logintime IS NOT NULL
                    AND t.logouttime IS NOT NULL
                    AND (@filterDate IS NULL OR t.workdate = @filterDate)
                    AND (@searchText = '' OR 
                    CONCAT(e.Firstname, ' ', e.Middle_name, ' ', e.Lastname) LIKE @searchLike
                    OR e.Firstname LIKE @searchLike
                    OR e.Middle_name LIKE @searchLike
                    OR e.Lastname LIKE @searchLike)
                    ORDER BY t.workdate DESC"

                Using cmd As New MySqlCommand(query, con)

                    If filterDate.HasValue Then
                        cmd.Parameters.AddWithValue("@filterDate", filterDate.Value)
                    Else
                        cmd.Parameters.AddWithValue("@filterDate", DBNull.Value)
                    End If
                    cmd.Parameters.AddWithValue("@searchText", searchText.Trim())
                    cmd.Parameters.AddWithValue("@searchLike", "%" & searchText.Trim() & "%")

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvLogHistory.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading log history: " & ex.Message)
        End Try
    End Sub

    Private Sub txtdatfilter_ValueChanged(sender As Object, e As EventArgs) Handles txtdatfilter.ValueChanged
        LoadLogHistory(txtdatfilter.Value.Date, txtsearch.Text)
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        LoadLogHistory(txtdatfilter.Value.Date, txtsearch.Text)
    End Sub

    Private Sub dgvLogHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogHistory.CellContentClick

    End Sub
End Class
