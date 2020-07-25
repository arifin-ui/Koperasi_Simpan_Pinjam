Imports System.data.odbc
Public Class pop_up_profil

    Private Sub pop_up_profil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        profil()
    End Sub
    Sub profil()
        dt = New DataTable()
        query = "select*from petugas where nama='" & Form_dashboard.Labelnama.Text & "'"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(dt)
            id.Text = dt.Rows(0)(0)
            nama.Text = dt.Rows(0)(1)
            tlp.Text = dt.Rows(0)(5)
            alamat.Text = dt.Rows(0)(4)
            username.Text = dt.Rows(0)(2)
        Catch ex As Exception
        End Try
    End Sub
End Class