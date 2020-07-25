Imports System.data.odbc
Public Class pop_up_pinjaman

    Private Sub GunaLineTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.Click
        GunaLineTextBox1.Text = ""
        GunaLineTextBox1.Focus()
    End Sub

    Private Sub pop_up_pinjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        pinjam()
    End Sub
    Sub pinjam()
        ds = New DataSet
        query = "select * from kategori_pinjaman"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            datapinjaman.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GunaLineTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.TextChanged
        ds = New DataSet
        query = "select * from kategori_pinjaman where nama_pinjaman like '%" & GunaLineTextBox1.Text & "%'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            datapinjaman.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
    Sub bersih()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        txtid_pinjaman.Enabled = True
        txtid_pinjaman.Focus()
        txtid_pinjaman.Text = ""
        txtnama_pinjaman.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = New OdbcCommand
        cmd.Connection = con
        query = "insert into kategori_pinjaman values ('" & txtid_pinjaman.Text & "','" & txtnama_pinjaman.Text & "')"
        cmd.CommandText = query
        Try
            cmd.ExecuteNonQuery()
            pinjam()
            bersih()
        Catch ex As Exception
            MsgBox("SIMPAN GAGAL", vbInformation)
            bersih()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmd = New OdbcCommand
        cmd.Connection = con
        query = "update kategori_pinjaman set nama_pinjaman='" & txtnama_pinjaman.Text & "'where id_kategori_pinjaman='" & txtid_pinjaman.Text & "'"
        cmd.CommandText = query
        Try
            MsgBox("EDIT SUKSES", vbInformation)
            cmd.ExecuteNonQuery()
            pinjam()
            bersih()
        Catch ex As Exception
            MsgBox("EDIT GAGAL", vbInformation)
            bersih()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Apakah Data Kategori Pinjaman Ingin Dihapus?", vbInformation + vbYesNo) = vbYes Then
            cmd = New OdbcCommand
            cmd.Connection = con
            query = "delete from kategori_pinjaman where id_kategori_pinjaman='" & txtid_pinjaman.Text & "'"
            cmd.CommandText = query
            Try
                MsgBox("DELETE SUKSES", vbInformation)
                cmd.ExecuteNonQuery()
                pinjam()
                bersih()
            Catch ex As Exception
                MsgBox("DELETE GAGAL", vbInformation)
                bersih()
            End Try
        End If
    End Sub

    Private Sub datapinjaman_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datapinjaman.CellClick
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
        txtid_pinjaman.Enabled = False
        Dim i As Integer
        i = datapinjaman.CurrentRow.Index
        txtid_pinjaman.Text = datapinjaman.Item(0, i).Value
        txtnama_pinjaman.Text = datapinjaman.Item(1, i).Value
        Form_dashboard.txtid_pinjaman.Text = datapinjaman.Item(0, i).Value
        Form_dashboard.txtnama_pinjaman.Text = datapinjaman.Item(1, i).Value
        Form_dashboard.txtid_kategori_pinjam_angsuran.Text = datapinjaman.Item(0, i).Value
    End Sub
End Class