<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAccountManagement = New System.Windows.Forms.Button()
        Me.btnBookManagement = New System.Windows.Forms.Button()
        Me.btnReturnBooks = New System.Windows.Forms.Button()
        Me.btnBorrowBooks = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.statusUser = New System.Windows.Forms.Label()
        Me.userName = New System.Windows.Forms.Label()
        Me.PictureBoxProfilAdmin = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProfilAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(515, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.SlateBlue
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(22, 22, 22, 10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1264, 657)
        Me.SplitContainer1.SplitterDistance = 221
        Me.SplitContainer1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAccountManagement)
        Me.Panel2.Controls.Add(Me.btnBookManagement)
        Me.Panel2.Controls.Add(Me.btnReturnBooks)
        Me.Panel2.Controls.Add(Me.btnBorrowBooks)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(10, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(201, 232)
        Me.Panel2.TabIndex = 5
        '
        'btnAccountManagement
        '
        Me.btnAccountManagement.BackColor = System.Drawing.Color.SlateBlue
        Me.btnAccountManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccountManagement.FlatAppearance.BorderSize = 0
        Me.btnAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccountManagement.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAccountManagement.Location = New System.Drawing.Point(0, 172)
        Me.btnAccountManagement.Name = "btnAccountManagement"
        Me.btnAccountManagement.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAccountManagement.Size = New System.Drawing.Size(201, 43)
        Me.btnAccountManagement.TabIndex = 5
        Me.btnAccountManagement.Text = "Account Management"
        Me.btnAccountManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccountManagement.UseVisualStyleBackColor = False
        '
        'btnBookManagement
        '
        Me.btnBookManagement.BackColor = System.Drawing.Color.SlateBlue
        Me.btnBookManagement.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBookManagement.FlatAppearance.BorderSize = 0
        Me.btnBookManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBookManagement.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBookManagement.Location = New System.Drawing.Point(0, 129)
        Me.btnBookManagement.Name = "btnBookManagement"
        Me.btnBookManagement.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBookManagement.Size = New System.Drawing.Size(201, 43)
        Me.btnBookManagement.TabIndex = 4
        Me.btnBookManagement.Text = "Book Management"
        Me.btnBookManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBookManagement.UseVisualStyleBackColor = False
        '
        'btnReturnBooks
        '
        Me.btnReturnBooks.BackColor = System.Drawing.Color.SlateBlue
        Me.btnReturnBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReturnBooks.FlatAppearance.BorderSize = 0
        Me.btnReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnBooks.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReturnBooks.Location = New System.Drawing.Point(0, 86)
        Me.btnReturnBooks.Name = "btnReturnBooks"
        Me.btnReturnBooks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnReturnBooks.Size = New System.Drawing.Size(201, 43)
        Me.btnReturnBooks.TabIndex = 3
        Me.btnReturnBooks.Text = "Return Books"
        Me.btnReturnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturnBooks.UseVisualStyleBackColor = False
        '
        'btnBorrowBooks
        '
        Me.btnBorrowBooks.BackColor = System.Drawing.Color.SlateBlue
        Me.btnBorrowBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBorrowBooks.FlatAppearance.BorderSize = 0
        Me.btnBorrowBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowBooks.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBorrowBooks.Location = New System.Drawing.Point(0, 43)
        Me.btnBorrowBooks.Name = "btnBorrowBooks"
        Me.btnBorrowBooks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBorrowBooks.Size = New System.Drawing.Size(201, 43)
        Me.btnBorrowBooks.TabIndex = 3
        Me.btnBorrowBooks.Text = "Borrow Books"
        Me.btnBorrowBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowBooks.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Lavender
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(201, 43)
        Me.btnDashboard.TabIndex = 3
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBoxProfilAdmin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 22)
        Me.Panel1.Size = New System.Drawing.Size(201, 79)
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.statusUser)
        Me.Panel3.Controls.Add(Me.userName)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(45, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(146, 37)
        Me.Panel3.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(111, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'statusUser
        '
        Me.statusUser.AutoSize = True
        Me.statusUser.ForeColor = System.Drawing.SystemColors.Control
        Me.statusUser.Location = New System.Drawing.Point(11, 24)
        Me.statusUser.Name = "statusUser"
        Me.statusUser.Size = New System.Drawing.Size(36, 13)
        Me.statusUser.TabIndex = 2
        Me.statusUser.Text = "Admin"
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.ForeColor = System.Drawing.SystemColors.Control
        Me.userName.Location = New System.Drawing.Point(11, 2)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(60, 13)
        Me.userName.TabIndex = 1
        Me.userName.Text = "User Name"
        '
        'PictureBoxProfilAdmin
        '
        Me.PictureBoxProfilAdmin.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBoxProfilAdmin.InitialImage = Nothing
        Me.PictureBoxProfilAdmin.Location = New System.Drawing.Point(10, 20)
        Me.PictureBoxProfilAdmin.Name = "PictureBoxProfilAdmin"
        Me.PictureBoxProfilAdmin.Size = New System.Drawing.Size(35, 37)
        Me.PictureBoxProfilAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProfilAdmin.TabIndex = 0
        Me.PictureBoxProfilAdmin.TabStop = False
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Homepage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProfilAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnReturnBooks As System.Windows.Forms.Button
    Friend WithEvents btnBorrowBooks As System.Windows.Forms.Button
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents statusUser As System.Windows.Forms.Label
    Friend WithEvents userName As System.Windows.Forms.Label
    Friend WithEvents PictureBoxProfilAdmin As System.Windows.Forms.PictureBox
    Friend WithEvents btnAccountManagement As System.Windows.Forms.Button
    Friend WithEvents btnBookManagement As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
