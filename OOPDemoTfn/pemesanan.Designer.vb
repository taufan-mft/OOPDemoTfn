<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pemesanan
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtKode = New MetroFramework.Controls.MetroTextBox()
        Me.txtNama = New MetroFramework.Controls.MetroTextBox()
        Me.txtAlamat = New MetroFramework.Controls.MetroTextBox()
        Me.txtQt1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtQt2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtQt3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtQt4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroListView1 = New MetroFramework.Controls.MetroListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 89)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nama:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Kode PO:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(13, 121)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Alamat:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(470, 89)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "3D Printer A"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(470, 60)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel5.TabIndex = 4
        Me.MetroLabel5.Text = "Pesanan"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(471, 121)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel6.TabIndex = 5
        Me.MetroLabel6.Text = "3D Printer B"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(471, 151)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel7.TabIndex = 6
        Me.MetroLabel7.Text = "3D Printer C"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(471, 183)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel8.TabIndex = 7
        Me.MetroLabel8.Text = "3D Printer D"
        '
        'txtKode
        '
        '
        '
        '
        Me.txtKode.CustomButton.Image = Nothing
        Me.txtKode.CustomButton.Location = New System.Drawing.Point(199, 2)
        Me.txtKode.CustomButton.Name = ""
        Me.txtKode.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtKode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtKode.CustomButton.TabIndex = 1
        Me.txtKode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtKode.CustomButton.UseSelectable = True
        Me.txtKode.CustomButton.Visible = False
        Me.txtKode.Lines = New String() {"MetroTextBox1"}
        Me.txtKode.Location = New System.Drawing.Point(84, 62)
        Me.txtKode.MaxLength = 32767
        Me.txtKode.Name = "txtKode"
        Me.txtKode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKode.SelectedText = ""
        Me.txtKode.SelectionLength = 0
        Me.txtKode.SelectionStart = 0
        Me.txtKode.ShortcutsEnabled = True
        Me.txtKode.Size = New System.Drawing.Size(219, 22)
        Me.txtKode.TabIndex = 8
        Me.txtKode.Text = "MetroTextBox1"
        Me.txtKode.UseSelectable = True
        Me.txtKode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtNama
        '
        '
        '
        '
        Me.txtNama.CustomButton.Image = Nothing
        Me.txtNama.CustomButton.Location = New System.Drawing.Point(199, 2)
        Me.txtNama.CustomButton.Name = ""
        Me.txtNama.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtNama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNama.CustomButton.TabIndex = 1
        Me.txtNama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNama.CustomButton.UseSelectable = True
        Me.txtNama.CustomButton.Visible = False
        Me.txtNama.Lines = New String() {"MetroTextBox2"}
        Me.txtNama.Location = New System.Drawing.Point(84, 91)
        Me.txtNama.MaxLength = 32767
        Me.txtNama.Name = "txtNama"
        Me.txtNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNama.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNama.SelectedText = ""
        Me.txtNama.SelectionLength = 0
        Me.txtNama.SelectionStart = 0
        Me.txtNama.ShortcutsEnabled = True
        Me.txtNama.Size = New System.Drawing.Size(219, 22)
        Me.txtNama.TabIndex = 9
        Me.txtNama.Text = "MetroTextBox2"
        Me.txtNama.UseSelectable = True
        Me.txtNama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAlamat
        '
        '
        '
        '
        Me.txtAlamat.CustomButton.Image = Nothing
        Me.txtAlamat.CustomButton.Location = New System.Drawing.Point(174, 2)
        Me.txtAlamat.CustomButton.Name = ""
        Me.txtAlamat.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtAlamat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAlamat.CustomButton.TabIndex = 1
        Me.txtAlamat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAlamat.CustomButton.UseSelectable = True
        Me.txtAlamat.CustomButton.Visible = False
        Me.txtAlamat.Lines = New String() {"MetroTextBox3"}
        Me.txtAlamat.Location = New System.Drawing.Point(84, 123)
        Me.txtAlamat.MaxLength = 32767
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAlamat.SelectedText = ""
        Me.txtAlamat.SelectionLength = 0
        Me.txtAlamat.SelectionStart = 0
        Me.txtAlamat.ShortcutsEnabled = True
        Me.txtAlamat.Size = New System.Drawing.Size(194, 22)
        Me.txtAlamat.TabIndex = 10
        Me.txtAlamat.Text = "MetroTextBox3"
        Me.txtAlamat.UseSelectable = True
        Me.txtAlamat.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAlamat.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtQt1
        '
        '
        '
        '
        Me.txtQt1.CustomButton.Image = Nothing
        Me.txtQt1.CustomButton.Location = New System.Drawing.Point(199, 2)
        Me.txtQt1.CustomButton.Name = ""
        Me.txtQt1.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtQt1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQt1.CustomButton.TabIndex = 1
        Me.txtQt1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQt1.CustomButton.UseSelectable = True
        Me.txtQt1.CustomButton.Visible = False
        Me.txtQt1.Lines = New String() {"MetroTextBox4"}
        Me.txtQt1.Location = New System.Drawing.Point(558, 89)
        Me.txtQt1.MaxLength = 32767
        Me.txtQt1.Name = "txtQt1"
        Me.txtQt1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQt1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQt1.SelectedText = ""
        Me.txtQt1.SelectionLength = 0
        Me.txtQt1.SelectionStart = 0
        Me.txtQt1.ShortcutsEnabled = True
        Me.txtQt1.Size = New System.Drawing.Size(219, 22)
        Me.txtQt1.TabIndex = 11
        Me.txtQt1.Text = "MetroTextBox4"
        Me.txtQt1.UseSelectable = True
        Me.txtQt1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQt1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtQt2
        '
        '
        '
        '
        Me.txtQt2.CustomButton.Image = Nothing
        Me.txtQt2.CustomButton.Location = New System.Drawing.Point(199, 2)
        Me.txtQt2.CustomButton.Name = ""
        Me.txtQt2.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtQt2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQt2.CustomButton.TabIndex = 1
        Me.txtQt2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQt2.CustomButton.UseSelectable = True
        Me.txtQt2.CustomButton.Visible = False
        Me.txtQt2.Lines = New String() {"MetroTextBox5"}
        Me.txtQt2.Location = New System.Drawing.Point(557, 121)
        Me.txtQt2.MaxLength = 32767
        Me.txtQt2.Name = "txtQt2"
        Me.txtQt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQt2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQt2.SelectedText = ""
        Me.txtQt2.SelectionLength = 0
        Me.txtQt2.SelectionStart = 0
        Me.txtQt2.ShortcutsEnabled = True
        Me.txtQt2.Size = New System.Drawing.Size(219, 22)
        Me.txtQt2.TabIndex = 12
        Me.txtQt2.Text = "MetroTextBox5"
        Me.txtQt2.UseSelectable = True
        Me.txtQt2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQt2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtQt3
        '
        '
        '
        '
        Me.txtQt3.CustomButton.Image = Nothing
        Me.txtQt3.CustomButton.Location = New System.Drawing.Point(199, 2)
        Me.txtQt3.CustomButton.Name = ""
        Me.txtQt3.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtQt3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQt3.CustomButton.TabIndex = 1
        Me.txtQt3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQt3.CustomButton.UseSelectable = True
        Me.txtQt3.CustomButton.Visible = False
        Me.txtQt3.Lines = New String() {"MetroTextBox6"}
        Me.txtQt3.Location = New System.Drawing.Point(558, 151)
        Me.txtQt3.MaxLength = 32767
        Me.txtQt3.Name = "txtQt3"
        Me.txtQt3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQt3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQt3.SelectedText = ""
        Me.txtQt3.SelectionLength = 0
        Me.txtQt3.SelectionStart = 0
        Me.txtQt3.ShortcutsEnabled = True
        Me.txtQt3.Size = New System.Drawing.Size(219, 22)
        Me.txtQt3.TabIndex = 13
        Me.txtQt3.Text = "MetroTextBox6"
        Me.txtQt3.UseSelectable = True
        Me.txtQt3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQt3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtQt4
        '
        '
        '
        '
        Me.txtQt4.CustomButton.Image = Nothing
        Me.txtQt4.CustomButton.Location = New System.Drawing.Point(154, 2)
        Me.txtQt4.CustomButton.Name = ""
        Me.txtQt4.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtQt4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQt4.CustomButton.TabIndex = 1
        Me.txtQt4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQt4.CustomButton.UseSelectable = True
        Me.txtQt4.CustomButton.Visible = False
        Me.txtQt4.Lines = New String() {"MetroTextBox7"}
        Me.txtQt4.Location = New System.Drawing.Point(558, 183)
        Me.txtQt4.MaxLength = 32767
        Me.txtQt4.Name = "txtQt4"
        Me.txtQt4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQt4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQt4.SelectedText = ""
        Me.txtQt4.SelectionLength = 0
        Me.txtQt4.SelectionStart = 0
        Me.txtQt4.ShortcutsEnabled = True
        Me.txtQt4.Size = New System.Drawing.Size(174, 22)
        Me.txtQt4.TabIndex = 14
        Me.txtQt4.Text = "MetroTextBox7"
        Me.txtQt4.UseSelectable = True
        Me.txtQt4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQt4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(84, 157)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 45)
        Me.MetroButton1.TabIndex = 15
        Me.MetroButton1.Text = "Save"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroListView1
        '
        Me.MetroListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.MetroListView1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MetroListView1.FullRowSelect = True
        Me.MetroListView1.Location = New System.Drawing.Point(62, 248)
        Me.MetroListView1.Name = "MetroListView1"
        Me.MetroListView1.OwnerDraw = True
        Me.MetroListView1.Size = New System.Drawing.Size(675, 147)
        Me.MetroListView1.TabIndex = 16
        Me.MetroListView1.UseCompatibleStateImageBehavior = False
        Me.MetroListView1.UseSelectable = True
        Me.MetroListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "KOde Po"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Alamat"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 170
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "A"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "B"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "C"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "D"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(656, 401)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(100, 45)
        Me.MetroButton2.TabIndex = 17
        Me.MetroButton2.Text = "Next"
        Me.MetroButton2.UseSelectable = True
        '
        'pemesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroListView1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.txtQt4)
        Me.Controls.Add(Me.txtQt3)
        Me.Controls.Add(Me.txtQt2)
        Me.Controls.Add(Me.txtQt1)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKode)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "pemesanan"
        Me.Text = "pemesanan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtKode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNama As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAlamat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtQt1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtQt2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtQt3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtQt4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroListView1 As MetroFramework.Controls.MetroListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
