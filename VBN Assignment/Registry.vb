Imports System.Data.OleDb
Imports System.Data
Public Class Registry
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|StaffLogin.accdb")
    Dim cmd As OleDbCommand
    Dim sql As String

    Private Sub btnRegistryClear_Click(sender As Object, e As EventArgs)
        txtCusName.Clear()
        cboGender.ResetText()
        mtbContactNo.Clear()
        txtCusAddress.Clear()
    End Sub
    Private Sub btnRegistryRegister_Click(sender As Object, e As EventArgs) Handles btnRegistryRegister.Click

        If txtCusName.Text = "" Or txtCusAddress.Text = "" Or cboGender.SelectedIndex < 0 Or mtbContactNo.Text = "" Then
            MsgBox("Please fill in all the detail required!", MsgBoxStyle.Exclamation)
        Else

            con.Open()
        sql = "insert into CustomerInfo ([CustomerName],[Gender],[Contact Number],[Address]) values ('" & txtCusName.Text & "','" & cboGender.Text & "','" & mtbContactNo.Text & "','" & txtCusAddress.Text & "')"

        cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()

        MsgBox("You have successfully register a new customer", vbExclamation)

        txtCusName.Clear()
        cboGender.ResetText()
        mtbContactNo.Clear()
            txtCusAddress.Clear()

        End If


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        UpdateInfo.Show()
    End Sub

    Private Sub Registry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class