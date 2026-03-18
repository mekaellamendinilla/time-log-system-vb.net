Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class UC_Userlist
    Private Sub UC_Userlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUsers()
    End Sub

    Private Sub txtid_MouseClick(sender As Object, e As MouseEventArgs) Handles txtid.MouseClick
        If txtid.Text = "Search" Then
            txtid.Text = ""
            txtid.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtid_LostFocus(sender As Object, e As EventArgs) Handles txtid.LostFocus
        If txtid.Text = "" Then
            txtid.Text = "Search"
            txtid.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub opencon()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub LoadUsers()
        Try
            opencon()
            Dim query As String = "SELECT User_id, Firstname, Lastname, Email, Position FROM employee_tbl"
            Dim cmd As New MySqlCommand(query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            dgvUserlist.DataSource = table

        Catch ROR As Exception
            MessageBox.Show("Error to load data" & ROR.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgvUserlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserlist.CellContentClick

    End Sub

    Private Sub SearchUsers(searchText As String)
        Try
            opencon()
            'loads all users' 
            'LIKE allows partial matching.' 
            '@search is a parameter that prevents SQL injection attacks'
            Dim query As String = "
            SELECT User_id, Firstname, Lastname, Email, Position
            FROM employee_tbl WHERE Firstname LIKE @search
            OR Lastname LIKE @search OR Email LIKE @search
            OR Position LIKE @search"

            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@search", "%" & searchText & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvUserlist.DataSource = table
        Catch ROR As Exception
            MessageBox.Show("Error while searching" & ROR.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        If txtid.Text = "" Or txtid.Text = "Search" Then
            LoadUsers()
        Else
            SearchUsers(txtid.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvUserlist.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one user to delete.")
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
        "Are you sure you want to delete the selected user(s)?",
        "Confirm Delete",
        MessageBoxButtons.YesNo)

        If confirm = DialogResult.Yes Then
            Try
                opencon()
                Dim deletedCount As Integer = 0
                For Each row As DataGridViewRow In dgvUserlist.SelectedRows
                    Dim userId As Integer = Convert.ToInt32(row.Cells("User_id").Value)
                    Dim query As String = "DELETE FROM employee_tbl WHERE User_id = @id"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@id", userId)
                        deletedCount += cmd.ExecuteNonQuery()
                    End Using
                Next

                MessageBox.Show($"{deletedCount} user(s) deleted successfully.")
                LoadUsers()
            Catch ex As Exception
                MessageBox.Show("Error deleting users: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Public Sub SwitchControl(newUC As UserControl)
        Me.Controls.Clear()
        Me.Controls.Add(newUC)
        newUC.Dock = DockStyle.Fill
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs)
        SwitchControl(New UC_OrganizedUserform)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        SwitchControl(New UC_OrganizedUserform)
    End Sub
End Class
