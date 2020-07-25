<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_login
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Labelcopyright = New System.Windows.Forms.Label()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.btnlogin = New Guna.UI.WinForms.GunaButton()
        Me.txtpas = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtuser = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.labelwaktu = New System.Windows.Forms.Label()
        Me.GunaGroupBox3 = New Guna.UI.WinForms.GunaGroupBox()
        Me.Labeltanggal = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaImageButton4 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton3 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton2 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.GunaGroupBox2.SuspendLayout()
        Me.GunaGroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GunaImageButton2)
        Me.Panel1.Controls.Add(Me.GunaImageButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 36)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(262, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "V.1.0."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "KOPERASI SIMPAN PINJAM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Labelcopyright)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(0, 419)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(831, 27)
        Me.Panel2.TabIndex = 1
        '
        'Labelcopyright
        '
        Me.Labelcopyright.AutoSize = True
        Me.Labelcopyright.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcopyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelcopyright.Location = New System.Drawing.Point(289, 1)
        Me.Labelcopyright.Name = "Labelcopyright"
        Me.Labelcopyright.Size = New System.Drawing.Size(173, 21)
        Me.Labelcopyright.TabIndex = 4
        Me.Labelcopyright.Text = "Copyright Febi Arifin "
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GunaGroupBox1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Teal
        Me.GunaGroupBox1.BorderSize = 2
        Me.GunaGroupBox1.Controls.Add(Me.GunaImageButton4)
        Me.GunaGroupBox1.Controls.Add(Me.GunaImageButton3)
        Me.GunaGroupBox1.Controls.Add(Me.btnlogin)
        Me.GunaGroupBox1.Controls.Add(Me.txtpas)
        Me.GunaGroupBox1.Controls.Add(Me.txtuser)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.Teal
        Me.GunaGroupBox1.Location = New System.Drawing.Point(432, 54)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(371, 347)
        Me.GunaGroupBox1.TabIndex = 3
        Me.GunaGroupBox1.Text = "LOGIN."
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btnlogin
        '
        Me.btnlogin.AnimationHoverSpeed = 0.07!
        Me.btnlogin.AnimationSpeed = 0.03!
        Me.btnlogin.BaseColor = System.Drawing.Color.Teal
        Me.btnlogin.BorderColor = System.Drawing.Color.Black
        Me.btnlogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnlogin.FocusedColor = System.Drawing.Color.DarkSlateGray
        Me.btnlogin.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Image = Nothing
        Me.btnlogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnlogin.Location = New System.Drawing.Point(105, 264)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.OnHoverBaseColor = System.Drawing.Color.DarkSlateGray
        Me.btnlogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnlogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnlogin.OnHoverImage = Nothing
        Me.btnlogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnlogin.Size = New System.Drawing.Size(181, 37)
        Me.btnlogin.TabIndex = 10
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpas
        '
        Me.txtpas.BackColor = System.Drawing.SystemColors.Control
        Me.txtpas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpas.FocusedLineColor = System.Drawing.Color.DarkSlateGray
        Me.txtpas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpas.ForeColor = System.Drawing.Color.Teal
        Me.txtpas.LineColor = System.Drawing.Color.Teal
        Me.txtpas.Location = New System.Drawing.Point(39, 162)
        Me.txtpas.Name = "txtpas"
        Me.txtpas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpas.Size = New System.Drawing.Size(310, 38)
        Me.txtpas.TabIndex = 3
        Me.txtpas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.SystemColors.Control
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.FocusedLineColor = System.Drawing.Color.DarkSlateGray
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.Teal
        Me.txtuser.LineColor = System.Drawing.Color.Teal
        Me.txtuser.Location = New System.Drawing.Point(39, 88)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuser.Size = New System.Drawing.Size(310, 38)
        Me.txtuser.TabIndex = 16
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GunaGroupBox2.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.Teal
        Me.GunaGroupBox2.BorderSize = 2
        Me.GunaGroupBox2.Controls.Add(Me.labelwaktu)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.Teal
        Me.GunaGroupBox2.Location = New System.Drawing.Point(28, 54)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(162, 64)
        Me.GunaGroupBox2.TabIndex = 17
        Me.GunaGroupBox2.Text = "TIME."
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'labelwaktu
        '
        Me.labelwaktu.AutoSize = True
        Me.labelwaktu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelwaktu.ForeColor = System.Drawing.Color.Teal
        Me.labelwaktu.Location = New System.Drawing.Point(45, 33)
        Me.labelwaktu.Name = "labelwaktu"
        Me.labelwaktu.Size = New System.Drawing.Size(72, 21)
        Me.labelwaktu.TabIndex = 5
        Me.labelwaktu.Text = "00;00;00"
        '
        'GunaGroupBox3
        '
        Me.GunaGroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GunaGroupBox3.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaGroupBox3.BorderColor = System.Drawing.Color.Teal
        Me.GunaGroupBox3.BorderSize = 2
        Me.GunaGroupBox3.Controls.Add(Me.Labeltanggal)
        Me.GunaGroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaGroupBox3.LineColor = System.Drawing.Color.Teal
        Me.GunaGroupBox3.Location = New System.Drawing.Point(196, 54)
        Me.GunaGroupBox3.Name = "GunaGroupBox3"
        Me.GunaGroupBox3.Size = New System.Drawing.Size(220, 64)
        Me.GunaGroupBox3.TabIndex = 18
        Me.GunaGroupBox3.Text = "DATE."
        Me.GunaGroupBox3.TextLocation = New System.Drawing.Point(10, 8)
        '
        'Labeltanggal
        '
        Me.Labeltanggal.AutoSize = True
        Me.Labeltanggal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltanggal.ForeColor = System.Drawing.Color.Teal
        Me.Labeltanggal.Location = New System.Drawing.Point(62, 34)
        Me.Labeltanggal.Name = "Labeltanggal"
        Me.Labeltanggal.Size = New System.Drawing.Size(96, 21)
        Me.Labeltanggal.TabIndex = 6
        Me.Labeltanggal.Text = "00/00/0000"
        Me.Labeltanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.icons8_auction_100
        Me.PictureBox3.Location = New System.Drawing.Point(247, 247)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(138, 126)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.icons8_payment_history_100
        Me.PictureBox1.Location = New System.Drawing.Point(211, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'GunaImageButton4
        '
        Me.GunaImageButton4.BackColor = System.Drawing.SystemColors.Control
        Me.GunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton4.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.lock
        Me.GunaImageButton4.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaImageButton4.Location = New System.Drawing.Point(39, 159)
        Me.GunaImageButton4.Name = "GunaImageButton4"
        Me.GunaImageButton4.OnHoverImage = Nothing
        Me.GunaImageButton4.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton4.Size = New System.Drawing.Size(30, 30)
        Me.GunaImageButton4.TabIndex = 15
        '
        'GunaImageButton3
        '
        Me.GunaImageButton3.BackColor = System.Drawing.SystemColors.Control
        Me.GunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton3.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.boy
        Me.GunaImageButton3.ImageSize = New System.Drawing.Size(25, 25)
        Me.GunaImageButton3.Location = New System.Drawing.Point(39, 85)
        Me.GunaImageButton3.Name = "GunaImageButton3"
        Me.GunaImageButton3.OnHoverImage = Nothing
        Me.GunaImageButton3.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton3.Size = New System.Drawing.Size(30, 30)
        Me.GunaImageButton3.TabIndex = 14
        '
        'GunaImageButton2
        '
        Me.GunaImageButton2.BackColor = System.Drawing.Color.Teal
        Me.GunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton2.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.minimize
        Me.GunaImageButton2.ImageSize = New System.Drawing.Size(28, 28)
        Me.GunaImageButton2.Location = New System.Drawing.Point(755, 1)
        Me.GunaImageButton2.Name = "GunaImageButton2"
        Me.GunaImageButton2.OnHoverImage = Nothing
        Me.GunaImageButton2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Size = New System.Drawing.Size(33, 33)
        Me.GunaImageButton2.TabIndex = 13
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.BackColor = System.Drawing.Color.Teal
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.close
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(28, 28)
        Me.GunaImageButton1.Location = New System.Drawing.Point(792, 1)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(33, 33)
        Me.GunaImageButton1.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.KOPERASI_SIMPAN_PINJAM.My.Resources.Resources.icons8_man_with_keyboard_100
        Me.PictureBox2.Location = New System.Drawing.Point(28, 179)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(199, 194)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 446)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaGroupBox3)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.GunaGroupBox3.ResumeLayout(False)
        Me.GunaGroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Labelcopyright As System.Windows.Forms.Label
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents txtpas As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnlogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton2 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton3 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton4 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents txtuser As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents labelwaktu As System.Windows.Forms.Label
    Friend WithEvents GunaGroupBox3 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents Labeltanggal As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
