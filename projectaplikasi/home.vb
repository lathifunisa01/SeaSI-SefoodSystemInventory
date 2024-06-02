Public Class home
    Private Sub btndatabarang_Click(sender As Object, e As EventArgs) Handles btndatabarang.Click
        Dim databarang As New databarang()
        databarang.Show()
        Me.Close()
    End Sub

    Private Sub btndatagudang_Click(sender As Object, e As EventArgs) Handles btndatagudang.Click
        Dim datagudang As New datagudang()
        datagudang.Show()
        Me.Close()
    End Sub

    Private Sub btnpelanggan_Click(sender As Object, e As EventArgs) Handles btnpelanggan.Click
        Dim datapelanggan As New datapelanggan()
        datapelanggan.Show()
        Me.Close()
    End Sub

    Private Sub btnpemasok_Click(sender As Object, e As EventArgs) Handles btnpemasok.Click
        Dim datapemasok As New datapemasok()
        datapemasok.Show()
        Me.Close()
    End Sub

    Private Sub btnpengguna_Click(sender As Object, e As EventArgs) Handles btnpengguna.Click
        pengguna.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub btnmasuk_Click(sender As Object, e As EventArgs) Handles btnmasuk.Click
        barangmasuk.Show()
        Me.Close()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        barangkeluar.Show()
        Me.Close()
    End Sub
End Class