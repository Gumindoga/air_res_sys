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
            cmd.CommandText = "insert into tblPassenger(PassengerID,Address,Age,FullName,Gender,Contact,FlightID,ReservedSeat,FlightDate,ArrivalTime,DepartureTime)values('" + txtPassenger.Text + "', '" + txtAddress.Text + "', '" + txtAge.Text + "', '" + txtFullName.Text + "', '" + txtGender.Text + "', '" + txtContact.Text + "', '" + txtFlight.Text + "', '" + txtSeat.Text + "', '" + txtDate.Text + "', '" + txtArrival.Text + "', '" + txtDeparture.Text + "')"
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
            cmd.CommandText = "UPDATE tblPassenger SET Address = @Address, Age = @Age, FullName = @FullName, Gender = @Gender, Contact = @Contact, FlightID = @FlightID, ReservedSeat = @ReservedSeat, FlightDate = @FlightDate, ArrivalTime = @ArrivalTime, DepartureTime = @DepartureTime WHERE PassengerID = @PassengerID"
            cmd.Parameters.AddWithValue("@PassengerID", txtPassenger.Text)
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@Age", txtAge.Text)
            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text)
            cmd.Parameters.AddWithValue("@Gender", txtGender.Text)
            cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
            cmd.Parameters.AddWithValue("@FlightID", txtFlight.Text)
            cmd.Parameters.AddWithValue("@ReservedSeat", txtSeat.Text)
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
            txtPassenger.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            txtAddress.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            txtAge.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
            txtFullName.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
            txtGender.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
            txtContact.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()
            txtFlight.Text = DataGridView1.SelectedRows(0).Cells(6).Value.ToString()
            txtSeat.Text = DataGridView1.SelectedRows(0).Cells(7).Value.ToString()
            txtDate.Text = DataGridView1.SelectedRows(0).Cells(8).Value.ToString()
            txtArrival.Text = DataGridView1.SelectedRows(0).Cells(9).Value.ToString()
            txtDeparture.Text = DataGridView1.SelectedRows(0).Cells(10).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Air Res Sys", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class