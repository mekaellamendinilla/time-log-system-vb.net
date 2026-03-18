Public Class Form1

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        LoadFormContent(New UC_Admin)
    End Sub

    Private Sub btnUserlist_Click(sender As Object, e As EventArgs) Handles btnUserlist.Click
        LoadFormContent(New UC_Userlist)
    End Sub

    Private Sub btnUserform_Click(sender As Object, e As EventArgs) Handles btnUserform.Click
        LoadFormContent(New UC_OrganizedUserform)
    End Sub

    Private Sub btnLogHistory_Click(sender As Object, e As EventArgs) Handles btnLogHistory.Click
        LoadFormContent(New UC_LogHistory)
    End Sub

    Private Sub btnAboutTheSystem_Click(sender As Object, e As EventArgs) Handles btnAboutTheSystem.Click
        LoadFormContent(New UC_AboutTheSystem)
    End Sub

    Private Sub LoadFormContent(content As UserControl)
        pnlMain.Controls.Clear()
        content.Dock = DockStyle.Fill
        pnlMain.Controls.Add(content)
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormContent(New UC_Admin)

        opencon()
        MsgBox("Connected")

    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f3 As New form3
        f3.Show()
        Me.Dispose()
    End Sub
End Class
