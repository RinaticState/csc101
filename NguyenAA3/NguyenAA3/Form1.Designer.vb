<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.gbFoods = New System.Windows.Forms.GroupBox()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.txtFrenchFries = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHamburgers = New System.Windows.Forms.TextBox()
        Me.lblDontUseHamPrice = New System.Windows.Forms.Label()
        Me.txtHotDogs = New System.Windows.Forms.TextBox()
        Me.lblDontUseHotDogsPrice = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDontUseTotal = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.gbCalculations = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblChangeDue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculateChange = New System.Windows.Forms.Button()
        Me.txtCustomerPayment = New System.Windows.Forms.TextBox()
        Me.lblDoNotUseOnceAgain = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDontEvenUseYouFool = New System.Windows.Forms.Label()
        Me.gbFoods.SuspendLayout()
        Me.gbCalculations.SuspendLayout()
        Me.lblStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbFoods
        '
        Me.gbFoods.Controls.Add(Me.btnCalculateTotal)
        Me.gbFoods.Controls.Add(Me.txtFrenchFries)
        Me.gbFoods.Controls.Add(Me.Label2)
        Me.gbFoods.Controls.Add(Me.txtHamburgers)
        Me.gbFoods.Controls.Add(Me.lblDontUseHamPrice)
        Me.gbFoods.Controls.Add(Me.txtHotDogs)
        Me.gbFoods.Controls.Add(Me.lblDontUseHotDogsPrice)
        Me.gbFoods.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFoods.Location = New System.Drawing.Point(21, 57)
        Me.gbFoods.Name = "gbFoods"
        Me.gbFoods.Size = New System.Drawing.Size(198, 284)
        Me.gbFoods.TabIndex = 0
        Me.gbFoods.TabStop = False
        Me.gbFoods.Text = "Food"
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(37, 228)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(122, 30)
        Me.btnCalculateTotal.TabIndex = 4
        Me.btnCalculateTotal.Text = "Calculate Total"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'txtFrenchFries
        '
        Me.txtFrenchFries.Location = New System.Drawing.Point(44, 189)
        Me.txtFrenchFries.Name = "txtFrenchFries"
        Me.txtFrenchFries.Size = New System.Drawing.Size(100, 24)
        Me.txtFrenchFries.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "French Fries: $0.75"
        '
        'txtHamburgers
        '
        Me.txtHamburgers.Location = New System.Drawing.Point(44, 119)
        Me.txtHamburgers.Name = "txtHamburgers"
        Me.txtHamburgers.Size = New System.Drawing.Size(100, 24)
        Me.txtHamburgers.TabIndex = 2
        '
        'lblDontUseHamPrice
        '
        Me.lblDontUseHamPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDontUseHamPrice.Location = New System.Drawing.Point(29, 88)
        Me.lblDontUseHamPrice.Name = "lblDontUseHamPrice"
        Me.lblDontUseHamPrice.Size = New System.Drawing.Size(135, 22)
        Me.lblDontUseHamPrice.TabIndex = 2
        Me.lblDontUseHamPrice.Text = "Hamburgers: $1.50"
        '
        'txtHotDogs
        '
        Me.txtHotDogs.Location = New System.Drawing.Point(44, 56)
        Me.txtHotDogs.Name = "txtHotDogs"
        Me.txtHotDogs.Size = New System.Drawing.Size(100, 24)
        Me.txtHotDogs.TabIndex = 1
        '
        'lblDontUseHotDogsPrice
        '
        Me.lblDontUseHotDogsPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDontUseHotDogsPrice.Location = New System.Drawing.Point(36, 28)
        Me.lblDontUseHotDogsPrice.Name = "lblDontUseHotDogsPrice"
        Me.lblDontUseHotDogsPrice.Size = New System.Drawing.Size(118, 22)
        Me.lblDontUseHotDogsPrice.TabIndex = 0
        Me.lblDontUseHotDogsPrice.Text = "Hot Dogs: $1.00"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(45, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter the quantity of the food the customer will purchase."
        '
        'lblDontUseTotal
        '
        Me.lblDontUseTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDontUseTotal.Location = New System.Drawing.Point(57, 24)
        Me.lblDontUseTotal.Name = "lblDontUseTotal"
        Me.lblDontUseTotal.Size = New System.Drawing.Size(91, 22)
        Me.lblDontUseTotal.TabIndex = 4
        Me.lblDontUseTotal.Text = "Total Price:"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPrice.Location = New System.Drawing.Point(48, 48)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(100, 24)
        Me.lblTotalPrice.TabIndex = 5
        '
        'gbCalculations
        '
        Me.gbCalculations.Controls.Add(Me.btnClear)
        Me.gbCalculations.Controls.Add(Me.lblChangeDue)
        Me.gbCalculations.Controls.Add(Me.Label3)
        Me.gbCalculations.Controls.Add(Me.btnCalculateChange)
        Me.gbCalculations.Controls.Add(Me.txtCustomerPayment)
        Me.gbCalculations.Controls.Add(Me.lblDoNotUseOnceAgain)
        Me.gbCalculations.Controls.Add(Me.lblTotalPrice)
        Me.gbCalculations.Controls.Add(Me.lblDontUseTotal)
        Me.gbCalculations.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCalculations.Location = New System.Drawing.Point(264, 57)
        Me.gbCalculations.Name = "gbCalculations"
        Me.gbCalculations.Size = New System.Drawing.Size(199, 284)
        Me.gbCalculations.TabIndex = 2
        Me.gbCalculations.TabStop = False
        Me.gbCalculations.Text = "Calculations"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(57, 237)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 29)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblChangeDue
        '
        Me.lblChangeDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChangeDue.Location = New System.Drawing.Point(51, 205)
        Me.lblChangeDue.Name = "lblChangeDue"
        Me.lblChangeDue.Size = New System.Drawing.Size(100, 24)
        Me.lblChangeDue.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Change Due:"
        '
        'btnCalculateChange
        '
        Me.btnCalculateChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateChange.Location = New System.Drawing.Point(32, 141)
        Me.btnCalculateChange.Name = "btnCalculateChange"
        Me.btnCalculateChange.Size = New System.Drawing.Size(140, 27)
        Me.btnCalculateChange.TabIndex = 8
        Me.btnCalculateChange.Text = "Calculate Change"
        Me.btnCalculateChange.UseVisualStyleBackColor = True
        '
        'txtCustomerPayment
        '
        Me.txtCustomerPayment.Location = New System.Drawing.Point(48, 105)
        Me.txtCustomerPayment.Name = "txtCustomerPayment"
        Me.txtCustomerPayment.Size = New System.Drawing.Size(100, 26)
        Me.txtCustomerPayment.TabIndex = 7
        '
        'lblDoNotUseOnceAgain
        '
        Me.lblDoNotUseOnceAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoNotUseOnceAgain.Location = New System.Drawing.Point(24, 79)
        Me.lblDoNotUseOnceAgain.Name = "lblDoNotUseOnceAgain"
        Me.lblDoNotUseOnceAgain.Size = New System.Drawing.Size(142, 22)
        Me.lblDoNotUseOnceAgain.TabIndex = 6
        Me.lblDoNotUseOnceAgain.Text = "Customer Payment:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(204, 345)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.lblStatus.Location = New System.Drawing.Point(0, 379)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(487, 22)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'lblDontEvenUseYouFool
        '
        Me.lblDontEvenUseYouFool.Location = New System.Drawing.Point(293, 15)
        Me.lblDontEvenUseYouFool.Name = "lblDontEvenUseYouFool"
        Me.lblDontEvenUseYouFool.Size = New System.Drawing.Size(139, 32)
        Me.lblDontEvenUseYouFool.TabIndex = 5
        Me.lblDontEvenUseYouFool.Text = "Enter any calculations you wish to make."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 401)
        Me.Controls.Add(Me.lblDontEvenUseYouFool)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbCalculations)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbFoods)
        Me.Name = "Form1"
        Me.Text = "Hot Dog Stand Cashier Program"
        Me.gbFoods.ResumeLayout(False)
        Me.gbFoods.PerformLayout()
        Me.gbCalculations.ResumeLayout(False)
        Me.gbCalculations.PerformLayout()
        Me.lblStatus.ResumeLayout(False)
        Me.lblStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbFoods As GroupBox
    Friend WithEvents btnCalculateTotal As Button
    Friend WithEvents txtFrenchFries As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHamburgers As TextBox
    Friend WithEvents lblDontUseHamPrice As Label
    Friend WithEvents txtHotDogs As TextBox
    Friend WithEvents lblDontUseHotDogsPrice As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDontUseTotal As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents gbCalculations As GroupBox
    Friend WithEvents lblChangeDue As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculateChange As Button
    Friend WithEvents txtCustomerPayment As TextBox
    Friend WithEvents lblDoNotUseOnceAgain As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblStatus As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblDontEvenUseYouFool As Label
End Class
