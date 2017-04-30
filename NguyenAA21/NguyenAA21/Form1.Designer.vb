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
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtGas = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblMPGLabel = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMPG
        '
        Me.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMPG.Location = New System.Drawing.Point(188, 165)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(172, 20)
        Me.lblMPG.TabIndex = 17
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(188, 118)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(171, 20)
        Me.txtMiles.TabIndex = 16
        '
        'txtGas
        '
        Me.txtGas.Location = New System.Drawing.Point(188, 65)
        Me.txtGas.Name = "txtGas"
        Me.txtGas.Size = New System.Drawing.Size(171, 20)
        Me.txtGas.TabIndex = 15
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(266, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 40)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(162, 215)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 40)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblMPGLabel
        '
        Me.lblMPGLabel.AutoSize = True
        Me.lblMPGLabel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMPGLabel.Location = New System.Drawing.Point(53, 167)
        Me.lblMPGLabel.Name = "lblMPGLabel"
        Me.lblMPGLabel.Size = New System.Drawing.Size(110, 18)
        Me.lblMPGLabel.TabIndex = 12
        Me.lblMPGLabel.Text = "Miles Per Gallon:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(56, 215)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 40)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate MPG"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblMiles
        '
        Me.lblMiles.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiles.Location = New System.Drawing.Point(53, 106)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(129, 49)
        Me.lblMiles.TabIndex = 10
        Me.lblMiles.Text = "Miles to be driven if on full tank:"
        '
        'lblGallons
        '
        Me.lblGallons.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.Location = New System.Drawing.Point(53, 53)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(110, 47)
        Me.lblGallons.TabIndex = 9
        Me.lblGallons.Text = "Maximum gas in gallons for car:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 325)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtGas)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblMPGLabel)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.lblGallons)
        Me.Name = "Form1"
        Me.Text = "Miles Per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMPG As Label
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents txtGas As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblMPGLabel As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblMiles As Label
    Friend WithEvents lblGallons As Label
End Class
