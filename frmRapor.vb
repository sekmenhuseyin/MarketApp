Imports System.Data.SqlClient

Public Class frmRapor
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGrid
    Friend WithEvents lblToplam As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.dg = New System.Windows.Forms.DataGrid
        Me.lblToplam = New System.Windows.Forms.Label
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Yenile"
        '
        'dg
        '
        Me.dg.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dg.BackgroundColor = System.Drawing.Color.LightGray
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dg.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.DataMember = ""
        Me.dg.FlatMode = True
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dg.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dg.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dg.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dg.LinkColor = System.Drawing.Color.Teal
        Me.dg.Location = New System.Drawing.Point(24, 16)
        Me.dg.Name = "dg"
        Me.dg.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dg.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dg.Size = New System.Drawing.Size(504, 408)
        Me.dg.TabIndex = 1
        '
        'lblToplam
        '
        Me.lblToplam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblToplam.Location = New System.Drawing.Point(168, 432)
        Me.lblToplam.Name = "lblToplam"
        Me.lblToplam.Size = New System.Drawing.Size(312, 32)
        Me.lblToplam.TabIndex = 3
        Me.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmRapor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 486)
        Me.Controls.Add(Me.lblToplam)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmRapor"
        Me.Text = "Rapor"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim conn As SqlConnection = New SqlConnection("user id=jdhfbursdlcn;password=hdsfjdslyuelf;initial catalog=BayrakMarketDB;data source=127.0.0.1")
    Dim toplam As Decimal
    Dim dt2 As DataTable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim da As SqlDataAdapter
        Dim dt As DataTable = New DataTable

        da = New SqlDataAdapter("Select kulad,GirisZamani from tempp", conn)
        da.Fill(dt)



        Dim da1 As SqlDataAdapter
        da1 = New SqlDataAdapter("SELECT * FROM SatisTablo WHERE kuladi <> '" & dt.Rows(0)(0) & "' ORDER BY SatisID DESC", conn)
        Dim dt1 As DataTable = New DataTable
        da1.Fill(dt1)
        '0 0 da istediðimiz id no var
        'bu id den büyük olanlarý seçecez ki bize son durumu versin

        Dim da2 As SqlDataAdapter
        da2 = New SqlDataAdapter("SELECT * FROM SatisTablo WHERE SatisID > '" & dt1.Rows(0)(0) & "'", conn)

        dt2 = New DataTable
        da2.Fill(dt2)

        dg.DataSource = dt2

        toplamibul()

    End Sub
    Sub toplamibul()
        toplam = 0
        Dim dtt As DataTable
        dtt = CType(dg.DataSource, DataTable)
        Dim i As Integer
        For i = 0 To dt2.Rows.Count - 1
            Try
                toplam += dg.Item(i, 4)
            Catch ex As Exception
                MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
            End Try
        Next
        lblToplam.Text = "Toplam Miktar:  " & toplam & " YTL"
    End Sub

    Private Sub frmRapor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As SqlDataAdapter
        Dim dt As DataTable = New DataTable

        da = New SqlDataAdapter("Select kulad,GirisZamani from tempp", conn)
        da.Fill(dt)



        Dim da1 As SqlDataAdapter
        da1 = New SqlDataAdapter("SELECT * FROM SatisTablo WHERE kuladi <> '" & dt.Rows(0)(0) & "' ORDER BY SatisID DESC", conn)
        Dim dt1 As DataTable = New DataTable
        da1.Fill(dt1)
        '0 0 da istediðimiz id no var
        'bu id den büyük olanlarý seçecez ki bize son durumu versin

        Dim da2 As SqlDataAdapter
        da2 = New SqlDataAdapter("SELECT * FROM SatisTablo WHERE SatisID > '" & dt1.Rows(0)(0) & "'", conn)

        dt2 = New DataTable
        da2.Fill(dt2)

        dg.DataSource = dt2

        toplamibul()

    End Sub
End Class
