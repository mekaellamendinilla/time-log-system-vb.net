<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Timein1 = New System.Windows.Forms.Button()
        Me.Timeout1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Time1 = New System.Windows.Forms.Label()
        Me.Date1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(67, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Admin log-in"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(123, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(149, 142)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpass.Size = New System.Drawing.Size(143, 20)
        Me.txtpass.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(77, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Password"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(149, 99)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(143, 20)
        Me.txtid.TabIndex = 12
        '
        'Timein1
        '
        Me.Timein1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Timein1.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timein1.Location = New System.Drawing.Point(221, 200)
        Me.Timein1.Name = "Timein1"
        Me.Timein1.Size = New System.Drawing.Size(71, 28)
        Me.Timein1.TabIndex = 16
        Me.Timein1.Text = "Time in"
        Me.Timein1.UseVisualStyleBackColor = True
        '
        'Timeout1
        '
        Me.Timeout1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Timeout1.Font = New System.Drawing.Font("Sitka Text", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timeout1.Location = New System.Drawing.Point(83, 200)
        Me.Timeout1.Name = "Timeout1"
        Me.Timeout1.Size = New System.Drawing.Size(63, 28)
        Me.Timeout1.TabIndex = 17
        Me.Timeout1.Text = "Time out"
        Me.Timeout1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Time1
        '
        Me.Time1.AutoSize = True
        Me.Time1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time1.ForeColor = System.Drawing.SystemColors.Control
        Me.Time1.Location = New System.Drawing.Point(263, 9)
        Me.Time1.Name = "Time1"
        Me.Time1.Size = New System.Drawing.Size(46, 21)
        Me.Time1.TabIndex = 18
        Me.Time1.Text = "Time"
        '
        'Date1
        '
        Me.Date1.AutoSize = True
        Me.Date1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date1.ForeColor = System.Drawing.SystemColors.Control
        Me.Date1.Location = New System.Drawing.Point(263, 30)
        Me.Date1.Name = "Date1"
        Me.Date1.Size = New System.Drawing.Size(40, 17)
        Me.Date1.TabIndex = 19
        Me.Date1.Text = "Date"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(376, 411)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Date1)
        Me.Controls.Add(Me.Time1)
        Me.Controls.Add(Me.Timeout1)
        Me.Controls.Add(Me.Timein1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nexel"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Timein1 As Button
    Friend WithEvents Timeout1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Time1 As Label
    Friend WithEvents Date1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
