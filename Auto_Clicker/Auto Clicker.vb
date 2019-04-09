Public Class Form1
    Public Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)

    Public startingKey As Integer = 0 'Keys to start/stop the autoclicker
    Public stoppingKey As Integer = 0

    Dim maxLength As Integer = 10 'The max length of the integer textboxes (min/max timer)


    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        startTimer.Enabled = True
        Randomize()
        Dim nextTimer As Integer = CInt(Int((maxTime.Text * Rnd()) + minTime.Text))
        startTimer.Interval = nextTimer
    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        startTimer.Enabled = False
    End Sub

    Private Sub startTimer_Tick(sender As Object, e As EventArgs) Handles startTimer.Tick
        Dim position
        position = Cursor.Position
        Cursor.Position = New Point(Cursor.Position.X, Cursor.Position.Y)
        mouse_event(&H2, 0, 0, 0, 0) 'Left mouse key down
        mouse_event(&H4, 0, 0, 0, 0) 'Left mouse key let up
        Me.Activate()
    End Sub

    Private Sub submitKeys_Click(sender As Object, e As EventArgs) Handles submitKeys.Click

        startButton.Text = "START"
        stopButton.Text = "STOP"

        If startKey.Text = "a" Then 'Gets the key that the user wants to start the autoclicker with
            startingKey = 97

        ElseIf startKey.Text = "b" Then
            startingKey = 98

        ElseIf startKey.Text = "c" Then
            startingKey = 99

        ElseIf startKey.Text = "d" Then
            startingKey = 100

        ElseIf startKey.Text = "e" Then
            startingKey = 101

        ElseIf startKey.Text = "f" Then
            startingKey = 102

        ElseIf startKey.Text = "g" Then
            startingKey = 103

        ElseIf startKey.Text = "h" Then
            startingKey = 104

        ElseIf startKey.Text = "i" Then
            startingKey = 105

        ElseIf startKey.Text = "j" Then
            startingKey = 106

        ElseIf startKey.Text = "k" Then
            startingKey = 107

        ElseIf startKey.Text = "l" Then
            startingKey = 108

        ElseIf startKey.Text = "m" Then
            startingKey = 109

        ElseIf startKey.Text = "n" Then
            startingKey = 110

        ElseIf startKey.Text = "o" Then
            startingKey = 111

        ElseIf startKey.Text = "p" Then
            startingKey = 112

        ElseIf startKey.Text = "q" Then
            startingKey = 113

        ElseIf startKey.Text = "r" Then
            startingKey = 114

        ElseIf startKey.Text = "s" Then
            startingKey = 115

        ElseIf startKey.Text = "t" Then
            startingKey = 116

        ElseIf startKey.Text = "u" Then
            startingKey = 117

        ElseIf startKey.Text = "v" Then
            startingKey = 118

        ElseIf startKey.Text = "w" Then
            startingKey = 119

        ElseIf startKey.Text = "x" Then
            startingKey = 120

        ElseIf startKey.Text = "y" Then
            startingKey = 121

        ElseIf startKey.Text = "z" Then
            startingKey = 122

        ElseIf startKey.Text = "0" Then
            startingKey = 48

        ElseIf startKey.Text = "1" Then
            startingKey = 49

        ElseIf startKey.Text = "2" Then
            startingKey = 50

        ElseIf startKey.Text = "3" Then
            startingKey = 51

        ElseIf startKey.Text = "4" Then
            startingKey = 52

        ElseIf startKey.Text = "5" Then
            startingKey = 53

        ElseIf startKey.Text = "6" Then
            startingKey = 54

        ElseIf startKey.Text = "7" Then
            startingKey = 55

        ElseIf startKey.Text = "8" Then
            startingKey = 56

        ElseIf startKey.Text = "9" Then
            startingKey = 57

        Else
            startingKey = 97
        End If

        If stopKey.Text = "a" Then 'Gets the key that the user wants to stop the autoclicker with
            stoppingKey = 97

        ElseIf stopKey.Text = "b" Then
            stoppingKey = 98

        ElseIf stopKey.Text = "c" Then
            stoppingKey = 99

        ElseIf stopKey.Text = "d" Then
            stoppingKey = 100

        ElseIf stopKey.Text = "e" Then
            stoppingKey = 101

        ElseIf stopKey.Text = "f" Then
            stoppingKey = 102

        ElseIf stopKey.Text = "g" Then
            stoppingKey = 103

        ElseIf stopKey.Text = "h" Then
            stoppingKey = 104

        ElseIf stopKey.Text = "i" Then
            stoppingKey = 105

        ElseIf stopKey.Text = "j" Then
            stoppingKey = 106

        ElseIf stopKey.Text = "k" Then
            stoppingKey = 107

        ElseIf stopKey.Text = "m" Then
            stoppingKey = 109

        ElseIf stopKey.Text = "n" Then
            stoppingKey = 110

        ElseIf stopKey.Text = "l" Then
            stoppingKey = 108

        ElseIf stopKey.Text = "o" Then
            stoppingKey = 111

        ElseIf stopKey.Text = "p" Then
            stoppingKey = 112

        ElseIf stopKey.Text = "q" Then
            stoppingKey = 113

        ElseIf stopKey.Text = "r" Then
            stoppingKey = 114

        ElseIf stopKey.Text = "s" Then
            stoppingKey = 115

        ElseIf stopKey.Text = "t" Then
            stoppingKey = 116

        ElseIf stopKey.Text = "u" Then
            stoppingKey = 117

        ElseIf stopKey.Text = "v" Then
            stoppingKey = 118

        ElseIf stopKey.Text = "w" Then
            stoppingKey = 119

        ElseIf stopKey.Text = "x" Then
            stoppingKey = 120

        ElseIf stopKey.Text = "y" Then
            stoppingKey = 121

        ElseIf stopKey.Text = "z" Then
            stoppingKey = 122

        ElseIf stopKey.Text = "0" Then
            stoppingKey = 48

        ElseIf stopKey.Text = "1" Then
            stoppingKey = 49

        ElseIf stopKey.Text = "2" Then
            stoppingKey = 50

        ElseIf stopKey.Text = "3" Then
            stoppingKey = 51

        ElseIf stopKey.Text = "4" Then
            stoppingKey = 52

        ElseIf stopKey.Text = "5" Then
            stoppingKey = 53

        ElseIf stopKey.Text = "6" Then
            stoppingKey = 54

        ElseIf stopKey.Text = "7" Then
            stoppingKey = 55

        ElseIf stopKey.Text = "8" Then
            stoppingKey = 56

        ElseIf stopKey.Text = "9" Then
            stoppingKey = 57

        Else
            stoppingKey = 98
        End If

        startButton.Text = startButton.Text + " (" + startKey.Text + ")"
        stopButton.Text = stopButton.Text + " (" + stopKey.Text + ")"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "AUTO CLICKER"
        Dim ico As New System.Drawing.Icon("AC Icon.ico.ico")
        Me.Icon = ico
        submitKeys.Select()
        minTime.BackColor = DefaultBackColor
        startingKey = 0
        stoppingKey = 0
        submitKeys_Click(Me, EventArgs.Empty) 'Sets the start/stop keys before starting
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(startingKey) Then 'Starts the autoclicker if the starting key is pressed
            Call startButton_Click(Me, EventArgs.Empty)
        End If
        If e.KeyChar = ChrW(stoppingKey) Then 'Stops the autoclicker if the stopping key is pressed
            Call stopButton_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub minTime_TextChanged(sender As Object, e As EventArgs) Handles minTime.TextChanged
        Dim dummy As Double
        Dim dummyInt As Integer

        If Not Double.TryParse(minTime.Text, dummy) Then
            Me.Height = 285
            errorLabel.Text = "Error: The minimum time must be a number."
            errorLabel.Visible = True
            minTime.BackColor = Color.Red

        Else If Not Integer.TryParse(minTime.Text, dummyInt) Then
            Me.Height = 285
            errorLabel.Text = "Error: The minimum time is too large."
            errorLabel.Visible = True
            minTime.BackColor = Color.Red


        ElseIf minTime.Text > maxTime.Text Then
            Me.Height = 285
            errorLabel.Text = "Error: The minimum time cannot exceed the maximum time."
            errorLabel.Visible = True
            minTime.BackColor = Color.Red

        Else
            Me.Height = 256
            minTime.BackColor = DefaultBackColor
            errorLabel.Visible = False
        End If
    End Sub

    Private Sub maxTime_TextChanged(sender As Object, e As EventArgs) Handles maxTime.TextChanged
        Dim dummy As Double

        If Not Double.TryParse(maxTime.Text, dummy) Then
            Me.Height = 285
            errorLabel.Text = "Error: The maximum time must be a number."
            errorLabel.Visible = True
            maxTime.BackColor = Color.Red

        ElseIf (maxTime.Text.Length >= maxLength) Then
            Me.Height = 285
            errorLabel.Text = "Error: The maximum time is too large."
            errorLabel.Visible = True
            maxTime.BackColor = Color.Red

        ElseIf minTime.Text > maxTime.Text Then
            Me.Height = 285
            errorLabel.Text = "Error: The minimum time cannot exceed the maximum time."
            errorLabel.Visible = True
            minTime.BackColor = Color.Red

        ElseIf minTime.Text <= maxTime.Text Then
            Me.Height = 256
            minTime.BackColor = DefaultBackColor
            errorLabel.Visible = False

        Else
        Me.Height = 256
        maxTime.BackColor = DefaultBackColor
        errorLabel.Visible = False
        End If
    End Sub

    Private Sub startKey_TextChanged(sender As Object, e As EventArgs) Handles startKey.TextChanged
        Dim dummy As Char

        If Not Char.TryParse(startKey.Text, dummy) Then
            Me.Height = 303
            errorLabel.Text = "Error: The starting button must be a single key."
            errorLabel.Visible = True
            startKey.BackColor = Color.Red
            Return
        End If

        If Char.TryParse(startKey.Text, dummy) Then
            Me.Height = 256
            startKey.BackColor = DefaultBackColor
            errorLabel.Visible = False
        End If
    End Sub

    Private Sub stopKey_TextChanged(sender As Object, e As EventArgs) Handles stopKey.TextChanged
        Dim dummy As Char

        If Not Char.TryParse(stopKey.Text, dummy) Then
            Me.Height = 303
            errorLabel.Text = "Error: The stopping button must be a single key."
            errorLabel.Visible = True
            stopKey.BackColor = Color.Red
            Return
        End If

        If Char.TryParse(stopKey.Text, dummy) Then
            Me.Height = 256
            stopKey.BackColor = DefaultBackColor
            errorLabel.Visible = False
        End If
    End Sub
End Class
