Imports System.Data.OleDb
Imports System.Data
Public Class Payment
    Dim PaymentPaid As Decimal = 0
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|StaffLogin.accdb")
    Dim cmd As OleDbCommand
    Dim sql As String
    Dim sql2 As String
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPaymentCusName.Text = "Customer Name: " & Order.cboFOCusName.Text
        lblPaymentTotal.Text = "Total: " & Order.txtboxTotal.Text
        txtboxPaymentPaid.Text = PaymentPaid

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCoin1.Click
        lstboxMoney.Items.Add("RM0.50")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCoin2.Click
        lstboxMoney.Items.Add("RM0.20")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCoin3.Click
        lstboxMoney.Items.Add("RM0.50")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCash1.Click
        lstboxMoney.Items.Add("RM1")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnCash2.Click
        lstboxMoney.Items.Add("RM5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCash3.Click
        lstboxMoney.Items.Add("RM10")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnCash4.Click
        lstboxMoney.Items.Add("RM20")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnCash5.Click
        lstboxMoney.Items.Add("RM50")
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnPaymentCal.Click
        If lstboxMoney.Items.Count < 1 Then
            MsgBox("Please enter total money received before proceeding to calculate the value!", MsgBoxStyle.Critical)
        Else
            For Each item As String In lstboxMoney.Items()
                If item = "RM0.10" Then
                    PaymentPaid += 0.1
                ElseIf item = "RM0.20" Then
                    PaymentPaid += 0.2
                ElseIf item = "RM0.50" Then
                    PaymentPaid += 0.5
                ElseIf item = "RM1" Then
                    PaymentPaid += 1
                ElseIf item = "RM5" Then
                    PaymentPaid += 5
                ElseIf item = "RM10" Then
                    PaymentPaid += 10
                ElseIf item = "RM20" Then
                    PaymentPaid += 20
                ElseIf item = "RM50" Then
                    PaymentPaid += 50
                End If
            Next
            txtboxPaymentPaid.Text = PaymentPaid
            txtboxPaymentExcess.Text = PaymentPaid - Order.txtboxTotal.Text
        End If
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnPaymentClear.Click
        lstboxMoney.Items.Clear()
        txtboxPaymentPaid.Text = ""
        txtboxPaymentExcess.Text = ""
        PaymentPaid = 0
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnOrderCancel.Click

        Order.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistryRegister_Click(sender As Object, e As EventArgs) Handles btnPaymentMenu.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub btnRecordPayment_Click(sender As Object, e As EventArgs) Handles btnRecordPayment.Click
        If txtboxPaymentExcess.Text = "" Or txtboxPaymentPaid.Text = "" Then
            MsgBox("Please Calculate the payment first!", MsgBoxStyle.Exclamation)
        Else
            con.Open()
            sql = "Insert into CustomerPayment ([CustomerName],[Total Paid], [Excess Paid]) values ('" & Order.cboFOCusName.Text & "','" & txtboxPaymentPaid.Text & "', '" & txtboxPaymentExcess.Text & "')"
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            con.Open()
            sql2 = "Insert into CustomerOrder ([CustomerName],[Fried Rice],[Fried Noodle],[Steak],[Cake],[Soybean Drink],[Canned Drink],[Coffee],[Tea],[Fries],[Nugget],[Salad],[Hash Brown]) values ('" & Order.cboFOCusName.Text & "', '" & Order.txtboxFood1.Text & "' ,'" & Order.txtboxFood2.Text & "', '" & Order.txtboxFood3.Text & "', '" & Order.txtboxFood4.Text & "', '" & Order.txtboxDrink1.Text & "', '" & Order.txtboxDrink2.Text & "','" & Order.txtboxDrink3.Text & "','" & Order.txtboxDrink4.Text & "', '" & Order.txtboxSide1.Text & "','" & Order.txtboxSide2.Text & "','" & Order.txtboxSide3.Text & "', '" & Order.txtboxSide4.Text & "')"
            cmd = New OleDbCommand(sql2, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("You have successfully recorded the transaction!", MsgBoxStyle.Information)
            Me.Hide()

            For Each FormControl As Control In Order.Controls
                If TypeOf FormControl Is TextBox Then
                    FormControl.Text = String.Empty
                End If
            Next
            Order.Show()


        End If
    End Sub


End Class