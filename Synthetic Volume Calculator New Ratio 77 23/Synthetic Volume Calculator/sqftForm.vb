Public Class sqftForm

    Private Sub sqftSubmitbtn_Click(sender As Object, e As EventArgs) Handles sqftSubmitbtn.Click
        Dim root = Math.Sqrt(CDbl(txtsqft.Text))
        MainForm.txtF.Text = CStr(root * 12)
        MainForm.txtG.Text = CStr(root * 12)
        MainForm.txtE.Text = txtthick.Text
        MainForm.rbtnGInches.Checked = True
        MainForm.rbtnFInches.Checked = True
        Me.Close()
    End Sub
End Class