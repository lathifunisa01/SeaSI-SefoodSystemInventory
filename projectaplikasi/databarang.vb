Imports MySql.Data.MySqlClient

Public Class databarang
    Private Sub combobox()
        Try
            konek()
            Dim query As String = "SELECT idgudang, namagudang FROM tbgudang"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim idgudang As String = Convert.ToInt32(reader("idgudang"))
                        Dim namagudang As String = reader("namagudang").ToString()
                        Dim item As New With {.id = idgudang, .name = namagudang}
                        cbgudang.Items.Add(item)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub tabel()
        Try
            konek()
            Dim query As String = "SELECT idbarang, namabarang, jenis, namagudang, stok FROM tbbarang"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable

            ' Tambahkan kolom ke DataTable dengan nama yang sesuai
            dt.Columns.Add("No")
            dt.Columns.Add("Nama")
            dt.Columns.Add("Jenis")
            dt.Columns.Add("Gudang")
            dt.Columns.Add("Stok")

            da.Fill(dt)

            ' Mengisi kolom "No" dengan IDBarang
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("No") = dt.Rows(i)("idbarang")
            Next

            ' Hapus kolom "IDBarang" jika tidak ingin menampilkannya
            dt.Columns.Remove("idbarang")

            tblbarang.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub input()
        Dim selectedgudangid As Integer = DirectCast(cbgudang.SelectedItem, Object).id
        Dim selectedgudangname As String = DirectCast(cbgudang.SelectedItem, Object).name
        Try
            konek()
            Dim query As String = "INSERT INTO tbbarang (namabarang, jenis, idgudang, namagudang, stok) VALUES (@namabarang, @jenis, @idgudang, @namagudang, @stok)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Mengambil nilai dari kontrol formulir dan mengaturnya sebagai parameter
            cmd.Parameters.AddWithValue("@namabarang", txtnama.Text)
            cmd.Parameters.AddWithValue("@jenis", cbjenis.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@idgudang", selectedgudangid)
            cmd.Parameters.AddWithValue("@namagudang", selectedgudangname)
            cmd.Parameters.AddWithValue("@stok", Integer.Parse(txtstok.Text))

            ' Eksekusi perintah SQL
            cmd.ExecuteNonQuery()

            ' Setelah berhasil disimpan, Anda dapat memperbarui tampilan DataGridView
            tabel()

            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Mengosongkan kontrol input setelah penyimpanan
            txtnama.Clear()
            cbjenis.SelectedIndex = -1
            cbgudang.SelectedIndex = -1
            txtstok.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub hapus()
        Dim row As Integer = tblbarang.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan dihapus, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)

            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim id As String = tblbarang.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)

                    Dim query As String = "DELETE FROM tbbarang WHERE idbarang = @id"
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
        Dim selectedgudangid As Integer = DirectCast(cbgudang.SelectedItem, Object).id
        Dim selectedgudangname As String = DirectCast(cbgudang.SelectedItem, Object).name
        Dim row As Integer = tblbarang.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan diedit, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)
            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim id As String = tblbarang.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)
                    Dim query As String = "UPDATE tbbarang SET namabarang = @Nama, jenis = @jenis, idgudang = @idgudang, namagudang = @namagudang stok = @stok WHERE idbarang = @id"
                    Dim cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Nama", txtnama.Text)
                    cmd.Parameters.AddWithValue("@jenis", cbjenis.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@idgudang", selectedgudangid)
                    cmd.Parameters.AddWithValue("@namagudang", selectedgudangname)
                    cmd.Parameters.AddWithValue("@stok", Integer.Parse(txtstok.Text))
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
            Dim query As String = "SELECT SELECT idbarang AS 'No', namabarang AS 'Nama', jenis AS 'Jenis', namagudang AS 'Gudang', stok AS 'Stok' FROM tbbarang WHERE idbarang LIKE '%" & keyword & "%' OR namabarang LIKE '%" & keyword & "%' OR jenis LIKE '%" & keyword & "%' OR namagudang LIKE '%" & keyword & "%'OR stok LIKE '%" & keyword & "%'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Mengisi DataGridView dengan hasil pencarian
            tblbarang.DataSource = dt

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblbarang.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblbarang.Columns("Nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblbarang.Columns("Jenis").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblbarang.Columns("Gudang").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblbarang.Columns("Stok").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub databarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabel()
        combobox()
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Dim home As New home()
        home.Show()
        Me.Hide()
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
End Class