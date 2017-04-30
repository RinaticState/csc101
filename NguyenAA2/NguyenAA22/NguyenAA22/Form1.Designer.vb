<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gbTicketsSold = New System.Windows.Forms.GroupBox()
        Me.gbRevenueGenerated = New System.Windows.Forms.GroupBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblClassA = New System.Windows.Forms.Label()
        Me.lblClassB = New System.Windows.Forms.Label()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.lblClassA1 = New System.Windows.Forms.Label()
        Me.lblClassB1 = New System.Windows.Forms.Label()
        Me.lblClassC1 = New System.Windows.Forms.Label()
        Me.lblTotalRevenueLabel = New System.Windows.Forms.Label()
        Me.lblClassAGenerated = New System.Windows.Forms.Label()
        Me.lblClassBGenerated = New System.Windows.Forms.Label()
        Me.lblClassCGenerated = New System.Windows.Forms.Label()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.btnCalculateRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbTicketsSold.SuspendLayout()
        Me.gbRevenueGenerated.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTicketsSold
        '
        Me.gbTicketsSold.Controls.Add(Me.txtClassC)
        Me.gbTicketsSold.Controls.Add(Me.txtClassB)
        Me.gbTicketsSold.Controls.Add(Me.txtClassA)
        Me.gbTicketsSold.Controls.Add(Me.lblClassC)
        Me.gbTicketsSold.Controls.Add(Me.lblClassB)
        Me.gbTicketsSold.Controls.Add(Me.lblClassA)
        Me.gbTicketsSold.Controls.Add(Me.lblInstructions)
        Me.gbTicketsSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTicketsSold.Location = New System.Drawing.Point(14, 12)
        Me.gbTicketsSold.Name = "gbTicketsSold"
        Me.gbTicketsSold.Size = New System.Drawing.Size(252, 221)
        Me.gbTicketsSold.TabIndex = 0
        Me.gbTicketsSold.TabStop = False
        Me.gbTicketsSold.Text = "Tickets Sold"
        '
        'gbRevenueGenerated
        '
        Me.gbRevenueGenerated.Controls.Add(Me.lblTotalRevenue)
        Me.gbRevenueGenerated.Controls.Add(Me.lblClassCGenerated)
        Me.gbRevenueGenerated.Controls.Add(Me.lblClassBGenerated)
        Me.gbRevenueGenerated.Controls.Add(Me.lblClassAGenerated)
        Me.gbRevenueGenerated.Controls.Add(Me.lblTotalRevenueLabel)
        Me.gbRevenueGenerated.Controls.Add(Me.lblClassC1)
        Me.gbRevenueGenerated.Controls.Add(Me.lblClassB1)
        Me.gbRevenueGenerated.Controls.Add(Me.lblClassA1)
        Me.gbRevenueGenerated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRevenueGenerated.Location = New System.Drawing.Point(282, 12)
        Me.gbRevenueGenerated.Name = "gbRevenueGenerated"
        Me.gbRevenueGenerated.Size = New System.Drawing.Size(252, 221)
        Me.gbRevenueGenerated.TabIndex = 1
        Me.gbRevenueGenerated.TabStop = False
        Me.gbRevenueGenerated.Text = "Revenue Generated"
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(35, 31)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(178, 45)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Enter the number of tickets sold for each class of seats"
        '
        'lblClassA
        '
        Me.lblClassA.AutoSize = True
        Me.lblClassA.Location = New System.Drawing.Point(35, 84)
        Me.lblClassA.Name = "lblClassA"
        Me.lblClassA.Size = New System.Drawing.Size(57, 16)
        Me.lblClassA.TabIndex = 1
        Me.lblClassA.Text = "Class A:"
        '
        'lblClassB
        '
        Me.lblClassB.AutoSize = True
        Me.lblClassB.Location = New System.Drawing.Point(35, 127)
        Me.lblClassB.Name = "lblClassB"
        Me.lblClassB.Size = New System.Drawing.Size(57, 16)
        Me.lblClassB.TabIndex = 2
        Me.lblClassB.Text = "Class B:"
        '
        'lblClassC
        '
        Me.lblClassC.AutoSize = True
        Me.lblClassC.Location = New System.Drawing.Point(35, 170)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Size = New System.Drawing.Size(57, 16)
        Me.lblClassC.TabIndex = 3
        Me.lblClassC.Text = "Class C:"
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(107, 81)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(65, 22)
        Me.txtClassA.TabIndex = 4
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(107, 124)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(65, 22)
        Me.txtClassB.TabIndex = 5
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(107, 167)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(65, 22)
        Me.txtClassC.TabIndex = 6
        '
        'lblClassA1
        '
        Me.lblClassA1.AutoSize = True
        Me.lblClassA1.Location = New System.Drawing.Point(74, 51)
        Me.lblClassA1.Name = "lblClassA1"
        Me.lblClassA1.Size = New System.Drawing.Size(57, 16)
        Me.lblClassA1.TabIndex = 2
        Me.lblClassA1.Text = "Class A:"
        '
        'lblClassB1
        '
        Me.lblClassB1.AutoSize = True
        Me.lblClassB1.Location = New System.Drawing.Point(74, 91)
        Me.lblClassB1.Name = "lblClassB1"
        Me.lblClassB1.Size = New System.Drawing.Size(57, 16)
        Me.lblClassB1.TabIndex = 3
        Me.lblClassB1.Text = "Class B:"
        '
        'lblClassC1
        '
        Me.lblClassC1.AutoSize = True
        Me.lblClassC1.Location = New System.Drawing.Point(74, 130)
        Me.lblClassC1.Name = "lblClassC1"
        Me.lblClassC1.Size = New System.Drawing.Size(57, 16)
        Me.lblClassC1.TabIndex = 4
        Me.lblClassC1.Text = "Class C:"
        '
        'lblTotalRevenueLabel
        '
        Me.lblTotalRevenueLabel.AutoSize = True
        Me.lblTotalRevenueLabel.Location = New System.Drawing.Point(31, 167)
        Me.lblTotalRevenueLabel.Name = "lblTotalRevenueLabel"
        Me.lblTotalRevenueLabel.Size = New System.Drawing.Size(100, 16)
        Me.lblTotalRevenueLabel.TabIndex = 5
        Me.lblTotalRevenueLabel.Text = "Total Revenue:"
        '
        'lblClassAGenerated
        '
        Me.lblClassAGenerated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassAGenerated.Location = New System.Drawing.Point(142, 49)
        Me.lblClassAGenerated.Name = "lblClassAGenerated"
        Me.lblClassAGenerated.Size = New System.Drawing.Size(88, 20)
        Me.lblClassAGenerated.TabIndex = 6
        '
        'lblClassBGenerated
        '
        Me.lblClassBGenerated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassBGenerated.Location = New System.Drawing.Point(142, 90)
        Me.lblClassBGenerated.Name = "lblClassBGenerated"
        Me.lblClassBGenerated.Size = New System.Drawing.Size(88, 20)
        Me.lblClassBGenerated.TabIndex = 7
        '
        'lblClassCGenerated
        '
        Me.lblClassCGenerated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassCGenerated.Location = New System.Drawing.Point(142, 130)
        Me.lblClassCGenerated.Name = "lblClassCGenerated"
        Me.lblClassCGenerated.Size = New System.Drawing.Size(88, 20)
        Me.lblClassCGenerated.TabIndex = 8
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRevenue.Location = New System.Drawing.Point(142, 167)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(88, 20)
        Me.lblTotalRevenue.TabIndex = 7
        '
        'btnCalculateRevenue
        '
        Me.btnCalculateRevenue.Location = New System.Drawing.Point(88, 251)
        Me.btnCalculateRevenue.Name = "btnCalculateRevenue"
        Me.btnCalculateRevenue.Size = New System.Drawing.Size(127, 28)
        Me.btnCalculateRevenue.TabIndex = 2
        Me.btnCalculateRevenue.Text = "Calculate Revenue"
        Me.btnCalculateRevenue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(237, 251)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 28)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(346, 251)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 28)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 322)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateRevenue)
        Me.Controls.Add(Me.gbRevenueGenerated)
        Me.Controls.Add(Me.gbTicketsSold)
        Me.Name = "Form1"
        Me.Text = "Stadium Seating"
        Me.gbTicketsSold.ResumeLayout(False)
        Me.gbTicketsSold.PerformLayout()
        Me.gbRevenueGenerated.ResumeLayout(False)
        Me.gbRevenueGenerated.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbTicketsSold As GroupBox
    Friend WithEvents txtClassC As TextBox
    Friend WithEvents txtClassB As TextBox
    Friend WithEvents txtClassA As TextBox
    Friend WithEvents lblClassC As Label
    Friend WithEvents lblClassB As Label
    Friend WithEvents lblClassA As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents gbRevenueGenerated As GroupBox
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents lblClassCGenerated As Label
    Friend WithEvents lblClassBGenerated As Label
    Friend WithEvents lblClassAGenerated As Label
    Friend WithEvents lblTotalRevenueLabel As Label
    Friend WithEvents lblClassC1 As Label
    Friend WithEvents lblClassB1 As Label
    Friend WithEvents lblClassA1 As Label
    Friend WithEvents btnCalculateRevenue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
