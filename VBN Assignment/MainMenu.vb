Public Class MainMenu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistryForm.Click
        Me.Hide()
        Registry.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOrderForm.Click
        Me.Hide()
        Order.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Home.Show()
    End Sub


End Class