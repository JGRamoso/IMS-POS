Public Class frm_mainAdmin

    Private Sub frm_mainAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_manageProduct_Click(sender As Object, e As EventArgs) Handles btn_manageProduct.Click
        frm_manageProducts.ShowDialog()

    End Sub

    Private Sub btn_manageStock_Click(sender As Object, e As EventArgs) Handles btn_manageStock.Click
        frm_manageStocks.ShowDialog()

    End Sub

    Private Sub btn_manageUsers_Click(sender As Object, e As EventArgs) Handles btn_manageUsers.Click
        frm_manageUser.ShowDialog()

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Me.Close()
        frm_login.Show()

    End Sub
End Class