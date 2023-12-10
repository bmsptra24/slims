<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MemberControlCommentTemplate
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
        Me.LabelContentComment = New System.Windows.Forms.Label()
        Me.LabelUserNameComment = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelContentComment
        '
        Me.LabelContentComment.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContentComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.LabelContentComment.Location = New System.Drawing.Point(31, 33)
        Me.LabelContentComment.Name = "LabelContentComment"
        Me.LabelContentComment.Size = New System.Drawing.Size(705, 27)
        Me.LabelContentComment.TabIndex = 0
        Me.LabelContentComment.Text = "Dengan menggunakan event FormClosing, Anda dapat menampilkan dialog konfirmasi."
        '
        'LabelUserNameComment
        '
        Me.LabelUserNameComment.AutoSize = True
        Me.LabelUserNameComment.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUserNameComment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.LabelUserNameComment.Location = New System.Drawing.Point(31, 14)
        Me.LabelUserNameComment.Name = "LabelUserNameComment"
        Me.LabelUserNameComment.Size = New System.Drawing.Size(98, 18)
        Me.LabelUserNameComment.TabIndex = 0
        Me.LabelUserNameComment.Text = "User Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelUserNameComment)
        Me.Panel1.Controls.Add(Me.LabelContentComment)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 76)
        Me.Panel1.TabIndex = 1
        '
        'MemberControlCommentTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MemberControlCommentTemplate"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 40, 0)
        Me.Size = New System.Drawing.Size(760, 76)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelContentComment As Label
    Friend WithEvents LabelUserNameComment As Label
    Friend WithEvents Panel1 As Panel
End Class
