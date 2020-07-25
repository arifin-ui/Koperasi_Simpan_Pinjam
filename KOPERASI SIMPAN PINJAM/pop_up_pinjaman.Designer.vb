<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_up_pinjaman
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
        Me.datapinjaman = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtnama_pinjaman = New Guna.UI.WinForms.GunaTextBox()
        Me.txtid_pinjaman = New Guna.UI.WinForms.GunaTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.datapinjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaImageButton5
        '
        Me.GunaImageButton5.BackColor = System.Drawing.Color.White
        Me.GunaImageButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton5.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.search
        Me.GunaImageButton5.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaImageButton5.Location = New System.Drawing.Point(430, 128)
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
        Me.GunaLineTextBox1.Location = New System.Drawing.Point(20, 128)
        Me.GunaLineTextBox1.Name = "GunaLineTextBox1"
        Me.GunaLineTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaLineTextBox1.Size = New System.Drawing.Size(443, 39)
        Me.GunaLineTextBox1.TabIndex = 8
        Me.GunaLineTextBox1.Text = "Nama Pinjaman"
        '
        'datapinjaman
        '
        Me.datapinjaman.AllowUserToAddRows = False
        Me.datapinjaman.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.datapinjaman.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datapinjaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datapinjaman.BackgroundColor = System.Drawing.Color.White
        Me.datapinjaman.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datapinjaman.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datapinjaman.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datapinjaman.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datapinjaman.ColumnHeadersHeight = 50
        Me.datapinjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datapinjaman.DefaultCellStyle = DataGridViewCellStyle3
        Me.datapinjaman.EnableHeadersVisualStyles = False
        Me.datapinjaman.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datapinjaman.Location = New System.Drawing.Point(20, 173)
        Me.datapinjaman.Name = "datapinjaman"
        Me.datapinjaman.ReadOnly = True
        Me.datapinjaman.RowHeadersVisible = False
        Me.datapinjaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datapinjaman.Size = New System.Drawing.Size(443, 313)
        Me.datapinjaman.TabIndex = 7
        Me.datapinjaman.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.datapinjaman.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.datapinjaman.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datapinjaman.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datapinjaman.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datapinjaman.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datapinjaman.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datapinjaman.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datapinjaman.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal
        Me.datapinjaman.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datapinjaman.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.datapinjaman.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datapinjaman.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datapinjaman.ThemeStyle.HeaderStyle.Height = 50
        Me.datapinjaman.ThemeStyle.ReadOnly = True
        Me.datapinjaman.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.datapinjaman.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datapinjaman.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.datapinjaman.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.datapinjaman.ThemeStyle.RowsStyle.Height = 22
        Me.datapinjaman.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.PaleTurquoise
        Me.datapinjaman.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Teal
        Me.Label33.Location = New System.Drawing.Point(24, 17)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(81, 17)
        Me.Label33.TabIndex = 24
        Me.Label33.Text = "ID Pinjaman"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Teal
        Me.Label35.Location = New System.Drawing.Point(162, 17)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(104, 17)
        Me.Label35.TabIndex = 23
        Me.Label35.Text = "Nama Pinjaman"
        '
        'txtnama_pinjaman
        '
        Me.txtnama_pinjaman.BaseColor = System.Drawing.Color.White
        Me.txtnama_pinjaman.BorderColor = System.Drawing.Color.Teal
        Me.txtnama_pinjaman.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnama_pinjaman.FocusedBaseColor = System.Drawing.Color.White
        Me.txtnama_pinjaman.FocusedBorderColor = System.Drawing.Color.Teal
        Me.txtnama_pinjaman.FocusedForeColor = System.Drawing.Color.Teal
        Me.txtnama_pinjaman.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnama_pinjaman.ForeColor = System.Drawing.Color.Teal
        Me.txtnama_pinjaman.Location = New System.Drawing.Point(165, 37)
        Me.txtnama_pinjaman.Name = "txtnama_pinjaman"
        Me.txtnama_pinjaman.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnama_pinjaman.Size = New System.Drawing.Size(298, 30)
        Me.txtnama_pinjaman.TabIndex = 22
        '
        'txtid_pinjaman
        '
        Me.txtid_pinjaman.BaseColor = System.Drawing.Color.White
        Me.txtid_pinjaman.BorderColor = System.Drawing.Color.Teal
        Me.txtid_pinjaman.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid_pinjaman.FocusedBaseColor = System.Drawing.Color.White
        Me.txtid_pinjaman.FocusedBorderColor = System.Drawing.Color.Teal
        Me.txtid_pinjaman.FocusedForeColor = System.Drawing.Color.Teal
        Me.txtid_pinjaman.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtid_pinjaman.ForeColor = System.Drawing.Color.Teal
        Me.txtid_pinjaman.Location = New System.Drawing.Point(23, 37)
        Me.txtid_pinjaman.Name = "txtid_pinjaman"
        Me.txtid_pinjaman.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid_pinjaman.Size = New System.Drawing.Size(136, 30)
        Me.txtid_pinjaman.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(113, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 32)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(201, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 32)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "EDIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Teal
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(289, 79)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 32)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'pop_up_pinjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 498)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtnama_pinjaman)
        Me.Controls.Add(Me.txtid_pinjaman)
        Me.Controls.Add(Me.GunaImageButton5)
        Me.Controls.Add(Me.GunaLineTextBox1)
        Me.Controls.Add(Me.datapinjaman)
        Me.Name = "pop_up_pinjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD PINJAMAN"
        CType(Me.datapinjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaImageButton5 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLineTextBox1 As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents datapinjaman As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtnama_pinjaman As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtid_pinjaman As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
