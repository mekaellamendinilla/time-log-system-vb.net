Imports MySql.Data.MySqlClient

Public Class UC_OrganizedUserform
    Private pictureChanged As Boolean = False
    Private originalPictureBytes As Byte() = Nothing

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtgender.SelectedIndexChanged

    End Sub

    Private Function BytesToImage(bytes As Byte()) As Image
        Try
            Using ms As New IO.MemoryStream(bytes)
                Return Image.FromStream(ms)
            End Using
        Catch
            Return Nothing
        End Try
    End Function

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        If String.IsNullOrEmpty(txtid.Text) Then
            txtfname.Clear()
            txtmname.Clear()
            txtlastn.Clear()
            txtaddress.Clear()
            txtage.Clear()
            txtcontact.Clear()
            txtemail.Clear()
            txtnation.Clear()
            txtbirth.ResetText()
            txtgender.ResetText()
            txtstatus.ResetText()
            txtcurpass.Clear()
            txtposition.Clear()
            PictureBox1.Image = Nothing
            pictureChanged = False
            originalPictureBytes = Nothing
        End If
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim query As String = "SELECT * FROM employee_tbl WHERE User_id = @id"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", txtid.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader

            If reader.Read() Then
                txtfname.Text = If(IsDBNull(reader("Firstname")), "", reader("Firstname").ToString())
                txtmname.Text = If(IsDBNull(reader("Middle_name")), "", reader("Middle_name").ToString())
                txtlastn.Text = If(IsDBNull(reader("Lastname")), "", reader("Lastname").ToString())
                txtemail.Text = If(IsDBNull(reader("Email")), "", reader("Email").ToString())
                txtage.Text = If(IsDBNull(reader("Age")), "", reader("Age").ToString())
                txtgender.Text = If(IsDBNull(reader("Gender")), "", reader("Gender").ToString())

                If Not IsDBNull(reader("Birthday")) Then
                    txtbirth.Value = Convert.ToDateTime(reader("Birthday"))
                Else
                    txtbirth.Value = DateTime.Today
                End If

                txtnation.Text = reader("Nationality").ToString()
                txtaddress.Text = reader("Address").ToString()
                txtcontact.Text = reader("Contact_number").ToString()
                txtposition.Text = reader("Position").ToString()
                txtcurpass.Text = reader("Password").ToString()
                txtstatus.Text = reader("Civil_Status").ToString()

                If Not IsDBNull(reader("Pictures")) Then
                    Dim pic As Byte() = CType(reader("Pictures"), Byte())
                    originalPictureBytes = pic
                    PictureBox1.Image = BytesToImage(pic)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    originalPictureBytes = Nothing
                    PictureBox1.Image = Nothing
                End If

                pictureChanged = False

            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub pnlPersonalInformation_Paint(sender As Object, e As PaintEventArgs) Handles pnlPersonalInformation.Paint

    End Sub

    Private Function ImageToBytes(pic As PictureBox) As Byte()
        If pic.Image Is Nothing Then Return Nothing
        Using bmp As New Bitmap(pic.Image)
            Using pt As New IO.MemoryStream
                bmp.Save(pt, System.Drawing.Imaging.ImageFormat.Png)
                Return pt.ToArray()
            End Using
        End Using
    End Function

    Private Function EmployeeExistsByID(id As String) As Boolean
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM employee_tbl WHERE User_id=@id", con)
        cmd.Parameters.AddWithValue("@id", id)
        Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
    End Function

    Private Function EmployeeExistsByName(fname As String, mname As String, lname As String) As Boolean
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM employee_tbl WHERE Firstname=@fname AND Middle_name=@mname AND Lastname=@lname", con)
        cmd.Parameters.AddWithValue("@fname", fname)
        cmd.Parameters.AddWithValue("@mname", mname)
        cmd.Parameters.AddWithValue("@lname", lname)
        Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
    End Function

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim imgBytes As Byte() = If(pictureChanged, ImageToBytes(PictureBox1), originalPictureBytes)

            If EmployeeExistsByID(txtid.Text) Then
                Dim updateQuery As String =
                "UPDATE employee_tbl SET 
                Firstname=@fn, Middle_name=@mn, Lastname=@ln,
                Email=@em, Age=@age, Gender=@gen, Birthday=@bday,
                Nationality=@nat, Address=@addr, Contact_number=@contact,
                Civil_Status=@status, Pictures=@pic, Position=@pos
                WHERE User_id=@id"

                Dim cmd As New MySqlCommand(updateQuery, con)


                cmd.Parameters.AddWithValue("@fn", txtfname.Text)
                cmd.Parameters.AddWithValue("@mn", txtmname.Text)
                cmd.Parameters.AddWithValue("@ln", txtlastn.Text)
                cmd.Parameters.AddWithValue("@em", txtemail.Text)
                cmd.Parameters.AddWithValue("@age", txtage.Text)
                cmd.Parameters.AddWithValue("@gen", txtgender.Text)
                cmd.Parameters.AddWithValue("@bday", txtbirth.Value)
                cmd.Parameters.AddWithValue("@nat", txtnation.Text)
                cmd.Parameters.AddWithValue("@addr", txtaddress.Text)
                cmd.Parameters.AddWithValue("@contact", txtcontact.Text)
                cmd.Parameters.AddWithValue("@status", txtstatus.Text)
                cmd.Parameters.AddWithValue("@po", txtposition.Text)
                cmd.Parameters.AddWithValue("@pic", imgBytes)
                cmd.Parameters.AddWithValue("@id", txtid.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Record Updated Successfully!")
                pictureChanged = False
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        Finally
            con.Close()
        End Try
    End Sub

    Private Sub changepic_Click(sender As Object, e As EventArgs) Handles changepic.Click
        Dim ofp As New OpenFileDialog
        ofp.Filter = "Image|*.jpg;*.jpeg;*.png;*.bmp"

        If ofp.ShowDialog() = DialogResult.OK Then
            Using fs As New IO.FileStream(ofp.FileName, IO.FileMode.Open, IO.FileAccess.Read)
                PictureBox1.Image = Image.FromStream(fs)
            End Using
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            pictureChanged = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub create_new_Click(sender As Object, e As EventArgs) Handles create_new.Click
        Try
            If String.IsNullOrEmpty(fname.Text) Or String.IsNullOrEmpty(lname.Text) Then
                MessageBox.Show("Please fill in all the requirements.")
                Return
            End If

            If String.IsNullOrEmpty(createpass.Text) Then
                MessageBox.Show("Please enter a password.")
                Return
            End If

            If createpass.Text <> curpass.Text Then
                MessageBox.Show("Passwords do not match.")
                Return
            End If

            If EmployeeExistsByName(fname.Text, mname.Text, lname.Text) Then
                MessageBox.Show("An employee with this name already exists!")
                Return
            End If

            If con.State = ConnectionState.Closed Then con.Open()

            Dim insertQuery As String =
        "INSERT INTO employee_tbl 
        (Firstname, Middle_name, Lastname, Email, Age, Gender,
         Birthday, Nationality, Address, Contact_number, Civil_Status, Position, Password)
        VALUES 
        (@fn, @mn, @ln, @em, @age, @gen, @bday, @nat, @addr, @contact, @status, @pos, @pass)"

            Dim cmd As New MySqlCommand(insertQuery, con)

            cmd.Parameters.AddWithValue("@fn", fname.Text)
            cmd.Parameters.AddWithValue("@mn", mname.Text)
            cmd.Parameters.AddWithValue("@ln", lname.Text)
            cmd.Parameters.AddWithValue("@em", email.Text)
            cmd.Parameters.AddWithValue("@age", age.Text)
            cmd.Parameters.AddWithValue("@gen", gender.Text)
            cmd.Parameters.AddWithValue("@bday", birthday.Value)
            cmd.Parameters.AddWithValue("@nat", nation.Text)
            cmd.Parameters.AddWithValue("@addr", address.Text)
            cmd.Parameters.AddWithValue("@contact", contact.Text)
            cmd.Parameters.AddWithValue("@status", status.Text)
            cmd.Parameters.AddWithValue("@pos", position.Text)
            cmd.Parameters.AddWithValue("@pass", createpass.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("New Employee Created!")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        Finally
            fname.Clear()
            mname.Clear()
            lname.Clear()
            address.Clear()
            age.Clear()
            contact.Clear()
            email.Clear()
            nation.Clear()
            birthday.ResetText()
            gender.ResetText()
            status.ResetText()
            position.Clear()
            createpass.Clear()
            curpass.Clear()
            con.Close()
        End Try
    End Sub

    Private Sub createpass_TextChanged(sender As Object, e As EventArgs) Handles createpass.TextChanged

    End Sub

    Private Sub curpass_TextChanged(sender As Object, e As EventArgs) Handles curpass.TextChanged

    End Sub

    Private Sub showpass_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked Then
            createpass.UseSystemPasswordChar = False
            curpass.UseSystemPasswordChar = False
        Else
            createpass.UseSystemPasswordChar = True
            curpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtnewpass.UseSystemPasswordChar = False
            txtcurpass.UseSystemPasswordChar = False
            txtconpass.UseSystemPasswordChar = False
        Else
            txtnewpass.UseSystemPasswordChar = True
            txtcurpass.UseSystemPasswordChar = True
            txtconpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If String.IsNullOrEmpty(txtnewpass.Text) Then
            MessageBox.Show("Please enter a password.")
            Return
        End If

        If txtnewpass.Text <> txtconpass.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        If String.IsNullOrEmpty(txtid.Text) Then
            MessageBox.Show("No user selected to update password.")
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show(
        "Are you sure you want to Change your current password?.d",
        "Confirm Change",
        MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            Try
                If con.State = ConnectionState.Closed Then con.Open()
                Dim updateQuery As String = "UPDATE employee_tbl SET Password=@pass WHERE User_id=@id"
                Using cmd As New MySqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@pass", txtnewpass.Text)
                    cmd.Parameters.AddWithValue("@id", txtid.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Password updated successfully!")
                        txtnewpass.Clear()
                        txtconpass.Clear()
                    Else
                        MessageBox.Show("No user found with this ID.")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtnewpass.Clear()
        txtconpass.Clear()
    End Sub

    Private Sub email_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged

    End Sub

    Private Sub nation_TextChanged(sender As Object, e As EventArgs) Handles nation.TextChanged

    End Sub

    Private Sub status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status.SelectedIndexChanged

    End Sub

    Private Sub age_TextChanged(sender As Object, e As EventArgs) Handles age.TextChanged

    End Sub

    Private Sub contact_TextChanged(sender As Object, e As EventArgs) Handles contact.TextChanged

    End Sub

    Private Sub address_TextChanged(sender As Object, e As EventArgs) Handles address.TextChanged

    End Sub

    Private Sub fname_TextChanged(sender As Object, e As EventArgs) Handles fname.TextChanged

    End Sub

    Private Sub mname_TextChanged(sender As Object, e As EventArgs) Handles mname.TextChanged

    End Sub

    Private Sub lname_TextChanged(sender As Object, e As EventArgs) Handles lname.TextChanged

    End Sub

    Private Sub position_TextChanged(sender As Object, e As EventArgs) Handles position.TextChanged

    End Sub

    Private Sub gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gender.SelectedIndexChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class