Imports System.Data.OleDb
Imports System.Data

Public Class UpdateInfo

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|StaffLogin.accdb")
    Dim cmd As OleDbCommand
    Dim sql As String


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtboxUPStaff.Text = Home.txtboxStaffID.Text
        con.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("select * from CustomerInfo", con)
        da.Fill(dt)
        DataGridViewUpdate.DataSource = dt.DefaultView


        con.Close()
    End Sub

    Private Sub btnRegistryRegister_Click(sender As Object, e As EventArgs) Handles btnUPUpdate.Click
        If txtUPCusName.Text = "" Or txtUPCusID.Text = "" Or mtbUPContactNo.Text = "" Or txtUPCusAddress.Text = "" Or cboUPGender.Text = "" Then
            MsgBox("Please enter all the required information into the space provided before updating the customer info", MsgBoxStyle.Critical)
        Else
            con.Open()
            sql = ("update CustomerInfo set [CustomerName]='" & txtUPCusName.Text & "', [Gender]='" & cboUPGender.Text & "', [Contact Number]='" & mtbUPContactNo.Text & "', [Address]='" & txtUPCusAddress.Text & "' where [CustomerID]=" & txtUPCusID.Text & "")
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            Dim ds As New DataSet
            Dim dt As New DataTable
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter("select * from CustomerInfo", con)
            da.Fill(dt)
            DataGridViewUpdate.DataSource = dt.DefaultView
            con.Close()
        End If
    End Sub

    Private Sub btnRegistryHome_Click(sender As Object, e As EventArgs)
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistryClear_Click(sender As Object, e As EventArgs)
        txtUPCusID.Text = ""
        txtUPCusAddress.Text = ""
        txtUPCusName.Text = ""
        mtbUPContactNo.Text = ""
        cboUPGender.Text = ""
    End Sub
End Class