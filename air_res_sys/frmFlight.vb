Imports System.Data.OleDb

Public Class frmFlight

    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap

    Private Sub viewer()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()

        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        da = New OleDbDataAdapter("select * from tblFlight", conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()

    End Sub

    Private Sub frmFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell Latitude\Code\VB\air_res_sys\air_res_sys.accdb"
        viewer()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into tblFlight(FlightID,PlaneID,PlaneName,SeatsAvailable,ArrivalTime,DepartureTime,FlightDate)values('" + txtFlight.Text + "', '" + txtPlane.Text + "', '" + txtName.Text + "', '" + txtSeats.Text + "', '" + txtArrival.Text + "', '" + txtDeparture.Text + "', '" + txtDate.Text + "')"
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Record Saved", "Air Res Sys")
        viewer()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        frmMenu.Show()
    End Sub
End Class