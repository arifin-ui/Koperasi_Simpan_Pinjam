Imports System.data.odbc
Public Class Form_login

    Private Sub Form_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Labelcopyright.Text = My.Application.Info.Copyright + " FEBI ARIFIN"
        koneksi()
        txtuser.Focus()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        labelwaktu.Text = TimeOfDay
        Labeltanggal.Text = Today
    End Sub

    Private Sub Labeltanggal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Labeltanggal.Click
        Labeltanggal.Text = DateTimePickerFormat.Long
    End Sub

    Private Sub GunaImageButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaImageButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GunaImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GunaImageButton1.Click
        If MsgBox("Yakin ingin close ?", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtuser.Text = "" Or txtpas.Text = "" Then
            MsgBox("Username  Dan Password Tidak Boleh Kosong", vbInformation)
            txtuser.Focus()
        Else

            cmd = New OdbcCommand
            cmd.Connection = con
            query = "select*from petugas where username='" & txtuser.Text & "' and password='" & txtpas.Text & "'"
            cmd.CommandText = query
            da = New OdbcDataAdapter(query, con)
            dt = New DataTable()
            Try
                da.Fill(dt)
                If dt.Rows.Count() <= 0 Then
                    MsgBox("Username dan Password salah", vbInformation)
                    txtuser.Text = ""
                    txtpas.Text = ""
                    txtuser.Focus()
                Else
                    Form_dashboard.Show()
                    Me.Visible = False
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If e.KeyChar = Chr(13) Then txtpas.Focus()
    End Sub

    Private Sub txtpas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpas.KeyPress
        If e.KeyChar = Chr(13) Then btnlogin.Focus()
    End Sub
End Class