Imports System.Data.SqlClient

Public Class frmTum
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
        Me.dg.DataMember = ""
        Me.dg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dg.Location = New System.Drawing.Point(8, 16)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(504, 448)
        Me.dg.TabIndex = 0
        '
        'frmTum
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 470)
        Me.Controls.Add(Me.dg)
        Me.Name = "frmTum"
        Me.Text = "Stok"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim conn As SqlConnection = New SqlConnection("user id=jdhfbursdlcn;password=hdsfjdslyuelf;initial catalog=BayrakMarketDB;data source=127.0.0.1")

    Private Sub frmTum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As SqlDataAdapter = New SqlDataAdapter("Select * from UrunTablo", conn)
        Dim dt As DataTable = New DataTable
        da.Fill(dt)
        dg.DataSource = dt

    End Sub
End Class
