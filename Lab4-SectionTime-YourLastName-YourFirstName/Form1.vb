Option Strict On

Public Class Form1
    'GLOBAL VARIABLES
    Dim totDiscount As Double = 0.00, aveDiscount As Double = 0.00
    Dim totQuantity As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'PERFORM LOGIC IF THE COMPUTE BUTTON IS CLICKED
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Try
            'LOCAL VARIABLES
            Dim totalpurchase As Double = Double.Parse(txtPurchasePrice.Text.Substring(1)) * Double.Parse(txtQuantityPurchased.Text)
            Dim numShippingCost = 0.00, numCostExtra = 0.00, numDiscount As Double
            Dim numSubtotal As Double, numSalesTax = 0.00, numTotalDue As Double

            'CHECKS WHICH AMONG THE SHIPMENT MODE RADIOBUTTONS ARE SELECTED, AND APPLY APPLICABLE 
            'SHIPPING COST
            If rbtnFedAir.Checked = True Then
                numShippingCost = Double.Parse(txtQuantityPurchased.Text) * 25
            ElseIf rbtnFedGround.Checked = True Then
                numShippingCost = Double.Parse(txtQuantityPurchased.Text) * 20
            Else
                numShippingCost = Double.Parse(txtQuantityPurchased.Text) * 12
            End If

            'CHECKS WHICH AMONG THE EXTRAS CHECKBOXES ARE CHECKED
            'AND APPLY ADDITIONAL COST ACCORDINGLY
            If chkClubMembership.Checked = True Then
                numCostExtra = numCostExtra + 150.0
            End If
            If chkOneYearWarranty.Checked = True Then
                numCostExtra = numCostExtra + 75.0
            End If
            If chkTireSale.Checked = True Then
                numCostExtra = numCostExtra + 25.0
            End If

            'IF WHOLESALE, THE 10% DISCOUNT IS APPLIED
            If rbtnWholesale.Checked = True Then
                numDiscount = totalpurchase / 10.0
            End If

            'COMPUTE FOR THE SUBTOTAL BY ADDING THE AMOUNT PURCHASE, SHIPPING COST, EXTRA COSTS
            'SUBTRACTED BY DISCOUNT AMOUNT
            numSubtotal = (totalpurchase + numShippingCost + numCostExtra) - numDiscount

            'COMPUTE FOR THE CORRESPONDING RETAIL TAX
            If rbtnRetail.Checked = True Then
                numSalesTax = numSubtotal / 0.05
            End If

            'COMPUTE FOR THE TOTAL DUE AMOUNT BY ADDING SUBTOTAL AND SALES TAX
            numTotalDue = numSubtotal + numSalesTax

            'COMPUTE THE TOTAL DISCOUNT AND TOTAL QUANTITY TO ACCUMULATE LATER ON
            totDiscount = totDiscount + numDiscount
            totQuantity = totQuantity + Integer.Parse(txtQuantityPurchased.Text)

            'DISPLAYS THE COMPUTED VALUES IN THE CORRESPONDING TEXTBOXES
            txtShippingCost.Text = numShippingCost.ToString("##0.00")
            txtCostExtras.Text = numCostExtra.ToString("###0.00")
            txtDiscount.Text = numDiscount.ToString("###0.00")
            txtSubtotal.Text = numSubtotal.ToString("###0.00")
            txtSalesTax.Text = numSalesTax.ToString("###0.00")
            txtTotalDue.Text = numTotalDue.ToString("$###0.00")

            'PERFORMS EXCEPTION LOGIC IF THERE ARE INVALID OR NULL ENTRIES
        Catch ex As Exception
            MessageBox.Show("There seems to be invalid entries. Kindly review your entries",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try

    End Sub

    'IF RESET BUTTON IS CLICKED, EVERYTHING IS CLEARED OUT
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCustomerName.Text = ""
        txtShippingAddress.Text = ""
        mtxtTelephone.Text = ""
        txtProductName.Text = ""
        txtPurchasePrice.Text = ""
        txtQuantityPurchased.Text = ""
        txtShippingCost.Text = ""
        txtCostExtras.Text = ""
        txtDiscount.Text = ""
        txtSubtotal.Text = ""
        txtSalesTax.Text = ""
        txtTotalDue.Text = ""

        'MAKE WHOLESALE AS SELECTED
        rbtnWholesale.Checked = True

        'MAKE FED EX AIR AS SELECTED
        rbtnFedAir.Checked = True

        'UNCHECK ALL CHECKBOX FROM EXTRAS
        chkClubMembership.Checked = False
        chkOneYearWarranty.Checked = False
        chkTireSale.Checked = False

        'SET FOCUS THE CUSTOMER NAME TEXTBOX
        txtCustomerName.Select()
    End Sub

    'ASSIGNS HOT KEYS
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCompute.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            btnReset.PerformClick()
        ElseIf e.KeyCode = Keys.C Then
            btnTotalCountAverage.PerformClick()
        ElseIf e.KeyCode = Keys.X Then
            btnExit.PerformClick()
        End If
    End Sub

    'PERFORMS THIS LOGIC IF THE EXIT BUTTON IS CLICKED
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to close this form?",
                                        "Quit",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question)
        'IF USER SELECT YES, TERMINATE PROGRAM
        If result = DialogResult.Yes Then
            End
        End If
    End Sub

    'PERFORM THIS LOGIC IF THE TOTAL COUNT AVERAGE BUTTON IS CLICKED
    Private Sub btnTotalCountAverage_Click(sender As Object, e As EventArgs) Handles btnTotalCountAverage.Click
        Try
            'COMPUTES FOR THE AVERAGE DISCOUNT
            aveDiscount = totDiscount / totQuantity

            'IF TOTAL QUANTITY IS ZERO, THROW A DIVIDE BY ZERO EXCEPTION
            If totQuantity = 0 Then
                Throw New DivideByZeroException()
                'IF NO EXCEPTIONS ENCOUNTERED, SHOW WHOLESALE TOTALS
            Else
                Dim result As DialogResult = MessageBox.Show("Total Wholesale Discounts: " & totDiscount & vbCrLf &
                                    "Total Wholesale Quantity Sold: " & totQuantity & vbCrLf &
                                    "Average Discount Amount: $" & aveDiscount & vbCrLf,
                                   "Totals, Counts and Averages",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Question)
            End If
            'PERFORM THIS IF THERE ARE NULL VALUES
        Catch ex As NullReferenceException
            MessageBox.Show("No products have been sold yet",
                            "Zero Sales Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            'PERFORM THIS IS THERE IS DIVIDE BY ZERO OPERATION
        Catch ex As DivideByZeroException
            MessageBox.Show("No products have been sold yet",
                            "Zero Sales Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try
    End Sub

    'IF THE PURCHASE PRICE IS CHANGED, PREPEND DOLLAR SIGN
    Private Sub txtPurchasePrice_TextChanged(sender As Object, e As EventArgs) Handles txtPurchasePrice.TextChanged
        Dim cleantext As String
        If txtPurchasePrice.Text.StartsWith("$") = False Then
            cleantext = "$" & txtPurchasePrice.Text
            txtPurchasePrice.Text = cleantext
            txtPurchasePrice.SelectionStart = txtPurchasePrice.SelectionStart + 2
        End If
    End Sub
End Class
