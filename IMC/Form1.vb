Public Class Form1
    Dim calcula As Double
    Dim riesgo As Integer
    Private Sub btncalcula_Click(sender As Object, e As EventArgs) Handles btncalcula.Click
        calcula = Val(txtpeso.Text) / (Val(txtaltura.Text) * Val(txtaltura.Text))
        txtcalcula.Text = Format(calcula, "0.00")
        riesgo = calcula
        If (riesgo >= 18.5 And riesgo <= 24.9) Then
            lblmensaje.Text = "Nivel de Riesgo: Promedio"
        ElseIf (riesgo >= 25 And riesgo <= 29.9) Then
            lblmensaje.Text = "Nivel de Riesgo: Aumentado"
        ElseIf (riesgo >= 30 And riesgo <= 34.9) Then
            lblmensaje.Text = "Nivel de Riesgo: Moderado"
        ElseIf (riesgo >= 35 And riesgo <= 39.9) Then
            lblmensaje.Text = "Nivel de Riesgo: Severo"
        ElseIf (riesgo >= 40) Then
            lblmensaje.Text = "Nivel de Riesgo: Muy Severo"
        Else
            lblmensaje.Text = "Nivel fuera de rango"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End
    End Sub
End Class
