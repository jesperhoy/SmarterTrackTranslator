Imports System.Windows.Forms

Public Class frmEdit

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub chkWrap_CheckedChanged(sender As Object, e As EventArgs) Handles chkWrap.CheckedChanged
    txtEnglish.WordWrap = chkWrap.Checked
    txtEnglish.ScrollBars = If(chkWrap.Checked, ScrollBars.Vertical, ScrollBars.Horizontal)
    txtTranslated.WordWrap = chkWrap.Checked
    txtTranslated.ScrollBars = If(chkWrap.Checked, ScrollBars.Vertical, ScrollBars.Horizontal)
  End Sub

  Private Sub txtTranslated_TextChanged(sender As Object, e As EventArgs) Handles txtTranslated.TextChanged

  End Sub

  Private Sub txtTranslated_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTranslated.KeyPress
    If e.KeyChar <> vbCr Then Exit Sub
    If txtEnglish.Text.Contains(vbLf) Then Exit Sub
    e.Handled = True
  End Sub

  Private Sub frmEdit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    txtTranslated.Focus()
  End Sub
End Class
