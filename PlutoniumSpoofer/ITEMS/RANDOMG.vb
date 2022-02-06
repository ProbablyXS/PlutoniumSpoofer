Module RANDOMG

    Public Function generateRandomProductID() As String
        Dim alphabet As String = "abcdefghijklmnopqrstuvwxyz"

        Dim randomNumber As New Random

        Dim r01, r02, r03, r04 As String

        For x As Integer = 1 To 5

            If (randomNumber.Next(0, 3)) Then
                r01 &= randomNumber.Next(0, 10).ToString
            Else
                r01 &= alphabet.Substring(randomNumber.Next(0, 26), 1).ToUpper
            End If

        Next

        For x As Integer = 1 To 5

            If (randomNumber.Next(0, 3)) Then
                r02 &= randomNumber.Next(0, 10).ToString
            Else
                r02 &= alphabet.Substring(randomNumber.Next(0, 26), 1).ToUpper
            End If

        Next

        For x As Integer = 1 To 5

            If (randomNumber.Next(0, 3)) Then
                r03 &= randomNumber.Next(0, 10).ToString
            Else
                r03 &= alphabet.Substring(randomNumber.Next(0, 26), 1).ToUpper
            End If

        Next

        For x As Integer = 1 To 5

            If (randomNumber.Next(0, 3)) Then
                r04 &= randomNumber.Next(0, 10).ToString
            Else
                r04 &= alphabet.Substring(randomNumber.Next(0, 26), 1).ToUpper
            End If

        Next

        Return r01 & "-" & r02 & "-" & r03 & "-" & r04

    End Function

    Public Function generateRandomMachineGUID() As String

        Dim randomNumber As New Random

        Dim r01, r02, r03, r04, r05 As String

        For x As Integer = 1 To 8

            r01 &= randomNumber.Next(0, 10).ToString

        Next

        For x As Integer = 1 To 4

            r02 &= randomNumber.Next(0, 10).ToString

        Next

        For x As Integer = 1 To 4

            r03 &= randomNumber.Next(0, 10).ToString

        Next

        For x As Integer = 1 To 4

            r04 &= randomNumber.Next(0, 10).ToString

        Next

        For x As Integer = 1 To 12

            r05 &= randomNumber.Next(0, 10).ToString

        Next

        Return r01 & "-" & r02 & "-" & r03 & "-" & r04 & "-" & r05

    End Function

    Public Function generateRandomMachineName() As String

        Dim alphabet As String = "abcdefghijklmnopqrstuvwxyz"
        Dim randomNumber As New Random

        Dim r01

        For x As Integer = 1 To 8

            If (randomNumber.Next(0, 2)) Then
                r01 &= randomNumber.Next(0, 10).ToString
            Else
                r01 &= alphabet.Substring(randomNumber.Next(0, 26), 1).ToUpper
            End If

        Next

        Return r01 & "-PC"

    End Function

    Public Function generateMacAddress() As String

        Dim alphabet As String = "abcdef"
        Dim randomNumber As New Random

        Dim r02, r03, r04, r05, r06 As String

        For x As Integer = 1 To 2
            If (randomNumber.Next(0, 3)) Then
                r02 &= randomNumber.Next(0, 10).ToString
            Else
                r02 &= alphabet.Substring(randomNumber.Next(0, 6), 1).ToUpper
            End If
        Next

        For x As Integer = 1 To 2
            If (randomNumber.Next(0, 3)) Then
                r03 &= randomNumber.Next(0, 10).ToString
            Else
                r03 &= alphabet.Substring(randomNumber.Next(0, 6), 1).ToUpper
            End If
        Next

        For x As Integer = 1 To 2
            If (randomNumber.Next(0, 3)) Then
                r04 &= randomNumber.Next(0, 10).ToString
            Else
                r04 &= alphabet.Substring(randomNumber.Next(0, 6), 1).ToUpper
            End If
        Next

        For x As Integer = 1 To 2
            If (randomNumber.Next(0, 3)) Then
                r05 &= randomNumber.Next(0, 10).ToString
            Else
                r05 &= alphabet.Substring(randomNumber.Next(0, 6), 1).ToUpper
            End If
        Next

        For x As Integer = 1 To 2
            If (randomNumber.Next(0, 3)) Then
                r06 &= randomNumber.Next(0, 10).ToString
            Else
                r06 &= alphabet.Substring(randomNumber.Next(0, 6), 1).ToUpper
            End If
        Next

        Return "02" & r02 & r03 & r04 & r05 & r06

    End Function

    Public Function generateRandomVolumeId() As String

        Dim alphabet As String = "abcdef"
        Dim randomNumber As New Random

        Dim r01, r02 As String

        For x As Integer = 1 To 4
            If (randomNumber.Next(0, 3)) Then
                r01 &= randomNumber.Next(0, 10).ToString
            Else
                r01 &= alphabet.Substring(randomNumber.Next(0, 6), 1).ToUpper
            End If
        Next

        For x As Integer = 1 To 4
            If (randomNumber.Next(0, 3)) Then
                r02 &= randomNumber.Next(0, 10).ToString
            Else
                r02 &= alphabet.Substring(randomNumber.Next(0, 6), 1).ToUpper
            End If
        Next

        Return r01 & "-" & r02

    End Function

End Module
