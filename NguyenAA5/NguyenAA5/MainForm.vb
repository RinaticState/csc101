'	Program:  Build A PC Application
'	Written by:  	Amber N Nguyen
'	Date:  10 December 2016
'	Description: The program has two forms. It first launches with a quiz form, but that is not its main form.
'   The reason for that is because it lacks content and is not the program as a whole. Thus, I call the form that
'   launches after the quiz form the main form. Anyways, the program first tests to see if the user knows the parts that are
'   inside a desktop computer. The program attempts to aid the user to build a PC by showing the most basic parts their
'   computer should have. The main form has several checkboxes for the user to check off the parts they already have, or
'   are set about. The program will respond to the user what they are missing. After, the user could use the calculator
'   part. There are no set prices because PC parts vary by manufacturer and seller. The goal of the calculator is for the
'   user to know how much their build will cost and hopefully give them a budget to work with.
'	Challenges: 	First off, I did not know how to use a subprocedure. I wanted to use one to not cram operations into a
'   single event handler. However, when faced to call the procedure, I did not know how to display the output. Thus, Professor
'   Hager told me that a using a subprocedure wasn't practical and told me to use a function. A function returns a value.
'   Using a function worked. Second, I was having problems with the quiz form. When the user guesses a part right, but
'   clicks on the "check answer" button, a message box would pop up saying the user is wrong. I figured the problem was
'   that when the next photo was set visible, it would somehow skip to the "Case Else" operation. I had to put an "Exit Sub"
'   before each "Case Else" statement, so that when the event is executed and the user gets the answer right, it would end the
'   part and not skip to the next problem. I know it's hard to explain and understand >_< . Third, I didn't know what to
'   declare as constants since the program primarily relies on user input. I realised that I could declare strings as constants,
'   hopefully they're still valid constants if I just use some of them once..
'	Time Spent:	10 hours (probably longer)
'   I used six of the following operations in this project:
'   1) An If-Then Statement, as well as a Select Case statement
'   2) A MessageBox
'   3) Checkboxes
'   4) Pictureboxes
'   5) More than two buttons
'   6) Multitple forms
'   For this Main Form:
'		User Input:	                                    Expected Output:
'		---------------------------------------------------------------  
'		Only checks CPU and Hard Drive => "You're missing a motherboard, CPU Cooler, SSD, Graphics Card, Power Supply Unit, and a case."
'		Calculator Part: Mobo: 100; CPU: 0; CPU Cooler: 0; Hard Drive: 50; SSD: 0, Quant: 0; GPU: 200, Quant: 2;
'       PSU: 0; Case: 150 => $700
'		Mobo: 150; CPU: 200; CPU Cooler: 100; Hard Drive: 50; SSD: 120, Quant: 3; GPU: 350, Quant: 1; PSU: 50; Case: 0 => $1260
'   Now for the specifics of this form: I call it the Main Form, although it is not the first form that starts up.
'   The reason for that is because  this form has more information and operations than the quix form that first starts up. People could
'   even skip the quiz form if they don't care or not want to repeat it multiple times. Thus, this main form is the form they want when
'   they repeatedly use the program. This Main Form has a PC Parts checkbox to the left and a calculator part to the right. When
'   the user checks off a PC Part they already have or plan to buy, the program will just give back what parts they are missing. For the
'   calculator part, it doesn't have set prices or anything. The user just puts in the prices for the parts, and the program gives back
'   the total price of the build. There are various PC parts made by different manufacturers and priced different between retailers - there's
'   tons of possibilities, and the program can't guess what the user actually wants.

