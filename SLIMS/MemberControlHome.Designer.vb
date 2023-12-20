<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemberControlHome
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.FlowLayoutPanelBookContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'FlowLayoutPanelBookContainer
        '
        Me.FlowLayoutPanelBookContainer.AutoScroll = True
        Me.FlowLayoutPanelBookContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanelBookContainer.Location = New System.Drawing.Point(0, 30)
        Me.FlowLayoutPanelBookContainer.Name = "FlowLayoutPanelBookContainer"
        Me.FlowLayoutPanelBookContainer.Size = New System.Drawing.Size(1027, 601)
        Me.FlowLayoutPanelBookContainer.TabIndex = 3
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(1027, 30)
        Me.TextBoxSearch.TabIndex = 2
        '
        'MemberControlHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanelBookContainer)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Name = "MemberControlHome"
        Me.Size = New System.Drawing.Size(1027, 631)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanelBookContainer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBoxSearch As System.Windows.Forms.TextBox

End Class
