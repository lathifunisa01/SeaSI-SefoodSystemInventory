Imports MySql.Data.MySqlClient
Public Class pengguna

    Private Sub tabel()
        Try
            konek()
            Dim queryg As String = "SELECT id AS No, nama AS Nama, username AS Username, password AS Password FROM tbuser"
            Dim dag As New MySqlDataAdapter(queryg, conn)
            Dim dtg As New DataTable

            dag.Fill(dtg)

            tblpengguna.DataSource = dtg

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblpengguna.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblpengguna.Columns("Nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblpengguna.Columns("Username").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblpengguna.Columns("Password").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            txtnama.Clear()
            txtuser.Clear()
            txtpass.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub input()
        Try
            konek()
            Dim query As String = "INSERT INTO tbuser (nama, username, password) VALUES (@nama, @user, @pass)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Mengambil nilai dari kontrol formulir dan mengaturnya sebagai parameter
            cmd.Parameters.AddWithValue("@nama", txtnama.Text)
            cmd.Parameters.AddWithValue("@user", txtuser.Text)
            cmd.Parameters.AddWithValue("@pass", txtpass.Text)

            ' Eksekusi perintah SQL
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data pengguna berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            tabel()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub hapus()
        Dim row As Integer = tblpengguna.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan dihapus, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)

            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim id As String = tblpengguna.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)

                    Dim query As String = "DELETE FROM tbuser WHERE id = @id"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil dihapus!")
                    tabel() ' Ganti dengan metode untuk menampilkan ulang data di DataGridView

                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
        End If
    End Sub

    Private Sub edit()
        Dim row As Integer = tblpengguna.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan diedit, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)
            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim id As String = tblpengguna.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)
                    Dim query As String = "UPDATE tbuser SET nama = @Nama, username = @user, password = @pass WHERE id = @id"
                    Dim cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Nama", txtnama.Text)
                    cmd.Parameters.AddWithValue("@user", txtuser.Text)
                    cmd.Parameters.AddWithValue("@pass", txtpass.Text)
                    cmd.Parameters.AddWithValue("@id", id)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil diupdate!")
                    tabel()
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
        End If
    End Sub

    Private Sub caridata()
        Try
            Dim keyword As String = txtsearch.Text
            konek()
            Dim query As String = "SELECT id AS No, nama AS Nama, username AS Username, password AS Password FROM tbuser WHERE nama LIKE '%" & keyword & "%' OR username LIKE '%" & keyword & "%' OR password LIKE '%" & keyword & "%'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Mengisi DataGridView dengan hasil pencarian
            tblpengguna.DataSource = dt

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblpengguna.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblpengguna.Columns("Nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblpengguna.Columns("Username").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblpengguna.Columns("Password").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub pengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabel()
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        input()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        edit()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        hapus()
    End Sub

    Private Sub tblpengguna_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblpengguna.CellClick
        txtnama.Text = tblpengguna.CurrentRow.Cells(1).Value
        txtuser.Text = tblpengguna.CurrentRow.Cells(2).Value
        txtpass.Text = tblpengguna.CurrentRow.Cells(3).Value
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        caridata()
    End Sub
End Class