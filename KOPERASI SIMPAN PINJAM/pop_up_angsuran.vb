Imports System.Data.Odbc
Public Class pop_up_angsuran

    Private Sub pop_up_angsuran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        angsuran()
    End Sub
    Sub angsuran()
        ds = New DataSet
        query = "select id_angsuran from angsuran"
        da = New odbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            dataangsuran.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GunaLineTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.Click
        GunaLineTextBox1.Text = ""
        GunaLineTextBox1.Focus()
    End Sub

    Private Sub GunaLineTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaLineTextBox1.TextChanged
        ds = New DataSet
        query = "select id_angsuran from angsuran where id_angsuran like '%" & GunaLineTextBox1.Text & "%'"
        da = New odbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            dataangsuran.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dataangsuran_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataangsuran.CellClick
        Dim i As Integer
        i = dataangsuran.CurrentRow.Index
        Try
            Form_dashboard.txtid_angsuran_pinjaman.Text = dataangsuran.Item(0, i).Value
        Catch ex As Exception

        End Try
    End Sub
End Class