'Form Name: Quiz Form
'Author: Amber Nguyen
'This QuizForm is the startup form.
'This isn't the main form although it is the startup form. It's just a quick quiz that tests the user on their knowledge of desktop
'computer parts. It is not meant to be the whole program. The actual program part of the program could be accessed by completing
'the quiz or skipping the quiz. This quiz is meant to onlybe completed once, but the MainForm is what the user wants when they
'run the program. I suppose the user could get rid of this form if they realy wanted to. When the user first launches the program,
'this form first pops up with a photo of a graphoics card. The user must guess it correctly by entering their answer into the
'textbox. A Select Case case statement evalues various answers and disregards case sensitivity. When the user guesses the part correct,
'it moves onto the next part. When the user guesses a part wrong, a MessageBox will pop up telling them to guess again. This procedure
'repeats until the user cases the case photo correctly. When they do, this QuizForm hides then the MainForm pops up. Also, when the
'user clicks the button to evaluate the answer, the textbox already clears for them.

Public Class QuizForm
    'Declaring variables

    Const strWRONG_ANSWER As String = "That's a wrong answer. Please try again."    'A string constant used for error messages.

    Dim frmMain As New MainForm                                                     'A variable for the MainForm

    Private Sub btnCheckAnswer_Click(sender As Object, e As EventArgs) Handles btnCheckAnswer.Click

        Dim strAnswer As String         'Declaring a variable

        strAnswer = txtPartsName.Text   'Assigns the string variable, strAnswer, the values received from the txtPartsName textbox

        'Clears the textbox. It will be useful when the user presses the button to guess the next part. The textbox will already be cleared.
        txtPartsName.Text = String.Empty

        'These following operations will evaluate various user inputs and is not case sensitive.
        'The photo of the GPU is first visible. It will evaluate the answer entered in the textbox and move
        'on to the CPU photo if correct, send an error message if incorrect.
        If picGPU.Visible = True Then
            Select Case strAnswer.ToUpper()
                Case "GPU", "GRAPHICS CARD", "VIDEO CARD"
                    picGPU.Visible = False
                    picCPU.Visible = True
                    Exit Sub
                Case Else
                    MessageBox.Show(strWRONG_ANSWER)
            End Select
        End If

        'After guessing the GPU correctly, the CPU photo is displayed. If guessed correctly, a photo
        'of a motherboard will be displayed, or an error message will pop up if incorrect.
        If picCPU.Visible = True Then
            Select Case strAnswer.ToUpper()
                Case "CPU", "CENTRAL PROCESSING UNIT"
                    picCPU.Visible = False
                    picMobo.Visible = True
                    Exit Sub
                Case Else
                    MessageBox.Show(strWRONG_ANSWER)
            End Select
        End If

        'The user has to guess the motherboard correctly by answering in the textbox, or an error
        'message will display.
        If picMobo.Visible = True Then
            Select Case strAnswer.ToUpper()
                Case "MOBO", "MOTHERBOARD"
                    picMobo.Visible = False
                    picPSU.Visible = True
                    Exit Sub
                Case Else
                    MessageBox.Show(strWRONG_ANSWER)
            End Select
        End If

        'The user has to guess the Power Supply Unit correct to advance or an error message will display.
        If picPSU.Visible = True Then
            Select Case strAnswer.ToUpper()
                Case "PSU", "POWER SUPPLY UNIT"
                    picPSU.Visible = False
                    picSSD.Visible = True
                    Exit Sub
                Case Else
                    MessageBox.Show(strWRONG_ANSWER)
            End Select
        End If

        'The user has to guess the SSD correctly to advance or an error message will display. This is actually
        'forgiving because I even accepted "hard drive."
        If picSSD.Visible = True Then
            Select Case strAnswer.ToUpper()
                Case "SSD", "SOLID STATE DRIVE", "STORAGE", "HARD DRIVE", "HARDDRIVE", "STORAGE DEVICE"
                    picSSD.Visible = False
                    picRAM.Visible = True
                    Exit Sub
                Case Else
                    MessageBox.Show(strWRONG_ANSWER)
            End Select
        End If

        'The user has to guess RAM correctly or an error message will display.
        If picRAM.Visible = True Then
            Select Case strAnswer.ToUpper()
                Case "RAM", "RANDOM ACCESS MEMORY", "MOTHERBOARD MEMORY"
                    picRAM.Visible = False
                    picCPUCooler.Visible = True
                    Exit Sub
                Case Else
                    MessageBox.Show(strWRONG_ANSWER)
            End Select
        End If

        'The user has to guess CPU Cooler correctly or an error message will display.
        If picCPUCooler.Visible = True Then
            Select Case strAnswer.ToUpper()
                Case "CPU COOLER", "CPU FAN", "FAN", "COOLER", "HEAT SINK", "HEATSINK"
                    picCPUCooler.Visible = False
                    picCase.Visible = True
                    Exit Sub
                Case Else
                    MessageBox.Show(strWRONG_ANSWER)
            End Select
        End If

        'If the user guesses the case correctly, then this QuizForm hides and pops the main form.
        If picCase.Visible = True Then
            Select Case strAnswer.ToUpper()
                Case "CASE", "TOWER"
                    Me.Hide()
                    frmMain.Show()
                    Exit Sub
                Case Else
                    MessageBox.Show(strWRONG_ANSWER)
            End Select
        End If

    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        'The user clicks the "Skip Quiz" button if they do not wish to deal with it.

        'This QuizForm hides.
        Me.Hide()

        'The MainForm pops up.
        frmMain.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the form.
        Me.Close()
    End Sub
End Class