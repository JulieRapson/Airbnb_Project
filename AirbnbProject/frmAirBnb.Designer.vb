<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirBnb
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
        Me.picAirBnb = New System.Windows.Forms.PictureBox()
        Me.lblOrlandoBnb = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNumberofnights = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblCostofstay = New System.Windows.Forms.Label()
        Me.lblCalcCost = New System.Windows.Forms.Label()
        CType(Me.picAirBnb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAirBnb
        '
        Me.picAirBnb.Image = Global.AirbnbProject.My.Resources.Resources.airbnb
        Me.picAirBnb.Location = New System.Drawing.Point(12, 1)
        Me.picAirBnb.Name = "picAirBnb"
        Me.picAirBnb.Size = New System.Drawing.Size(378, 458)
        Me.picAirBnb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirBnb.TabIndex = 0
        Me.picAirBnb.TabStop = False
        '
        'lblOrlandoBnb
        '
        Me.lblOrlandoBnb.AutoSize = True
        Me.lblOrlandoBnb.Enabled = False
        Me.lblOrlandoBnb.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrlandoBnb.Location = New System.Drawing.Point(467, 37)
        Me.lblOrlandoBnb.Name = "lblOrlandoBnb"
        Me.lblOrlandoBnb.Size = New System.Drawing.Size(255, 37)
        Me.lblOrlandoBnb.TabIndex = 1
        Me.lblOrlandoBnb.Text = "Orlando AirBnB"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(495, 96)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(209, 24)
        Me.lblCost.TabIndex = 2
        Me.lblCost.Text = "Only $79.00 per night"
        '
        'btnCost
        '
        Me.btnCost.Location = New System.Drawing.Point(432, 335)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(75, 23)
        Me.btnCost.TabIndex = 3
        Me.btnCost.Text = "Display Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(547, 334)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(647, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNumberofnights
        '
        Me.txtNumberofnights.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberofnights.Location = New System.Drawing.Point(614, 191)
        Me.txtNumberofnights.Name = "txtNumberofnights"
        Me.txtNumberofnights.Size = New System.Drawing.Size(38, 24)
        Me.txtNumberofnights.TabIndex = 6
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(432, 197)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(145, 18)
        Me.lblNumber.TabIndex = 7
        Me.lblNumber.Text = "Number of Nights:"
        '
        'lblCostofstay
        '
        Me.lblCostofstay.AutoSize = True
        Me.lblCostofstay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostofstay.Location = New System.Drawing.Point(432, 262)
        Me.lblCostofstay.Name = "lblCostofstay"
        Me.lblCostofstay.Size = New System.Drawing.Size(107, 18)
        Me.lblCostofstay.TabIndex = 8
        Me.lblCostofstay.Text = "Cost of Stay:"
        '
        'lblCalcCost
        '
        Me.lblCalcCost.AutoSize = True
        Me.lblCalcCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcCost.Location = New System.Drawing.Point(611, 262)
        Me.lblCalcCost.Name = "lblCalcCost"
        Me.lblCalcCost.Size = New System.Drawing.Size(57, 18)
        Me.lblCalcCost.TabIndex = 9
        Me.lblCalcCost.Text = "Label1"
        '
        'frmAirBnb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(800, 461)
        Me.Controls.Add(Me.lblCalcCost)
        Me.Controls.Add(Me.lblCostofstay)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.txtNumberofnights)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblOrlandoBnb)
        Me.Controls.Add(Me.picAirBnb)
        Me.Name = "frmAirBnb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBnB Reservations"
        CType(Me.picAirBnb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAirBnb As PictureBox
    Friend WithEvents lblOrlandoBnb As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNumberofnights As TextBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblCostofstay As Label
    Friend WithEvents lblCalcCost As Label
End Class
