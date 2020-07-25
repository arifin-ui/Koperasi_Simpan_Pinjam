Public Class pop_up_laporan

    Private Sub angsuran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles angsuran.Click
        Try
        AxCrystalReport1.ReportFileName = "laporan_angsuran.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pop_up_laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub pinjaman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pinjaman.Click
        Try
            AxCrystalReport1.ReportFileName = "laporan_pinjaman.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub simpanan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpanan.Click
        Try


            AxCrystalReport1.ReportFileName = "laporan_simpanan.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
        Catch ex As Exception

        End Try
    End Sub
End Class