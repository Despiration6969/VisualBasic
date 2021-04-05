<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order
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
        Me.lblFOTitle = New System.Windows.Forms.Label()
        Me.lblFOCustomerID = New System.Windows.Forms.Label()
        Me.cboFOCusName = New System.Windows.Forms.ComboBox()
        Me.lstboxOrderedFood = New System.Windows.Forms.ListBox()
        Me.btnFoodAdd = New System.Windows.Forms.Button()
        Me.btnFoodRemove = New System.Windows.Forms.Button()
        Me.btnPaymentConfirm = New System.Windows.Forms.Button()
        Me.lblFoodList = New System.Windows.Forms.Label()
        Me.lblOrderedFood = New System.Windows.Forms.Label()
        Me.txtboxSubtotal = New System.Windows.Forms.TextBox()
        Me.txtboxTax = New System.Windows.Forms.TextBox()
        Me.txtboxTotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblFOTotal = New System.Windows.Forms.Label()
        Me.lstboxFoodList = New System.Windows.Forms.ListBox()
        Me.btnFOMenu = New System.Windows.Forms.Button()
        Me.lblFOStaffLoggedIn = New System.Windows.Forms.Label()
        Me.lblShoppingCart = New System.Windows.Forms.Label()
        Me.PBFood1 = New System.Windows.Forms.PictureBox()
        Me.PBFood2 = New System.Windows.Forms.PictureBox()
        Me.PBFood3 = New System.Windows.Forms.PictureBox()
        Me.PBFood4 = New System.Windows.Forms.PictureBox()
        Me.PBDrink1 = New System.Windows.Forms.PictureBox()
        Me.PBDrink2 = New System.Windows.Forms.PictureBox()
        Me.PBDrink3 = New System.Windows.Forms.PictureBox()
        Me.PBDrink4 = New System.Windows.Forms.PictureBox()
        Me.PBSide1 = New System.Windows.Forms.PictureBox()
        Me.PBSide2 = New System.Windows.Forms.PictureBox()
        Me.PBSide3 = New System.Windows.Forms.PictureBox()
        Me.PBSide4 = New System.Windows.Forms.PictureBox()
        Me.txtboxFood1 = New System.Windows.Forms.TextBox()
        Me.txtboxFood2 = New System.Windows.Forms.TextBox()
        Me.txtboxFood3 = New System.Windows.Forms.TextBox()
        Me.txtboxFood4 = New System.Windows.Forms.TextBox()
        Me.txtboxDrink1 = New System.Windows.Forms.TextBox()
        Me.txtboxSide1 = New System.Windows.Forms.TextBox()
        Me.txtboxDrink2 = New System.Windows.Forms.TextBox()
        Me.txtboxSide2 = New System.Windows.Forms.TextBox()
        Me.txtboxDrink3 = New System.Windows.Forms.TextBox()
        Me.txtboxDrink4 = New System.Windows.Forms.TextBox()
        Me.txtboxSide4 = New System.Windows.Forms.TextBox()
        Me.txtboxSide3 = New System.Windows.Forms.TextBox()
        Me.btnFOUpdateCart = New System.Windows.Forms.Button()
        Me.lblFoodPrice1 = New System.Windows.Forms.Label()
        Me.lblDrinkPrice1 = New System.Windows.Forms.Label()
        Me.lblSidePrice1 = New System.Windows.Forms.Label()
        Me.lblFoodPrice2 = New System.Windows.Forms.Label()
        Me.lblDrinkPrice2 = New System.Windows.Forms.Label()
        Me.lblSidePrice2 = New System.Windows.Forms.Label()
        Me.lblFoodPrice3 = New System.Windows.Forms.Label()
        Me.lblDrinkPrice3 = New System.Windows.Forms.Label()
        Me.lblSidePrice3 = New System.Windows.Forms.Label()
        Me.lblFoodPrice4 = New System.Windows.Forms.Label()
        Me.lblDrinkPrice4 = New System.Windows.Forms.Label()
        Me.lblSidePrice4 = New System.Windows.Forms.Label()
        Me.btnFOClearCart = New System.Windows.Forms.Button()
        CType(Me.PBFood1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFood2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFood3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFood4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDrink1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDrink2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDrink3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDrink4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSide1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSide2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSide3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSide4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFOTitle
        '
        Me.lblFOTitle.AutoSize = True
        Me.lblFOTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFOTitle.Location = New System.Drawing.Point(79, 9)
        Me.lblFOTitle.Name = "lblFOTitle"
        Me.lblFOTitle.Size = New System.Drawing.Size(360, 73)
        Me.lblFOTitle.TabIndex = 1
        Me.lblFOTitle.Text = "Food Order"
        '
        'lblFOCustomerID
        '
        Me.lblFOCustomerID.AutoSize = True
        Me.lblFOCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFOCustomerID.Location = New System.Drawing.Point(12, 111)
        Me.lblFOCustomerID.Name = "lblFOCustomerID"
        Me.lblFOCustomerID.Size = New System.Drawing.Size(152, 24)
        Me.lblFOCustomerID.TabIndex = 4
        Me.lblFOCustomerID.Text = "Customer Name:"
        '
        'cboFOCusName
        '
        Me.cboFOCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFOCusName.FormattingEnabled = True
        Me.cboFOCusName.Location = New System.Drawing.Point(170, 108)
        Me.cboFOCusName.Name = "cboFOCusName"
        Me.cboFOCusName.Size = New System.Drawing.Size(221, 32)
        Me.cboFOCusName.TabIndex = 6
        '
        'lstboxOrderedFood
        '
        Me.lstboxOrderedFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxOrderedFood.FormattingEnabled = True
        Me.lstboxOrderedFood.ItemHeight = 24
        Me.lstboxOrderedFood.Location = New System.Drawing.Point(575, 145)
        Me.lstboxOrderedFood.Name = "lstboxOrderedFood"
        Me.lstboxOrderedFood.Size = New System.Drawing.Size(223, 244)
        Me.lstboxOrderedFood.TabIndex = 8
        '
        'btnFoodAdd
        '
        Me.btnFoodAdd.Location = New System.Drawing.Point(397, 145)
        Me.btnFoodAdd.Name = "btnFoodAdd"
        Me.btnFoodAdd.Size = New System.Drawing.Size(172, 42)
        Me.btnFoodAdd.TabIndex = 9
        Me.btnFoodAdd.Text = "Add"
        Me.btnFoodAdd.UseVisualStyleBackColor = True
        '
        'btnFoodRemove
        '
        Me.btnFoodRemove.Location = New System.Drawing.Point(397, 193)
        Me.btnFoodRemove.Name = "btnFoodRemove"
        Me.btnFoodRemove.Size = New System.Drawing.Size(172, 42)
        Me.btnFoodRemove.TabIndex = 10
        Me.btnFoodRemove.Text = "Remove"
        Me.btnFoodRemove.UseVisualStyleBackColor = True
        '
        'btnPaymentConfirm
        '
        Me.btnPaymentConfirm.Location = New System.Drawing.Point(600, 500)
        Me.btnPaymentConfirm.Name = "btnPaymentConfirm"
        Me.btnPaymentConfirm.Size = New System.Drawing.Size(172, 42)
        Me.btnPaymentConfirm.TabIndex = 12
        Me.btnPaymentConfirm.Text = "Confirm Payment"
        Me.btnPaymentConfirm.UseVisualStyleBackColor = True
        '
        'lblFoodList
        '
        Me.lblFoodList.AutoSize = True
        Me.lblFoodList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodList.Location = New System.Drawing.Point(72, 145)
        Me.lblFoodList.Name = "lblFoodList"
        Me.lblFoodList.Size = New System.Drawing.Size(92, 24)
        Me.lblFoodList.TabIndex = 13
        Me.lblFoodList.Text = "Food List:"
        '
        'lblOrderedFood
        '
        Me.lblOrderedFood.AutoSize = True
        Me.lblOrderedFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderedFood.Location = New System.Drawing.Point(575, 118)
        Me.lblOrderedFood.Name = "lblOrderedFood"
        Me.lblOrderedFood.Size = New System.Drawing.Size(136, 24)
        Me.lblOrderedFood.TabIndex = 14
        Me.lblOrderedFood.Text = "Ordered Food:"
        '
        'txtboxSubtotal
        '
        Me.txtboxSubtotal.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxSubtotal.Location = New System.Drawing.Point(575, 395)
        Me.txtboxSubtotal.Name = "txtboxSubtotal"
        Me.txtboxSubtotal.ReadOnly = True
        Me.txtboxSubtotal.Size = New System.Drawing.Size(223, 29)
        Me.txtboxSubtotal.TabIndex = 15
        '
        'txtboxTax
        '
        Me.txtboxTax.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxTax.Location = New System.Drawing.Point(575, 430)
        Me.txtboxTax.Name = "txtboxTax"
        Me.txtboxTax.ReadOnly = True
        Me.txtboxTax.Size = New System.Drawing.Size(223, 29)
        Me.txtboxTax.TabIndex = 16
        '
        'txtboxTotal
        '
        Me.txtboxTotal.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxTotal.Location = New System.Drawing.Point(575, 465)
        Me.txtboxTotal.Name = "txtboxTotal"
        Me.txtboxTotal.ReadOnly = True
        Me.txtboxTotal.Size = New System.Drawing.Size(223, 29)
        Me.txtboxTotal.TabIndex = 17
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(487, 398)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(82, 24)
        Me.lblSubtotal.TabIndex = 18
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(480, 430)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(89, 24)
        Me.lblTax.TabIndex = 19
        Me.lblTax.Text = "Tax (6%):"
        '
        'lblFOTotal
        '
        Me.lblFOTotal.AutoSize = True
        Me.lblFOTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFOTotal.Location = New System.Drawing.Point(513, 468)
        Me.lblFOTotal.Name = "lblFOTotal"
        Me.lblFOTotal.Size = New System.Drawing.Size(56, 24)
        Me.lblFOTotal.TabIndex = 20
        Me.lblFOTotal.Text = "Total:"
        '
        'lstboxFoodList
        '
        Me.lstboxFoodList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxFoodList.FormattingEnabled = True
        Me.lstboxFoodList.ItemHeight = 24
        Me.lstboxFoodList.Items.AddRange(New Object() {"Fried Rice", "Fried Noodle", "Steak", "Cake", "Soybean Drink", "Canned Drink", "Coffee", "Tea", "Fries", "Nugget", "Salad", "Hash Brown "})
        Me.lstboxFoodList.Location = New System.Drawing.Point(168, 146)
        Me.lstboxFoodList.Name = "lstboxFoodList"
        Me.lstboxFoodList.Size = New System.Drawing.Size(223, 292)
        Me.lstboxFoodList.TabIndex = 21
        '
        'btnFOMenu
        '
        Me.btnFOMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFOMenu.Location = New System.Drawing.Point(16, 466)
        Me.btnFOMenu.Name = "btnFOMenu"
        Me.btnFOMenu.Size = New System.Drawing.Size(88, 74)
        Me.btnFOMenu.TabIndex = 23
        Me.btnFOMenu.Text = "Menu"
        Me.btnFOMenu.UseVisualStyleBackColor = True
        '
        'lblFOStaffLoggedIn
        '
        Me.lblFOStaffLoggedIn.AutoSize = True
        Me.lblFOStaffLoggedIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFOStaffLoggedIn.Location = New System.Drawing.Point(471, 30)
        Me.lblFOStaffLoggedIn.Name = "lblFOStaffLoggedIn"
        Me.lblFOStaffLoggedIn.Size = New System.Drawing.Size(0, 24)
        Me.lblFOStaffLoggedIn.TabIndex = 42
        '
        'lblShoppingCart
        '
        Me.lblShoppingCart.AutoSize = True
        Me.lblShoppingCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShoppingCart.Location = New System.Drawing.Point(996, 96)
        Me.lblShoppingCart.Name = "lblShoppingCart"
        Me.lblShoppingCart.Size = New System.Drawing.Size(83, 39)
        Me.lblShoppingCart.TabIndex = 44
        Me.lblShoppingCart.Text = "Cart"
        '
        'PBFood1
        '
        Me.PBFood1.Image = Global.VBN_Assignment.My.Resources.Resources.Fried_Rice
        Me.PBFood1.Location = New System.Drawing.Point(814, 143)
        Me.PBFood1.Name = "PBFood1"
        Me.PBFood1.Size = New System.Drawing.Size(107, 70)
        Me.PBFood1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFood1.TabIndex = 45
        Me.PBFood1.TabStop = False
        '
        'PBFood2
        '
        Me.PBFood2.Image = Global.VBN_Assignment.My.Resources.Resources.Fried_Noodle
        Me.PBFood2.Location = New System.Drawing.Point(927, 143)
        Me.PBFood2.Name = "PBFood2"
        Me.PBFood2.Size = New System.Drawing.Size(107, 70)
        Me.PBFood2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFood2.TabIndex = 46
        Me.PBFood2.TabStop = False
        '
        'PBFood3
        '
        Me.PBFood3.Image = Global.VBN_Assignment.My.Resources.Resources.Steak
        Me.PBFood3.Location = New System.Drawing.Point(1040, 143)
        Me.PBFood3.Name = "PBFood3"
        Me.PBFood3.Size = New System.Drawing.Size(107, 70)
        Me.PBFood3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFood3.TabIndex = 47
        Me.PBFood3.TabStop = False
        '
        'PBFood4
        '
        Me.PBFood4.Image = Global.VBN_Assignment.My.Resources.Resources.Cake
        Me.PBFood4.Location = New System.Drawing.Point(1153, 143)
        Me.PBFood4.Name = "PBFood4"
        Me.PBFood4.Size = New System.Drawing.Size(107, 70)
        Me.PBFood4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFood4.TabIndex = 48
        Me.PBFood4.TabStop = False
        '
        'PBDrink1
        '
        Me.PBDrink1.Image = Global.VBN_Assignment.My.Resources.Resources.Soybean_Drink
        Me.PBDrink1.Location = New System.Drawing.Point(814, 254)
        Me.PBDrink1.Name = "PBDrink1"
        Me.PBDrink1.Size = New System.Drawing.Size(107, 70)
        Me.PBDrink1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBDrink1.TabIndex = 49
        Me.PBDrink1.TabStop = False
        '
        'PBDrink2
        '
        Me.PBDrink2.Image = Global.VBN_Assignment.My.Resources.Resources.Canned_Drink
        Me.PBDrink2.Location = New System.Drawing.Point(927, 254)
        Me.PBDrink2.Name = "PBDrink2"
        Me.PBDrink2.Size = New System.Drawing.Size(107, 70)
        Me.PBDrink2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBDrink2.TabIndex = 50
        Me.PBDrink2.TabStop = False
        '
        'PBDrink3
        '
        Me.PBDrink3.Image = Global.VBN_Assignment.My.Resources.Resources.Coffee
        Me.PBDrink3.Location = New System.Drawing.Point(1040, 254)
        Me.PBDrink3.Name = "PBDrink3"
        Me.PBDrink3.Size = New System.Drawing.Size(107, 70)
        Me.PBDrink3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBDrink3.TabIndex = 51
        Me.PBDrink3.TabStop = False
        '
        'PBDrink4
        '
        Me.PBDrink4.Image = Global.VBN_Assignment.My.Resources.Resources.tea
        Me.PBDrink4.Location = New System.Drawing.Point(1153, 254)
        Me.PBDrink4.Name = "PBDrink4"
        Me.PBDrink4.Size = New System.Drawing.Size(107, 70)
        Me.PBDrink4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBDrink4.TabIndex = 52
        Me.PBDrink4.TabStop = False
        '
        'PBSide1
        '
        Me.PBSide1.Image = Global.VBN_Assignment.My.Resources.Resources.Fries
        Me.PBSide1.Location = New System.Drawing.Point(814, 365)
        Me.PBSide1.Name = "PBSide1"
        Me.PBSide1.Size = New System.Drawing.Size(107, 70)
        Me.PBSide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBSide1.TabIndex = 53
        Me.PBSide1.TabStop = False
        '
        'PBSide2
        '
        Me.PBSide2.Image = Global.VBN_Assignment.My.Resources.Resources.Nugget
        Me.PBSide2.Location = New System.Drawing.Point(927, 365)
        Me.PBSide2.Name = "PBSide2"
        Me.PBSide2.Size = New System.Drawing.Size(107, 70)
        Me.PBSide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBSide2.TabIndex = 54
        Me.PBSide2.TabStop = False
        '
        'PBSide3
        '
        Me.PBSide3.Image = Global.VBN_Assignment.My.Resources.Resources.Salad
        Me.PBSide3.Location = New System.Drawing.Point(1040, 365)
        Me.PBSide3.Name = "PBSide3"
        Me.PBSide3.Size = New System.Drawing.Size(107, 70)
        Me.PBSide3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBSide3.TabIndex = 55
        Me.PBSide3.TabStop = False
        '
        'PBSide4
        '
        Me.PBSide4.Image = Global.VBN_Assignment.My.Resources.Resources.Hash_Brown
        Me.PBSide4.Location = New System.Drawing.Point(1153, 365)
        Me.PBSide4.Name = "PBSide4"
        Me.PBSide4.Size = New System.Drawing.Size(107, 70)
        Me.PBSide4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBSide4.TabIndex = 56
        Me.PBSide4.TabStop = False
        '
        'txtboxFood1
        '
        Me.txtboxFood1.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxFood1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxFood1.Location = New System.Drawing.Point(888, 219)
        Me.txtboxFood1.Name = "txtboxFood1"
        Me.txtboxFood1.ReadOnly = True
        Me.txtboxFood1.Size = New System.Drawing.Size(33, 29)
        Me.txtboxFood1.TabIndex = 57
        '
        'txtboxFood2
        '
        Me.txtboxFood2.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxFood2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxFood2.Location = New System.Drawing.Point(1001, 219)
        Me.txtboxFood2.Name = "txtboxFood2"
        Me.txtboxFood2.ReadOnly = True
        Me.txtboxFood2.Size = New System.Drawing.Size(33, 29)
        Me.txtboxFood2.TabIndex = 58
        '
        'txtboxFood3
        '
        Me.txtboxFood3.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxFood3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxFood3.Location = New System.Drawing.Point(1114, 219)
        Me.txtboxFood3.Name = "txtboxFood3"
        Me.txtboxFood3.ReadOnly = True
        Me.txtboxFood3.Size = New System.Drawing.Size(33, 29)
        Me.txtboxFood3.TabIndex = 59
        '
        'txtboxFood4
        '
        Me.txtboxFood4.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxFood4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxFood4.Location = New System.Drawing.Point(1227, 219)
        Me.txtboxFood4.Name = "txtboxFood4"
        Me.txtboxFood4.ReadOnly = True
        Me.txtboxFood4.Size = New System.Drawing.Size(33, 29)
        Me.txtboxFood4.TabIndex = 60
        '
        'txtboxDrink1
        '
        Me.txtboxDrink1.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxDrink1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxDrink1.Location = New System.Drawing.Point(888, 330)
        Me.txtboxDrink1.Name = "txtboxDrink1"
        Me.txtboxDrink1.ReadOnly = True
        Me.txtboxDrink1.Size = New System.Drawing.Size(33, 29)
        Me.txtboxDrink1.TabIndex = 61
        '
        'txtboxSide1
        '
        Me.txtboxSide1.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxSide1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxSide1.Location = New System.Drawing.Point(888, 441)
        Me.txtboxSide1.Name = "txtboxSide1"
        Me.txtboxSide1.ReadOnly = True
        Me.txtboxSide1.Size = New System.Drawing.Size(33, 29)
        Me.txtboxSide1.TabIndex = 62
        '
        'txtboxDrink2
        '
        Me.txtboxDrink2.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxDrink2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxDrink2.Location = New System.Drawing.Point(1001, 330)
        Me.txtboxDrink2.Name = "txtboxDrink2"
        Me.txtboxDrink2.ReadOnly = True
        Me.txtboxDrink2.Size = New System.Drawing.Size(33, 29)
        Me.txtboxDrink2.TabIndex = 63
        '
        'txtboxSide2
        '
        Me.txtboxSide2.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxSide2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxSide2.Location = New System.Drawing.Point(1003, 441)
        Me.txtboxSide2.Name = "txtboxSide2"
        Me.txtboxSide2.ReadOnly = True
        Me.txtboxSide2.Size = New System.Drawing.Size(33, 29)
        Me.txtboxSide2.TabIndex = 64
        '
        'txtboxDrink3
        '
        Me.txtboxDrink3.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxDrink3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxDrink3.Location = New System.Drawing.Point(1114, 330)
        Me.txtboxDrink3.Name = "txtboxDrink3"
        Me.txtboxDrink3.ReadOnly = True
        Me.txtboxDrink3.Size = New System.Drawing.Size(33, 29)
        Me.txtboxDrink3.TabIndex = 65
        '
        'txtboxDrink4
        '
        Me.txtboxDrink4.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxDrink4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxDrink4.Location = New System.Drawing.Point(1227, 330)
        Me.txtboxDrink4.Name = "txtboxDrink4"
        Me.txtboxDrink4.ReadOnly = True
        Me.txtboxDrink4.Size = New System.Drawing.Size(33, 29)
        Me.txtboxDrink4.TabIndex = 66
        '
        'txtboxSide4
        '
        Me.txtboxSide4.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxSide4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxSide4.Location = New System.Drawing.Point(1227, 441)
        Me.txtboxSide4.Name = "txtboxSide4"
        Me.txtboxSide4.ReadOnly = True
        Me.txtboxSide4.Size = New System.Drawing.Size(33, 29)
        Me.txtboxSide4.TabIndex = 67
        '
        'txtboxSide3
        '
        Me.txtboxSide3.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxSide3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxSide3.Location = New System.Drawing.Point(1114, 441)
        Me.txtboxSide3.Name = "txtboxSide3"
        Me.txtboxSide3.ReadOnly = True
        Me.txtboxSide3.Size = New System.Drawing.Size(33, 29)
        Me.txtboxSide3.TabIndex = 68
        '
        'btnFOUpdateCart
        '
        Me.btnFOUpdateCart.Location = New System.Drawing.Point(814, 500)
        Me.btnFOUpdateCart.Name = "btnFOUpdateCart"
        Me.btnFOUpdateCart.Size = New System.Drawing.Size(172, 42)
        Me.btnFOUpdateCart.TabIndex = 69
        Me.btnFOUpdateCart.Text = "Update Cart"
        Me.btnFOUpdateCart.UseVisualStyleBackColor = True
        '
        'lblFoodPrice1
        '
        Me.lblFoodPrice1.AutoSize = True
        Me.lblFoodPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodPrice1.Location = New System.Drawing.Point(810, 224)
        Me.lblFoodPrice1.Name = "lblFoodPrice1"
        Me.lblFoodPrice1.Size = New System.Drawing.Size(64, 24)
        Me.lblFoodPrice1.TabIndex = 70
        Me.lblFoodPrice1.Text = "RM3 x"
        '
        'lblDrinkPrice1
        '
        Me.lblDrinkPrice1.AutoSize = True
        Me.lblDrinkPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkPrice1.Location = New System.Drawing.Point(810, 333)
        Me.lblDrinkPrice1.Name = "lblDrinkPrice1"
        Me.lblDrinkPrice1.Size = New System.Drawing.Size(64, 24)
        Me.lblDrinkPrice1.TabIndex = 71
        Me.lblDrinkPrice1.Text = "RM3 x"
        '
        'lblSidePrice1
        '
        Me.lblSidePrice1.AutoSize = True
        Me.lblSidePrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidePrice1.Location = New System.Drawing.Point(810, 446)
        Me.lblSidePrice1.Name = "lblSidePrice1"
        Me.lblSidePrice1.Size = New System.Drawing.Size(64, 24)
        Me.lblSidePrice1.TabIndex = 72
        Me.lblSidePrice1.Text = "RM5 x"
        '
        'lblFoodPrice2
        '
        Me.lblFoodPrice2.AutoSize = True
        Me.lblFoodPrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodPrice2.Location = New System.Drawing.Point(923, 224)
        Me.lblFoodPrice2.Name = "lblFoodPrice2"
        Me.lblFoodPrice2.Size = New System.Drawing.Size(64, 24)
        Me.lblFoodPrice2.TabIndex = 73
        Me.lblFoodPrice2.Text = "RM3 x"
        '
        'lblDrinkPrice2
        '
        Me.lblDrinkPrice2.AutoSize = True
        Me.lblDrinkPrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkPrice2.Location = New System.Drawing.Point(927, 335)
        Me.lblDrinkPrice2.Name = "lblDrinkPrice2"
        Me.lblDrinkPrice2.Size = New System.Drawing.Size(64, 24)
        Me.lblDrinkPrice2.TabIndex = 74
        Me.lblDrinkPrice2.Text = "RM3 x"
        '
        'lblSidePrice2
        '
        Me.lblSidePrice2.AutoSize = True
        Me.lblSidePrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidePrice2.Location = New System.Drawing.Point(927, 446)
        Me.lblSidePrice2.Name = "lblSidePrice2"
        Me.lblSidePrice2.Size = New System.Drawing.Size(64, 24)
        Me.lblSidePrice2.TabIndex = 75
        Me.lblSidePrice2.Text = "RM3 x"
        '
        'lblFoodPrice3
        '
        Me.lblFoodPrice3.AutoSize = True
        Me.lblFoodPrice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodPrice3.Location = New System.Drawing.Point(1040, 224)
        Me.lblFoodPrice3.Name = "lblFoodPrice3"
        Me.lblFoodPrice3.Size = New System.Drawing.Size(64, 24)
        Me.lblFoodPrice3.TabIndex = 76
        Me.lblFoodPrice3.Text = "RM7 x"
        '
        'lblDrinkPrice3
        '
        Me.lblDrinkPrice3.AutoSize = True
        Me.lblDrinkPrice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkPrice3.Location = New System.Drawing.Point(1042, 338)
        Me.lblDrinkPrice3.Name = "lblDrinkPrice3"
        Me.lblDrinkPrice3.Size = New System.Drawing.Size(67, 20)
        Me.lblDrinkPrice3.TabIndex = 77
        Me.lblDrinkPrice3.Text = "RM2.5 x"
        '
        'lblSidePrice3
        '
        Me.lblSidePrice3.AutoSize = True
        Me.lblSidePrice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidePrice3.Location = New System.Drawing.Point(1042, 448)
        Me.lblSidePrice3.Name = "lblSidePrice3"
        Me.lblSidePrice3.Size = New System.Drawing.Size(64, 24)
        Me.lblSidePrice3.TabIndex = 78
        Me.lblSidePrice3.Text = "RM5 x"
        '
        'lblFoodPrice4
        '
        Me.lblFoodPrice4.AutoSize = True
        Me.lblFoodPrice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodPrice4.Location = New System.Drawing.Point(1153, 224)
        Me.lblFoodPrice4.Name = "lblFoodPrice4"
        Me.lblFoodPrice4.Size = New System.Drawing.Size(64, 24)
        Me.lblFoodPrice4.TabIndex = 79
        Me.lblFoodPrice4.Text = "RM4 x"
        '
        'lblDrinkPrice4
        '
        Me.lblDrinkPrice4.AutoSize = True
        Me.lblDrinkPrice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkPrice4.Location = New System.Drawing.Point(1154, 337)
        Me.lblDrinkPrice4.Name = "lblDrinkPrice4"
        Me.lblDrinkPrice4.Size = New System.Drawing.Size(67, 20)
        Me.lblDrinkPrice4.TabIndex = 80
        Me.lblDrinkPrice4.Text = "RM2.5 x"
        '
        'lblSidePrice4
        '
        Me.lblSidePrice4.AutoSize = True
        Me.lblSidePrice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSidePrice4.Location = New System.Drawing.Point(1153, 446)
        Me.lblSidePrice4.Name = "lblSidePrice4"
        Me.lblSidePrice4.Size = New System.Drawing.Size(64, 24)
        Me.lblSidePrice4.TabIndex = 81
        Me.lblSidePrice4.Text = "RM2 x"
        '
        'btnFOClearCart
        '
        Me.btnFOClearCart.Location = New System.Drawing.Point(1088, 500)
        Me.btnFOClearCart.Name = "btnFOClearCart"
        Me.btnFOClearCart.Size = New System.Drawing.Size(172, 42)
        Me.btnFOClearCart.TabIndex = 82
        Me.btnFOClearCart.Text = "Clear Cart"
        Me.btnFOClearCart.UseVisualStyleBackColor = True
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1292, 565)
        Me.Controls.Add(Me.btnFOClearCart)
        Me.Controls.Add(Me.lblSidePrice4)
        Me.Controls.Add(Me.lblDrinkPrice4)
        Me.Controls.Add(Me.lblFoodPrice4)
        Me.Controls.Add(Me.lblSidePrice3)
        Me.Controls.Add(Me.lblDrinkPrice3)
        Me.Controls.Add(Me.lblFoodPrice3)
        Me.Controls.Add(Me.lblSidePrice2)
        Me.Controls.Add(Me.lblDrinkPrice2)
        Me.Controls.Add(Me.lblFoodPrice2)
        Me.Controls.Add(Me.lblSidePrice1)
        Me.Controls.Add(Me.lblDrinkPrice1)
        Me.Controls.Add(Me.lblFoodPrice1)
        Me.Controls.Add(Me.btnFOUpdateCart)
        Me.Controls.Add(Me.txtboxSide3)
        Me.Controls.Add(Me.txtboxSide4)
        Me.Controls.Add(Me.txtboxDrink4)
        Me.Controls.Add(Me.txtboxDrink3)
        Me.Controls.Add(Me.txtboxSide2)
        Me.Controls.Add(Me.txtboxDrink2)
        Me.Controls.Add(Me.txtboxSide1)
        Me.Controls.Add(Me.txtboxDrink1)
        Me.Controls.Add(Me.txtboxFood4)
        Me.Controls.Add(Me.txtboxFood3)
        Me.Controls.Add(Me.txtboxFood2)
        Me.Controls.Add(Me.txtboxFood1)
        Me.Controls.Add(Me.PBSide4)
        Me.Controls.Add(Me.PBSide3)
        Me.Controls.Add(Me.PBSide2)
        Me.Controls.Add(Me.PBSide1)
        Me.Controls.Add(Me.PBDrink4)
        Me.Controls.Add(Me.PBDrink3)
        Me.Controls.Add(Me.PBDrink2)
        Me.Controls.Add(Me.PBDrink1)
        Me.Controls.Add(Me.PBFood4)
        Me.Controls.Add(Me.PBFood3)
        Me.Controls.Add(Me.PBFood2)
        Me.Controls.Add(Me.PBFood1)
        Me.Controls.Add(Me.lblShoppingCart)
        Me.Controls.Add(Me.lblFOStaffLoggedIn)
        Me.Controls.Add(Me.btnFOMenu)
        Me.Controls.Add(Me.lstboxFoodList)
        Me.Controls.Add(Me.lblFOTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.txtboxTotal)
        Me.Controls.Add(Me.txtboxTax)
        Me.Controls.Add(Me.txtboxSubtotal)
        Me.Controls.Add(Me.lblOrderedFood)
        Me.Controls.Add(Me.lblFoodList)
        Me.Controls.Add(Me.btnPaymentConfirm)
        Me.Controls.Add(Me.btnFoodRemove)
        Me.Controls.Add(Me.btnFoodAdd)
        Me.Controls.Add(Me.lstboxOrderedFood)
        Me.Controls.Add(Me.cboFOCusName)
        Me.Controls.Add(Me.lblFOCustomerID)
        Me.Controls.Add(Me.lblFOTitle)
        Me.Name = "Order"
        Me.Text = "Payment"
        CType(Me.PBFood1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFood2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFood3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFood4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDrink1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDrink2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDrink3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDrink4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSide1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSide2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSide3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSide4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFOTitle As Label
    Friend WithEvents lblFOCustomerID As Label
    Friend WithEvents cboFOCusName As ComboBox
    Friend WithEvents lstboxOrderedFood As ListBox
    Friend WithEvents btnFoodAdd As Button
    Friend WithEvents btnFoodRemove As Button
    Friend WithEvents btnPaymentConfirm As Button
    Friend WithEvents lblFoodList As Label
    Friend WithEvents lblOrderedFood As Label
    Friend WithEvents txtboxSubtotal As TextBox
    Friend WithEvents txtboxTax As TextBox
    Friend WithEvents txtboxTotal As TextBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblFOTotal As Label
    Friend WithEvents lstboxFoodList As ListBox
    Friend WithEvents btnFOMenu As Button
    Friend WithEvents lblFOStaffLoggedIn As Label
    Friend WithEvents lblShoppingCart As Label
    Friend WithEvents PBFood1 As PictureBox
    Friend WithEvents PBFood2 As PictureBox
    Friend WithEvents PBFood3 As PictureBox
    Friend WithEvents PBFood4 As PictureBox
    Friend WithEvents PBDrink1 As PictureBox
    Friend WithEvents PBDrink2 As PictureBox
    Friend WithEvents PBDrink3 As PictureBox
    Friend WithEvents PBDrink4 As PictureBox
    Friend WithEvents PBSide1 As PictureBox
    Friend WithEvents PBSide2 As PictureBox
    Friend WithEvents PBSide3 As PictureBox
    Friend WithEvents txtboxFood1 As TextBox
    Friend WithEvents txtboxFood2 As TextBox
    Friend WithEvents txtboxFood3 As TextBox
    Friend WithEvents txtboxFood4 As TextBox
    Friend WithEvents txtboxDrink1 As TextBox
    Friend WithEvents txtboxSide1 As TextBox
    Friend WithEvents txtboxDrink2 As TextBox
    Friend WithEvents txtboxSide2 As TextBox
    Friend WithEvents txtboxDrink3 As TextBox
    Friend WithEvents txtboxDrink4 As TextBox
    Friend WithEvents txtboxSide4 As TextBox
    Friend WithEvents txtboxSide3 As TextBox
    Friend WithEvents btnFOUpdateCart As Button
    Friend WithEvents lblFoodPrice1 As Label
    Friend WithEvents lblDrinkPrice1 As Label
    Friend WithEvents lblSidePrice1 As Label
    Friend WithEvents lblFoodPrice2 As Label
    Friend WithEvents lblDrinkPrice2 As Label
    Friend WithEvents lblSidePrice2 As Label
    Friend WithEvents lblFoodPrice3 As Label
    Friend WithEvents lblDrinkPrice3 As Label
    Friend WithEvents lblSidePrice3 As Label
    Friend WithEvents lblFoodPrice4 As Label
    Friend WithEvents lblDrinkPrice4 As Label
    Friend WithEvents lblSidePrice4 As Label
    Friend WithEvents btnFOClearCart As Button
    Friend WithEvents PBSide4 As PictureBox
End Class
