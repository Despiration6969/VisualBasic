Imports System.Data.OleDb
Imports System.Data

Public Class Home
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|StaffLogin.accdb")
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim sql As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        con.Open()
        sql = "Select * from StaffLogin where [StaffUsername]='" & txtboxStaffID.Text & "' AND StaffPassword='" & txtboxStaffPass.Text & "'"
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        If (dr.HasRows = True) Then
            MsgBox("You have successfully login", MsgBoxStyle.Information)
            MainMenu.Show()
            Me.Hide()
            MainMenu.txtBoxStaffLoggedIn.Text = (Me.txtboxStaffID.Text)
            Payment.txtboxPaymentStaff.Text = (Me.txtboxStaffID.Text)
            Registry.txtboxRegistryStaff.Text = (Me.txtboxStaffID.Text)


        Else
            MsgBox("You have entered incorrect combination of username or password, please retry again", MsgBoxStyle.Critical)
            txtboxStaffID.Clear()
            txtboxStaffPass.Clear()

        End If

        con.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btmHomeClear.Click
        txtboxStaffID.Clear()
        txtboxStaffPass.Clear()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
