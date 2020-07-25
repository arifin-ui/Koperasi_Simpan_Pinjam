<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_up_angsuran
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaImageButton5 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLineTextBox1 = New Guna.UI.WinForms.GunaLineTextBox()
        Me.dataangsuran = New Guna.UI.WinForms.GunaDataGridView()
        CType(Me.dataangsuran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaImageButton5
        '
        Me.GunaImageButton5.BackColor = System.Drawing.Color.White
        Me.GunaImageButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton5.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.search
        Me.GunaImageButton5.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaImageButton5.Location = New System.Drawing.Point(321, 22)
        Me.GunaImageButton5.Name = "GunaImageButton5"
        Me.GunaImageButton5.OnHoverImage = Nothing
        Me.GunaImageButton5.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton5.Size = New System.Drawing.Size(33, 33)
        Me.GunaImageButton5.TabIndex = 9
        '
        'GunaLineTextBox1
        '
        Me.GunaLineTextBox1.BackColor = System.Drawing.Color.White
        Me.GunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaLineTextBox1.FocusedLineColor = System.Drawing.Color.PaleTurquoise
        Me.GunaLineTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLineTextBox1.ForeColor = System.Drawing.Color.Teal
        Me.GunaLineTextBox1.LineColor = System.Drawing.Color.Teal
        Me.GunaLineTextBox1.Location = New System.Drawing.Point(18, 22)
        Me.GunaLineTextBox1.Name = "GunaLineTextBox1"
        Me.GunaLineTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox1.Size = New System.Drawing.Size(336, 39)
        Me.GunaLineTextBox1.TabIndex = 8
        Me.GunaLineTextBox1.Text = "ID Angsuran"
        '
        'dataangsuran
        '
        Me.dataangsuran.AllowUserToAddRows = False
        Me.dataangsuran.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dataangsuran.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataangsuran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataangsuran.BackgroundColor = System.Drawing.Color.White
        Me.dataangsuran.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataangsuran.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataangsuran.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataangsuran.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataangsuran.ColumnHeadersHeight = 50
        Me.dataangsuran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataangsuran.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataangsuran.EnableHeadersVisualStyles = False
        Me.dataangsuran.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataangsuran.Location = New System.Drawing.Point(18, 80)
        Me.dataangsuran.Name = "dataangsuran"
        Me.dataangsuran.ReadOnly = True
        Me.dataangsuran.RowHeadersVisible = False
        Me.dataangsuran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataangsuran.Size = New System.Drawing.Size(336, 379)
        Me.dataangsuran.TabIndex = 7
        Me.dataangsuran.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dataangsuran.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dataangsuran.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataangsuran.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataangsuran.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataangsuran.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataangsuran.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataangsuran.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataangsuran.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal
        Me.dataangsuran.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataangsuran.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dataangsuran.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataangsuran.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dataangsuran.ThemeStyle.HeaderStyle.Height = 50
        Me.dataangsuran.ThemeStyle.ReadOnly = True
        Me.dataangsuran.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.dataangsuran.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataangsuran.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dataangsuran.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dataangsuran.ThemeStyle.RowsStyle.Height = 22
        Me.dataangsuran.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        Me.dataangsuran.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'pop_up_angsuran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 471)
        Me.Controls.Add(Me.GunaImageButton5)
        Me.Controls.Add(Me.GunaLineTextBox1)
        Me.Controls.Add(Me.dataangsuran)
        Me.Name = "pop_up_angsuran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pop_up_angsuran"
        CType(Me.dataangsuran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaImageButton5 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLineTextBox1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dataangsuran As Guna.UI.WinForms.GunaDataGridView
End Class
