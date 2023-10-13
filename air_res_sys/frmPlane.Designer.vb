<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlane
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.txtPlaneID = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSeats
        '
        Me.txtSeats.Location = New System.Drawing.Point(608, 66)
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(125, 27)
        Me.txtSeats.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(53, 374)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(94, 37)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(594, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Seats Available"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(53, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Plane Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(53, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Plane ID"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(193, 107)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(125, 27)
        Me.txtFullName.TabIndex = 8
        '
        'txtPlaneID
        '
        Me.txtPlaneID.Location = New System.Drawing.Point(193, 61)
        Me.txtPlaneID.Name = "txtPlaneID"
        Me.txtPlaneID.Size = New System.Drawing.Size(125, 27)
        Me.txtPlaneID.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(649, 374)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 37)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(505, 374)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 37)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnView.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnView.Location = New System.Drawing.Point(361, 374)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(94, 37)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpdate.Font = New System.Drawing.Font("Sequel", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate.Location = New System.Drawing.Point(210, 374)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(94, 37)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(53, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(693, 188)
        Me.DataGridView1.TabIndex = 14
        '
        'frmPlane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPlaneID)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSeats)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPlane"
        Me.Text = "Plane Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSeats As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtPlaneID As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
