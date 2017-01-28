Imports System.Data.SqlClient

Public Class Satis
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
         Friend WithEvents Label1 As System.Windows.Forms.Label
         Friend WithEvents txtUrunID As System.Windows.Forms.TextBox
         Friend WithEvents Label3 As System.Windows.Forms.Label
         Friend WithEvents txtAdet As System.Windows.Forms.TextBox
         Friend WithEvents btnTamam As System.Windows.Forms.Button
         Friend WithEvents dg As System.Windows.Forms.DataGrid
         Friend WithEvents dgtsUrunAd As System.Windows.Forms.DataGridTableStyle
         Friend WithEvents dgtsUrunF As System.Windows.Forms.DataGridTableStyle
         Friend WithEvents lblToplam As System.Windows.Forms.Label
         Friend WithEvents btnYeni As System.Windows.Forms.Button
         Friend WithEvents btnTemiz As System.Windows.Forms.Button
         Friend WithEvents btnSSIptal As System.Windows.Forms.Button
         Friend WithEvents btnIptalZ As System.Windows.Forms.Button
         <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUrunID = New System.Windows.Forms.TextBox
        Me.dg = New System.Windows.Forms.DataGrid
        Me.dgtsUrunAd = New System.Windows.Forms.DataGridTableStyle
        Me.dgtsUrunF = New System.Windows.Forms.DataGridTableStyle
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAdet = New System.Windows.Forms.TextBox
        Me.btnTamam = New System.Windows.Forms.Button
        Me.lblToplam = New System.Windows.Forms.Label
        Me.btnYeni = New System.Windows.Forms.Button
        Me.btnTemiz = New System.Windows.Forms.Button
        Me.btnSSIptal = New System.Windows.Forms.Button
        Me.btnIptalZ = New System.Windows.Forms.Button
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ürün Numarasý:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUrunID
        '
        Me.txtUrunID.ForeColor = System.Drawing.Color.Silver
        Me.txtUrunID.Location = New System.Drawing.Point(240, 8)
        Me.txtUrunID.MaxLength = 100
        Me.txtUrunID.Name = "txtUrunID"
        Me.txtUrunID.Size = New System.Drawing.Size(144, 20)
        Me.txtUrunID.TabIndex = 2
        Me.txtUrunID.Text = ""
        '
        'dg
        '
        Me.dg.AlternatingBackColor = System.Drawing.Color.GhostWhite
        Me.dg.BackColor = System.Drawing.Color.GhostWhite
        Me.dg.BackgroundColor = System.Drawing.Color.Lavender
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.dg.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.CaptionForeColor = System.Drawing.Color.White
        Me.dg.DataMember = ""
        Me.dg.FlatMode = True
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.dg.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dg.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.HeaderForeColor = System.Drawing.Color.Lavender
        Me.dg.LinkColor = System.Drawing.Color.Teal
        Me.dg.Location = New System.Drawing.Point(40, 56)
        Me.dg.Name = "dg"
        Me.dg.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.dg.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.SelectionBackColor = System.Drawing.Color.Teal
        Me.dg.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.dg.Size = New System.Drawing.Size(384, 320)
        Me.dg.TabIndex = 4
        Me.dg.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgtsUrunAd, Me.dgtsUrunF})
        Me.dg.TabStop = False
        '
        'dgtsUrunAd
        '
        Me.dgtsUrunAd.DataGrid = Me.dg
        Me.dgtsUrunAd.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgtsUrunAd.MappingName = ""
        '
        'dgtsUrunF
        '
        Me.dgtsUrunF.DataGrid = Me.dg
        Me.dgtsUrunF.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgtsUrunF.MappingName = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Adet:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAdet
        '
        Me.txtAdet.Location = New System.Drawing.Point(56, 8)
        Me.txtAdet.Name = "txtAdet"
        Me.txtAdet.Size = New System.Drawing.Size(48, 20)
        Me.txtAdet.TabIndex = 1
        Me.txtAdet.Text = "1"
        '
        'btnTamam
        '
        Me.btnTamam.Location = New System.Drawing.Point(392, 8)
        Me.btnTamam.Name = "btnTamam"
        Me.btnTamam.Size = New System.Drawing.Size(64, 23)
        Me.btnTamam.TabIndex = 3
        Me.btnTamam.Text = "Tamam"
        '
        'lblToplam
        '
        Me.lblToplam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblToplam.Location = New System.Drawing.Point(128, 392)
        Me.lblToplam.Name = "lblToplam"
        Me.lblToplam.Size = New System.Drawing.Size(296, 32)
        Me.lblToplam.TabIndex = 8
        '
        'btnYeni
        '
        Me.btnYeni.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnYeni.Location = New System.Drawing.Point(440, 48)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(112, 23)
        Me.btnYeni.TabIndex = 9
        Me.btnYeni.Text = "Yeni Müþteri (Esc)"
        '
        'btnTemiz
        '
        Me.btnTemiz.Location = New System.Drawing.Point(440, 96)
        Me.btnTemiz.Name = "btnTemiz"
        Me.btnTemiz.Size = New System.Drawing.Size(112, 23)
        Me.btnTemiz.TabIndex = 10
        Me.btnTemiz.Text = "Ekraný Temizle"
        '
        'btnSSIptal
        '
        Me.btnSSIptal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnSSIptal.Location = New System.Drawing.Point(440, 136)
        Me.btnSSIptal.Name = "btnSSIptal"
        Me.btnSSIptal.Size = New System.Drawing.Size(112, 24)
        Me.btnSSIptal.TabIndex = 11
        Me.btnSSIptal.Text = "Son Satýþ Ýptal"
        '
        'btnIptalZ
        '
        Me.btnIptalZ.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIptalZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnIptalZ.Location = New System.Drawing.Point(432, 184)
        Me.btnIptalZ.Name = "btnIptalZ"
        Me.btnIptalZ.Size = New System.Drawing.Size(128, 40)
        Me.btnIptalZ.TabIndex = 12
        Me.btnIptalZ.Text = "Satýþ Ýptal (Satýþ Numarasýna Göre)"
        '
        'Satis
        '
        Me.AcceptButton = Me.btnTamam
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnYeni
        Me.ClientSize = New System.Drawing.Size(568, 429)
        Me.Controls.Add(Me.btnIptalZ)
        Me.Controls.Add(Me.btnSSIptal)
        Me.Controls.Add(Me.btnTemiz)
        Me.Controls.Add(Me.btnYeni)
        Me.Controls.Add(Me.lblToplam)
        Me.Controls.Add(Me.btnTamam)
        Me.Controls.Add(Me.txtAdet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtUrunID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Satis"
        Me.Text = "Satýþ"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim conn As SqlConnection = New SqlConnection("user id=jdhfbursdlcn;password=hdsfjdslyuelf;initial catalog=BayrakMarketDB;data source=127.0.0.1")

         'Datagrid özellikleri____________________
         Dim dt As New DataTable
         Dim sutun As DataColumn
         Dim satir As DataRow
         '___________________________________
         Dim toplam As Decimal

    Private Sub btnTamam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTamam.Click
        Dim f, f2 As Double
        Dim ald As String = txtUrunID.Text
        Dim strcon As String = "SELECT UrunAD,UrunFiyat FROM UrunTablo WHERE UrunID = '" & ald & "'"
        Dim da As SqlDataAdapter
        Dim ds As DataTable

        'Try
        da = New SqlDataAdapter(strcon, conn)
        ds = New DataTable
        da.Fill(ds)

        'Satýrlarý oluþtur
        If ds.Rows.Count <> 0 Then
            satir = dt.NewRow
            satir("Ürün No") = ald
            satir("Ürün Adý") = ds.Rows(0)(0)
            satir("Ürün Adet") = Val(txtAdet.Text)
            f = Val(ds.Rows(0)(1))
            f2 = Val(txtAdet.Text)
            satir("Fiyat") = f * f2

            dt.Rows.Add(satir)
        Else
            MsgBox("Bu ürün kayýtlarda bulunamadý!", MsgBoxStyle.OKOnly)

        End If


        'Catch ex As Exception
        '    MsgBox("Hata!", MsgBoxStyle.OKOnly)

        'End Try
        toplamibul()
        txtUrunID.SelectAll()
        txtAdet.Text = "1"
    End Sub

    Private Sub Satis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Sütunlarý oluþtur
        sutun = New DataColumn("Ürün No")
        sutun.DataType = Type.GetType("System.Int64")
        sutun.AutoIncrement = True
        sutun.AutoIncrementStep = 1
        'Sütunlara ekle
        dt.Columns.Add(sutun)

        'Yeni bir sütun daha oluþtur
        sutun = New DataColumn("Ürün Adý")
        sutun.DataType = Type.GetType("System.String")
        'Sütunlara ekle
        dt.Columns.Add(sutun)

        'Yeni bir sütun daha oluþtur
        sutun = New DataColumn("Ürün Adet")
        sutun.DataType = Type.GetType("System.Int32")
        'Sütunlara ekle
        dt.Columns.Add(sutun)

        'Yeni bir sütun daha oluþtur
        sutun = New DataColumn("Fiyat")
        sutun.DataType = Type.GetType("System.String")
        '                  sutun.Expression = "[Ürün Adet]*3"
        'Sütunlara ekle
        dt.Columns.Add(sutun)
        dg.DataSource = dt

        lblToplam.Text = "Toplam Miktar:  " & 0 & " YTL"

    End Sub
    Sub toplamibul()
        toplam = 0
        Dim dtt As DataTable
        dtt = CType(dg.DataSource, DataTable)
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            Try
                toplam += dg.Item(i, 3)
            Catch ex As Exception
                MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
            End Try
        Next
        lblToplam.Text = "Toplam Miktar:  " & toplam & " YTL"
    End Sub


    Private Sub btnYeni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYeni.Click
        Dim j, cikar, y As Integer
        Dim cmd, cmd2 As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet = New DataSet
        Dim dtt As DataTable
        dtt = CType(dg.DataSource, DataTable)
        Dim dak As SqlDataAdapter = New SqlDataAdapter("Select * from tempp", conn)
        Dim dtk As DataTable = New DataTable
        dak.Fill(dtk)

        Dim tarih As String = Now.Month & "." & Now.Day & "." & Now.Year & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second


        Try
            For j = 0 To dt.Rows.Count - 1
                da = New SqlDataAdapter("select adet from UrunTablo where UrunID='" & dg.Item(j, 0) & "' ", conn)
                da.Fill(ds, "S")
                cikar = Val(ds.Tables("S").Rows(0)(0)) - Val(dg.Item(j, 2))
                cmd = New SqlCommand("update UrunTablo set Adet='" & cikar & "' where UrunID='" & dg.Item(j, 0) & "'", conn)
                cmd2 = New SqlCommand("insert into SatisTablo (SatisZaman,UrunID,SatisAdet,SatisFiyat,Kuladi) values('" & tarih & "','" & dg.Item(j, 0) & "','" & dg.Item(j, 2) & "','" & dg.Item(j, 3) & "','" & dtk.Rows(0)(0) & "')", conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()
                conn.Close()

            Next
        Catch ex As Exception
            MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
        End Try

        dt.Rows.Clear()
        lblToplam.Text = "Toplam Miktar:  " & 0 & " YTL"

    End Sub

    Private Sub btnTemiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTemiz.Click
        dt.Rows.Clear()
        lblToplam.Text = "Toplam Miktar:  " & 0 & " YTL"
    End Sub

    Private Sub btnSSIptal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSSIptal.Click

        Dim trh As String

        Dim daZ As SqlDataAdapter = New SqlDataAdapter("select top 1 SatisZaman from SatisTablo order by SatisID desc", conn)
        Dim dsZ As DataSet = New DataSet
        Try
            daZ.Fill(dsZ, "z")
            'Son satýþýn zamaný alýndý ve o zaman da olan tüm satýþlarý silecez
            trh = dsZ.Tables("z").Rows(0)(0)
        Catch ex As Exception
            MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
        End Try

        Dim daB As SqlDataAdapter = New SqlDataAdapter("SELECT SatisID,UrunID,SatisAdet,SatisFiyat FROM SatisTablo WHERE SatisZaman= '" & trh & "'", conn)
        Dim dsB As DataSet = New DataSet
        Try
            daB.Fill(dsB, "b")
        Catch ex As Exception
            MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
        End Try

        'son tarih alýndý ve o tarihte satýlmýþ tüm satýþlar dataset e alýndý, bu buffer sayesinde ürünleri datagridde görebileceðiz

        Dim q As Integer = 0
        Try
            While q < dsB.Tables("b").Rows.Count
                'Satýrlarý oluþtur
                satir = dt.NewRow

                satir("Ürün No") = dsB.Tables("b").Rows(q)(1)
                satir("Ürün Adý") = "???"
                satir("Ürün Adet") = dsB.Tables("b").Rows(q)(2)
                satir("Fiyat") = dsB.Tables("b").Rows(q)(3)

                dt.Rows.Add(satir)
                toplamibul()
                lblToplam.Text = "Toplam Miktar:  " & toplam & " YTL"
                q += 1
            End While
            'bu while döngüsü ile datagridin içini doldurduk ve iade edilecek fiyatý bulduk
        Catch ex As Exception
            MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
        End Try

        If MsgBox("Ýade Tutarý : " & toplam & " YTL" & Chr(13) & " Silmek Ýstediðinizden Eminmisiniz", vbOKCancel) = vbOK Then

            Dim cmdS As SqlCommand = New SqlCommand("DELETE FROM SatisTablo WHERE SatisZaman = '" & trh & "'", conn)
            Try
                conn.Open()
                cmdS.ExecuteNonQuery()
                conn.Close()
                'Son tarihdeki satýþlar silindi
            Catch ex As Exception
                MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
            End Try

            'Bufferýn içindeki bilgilere göre UrunTablo'ya silinenleri tekrar geri koy!
            q = 0
            Dim daU As SqlDataAdapter
            Dim dsU As DataSet
            Dim cmdU As SqlCommand
            Dim topla As Integer = 0
            Try
                While q < dsB.Tables("b").Rows.Count
                    'Bu while ile iade edilen mallarý stoða geri koyacaðýz
                    daU = New SqlDataAdapter("select UrunID,Adet from UrunTablo where UrunID='" & dg.Item(q, 0) & "'", conn)
                    dsU = New DataSet
                    daU.Fill(dsU, "u")
                    topla = dsU.Tables("u").Rows(0)(1) + dsB.Tables("b").Rows(q)(2)

                    'Stoktaki ve Satýlýp geri iade edilen mallarýn toplamý
                    cmdU = New SqlCommand("update UrunTablo set Adet='" & topla & "' where UrunID='" & dsB.Tables("b").Rows(q)(1) & "'", conn)

                    conn.Open()
                    cmdU.ExecuteNonQuery()
                    conn.Close()

                    q += 1
                End While
            Catch ex As Exception
                MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
            End Try

        Else
            Exit Sub
        End If
        'datagrid'i temizlemek gerekiyor
        dt.Rows.Clear()
        lblToplam.Text = "Toplam Miktar:  " & 0 & " YTL"

    End Sub

    Private Sub btnIptalZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIptalZ.Click
        Dim satid As Integer
        Dim satadet As Integer
        Dim urun As Integer
        Dim topla As Integer = 0
        Dim ad As String

        Dim daS, daU As SqlDataAdapter
        Dim dsS, dsU As DataSet
        Dim cmdU, cmdD As SqlCommand

        ad = InputBox("Silmek Ýstediðiniz Satýþýn ID numarasýný Girin", "Satýþ Ýptal")
        satid = Val(ad)

        daS = New SqlDataAdapter("select SatisID,SatisAdet,UrunID from SatisTablo where SatisID='" & satid & "'", conn)
        dsS = New DataSet
        Try
            daS.Fill(dsS, "s")

            If dsS.Tables("s").Rows.Count <> 0 Then
                satadet = dsS.Tables("s").Rows(0)(1)
                urun = dsS.Tables("s").Rows(0)(2)

                daU = New SqlDataAdapter("select UrunID,Adet from UrunTablo where UrunID='" & urun & "'", conn)
                dsU = New DataSet
                daU.Fill(dsU, "u")

                topla = dsU.Tables("u").Rows(0)(1) + satadet

                cmdU = New SqlCommand("update UrunTablo set Adet='" & topla & "' where UrunID='" & urun & "'", conn)
                cmdD = New SqlCommand("Delete from SatisTablo where SatisID='" & satid & "'", conn)

                conn.Open()
                cmdU.ExecuteNonQuery()
                cmdD.ExecuteNonQuery()
                conn.Close()

                MsgBox(satid & "  Nolu Satýþ Silindi", vbInformation, "Bitti!")
            Else
                MsgBox(satid & "  Nolu Satýþ Bulunamadý!")
            End If
        Catch ex As Exception
            MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
