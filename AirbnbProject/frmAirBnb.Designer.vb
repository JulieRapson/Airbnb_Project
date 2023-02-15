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
        Me.lblOrlandoBnb.Location = New System.Drawing.Point(464, 41)
        Me.lblOrlandoBnb.Name = "lblOrlandoBnb"
        Me.lblOrlandoBnb.Size = New System.Drawing.Size(255, 37)
        Me.lblOrlandoBnb.TabIndex = 1
        Me.lblOrlandoBnb.Text = "Orlando AirBnB"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(492, 100)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(209, 24)
        Me.lblCost.TabIndex = 2
        Me.lblCost.Text = "Only $79.00 per night"
        '
        'frmAirBnb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(800, 461)
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
End Class
