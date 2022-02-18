Public Class Form1
    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click
        Dim i, j As Integer
        Try
            j = 1
            Dim n As String = txt_factor.Text
            Dim numero As Decimal = Convert.ToDecimal(n)

            For i = 1 To n Step 1
                j = j * i
            Next
            lbl_resultado.Text = j.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
