Public Class Form1

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        Dim intDivisor As Integer
        Dim intNumber As Integer
        Dim intCount As Integer = -1
        Const FLAG As Integer = 0

        Do
            intDivisor = InputBox("Enter A Positive Number Or 0 To Quit")

            If intDivisor < 0 Then
                MessageBox.Show("ERROR! Enter A Positive Number")
            End If
        Loop Until intDivisor > 0

        Do
            intNumber = InputBox("Enter A Positive Number Or 0 To Quit")

            If intNumber Mod intDivisor = 0 Then
                intCount = intCount + 1
            End If

        Loop Until intNumber = FLAG

        MessageBox.Show("You entered " & intCount & " number(s) that are divisible by " & intDivisor)

    End Sub
End Class
