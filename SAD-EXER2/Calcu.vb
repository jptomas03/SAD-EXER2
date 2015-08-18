Public Class Calcu
    Dim N As New Collection
    Private Sub cmdAccept_Click(sender As Object, e As EventArgs) Handles cmdAccept.Click
        N.Add(txtInput.Text)
        lblNumber.Text = N.Count
        txtInput.Text = ""
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        N.Clear()
        lblNumber.Text = N.Count
        lblMean.Text = ""
        lblStdDev.Text = ""
        txtInput.Text = ""
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdComput_Click(sender As Object, e As EventArgs) Handles cmdComput.Click
        mean()
        standardDeviation()
    End Sub

    Private Sub mean()
        Dim i, sum As Integer
        For i = 1 To N.Count
            sum = sum + +N.Item(i)
        Next
        lblMean.Text = sum / N.Count
    End Sub

    Private Sub standardDeviation()
        Dim i, sum1, sum2 As Integer
        For i = 1 To N.Count
            sum1 = sum1 + +(N.Item(i) ^ 2)
            sum2 = sum2 + +N.Item(i)
        Next
        sum1 = sum1 * N.Count
        sum2 = sum2 ^ 2
        lblStdDev.Text = Math.Sqrt((sum1 - sum2) / (N.Count * (N.Count - 1)))
    End Sub
End Class
