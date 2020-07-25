Imports System.Data.Odbc
Module Module_koneksi
    Public con As OdbcConnection
    Public query As String
    Public cmd As OdbcCommand
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public rd As OdbcDataReader
    Public dt As DataTable

    Sub koneksi()
        con = New OdbcConnection("DSN=koperasi")
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox("KONEKSI GAGAL!", vbInformation)
        End Try
    End Sub

End Module
