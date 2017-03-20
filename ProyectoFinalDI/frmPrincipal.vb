Public Class frmPrincipal
    Dim frmMenu As New ucPuntuacion5
    Dim contador As Integer

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If contador < 100 Then
            ProgressBar.Value = contador
            contador = contador + 1

        Else
            Timer.Enabled = False
            btnIniciar.Visible = True
            lblCargando.Text = "Aplicación cargada"
        End If
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        frmMenu.Show()
    End Sub

End Class
