Public Class Form1

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'fix problem avec le .net metro UI
        ListWriteBox.ForeColor = Color.FromArgb(170, 170, 170)
        MetroSetComboBox1.ForeColor = Color.FromArgb(170, 170, 170)
        MetroSetComboBox1.SelectedItemBackColor = Color.FromArgb(34, 34, 34)
        MetroSetComboBox1.SelectedItemForeColor = Color.FromArgb(170, 170, 170)
        'fix problem avec le .net metro UI

        Dim num1 As Integer = 0
        Dim num2 As Integer = 0

        Do Until num1 And num2 = 99

            Await Task.Delay(1)

            If My.Computer.Registry.LocalMachine.OpenSubKey(LocaMacAddress & "00" & num1 & num2) Is Nothing Then

                num2 += 1

            Else

                Dim result As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\" & LocaMacAddress & "00" & num1 & num2, "DriverDesc", "")

                MetroSetComboBox1.Items.Add("(" & num1 & num2 & ")" & Space(1) & result)

                If num2 >= 9 Then

                    num1 += 1
                    num2 = 0

                End If

                num2 += 1

            End If

        Loop

        MetroSetComboBox1.SelectedIndex = 0

        ListWriteBox.Items.Add("● Welcome to Plutonium Spoofer")

        If My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Spoofer") IsNot Nothing Then
            Button3.Visible = True
        End If

        Label1.Visible = False
        Button1.Visible = True
        MetroSetComboBox1.Visible = True
        ListWriteBox.AllowDrop = True
        MetroSetComboBox1.AllowDrop = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SPOOF.Spoof()

    End Sub

    Private Sub MetroSetComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroSetComboBox1.SelectedIndexChanged

        Dim length As Integer = MetroSetComboBox1.SelectedItem.ToString.Length - 4
        resultNumbMacAddress = MetroSetComboBox1.SelectedItem.ToString.Remove(4, length).Replace("(", Nothing).Replace(")", Nothing)

    End Sub

    Private Sub MetroSetComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroSetComboBox1.SelectedIndexChanged

        Focus() 'fix text bizarre

    End Sub

    Private Sub MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter

        If sender.Name = Button2.Name Then
            sender.ForeColor = Color.FromArgb(170, 170, 110)
        End If

    End Sub

    Private Sub MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave

        If sender.Name = Button2.Name Then
            sender.ForeColor = Color.FromArgb(170, 170, 170)
        End If

    End Sub

    Public Sub OutputHandler(sender As Object, e As DataReceivedEventArgs)

        If Not String.IsNullOrEmpty(e.Data) Then

            Dim ez As String = e.Data
            If ez = "VolumeId v2.1 - Set disk volume id" Or ez = "Copyright (C) 1997-2016 Mark Russinovich" Or ez = "Sysinternals - www.sysinternals.com" Then

                Exit Sub

            End If

            If ez.Contains("Volume Serial Number is") Then

                Dim wordtofind As String = "is"
                Dim findval = ez.IndexOf(wordtofind)
                SPOOF.volOlderValue = ez.Substring(findval + wordtofind.Length, ez.Length - wordtofind.Length - findval).ToString()

                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Spoofer",
      "VolumeId", volOlderValue.ToString())

            End If

            ListWriteBox.Items.Add("●" & ez)

        End If

    End Sub


    Public Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)

        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        p.StartInfo = pi

        AddHandler p.OutputDataReceived, AddressOf OutputHandler

        With p.StartInfo
            .FileName = "cmd.exe"
            .Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments

            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .RedirectStandardInput = True
            .UseShellExecute = False
            .CreateNoWindow = True

        End With

        p.Start()

        p.BeginOutputReadLine()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        SPOOF.SpoofOriginal()

    End Sub
End Class
