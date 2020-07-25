Imports System.data.odbc
Public Class Form_dashboard

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Labelcopyright.Text = My.Application.Info.Copyright + " FEBI ARIFIN"
        petugas()
        anggota()
        simpanan()
        pinjaman()
        angsuran()
        nama()
        jumlah_anggota()
    End Sub
    Sub nama()
        dt = New DataTable()
        query = "select*from petugas where password='" & Form_login.txtpas.Text & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(dt)
            btnnama.Text = dt.Rows(0)(1)
            Labelnama.Text = dt.Rows(0)(1)
        Catch ex As Exception
        End Try
    End Sub
    Sub jumlah_anggota()
        query = "SELECT COUNT(id_anggota) as jumlah from anggota"
        cmd = New OdbcCommand(query, con)
        Try
            rd = cmd.ExecuteReader
            If rd.Read Then
                labeljumlahanggota.Text = rd("jumlah")
                rd.Close()
            Else
                rd.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub togel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles togel.CheckedChanged
        If togel.Checked Then
            Me.BackColor = Color.Silver
            Panelhome.BackColor = Color.Silver
            Panelanggota.BackColor = Color.Silver
            Panelpetugas.BackColor = Color.Silver
            Panelsimpanan.BackColor = Color.Silver
            FlowLayoutPanel1.BackColor = Color.Silver
            Labelaktif.Text = "Aktif"
        Else
            Me.BackColor = Color.WhiteSmoke
            Panelhome.BackColor = Color.WhiteSmoke
            Panelanggota.BackColor = Color.WhiteSmoke
            Panelpetugas.BackColor = Color.WhiteSmoke
            Panelsimpanan.BackColor = Color.WhiteSmoke
            FlowLayoutPanel1.BackColor = Color.WhiteSmoke
            Labelaktif.Text = "Tidak Aktif"
        End If
    End Sub

    Private Sub GunaImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaImageButton1.Click
        If MsgBox("Yakin ingin close ?", vbInformation + vbYesNo) = vbYes Then
            End
        End If

    End Sub

    Private Sub GunaImageButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaImageButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Labelwaktu.Text = TimeOfDay
    End Sub


    Private Sub btnhome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhome.Click
        Panelhome.Show()
    End Sub

    Private Sub btnpetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpetugas.Click
        Panelpetugas.Show()
        Panelhome.Hide()
    End Sub

    'panel petugas ===============================================================================================================

    Sub petugas()
        ds = New DataSet
        query = "select id_petugas,nama,username,alamat,no_telepon,tempat_lahir,tgl_lahir,keterangan from petugas"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            datapetugas.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtcaripetugas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcaripetugas.TextChanged

        ds = New DataSet
        query = "select id_petugas,nama,username,alamat,no_telepon,tempat_lahir,tgl_lahir,keterangan from petugas where nama like '%" & txtcaripetugas.Text & "%'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            datapetugas.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try

    End Sub

    'panel anggota==========================================================================================================================

    Private Sub txtcarianggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarianggota.Click
        txtcarianggota.Text = ""
        txtcarianggota.Focus()
    End Sub

    Sub anggota()
        ds = New DataSet
        query = "select*from anggota"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            dataanggota.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
    Sub clear()
        btnsimpan_anggota.Enabled = True
        btnedit_anggota.Enabled = False
        btndelete_anggota.Enabled = False
        txtidanggita.Enabled = True
        txtidanggita.Focus()
        txtidanggita.Text = ""
        txtnamaanggota.Text = ""
        txtalamat.Text = ""
        txttempatlahir.Text = ""
        txtno_telepon.Text = ""
        txtketerangan.Text = ""
        '  txtjenis_kelamin.Items.Clear()
        ' txtstatus.Items.Clear()
    End Sub
    Private Sub dataanggota_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataanggota.CellClick
        btnsimpan_anggota.Enabled = False
        btnedit_anggota.Enabled = True
        btndelete_anggota.Enabled = True
        txtidanggita.Enabled = False
        Dim i As Integer
        i = dataanggota.CurrentRow.Index
        Try
            txtidanggita.Text = dataanggota.Item(0, i).Value
            txtnamaanggota.Text = dataanggota.Item(1, i).Value
            txtalamat.Text = dataanggota.Item(2, i).Value
            txttanggal_lahir.Text = dataanggota.Item(3, i).Value
            txttempatlahir.Text = dataanggota.Item(4, i).Value
            txtjenis_kelamin.Text = dataanggota.Item(5, i).Value
            txtstatus.Text = dataanggota.Item(6, i).Value
            txtno_telepon.Text = dataanggota.Item(7, i).Value
            txtketerangan.Text = dataanggota.Item(8, i).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsimpan_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan_anggota.Click
        cmd = New OdbcCommand
        cmd.Connection = con
        query = "insert into anggota values('" & txtidanggita.Text & "','" & txtnamaanggota.Text & "','" & txtalamat.Text & "','" & txttanggal_lahir.Text & "','" & txttempatlahir.Text & "','" & txtjenis_kelamin.Text & "','" & txtstatus.Text & "','" & txtno_telepon.Text & "','" & txtketerangan.Text & "')"
        cmd.CommandText = query
        Try
            cmd.ExecuteNonQuery()
            anggota()
            clear()
        Catch ex As Exception
            MsgBox("SIMPAN DATA ANGGOTA GAGAL!", vbInformation)
            clear()
        End Try
    End Sub

    Private Sub txtcarianggota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarianggota.TextChanged
        ds = New DataSet
        query = "select*from anggota where nama like '%" & txtcarianggota.Text & "%'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            dataanggota.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit_anggota.Click
        cmd = New OdbcCommand
        cmd.Connection = con
        query = "update anggota set nama='" & txtnamaanggota.Text & "',alamat='" & txtalamat.Text & "',tgl_lahir='" & txttanggal_lahir.Text & "',tempat_lahir='" & txttempatlahir.Text & "',jenis_kelamin='" & txtjenis_kelamin.Text & "',status='" & txtstatus.Text & "',no_telepon='" & txtno_telepon.Text & "',keterangan='" & txtketerangan.Text & "'where id_anggota='" & txtidanggita.Text & "'"
        cmd.CommandText = query
        Try
            MsgBox("EDIT DATA ANGGOTA SUKSES!", vbInformation)
            cmd.ExecuteNonQuery()
            anggota()
            clear()
        Catch ex As Exception
            MsgBox("EDIT DATA ANGGOTA GAGAL!", vbInformation)
            clear()
        End Try
    End Sub

    Private Sub btndelete_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete_anggota.Click
        If MsgBox("Yakin Data Angota Inging dihapus?", vbInformation + vbYesNo) = vbYes Then
            cmd = New OdbcCommand
            cmd.Connection = con
            query = "delete from anggota where id_anggota='" & txtidanggita.Text & "'"
            cmd.CommandText = query
            Try
                MsgBox("HAPUS DATA ANGGOTA SUKSES!", vbInformation)
                cmd.ExecuteNonQuery()
                anggota()
                clear()
            Catch ex As Exception
                MsgBox("HAPUS DATA ANGGOTA GAGAL!", vbInformation)
                clear()
            End Try
        End If
    End Sub

    Private Sub txtcaripetugas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcaripetugas.Click
        txtcaripetugas.Text = ""
        txtcaripetugas.Focus()
    End Sub

    Private Sub btnanggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanggota.Click
        Panelanggota.Show()
        Panelhome.Hide()
        Panelpetugas.Hide()
    End Sub

    'panel simpanan=====================================================================================================

    Private Sub txtid_anggota_simpanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_anggota_simpanan.Click
        pop_up_anggota.Show()
    End Sub
    Sub simpanan()
        ds = New DataSet
        query = "select*from simpanan"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            datasimpanan.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
    Sub bersih()
        btnsimpan_simpanan.Enabled = True
        btnedit_simpanan.Enabled = False
        btndelete_simpanan.Enabled = False
        txtid_simpanan.Enabled = True
        txtid_simpanan.Focus()
        txtid_simpanan.Text = ""
        txtid_anggota_simpanan.Text = ""
        txtnama_simpanan.Text = ""
        txttgl_simpanan.Text = ""
        txtbesar_simpanan.Text = ""
        txtketerangan_simpanan.Text = ""
    End Sub
    Private Sub txtcarisimpanan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarisimpanan.TextChanged
        ds = New DataSet
        query = "select*from simpanan where nama_simpanan like '%" & txtcarisimpanan.Text & "%'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            datasimpanan.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcarisimpanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarisimpanan.Click
        txtcarisimpanan.Text = ""
        txtcarisimpanan.Focus()
    End Sub

    Private Sub datasimpanan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datasimpanan.CellClick
        btnsimpan_simpanan.Enabled = False
        btnedit_simpanan.Enabled = True
        btndelete_simpanan.Enabled = True
        txtid_simpanan.Enabled = False

        Dim i As Integer
        i = datasimpanan.CurrentRow.Index
        Try
            txtid_simpanan.Text = datasimpanan.Item(0, i).Value
            txtnama_simpanan.Text = datasimpanan.Item(1, i).Value
            txtid_anggota_simpanan.Text = datasimpanan.Item(2, i).Value
            txttgl_simpanan.Text = datasimpanan.Item(3, i).Value
            txtbesar_simpanan.Text = datasimpanan.Item(4, i).Value
            txtketerangan_simpanan.Text = datasimpanan.Item(5, i).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsimpan_simpanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan_simpanan.Click
        cmd = New OdbcCommand
        cmd.Connection = con
        query = "insert into simpanan values('" & txtid_simpanan.Text & "','" & txtnama_simpanan.Text & "','" & txtid_anggota_simpanan.Text & "','" & txttgl_simpanan.Text & "','" & txtbesar_simpanan.Text & "','" & txtketerangan_simpanan.Text & "')"
        cmd.CommandText = query
        Try
            cmd.ExecuteNonQuery()
            simpanan()
            bersih()
        Catch ex As Exception
            MsgBox("SIMPAN DATA SIMPANAN GAGAL!", vbInformation)
            bersih()
        End Try
    End Sub

    Private Sub btnedit_simpanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit_simpanan.Click
        cmd = New OdbcCommand
        cmd.Connection = con
        query = "update simpanan set nama_simpanan='" & txtnama_simpanan.Text & "',id_anggota='" & txtid_anggota_simpanan.Text & "',tgl_simpanan='" & txttgl_simpanan.Text & "',besar_simpanan='" & txtbesar_simpanan.Text & "',keterangan='" & txtketerangan_simpanan.Text & "'where id_simpanan='" & txtid_simpanan.Text & "'"
        cmd.CommandText = query
        Try
            MsgBox("EDIT DATA SIMPANAN SUKSES!", vbInformation)
            cmd.ExecuteNonQuery()
            simpanan()
            bersih()
        Catch ex As Exception
            MsgBox("EDIT DATA SIMPANAN GAGAL!", vbInformation)
            bersih()
        End Try
    End Sub

    Private Sub btndelete_simpanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete_simpanan.Click
        If MsgBox("Yakin Data Simpanan Inging dihapus?", vbInformation + vbYesNo) = vbYes Then
            cmd = New OdbcCommand
            cmd.Connection = con
            query = "delete from simpanan where id_simpanan='" & txtid_simpanan.Text & "'"
            cmd.CommandText = query
            Try
                MsgBox("HAPUS DATA SIMPANAN SUKSES!", vbInformation)
                cmd.ExecuteNonQuery()
                simpanan()
                bersih()
            Catch ex As Exception
                MsgBox("HAPUS DATA SIMPANAN GAGAL!", vbInformation)
                bersih()
            End Try
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        Panelsimpanan.Show()
        Panelhome.Hide()
        Panelanggota.Hide()
        Panelpetugas.Hide()
    End Sub

    'panel pinjaman===========================================================================================================================

    Private Sub datapinjman_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datapinjman.CellClick
        btnsimpnan_pinjaman.Enabled = False
        btnedit_pinjaman.Enabled = True
        btndelete_pinjaman.Enabled = True
        txtid_pinjaman.Enabled = False

        Dim i As Integer
        i = datapinjman.CurrentRow.Index
        Try
            txtid_pinjaman.Text = datapinjman.Item(0, i).Value
            txtnama_pinjaman.Text = datapinjman.Item(1, i).Value
            txtid_anggota_pinjaman.Text = datapinjman.Item(2, i).Value
            txtbesar_pinjaman.Text = datapinjman.Item(3, i).Value
            txttgl_pengajuan_pinjaman.Text = datapinjman.Item(4, i).Value
            txttgl_acc_pinjaman.Text = datapinjman.Item(5, i).Value
            txttgl_pinjaman.Text = datapinjman.Item(6, i).Value
            txttgl_pelunasan_pinjaman.Text = datapinjman.Item(7, i).Value
            txtid_angsuran_pinjaman.Text = datapinjman.Item(8, i).Value
            txtketerangan_pinjaman.Text = datapinjman.Item(9, i).Value
        Catch ex As Exception

        End Try
    End Sub
    Sub pinjaman()
        ds = New DataSet
        query = "select*from pinjaman"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            datapinjman.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
    Sub bersih_pinjaman()
        btnsimpnan_pinjaman.Enabled = True
        btnedit_pinjaman.Enabled = False
        btndelete_pinjaman.Enabled = False
        txtid_pinjaman.Enabled = True
        txtid_pinjaman.Focus()

        txtid_pinjaman.Text = ""
        txtnama_pinjaman.Text = ""
        txtid_anggota_pinjaman.Text = ""
        txtbesar_pinjaman.Text = ""
        txttgl_pengajuan_pinjaman.Text = ""
        txttgl_acc_pinjaman.Text = ""
        txttgl_pinjaman.Text = ""
        txttgl_pelunasan_pinjaman.Text = ""
        txtid_angsuran_pinjaman.Text = ""
        txtketerangan_pinjaman.Text = ""
    End Sub

    Private Sub txtcari_pinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari_pinjaman.Click
        txtcari_pinjaman.Text = ""
        txtcari_pinjaman.Focus()
    End Sub

    Private Sub txtcari_pinjaman_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari_pinjaman.TextChanged
        ds = New DataSet
        query = "select*from pinjaman where nama_pinjaman like '%" & txtcari_pinjaman.Text & "%'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            datapinjman.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsimpnan_pinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpnan_pinjaman.Click
        cmd = New OdbcCommand
        cmd.Connection = con
        query = "insert into pinjaman values('" & txtid_pinjaman.Text & "','" & txtnama_pinjaman.Text & "','" & txtid_anggota_pinjaman.Text & "','" & txtbesar_pinjaman.Text & "','" & txttgl_pengajuan_pinjaman.Text & "','" & txttgl_acc_pinjaman.Text & "','" & txttgl_pinjaman.Text & "','" & txttgl_pelunasan_pinjaman.Text & "','" & txtid_angsuran_pinjaman.Text & "','" & txtketerangan_pinjaman.Text & "')"
        cmd.CommandText = query
        Try
            cmd.ExecuteNonQuery()
            pinjaman()
            bersih_pinjaman()
        Catch ex As Exception
            MsgBox("SIMPAN DATA PINJAMAN GAGAL!", vbInformation)
            bersih_pinjaman()
        End Try
    End Sub

    Private Sub btnedit_pinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit_pinjaman.Click
        cmd = New OdbcCommand
        cmd.Connection = con
        query = "update pinjaman set nama_pinjaman='" & txtnama_pinjaman.Text & "',id_anggota='" & txtid_anggota_pinjaman.Text & "',besar_pinjaman='" & txtbesar_pinjaman.Text & "',tgl_pengajuan_pinjaman='" & txttgl_pengajuan_pinjaman.Text & "',tgl_acc_pinjaman='" & txttgl_acc_pinjaman.Text & "',tgl_pinjaman='" & txttgl_pinjaman.Text & "',tgl_pelunasan='" & txttgl_pelunasan_pinjaman.Text & "',id_angsuran='" & txtid_angsuran_pinjaman.Text & "',keterangan='" & txtketerangan_pinjaman.Text & "'where id_pinjaman='" & txtid_pinjaman.Text & "'"
        cmd.CommandText = query
        Try
            MsgBox("EDIT DATA PINJAMAN SUKSES!", vbInformation)
            cmd.ExecuteNonQuery()
            pinjaman()
            bersih_pinjaman()
        Catch ex As Exception
            MsgBox("EDIT DATA PINJAMAN GAGAL!", vbInformation)
            bersih_pinjaman()
        End Try
    End Sub

    Private Sub btndelete_pinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete_pinjaman.Click
        If MsgBox("Yakin Data Pinjaman Ingin dihapus?", vbInformation + vbYesNo) = vbYes Then
            cmd = New OdbcCommand
            cmd.Connection = con
            query = "delete from pinjaman where id_pinjaman='" & txtid_pinjaman.Text & "'"
            cmd.CommandText = query
            Try
                MsgBox("HAPUS DATA PINJAMAN SUKSES!", vbInformation)
                cmd.ExecuteNonQuery()
                pinjaman()
                bersih_pinjaman()
            Catch ex As Exception
                MsgBox("HAPUS DATA PINJAMAN GAGAL!", vbInformation)
                bersih_pinjaman()
            End Try
        End If
    End Sub

    Private Sub txtid_anggota_pinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_anggota_pinjaman.Click
        pop_up_anggota.Show()
    End Sub

    Private Sub btnaddpinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddpinjaman.Click
        pop_up_pinjaman.Show()
    End Sub

    Private Sub txtid_pinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_pinjaman.Click
        pop_up_pinjaman.Show()
    End Sub

    Private Sub txtid_angsuran_pinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_angsuran_pinjaman.Click
        pop_up_angsuran.Show()
    End Sub

    Private Sub btnpinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpinjam.Click
        Panelpinjaman.Show()
        Panelhome.Hide()
        Panelpetugas.Hide()
        Panelanggota.Hide()
        Panelsimpanan.Hide()
    End Sub

    Private Sub GunaButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton7.Click
        If Panelsidebar.Visible = False Then
            Panelsidebar.Visible = True
        Else
            Panelsidebar.Visible = False
        End If

    End Sub

    'panel angsuran===================================================================================================================
    Sub angsuran()
        ds = New DataSet
        query = "select*from angsuran"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            dataasngsuran.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
    Sub bersih_angsuran()
        btnshow_detail_ngsuran.Visible = False
        btnsimpan_angsuran.Enabled = True
        btnedit_angsuran.Enabled = False
        btndelete_angsuran.Enabled = False
        txtid_angsuran.Enabled = True
        txtid_angsuran.Focus()

        txtid_angsuran.Text = ""
        txtid_kategori_pinjam_angsuran.Text = ""
        txtid_anggota_angsuran.Text = ""
        txttgl_pembayaran.Text = ""
        txtangsuranke.Text = ""
        txtbesar_angsuran.Text = ""
        txtketerangan_angsuran.Text = ""
    End Sub
    Private Sub txtid_kategori_pinjam_angsuran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_kategori_pinjam_angsuran.Click
        pop_up_pinjaman.Show()
    End Sub

    Private Sub txtid_anggota_angsuran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_anggota_angsuran.Click
        pop_up_anggota.Show()
    End Sub

    Private Sub dataasngsuran_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataasngsuran.CellClick
        btnshow_detail_ngsuran.Visible = True
        btnsimpan_angsuran.Enabled = False
        btnedit_angsuran.Enabled = True
        btndelete_angsuran.Enabled = True
        txtid_angsuran.Enabled = False

        Dim i As Integer
        i = dataasngsuran.CurrentRow.Index
        Try
            txtid_angsuran.Text = dataasngsuran.Item(0, i).Value
            txtid_kategori_pinjam_angsuran.Text = dataasngsuran.Item(1, i).Value
            txtid_anggota_angsuran.Text = dataasngsuran.Item(2, i).Value
            txttgl_pembayaran.Text = dataasngsuran.Item(3, i).Value
            txtangsuranke.Text = dataasngsuran.Item(4, i).Value
            txtbesar_angsuran.Text = dataasngsuran.Item(5, i).Value
            txtketerangan_angsuran.Text = dataasngsuran.Item(6, i).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsimpan_angsuran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan_angsuran.Click
        cmd = New OdbcCommand
        cmd.Connection = con
        query = "insert into angsuran values('" & txtid_angsuran.Text & "','" & txtid_kategori_pinjam_angsuran.Text & "','" & txtid_anggota_angsuran.Text & "','" & txttgl_pembayaran.Text & "','" & txtangsuranke.Text & "','" & txtbesar_angsuran.Text & "','" & txtketerangan_angsuran.Text & "');insert into detail_angsuran values('" & txtid_angsuran.Text & "','" & txttgl_pembayaran.Text & "','" & txtbesar_angsuran.Text & "','" & txtketerangan_angsuran.Text & "')"
        cmd.CommandText = query
        Try
            cmd.ExecuteNonQuery()
            angsuran()
            bersih_angsuran()
        Catch ex As Exception
            MsgBox("SIMPAN DATA ANGSURAN GAGAL", vbInformation)
        End Try
    End Sub

    Private Sub txtcari_angsuran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari_angsuran.Click
        txtcari_angsuran.Text = ""
        txtcari_angsuran.Focus()
    End Sub

    Private Sub txtcari_angsuran_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari_angsuran.TextChanged
        ds = New DataSet
        query = "select*from angsuran where id_angsuran like '%" & txtcari_angsuran.Text & "%'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            dataasngsuran.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnedit_angsuran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit_angsuran.Click
        cmd = New OdbcCommand
        cmd.Connection = con
        query = "update angsuran set id_kategori='" & txtid_kategori_pinjam_angsuran.Text & "',id_anggota='" & txtid_anggota_angsuran.Text & "',tgl_pembayaran='" & txttgl_pembayaran.Text & "',angsuran_ke='" & txtangsuranke.Text & "',besar_angsuran='" & txtbesar_angsuran.Text & "',keterangan='" & txtketerangan_angsuran.Text & "'where id_angsuran='" & txtid_angsuran.Text & "';update detail_angsuran set tgl_jatuh_tempo='" & txttgl_pembayaran.Text & "',besar_angsuran='" & txtbesar_angsuran.Text & "',keterangan='" & txtketerangan_angsuran.Text & "'where id_angsuran='" & txtid_angsuran.Text & "'"
        cmd.CommandText = query
        Try
            MsgBox("EDIT DATA ANGSURAN SUKSES", vbInformation)
            cmd.ExecuteNonQuery()
            angsuran()
            bersih_angsuran()
        Catch ex As Exception
            MsgBox("EDIT DATA ANGSURAN GAGAL", vbInformation)
        End Try
    End Sub

    Private Sub btndelete_angsuran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete_angsuran.Click
        If MsgBox("Apakah Data Angsuran Ingin Di Hapus?", vbInformation + vbYesNo) = vbYes Then
            cmd = New OdbcCommand
            cmd.Connection = con
            query = "delete from angsuran where id_angsuran='" & txtid_angsuran.Text & "';delete from detail_angsuran where id_angsuran='" & txtid_angsuran.Text & "'"
            cmd.CommandText = query
            Try
                MsgBox("HAPUS DATA ANGSURAN SUKSES", vbInformation)
                cmd.ExecuteNonQuery()
                angsuran()
                bersih_angsuran()
            Catch ex As Exception
                MsgBox("HAPUS DATA ANGSURAN GAGAL", vbInformation)
            End Try
        End If

    End Sub

    Private Sub btnshow_detail_ngsuran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow_detail_ngsuran.Click
        pop_up_detail_angsuran.Show()
        pop_up_detail_angsuran.labelid.Text = txtid_angsuran.Text
        pop_up_detail_angsuran.labeltgl.Text = txttgl_pembayaran.Text
        pop_up_detail_angsuran.labelbesar.Text = txtbesar_angsuran.Text
        pop_up_detail_angsuran.labelkete.Text = txtketerangan_angsuran.Text
    End Sub

    Private Sub btnangsuran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnangsuran.Click
        Panelangsuran.Show()
        Panelhome.Hide()
        Panelpetugas.Hide()
        Panelanggota.Hide()
        Panelsimpanan.Hide()
        Panelpinjaman.Hide()
    End Sub

    Private Sub GunaButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton5.Click
        pop_up_laporan.Show()
    End Sub

    Private Sub GunaButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton1.Click
        Panelsidebar.Visible = False
        If MsgBox("Yakin ingin Logout ?", vbInformation + vbYesNo) = vbYes Then
            Form_login.Show()
            Me.Close()
            Form_login.txtuser.Text = ""
            Form_login.txtpas.Text = ""
            Form_login.txtuser.Focus()
        End If
    End Sub

    Private Sub GunaButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaButton2.Click
        pop_up_profil.Show()
        Panelsidebar.Visible = False
    End Sub

    Private Sub Panelhome_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panelhome.Paint

    End Sub
End Class
