<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class databarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.cbjenis = New System.Windows.Forms.ComboBox()
        Me.cbgudang = New System.Windows.Forms.ComboBox()
        Me.tblbarang = New System.Windows.Forms.DataGridView()
        Me.btninput = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnhome = New System.Windows.Forms.Button()
        CType(Me.tblbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Barang"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 101)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(75, 29)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Nama"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(149, 98)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(400, 36)
        Me.txtnama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 29)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Stok"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 29)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Gudang"
        '
        'txtstok
        '
        Me.txtstok.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstok.Location = New System.Drawing.Point(149, 227)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(400, 36)
        Me.txtstok.TabIndex = 9
        '
        'cbjenis
        '
        Me.cbjenis.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.Items.AddRange(New Object() {"Ikan Segar", "Ikan Beku", "Lobster Segar", "Lobster Beku"})
        Me.cbjenis.Location = New System.Drawing.Point(149, 140)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.Size = New System.Drawing.Size(400, 37)
        Me.cbjenis.TabIndex = 10
        '
        'cbgudang
        '
        Me.cbgudang.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgudang.FormattingEnabled = True
        Me.cbgudang.Location = New System.Drawing.Point(149, 182)
        Me.cbgudang.Name = "cbgudang"
        Me.cbgudang.Size = New System.Drawing.Size(400, 37)
        Me.cbgudang.TabIndex = 11
        '
        'tblbarang
        '
        Me.tblbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblbarang.Location = New System.Drawing.Point(12, 325)
        Me.tblbarang.Name = "tblbarang"
        Me.tblbarang.RowHeadersVisible = False
        Me.tblbarang.RowHeadersWidth = 62
        Me.tblbarang.RowTemplate.Height = 28
        Me.tblbarang.Size = New System.Drawing.Size(771, 173)
        Me.tblbarang.TabIndex = 12
        '
        'btninput
        '
        Me.btninput.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btninput.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btninput.Location = New System.Drawing.Point(555, 98)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(233, 58)
        Me.btninput.TabIndex = 13
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnedit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnedit.Location = New System.Drawing.Point(555, 173)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(233, 58)
        Me.btnedit.TabIndex = 14
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btndelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btndelete.Location = New System.Drawing.Point(555, 247)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(233, 58)
        Me.btndelete.TabIndex = 15
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnsearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnsearch.Location = New System.Drawing.Point(17, 269)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(108, 50)
        Me.btnsearch.TabIndex = 16
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(149, 274)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(240, 36)
        Me.txtsearch.TabIndex = 17
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnhome.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnhome.Location = New System.Drawing.Point(607, 35)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(126, 43)
        Me.btnhome.TabIndex = 18
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'databarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 510)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.tblbarang)
        Me.Controls.Add(Me.cbgudang)
        Me.Controls.Add(Me.cbjenis)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "databarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "databarang"
        CType(Me.tblbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstok As TextBox
    Friend WithEvents cbjenis As ComboBox
    Friend WithEvents cbgudang As ComboBox
    Friend WithEvents tblbarang As DataGridView
    Friend WithEvents btninput As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnhome As Button
End Class
