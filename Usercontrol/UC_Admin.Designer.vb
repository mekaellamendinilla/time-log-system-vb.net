<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Admin
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.txtSearchForAdmin = New System.Windows.Forms.TextBox()
        Me.btnSearchForAdmin = New System.Windows.Forms.Button()
        Me.btnSaveForAdmin = New System.Windows.Forms.Button()
        Me.dgv1TotalPresent = New System.Windows.Forms.DataGridView()
        Me.pnlAdmin.SuspendLayout()
        CType(Me.dgv1TotalPresent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAdmin
        '
        Me.pnlAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.pnlAdmin.Controls.Add(Me.txtSearchForAdmin)
        Me.pnlAdmin.Controls.Add(Me.btnSearchForAdmin)
        Me.pnlAdmin.Controls.Add(Me.btnSaveForAdmin)
        Me.pnlAdmin.Controls.Add(Me.dgv1TotalPresent)
        Me.pnlAdmin.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(774, 489)
        Me.pnlAdmin.TabIndex = 2
        '
        'txtSearchForAdmin
        '
        Me.txtSearchForAdmin.AcceptsTab = True
        Me.txtSearchForAdmin.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtSearchForAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchForAdmin.Font = New System.Drawing.Font("Century Gothic", 12.75!, System.Drawing.FontStyle.Bold)
        Me.txtSearchForAdmin.ForeColor = System.Drawing.Color.Gray
        Me.txtSearchForAdmin.Location = New System.Drawing.Point(14, 36)
        Me.txtSearchForAdmin.Name = "txtSearchForAdmin"
        Me.txtSearchForAdmin.Size = New System.Drawing.Size(226, 21)
        Me.txtSearchForAdmin.TabIndex = 55
        Me.txtSearchForAdmin.Text = "Search"
        '
        'btnSearchForAdmin
        '
        Me.btnSearchForAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSearchForAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchForAdmin.FlatAppearance.BorderSize = 0
        Me.btnSearchForAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchForAdmin.Font = New System.Drawing.Font("Sitka Small", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchForAdmin.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSearchForAdmin.Image = Global.Dashboard_UI.My.Resources.Resources.magnifying_glass
        Me.btnSearchForAdmin.Location = New System.Drawing.Point(238, 36)
        Me.btnSearchForAdmin.Name = "btnSearchForAdmin"
        Me.btnSearchForAdmin.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.btnSearchForAdmin.Size = New System.Drawing.Size(31, 21)
        Me.btnSearchForAdmin.TabIndex = 56
        Me.btnSearchForAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearchForAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearchForAdmin.UseVisualStyleBackColor = False
        '
        'btnSaveForAdmin
        '
        Me.btnSaveForAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveForAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSaveForAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveForAdmin.FlatAppearance.BorderSize = 0
        Me.btnSaveForAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveForAdmin.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveForAdmin.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSaveForAdmin.Image = Global.Dashboard_UI.My.Resources.Resources.save_file
        Me.btnSaveForAdmin.Location = New System.Drawing.Point(684, 29)
        Me.btnSaveForAdmin.Name = "btnSaveForAdmin"
        Me.btnSaveForAdmin.Size = New System.Drawing.Size(75, 41)
        Me.btnSaveForAdmin.TabIndex = 60
        Me.btnSaveForAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSaveForAdmin.UseVisualStyleBackColor = False
        '
        'dgv1TotalPresent
        '
        Me.dgv1TotalPresent.AllowUserToAddRows = False
        Me.dgv1TotalPresent.AllowUserToDeleteRows = False
        Me.dgv1TotalPresent.AllowUserToResizeColumns = False
        Me.dgv1TotalPresent.AllowUserToResizeRows = False
        Me.dgv1TotalPresent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1TotalPresent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv1TotalPresent.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.dgv1TotalPresent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv1TotalPresent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv1TotalPresent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1TotalPresent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv1TotalPresent.ColumnHeadersHeight = 33
        Me.dgv1TotalPresent.EnableHeadersVisualStyles = False
        Me.dgv1TotalPresent.GridColor = System.Drawing.SystemColors.Window
        Me.dgv1TotalPresent.Location = New System.Drawing.Point(14, 80)
        Me.dgv1TotalPresent.Margin = New System.Windows.Forms.Padding(0)
        Me.dgv1TotalPresent.MultiSelect = False
        Me.dgv1TotalPresent.Name = "dgv1TotalPresent"
        Me.dgv1TotalPresent.ReadOnly = True
        Me.dgv1TotalPresent.RowHeadersVisible = False
        Me.dgv1TotalPresent.RowHeadersWidth = 25
        Me.dgv1TotalPresent.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgv1TotalPresent.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv1TotalPresent.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.dgv1TotalPresent.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.dgv1TotalPresent.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        Me.dgv1TotalPresent.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1TotalPresent.RowTemplate.Height = 25
        Me.dgv1TotalPresent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1TotalPresent.Size = New System.Drawing.Size(745, 385)
        Me.dgv1TotalPresent.TabIndex = 0
        '
        'UC_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.pnlAdmin)
        Me.Name = "UC_Admin"
        Me.Size = New System.Drawing.Size(774, 489)
        Me.pnlAdmin.ResumeLayout(False)
        Me.pnlAdmin.PerformLayout()
        CType(Me.dgv1TotalPresent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlAdmin As Panel
    Friend WithEvents btnSaveForAdmin As Button
    Friend WithEvents btnSearchForAdmin As Button
    Friend WithEvents txtSearchForAdmin As TextBox
    Friend WithEvents dgv1TotalPresent As DataGridView
End Class
