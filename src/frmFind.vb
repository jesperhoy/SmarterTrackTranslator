Public Class frmFind
  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    Me.Hide()
  End Sub

  Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
    Form1.DoFind(False)
  End Sub
End Class