Imports MySql.Data.MySqlClient
Public Class barangkeluar

    Private Sub comboboxbarang()
        Try
            konek()
            Dim query As String = "SELECT idbarang, namabarang FROM tbbarang"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim idbarang As String = Convert.ToInt32(reader("idbarang"))
                        Dim namabarang As String = reader("namabarang").ToString()
                        Dim item As New With {.id = idbarang, .name = namabarang}
                        cbbarang.Items.Add(item)
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

    Private Sub comboboxpelanggan()
        Try
            konek()
            Dim query As String = "SELECT idpelanggan, namapelanggan FROM tbpelanggan"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim idpelanggan As String = Convert.ToInt32(reader("idpelanggan"))
                        Dim namapelanggan As String = reader("namapelanggan").ToString()
                        Dim item As New With {.id = idpelanggan, .name = namapelanggan}
                        cbpelanggan.Items.Add(item)
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

    Private Sub kurangstok(idbarang As Integer, stokkeluar As Integer)
        Try
            konek()
            Dim query As String = "UPDATE tbbarang SET stok = stok - @jumlahkeluar WHERE idbarang = @idbarang"
            Dim cmd As New MySqlCommand(query, conn)

            ' Gantilah dengan nilai yang sesuai dari objek bk
            cmd.Parameters.AddWithValue("@jumlahkeluar", stokkeluar)
            cmd.Parameters.AddWithValue("@idbarang", idbarang)

            conn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tabel()
        Try
            konek()
            Dim queryg As String = "SELECT idbarangkeluar AS 'No', namabarang AS 'Nama Barang', namapelanggan AS 'Pelanggan', tanggalkeluar AS 'Tanggal Keluar', jumlahkeluar AS 'Jumlah Keluar' FROM tbbarangkeluar"
            Dim dag As New MySqlDataAdapter(queryg, conn)
            Dim dtg As New DataTable

            dag.Fill(dtg)

            tblkeluar.DataSource = dtg

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblkeluar.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblkeluar.Columns("Nama Barang").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblkeluar.Columns("Pelanggan").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblkeluar.Columns("Tanggal Keluar").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblkeluar.Columns("Jumlah Keluar").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            txtstok.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub input()
        Dim selectedbarangid As Integer = DirectCast(cbbarang.SelectedItem, Object).id
        Dim selectedbarangname As String = DirectCast(cbbarang.SelectedItem, Object).name
        Dim selectedpelangganid As Integer = DirectCast(cbpelanggan.SelectedItem, Object).id
        Dim selectedpelangganname As String = DirectCast(cbpelanggan.SelectedItem, Object).name

        Dim stokkeluar As Integer = Integer.Parse(txtstok.Text)
        Try
            konek()
            Dim query As String = "INSERT INTO tbbarangkeluar (idbarang, namabarang, idpelanggan, namapelanggan, tanggalkeluar, jumlahkeluar) VALUES (@idbarang, @namabarang, @idpelanggan, @namapelanggan, @tanggalkeluar, @jumlahkeluar)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Mengambil nilai dari kontrol formulir dan mengaturnya sebagai parameter
            cmd.Parameters.AddWithValue("@idbarang", selectedbarangid)
            cmd.Parameters.AddWithValue("@namabarang", selectedbarangname)
            cmd.Parameters.AddWithValue("@idpelanggan", selectedpelangganid)
            cmd.Parameters.AddWithValue("@namaPelanggan", selectedpelangganid)
            cmd.Parameters.AddWithValue("@tanggalkeluar", Format(txtdate.Value, "yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@jumlahkeluar", stokkeluar)

            ' Eksekusi perintah SQL
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Barang Masuk berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            tabel()
            kurangstok(selectedbarangid, stokkeluar)

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub edit()
        Dim selectedbarangid As Integer = DirectCast(cbbarang.SelectedItem, Object).id
        Dim selectedbarangname As String = DirectCast(cbbarang.SelectedItem, Object).name
        Dim selectedpelangganid As Integer = DirectCast(cbpelanggan.SelectedItem, Object).id
        Dim selectedpelangganname As String = DirectCast(cbpelanggan.SelectedItem, Object).name

        Dim stokkeluar As Integer = Integer.Parse(txtstok.Text)
        Dim row As Integer = tblkeluar.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan diedit, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)
            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim id As String = tblkeluar.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)
                    Dim query As String = "UPDATE tbbarangkeluar SET idbarang = @idbarang, namabarang = @Nama, idpelanggan = @idpelanggan namapelanggan = @Pelanggan, tanggalkeluar = @tanggalkeluar, jumlahkeluar = @jumlahkeluar WHERE idbarangkeluar = @ID"
                    Dim cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@idbarang", selectedbarangid)
                    cmd.Parameters.AddWithValue("@Nama", selectedbarangname)
                    cmd.Parameters.AddWithValue("@idpemasok", selectedpelangganid)
                    cmd.Parameters.AddWithValue("@Pelanggan", selectedpelangganname)
                    cmd.Parameters.AddWithValue("@tanggalkeluar", Format(txtdate.Value, "yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@jumlahkeluar", stokkeluar)
                    cmd.Parameters.AddWithValue("@ID", id)

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

    Private Sub hapus()
        Dim row As Integer = tblkeluar.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan dihapus, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)

            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim id As String = tblkeluar.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)

                    Dim query As String = "DELETE FROM tbbarangkeluar WHERE idbarangkeluar = @id"
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

    Private Sub caridata()
        Try
            Dim keyword As String = txtsearch.Text
            konek()
            Dim query As String = "SELECT idbarangkeluar AS 'No', namabarang AS 'Nama Barang', namapelanggan AS 'Pelanggan', tanggalkeluar AS 'Tanggal Keluar', jumlahkeluar AS 'Jumlah Keluar' FROM tbbarangkeluar WHERE namabarang LIKE '%" & keyword & "%' OR namapelanggan LIKE '%" & keyword & "%' OR tanggalkeluar LIKE '%" & keyword & "%' OR jumlahkeluar LIKE '%" & keyword & "%'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Mengisi DataGridView dengan hasil pencarian
            tblkeluar.DataSource = dt

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblkeluar.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblkeluar.Columns("Nama Barang").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblkeluar.Columns("Pelanggan").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblkeluar.Columns("Tanggal Keluar").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblkeluar.Columns("Jumlah Keluar").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
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

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub tblkeluar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblkeluar.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = tblkeluar.Rows(e.RowIndex)
            cbbarang.Text = row.Cells("Nama Barang").Value.ToString()
            cbpelanggan.Text = row.Cells("Pelanggan").Value.ToString()
            txtdate.Value = DateTime.Parse(row.Cells("Tanggal Keluar").Value.ToString())
            txtstok.Text = row.Cells("Jumlah Keluar").Value.ToString()
        End If
    End Sub

    Private Sub barangkeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboboxbarang()
        comboboxpelanggan()
        tabel()
        txtdate.Value = DateTime.Now
    End Sub
End Class