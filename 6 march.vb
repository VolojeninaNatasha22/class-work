Imports System

Module Program
    Sub Main(args As String())
        Dim numbers(5) As Integer

        For i = 0 To numbers.Length - 1
            numbers(i) = Console.ReadLine()
        Next
        Console.WriteLine()

        printReverse(numbers)
        Dim strings(4) As String
        For i = 0 To strings.Length - 1
            strings(i) = Console.ReadLine()
        Next
        printReverse(strings)
        Console.ReadLine()
    End Sub
    Sub printReverse(list As Integer())
        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next

    End Sub
    Sub printReverse(list As String())
        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next

    End Sub
End Module
