Public Class Form1
    Dim op, pr, ps, conf As Integer
    Dim pert, varianza, menorTiempo, mayorTiempo As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pert = (Val(TextBox1.Text) + 4 * Val(TextBox2.Text) + Val(TextBox3.Text)) / 6
        varianza = (Val(TextBox3.Text) - Val(TextBox1.Text)) / 6
        If RadioButton1.Checked = True Then
            menorTiempo = pert - 1 * varianza
            mayorTiempo = pert + 1 * varianza
            resultado.Text = menorTiempo
            resultado2.Text = mayorTiempo
        ElseIf RadioButton2.Checked = True Then
            menorTiempo = pert - 2 * varianza
            mayorTiempo = pert + 2 * varianza
            resultado.Text = menorTiempo
            resultado2.Text = mayorTiempo
        ElseIf RadioButton3.Checked = True Then
            menorTiempo = pert - 3 * varianza
            mayorTiempo = pert + 3 * varianza
            resultado.Text = menorTiempo
            resultado2.Text = mayorTiempo
        End If
    End Sub

End Class
