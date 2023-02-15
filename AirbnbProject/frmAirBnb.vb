'Author: Julie Rapson
'Date: 2/15/2023
'Project Name: Weekly Assignment 4 - Air BnB Project
'Program details: This program was built to calculate the total cost of nights stayed at the Air BnB.

Public Class frmAirBnb
    ' Cost of a nights stay variable to use for calculations as a decimal
    'This program will load in the center of the screen
    Const decTotalCost As Decimal = 79D

    Private Sub frmAirBnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form loads, make sure the lblCalcCost is blank and the number of nights is also blank
        'Focus on the number of nights so that you can just enter a number here.
        lblCalcCost.Text = ""
        txtNumberofnights.Text = ""
        txtNumberofnights.Select()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'The exit button will  just close the program entirely.
        Close()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        'Created 3 variables here to account for the number of nights a person enters, switching to an
        'integer and then doing the calculation for the total cost using the constant variable that was created in the 
        'class. This is takign the text entered, converting to integer, calculating and then converting to string for display
        Dim strNumNights As String
        Dim intNumNights As Integer
        Dim decTotalCostOfStay As Decimal

        strNumNights = txtNumberofnights.Text
        intNumNights = Convert.ToInt32(strNumNights)
        decTotalCostOfStay = intNumNights * decTotalCost
        lblCalcCost.Text = decTotalCostOfStay.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'When a user clicks on clear, the calculation of cost and number of nights will reset showing nothing.
        'Once cleared, the number of nights text box will again get focus
        lblCalcCost.Text = ""
        txtNumberofnights.Text = ""
        txtNumberofnights.Select()
    End Sub
End Class
