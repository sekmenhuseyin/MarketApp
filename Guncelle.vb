Imports System.Data.SqlClient

Public Class Guncelle
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSFiyat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUAdi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGrid
    Friend WithEvents btnTamam As System.Windows.Forms.Button
    Friend WithEvents txtAdet As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUrunID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGel As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSFiyat = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtUAdi = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dg = New System.Windows.Forms.DataGrid
        Me.btnTamam = New System.Windows.Forms.Button
        Me.txtAdet = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUrunID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtGel = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(424, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "#.##"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSFiyat
        '
        Me.txtSFiyat.Location = New System.Drawing.Point(344, 16)
        Me.txtSFiyat.Name = "txtSFiyat"
        Me.txtSFiyat.Size = New System.Drawing.Size(80, 20)
        Me.txtSFiyat.TabIndex = 2
        Me.txtSFiyat.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(232, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Sat�� Fiyat�"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUAdi
        '
        Me.txtUAdi.Location = New System.Drawing.Point(120, 16)
        Me.txtUAdi.Name = "txtUAdi"
        Me.txtUAdi.TabIndex = 1
        Me.txtUAdi.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "�r�n Ad�"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dg
        '
        Me.dg.AlternatingBackColor = System.Drawing.Color.White
        Me.dg.BackColor = System.Drawing.Color.White
        Me.dg.BackgroundColor = System.Drawing.Color.Ivory
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dg.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.CaptionForeColor = System.Drawing.Color.Lavender
        Me.dg.DataMember = ""
        Me.dg.FlatMode = True
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.ForeColor = System.Drawing.Color.Black
        Me.dg.GridLineColor = System.Drawing.Color.Wheat
        Me.dg.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.dg.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.HeaderForeColor = System.Drawing.Color.Black
        Me.dg.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dg.Location = New System.Drawing.Point(32, 88)
        Me.dg.Name = "dg"
        Me.dg.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.dg.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg.SelectionBackColor = System.Drawing.Color.Wheat
        Me.dg.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg.Size = New System.Drawing.Size(536, 440)
        Me.dg.TabIndex = 24
        Me.dg.TabStop = False
        '
        'btnTamam
        '
        Me.btnTamam.Location = New System.Drawing.Point(520, 48)
        Me.btnTamam.Name = "btnTamam"
        Me.btnTamam.Size = New System.Drawing.Size(64, 23)
        Me.btnTamam.TabIndex = 22
        Me.btnTamam.Text = "G�ncelle"
        '
        'txtAdet
        '
        Me.txtAdet.Location = New System.Drawing.Point(536, 16)
        Me.txtAdet.Name = "txtAdet"
        Me.txtAdet.Size = New System.Drawing.Size(48, 20)
        Me.txtAdet.TabIndex = 3
        Me.txtAdet.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(488, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Adet:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUrunID
        '
        Me.txtUrunID.ForeColor = System.Drawing.Color.Silver
        Me.txtUrunID.Location = New System.Drawing.Point(368, 48)
        Me.txtUrunID.MaxLength = 100
        Me.txtUrunID.Name = "txtUrunID"
        Me.txtUrunID.Size = New System.Drawing.Size(144, 20)
        Me.txtUrunID.TabIndex = 5
        Me.txtUrunID.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(248, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "�r�n Numaras�:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGel
        '
        Me.txtGel.Location = New System.Drawing.Point(136, 48)
        Me.txtGel.Name = "txtGel"
        Me.txtGel.Size = New System.Drawing.Size(80, 20)
        Me.txtGel.TabIndex = 4
        Me.txtGel.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(24, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Geli� Fiyat�"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guncelle
        '
        Me.AcceptButton = Me.btnTamam
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 542)
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
        Me.Name = "Guncelle"
        Me.Text = "�r�n Guncelle"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim conn As SqlConnection = New SqlConnection("user id=jdhfbursdlcn;password=hdsfjdslyuelf;initial catalog=BayrakMarketDB;data source=127.0.0.1")
    Dim ds As DataTable

    Private Sub Guncelle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As SqlDataAdapter = New SqlDataAdapter("Select * from UrunTablo", conn)
        ds = New DataTable
        'Try
        da.Fill(ds)
        dg.DataSource = ds
        'Catch ex As Exception
        '    MsgBox("Hata! Sistem y�neticinize ba� vurun.", MsgBoxStyle.Critical)
        'End Try
    End Sub

    Private Sub btnTamam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTamam.Click
        Dim daT As SqlDataAdapter = New SqlDataAdapter("Select Adet From UrunTablo Where UrunID='" & txtUrunID.Text & "'", conn)
        'Dim dsT As DataSet = New DataSet
        Dim dt As DataTable = New DataTable
        daT.Fill(dt)
        'daT.Fill(dsT, "A")
        Dim cmdG As SqlCommand
        Dim x As Integer
        Try
            x = Val(txtAdet.Text) + dt.Rows(0)(0)

            If txtAdet.Text = "" Or txtSFiyat.Text = "" Or txtUrunID.Text = "" Then
                MsgBox("L�tfen K�rm�z�l� alanlar� doldurun!", MsgBoxStyle.Critical)
                Exit Sub
            ElseIf txtUAdi.Text = "" And txtGel.Text <> "" Then
                cmdG = New SqlCommand("Update UrunTablo set Adet='" & x & "',UrunFiyat='" & txtSFiyat.Text & "',GelisFiyat='" & txtGel.Text & "' where UrunID='" & txtUrunID.Text & "' ", conn)

            ElseIf txtUAdi.Text = "" And txtGel.Text = "" Then
                cmdG = New SqlCommand("Update UrunTablo set Adet='" & x & "',UrunFiyat='" & txtSFiyat.Text & "' where UrunID='" & txtUrunID.Text & "' ", conn)

            Else
                cmdG = New SqlCommand("Update UrunTablo set UrunAd='" & txtUAdi.Text & "',Adet='" & x & "',UrunFiyat='" & txtSFiyat.Text & "',GelisFiyat='" & txtGel.Text & "' where UrunID='" & txtUrunID.Text & "' ", conn)
            End If
            conn.Open()
            cmdG.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Hata! Sistem y�neticinize ba� vurun.", MsgBoxStyle.Critical)
        End Try


        txtUrunID.Text = ""
        txtAdet.Text = ""
        txtSFiyat.Text = ""
        txtUAdi.Text = ""
        txtGel.Text = ""
        txtUAdi.Focus()

        Dim da1 As SqlDataAdapter = New SqlDataAdapter("Select * from UrunTablo", conn)
        Dim ds1 As DataTable = New DataTable
        Try
            da1.Fill(ds1)
            dg.DataSource = ds1
        Catch ex As Exception
            MsgBox("Hata! Sistem y�neticinize ba� vurun.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
