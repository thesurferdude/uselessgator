Module Module1
    Dim mymenu As Integer
    Dim option1 As Integer

    Sub Main()
mymenu:
        Console.WriteLine("
░░░░░▄▄▄▄▄░▄░▄░▄░▄
▄▄▄▄██▄████▀█▀█▀█▀██▄
▀▄▀▄▀▄████▄█▄█▄█▄█████
▒▀▀▀▀▀▀▀▀██▀▀▀▀██▀▒▄██
▒▒▒▒▒▒▒▒▀▀▒▒▒▒▀▀▄▄██▀▒
")
        Console.WriteLine()

        Console.WriteLine("hello and welcome to uselessgator!" + vbCrLf + "1 - option1" + vbCrLf + "2 - oops loops" + vbCrLf + "3 - option3" + vbCrLf + "4 - exit")
        Do Until mymenu = 4
            mymenu = Console.ReadLine
            Select Case mymenu
                Case "1"
                    GoTo option1

                Case "2"
                    GoTo option2

                Case "3"
                    GoTo option3

                Case "4"
                    GoTo myExit

            End Select

        Loop

option1:
        Console.WriteLine("option 1 works!" + vbCrLf + "1 - main menu" + vbCrLf + "2 - option2")
        Do Until option1 = 2
            option1 = Console.ReadLine
            Select Case option1
                Case "1"
                    GoTo mymenu

                Case "2"
                    GoTo option2
            End Select

        Loop


option2:
        Do
            Console.WriteLine("oops")
        Loop
option3:




myExit:
        Console.WriteLine("thank you for using uselessgator")
        Console.WriteLine("press any key to exit")
        Console.ReadKey(True)

    End Sub

End Module
