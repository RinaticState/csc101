<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.gbChecklist = New System.Windows.Forms.GroupBox()
        Me.btnMissingPartsClear = New System.Windows.Forms.Button()
        Me.btnMissingParts = New System.Windows.Forms.Button()
        Me.chkPSU = New System.Windows.Forms.CheckBox()
        Me.lblMissingParts = New System.Windows.Forms.Label()
        Me.chkCase = New System.Windows.Forms.CheckBox()
        Me.chkGPU = New System.Windows.Forms.CheckBox()
        Me.chkSSD = New System.Windows.Forms.CheckBox()
        Me.chkHardDrive = New System.Windows.Forms.CheckBox()
        Me.chkCPUCooler = New System.Windows.Forms.CheckBox()
        Me.chkCPU = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkMobo = New System.Windows.Forms.CheckBox()
        Me.gbCalculator = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPSU = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCalculateTotal = New System.Windows.Forms.Button()
        Me.txtCase = New System.Windows.Forms.TextBox()
        Me.txtMobo = New System.Windows.Forms.TextBox()
        Me.txtGPUQuantity = New System.Windows.Forms.TextBox()
        Me.txtGPUPrice = New System.Windows.Forms.TextBox()
        Me.txtSSDQuantity = New System.Windows.Forms.TextBox()
        Me.txtSSDPrice = New System.Windows.Forms.TextBox()
        Me.txtHardDrive = New System.Windows.Forms.TextBox()
        Me.txtCPUCooler = New System.Windows.Forms.TextBox()
        Me.txtCPU = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbChecklist.SuspendLayout()
        Me.gbCalculator.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbChecklist
        '
        Me.gbChecklist.Controls.Add(Me.btnMissingPartsClear)
        Me.gbChecklist.Controls.Add(Me.btnMissingParts)
        Me.gbChecklist.Controls.Add(Me.chkPSU)
        Me.gbChecklist.Controls.Add(Me.lblMissingParts)
        Me.gbChecklist.Controls.Add(Me.chkCase)
        Me.gbChecklist.Controls.Add(Me.chkGPU)
        Me.gbChecklist.Controls.Add(Me.chkSSD)
        Me.gbChecklist.Controls.Add(Me.chkHardDrive)
        Me.gbChecklist.Controls.Add(Me.chkCPUCooler)
        Me.gbChecklist.Controls.Add(Me.chkCPU)
        Me.gbChecklist.Controls.Add(Me.Label1)
        Me.gbChecklist.Controls.Add(Me.chkMobo)
        Me.gbChecklist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbChecklist.Location = New System.Drawing.Point(20, 12)
        Me.gbChecklist.Name = "gbChecklist"
        Me.gbChecklist.Size = New System.Drawing.Size(269, 472)
        Me.gbChecklist.TabIndex = 0
        Me.gbChecklist.TabStop = False
        Me.gbChecklist.Text = "Checklist"
        '
        'btnMissingPartsClear
        '
        Me.btnMissingPartsClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMissingPartsClear.Location = New System.Drawing.Point(141, 354)
        Me.btnMissingPartsClear.Name = "btnMissingPartsClear"
        Me.btnMissingPartsClear.Size = New System.Drawing.Size(89, 31)
        Me.btnMissingPartsClear.TabIndex = 7
        Me.btnMissingPartsClear.Text = "Clear"
        Me.btnMissingPartsClear.UseVisualStyleBackColor = True
        '
        'btnMissingParts
        '
        Me.btnMissingParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMissingParts.Location = New System.Drawing.Point(31, 354)
        Me.btnMissingParts.Name = "btnMissingParts"
        Me.btnMissingParts.Size = New System.Drawing.Size(89, 31)
        Me.btnMissingParts.TabIndex = 6
        Me.btnMissingParts.Text = "Check"
        Me.btnMissingParts.UseVisualStyleBackColor = True
        '
        'chkPSU
        '
        Me.chkPSU.AutoSize = True
        Me.chkPSU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPSU.Location = New System.Drawing.Point(31, 286)
        Me.chkPSU.Name = "chkPSU"
        Me.chkPSU.Size = New System.Drawing.Size(157, 24)
        Me.chkPSU.TabIndex = 5
        Me.chkPSU.Text = "Power Supply Unit"
        Me.chkPSU.UseVisualStyleBackColor = True
        '
        'lblMissingParts
        '
        Me.lblMissingParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMissingParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissingParts.Location = New System.Drawing.Point(20, 396)
        Me.lblMissingParts.Name = "lblMissingParts"
        Me.lblMissingParts.Size = New System.Drawing.Size(229, 73)
        Me.lblMissingParts.TabIndex = 5
        '
        'chkCase
        '
        Me.chkCase.AutoSize = True
        Me.chkCase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCase.Location = New System.Drawing.Point(31, 319)
        Me.chkCase.Name = "chkCase"
        Me.chkCase.Size = New System.Drawing.Size(65, 24)
        Me.chkCase.TabIndex = 4
        Me.chkCase.Text = "Case"
        Me.chkCase.UseVisualStyleBackColor = True
        '
        'chkGPU
        '
        Me.chkGPU.AutoSize = True
        Me.chkGPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGPU.Location = New System.Drawing.Point(31, 252)
        Me.chkGPU.Name = "chkGPU"
        Me.chkGPU.Size = New System.Drawing.Size(130, 24)
        Me.chkGPU.TabIndex = 4
        Me.chkGPU.Text = "Graphics Card"
        Me.chkGPU.UseVisualStyleBackColor = True
        '
        'chkSSD
        '
        Me.chkSSD.AutoSize = True
        Me.chkSSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSSD.Location = New System.Drawing.Point(31, 218)
        Me.chkSSD.Name = "chkSSD"
        Me.chkSSD.Size = New System.Drawing.Size(62, 24)
        Me.chkSSD.TabIndex = 4
        Me.chkSSD.Text = "SSD"
        Me.chkSSD.UseVisualStyleBackColor = True
        '
        'chkHardDrive
        '
        Me.chkHardDrive.AutoSize = True
        Me.chkHardDrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHardDrive.Location = New System.Drawing.Point(31, 185)
        Me.chkHardDrive.Name = "chkHardDrive"
        Me.chkHardDrive.Size = New System.Drawing.Size(103, 24)
        Me.chkHardDrive.TabIndex = 4
        Me.chkHardDrive.Text = "Hard Drive"
        Me.chkHardDrive.UseVisualStyleBackColor = True
        '
        'chkCPUCooler
        '
        Me.chkCPUCooler.AutoSize = True
        Me.chkCPUCooler.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCPUCooler.Location = New System.Drawing.Point(31, 152)
        Me.chkCPUCooler.Name = "chkCPUCooler"
        Me.chkCPUCooler.Size = New System.Drawing.Size(111, 24)
        Me.chkCPUCooler.TabIndex = 3
        Me.chkCPUCooler.Text = "CPU Cooler"
        Me.chkCPUCooler.UseVisualStyleBackColor = True
        '
        'chkCPU
        '
        Me.chkCPU.AutoSize = True
        Me.chkCPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCPU.Location = New System.Drawing.Point(31, 120)
        Me.chkCPU.Name = "chkCPU"
        Me.chkCPU.Size = New System.Drawing.Size(61, 24)
        Me.chkCPU.TabIndex = 2
        Me.chkCPU.Text = "CPU"
        Me.chkCPU.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Check the parts that you already have or are set about."
        '
        'chkMobo
        '
        Me.chkMobo.AutoSize = True
        Me.chkMobo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMobo.Location = New System.Drawing.Point(31, 87)
        Me.chkMobo.Name = "chkMobo"
        Me.chkMobo.Size = New System.Drawing.Size(119, 24)
        Me.chkMobo.TabIndex = 0
        Me.chkMobo.Text = "Motherboard"
        Me.chkMobo.UseVisualStyleBackColor = True
        '
        'gbCalculator
        '
        Me.gbCalculator.Controls.Add(Me.Label13)
        Me.gbCalculator.Controls.Add(Me.Label12)
        Me.gbCalculator.Controls.Add(Me.txtPSU)
        Me.gbCalculator.Controls.Add(Me.Label11)
        Me.gbCalculator.Controls.Add(Me.btnClose)
        Me.gbCalculator.Controls.Add(Me.btnClear)
        Me.gbCalculator.Controls.Add(Me.lblTotalPrice)
        Me.gbCalculator.Controls.Add(Me.Label10)
        Me.gbCalculator.Controls.Add(Me.btnCalculateTotal)
        Me.gbCalculator.Controls.Add(Me.txtCase)
        Me.gbCalculator.Controls.Add(Me.txtMobo)
        Me.gbCalculator.Controls.Add(Me.txtGPUQuantity)
        Me.gbCalculator.Controls.Add(Me.txtGPUPrice)
        Me.gbCalculator.Controls.Add(Me.txtSSDQuantity)
        Me.gbCalculator.Controls.Add(Me.txtSSDPrice)
        Me.gbCalculator.Controls.Add(Me.txtHardDrive)
        Me.gbCalculator.Controls.Add(Me.txtCPUCooler)
        Me.gbCalculator.Controls.Add(Me.txtCPU)
        Me.gbCalculator.Controls.Add(Me.Label9)
        Me.gbCalculator.Controls.Add(Me.Label8)
        Me.gbCalculator.Controls.Add(Me.Label7)
        Me.gbCalculator.Controls.Add(Me.Label6)
        Me.gbCalculator.Controls.Add(Me.Label5)
        Me.gbCalculator.Controls.Add(Me.Label4)
        Me.gbCalculator.Controls.Add(Me.Label3)
        Me.gbCalculator.Controls.Add(Me.Label2)
        Me.gbCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCalculator.Location = New System.Drawing.Point(316, 12)
        Me.gbCalculator.Name = "gbCalculator"
        Me.gbCalculator.Size = New System.Drawing.Size(343, 472)
        Me.gbCalculator.TabIndex = 1
        Me.gbCalculator.TabStop = False
        Me.gbCalculator.Text = "Calculator"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(160, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 16)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Price:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(262, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Quantity:"
        '
        'txtPSU
        '
        Me.txtPSU.Location = New System.Drawing.Point(140, 277)
        Me.txtPSU.Name = "txtPSU"
        Me.txtPSU.Size = New System.Drawing.Size(100, 26)
        Me.txtPSU.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(88, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "PSU:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(206, 428)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 29)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(59, 428)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(122, 29)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPrice.Location = New System.Drawing.Point(142, 386)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(161, 30)
        Me.lblTotalPrice.TabIndex = 19
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 392)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 18)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Total Price:"
        '
        'btnCalculateTotal
        '
        Me.btnCalculateTotal.Location = New System.Drawing.Point(128, 346)
        Me.btnCalculateTotal.Name = "btnCalculateTotal"
        Me.btnCalculateTotal.Size = New System.Drawing.Size(122, 29)
        Me.btnCalculateTotal.TabIndex = 17
        Me.btnCalculateTotal.Text = "Calculate Total"
        Me.btnCalculateTotal.UseVisualStyleBackColor = True
        '
        'txtCase
        '
        Me.txtCase.Location = New System.Drawing.Point(140, 312)
        Me.txtCase.Name = "txtCase"
        Me.txtCase.Size = New System.Drawing.Size(100, 26)
        Me.txtCase.TabIndex = 16
        '
        'txtMobo
        '
        Me.txtMobo.Location = New System.Drawing.Point(141, 84)
        Me.txtMobo.Name = "txtMobo"
        Me.txtMobo.Size = New System.Drawing.Size(100, 26)
        Me.txtMobo.TabIndex = 15
        '
        'txtGPUQuantity
        '
        Me.txtGPUQuantity.Location = New System.Drawing.Point(250, 246)
        Me.txtGPUQuantity.Name = "txtGPUQuantity"
        Me.txtGPUQuantity.Size = New System.Drawing.Size(78, 26)
        Me.txtGPUQuantity.TabIndex = 14
        '
        'txtGPUPrice
        '
        Me.txtGPUPrice.Location = New System.Drawing.Point(140, 246)
        Me.txtGPUPrice.Name = "txtGPUPrice"
        Me.txtGPUPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtGPUPrice.TabIndex = 13
        '
        'txtSSDQuantity
        '
        Me.txtSSDQuantity.Location = New System.Drawing.Point(250, 212)
        Me.txtSSDQuantity.Name = "txtSSDQuantity"
        Me.txtSSDQuantity.Size = New System.Drawing.Size(78, 26)
        Me.txtSSDQuantity.TabIndex = 12
        '
        'txtSSDPrice
        '
        Me.txtSSDPrice.Location = New System.Drawing.Point(140, 212)
        Me.txtSSDPrice.Name = "txtSSDPrice"
        Me.txtSSDPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtSSDPrice.TabIndex = 11
        '
        'txtHardDrive
        '
        Me.txtHardDrive.Location = New System.Drawing.Point(141, 180)
        Me.txtHardDrive.Name = "txtHardDrive"
        Me.txtHardDrive.Size = New System.Drawing.Size(100, 26)
        Me.txtHardDrive.TabIndex = 10
        '
        'txtCPUCooler
        '
        Me.txtCPUCooler.Location = New System.Drawing.Point(141, 150)
        Me.txtCPUCooler.Name = "txtCPUCooler"
        Me.txtCPUCooler.Size = New System.Drawing.Size(100, 26)
        Me.txtCPUCooler.TabIndex = 9
        '
        'txtCPU
        '
        Me.txtCPU.Location = New System.Drawing.Point(141, 118)
        Me.txtCPU.Name = "txtCPU"
        Me.txtCPU.Size = New System.Drawing.Size(100, 26)
        Me.txtCPU.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(87, 317)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Case:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(89, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "GPU:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(91, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "SSD:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Hard drive:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CPU Cooler:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CPU:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Motherboard:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter the prices of the parts and quantity if specified."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 496)
        Me.Controls.Add(Me.gbCalculator)
        Me.Controls.Add(Me.gbChecklist)
        Me.Name = "MainForm"
        Me.Text = "Let's Build A PC"
        Me.gbChecklist.ResumeLayout(False)
        Me.gbChecklist.PerformLayout()
        Me.gbCalculator.ResumeLayout(False)
        Me.gbCalculator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbChecklist As GroupBox
    Friend WithEvents lblMissingParts As Label
    Friend WithEvents chkCase As CheckBox
    Friend WithEvents chkGPU As CheckBox
    Friend WithEvents chkSSD As CheckBox
    Friend WithEvents chkHardDrive As CheckBox
    Friend WithEvents chkCPUCooler As CheckBox
    Friend WithEvents chkCPU As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkMobo As CheckBox
    Friend WithEvents gbCalculator As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCalculateTotal As Button
    Friend WithEvents txtCase As TextBox
    Friend WithEvents txtMobo As TextBox
    Friend WithEvents txtGPUQuantity As TextBox
    Friend WithEvents txtGPUPrice As TextBox
    Friend WithEvents txtSSDQuantity As TextBox
    Friend WithEvents txtSSDPrice As TextBox
    Friend WithEvents txtHardDrive As TextBox
    Friend WithEvents txtCPUCooler As TextBox
    Friend WithEvents txtCPU As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents txtPSU As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chkPSU As CheckBox
    Friend WithEvents btnMissingPartsClear As Button
    Friend WithEvents btnMissingParts As Button
End Class
