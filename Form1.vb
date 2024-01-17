Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Declaring Variables
        Dim n As Integer

        While n <> 5
            n += 1

            MsgBox(n)

        End While
        MsgBox("now out of the loop")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaring Variables
        Dim firstNumber, SecondNumber As Integer
        firstNumber = Val(TextBox1.Text)
        SecondNumber = Val(TextBox2.Text)


        Sum(firstNumber, SecondNumber)

    End Sub
    'The Sum Calcuation

    Sub Sum(a As Integer, b As Integer)
        'Declaring Variables
        Dim total As Integer
        total = a + b
        TextBox3.Text = total

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
