Imports System.Data.SqlClient

Public Class frmGiris
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
    Friend WithEvents txtAd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtAd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kullanýcý Adý:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(136, 80)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "Giriþ"
        '
        'txtAd
        '
        Me.txtAd.Location = New System.Drawing.Point(112, 16)
        Me.txtAd.Name = "txtAd"
        Me.txtAd.TabIndex = 1
        Me.txtAd.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Þifre:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(112, 48)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.TabIndex = 2
        Me.txtPass.Text = ""
        '
        'frmGiris
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(224, 110)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAd)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGiris"
        Me.Text = "Giriþ"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim conn As SqlConnection = New SqlConnection("user id=jdhfbursdlcn;password=hdsfjdslyuelf;initial catalog=BayrakMarketDB;data source=127.0.0.1")

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim da As SqlDataAdapter
        Dim ds As DataTable
        da = New SqlDataAdapter("SELECT * FROM giris WHERE kuladi='" & txtAd.Text & "' and sifre='" & txtPass.Text & "'", conn)
        ds = New DataTable
        da.Fill(ds)

        If ds.Rows.Count <> 0 Then
            Dim frmS As New Main
            frmS.Show()
            Me.Hide()
            Dim cmd As SqlCommand = New SqlCommand("Delete from tempp", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            Dim cmd2 As SqlCommand = New SqlCommand("Insert into tempp  (kulad,GirisZamani) values ('" & txtAd.Text & "','" & Now & "')", conn)
            cmd2.ExecuteNonQuery()
            conn.Close()

        Else
            MsgBox("Yanlýþ kullanýcý adý veya þifre!", MsgBoxStyle.Critical)

        End If
    End Sub
End Class
