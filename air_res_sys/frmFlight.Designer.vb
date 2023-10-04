<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFlight
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDeparture = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtPlane = New System.Windows.Forms.TextBox()
        Me.txtFlight = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtArrival = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSeats)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDeparture)
        Me.GroupBox2.Controls.Add(Me.txtDate)
        Me.GroupBox2.Controls.Add(Me.txtPlane)
        Me.GroupBox2.Controls.Add(Me.txtFlight)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtArrival)
        Me.GroupBox2.Font = New System.Drawing.Font("Sequel", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(49, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(711, 143)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flight Details"
        '
        'txtSeats
        '
        Me.txtSeats.Location = New System.Drawing.Point(156, 107)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(166, 25)
        Me.txtSeats.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sequel", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(21, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Seats Available"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(156, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(166, 25)
        Me.txtName.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sequel", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(49, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Plane Name"
        '
        'txtDeparture
        '
        Me.txtDeparture.Location = New System.Drawing.Point(521, 51)
        Me.txtDeparture.Name = "txtDeparture"
        Me.txtDeparture.Size = New System.Drawing.Size(170, 25)
        Me.txtDeparture.TabIndex = 9
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(521, 80)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(170, 25)
        Me.txtDate.TabIndex = 7
        '
        'txtPlane
        '
        Me.txtPlane.Location = New System.Drawing.Point(156, 51)
        Me.txtPlane.Name = "txtPlane"
        Me.txtPlane.Size = New System.Drawing.Size(166, 25)
        Me.txtPlane.TabIndex = 6
        '
        'txtFlight
        '
        Me.txtFlight.Location = New System.Drawing.Point(156, 23)
        Me.txtFlight.Name = "txtFlight"
        Me.txtFlight.Size = New System.Drawing.Size(166, 25)
        Me.txtFlight.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sequel", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(408, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Arrival Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sequel", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(388, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Departure Time"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sequel", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(70, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Plane ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sequel", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(415, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 18)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Flight Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sequel", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(68, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Flight ID"
        '
        'txtArrival
        '
        Me.txtArrival.Location = New System.Drawing.Point(521, 23)
        Me.txtArrival.Name = "txtArrival"
        Me.txtArrival.Size = New System.Drawing.Size(170, 25)
        Me.txtArrival.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(211, 401)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 37)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(355, 401)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 37)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(509, 401)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 37)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(655, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 37)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(67, 401)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 37)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(66, 186)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(683, 196)
        Me.DataGridView1.TabIndex = 27
        '
        'frmFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmFlight"
        Me.Text = "Flight Form"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSeats As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDeparture As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtPlane As TextBox
    Friend WithEvents txtFlight As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtArrival As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
