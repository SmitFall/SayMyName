'Fallon Smith
'RCET0265
'Spring 2022
'Say My Name
'https://github.com/SmitFall/SayMyName


Option Explicit On
Option Strict On

Module Saymyname

    Sub Main()
        'declare some variables
        Dim userinput As String


        Console.WriteLine("Please type your name")
        userinput = Console.ReadLine()
        Console.WriteLine("Hello " & userinput & "! aren't you looking nice today!")

        'wait for user response
        Console.ReadLine()

    End Sub

End Module
