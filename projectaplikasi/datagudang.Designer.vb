﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class datagudang
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btninput = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.DataSet1 = New projectaplikasi.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnhome = New System.Windows.Forms.Button()
        Me.tblgudang = New System.Windows.Forms.DataGridView()
        Me.DataSet11 = New projectaplikasi.DataSet1()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblgudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Gudang"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 142)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(86, 29)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Alamat"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(148, 97)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(400, 36)
        Me.txtnama.TabIndex = 5
        '
        'txtalamat
        '
        Me.txtalamat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(148, 139)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(400, 36)
        Me.txtalamat.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nama"
        '
        'btninput
        '
        Me.btninput.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btninput.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btninput.Location = New System.Drawing.Point(555, 97)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(233, 58)
        Me.btninput.TabIndex = 14
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnedit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnedit.Location = New System.Drawing.Point(554, 161)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(233, 58)
        Me.btnedit.TabIndex = 15
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btndelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btndelete.Location = New System.Drawing.Point(554, 225)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(233, 58)
        Me.btndelete.TabIndex = 16
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnsearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnsearch.Location = New System.Drawing.Point(17, 205)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(108, 50)
        Me.btnsearch.TabIndex = 18
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(148, 210)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(240, 36)
        Me.txtsearch.TabIndex = 19
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnhome.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnhome.Location = New System.Drawing.Point(602, 28)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(126, 43)
        Me.btnhome.TabIndex = 21
        Me.btnhome.Text = "Home"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'tblgudang
        '
        Me.tblgudang.AllowUserToAddRows = False
        Me.tblgudang.AllowUserToDeleteRows = False
        Me.tblgudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblgudang.Location = New System.Drawing.Point(17, 289)
        Me.tblgudang.Name = "tblgudang"
        Me.tblgudang.ReadOnly = True
        Me.tblgudang.RowHeadersVisible = False
        Me.tblgudang.RowHeadersWidth = 62
        Me.tblgudang.RowTemplate.Height = 28
        Me.tblgudang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblgudang.Size = New System.Drawing.Size(771, 173)
        Me.tblgudang.TabIndex = 22
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'datagudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 472)
        Me.Controls.Add(Me.tblgudang)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "datagudang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "datagudang"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblgudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btninput As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents btnhome As Button
    Friend WithEvents tblgudang As DataGridView
    Friend WithEvents DataSet11 As DataSet1
End Class