Public Class MainForm
    'Declaring string constants.

    Const strError As String = "Please enter valid numeric inputs."     'This is for an error message.

    Const strMissingParts As String = "You are missing"                 'This is for the beginning of a sentence.

    'I used a function operation to calculate prices and to return a value.

    Function Calculations() As Double

        'Declaring Variables

        Dim dblMoboPrice As Double          'Sets the variable for the motherboard price.

        Dim dblCPUPrice As Double           'Sets the variable for the CPU price.

        Dim dblCoolerPrice As Double        'Sets the variable for the CPU Cooler price.

        Dim dblHardDrivePrice As Double     'Sets the variable for the Hard Drive price.

        Dim dblSSDPrice As Double           'Sets the variable for the SSD price.

        Dim dblGPUPrice As Double           'Sets the variable for the GPU price.

        Dim dblCasePrice As Double          'Sets the variable for the case price.

        Dim dblPSUPrice As Double           'Sets the variable for the PSU price.

        Dim dblTotal As Double              'Sets the variable for the total price of all the parts.

        'I enclosed the function operation in a Try-Catch block for exception handling.
        Try

            'The following TryParse statement takes the user input from the GPU Price textbox and the GPU Quantity textbox, multiples them
            'together then store them in the dblGPUPrice variable.
            If Double.TryParse(txtGPUPrice.Text, dblGPUPrice) Then
                dblGPUPrice = CDbl(txtGPUPrice.Text) * CDbl(txtGPUQuantity.Text)
            End If

            'The following TryParse statement takes the user input from the SSD Price textbox and the SSD Quantity textbox, multiples them
            'together, then place them in the dblSSDPrice variable.
            If Double.TryParse(txtSSDPrice.Text, dblSSDPrice) Then
                dblSSDPrice = CDbl(txtSSDPrice.Text) * CDbl(txtSSDQuantity.Text)
            End If

            'Converting textbox inputs to a double data type.
            dblMoboPrice = CDbl(txtMobo.Text)               'Stores the textbox input for the Motherboard price into dblMoboPrice

            dblCPUPrice = CDbl(txtCPU.Text)                 'Stores the textbox input for the CPU price into dblCPUPrice

            dblCoolerPrice = CDbl(txtCPUCooler.Text)        'Stores the textbox input for the CPU Cooler price into dblCoolerPrice

            dblPSUPrice = CDbl(txtPSU.Text)                 'Stores the textbox input for the PSU price into dblPSUPrice

            dblHardDrivePrice = CDbl(txtHardDrive.Text)     'Stores the textbox input for the Hard Drive price into dblHardDrivePrice

            dblCasePrice = CDbl(txtCase.Text)               'Stores the textbox input for the Case price into dblCasePrice

            'Adding up the prices of the parts together and putting them in the dblTotal variable
            dblTotal = dblMoboPrice + dblCPUPrice + dblCoolerPrice + dblPSUPrice + dblHardDrivePrice + dblCasePrice + dblGPUPrice + dblSSDPrice

        Catch ex As Exception

            'A messagebox pops up with an error message if the user doesn't enter a value or words instead of numbers
            MessageBox.Show(strError)

        End Try

        'The function will return the value of the price of the parts added together.
        Return dblTotal

    End Function

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click

        'A function call by displaying the value of the function in a label.
        lblTotalPrice.Text = Calculations().ToString("c")

    End Sub

    Private Sub btnMissingParts_Click(sender As Object, e As EventArgs) Handles btnMissingParts.Click
        'This is for the beginning of the statement
        lblMissingParts.Text = strMissingParts

        'For the parts the user didn't check, it tells what unchecked parts the user is missing

        'If the user didn't check off the Motherboard, it will tell the user they're missing a motherboard.
        If chkMobo.Checked = False Then
            lblMissingParts.Text &= " a motherboard, "
        End If

        'If the user didn't check off the CPU, it will tell the user they're missing a CPU.
        If chkCPU.Checked = False Then
            lblMissingParts.Text &= " a CPU, "
        End If

        'If the user didn't check off the CPU Cooler, it will tell the user they're missing a CPU Cooler.
        If chkCPUCooler.Checked = False Then
            lblMissingParts.Text &= " a CPU cooler, "
        End If

        'If the user didn't check off the Hard Drive, it will tell the user they're missing a Hard Drive.
        If chkHardDrive.Checked = False Then
            lblMissingParts.Text &= " a hard drive, "
        End If

        'If the user didn't check off the SSD, it will tell the user they're missing some SSDs.
        If chkSSD.Checked = False Then
            lblMissingParts.Text &= " some SSDs, "
        End If

        'If the user didn't check off the GPU, it will tell the user they're missing a GPU.
        If chkGPU.Checked = False Then
            lblMissingParts.Text &= " a video card, "
        End If

        'If the user didn't check off the PSU, it will tell the user they're missing a PSU.
        If chkPSU.Checked = False Then
            lblMissingParts.Text &= "a power supply unit, "
        End If

        'If the user didn't check off the Case, it will tell the user they're missing a Case.
        If chkCase.Checked = False Then
            lblMissingParts.Text &= "and a case . "
        End If

    End Sub

    Private Sub btnMissingPartsClear_Click(sender As Object, e As EventArgs) Handles btnMissingPartsClear.Click
        'Clears the checks for the checkboxes

        'Unchecks the Motherboard checkbox.
        chkMobo.Checked = False

        'Unchecks the CPU checkbox.
        chkCPU.Checked = False

        'Unchecks the CPU Cooler checkbox.
        chkCPUCooler.Checked = False

        'Unchecks the Hard Drive checkbox.
        chkHardDrive.Checked = False

        'Unchecks the SSD checkbox.
        chkSSD.Checked = False

        'Unchecks the GPU checkbox.
        chkGPU.Checked = False

        'Unchecks the PSU checkbox.
        chkPSU.Checked = False

        'Unchecks the Case checkbox.
        chkCase.Checked = False

        'Clears the label.
        lblMissingParts.Text = String.Empty
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the textboxes
        txtMobo.Clear()         'Clears the motherboard textbox

        txtCPU.Clear()          'Clears the CPU textbox

        txtCPUCooler.Clear()    'Clears the CPU Cooler textbox

        txtHardDrive.Clear()    'Clears the Hard Drive textbox

        txtSSDPrice.Clear()     'Clears the SSD Price textbox

        txtSSDQuantity.Clear()  'Clears the SSD Quantity textbox

        txtGPUPrice.Clear()     'Clears the GPU Price textbox

        txtGPUQuantity.Clear()  'Clears the GPU Quantity textbox

        txtPSU.Clear()          'Clears the PSU textbox

        txtCase.Clear()         'Clears the Case textbox

        'Clears the total price label.
        lblTotalPrice.Text = String.Empty

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the form

        'Declaring a variable for the quiz form.
        Dim frmQuiz As New QuizForm

        'Closes this form, the MainForm.
        Me.Close()

        'Closes the QuizForm since it was previously hidden.
        QuizForm.Close()
    End Sub
End Class
