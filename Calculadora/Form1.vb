Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Este programa suma 2 valores'
        Dim valor1, valor2, suma As Single
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        suma = valor1 + valor2
        TextBox3.Text = suma
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Este programa resta 2 valores'
        Dim valor1, valor2, resta As Single
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        resta = valor1 - valor2
        TextBox3.Text = resta
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Este programa multiplica 2 valores'
        Dim valor1, valor2, multiplicacion As Single
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        multiplicacion = valor1 * valor2
        TextBox3.Text = multiplicacion
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Este programa divide 2 valores'
        Dim valor1, valor2, division As Single
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        division = valor1 / valor2
        TextBox3.Text = division
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Este programa saca la raiz de 1 valor'
        Dim valor1, valor2, raiz As Single
        valor1 = TextBox1.Text
        raiz = valor1 ^ 0.5
        TextBox3.Text = raiz
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Este programa potencia 2 valores'
        Dim valor1, valor2, potencia As Single
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        potencia = valor1 ^ valor2
        TextBox3.Text = potencia
    End Sub
End Class
