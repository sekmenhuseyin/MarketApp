Imports System.Data.SqlClient

Public Class Giris
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnTamam As System.Windows.Forms.Button
    Friend WithEvents txtAdet As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUrunID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUAdi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSFiyat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnTamam = New System.Windows.Forms.Button
        Me.txtAdet = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUrunID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dg = New System.Windows.Forms.DataGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUAdi = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSFiyat = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtGel = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTamam
        '
        Me.btnTamam.Location = New System.Drawing.Point(512, 40)
        Me.btnTamam.Name = "btnTamam"
        Me.btnTamam.Size = New System.Drawing.Size(64, 23)
        Me.btnTamam.TabIndex = 9
        Me.btnTamam.Text = "Ekle"
        '
        'txtAdet
        '
        Me.txtAdet.Location = New System.Drawing.Point(528, 8)
        Me.txtAdet.Name = "txtAdet"
        Me.txtAdet.Size = New System.Drawing.Size(48, 20)
        Me.txtAdet.TabIndex = 3
        Me.txtAdet.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(480, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Adet:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUrunID
        '
        Me.txtUrunID.ForeColor = System.Drawing.Color.Silver
        Me.txtUrunID.Location = New System.Drawing.Point(360, 40)
        Me.txtUrunID.MaxLength = 100
        Me.txtUrunID.Name = "txtUrunID"
        Me.txtUrunID.Size = New System.Drawing.Size(144, 20)
        Me.txtUrunID.TabIndex = 5
        Me.txtUrunID.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(240, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ürün Numarasý:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dg
        '
        Me.dg.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.dg.BackColor = System.Drawing.Color.OldLace
        Me.dg.BackgroundColor = System.Drawing.Color.Tan
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.dg.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.CaptionForeColor = System.Drawing.Color.OldLace
        Me.dg.DataMember = ""
        Me.dg.FlatMode = True
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dg.GridLineColor = System.Drawing.Color.Tan
        Me.dg.HeaderBackColor = System.Drawing.Color.Wheat
        Me.dg.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.dg.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dg.Location = New System.Drawing.Point(24, 80)
        Me.dg.Name = "dg"
        Me.dg.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.dg.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.dg.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.dg.SelectionForeColor = System.Drawing.Color.White
        Me.dg.Size = New System.Drawing.Size(536, 440)
        Me.dg.TabIndex = 11
        Me.dg.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Ürün Adý"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUAdi
        '
        Me.txtUAdi.Location = New System.Drawing.Point(112, 8)
        Me.txtUAdi.Name = "txtUAdi"
        Me.txtUAdi.TabIndex = 1
        Me.txtUAdi.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(224, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Satýþ Fiyatý"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSFiyat
        '
        Me.txtSFiyat.Location = New System.Drawing.Point(336, 8)
        Me.txtSFiyat.Name = "txtSFiyat"
        Me.txtSFiyat.Size = New System.Drawing.Size(80, 20)
        Me.txtSFiyat.TabIndex = 2
        Me.txtSFiyat.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(416, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "#.##"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGel
        '
        Me.txtGel.Location = New System.Drawing.Point(136, 40)
        Me.txtGel.Name = "txtGel"
        Me.txtGel.Size = New System.Drawing.Size(80, 20)
        Me.txtGel.TabIndex = 4
        Me.txtGel.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Geliþ Fiyatý"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Giris
        '
        Me.AcceptButton = Me.btnTamam
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 534)
        Me.Controls.Add(Me.txtGel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSFiyat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUAdi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.btnTamam)
        Me.Controls.Add(Me.txtAdet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUrunID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Giris"
        Me.Text = "Ürün Giriþi"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim conn As SqlConnection = New SqlConnection("user id=jdhfbursdlcn;password=hdsfjdslyuelf;initial catalog=BayrakMarketDB;data source=127.0.0.1")


    Private Sub btnTamam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTamam.Click

        If txtUrunID.Text <> "" And txtUAdi.Text <> "" And txtSFiyat.Text <> "" And txtAdet.Text <> "" Then
            Dim cmdE As SqlCommand = New SqlCommand("Insert into UrunTablo (UrunID,UrunAd,Adet,UrunFiyat,GelisFiyat) values ('" & txtUrunID.Text & "','" & txtUAdi.Text & "','" & txtAdet.Text & "','" & txtSFiyat.Text & "','" & txtGel.Text & "')", conn)
            conn.Open()
            cmdE.ExecuteNonQuery()
            conn.Close()


            txtUrunID.Text = ""
            txtAdet.Text = ""
            txtSFiyat.Text = ""
            txtUAdi.Text = ""
            txtGel.Text = ""
            txtUAdi.Focus()

            Dim da As SqlDataAdapter = New SqlDataAdapter("Select * from UrunTablo", conn)
            Dim ds As DataTable = New DataTable
            Try
                da.Fill(ds)
                dg.DataSource = ds
            Catch ex As Exception
                MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
            End Try

        Else
            MsgBox("Lütfen Kýrmýzýlý alanlarý doldurun!", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Giris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As SqlDataAdapter = New SqlDataAdapter("Select * from UrunTablo", conn)
        Dim ds As DataTable = New DataTable
        Try
            da.Fill(ds)
            dg.DataSource = ds
        Catch ex As Exception
            MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
