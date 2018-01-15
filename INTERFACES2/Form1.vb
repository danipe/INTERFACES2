Public Class Form1
    Dim numeroAleatorio As Integer
    Dim contador As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contador = 0
        Randomize()
        numeroAleatorio = Int(100 * Rnd() + 1)
        TextBox1.Enabled = True
        Button1.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim numero As Integer
            Try
                numero = Integer.Parse(TextBox1.Text)
                TextBox1.Text = ""
                CheckNumber(numero)
            Catch ex As Exception
                MessageBox.Show("No has introducido un número válido", "Atención", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Function CheckNumber(numero As Integer)
        contador = contador + 1
        If numero > numeroAleatorio Then
            ListBox1.Items.Add(numero.ToString + ": El numero es mayor que el numero secreto")
        ElseIf numero < numeroAleatorio Then
            ListBox1.Items.Add(numero.ToString + ": El numero es menor que el numero secreto")
        ElseIf numero = numeroAleatorio Then
            ListBox1.Items.Add(numero.ToString + ": Acertaste, te ha costado " + contador.ToString + " intentos")
            TextBox1.Enabled = False
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = True
        TextBox1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dispose()
    End Sub
End Class
