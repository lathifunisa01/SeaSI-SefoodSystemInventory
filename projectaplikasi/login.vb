Imports MySql.Data.MySqlClient

Public Class login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        konek()
        cmd = New MySqlCommand("SELECT * FROM tbuser WHERE username=@username AND password=@password", conn)
        cmd.Parameters.AddWithValue("@username", txtuser.Text)
        cmd.Parameters.AddWithValue("@password", txtpass.Text)

        dr = cmd.ExecuteReader
        If dr.Read() Then
            MessageBox.Show("Login Berhasil, Selamat datang " + dr("nama").ToString() + "!")
            Me.Hide()
            home.Show()
        Else
            MessageBox.Show("Login Gagal! Username atau Password anda salah")
            txtpass.Focus()
        End If
        dr.Close()
    End Sub


    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged

    End Sub
End Class
