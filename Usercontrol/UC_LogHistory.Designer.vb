<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_LogHistory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvLogHistory = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtdatfilter = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvLogHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLogHistory
        '
        Me.dgvLogHistory.AllowUserToAddRows = False
        Me.dgvLogHistory.AllowUserToDeleteRows = False
        Me.dgvLogHistory.AllowUserToResizeColumns = False
        Me.dgvLogHistory.AllowUserToResizeRows = False
        Me.dgvLogHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLogHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLogHistory.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.dgvLogHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLogHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvLogHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLogHistory.ColumnHeadersHeight = 33
        Me.dgvLogHistory.EnableHeadersVisualStyles = False
        Me.dgvLogHistory.GridColor = System.Drawing.SystemColors.Window
        Me.dgvLogHistory.Location = New System.Drawing.Point(14, 65)
        Me.dgvLogHistory.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvLogHistory.MultiSelect = False
        Me.dgvLogHistory.Name = "dgvLogHistory"
        Me.dgvLogHistory.ReadOnly = True
        Me.dgvLogHistory.RowHeadersVisible = False
        Me.dgvLogHistory.RowHeadersWidth = 25
        Me.dgvLogHistory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvLogHistory.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLogHistory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.dgvLogHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.dgvLogHistory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        Me.dgvLogHistory.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogHistory.RowTemplate.Height = 25
        Me.dgvLogHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogHistory.Size = New System.Drawing.Size(746, 411)
        Me.dgvLogHistory.TabIndex = 0
        '
        'txtsearch
        '
        Me.txtsearch.AcceptsTab = True
        Me.txtsearch.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsearch.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(17, 21)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(226, 21)
        Me.txtsearch.TabIndex = 55
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Image = Global.Dashboard_UI.My.Resources.Resources.magnifying_glass
        Me.Button3.Location = New System.Drawing.Point(241, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(35, 22)
        Me.Button3.TabIndex = 56
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtdatfilter)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.dgvLogHistory)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 489)
        Me.Panel1.TabIndex = 1
        '
        'txtdatfilter
        '
        Me.txtdatfilter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtdatfilter.CalendarFont = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatfilter.CalendarForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtdatfilter.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar
        Me.txtdatfilter.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdatfilter.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdatfilter.Location = New System.Drawing.Point(522, 21)
        Me.txtdatfilter.Name = "txtdatfilter"
        Me.txtdatfilter.Size = New System.Drawing.Size(157, 27)
        Me.txtdatfilter.TabIndex = 61
        Me.txtdatfilter.Value = New Date(2025, 11, 26, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Image = Global.Dashboard_UI.My.Resources.Resources.save_file
        Me.Button1.Location = New System.Drawing.Point(685, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 60
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UC_LogHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UC_LogHistory"
        Me.Size = New System.Drawing.Size(774, 489)
        CType(Me.dgvLogHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLogHistory As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtdatfilter As DateTimePicker
End Class
