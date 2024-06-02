Imports MySql.Data.MySqlClient

Public Class datapemasok

    Private Sub tabel()
        Try
            konek()
            Dim queryg As String = "SELECT idpemasok AS No, namapemasok AS Nama, alamatpemasok AS Alamat, telepon AS Telepon FROM tbpemasok"
            Dim dag As New MySqlDataAdapter(queryg, conn)
            Dim dtg As New DataTable

            dag.Fill(dtg)

            tblpemasok.DataSource = dtg

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblpemasok.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblpemasok.Columns("Nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblpemasok.Columns("Alamat").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblpemasok.Columns("Telepon").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            txtnama.Clear()
            txtalamat.Clear()
            txttlp.Clear()

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
            Dim query As String = "INSERT INTO tbpemasok (namapemasok, alamatpemasok, telepon) VALUES (@nama, @alamat, @telepon)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Mengambil nilai dari kontrol formulir dan mengaturnya sebagai parameter
            cmd.Parameters.AddWithValue("@nama", txtnama.Text)
            cmd.Parameters.AddWithValue("@alamat", txtalamat.Text)
            cmd.Parameters.AddWithValue("@telepon", txttlp.Text)

            ' Eksekusi perintah SQL
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data pemasok berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
        Dim row As Integer = tblpemasok.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan dihapus, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)

            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim idpemasok As String = tblpemasok.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)

                    Dim query As String = "DELETE FROM tbpemasok WHERE idpemasok = @idpemasok"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idpemasok", idpemasok)

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
        Dim row As Integer = tblpemasok.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan diedit, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)
            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim id As String = tblpemasok.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)
                    Dim query As String = "UPDATE tbpemasok SET namapemasok = @Nama, alamatpemasok = @Alamat, telepon = @telepon WHERE idpemasok = @id"
                    Dim cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Nama", txtnama.Text)
                    cmd.Parameters.AddWithValue("@Alamat", txtalamat.Text)
                    cmd.Parameters.AddWithValue("@telepon", txttlp.Text)
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
            Dim query As String = "SELECT idpemasok AS No, namapemasok AS Nama, alamatpemasok AS Alamat, telepon AS Telepon FROM tbpemasok WHERE namapemasok LIKE '%" & keyword & "%' OR alamatpemasok LIKE '%" & keyword & "%' OR telepon LIKE '%" & keyword & "%'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Mengisi DataGridView dengan hasil pencarian
            tblpemasok.DataSource = dt

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblpemasok.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblpemasok.Columns("Nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblpemasok.Columns("Alamat").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblpemasok.Columns("Telepon").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Dim home As New home()
        home.Show()
        Me.Close()
    End Sub

    Private Sub tblpemasok_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblpemasok.CellClick
        txtnama.Text = tblpemasok.CurrentRow.Cells(1).Value
        txtalamat.Text = tblpemasok.CurrentRow.Cells(2).Value
        txttlp.Text = tblpemasok.CurrentRow.Cells(3).Value
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

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        caridata()
    End Sub

    Private Sub datapemasok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabel()
    End Sub
End Class