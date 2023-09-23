Module Operacion

    Dim octal() As String = {"000", "001", "010", "011", "100", "101", "110", "111"}
    Dim hexadecimal() As String = {"0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"}

    Function numeroToDecimal(ByVal numero As String, ByVal base As Integer) As String
        Dim x As Integer = 0
        Dim total As Integer = 0
        Dim numeros() As Char = numero.ToArray
        Dim numeroString As String = ""
        For x = numero.Length - 1 To 0 Step -1
            numeroString = "" + numeros(x)
            If IsNumeric(numeroString) = True Then
                'MsgBox("Numero")
                total += (Val(numeroString) * (Math.Pow(base, ((numero.Length - (x)) - 1))))
            Else
                'MsgBox("Letra")
                'MsgBox(valorHexadecimal(numeroString).ToString + "*" + "(" + base.ToString + "elevado: " + (numero.Length - (x) - 1).ToString)
                total += (valorHexadecimal(numeroString) * (Math.Pow(base, (numero.Length - (x) - 1))))
            End If
            'total += numero = "" + numero(x)
        Next
        Return total
    End Function



    'Convierte de base 10 a una base X'
    Function decimalToBaseX(ByVal numero As Integer, ByVal base As Integer) As String
        Dim x As Integer = 0
        Dim y As String = ""
        Dim salida As String = ""
        Dim total As String = ""
        Dim division As Integer = numero
        While (division >= base)
            salida = (division Mod base).ToString
            If tieneLetra(salida) = True Then
                total = letraHexadecimal(salida) + total
                division = Math.Floor(division / base)
            Else
                total = salida + total
                division = Math.Floor(division / base)
            End If
            
        End While

        If tieneLetra(division.ToString) = True Then
            y = letraHexadecimal(division.ToString) + total
            MsgBox("Final: " + y)
        Else
            y = division.ToString + total

        End If

        Return y
    End Function

    'Retorna true o false si puede o no convertir '
    Function puedeConvertir(ByVal numero As String, ByVal base As Integer) As Boolean
        Dim salida As Boolean = True
        Dim x As Integer = 0
        Dim numeros() As Char = numero.ToArray
        Dim numeroString As String = ""
        For x = numero.Length - 1 To 0 Step -1
            numeroString = "" + numeros(x)
            If IsNumeric(numeroString) = True Then
                If Val(numeroString) >= base Then
                    salida = False
                    Exit For
                End If

            Else
                If valorHexadecimal(numeroString) >= base Then
                    salida = False
                    Exit For
                End If
            End If
        Next
        Return salida
    End Function

    'Retorna el valor en Decimal de una Letra'
    Function valorHexadecimal(ByVal letra As String) As Integer
        Dim valor As Integer = 0
        Select Case letra

            Case "A"
                valor = 10

            Case "B"
                valor = 11

            Case "C"
                valor = 12

            Case "D"
                valor = 13

            Case "E"
                valor = 14

            Case "F"
                valor = 15

        End Select
        Return valor
    End Function

    'Retorna una letra apartir de un numero Hexadecimal'
    Function letraHexadecimal2(ByVal numero As String) As String
        Dim salida = ""
        Dim letra As String = ""
        Select Case numero

            Case "1010"
                letra = "A"

            Case "1011"
                letra = "B"

            Case "1100"
                letra = "C"

            Case "1101"
                letra = "D"

            Case "1110"
                letra = "E"

            Case "1111"
                letra = "F"
        End Select
        Return letra
    End Function


    'Retorna una letra apartir de un numero Hexadecimal'
    Function letraHexadecimal(ByVal numero As String) As String
        Dim salida = ""
        Dim letra As String = ""
        Select Case numero

            Case "10"
                letra = "A"

            Case "11"
                letra = "B"

            Case "12"
                letra = "C"

            Case "13"
                letra = "D"

            Case "14"
                letra = "E"

            Case "15"
                letra = "F"
        End Select
        Return letra
    End Function

    'Devuelve true o false si el numero contiene una letra que lo representa'
    Function tieneLetra(ByVal letra As String) As Boolean
        Dim valores() As String = {"10", "11", "12", "13", "14", "15"}
        Dim x As Integer = 0
        Dim resultado As Boolean = False
        For x = 0 To valores.Length - 1
            If letra.Equals(valores(x)) = True Then
                resultado = True
                Exit For
            End If
        Next
        Return resultado
    End Function

    'Devuelve true o false si el numero contiene una letra que lo representa'
    Function tieneLetraHexadecimal(ByVal letra As String) As Boolean
        Dim valores() As String = {"1010", "1011", "1100", "1101", "1110", "1111"}
        Dim x As Integer = 0
        Dim resultado As Boolean = False
        For x = 0 To valores.Length - 1
            If letra.Equals(valores(x)) = True Then
                resultado = True
                Exit For
            End If
        Next
        Return resultado
    End Function

    'Agrega o no los ceros necesarios a la izquierda(Para un octal)'
    Function binarioConCerosOctal(ByVal numero As String)
        Dim salida As String = ""
        Dim cantidad As Integer = numero.Length
        If numero.Length Mod 3 = 1 Then
            salida = "00" + numero
        ElseIf numero.Length Mod 3 = 2 Then
            salida = "0" + numero
        Else
            salida = numero
        End If
        Return salida
    End Function


    'Agrega o no los ceros necesarios a la izquierda(Para un Hexadecimal)'
    Function binarioConCerosHexadecimal(ByVal numero As String)
        Dim salida As String = ""
        Dim cantidad As Integer = numero.Length
        If numero.Length Mod 4 = 1 Then
            salida = "000" + numero
        ElseIf numero.Length Mod 4 = 2 Then
            salida = "00" + numero
        ElseIf numero.Length Mod 4 = 3 Then
            salida = "0" + numero
        Else
            salida = numero
        End If
        Return salida
    End Function

    'Retorna un numero octal correspondiente a el binario'
    Function numeroOctalFromBinario(ByVal numero As String) As String
        Dim x As Integer = 0
        Dim salida As String = ""
        For x = 0 To octal.Length - 1
            If numero.Equals(octal(x)) = True Then
                salida = x.ToString
                Exit For
            End If
        Next
        Return salida
    End Function

    'Retorna un numero Hexadecimal correspondiente a el binario'
    Function numeroHexadecimalFromBinario(ByVal numero As String) As String
        Dim x As Integer = 0
        Dim salida As String = ""
        For x = 0 To octal.Length - 1
            If numero.Equals(hexadecimal(x)) = True Then
                salida = x.ToString
                Exit For
            End If
        Next
        Return salida
    End Function


    'Recibe un binario y lo convierte a octal'
    Function binarioToOctal(ByVal numero As String) As String
        Dim salida As String = ""
        Dim concatenacion As String = ""
        Dim vector() As Char = binarioConCerosOctal(numero).ToCharArray
        Dim x As Integer = 0
        For x = 0 To vector.Length - 1
            concatenacion += vector(x)
            If concatenacion.Length = 3 Then
                salida += numeroOctalFromBinario(concatenacion)
                concatenacion = ""
            End If
        Next
        Return salida
    End Function


    'Recibe un binario y lo convierte a Hexadecimal'
    Function binarioToHexadecimal(ByVal numero As String) As String
        Dim salida As String = ""
        Dim concatenacion As String = ""
        Dim vector() As Char = binarioConCerosHexadecimal(numero).ToCharArray
        Dim x As Integer = 0
        For x = 0 To vector.Length - 1
            concatenacion += vector(x)
            If concatenacion.Length = 4 Then
                If tieneLetraHexadecimal(concatenacion) = True Then
                    salida += letraHexadecimal2(concatenacion)
                Else
                    salida += numeroHexadecimalFromBinario(concatenacion)
                End If

                concatenacion = ""
            End If
        Next
        Return salida
    End Function

End Module
