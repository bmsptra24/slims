Public Class ClassNavigation
    ' change control
    Public Shared Function changeControl(UserControl, Container)
        Container.Controls.Clear()
        UserControl.Dock = DockStyle.Fill
        Return Container.Controls.Add(UserControl)
    End Function

End Class
