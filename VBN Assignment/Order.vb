Imports System.Data.OleDb
Imports System.Data

Public Class Order
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|StaffLogin.accdb")
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim sql As String
    Dim subtotal As Integer
    Dim FriedRice As Integer
    Dim FriedNoodle As Integer
    Dim Steak As Integer
    Dim Cake As Integer
    Dim SoybeanDrink As Integer
    Dim CannedDrink As Integer
    Dim Coffee As Integer
    Dim Tea As Integer
    Dim Fries As Integer
    Dim Nugget As Integer
    Dim Salad As Integer
    Dim HashBrown As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFOCusName.SelectedIndexChanged
    End Sub

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        sql = "SELECT * FROM CustomerInfo"
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read
            cboFOCusName.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()

        lblFOStaffLoggedIn.Text = "Staff Logged In :" & MainMenu.txtBoxStaffLoggedIn.Text & ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFoodAdd.Click
        lstboxOrderedFood.ClearSelected()

        If lstboxFoodList.SelectedIndex >= 0 Then
            lstboxOrderedFood.Items.Add(lstboxFoodList.SelectedItem)
        Else
            MsgBox("Please select an item", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFoodRemove.Click
        lstboxFoodList.ClearSelected()
        If lstboxOrderedFood.SelectedIndex >= 0 Then
            lstboxOrderedFood.Items.Remove(lstboxOrderedFood.SelectedItem)
        Else
            MsgBox("Please select an item to be remove", MsgBoxStyle.Exclamation)

        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        lstboxOrderedFood.Items.Clear()
        subtotal = 0
        txtboxSubtotal.Text = 0
        txtboxTax.Text = 0
        txtboxTotal.Text = 0
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnPaymentConfirm.Click
        Dim Result As MsgBoxResult

        If txtboxSubtotal.Text = "" Or txtboxTotal.Text = "" Or txtboxTax.Text = "" Then
            MsgBox("Please Update the food cart and calculate the price first")
        Else
            Result = MsgBox("Confirm order and proceed to payment page?", MessageBoxButtons.YesNo)
            If Result = MsgBoxResult.Yes Then

                MsgBox("you have successfully confirm the order")
                Payment.Show()
                Me.Hide()
            Else

            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim tax As Double = (0.06)
        Dim total As Double = (1.06)

        If cboFOCusName.SelectedIndex < 0 Then
            MsgBox("Please select a customer!", MsgBoxStyle.Exclamation)
        Else
            For Each item As String In lstboxOrderedFood.Items()

                If item = "Fried Rice" Then
                    subtotal += 3
                ElseIf item = "Fried Noodle" Then
                    subtotal += 3
                ElseIf item = "Steak" Then
                    subtotal += 7
                ElseIf item = "Cake" Then
                    subtotal += 4
                ElseIf item = "Soybean Drink" Then
                    subtotal += 3
                ElseIf item = "Canned Drink" Then
                    subtotal += 3
                ElseIf item = "Coffee" Then
                    subtotal += 2.5
                ElseIf item = "Tea" Then
                    subtotal += 2.5
                ElseIf item = "Fries" Then
                    subtotal += 5
                ElseIf item = "Nugget" Then
                    subtotal += 3
                ElseIf item = "Salad" Then
                    subtotal += 5
                ElseIf item = "Hash Brown" Then
                    subtotal += 2
                End If

            Next
        End If


        txtboxSubtotal.Text = "RM" & subtotal

        txtboxTax.Text = "RM" & subtotal * tax

        txtboxTotal.Text = "RM" & subtotal * total
    End Sub

    Private Sub btnRegistryRegister_Click(sender As Object, e As EventArgs) Handles btnFOMenu.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub btnFOUpdateCart_Click(sender As Object, e As EventArgs) Handles btnFOUpdateCart.Click

        Dim tax As Double = (0.06)
        Dim total As Double = (1.06)

        For Each item As String In lstboxOrderedFood.Items()
            If item = "Fried Rice" Then
                FriedRice += 1
            ElseIf item = "Fried Noodle" Then
                FriedNoodle += 1
            ElseIf item = "Steak" Then
                Steak += 1
            ElseIf item = "Cake" Then
                Cake += 1
            ElseIf item = "Soybean Drink" Then
                SoybeanDrink += 1
            ElseIf item = "Canned Drink" Then
                CannedDrink += 1
            ElseIf item = "Coffee" Then
                Coffee += 1
            ElseIf item = "Tea" Then
                Tea += 1
            ElseIf item = "Fries" Then
                Fries += 1
            ElseIf item = "Nugget" Then
                Nugget += 1
            ElseIf item = "Salad" Then
                Salad += 1
            ElseIf item = "Hash Brown" Then
                HashBrown += 1
            End If
        Next

        If cboFOCusName.SelectedIndex < 0 Or lstboxOrderedFood.Items.Count < 1 Then
            MsgBox("Please select a customer or put in any order before proceed to update the cart!", MsgBoxStyle.Exclamation)
        Else
            For Each item As String In lstboxOrderedFood.Items()

                If item = "Fried Rice" Then
                    subtotal += 3
                ElseIf item = "Fried Noodle" Then
                    subtotal += 3
                ElseIf item = "Steak" Then
                    subtotal += 7
                ElseIf item = "Cake" Then
                    subtotal += 4
                ElseIf item = "Soybean Drink" Then
                    subtotal += 3
                ElseIf item = "Canned Drink" Then
                    subtotal += 3
                ElseIf item = "Coffee" Then
                    subtotal += 2.5
                ElseIf item = "Tea" Then
                    subtotal += 2.5
                ElseIf item = "Fries" Then
                    subtotal += 5
                ElseIf item = "Nugget" Then
                    subtotal += 3
                ElseIf item = "Salad" Then
                    subtotal += 5
                ElseIf item = "Hash Brown" Then
                    subtotal += 2
                End If

            Next
            txtboxSubtotal.Text = "RM" & subtotal

            txtboxTax.Text = "RM" & subtotal * tax

            txtboxTotal.Text = "RM" & subtotal * total

            txtboxFood1.Text = FriedRice
            txtboxFood2.Text = FriedNoodle
            txtboxFood3.Text = Steak
            txtboxFood4.Text = Cake
            txtboxDrink1.Text = SoybeanDrink
            txtboxDrink2.Text = CannedDrink
            txtboxDrink3.Text = Coffee
            txtboxDrink4.Text = Tea
            txtboxSide1.Text = Fries
            txtboxSide2.Text = Nugget
            txtboxSide3.Text = Salad
            txtboxSide4.Text = HashBrown
        End If

        lstboxOrderedFood.Items.Clear()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnFOClearCart.Click
        lstboxOrderedFood.ClearSelected()
        FriedRice = 0
        FriedNoodle = 0
        Steak = 0
        Cake = 0
        SoybeanDrink = 0
        CannedDrink = 0
        Coffee = 0
        Tea = 0
        Fries = 0
        Nugget = 0
        Salad = 0
        HashBrown = 0

        txtboxFood1.Text = FriedRice
        txtboxFood2.Text = FriedNoodle
        txtboxFood3.Text = Steak
        txtboxFood4.Text = Cake
        txtboxDrink1.Text = SoybeanDrink
        txtboxDrink2.Text = CannedDrink
        txtboxDrink3.Text = Coffee
        txtboxDrink4.Text = Tea
        txtboxSide1.Text = Fries
        txtboxSide2.Text = Nugget
        txtboxSide3.Text = Salad
        txtboxSide4.Text = HashBrown

        subtotal = 0
        txtboxSubtotal.Text = ""
        txtboxTotal.Text = ""
        txtboxTax.Text = ""


    End Sub


End Class
