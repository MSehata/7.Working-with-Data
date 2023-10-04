Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaySomething_Click(sender As Object, e As EventArgs) Handles btnSaySomething.Click
        Dim yourMessage As String, age As Int16
        yourMessage = "Happy Birthday! How aold are you now? "
        MsgBox(yourMessage)

        age = Val(InputBox("Enter your Age: "))
        MsgBox("You are now " & age & " years old")

    End Sub

    Private Sub btnCalculateAge_Click(sender As Object, e As EventArgs) Handles btnCalculateAge.Click
        Dim yearOfBirth As Int32
        yearOfBirth = Val(InputBox("Which year where you born? "))
        MsgBox("You are now " & 2023 - yearOfBirth & " years old")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
