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
        Dim dataPath As String

        dataPath = System.Windows.Forms.Application.StartupPath

        dataPath = System.IO.Path.Combine(dataPath, "air_res_sys.accdb")

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dataPath

        viewer()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into tblFlight(FlightID,PlaneID,PlaneName,SeatsAvailable,ArrivalTime,DepartureTime,FlightDate)values('" + txtFlight.Text + "', '" + txtPlane.Text + "', '" + txtName.Text + "', '" + txtSeats.Text + "', '" + txtArrival.Text + "', '" + txtDeparture.Text + "', '" + txtDate.Text + "')"
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Saved", "Air Res Sys")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Air Res Sys", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        viewer()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE tblFlight SET PlaneID = @PlaneID, PlaneName = @PlaneName, FlightID = @FlightID, SeatsAvailable = @SeatsAvailable, FlightDate = @FlightDate, ArrivalTime = @ArrivalTime, DepartureTime = @DepartureTime WHERE FlightID = @FlightID"
            cmd.Parameters.AddWithValue("@PlaneID", txtPlane.Text)
            cmd.Parameters.AddWithValue("@PlaneName", txtName.Text)
            cmd.Parameters.AddWithValue("@FlightID", txtFlight.Text)
            cmd.Parameters.AddWithValue("@SeatsAvailable", txtSeats.Text)
            cmd.Parameters.AddWithValue("@FlightDate", txtDate.Text)
            cmd.Parameters.AddWithValue("@ArrivalTime", txtArrival.Text)
            cmd.Parameters.AddWithValue("@DepartureTime", txtDeparture.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Updated Successfully", "Air Res Sys")
            viewer()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Air Res Sys", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtFlight.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            txtPlane.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            txtName.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
            txtSeats.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
            txtDate.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
            txtArrival.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()
            txtDeparture.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Air Res Sys", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class