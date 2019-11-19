Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strDOB, strStateCode, strGender As String
        Dim intLength As Integer
        strDOB = Mid(TextBox1.Text, 5, 2) & Mid(TextBox1.Text, 3, 2) & Microsoft.VisualBasic.Left(TextBox1.Text, 2)
        strStateCode = Mid(TextBox1.Text, 7, 2)
        strGender = Microsoft.VisualBasic.Right(TextBox1.Text, 1)
        intLength = Len(TextBox1.Text)
        With ListBox1.Items
            .Add("Date Of Birth : " & strDOB)
            .Add("State Code : " & strStateCode)
            .Add("Gender : " & strGender)
            .Add("Length Of Character : " & intLength)
        End With
    End Sub
End Class
