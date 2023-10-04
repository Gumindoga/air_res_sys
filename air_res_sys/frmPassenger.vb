Imports System.Data.OleDb

Public Class frmPassenger

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
        da = New OleDbDataAdapter("select * from tblPassenger ", conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()

    End Sub
    Private Sub frmPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Dell Latitude\Code\VB\air_res_sys\air_res_sys.accdb"
        viewer()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        conn.Open()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into tblPassenger(PassengerID,Address,Age,FullName,Gender,Contact,Flight,ReservedSeat,FlightDate,ArrivalTime,DepartureTime)values('" + txtPassenger.Text + "', '" + txtAddress.Text + "', '" + txtAge.Text + "', '" + txtFullName.Text + "', '" + txtGender.Text + "', '" + txtContact.Text + "', '" + txtFlight.Text + "', '" + txtSeat.Text + "', '" + txtDate.Text + "', '" + txtArrival.Text + "', '" + txtDeparture.Text + "')"
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Record Saved", "Air Res Sys")
        viewer()
    End Sub
End Class