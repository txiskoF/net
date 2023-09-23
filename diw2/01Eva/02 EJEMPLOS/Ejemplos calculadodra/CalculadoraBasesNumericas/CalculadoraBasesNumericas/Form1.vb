Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "8"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "9"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "4"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "6"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "1"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "2"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "3"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "A"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "B"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "C"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "D"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "E"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "F"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtNumeroAComvertir.Text = txtNumeroAComvertir.Text + "0"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If txtNumeroAComvertir.Text.Length > 0 Then
            txtNumeroAComvertir.Text = txtNumeroAComvertir.Text.Substring(0, txtNumeroAComvertir.Text.Length - 1)
        End If

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If puedeConvertir(txtNumeroAComvertir.Text, Val(txtBaseDada.Text)) = True Then
            If Val(txtBaseAConvertir.Text) = 10 Then
                txtResultado.Text = numeroToDecimal(txtNumeroAComvertir.Text, Val(txtBaseDada.Text))
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            If Val(txtBaseAConvertir.Text) <> 0 And Val(txtBaseAConvertir.Text) <> 8 And Val(txtBaseAConvertir.Text) <> 10 And Val(txtBaseAConvertir.Text) <> 16 Then
                If Val(txtBaseDada.Text) = 10 Then
                    txtResultado.Text = decimalToBaseX(Val(txtNumeroAComvertir.Text), Val(txtBaseAConvertir.Text))
                Else
                    txtResultado.Text = decimalToBaseX(Val(numeroToDecimal(txtNumeroAComvertir.Text, Val(txtBaseDada.Text))), Val(txtBaseAConvertir.Text))
                End If
            End If

            If Val(txtBaseAConvertir.Text) = 8 Then

                If Val(txtBaseDada.Text) = 10 Then
                    Dim binario As String = decimalToBaseX(Val(txtNumeroAComvertir.Text), 2)
                    txtResultado.Text = binarioToOctal(binario)
                Else
                    Dim base10 As Integer = numeroToDecimal(txtNumeroAComvertir.Text, Val(txtBaseDada.Text))
                    Dim binario As String = decimalToBaseX(Val(base10), 2)
                    txtResultado.Text = binarioToOctal(binario)
                End If

            End If

            If Val(txtBaseAConvertir.Text) = 16 Then

                If Val(txtBaseDada.Text) = 10 Then
                    Dim binario As String = decimalToBaseX(Val(txtNumeroAComvertir.Text), 2)
                    txtResultado.Text = binarioToHexadecimal(binario)
                Else
                    Dim base10 As Integer = numeroToDecimal(txtNumeroAComvertir.Text, Val(txtBaseDada.Text))
                    Dim binario As String = decimalToBaseX(Val(base10), 2)
                    txtResultado.Text = binarioToHexadecimal(binario)
                End If

            End If



        Else
            MsgBox("El numero dado no corresponde a base: " + txtBaseDada.Text)
            txtResultado.Clear()
        End If


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        MsgBox(binarioToOctal(txtNumeroAComvertir.Text))
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs)
        MsgBox(binarioConCerosHexadecimal(txtNumeroAComvertir.Text))
    End Sub
End Class
