Imports System.Data.SqlClient

Public Class frmSatT
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
    Friend WithEvents dg As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dg = New System.Windows.Forms.DataGrid
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AlternatingBackColor = System.Drawing.Color.White
        Me.dg.BackColor = System.Drawing.Color.White
        Me.dg.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg.CaptionBackColor = System.Drawing.Color.Silver
        Me.dg.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.CaptionForeColor = System.Drawing.Color.Black
        Me.dg.DataMember = ""
        Me.dg.FlatMode = True
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dg.GridLineColor = System.Drawing.Color.DarkGray
        Me.dg.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dg.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.HeaderForeColor = System.Drawing.Color.White
        Me.dg.LinkColor = System.Drawing.Color.DarkGreen
        Me.dg.Location = New System.Drawing.Point(16, 16)
        Me.dg.Name = "dg"
        Me.dg.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dg.SelectionForeColor = System.Drawing.Color.Black
        Me.dg.Size = New System.Drawing.Size(616, 504)
        Me.dg.TabIndex = 0
        '
        'frmSatT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 534)
        Me.Controls.Add(Me.dg)
        Me.Name = "frmSatT"
        Me.Text = "Satýþ Tablosu"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim conn As SqlConnection = New SqlConnection("user id=jdhfbursdlcn;password=hdsfjdslyuelf;initial catalog=BayrakMarketDB;data source=127.0.0.1")

    Private Sub frmSatT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM SatisTablo", conn)
        'SatisID, SatisZaman, UrunID, SatisAdet, SatisFiyat, kuladi
        Dim ds As DataTable = New DataTable

        Try
            da.Fill(ds)

            dg.DataSource = ds
        Catch ex As Exception
            MsgBox("Hata! Sistem yöneticinize baþ vurun.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
