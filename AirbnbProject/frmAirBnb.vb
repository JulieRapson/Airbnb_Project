Public Class frmAirBnb
    ' Cost of a nights stay variable to use for calculations
    Const decTotalCost As Decimal = 79D
    Private Sub lblCalcCost_Click(sender As Object, e As EventArgs) Handles lblCalcCost.Click

    End Sub

    Private Sub frmAirBnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCalcCost.Text = ""
        txtNumberofnights.Text = ""
        txtNumberofnights.Select()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim strNumNights As String
        Dim intNumNights As Integer
        Dim decTotalCostOfStay As Decimal

        strNumNights = txtNumberofnights.Text
        intNumNights = Convert.ToInt32(strNumNights)
        decTotalCostOfStay = intNumNights * decTotalCost
        lblCalcCost.Text = decTotalCostOfStay.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblCalcCost.Text = ""
        txtNumberofnights.Text = ""
        txtNumberofnights.Select()
    End Sub
End Class
