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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtxtTelephone = New System.Windows.Forms.MaskedTextBox()
        Me.txtShippingAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalDue = New System.Windows.Forms.TextBox()
        Me.txtSalesTax = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtCostExtras = New System.Windows.Forms.TextBox()
        Me.txtShippingCost = New System.Windows.Forms.TextBox()
        Me.txtQuantityPurchased = New System.Windows.Forms.TextBox()
        Me.txtPurchasePrice = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbtnRetail = New System.Windows.Forms.RadioButton()
        Me.rbtnWholesale = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbtnUSPostal = New System.Windows.Forms.RadioButton()
        Me.rbtnFedGround = New System.Windows.Forms.RadioButton()
        Me.rbtnFedAir = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkTireSale = New System.Windows.Forms.CheckBox()
        Me.chkClubMembership = New System.Windows.Forms.CheckBox()
        Me.chkOneYearWarranty = New System.Windows.Forms.CheckBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnTotalCountAverage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mtxtTelephone)
        Me.GroupBox1.Controls.Add(Me.txtShippingAddress)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'mtxtTelephone
        '
        Me.mtxtTelephone.Location = New System.Drawing.Point(126, 81)
        Me.mtxtTelephone.Name = "mtxtTelephone"
        Me.mtxtTelephone.Size = New System.Drawing.Size(117, 23)
        Me.mtxtTelephone.TabIndex = 3
        '
        'txtShippingAddress
        '
        Me.txtShippingAddress.Location = New System.Drawing.Point(126, 46)
        Me.txtShippingAddress.Name = "txtShippingAddress"
        Me.txtShippingAddress.Size = New System.Drawing.Size(302, 23)
        Me.txtShippingAddress.TabIndex = 2
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(126, 16)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(302, 23)
        Me.txtCustomerName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telephone:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shipping Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalDue)
        Me.GroupBox2.Controls.Add(Me.txtSalesTax)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.txtDiscount)
        Me.GroupBox2.Controls.Add(Me.txtCostExtras)
        Me.GroupBox2.Controls.Add(Me.txtShippingCost)
        Me.GroupBox2.Controls.Add(Me.txtQuantityPurchased)
        Me.GroupBox2.Controls.Add(Me.txtPurchasePrice)
        Me.GroupBox2.Controls.Add(Me.txtProductName)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 298)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Purchase Information"
        '
        'txtTotalDue
        '
        Me.txtTotalDue.Enabled = False
        Me.txtTotalDue.Location = New System.Drawing.Point(136, 262)
        Me.txtTotalDue.Name = "txtTotalDue"
        Me.txtTotalDue.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalDue.TabIndex = 17
        Me.txtTotalDue.TabStop = False
        Me.txtTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSalesTax
        '
        Me.txtSalesTax.Enabled = False
        Me.txtSalesTax.Location = New System.Drawing.Point(136, 229)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.Size = New System.Drawing.Size(100, 23)
        Me.txtSalesTax.TabIndex = 16
        Me.txtSalesTax.TabStop = False
        Me.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(136, 200)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.txtSubtotal.TabIndex = 15
        Me.txtSubtotal.TabStop = False
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Location = New System.Drawing.Point(136, 170)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 23)
        Me.txtDiscount.TabIndex = 14
        Me.txtDiscount.TabStop = False
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostExtras
        '
        Me.txtCostExtras.Enabled = False
        Me.txtCostExtras.Location = New System.Drawing.Point(136, 140)
        Me.txtCostExtras.Name = "txtCostExtras"
        Me.txtCostExtras.Size = New System.Drawing.Size(100, 23)
        Me.txtCostExtras.TabIndex = 13
        Me.txtCostExtras.TabStop = False
        Me.txtCostExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShippingCost
        '
        Me.txtShippingCost.Enabled = False
        Me.txtShippingCost.Location = New System.Drawing.Point(136, 106)
        Me.txtShippingCost.Name = "txtShippingCost"
        Me.txtShippingCost.Size = New System.Drawing.Size(100, 23)
        Me.txtShippingCost.TabIndex = 12
        Me.txtShippingCost.TabStop = False
        Me.txtShippingCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQuantityPurchased
        '
        Me.txtQuantityPurchased.Location = New System.Drawing.Point(136, 76)
        Me.txtQuantityPurchased.Name = "txtQuantityPurchased"
        Me.txtQuantityPurchased.Size = New System.Drawing.Size(100, 23)
        Me.txtQuantityPurchased.TabIndex = 6
        Me.txtQuantityPurchased.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.Location = New System.Drawing.Point(136, 44)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(100, 23)
        Me.txtPurchasePrice.TabIndex = 5
        Me.txtPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(136, 15)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(118, 23)
        Me.txtProductName.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Total Due:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 15)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Sales Tax:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Subtotal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Discount:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Cost of Extras:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Shipping Cost:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Quantity Purchased:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Purchase Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Product Identifier:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbtnRetail)
        Me.GroupBox3.Controls.Add(Me.rbtnWholesale)
        Me.GroupBox3.Location = New System.Drawing.Point(291, 138)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(158, 79)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status:"
        '
        'rbtnRetail
        '
        Me.rbtnRetail.AutoSize = True
        Me.rbtnRetail.Location = New System.Drawing.Point(7, 50)
        Me.rbtnRetail.Name = "rbtnRetail"
        Me.rbtnRetail.Size = New System.Drawing.Size(54, 19)
        Me.rbtnRetail.TabIndex = 1
        Me.rbtnRetail.Text = "Retail"
        Me.rbtnRetail.UseVisualStyleBackColor = True
        '
        'rbtnWholesale
        '
        Me.rbtnWholesale.AutoSize = True
        Me.rbtnWholesale.Checked = True
        Me.rbtnWholesale.Location = New System.Drawing.Point(7, 23)
        Me.rbtnWholesale.Name = "rbtnWholesale"
        Me.rbtnWholesale.Size = New System.Drawing.Size(79, 19)
        Me.rbtnWholesale.TabIndex = 0
        Me.rbtnWholesale.TabStop = True
        Me.rbtnWholesale.Text = "Wholesale"
        Me.rbtnWholesale.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbtnUSPostal)
        Me.GroupBox4.Controls.Add(Me.rbtnFedGround)
        Me.GroupBox4.Controls.Add(Me.rbtnFedAir)
        Me.GroupBox4.Location = New System.Drawing.Point(291, 224)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(158, 100)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Shipment Mode"
        '
        'rbtnUSPostal
        '
        Me.rbtnUSPostal.AutoSize = True
        Me.rbtnUSPostal.Location = New System.Drawing.Point(7, 74)
        Me.rbtnUSPostal.Name = "rbtnUSPostal"
        Me.rbtnUSPostal.Size = New System.Drawing.Size(83, 19)
        Me.rbtnUSPostal.TabIndex = 2
        Me.rbtnUSPostal.Text = "U. S. Postal"
        Me.rbtnUSPostal.UseVisualStyleBackColor = True
        '
        'rbtnFedGround
        '
        Me.rbtnFedGround.AutoSize = True
        Me.rbtnFedGround.Location = New System.Drawing.Point(7, 48)
        Me.rbtnFedGround.Name = "rbtnFedGround"
        Me.rbtnFedGround.Size = New System.Drawing.Size(102, 19)
        Me.rbtnFedGround.TabIndex = 1
        Me.rbtnFedGround.Text = "Fed Ex Ground"
        Me.rbtnFedGround.UseVisualStyleBackColor = True
        '
        'rbtnFedAir
        '
        Me.rbtnFedAir.AutoSize = True
        Me.rbtnFedAir.Checked = True
        Me.rbtnFedAir.Location = New System.Drawing.Point(7, 22)
        Me.rbtnFedAir.Name = "rbtnFedAir"
        Me.rbtnFedAir.Size = New System.Drawing.Size(77, 19)
        Me.rbtnFedAir.TabIndex = 0
        Me.rbtnFedAir.TabStop = True
        Me.rbtnFedAir.Text = "Fed Ex Air"
        Me.rbtnFedAir.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkTireSale)
        Me.GroupBox5.Controls.Add(Me.chkClubMembership)
        Me.GroupBox5.Controls.Add(Me.chkOneYearWarranty)
        Me.GroupBox5.Location = New System.Drawing.Point(291, 331)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(158, 100)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Extras"
        '
        'chkTireSale
        '
        Me.chkTireSale.AutoSize = True
        Me.chkTireSale.Location = New System.Drawing.Point(7, 74)
        Me.chkTireSale.Name = "chkTireSale"
        Me.chkTireSale.Size = New System.Drawing.Size(69, 19)
        Me.chkTireSale.TabIndex = 2
        Me.chkTireSale.Text = "Tire Sale"
        Me.chkTireSale.UseVisualStyleBackColor = True
        '
        'chkClubMembership
        '
        Me.chkClubMembership.AutoSize = True
        Me.chkClubMembership.Location = New System.Drawing.Point(7, 49)
        Me.chkClubMembership.Name = "chkClubMembership"
        Me.chkClubMembership.Size = New System.Drawing.Size(121, 19)
        Me.chkClubMembership.TabIndex = 1
        Me.chkClubMembership.Text = "Club Membership"
        Me.chkClubMembership.UseVisualStyleBackColor = True
        '
        'chkOneYearWarranty
        '
        Me.chkOneYearWarranty.AutoSize = True
        Me.chkOneYearWarranty.Location = New System.Drawing.Point(7, 23)
        Me.chkOneYearWarranty.Name = "chkOneYearWarranty"
        Me.chkOneYearWarranty.Size = New System.Drawing.Size(124, 19)
        Me.chkOneYearWarranty.TabIndex = 0
        Me.chkOneYearWarranty.Text = "One Year Warranty"
        Me.chkOneYearWarranty.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(13, 442)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(105, 38)
        Me.btnCompute.TabIndex = 10
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(124, 441)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 39)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnTotalCountAverage
        '
        Me.btnTotalCountAverage.Location = New System.Drawing.Point(228, 442)
        Me.btnTotalCountAverage.Name = "btnTotalCountAverage"
        Me.btnTotalCountAverage.Size = New System.Drawing.Size(112, 39)
        Me.btnTotalCountAverage.TabIndex = 12
        Me.btnTotalCountAverage.Text = "&Total, Count and Average"
        Me.btnTotalCountAverage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(344, 442)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 38)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 493)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTotalCountAverage)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Edwardsville Auto Store - Doug Bock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mtxtTelephone As MaskedTextBox
    Friend WithEvents txtShippingAddress As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtTotalDue As TextBox
    Friend WithEvents txtSalesTax As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtCostExtras As TextBox
    Friend WithEvents txtShippingCost As TextBox
    Friend WithEvents txtQuantityPurchased As TextBox
    Friend WithEvents txtPurchasePrice As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbtnRetail As RadioButton
    Friend WithEvents rbtnWholesale As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbtnUSPostal As RadioButton
    Friend WithEvents rbtnFedGround As RadioButton
    Friend WithEvents rbtnFedAir As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents chkTireSale As CheckBox
    Friend WithEvents chkClubMembership As CheckBox
    Friend WithEvents chkOneYearWarranty As CheckBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnTotalCountAverage As Button
    Friend WithEvents btnExit As Button
End Class
