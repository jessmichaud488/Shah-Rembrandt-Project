<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtIDBox = New System.Windows.Forms.TextBox()
        Me.txtSoldBox = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNumSold = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpStats = New System.Windows.Forms.GroupBox()
        Me.txtUsedCarBox = New System.Windows.Forms.TextBox()
        Me.lblNewCar = New System.Windows.Forms.Label()
        Me.txtNewCarBox = New System.Windows.Forms.TextBox()
        Me.txtPartTimeBox = New System.Windows.Forms.TextBox()
        Me.lblUsedCar = New System.Windows.Forms.Label()
        Me.lblFullTime = New System.Windows.Forms.Label()
        Me.txtFullTimeBox = New System.Windows.Forms.TextBox()
        Me.lblPartTime = New System.Windows.Forms.Label()
        Me.grpStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIDBox
        '
        Me.txtIDBox.Location = New System.Drawing.Point(40, 62)
        Me.txtIDBox.Name = "txtIDBox"
        Me.txtIDBox.Size = New System.Drawing.Size(100, 20)
        Me.txtIDBox.TabIndex = 0
        '
        'txtSoldBox
        '
        Me.txtSoldBox.Location = New System.Drawing.Point(169, 62)
        Me.txtSoldBox.Name = "txtSoldBox"
        Me.txtSoldBox.Size = New System.Drawing.Size(68, 20)
        Me.txtSoldBox.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(41, 29)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "&ID:"
        '
        'lblNumSold
        '
        Me.lblNumSold.AutoSize = True
        Me.lblNumSold.Location = New System.Drawing.Point(167, 29)
        Me.lblNumSold.Name = "lblNumSold"
        Me.lblNumSold.Size = New System.Drawing.Size(71, 13)
        Me.lblNumSold.TabIndex = 5
        Me.lblNumSold.Text = "&Number Sold:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(297, 29)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(297, 62)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpStats
        '
        Me.grpStats.Controls.Add(Me.txtUsedCarBox)
        Me.grpStats.Controls.Add(Me.lblNewCar)
        Me.grpStats.Controls.Add(Me.txtNewCarBox)
        Me.grpStats.Controls.Add(Me.txtPartTimeBox)
        Me.grpStats.Controls.Add(Me.lblUsedCar)
        Me.grpStats.Controls.Add(Me.lblFullTime)
        Me.grpStats.Controls.Add(Me.txtFullTimeBox)
        Me.grpStats.Controls.Add(Me.lblPartTime)
        Me.grpStats.Location = New System.Drawing.Point(68, 110)
        Me.grpStats.Name = "grpStats"
        Me.grpStats.Size = New System.Drawing.Size(272, 145)
        Me.grpStats.TabIndex = 6
        Me.grpStats.TabStop = False
        Me.grpStats.Text = "Cars sold by"
        '
        'txtUsedCarBox
        '
        Me.txtUsedCarBox.Location = New System.Drawing.Point(166, 109)
        Me.txtUsedCarBox.Name = "txtUsedCarBox"
        Me.txtUsedCarBox.Size = New System.Drawing.Size(100, 20)
        Me.txtUsedCarBox.TabIndex = 10
        '
        'lblNewCar
        '
        Me.lblNewCar.AutoSize = True
        Me.lblNewCar.Location = New System.Drawing.Point(15, 85)
        Me.lblNewCar.Name = "lblNewCar"
        Me.lblNewCar.Size = New System.Drawing.Size(103, 13)
        Me.lblNewCar.TabIndex = 2
        Me.lblNewCar.Text = "New car employees:"
        '
        'txtNewCarBox
        '
        Me.txtNewCarBox.Location = New System.Drawing.Point(166, 79)
        Me.txtNewCarBox.Name = "txtNewCarBox"
        Me.txtNewCarBox.Size = New System.Drawing.Size(100, 20)
        Me.txtNewCarBox.TabIndex = 8
        '
        'txtPartTimeBox
        '
        Me.txtPartTimeBox.Location = New System.Drawing.Point(166, 49)
        Me.txtPartTimeBox.Name = "txtPartTimeBox"
        Me.txtPartTimeBox.Size = New System.Drawing.Size(100, 20)
        Me.txtPartTimeBox.TabIndex = 9
        '
        'lblUsedCar
        '
        Me.lblUsedCar.AutoSize = True
        Me.lblUsedCar.Location = New System.Drawing.Point(15, 114)
        Me.lblUsedCar.Name = "lblUsedCar"
        Me.lblUsedCar.Size = New System.Drawing.Size(106, 13)
        Me.lblUsedCar.TabIndex = 3
        Me.lblUsedCar.Text = "Used car employees:"
        '
        'lblFullTime
        '
        Me.lblFullTime.AutoSize = True
        Me.lblFullTime.Location = New System.Drawing.Point(15, 27)
        Me.lblFullTime.Name = "lblFullTime"
        Me.lblFullTime.Size = New System.Drawing.Size(101, 13)
        Me.lblFullTime.TabIndex = 0
        Me.lblFullTime.Text = "Full-time employees:"
        '
        'txtFullTimeBox
        '
        Me.txtFullTimeBox.Location = New System.Drawing.Point(166, 19)
        Me.txtFullTimeBox.Name = "txtFullTimeBox"
        Me.txtFullTimeBox.Size = New System.Drawing.Size(100, 20)
        Me.txtFullTimeBox.TabIndex = 7
        '
        'lblPartTime
        '
        Me.lblPartTime.AutoSize = True
        Me.lblPartTime.Location = New System.Drawing.Point(15, 56)
        Me.lblPartTime.Name = "lblPartTime"
        Me.lblPartTime.Size = New System.Drawing.Size(104, 13)
        Me.lblPartTime.TabIndex = 1
        Me.lblPartTime.Text = "Part-time employees:"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpStats)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblNumSold)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtSoldBox)
        Me.Controls.Add(Me.txtIDBox)
        Me.Name = "frmMain"
        Me.Text = "Rembrandt Auto-Mart"
        Me.grpStats.ResumeLayout(False)
        Me.grpStats.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIDBox As TextBox
    Friend WithEvents txtSoldBox As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblNumSold As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpStats As GroupBox
    Friend WithEvents lblNewCar As Label
    Friend WithEvents lblUsedCar As Label
    Friend WithEvents lblFullTime As Label
    Friend WithEvents lblPartTime As Label
    Friend WithEvents txtUsedCarBox As TextBox
    Friend WithEvents txtNewCarBox As TextBox
    Friend WithEvents txtPartTimeBox As TextBox
    Friend WithEvents txtFullTimeBox As TextBox
End Class
