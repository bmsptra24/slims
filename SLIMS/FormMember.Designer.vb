<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMember))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PanelParentAnswerAskAI = New System.Windows.Forms.Panel()
        Me.PanelAnswerAskAI = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RichTextBoxAskAI = New System.Windows.Forms.RichTextBox()
        Me.btnAskAI = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRank = New System.Windows.Forms.Button()
        Me.btnComment = New System.Windows.Forms.Button()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.PictureBoxProfilMember = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PanelParentAnswerAskAI.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProfilMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(515, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(409, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.0!)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
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
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelParentAnswerAskAI)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel10)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Georgia", 8.25!)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(22, 22, 22, 10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1264, 657)
        Me.SplitContainer1.SplitterDistance = 220
        Me.SplitContainer1.TabIndex = 3
        '
        'PanelParentAnswerAskAI
        '
        Me.PanelParentAnswerAskAI.AutoScroll = True
        Me.PanelParentAnswerAskAI.BackColor = System.Drawing.Color.GhostWhite
        Me.PanelParentAnswerAskAI.Controls.Add(Me.PanelAnswerAskAI)
        Me.PanelParentAnswerAskAI.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelParentAnswerAskAI.Location = New System.Drawing.Point(10, 362)
        Me.PanelParentAnswerAskAI.Name = "PanelParentAnswerAskAI"
        Me.PanelParentAnswerAskAI.Size = New System.Drawing.Size(200, 243)
        Me.PanelParentAnswerAskAI.TabIndex = 9
        Me.PanelParentAnswerAskAI.Visible = False
        '
        'PanelAnswerAskAI
        '
        Me.PanelAnswerAskAI.AutoSize = True
        Me.PanelAnswerAskAI.BackColor = System.Drawing.Color.White
        Me.PanelAnswerAskAI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAnswerAskAI.Location = New System.Drawing.Point(0, 0)
        Me.PanelAnswerAskAI.Name = "PanelAnswerAskAI"
        Me.PanelAnswerAskAI.Size = New System.Drawing.Size(200, 243)
        Me.PanelAnswerAskAI.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RichTextBoxAskAI)
        Me.Panel4.Controls.Add(Me.btnAskAI)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 605)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 42)
        Me.Panel4.TabIndex = 8
        '
        'RichTextBoxAskAI
        '
        Me.RichTextBoxAskAI.BackColor = System.Drawing.Color.White
        Me.RichTextBoxAskAI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBoxAskAI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxAskAI.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxAskAI.Name = "RichTextBoxAskAI"
        Me.RichTextBoxAskAI.Size = New System.Drawing.Size(131, 42)
        Me.RichTextBoxAskAI.TabIndex = 6
        Me.RichTextBoxAskAI.Text = ""
        '
        'btnAskAI
        '
        Me.btnAskAI.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnAskAI.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAskAI.FlatAppearance.BorderSize = 0
        Me.btnAskAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAskAI.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAskAI.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAskAI.Location = New System.Drawing.Point(131, 0)
        Me.btnAskAI.Name = "btnAskAI"
        Me.btnAskAI.Size = New System.Drawing.Size(69, 42)
        Me.btnAskAI.TabIndex = 0
        Me.btnAskAI.Text = "Ask AI"
        Me.btnAskAI.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRank)
        Me.Panel2.Controls.Add(Me.btnComment)
        Me.Panel2.Controls.Add(Me.btnHistory)
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(10, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 229)
        Me.Panel2.TabIndex = 6
        '
        'btnRank
        '
        Me.btnRank.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnRank.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRank.FlatAppearance.BorderSize = 0
        Me.btnRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRank.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnRank.Location = New System.Drawing.Point(0, 129)
        Me.btnRank.Name = "btnRank"
        Me.btnRank.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnRank.Size = New System.Drawing.Size(200, 43)
        Me.btnRank.TabIndex = 4
        Me.btnRank.Text = "Rank"
        Me.btnRank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRank.UseVisualStyleBackColor = False
        '
        'btnComment
        '
        Me.btnComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnComment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnComment.FlatAppearance.BorderSize = 0
        Me.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComment.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnComment.Location = New System.Drawing.Point(0, 86)
        Me.btnComment.Name = "btnComment"
        Me.btnComment.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnComment.Size = New System.Drawing.Size(200, 43)
        Me.btnComment.TabIndex = 3
        Me.btnComment.Text = "Comment"
        Me.btnComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComment.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistory.FlatAppearance.BorderSize = 0
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnHistory.Location = New System.Drawing.Point(0, 43)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHistory.Size = New System.Drawing.Size(200, 43)
        Me.btnHistory.TabIndex = 3
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHome.Location = New System.Drawing.Point(0, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHome.Size = New System.Drawing.Size(200, 43)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.PictureBoxProfilMember)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(10, 10)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(10, 20, 10, 22)
        Me.Panel10.Size = New System.Drawing.Size(200, 86)
        Me.Panel10.TabIndex = 5
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.PictureBox1)
        Me.Panel11.Controls.Add(Me.Label14)
        Me.Panel11.Controls.Add(Me.LabelUserName)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(45, 20)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(145, 44)
        Me.Panel11.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(110, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(11, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 18)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Member"
        '
        'LabelUserName
        '
        Me.LabelUserName.AutoSize = True
        Me.LabelUserName.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.LabelUserName.Location = New System.Drawing.Point(11, 2)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(88, 18)
        Me.LabelUserName.TabIndex = 1
        Me.LabelUserName.Text = "User Name"
        '
        'PictureBoxProfilMember
        '
        Me.PictureBoxProfilMember.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBoxProfilMember.InitialImage = Nothing
        Me.PictureBoxProfilMember.Location = New System.Drawing.Point(10, 20)
        Me.PictureBoxProfilMember.Name = "PictureBoxProfilMember"
        Me.PictureBoxProfilMember.Size = New System.Drawing.Size(35, 44)
        Me.PictureBoxProfilMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProfilMember.TabIndex = 0
        Me.PictureBoxProfilMember.TabStop = False
        '
        'FormMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Diaria Pro Md", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PanelParentAnswerAskAI.ResumeLayout(False)
        Me.PanelParentAnswerAskAI.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProfilMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LabelUserName As System.Windows.Forms.Label
    Friend WithEvents PictureBoxProfilMember As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnRank As System.Windows.Forms.Button
    Friend WithEvents btnComment As System.Windows.Forms.Button
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBoxAskAI As System.Windows.Forms.RichTextBox
    Friend WithEvents btnAskAI As System.Windows.Forms.Button
    Friend WithEvents PanelParentAnswerAskAI As System.Windows.Forms.Panel
    Friend WithEvents PanelAnswerAskAI As System.Windows.Forms.Panel

End Class
