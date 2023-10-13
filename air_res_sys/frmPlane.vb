Imports System.Data.OleDb
Public Class frmPlane
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
        da = New OleDbDataAdapter("select * from tblPlane ", conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()

        DataGridView1.Columns(0).Width = 177.5
        DataGridView1.Columns(1).Width = 177.5
        DataGridView1.Columns(2).Width = 177.5

    End Sub
    Private Sub frmPlane_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            cmd.CommandText = "insert into tblPlane(PlaneID,PlaneName,SeatsAvailable)values('" + txtPlaneID.Text + "', '" + txtFullName.Text + "', '" + txtSeats.Text + "')"
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
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE tblPlane SET PlaneName = @PlaneName, AvailableSeats = @AvailableSeats WHERE PlaneID = @PlaneID"
            cmd.Parameters.AddWithValue("@PlaneName", txtFullName.Text)
            cmd.Parameters.AddWithValue("@PlaneID", txtPlaneID.Text)
            cmd.Parameters.AddWithValue("@AvailableSeats", txtSeats.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Updated Successfully", "Air Res Sys")
            viewer()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Air Res Sys", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        viewer()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtPlaneID.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            txtFullName.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            txtSeats.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Air Res Sys", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class