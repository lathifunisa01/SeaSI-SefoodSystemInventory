<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btndatabarang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndatagudang = New System.Windows.Forms.Button()
        Me.btnpelanggan = New System.Windows.Forms.Button()
        Me.btnpemasok = New System.Windows.Forms.Button()
        Me.btnpengguna = New System.Windows.Forms.Button()
        Me.btnmasuk = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btndatabarang
        '
        Me.btndatabarang.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btndatabarang.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btndatabarang.Location = New System.Drawing.Point(12, 120)
        Me.btndatabarang.Name = "btndatabarang"
        Me.btndatabarang.Size = New System.Drawing.Size(165, 75)
        Me.btndatabarang.TabIndex = 6
        Me.btndatabarang.Text = "Data Barang"
        Me.btndatabarang.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(348, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 43)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Home"
        '
        'btndatagudang
        '
        Me.btndatagudang.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btndatagudang.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btndatagudang.Location = New System.Drawing.Point(218, 120)
        Me.btndatagudang.Name = "btndatagudang"
        Me.btndatagudang.Size = New System.Drawing.Size(165, 75)
        Me.btndatagudang.TabIndex = 8
        Me.btndatagudang.Text = "Data Gudang"
        Me.btndatagudang.UseVisualStyleBackColor = False
        '
        'btnpelanggan
        '
        Me.btnpelanggan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnpelanggan.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnpelanggan.Location = New System.Drawing.Point(424, 120)
        Me.btnpelanggan.Name = "btnpelanggan"
        Me.btnpelanggan.Size = New System.Drawing.Size(165, 75)
        Me.btnpelanggan.TabIndex = 9
        Me.btnpelanggan.Text = "Data Pelanggan"
        Me.btnpelanggan.UseVisualStyleBackColor = False
        '
        'btnpemasok
        '
        Me.btnpemasok.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnpemasok.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnpemasok.Location = New System.Drawing.Point(623, 120)
        Me.btnpemasok.Name = "btnpemasok"
        Me.btnpemasok.Size = New System.Drawing.Size(165, 75)
        Me.btnpemasok.TabIndex = 10
        Me.btnpemasok.Text = "Data Pemasok"
        Me.btnpemasok.UseVisualStyleBackColor = False
        '
        'btnpengguna
        '
        Me.btnpengguna.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnpengguna.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnpengguna.Location = New System.Drawing.Point(539, 233)
        Me.btnpengguna.Name = "btnpengguna"
        Me.btnpengguna.Size = New System.Drawing.Size(165, 75)
        Me.btnpengguna.TabIndex = 11
        Me.btnpengguna.Text = "Pengguna"
        Me.btnpengguna.UseVisualStyleBackColor = False
        '
        'btnmasuk
        '
        Me.btnmasuk.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnmasuk.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnmasuk.Location = New System.Drawing.Point(83, 233)
        Me.btnmasuk.Name = "btnmasuk"
        Me.btnmasuk.Size = New System.Drawing.Size(165, 75)
        Me.btnmasuk.TabIndex = 12
        Me.btnmasuk.Text = "Barang Masuk"
        Me.btnmasuk.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(623, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 40)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnkeluar.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnkeluar.Location = New System.Drawing.Point(321, 233)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(165, 75)
        Me.btnkeluar.TabIndex = 14
        Me.btnkeluar.Text = "Barang Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 370)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnmasuk)
        Me.Controls.Add(Me.btnpengguna)
        Me.Controls.Add(Me.btnpemasok)
        Me.Controls.Add(Me.btnpelanggan)
        Me.Controls.Add(Me.btndatagudang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndatabarang)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btndatabarang As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btndatagudang As Button
    Friend WithEvents btnpelanggan As Button
    Friend WithEvents btnpemasok As Button
    Friend WithEvents btnpengguna As Button
    Friend WithEvents btnmasuk As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnkeluar As Button
End Class
