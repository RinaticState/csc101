'	Program:  Hot Dog Stand Cashier Program
'	Written by:  	Amber N Nguyen
'	Date:  11/04/16
'	Description: This program is intended as use for calculating prices as a cashier for a hot dog stand. It displays the prices
'       of the food alongside its name. It also calculates the price of the food with the 6.25% Mass Sales Tax. When the customer
'       hands the cashier the change, the user will be able to enter the amount and get the change.
'	Challenges: First, I was confused with TryParse statements and how to write them. I had to look at the textbook on how to
'       write them. Second, I did not know how to get the value of the total price from the variable "dblTotalPrice" since it was
'       in one procedure, and I had to use it for another procedure. Initially, I asked my friend, and she said I could use the
'       price output from the label, lblTotalPrice. I used the label's text output to subtract it with the dblChange variable.
'       However, when I showed Professor Hager the code, she said I could have just declared a class level variable. I must have
'       forgotten how to do that, so I looked up a Youtube video. Third, and still my only problem I do not know how to solve is
'       that when I click "calculate change," the change will appear with parentheses around the numbers. I'm not really sure
'       where the problem for that lies.. Update: I had to redo the TryParse Statements once again, but I understand them better >_>
'       Also, I had to rename my variables. Now I know how to properly name constants and doubles. I can't trust my old codes..
'       Another update: I found out the source of the parentheses problem. I was doing dblTotalPrice - dblChange, which is wrong
'       because the change should be more than the total price. VB also doesn't display the - sign for currency.
'	Time Spent:	4 hours 
'		User Input:	Expected Output:
'		---------------------------------------------------------------  
'		Hot Dogs: 5 ; Hamburgers: 1 ; French Fries: 0 => Total: $6.91 => Customer Payment: $10 => Change: $3.09
'		Hot Dogs: 60 ; Hamburgers: 50 ; French Fries: 100 => Total: $223.13 => Customer Payment: $300.13 => Change: $77.00
'		Hot Dogs: 0 ; Hamburgers: 2 ; French Fries: 0 => Total: $3.19 => Customer Payment: $3.19 => Change: $0.00
'

Public Class Form1
    'Declares constants for the prices of the foods.

    Const dblHOT_DOGS As Double = 1         'Hot Dog Price Is $1.

    Const dblHAMBURGERS As Double = 1.5     'Hamburger Price Is $1.50.

    Const dblFRENCH_FRIES As Double = 0.75  'French Fries Price Is $0.75.

    Const dblMASS_TAX As Double = 0.0625    'Mass Sales Tax Is 6.25%.

    'Declares a class level variable for the total price of the foods.

    Dim dblTotalPrice As Double             'dblTotalPrice will be used in the CalculateTotal Event Handler and Calculate Change Event Handler.

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        'Declaring variables as double.

        Dim dblHotDogPrice As Double            'This variable is for the hot dog price: its price multiplied by quantity.

        Dim dblHamburgerPrice As Double         'This variable is for the hamburger price: its price multiplied by quantity.

        Dim dblFrenchFriesPrice As Double       'This variable is for the french fries price: its price multiplied by quantity.

        Dim dblMassSalesTax As Double           'This variable is to have the total price multiplied by the 6.25% Mass Sales Tax.

        Dim dblNonTaxPrice As Double            'This variable is for the total price without the Mass Sales Tax.

        'The operation is in a try-catch block for exception handling.

        Try

            'This TryParse statement serves to validate user input and an operation for the hot dog pricing calculations.
            'It uses the variable "dblHotDogPrice" to multiply the hot dog's price with the quantity of hot dog orders.
            If Double.TryParse(txtHotDogs.Text, dblHOT_DOGS) Then
                dblHotDogPrice = CDbl(txtHotDogs.Text) * dblHOT_DOGS
            Else
                ToolStripStatusLabel1.Text = "Please enter a numeric value for the hot dogs."
            End If

            'This TryParse statement serves validate user input and an operation for the hamburger pricing calculations.
            'It uses the variable "dblHamburger" to multiply the hamburger's price with the quantity of hamburger orders.
            If Double.TryParse(txtHamburgers.Text, dblHAMBURGERS) Then
                dblHamburgerPrice = CDbl(txtHamburgers.Text) * dblHAMBURGERS
            Else
                ToolStripStatusLabel1.Text = "Please enter a numeric value for the hamburgers."
            End If

            'This TryParse statement serves validate user input and an operation for the french fries pricing calculations.
            'It uses the variable "dblFrenchFriesPrice" to multiply the french fries' price with the quantity of french fries orders.
            If Double.TryParse(txtFrenchFries.Text, dblFRENCH_FRIES) Then
                dblFrenchFriesPrice = CDbl(txtFrenchFries.Text) * dblFRENCH_FRIES
            Else
                ToolStripStatusLabel1.Text = "Please enter a numeric value for the french fries."
            End If

            'This catch part is to send a message to the user instead of crashing (although the try-parse statements tell you what you're doing wrong).
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Please enter numeric values for the food."
        End Try

        'Calculates the total prices of each foods in accordance with their quantity together. It does not include the sales tax.
        dblNonTaxPrice = dblHotDogPrice + dblHamburgerPrice + dblFrenchFriesPrice

        'Multiples the 6.25% Mass Sales Tax with the total price.
        dblMassSalesTax = dblNonTaxPrice * dblMASS_TAX

        'This adds the sales tax to the price of the non sales tax.
        dblTotalPrice = dblNonTaxPrice + dblMassSalesTax

        'Displays the output for the total price.
        lblTotalPrice.Text = dblTotalPrice.ToString("c")

        'The message box pops up a message that summarises the order.
        MessageBox.Show("The order includes " & txtHotDogs.Text & " hot dogs, " & txtHamburgers.Text & " hamburgers, and " & txtFrenchFries.Text & " French Fries, for the total of " & dblTotalPrice.ToString("c"))
    End Sub

    Private Sub btnCalculateChange_Click(sender As Object, e As EventArgs) Handles btnCalculateChange.Click
        'Declaring variables as double.

        Dim dblChange As Double             'Declares the variable for money the customer gives to the cashier.

        Dim dblChangeTotal As Double        'Declares the variable for the change to give back to the customer.

        'The operation is enclosed in a try-catch block.
        Try

            If Double.TryParse(txtCustomerPayment.Text, dblChange) Then
                dblChange = CDbl(txtCustomerPayment.Text)
            Else
                ToolStripStatusLabel1.Text = "Please enter a numeric value for the customer change."
            End If

            'Catches an error in case the user makes a mistake.
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Please enter valid numeric input for the customer change."
        End Try

        'Subtracts the input of customer payment from the total price.
        dblChangeTotal = dblChange - dblTotalPrice

        'Displays the amount of change due to the customer.
        lblChangeDue.Text = dblChangeTotal.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears the form.

        'Clears the hot dogs textbox input.
        txtHotDogs.Clear()

        'Clears the hamburgers textbox.
        txtHamburgers.Clear()

        'Clears the french fries textbox.
        txtFrenchFries.Clear()

        'Clears the label displaying total price.
        lblTotalPrice.Text = String.Empty

        'Clears the customer payment textbox.
        txtCustomerPayment.Clear()

        'Clears the change due label.
        lblChangeDue.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the application.
        Me.Close()
    End Sub

    Private Sub txtHotDogs_TextChanged(sender As Object, e As EventArgs) Handles txtHotDogs.TextChanged

    End Sub
End Class
