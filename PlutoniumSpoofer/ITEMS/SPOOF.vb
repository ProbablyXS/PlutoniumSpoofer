Imports System.IO
Imports System.Threading

Module SPOOF

    Public LocaprodID As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion"
    Public LocaMachID As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography"
    Public LocaMachName As String = "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\ComputerName\ComputerName"
    Public LocaMacAddress As String = "SYSTEM\ControlSet001\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\"
    Public New_ProdID As String
    Public New_MachID As String
    Public New_MachNAME As String
    Public New_MacAdress As String
    Public Started As Boolean = False
    Public resultNumbMacAddress As String
    Dim proc As New Process()

    Public Async Sub Spoof()

        Try

            If Started = True Then
                Form1.ListWriteBox.Items.Add("● The spoofer is already started")
                Exit Sub
            Else
                Started = True
            End If

            Form1.ListWriteBox.Items.Add("● Starting SPOOFER in 5 seconds")

            Await Delay() 'WAIT 5 SECONDES

            Await ProdID()
            Await MachineGUID()
            Await MachineNAME()
            Await MacAddress()

            Await VolumeId()

            Await LOG()

            Dim messaging As Integer = MsgBox("Would do you want to restart your computer now ?", MsgBoxStyle.YesNo)

            If messaging = vbYes Then

                Shell("Shutdown -r -t 1", vbHide)

            End If

            Started = False

        Catch ex As Exception

        End Try

    End Sub

    Public Async Function Delay() As Task

        Dim val As Integer = 0
        Do Until val = 5

            Await Task.Delay(1000)

            val += 1

        Loop
    End Function

    Public Async Function ProdID() As Task

        Form1.ListWriteBox.Items.Add("● Spoofing Product Id")

        Await Task.Delay(200)

        Form1.ListWriteBox.Items.Add("● Old: " & My.Computer.Registry.GetValue(LocaprodID, "ProductId", ""))

        Await Task.Delay(200)

        New_ProdID = (RANDOMG.generateRandomProductID)
        My.Computer.Registry.SetValue(LocaprodID, "ProductId", New_ProdID)
        Form1.ListWriteBox.Items.Add("● New: " & My.Computer.Registry.GetValue(LocaprodID, "ProductId", ""))

    End Function

    Public Async Function MachineGUID() As Task

        Form1.ListWriteBox.Items.Add("● Spoofing Machine GUID")

        Await Task.Delay(200)

        Form1.ListWriteBox.Items.Add("● Old: " & My.Computer.Registry.GetValue(LocaMachID, "MachineGuid", ""))

        Await Task.Delay(200)

        New_MachID = (RANDOMG.generateRandomMachineGUID)
        My.Computer.Registry.SetValue(LocaMachID, "MachineGuid", New_MachID)
        Form1.ListWriteBox.Items.Add("● New: " & My.Computer.Registry.GetValue(LocaMachID, "MachineGuid", ""))



    End Function

    Public Async Function MachineNAME() As Task

        Form1.ListWriteBox.Items.Add("● Spoofing Machine Name")

        Await Task.Delay(200)

        Form1.ListWriteBox.Items.Add("● Old: " & My.Computer.Registry.GetValue(LocaMachName, "ComputerName", ""))

        Await Task.Delay(200)

        New_MachNAME = (RANDOMG.generateRandomMachineName)
        My.Computer.Registry.SetValue(LocaMachName, "ComputerName", New_MachNAME)
        Form1.ListWriteBox.Items.Add("● New: " & My.Computer.Registry.GetValue(LocaMachName, "ComputerName", ""))



    End Function

    Public Async Function MacAddress() As Task

        Form1.ListWriteBox.Items.Add("● Spoofing Mac Address")

        Await Task.Delay(200)

        Form1.ListWriteBox.Items.Add("● Old: " & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\" & LocaMacAddress & "00" & resultNumbMacAddress, "NetworkAddress", ""))

        Await Task.Delay(200)

        New_MacAdress = (RANDOMG.generateMacAddress)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\" & LocaMacAddress & "00" & resultNumbMacAddress, "NetworkAddress", New_MacAdress)
        Form1.ListWriteBox.Items.Add("● New: " & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\" & LocaMacAddress & "00" & resultNumbMacAddress, "NetworkAddress", ""))



    End Function

    Public Async Function LOG() As Task

        For i As Integer = 0 To Form1.ListWriteBox.Items.Count

            Try

                Dim line As String = Form1.ListWriteBox.Items(i).ToString

                Dim write As New IO.StreamWriter("LOG.txt", True)

                write.WriteLine(DateTime.Now & Space(1) & line)
                write.Close()

            Catch ex As Exception

                Exit For

            End Try

        Next

    End Function

    Public Async Function VolumeId() As Task

        Dim Paths As String = Path.Combine(Path.GetTempPath(), "Volumeid.exe")
        File.WriteAllBytes(Paths, My.Resources.Volumeid)
        Process.Start(Paths)

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Sysinternals\VolumeID\", "EulaAccepted", "1")

        Form1.RunCommandCom(Paths, "c: " & generateRandomVolumeId(), False)

    End Function

End Module
