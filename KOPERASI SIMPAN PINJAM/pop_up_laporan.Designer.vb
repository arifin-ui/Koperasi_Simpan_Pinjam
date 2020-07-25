<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pop_up_laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pop_up_laporan))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.simpanan = New Guna.UI.WinForms.GunaButton()
        Me.pinjaman = New Guna.UI.WinForms.GunaButton()
        Me.angsuran = New Guna.UI.WinForms.GunaButton()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Teal
        Me.GunaLabel1.Location = New System.Drawing.Point(40, 33)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(455, 32)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Lihat Laporan Koperasi Simpan Pinjam"
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(26, 162)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.icons8_print_96
        Me.PictureBox1.Location = New System.Drawing.Point(501, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'simpanan
        '
        Me.simpanan.AnimationHoverSpeed = 0.07!
        Me.simpanan.AnimationSpeed = 0.03!
        Me.simpanan.BaseColor = System.Drawing.Color.Teal
        Me.simpanan.BorderColor = System.Drawing.Color.Black
        Me.simpanan.DialogResult = System.Windows.Forms.DialogResult.None
        Me.simpanan.FocusedColor = System.Drawing.Color.Empty
        Me.simpanan.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpanan.ForeColor = System.Drawing.Color.White
        Me.simpanan.Image = CType(resources.GetObject("simpanan.Image"), System.Drawing.Image)
        Me.simpanan.ImageSize = New System.Drawing.Size(20, 20)
        Me.simpanan.Location = New System.Drawing.Point(400, 108)
        Me.simpanan.Name = "simpanan"
        Me.simpanan.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.simpanan.OnHoverBorderColor = System.Drawing.Color.Black
        Me.simpanan.OnHoverForeColor = System.Drawing.Color.White
        Me.simpanan.OnHoverImage = Nothing
        Me.simpanan.OnPressedColor = System.Drawing.Color.Black
        Me.simpanan.Size = New System.Drawing.Size(171, 32)
        Me.simpanan.TabIndex = 7
        Me.simpanan.Text = "SIMPANAN"
        Me.simpanan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pinjaman
        '
        Me.pinjaman.AnimationHoverSpeed = 0.07!
        Me.pinjaman.AnimationSpeed = 0.03!
        Me.pinjaman.BaseColor = System.Drawing.Color.Teal
        Me.pinjaman.BorderColor = System.Drawing.Color.Black
        Me.pinjaman.DialogResult = System.Windows.Forms.DialogResult.None
        Me.pinjaman.FocusedColor = System.Drawing.Color.Empty
        Me.pinjaman.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pinjaman.ForeColor = System.Drawing.Color.White
        Me.pinjaman.Image = CType(resources.GetObject("pinjaman.Image"), System.Drawing.Image)
        Me.pinjaman.ImageSize = New System.Drawing.Size(20, 20)
        Me.pinjaman.Location = New System.Drawing.Point(223, 108)
        Me.pinjaman.Name = "pinjaman"
        Me.pinjaman.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.pinjaman.OnHoverBorderColor = System.Drawing.Color.Black
        Me.pinjaman.OnHoverForeColor = System.Drawing.Color.White
        Me.pinjaman.OnHoverImage = Nothing
        Me.pinjaman.OnPressedColor = System.Drawing.Color.Black
        Me.pinjaman.Size = New System.Drawing.Size(171, 32)
        Me.pinjaman.TabIndex = 6
        Me.pinjaman.Text = "PINJAMAN"
        Me.pinjaman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'angsuran
        '
        Me.angsuran.AnimationHoverSpeed = 0.07!
        Me.angsuran.AnimationSpeed = 0.03!
        Me.angsuran.BaseColor = System.Drawing.Color.Teal
        Me.angsuran.BorderColor = System.Drawing.Color.Black
        Me.angsuran.DialogResult = System.Windows.Forms.DialogResult.None
        Me.angsuran.FocusedColor = System.Drawing.Color.Empty
        Me.angsuran.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.angsuran.ForeColor = System.Drawing.Color.White
        Me.angsuran.Image = CType(resources.GetObject("angsuran.Image"), System.Drawing.Image)
        Me.angsuran.ImageSize = New System.Drawing.Size(20, 20)
        Me.angsuran.Location = New System.Drawing.Point(46, 108)
        Me.angsuran.Name = "angsuran"
        Me.angsuran.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.angsuran.OnHoverBorderColor = System.Drawing.Color.Black
        Me.angsuran.OnHoverForeColor = System.Drawing.Color.White
        Me.angsuran.OnHoverImage = Nothing
        Me.angsuran.OnPressedColor = System.Drawing.Color.Black
        Me.angsuran.Size = New System.Drawing.Size(171, 32)
        Me.angsuran.TabIndex = 5
        Me.angsuran.Text = "ANGSURAN"
        Me.angsuran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pop_up_laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 217)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.simpanan)
        Me.Controls.Add(Me.pinjaman)
        Me.Controls.Add(Me.angsuran)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Name = "pop_up_laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIHAT LAPORAN"
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents angsuran As Guna.UI.WinForms.GunaButton
    Friend WithEvents pinjaman As Guna.UI.WinForms.GunaButton
    Friend WithEvents simpanan As Guna.UI.WinForms.GunaButton
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
