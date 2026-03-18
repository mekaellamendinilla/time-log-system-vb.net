<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.plLeftNav = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.plOnButton5 = New System.Windows.Forms.Panel()
        Me.btnAboutTheSystem = New System.Windows.Forms.Button()
        Me.plOnButton4 = New System.Windows.Forms.Panel()
        Me.plOnButton3 = New System.Windows.Forms.Panel()
        Me.btnLogHistory = New System.Windows.Forms.Button()
        Me.plOnButton2 = New System.Windows.Forms.Panel()
        Me.plOnButton1 = New System.Windows.Forms.Panel()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnUserlist = New System.Windows.Forms.Button()
        Me.btnUserform = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.plUpside = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.plLeftNav.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plUpside.SuspendLayout()
        Me.SuspendLayout()
        '
        'plLeftNav
        '
        Me.plLeftNav.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.plLeftNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.plLeftNav.Controls.Add(Me.Button1)
        Me.plLeftNav.Controls.Add(Me.PictureBox1)
        Me.plLeftNav.Controls.Add(Me.plOnButton5)
        Me.plLeftNav.Controls.Add(Me.btnAboutTheSystem)
        Me.plLeftNav.Controls.Add(Me.plOnButton4)
        Me.plLeftNav.Controls.Add(Me.plOnButton3)
        Me.plLeftNav.Controls.Add(Me.btnLogHistory)
        Me.plLeftNav.Controls.Add(Me.plOnButton2)
        Me.plLeftNav.Controls.Add(Me.plOnButton1)
        Me.plLeftNav.Controls.Add(Me.btnAdmin)
        Me.plLeftNav.Controls.Add(Me.btnUserlist)
        Me.plLeftNav.Controls.Add(Me.btnUserform)
        Me.plLeftNav.Location = New System.Drawing.Point(0, 0)
        Me.plLeftNav.Name = "plLeftNav"
        Me.plLeftNav.Size = New System.Drawing.Size(210, 563)
        Me.plLeftNav.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(12, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Log out"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'plOnButton5
        '
        Me.plOnButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.plOnButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.plOnButton5.Location = New System.Drawing.Point(0, 317)
        Me.plOnButton5.Name = "plOnButton5"
        Me.plOnButton5.Size = New System.Drawing.Size(11, 33)
        Me.plOnButton5.TabIndex = 9
        '
        'btnAboutTheSystem
        '
        Me.btnAboutTheSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAboutTheSystem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAboutTheSystem.FlatAppearance.BorderSize = 0
        Me.btnAboutTheSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutTheSystem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutTheSystem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAboutTheSystem.Image = Global.Dashboard_UI.My.Resources.Resources.gear
        Me.btnAboutTheSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAboutTheSystem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAboutTheSystem.Location = New System.Drawing.Point(0, 317)
        Me.btnAboutTheSystem.Name = "btnAboutTheSystem"
        Me.btnAboutTheSystem.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnAboutTheSystem.Size = New System.Drawing.Size(210, 33)
        Me.btnAboutTheSystem.TabIndex = 8
        Me.btnAboutTheSystem.Text = "   About the system"
        Me.btnAboutTheSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAboutTheSystem.UseVisualStyleBackColor = True
        '
        'plOnButton4
        '
        Me.plOnButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.plOnButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.plOnButton4.Location = New System.Drawing.Point(0, 267)
        Me.plOnButton4.Name = "plOnButton4"
        Me.plOnButton4.Size = New System.Drawing.Size(11, 33)
        Me.plOnButton4.TabIndex = 7
        '
        'plOnButton3
        '
        Me.plOnButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.plOnButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.plOnButton3.Location = New System.Drawing.Point(0, 217)
        Me.plOnButton3.Name = "plOnButton3"
        Me.plOnButton3.Size = New System.Drawing.Size(11, 33)
        Me.plOnButton3.TabIndex = 4
        '
        'btnLogHistory
        '
        Me.btnLogHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogHistory.FlatAppearance.BorderSize = 0
        Me.btnLogHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogHistory.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogHistory.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnLogHistory.Image = Global.Dashboard_UI.My.Resources.Resources.file__1_
        Me.btnLogHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLogHistory.Location = New System.Drawing.Point(0, 267)
        Me.btnLogHistory.Name = "btnLogHistory"
        Me.btnLogHistory.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLogHistory.Size = New System.Drawing.Size(210, 33)
        Me.btnLogHistory.TabIndex = 6
        Me.btnLogHistory.Text = "   Log History"
        Me.btnLogHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogHistory.UseVisualStyleBackColor = True
        '
        'plOnButton2
        '
        Me.plOnButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.plOnButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.plOnButton2.Location = New System.Drawing.Point(0, 166)
        Me.plOnButton2.Name = "plOnButton2"
        Me.plOnButton2.Size = New System.Drawing.Size(11, 33)
        Me.plOnButton2.TabIndex = 3
        '
        'plOnButton1
        '
        Me.plOnButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.plOnButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.plOnButton1.Location = New System.Drawing.Point(0, 115)
        Me.plOnButton1.Name = "plOnButton1"
        Me.plOnButton1.Size = New System.Drawing.Size(11, 33)
        Me.plOnButton1.TabIndex = 0
        '
        'btnAdmin
        '
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnAdmin.Image = Global.Dashboard_UI.My.Resources.Resources.profile__2_
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAdmin.Location = New System.Drawing.Point(0, 115)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnAdmin.Size = New System.Drawing.Size(210, 33)
        Me.btnAdmin.TabIndex = 0
        Me.btnAdmin.Text = "   Admin"
        Me.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnUserlist
        '
        Me.btnUserlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUserlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserlist.FlatAppearance.BorderSize = 0
        Me.btnUserlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserlist.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserlist.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnUserlist.Image = Global.Dashboard_UI.My.Resources.Resources.clipboard__1_
        Me.btnUserlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserlist.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnUserlist.Location = New System.Drawing.Point(0, 217)
        Me.btnUserlist.Name = "btnUserlist"
        Me.btnUserlist.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnUserlist.Size = New System.Drawing.Size(210, 33)
        Me.btnUserlist.TabIndex = 5
        Me.btnUserlist.Text = "   Userlist"
        Me.btnUserlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserlist.UseVisualStyleBackColor = True
        '
        'btnUserform
        '
        Me.btnUserform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUserform.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserform.FlatAppearance.BorderSize = 0
        Me.btnUserform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserform.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserform.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnUserform.Image = Global.Dashboard_UI.My.Resources.Resources.id_card__1_
        Me.btnUserform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserform.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnUserform.Location = New System.Drawing.Point(0, 166)
        Me.btnUserform.Name = "btnUserform"
        Me.btnUserform.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnUserform.Size = New System.Drawing.Size(210, 33)
        Me.btnUserform.TabIndex = 2
        Me.btnUserform.Text = "   Userform"
        Me.btnUserform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserform.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Sitka Small", 11.25!)
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTime.Location = New System.Drawing.Point(550, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(54, 23)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Time:"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Sitka Small", 11.25!)
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDate.Location = New System.Drawing.Point(552, 32)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(51, 23)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'plUpside
        '
        Me.plUpside.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.plUpside.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.plUpside.Controls.Add(Me.lblDate)
        Me.plUpside.Controls.Add(Me.lblTime)
        Me.plUpside.Location = New System.Drawing.Point(210, 0)
        Me.plUpside.Name = "plUpside"
        Me.plUpside.Size = New System.Drawing.Size(774, 74)
        Me.plUpside.TabIndex = 1
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.BackColor = System.Drawing.SystemColors.Window
        Me.pnlMain.Location = New System.Drawing.Point(210, 74)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(774, 489)
        Me.pnlMain.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(984, 563)
        Me.Controls.Add(Me.plUpside)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.plLeftNav)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.plLeftNav.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plUpside.ResumeLayout(False)
        Me.plUpside.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents plLeftNav As Panel
    Friend WithEvents btnAdmin As Button
    Friend WithEvents plOnButton1 As Panel
    Friend WithEvents btnUserform As Button
    Friend WithEvents plOnButton2 As Panel
    Friend WithEvents plOnButton3 As Panel
    Friend WithEvents btnUserlist As Button
    Friend WithEvents plOnButton4 As Panel
    Friend WithEvents btnLogHistory As Button
    Friend WithEvents plOnButton5 As Panel
    Friend WithEvents btnAboutTheSystem As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents plUpside As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class
