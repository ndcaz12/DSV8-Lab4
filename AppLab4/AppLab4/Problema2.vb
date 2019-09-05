Public Class Calculos
    Public Function Calculo_Salrio_Diario(salario As Double) As Double
        Dim SalarioFinal As Double = salario * 8
        Return SalarioFinal
    End Function
    Public Function Calculo_De_Incentivo(sillas As Integer, salrio As Double) As Double
        Dim IncentivoTotal = 0

        If (sillas > 50) Then
            IncentivoTotal = (salrio * 0.5)
        End If

        Return IncentivoTotal
    End Function
End Class
Public Class Problema2
    Shared Sub Main()

        Dim empleado As String
        Dim tarifaHora As Double
        Dim sillasDelDia As Integer

        Dim obj = New Calculos()

        Console.WriteLine(vbTab & "----------------------------------")
        Console.WriteLine(vbTab & "Fabrica de sillas Seminole")
        Console.WriteLine(vbTab & "----------------------------------")

        Console.WriteLine(vbTab & "Bienvenido al sistema de calculo de saldo diario")
        Console.WriteLine(vbTab & "Ingrese los datos solicitados a continuacion")

        Console.WriteLine(vbTab & "---------------------------------------------")
        Console.Write(vbTab & "Nombre: ")
        empleado = Console.ReadLine()
        Console.Write(vbTab & "Tarifa de salario por hora: $")
        tarifaHora = Console.ReadLine()
        Console.Write(vbTab & "Sillas producidas el dia de hoy: ")
        sillasDelDia = Console.ReadLine()
        Console.WriteLine(vbNewLine)
        Console.WriteLine(vbTab & "---------------------------------------------" & vbNewLine)

        Console.WriteLine(vbTab & "Perfecto " & empleado & " su desglose de hoy es el siguiente:")
        Console.WriteLine(vbTab & "Hoy usted realizo un total: " & sillasDelDia & " sillas.")
        Console.WriteLine(vbTab & "La tarifa de su salario por hora es de $: " & tarifaHora)
        Console.WriteLine(vbTab & "---------------------------------------------")
        Console.WriteLine(vbTab & "Su salario base diario es de = $" & obj.Calculo_Salrio_Diario(tarifaHora))
        Console.WriteLine(vbTab & "---------------------------------------------")
        Console.WriteLine(vbTab & "El incentivo es de = $" & obj.Calculo_De_Incentivo(sillasDelDia, obj.Calculo_Salrio_Diario(tarifaHora)))
        Console.WriteLine(vbTab & "---------------------------------------------")
        Console.WriteLine(vbTab & "Su salario total de hoy es de = $" & obj.Calculo_De_Incentivo(sillasDelDia, obj.Calculo_Salrio_Diario(tarifaHora)) + obj.Calculo_Salrio_Diario(tarifaHora))
        Console.WriteLine(vbTab & "---------------------------------------------")
        Console.Read()

    End Sub
End Class
