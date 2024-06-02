Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class datagudang
    Private Sub tabel()
        Try
            konek()
            Dim queryg As String = "SELECT idgudang AS 'No', namagudang AS 'Nama', alamatgudang AS 'Alamat' FROM tbgudang"
            Dim dag As New MySqlDataAdapter(queryg, conn)
            Dim dtg As New DataTable

            dag.Fill(dtg)

            tblgudang.DataSource = dtg

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblgudang.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblgudang.Columns("Nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblgudang.Columns("Alamat").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            txtnama.Clear()
            txtalamat.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub



    Private Sub SimpanDataGudang()
        Try
            konek()
            Dim query As String = "INSERT INTO tbgudang (namagudang, alamatgudang) VALUES (@namaGudang, @alamatGudang)"
            Dim cmd As New MySqlCommand(query, conn)

            ' Mengambil nilai dari kontrol formulir dan mengaturnya sebagai parameter
            cmd.Parameters.AddWithValue("@namaGudang", txtnama.Text)
            cmd.Parameters.AddWithValue("@alamatGudang", txtalamat.Text)

            ' Eksekusi perintah SQL
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data gudang berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
        Dim row As Integer = tblgudang.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan dihapus, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)

            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim idgudang As String = tblgudang.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)

                    Dim query As String = "DELETE FROM tbgudang WHERE idgudang = @idgudang"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idgudang", idgudang)

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
        Dim row As Integer = tblgudang.CurrentRow.Index ' Ganti DataGridView1 dengan nama DataGridView Anda

        If row < 0 Then
            MessageBox.Show("Silakan pilih data yang akan dihapus!")
            Return
        Else
            Dim jawab As Integer = MessageBox.Show("Data ini akan diedit, lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo)
            If jawab = DialogResult.Yes Then
                Try
                    konek()
                    Dim idgudang As String = tblgudang.Rows(row).Cells(0).Value.ToString() ' Mengambil nilai dari kolom pertama (kolom ID)
                    Dim query As String = "UPDATE tbgudang SET namagudang = @Nama, alamatgudang = @Alamat WHERE idgudang = @IDGudang"
                    Dim cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Nama", txtnama.Text)
                    cmd.Parameters.AddWithValue("@Alamat", txtalamat.Text)
                    cmd.Parameters.AddWithValue("@IDGudang", idgudang)

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
            Dim query As String = "SELECT idgudang AS No, namagudang AS Nama, alamatgudang AS Alamat FROM tbgudang WHERE namagudang LIKE '%" & keyword & "%' OR alamatgudang LIKE '%" & keyword & "%'"
            Dim cmd As New MySqlCommand(query, conn)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            ' Mengisi DataGridView dengan hasil pencarian
            tblgudang.DataSource = dt

            ' Mengatur AutoSizeMode untuk kolom "No", "Nama", dan "Alamat"
            tblgudang.Columns("No").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            tblgudang.Columns("Nama").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            tblgudang.Columns("Alamat").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub







    Private Sub datagudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabel()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub tblgudang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Dim home As New home()
        home.Show()
        Me.Close()
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        SimpanDataGudang()
    End Sub

    Private Sub tblgudang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblgudang.CellClick
        txtnama.Text = tblgudang.CurrentRow.Cells(1).Value
        txtalamat.Text = tblgudang.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        hapus()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        edit()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        CariData()
    End Sub
End Class