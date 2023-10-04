Public Class frmMenu
    Private Sub FlightFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlightFormToolStripMenuItem.Click
        frmFlight.Show()
        Me.Hide()
    End Sub

    Private Sub PassengerFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PassengerFormToolStripMenuItem.Click
        frmPassenger.Show()
        Me.Hide()
    End Sub

    Private Sub PlaneFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaneFormToolStripMenuItem.Click
        frmPlane.Show()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
        frmLogin.Show()
    End Sub
End Class