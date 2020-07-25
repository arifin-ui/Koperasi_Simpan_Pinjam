Imports System.Data.Odbc
Public Class pop_up_anggota

    Private Sub GunaDataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataanggota.CellClick
        Dim i As Integer
        i = dataanggota.CurrentRow.Index
        Try
            Form_dashboard.txtid_anggota_simpanan.Text = dataanggota.Item(0, i).Value
            Form_dashboard.txtid_anggota_pinjaman.Text = dataanggota.Item(0, i).Value
            Form_dashboard.txtid_anggota_angsuran.Text = dataanggota.Item(0, i).Value
        Catch ex As Exception

        End Try
    End Sub
    Sub anggota()
        ds = New DataSet
        query = "select id_anggota,nama from anggota"
        da = New odbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            dataanggota.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub pop_up_anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        anggota()
    End Sub

    Private Sub GunaLineTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.TextChanged
        ds = New DataSet
        query = "select id_anggota,nama from anggota where nama like '%" & GunaLineTextBox1.Text & "%'"
        da = New odbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            dataanggota.DataSource = ds.Tables(0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GunaLineTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.Click
        GunaLineTextBox1.Text = ""
        GunaLineTextBox1.Focus()
    End Sub
End Class