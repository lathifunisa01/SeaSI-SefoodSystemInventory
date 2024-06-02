<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class barangkeluar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.cbbarang = New System.Windows.Forms.ComboBox()
        Me.cbpelanggan = New System.Windows.Forms.ComboBox()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btninput = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.tblkeluar = New System.Windows.Forms.DataGridView()
        CType(Me.tblkeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 43)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Barang Keluar"
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnhome.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnhome.Location = New System.Drawing.Point(632, 17)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(126, 43)
        Me.btnhome.TabIndex = 20
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 84)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 29)
        Me.label2.TabIndex = 22
        Me.label2.Text = "Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 29)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Pelanggan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 29)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 29)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Jumlah Masuk"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnsearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnsearch.Location = New System.Drawing.Point(17, 250)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(108, 50)
        Me.btnsearch.TabIndex = 35
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'cbbarang
        '
        Me.cbbarang.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbarang.FormattingEnabled = True
        Me.cbbarang.Location = New System.Drawing.Point(172, 81)
        Me.cbbarang.Name = "cbbarang"
        Me.cbbarang.Size = New System.Drawing.Size(400, 37)
        Me.cbbarang.TabIndex = 36
        '
        'cbpelanggan
        '
        Me.cbpelanggan.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpelanggan.FormattingEnabled = True
        Me.cbpelanggan.Location = New System.Drawing.Point(172, 124)
        Me.cbpelanggan.Name = "cbpelanggan"
        Me.cbpelanggan.Size = New System.Drawing.Size(400, 37)
        Me.cbpelanggan.TabIndex = 37
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(172, 167)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(400, 36)
        Me.txtdate.TabIndex = 38
        Me.txtdate.Value = New Date(2023, 10, 4, 13, 57, 3, 0)
        '
        'txtstok
        '
        Me.txtstok.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstok.Location = New System.Drawing.Point(172, 209)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(400, 36)
        Me.txtstok.TabIndex = 39
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(172, 255)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(240, 36)
        Me.txtsearch.TabIndex = 40
        '
        'btninput
        '
        Me.btninput.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btninput.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btninput.Location = New System.Drawing.Point(578, 81)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(233, 58)
        Me.btninput.TabIndex = 41
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnedit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnedit.Location = New System.Drawing.Point(578, 161)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(233, 58)
        Me.btnedit.TabIndex = 42
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btndelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btndelete.Location = New System.Drawing.Point(578, 246)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(233, 58)
        Me.btndelete.TabIndex = 43
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'tblkeluar
        '
        Me.tblkeluar.AllowUserToAddRows = False
        Me.tblkeluar.AllowUserToDeleteRows = False
        Me.tblkeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblkeluar.Location = New System.Drawing.Point(17, 310)
        Me.tblkeluar.Name = "tblkeluar"
        Me.tblkeluar.ReadOnly = True
        Me.tblkeluar.RowHeadersVisible = False
        Me.tblkeluar.RowHeadersWidth = 62
        Me.tblkeluar.RowTemplate.Height = 28
        Me.tblkeluar.Size = New System.Drawing.Size(799, 173)
        Me.tblkeluar.TabIndex = 44
        '
        'barangkeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 494)
        Me.Controls.Add(Me.tblkeluar)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.cbpelanggan)
        Me.Controls.Add(Me.cbbarang)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Label1)
        Me.Name = "barangkeluar"
        Me.Text = "barangkeluar"
        CType(Me.tblkeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnhome As Button
    Friend WithEvents label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents cbbarang As ComboBox
    Friend WithEvents cbpelanggan As ComboBox
    Friend WithEvents txtdate As DateTimePicker
    Friend WithEvents txtstok As TextBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btninput As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents tblkeluar As DataGridView
End Class
