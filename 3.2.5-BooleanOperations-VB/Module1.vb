Module Module1

    Sub Main()
        '   Students should be able to use these operators,
        ' And combinations of these operators, within
        ' conditions for iterative And selection structures
        ' Be familiar with And be able to use:
        ' Not
        Dim found As Boolean = False
        If Not found Then
            Console.WriteLine("Not found")
        End If
        While Not found
            Console.WriteLine("loop while not found")
        End While
        Do
            Console.WriteLine("Loop while not found")
        Loop While Not found

        'AND
        Dim valid As Boolean = True
        If Not found And valid Then
            Console.WriteLine("found = false and valid = true")
        End If
        While Not found And valid
            Console.WriteLine("Loop while found = false and valid = true")
        End While
        Do
            Console.WriteLine("Loop while found = false and valid = true")
        Loop While valid And Not found

        ' OR
        If found Or valid Then
            Console.WriteLine("Found or valid are true")
        End If
        While found Or valid
            Console.WriteLine("Loop while either found or valid are true")
        End While
        Do
            Console.WriteLine("Loop while either found or valid are true")
        Loop While found Or valid
    End Sub

End Module
