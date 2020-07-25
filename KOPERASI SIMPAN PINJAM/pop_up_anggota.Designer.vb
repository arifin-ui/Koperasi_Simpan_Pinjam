<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_up_anggota
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dataanggota = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaImageButton5 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLineTextBox1 = New Guna.UI.WinForms.GunaLineTextBox()
        CType(Me.dataanggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataanggota
        '
        Me.dataanggota.AllowUserToAddRows = False
        Me.dataanggota.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dataanggota.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataanggota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataanggota.BackgroundColor = System.Drawing.Color.White
        Me.dataanggota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataanggota.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataanggota.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataanggota.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataanggota.ColumnHeadersHeight = 50
        Me.dataanggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataanggota.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataanggota.EnableHeadersVisualStyles = False
        Me.dataanggota.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataanggota.Location = New System.Drawing.Point(12, 78)
        Me.dataanggota.Name = "dataanggota"
        Me.dataanggota.ReadOnly = True
        Me.dataanggota.RowHeadersVisible = False
        Me.dataanggota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataanggota.Size = New System.Drawing.Size(368, 392)
        Me.dataanggota.TabIndex = 1
        Me.dataanggota.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dataanggota.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dataanggota.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataanggota.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataanggota.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataanggota.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataanggota.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataanggota.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataanggota.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal
        Me.dataanggota.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataanggota.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dataanggota.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataanggota.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataanggota.ThemeStyle.HeaderStyle.Height = 50
        Me.dataanggota.ThemeStyle.ReadOnly = True
        Me.dataanggota.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dataanggota.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataanggota.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dataanggota.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dataanggota.ThemeStyle.RowsStyle.Height = 22
        Me.dataanggota.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        Me.dataanggota.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'GunaImageButton5
        '
        Me.GunaImageButton5.BackColor = System.Drawing.Color.White
        Me.GunaImageButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton5.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.search
        Me.GunaImageButton5.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaImageButton5.Location = New System.Drawing.Point(347, 28)
        Me.GunaImageButton5.Name = "GunaImageButton5"
        Me.GunaImageButton5.OnHoverImage = Nothing
        Me.GunaImageButton5.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton5.Size = New System.Drawing.Size(33, 33)
        Me.GunaImageButton5.TabIndex = 6
        '
        'GunaLineTextBox1
        '
        Me.GunaLineTextBox1.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaLineTextBox1.FocusedLineColor = System.Drawing.Color.PaleTurquoise
        Me.GunaLineTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBox1.ForeColor = System.Drawing.Color.Teal
        Me.GunaLineTextBox1.LineColor = System.Drawing.Color.Teal
        Me.GunaLineTextBox1.Location = New System.Drawing.Point(12, 26)
        Me.GunaLineTextBox1.Name = "GunaLineTextBox1"
        Me.GunaLineTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox1.Size = New System.Drawing.Size(368, 39)
        Me.GunaLineTextBox1.TabIndex = 5
        Me.GunaLineTextBox1.Text = "Nama Anggota"
        '
        'pop_up_anggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 482)
        Me.Controls.Add(Me.GunaImageButton5)
        Me.Controls.Add(Me.GunaLineTextBox1)
        Me.Controls.Add(Me.dataanggota)
        Me.Name = "pop_up_anggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POP UP ANGGOTA"
        CType(Me.dataanggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dataanggota As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaImageButton5 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLineTextBox1 As Guna.UI.WinForms.GunaLineTextBox
End Class
