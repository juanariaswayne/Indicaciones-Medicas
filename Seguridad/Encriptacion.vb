Public Class Encriptacion

    Function ENCRIPTAR(ByVal valor As String) As String
        Try
            Dim Clave As String, i As Integer, Encriptado As String, Encriptado_CRC As String
            Dim CAR As String, Codigo As String, Valor_CRC As String
            Encriptado = String.Empty
            Encriptado_CRC = String.Empty
            Valor_CRC = String.Empty

            'ENCRIPTO LA CLAVE
            Clave = "?ü&/@#$|"
            For i = 1 To Len(Trim(valor))
                CAR = Mid(valor, i, 1)
                Codigo = Mid(Clave, ((i - 1) Mod Len(Clave)) + 1, 1)
                Encriptado = Encriptado & Microsoft.VisualBasic.Strings.Right("0" & Hex(Asc(Codigo) Xor Asc(CAR)), 2)
            Next i

            Return Encriptado

        Catch ex As Exception
            Return "Error"
        End Try


    End Function

    Function DESENCRIPTAR(ByVal valor As String) As String

        Try

            Dim Clave As String, i As Integer, DesEncriptado As String
            Dim CAR As String, Codigo As String
            Dim j As Integer

            Clave = "?ü&/@#$|"
            DesEncriptado = String.Empty
            j = 1

            For i = 1 To Len(Trim(CType(valor, String))) Step 2
                CAR = Mid(valor, i, 2)
                Codigo = Mid(Clave, ((j - 1) Mod Len(Clave)) + 1, 1)
                DesEncriptado = DesEncriptado & Chr(Asc(Codigo) Xor Val("&h" + CAR))
                j = j + 1
            Next i

            
            Return DesEncriptado


        Catch ex As Exception
            Return "Error"
        End Try


    End Function

End Class
