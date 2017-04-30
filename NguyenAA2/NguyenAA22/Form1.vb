'	Program:  Stadium Seating Calculator
'	Written by: Amber N Nguyen
'	Date:  30 September 2016
'	Description: This program calculates ticket prices based on ticket price and number of purchases. There are three seperate tickets depending on the seating with their own prices.
'                After calculating all the prices, all the prices are totaled up to determine the total amount of revenue.
'	Challenges: First, I didn't know how to get the money values to show up (dblX.ToString("c") ).
'               Second, I was confused as to how to put the .ToString("c") for the total revenue, but I realised that I had to declare another double and set the operations for that, so I could then convert the double to a string.
'               Third, for the dblTOTAL_REVENUE calcuations, I realised that I didn't need to use any parenthesises.
'	Time Spent:	2.5 hours
'		User Input => Expected Output
'		---------------------------------------------------------------  
'		Class A: 50 => $750.00 ; Class B: 23 => $276.00 ; Class C: 62 => $558.00 ; => Total Revenue: $1,584.00
'		Class A: 93 => $1395.00 ; Class B: 169 => $2028.00 ; Class C: 500 => $4500.00 ; => Total Revenue: $7,923.00
'		Class A: 2000 => $30,000.00 ; Class B: 5000 => $60,000.00 ; Class C: 10000 => $90,000.00 ; => Total Revenue: $180,000.00

Public Class Form1
    'Declares the constant dblCLASSA_A as a Double.
    Const dblCLASS_A As Double = 15

    'Declares the constant dblCLASS_B as a Double.
    Const dblCLASS_B As Double = 12

    'Declares the constant dblCLASS_C as a Double.
    Const dblCLASS_C As Double = 9
    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        'Declares variable dblCLASS_A_TOTAL as a Double.
        Dim dblCLASS_A_TOTAL As Double

        'I am setting the operation for the variable dblCLASS_A_TOTAL to multiply the user input from txtClassA with the constant dblCLASS_A
        dblCLASS_A_TOTAL = CDbl(txtClassA.Text) * (dblCLASS_A)

        'Sets the label box to display the calculations from dblCLASS_A_TOTAL 's operation.
        lblClassAGenerated.Text = dblCLASS_A_TOTAL.ToString("c")

        'Declares variable dblClass_B_Total as a Double.
        Dim dblCLASS_B_TOTAL As Double

        'Sets up the operation for dblCLASS_B_TOTAL to multiply the user input from txtClassB with the constant dblCLASS_B
        dblCLASS_B_TOTAL = CDbl(txtClassB.Text) * (dblCLASS_B)

        'Sets the label box to display the calculations from dblCLASS_B_TOTAL 's operation.
        lblClassBGenerated.Text = dblCLASS_B_TOTAL.ToString("c")

        'Declares variable dblClass_C_Total as a Double.
        Dim dblCLASS_C_TOTAL As Double

        'Sets up the operation for dblCLASS_C_TOTAL to multiply the user input from txtClassC with the constant dblCLASS_C
        dblCLASS_C_TOTAL = CDbl(txtClassC.Text) * (dblCLASS_C)

        'Sets the label box to display the calculations from dblCLASS_C_TOTAL 's operation.
        lblClassCGenerated.Text = dblCLASS_C_TOTAL.ToString("c")

        'Declares variable dblTOTAL_REVENUE as a Double.
        Dim dblTOTAL_REVENUE As Double

        'Sets up the operation of dblTOTAL_REVENUE to add the totals from dblCLASS_A_TOTAL , dblCLASS_B_TOTAL , and dblCLASS_C_TOTAL
        dblTOTAL_REVENUE = dblCLASS_A_TOTAL + dblCLASS_B_TOTAL + dblCLASS_C_TOTAL

        'Sets the label box to display the calculations from dblTOTAL_REVENUE 's operation.
        lblTotalRevenue.Text = dblTOTAL_REVENUE.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the Class A user input textbox.
        txtClassA.Clear()

        'Clears the Class B user input textbox.
        txtClassB.Clear()

        'Clears the Class C user input textbox.
        txtClassC.Clear()

        'Clears the label box.
        lblClassAGenerated.Text = String.Empty

        'Clears the label box.
        lblClassBGenerated.Text = String.Empty

        'Clears the label box.
        lblClassCGenerated.Text = String.Empty

        'Clears the label box.
        lblTotalRevenue.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the application.
        Me.Close()
    End Sub
End Class
