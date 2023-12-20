<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControlABook
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControlABook))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.varBookLink = New System.Windows.Forms.Label()
        Me.varBookId = New System.Windows.Forms.Label()
        Me.LabelBookDescription = New System.Windows.Forms.Label()
        Me.PictureBoxCover = New System.Windows.Forms.PictureBox()
        Me.LabelBookTitle = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBoxCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.varBookLink)
        Me.Panel3.Controls.Add(Me.varBookId)
        Me.Panel3.Controls.Add(Me.LabelBookDescription)
        Me.Panel3.Controls.Add(Me.PictureBoxCover)
        Me.Panel3.Controls.Add(Me.LabelBookTitle)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(201, 318)
        Me.Panel3.TabIndex = 2
        '
        'varBookLink
        '
        Me.varBookLink.AutoSize = True
        Me.varBookLink.BackColor = System.Drawing.Color.Transparent
        Me.varBookLink.ForeColor = System.Drawing.Color.Transparent
        Me.varBookLink.Location = New System.Drawing.Point(212, 251)
        Me.varBookLink.Name = "varBookLink"
        Me.varBookLink.Size = New System.Drawing.Size(0, 14)
        Me.varBookLink.TabIndex = 4
        '
        'varBookId
        '
        Me.varBookId.AutoSize = True
        Me.varBookId.BackColor = System.Drawing.Color.Transparent
        Me.varBookId.ForeColor = System.Drawing.Color.Transparent
        Me.varBookId.Location = New System.Drawing.Point(217, 301)
        Me.varBookId.Name = "varBookId"
        Me.varBookId.Size = New System.Drawing.Size(0, 14)
        Me.varBookId.TabIndex = 3
        '
        'LabelBookDescription
        '
        Me.LabelBookDescription.AutoSize = True
        Me.LabelBookDescription.Location = New System.Drawing.Point(12, 271)
        Me.LabelBookDescription.MaximumSize = New System.Drawing.Size(160, 30)
        Me.LabelBookDescription.Name = "LabelBookDescription"
        Me.LabelBookDescription.Size = New System.Drawing.Size(150, 28)
        Me.LabelBookDescription.TabIndex = 2
        Me.LabelBookDescription.Text = "This is the book description will look like."
        '
        'PictureBoxCover
        '
        Me.PictureBoxCover.Image = CType(resources.GetObject("PictureBoxCover.Image"), System.Drawing.Image)
        Me.PictureBoxCover.Location = New System.Drawing.Point(11, 11)
        Me.PictureBoxCover.Name = "PictureBoxCover"
        Me.PictureBoxCover.Size = New System.Drawing.Size(178, 224)
        Me.PictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxCover.TabIndex = 0
        Me.PictureBoxCover.TabStop = False
        '
        'LabelBookTitle
        '
        Me.LabelBookTitle.AutoSize = True
        Me.LabelBookTitle.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBookTitle.Location = New System.Drawing.Point(12, 247)
        Me.LabelBookTitle.MaximumSize = New System.Drawing.Size(190, 20)
        Me.LabelBookTitle.Name = "LabelBookTitle"
        Me.LabelBookTitle.Size = New System.Drawing.Size(167, 20)
        Me.LabelBookTitle.TabIndex = 1
        Me.LabelBookTitle.Text = "Book Title e dwefefew fewf wef ewf"
        '
        'UserControlABook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Name = "UserControlABook"
        Me.Size = New System.Drawing.Size(201, 318)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBoxCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelBookDescription As Label
    Friend WithEvents PictureBoxCover As PictureBox
    Friend WithEvents LabelBookTitle As Label
    Friend WithEvents varBookId As Label
    Friend WithEvents varBookLink As Label
End Class
