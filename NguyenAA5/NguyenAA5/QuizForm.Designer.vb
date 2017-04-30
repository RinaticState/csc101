<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuizForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picCase = New System.Windows.Forms.PictureBox()
        Me.picCPUCooler = New System.Windows.Forms.PictureBox()
        Me.picRAM = New System.Windows.Forms.PictureBox()
        Me.picSSD = New System.Windows.Forms.PictureBox()
        Me.picPSU = New System.Windows.Forms.PictureBox()
        Me.picMobo = New System.Windows.Forms.PictureBox()
        Me.picCPU = New System.Windows.Forms.PictureBox()
        Me.picGPU = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPartsName = New System.Windows.Forms.TextBox()
        Me.btnCheckAnswer = New System.Windows.Forms.Button()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.picCase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCPUCooler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRAM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPSU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMobo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGPU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Guess the PC parts !"
        '
        'picCase
        '
        Me.picCase.Image = Global.NguyenAA5.My.Resources.Resources._350d_hero_up_built
        Me.picCase.Location = New System.Drawing.Point(447, 128)
        Me.picCase.Name = "picCase"
        Me.picCase.Size = New System.Drawing.Size(94, 98)
        Me.picCase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCase.TabIndex = 8
        Me.picCase.TabStop = False
        Me.picCase.Visible = False
        '
        'picCPUCooler
        '
        Me.picCPUCooler.Image = Global.NguyenAA5.My.Resources.Resources.a70_hero__72
        Me.picCPUCooler.Location = New System.Drawing.Point(315, 128)
        Me.picCPUCooler.Name = "picCPUCooler"
        Me.picCPUCooler.Size = New System.Drawing.Size(117, 98)
        Me.picCPUCooler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCPUCooler.TabIndex = 7
        Me.picCPUCooler.TabStop = False
        Me.picCPUCooler.Visible = False
        '
        'picRAM
        '
        Me.picRAM.Image = Global.NguyenAA5.My.Resources.Resources.RAM_PNG_Image2
        Me.picRAM.Location = New System.Drawing.Point(149, 128)
        Me.picRAM.Name = "picRAM"
        Me.picRAM.Size = New System.Drawing.Size(152, 98)
        Me.picRAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRAM.TabIndex = 6
        Me.picRAM.TabStop = False
        Me.picRAM.Visible = False
        '
        'picSSD
        '
        Me.picSSD.Image = Global.NguyenAA5.My.Resources.Resources._1pt8_ssd
        Me.picSSD.Location = New System.Drawing.Point(12, 128)
        Me.picSSD.Name = "picSSD"
        Me.picSSD.Size = New System.Drawing.Size(129, 98)
        Me.picSSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSSD.TabIndex = 5
        Me.picSSD.TabStop = False
        Me.picSSD.Visible = False
        '
        'picPSU
        '
        Me.picPSU.Image = Global.NguyenAA5.My.Resources.Resources.hx850_psu_sideview_cable
        Me.picPSU.Location = New System.Drawing.Point(423, 29)
        Me.picPSU.Name = "picPSU"
        Me.picPSU.Size = New System.Drawing.Size(118, 93)
        Me.picPSU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPSU.TabIndex = 4
        Me.picPSU.TabStop = False
        Me.picPSU.Visible = False
        '
        'picMobo
        '
        Me.picMobo.Image = Global.NguyenAA5.My.Resources.Resources.Motherboard_Free_PNG_Image
        Me.picMobo.Location = New System.Drawing.Point(282, 29)
        Me.picMobo.Name = "picMobo"
        Me.picMobo.Size = New System.Drawing.Size(135, 93)
        Me.picMobo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMobo.TabIndex = 3
        Me.picMobo.TabStop = False
        Me.picMobo.Visible = False
        '
        'picCPU
        '
        Me.picCPU.Image = Global.NguyenAA5.My.Resources.Resources.cpuz_logo
        Me.picCPU.Location = New System.Drawing.Point(176, 29)
        Me.picCPU.Name = "picCPU"
        Me.picCPU.Size = New System.Drawing.Size(100, 93)
        Me.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCPU.TabIndex = 2
        Me.picCPU.TabStop = False
        Me.picCPU.Visible = False
        '
        'picGPU
        '
        Me.picGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picGPU.Image = Global.NguyenAA5.My.Resources.Resources._2016_06_28_thumb_2
        Me.picGPU.Location = New System.Drawing.Point(12, 29)
        Me.picGPU.Name = "picGPU"
        Me.picGPU.Size = New System.Drawing.Size(158, 93)
        Me.picGPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGPU.TabIndex = 0
        Me.picGPU.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(173, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enter The Name Of The Part:"
        '
        'txtPartsName
        '
        Me.txtPartsName.Location = New System.Drawing.Point(119, 286)
        Me.txtPartsName.Name = "txtPartsName"
        Me.txtPartsName.Size = New System.Drawing.Size(313, 20)
        Me.txtPartsName.TabIndex = 10
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.Location = New System.Drawing.Point(119, 330)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(92, 27)
        Me.btnCheckAnswer.TabIndex = 11
        Me.btnCheckAnswer.Text = "Check Answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = True
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(232, 330)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(92, 27)
        Me.btnSkip.TabIndex = 13
        Me.btnSkip.Text = "Skip Quiz"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(340, 330)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 27)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'QuizForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 434)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.btnCheckAnswer)
        Me.Controls.Add(Me.txtPartsName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picCase)
        Me.Controls.Add(Me.picCPUCooler)
        Me.Controls.Add(Me.picRAM)
        Me.Controls.Add(Me.picSSD)
        Me.Controls.Add(Me.picPSU)
        Me.Controls.Add(Me.picMobo)
        Me.Controls.Add(Me.picCPU)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picGPU)
        Me.Name = "QuizForm"
        Me.Text = "Build A PC Quiz"
        CType(Me.picCase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCPUCooler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRAM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPSU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMobo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGPU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGPU As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picCPU As PictureBox
    Friend WithEvents picMobo As PictureBox
    Friend WithEvents picPSU As PictureBox
    Friend WithEvents picSSD As PictureBox
    Friend WithEvents picRAM As PictureBox
    Friend WithEvents picCPUCooler As PictureBox
    Friend WithEvents picCase As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPartsName As TextBox
    Friend WithEvents btnCheckAnswer As Button
    Friend WithEvents btnSkip As Button
    Friend WithEvents btnClose As Button
End Class
