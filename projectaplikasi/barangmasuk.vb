Imports System.Globalization
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports MySql.Data.MySqlClient

Public Class barangmasuk
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

    Private Sub comboboxpemasok()
        Try
            konek()
            Dim query As String = "SELECT idpemasok, namapemasok FROM tbpemasok"

            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim idpemasok As String = Convert.ToInt32(reader("idpemasok"))
                        Dim namapemasok As String = reader("namapemasok").ToString()
                        Dim item As New With {.id = idpemasok, .name = namapemasok}
                        cbpemasok.Items.Add(item)
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

    Private Sub tambahstok(idbarang As Integer, stokmasuk As Integer)
        Try
            konek()
            Dim query As String = "UPDATE tbbarang SET stok = stok + @jumlahMasuk WHERE idbarang = @idBarang"
            Dim cmd As New MySqlCommand(query, conn)

            ' Gantilah dengan nilai yang sesuai dari objek bk
            cmd.Parameters.AddWithValue("@jumlahMasuk", stokmasuk)
            cmd.Parameters.AddWithValue("@idBarang", idbarang)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tabel()
        Try
            konek()
            Dim queryg As String = "SELECT idbarangmasuk AS 'No', namabarang AS 'Nama Barang', namapemasok AS 'Pemasok', tanggalmasuk AS 'Tanggal Masuk', jumlahmasuk AS 'Jumlah Masuk' FROM tbbarangmasuk"
            Dim dag As New MySqlDataAdapter(queryg, conn)
            Dim dtg As New DataTable

            dag.Fill(dtg)

            tblmasuk.DataSource = dtg

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblmasuk.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblmasuk.Columns("Nama Barang").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblmasuk.Columns("Pemasok").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblmasuk.Columns("Tanggal Masuk").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblmasuk.Columns("Jumlah Masuk").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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
        Dim selectedpemasokid As Integer = DirectCast(cbpemasok.SelectedItem, Object).id
        Dim selectedpemasokname As String = DirectCast(cbpemasok.SelectedItem, Object).name

        Dim stokmasuk As Integer = Integer.Parse(txtstok.Text)
        Try
            konek()
            Dim query As String = "INSERT INTO tbbarangmasuk (idbarang, namabarang, idpemaosok, namapemasok, tanggalmasuk, jumlahmasuk) VALUES (@idbarang, @namabarang, @idpemasok, @namapemasok, @tanggalmasuk, @jumlahmasuk)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Mengambil nilai dari kontrol formulir dan mengaturnya sebagai parameter
            cmd.Parameters.AddWithValue("@idbarang", selectedbarangid)
            cmd.Parameters.AddWithValue("@namabarang", selectedbarangname)
            cmd.Parameters.AddWithValue("@idpemasok", selectedpemasokid)
            cmd.Parameters.AddWithValue("@namapemasok", selectedpemasokname)
            cmd.Parameters.AddWithValue("@tanggalmasuk", Format(txtdate.Value, "yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@jumlahmasuk", stokmasuk)

            ' Eksekusi perintah SQL
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Barang Masuk berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            tabel()
            tambahstok(selectedbarangid, stokmasuk)

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
        Dim selectedpemasokid As Integer = DirectCast(cbpemasok.SelectedItem, Object).id
        Dim selectedpemasokname As String = DirectCast(cbpemasok.SelectedItem, Object).name
        Dim stokmasuk As Integer = Integer.Parse(txtstok.Text)
        Dim row As Integer = tblmasuk.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan diedit, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)
            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim id As String = tblmasuk.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)
                    Dim query As String = "UPDATE tbbarangmasuk SET idbarang = @idbarang, namabarang = @Nama,idpemasok = @idpemasok namapemasok = @Pemasok, tanggalmasuk = @tanggalmasuk, jumlahmasuk = @jumlahmasuk WHERE idbarangmasuk = @ID"
                    Dim cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@idpemasok", selectedbarangid)
                    cmd.Parameters.AddWithValue("@Nama", selectedbarangname)
                    cmd.Parameters.AddWithValue("@idpemasok", selectedpemasokid)
                    cmd.Parameters.AddWithValue("@Pemasok", selectedpemasokname)
                    cmd.Parameters.AddWithValue("@tanggalmasuk", Format(txtdate.Value, "yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@jumlahmasuk", stokmasuk)
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
        Dim row As Integer = tblmasuk.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan dihapus, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)

            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim id As String = tblmasuk.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)

                    Dim query As String = "DELETE FROM tbbarangmasuk WHERE idbarangmasuk = @id"
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
            Dim query As String = "SELECT idbarangmasuk AS 'No', namabarang AS 'Nama Barang', namapemasok AS 'Pemasok', tanggalmasuk AS 'Tanggal Masuk', jumlahmasuk AS 'Jumlah Masuk' FROM tbbarangmasuk WHERE namabarang LIKE '%" & keyword & "%' OR namapemasok LIKE '%" & keyword & "%' OR tanggalmasuk LIKE '%" & keyword & "%' OR jumlahmasuk LIKE '%" & keyword & "%'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Mengisi DataGridView dengan hasil pencarian
            tblmasuk.DataSource = dt

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblmasuk.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblmasuk.Columns("Nama Barang").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblmasuk.Columns("Pemasok").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblmasuk.Columns("Tanggal Masuk").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblmasuk.Columns("Jumlah Masuk").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub barangmasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboboxbarang()
        comboboxpemasok()
        tabel()
        txtdate.Value = DateTime.Now
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        input()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        edit()
    End Sub

    Private Sub tblmasuk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblmasuk.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = tblmasuk.Rows(e.RowIndex)
            cbbarang.Text = row.Cells("Nama Barang").Value.ToString()
            cbpemasok.Text = row.Cells("Pemasok").Value.ToString()
            txtdate.Value = DateTime.Parse(row.Cells("Tanggal Masuk").Value.ToString())
            txtstok.Text = row.Cells("Jumlah Masuk").Value.ToString()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        hapus()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        caridata()
    End Sub
End Class