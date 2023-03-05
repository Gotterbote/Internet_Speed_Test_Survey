Public Class Form1
    'Name: Internet Speed Test Survey
    'Developer: Timmy Bell
    'Date: 03/05/2023

    ' This program calculates the average internet speed in Mbps

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnterData.Click
        'Input Box Variables
        Dim strInputMessage As String = "Enter your download speed in Mbps or cancel to end"
        Dim strTitle As String = "Enter Download Speed"
        Dim strDefault = "0"
        Dim strCancelClicked = ""

        'Other Variables
        Dim strInternetSpeed As String
        Dim dblInternetSpeed As Double
        Dim intCount As Integer = 0
        Dim dblTotal As Double = 0
        Dim dblAverage As Double

        'Get User Input
        strInternetSpeed = InputBox(strInputMessage, strTitle, strDefault)

        'Do while loop to check if input is valid and counter less than 10
        Do While strInternetSpeed <> strCancelClicked And intCount < 10
            If IsNumeric(strInternetSpeed) Then
                'input is a valid number
                dblInternetSpeed = Convert.ToDouble(strInternetSpeed)
                'test to see if input is in valid range
                If (dblInternetSpeed >= 0 And dblInternetSpeed <= 100000) Then
                    'speed is within range
                    'add speed to the listbox
                    lstContainer.Items.Add(dblInternetSpeed.ToString("n2"))
                    'add speed to the accumulator
                    dblTotal += dblInternetSpeed
                    intCount += 1
                Else
                    'speed is not within range
                    MessageBox.Show("Speed must be greater than zero and less than 100000")
                End If
            Else
                'input is not a valid number
                MessageBox.Show("Please enter a valid number")
            End If
            strInternetSpeed = InputBox(strInputMessage, strTitle, strDefault)
        Loop
        dblAverage = dblTotal / intCount

        If intCount < 10 Then
            'display accuracy message
            lblAccuracy.Visible = True
        Else
            lblAccuracy.Visible = False
        End If

        'Dispaly the results in lblOutput
        lblOutput.Visible = True
        lblOutput.Text = dblAverage.ToString("n2") + " Mbps"
        btnClear.Visible = True
        btnClose.Visible = True

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnClear.Visible = False
        lstContainer.Items.Clear()
        lblOutput.Visible = False
        btnEnterData.Focus()
        lblAccuracy.Visible = False
        btnClose.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
