Imports MySql.Data.MySqlClient

Module modulkoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public ds As DataSet
    Public dt As New DataTable
    Public str As String
    Public x As Integer

    Sub konek()
        Dim lokasidata As String
        lokasidata = "Server=localhost;Database=aplikasigudang;User=root;Password= ;"
        conn = New MySqlConnection(lokasidata)
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Database tidak terhubung!" & vbCrLf & ex.Message)
        End Try
    End Sub
End Module
