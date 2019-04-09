<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.minTime = New System.Windows.Forms.TextBox()
        Me.maxTime = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startButton = New System.Windows.Forms.Button()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.startKey = New System.Windows.Forms.TextBox()
        Me.stopKey = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.startTimer = New System.Windows.Forms.Timer(Me.components)
        Me.stopTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.submitKeys = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.errorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'minTime
        '
        Me.minTime.Location = New System.Drawing.Point(81, 7)
        Me.minTime.Name = "minTime"
        Me.minTime.Size = New System.Drawing.Size(78, 20)
        Me.minTime.TabIndex = 1
        Me.minTime.Text = "100"
        Me.minTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'maxTime
        '
        Me.maxTime.Location = New System.Drawing.Point(81, 34)
        Me.maxTime.Name = "maxTime"
        Me.maxTime.Size = New System.Drawing.Size(78, 20)
        Me.maxTime.TabIndex = 3
        Me.maxTime.Text = "100"
        Me.maxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "AT LEAST"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "AT MOST"
        '
        'startButton
        '
        Me.startButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startButton.Location = New System.Drawing.Point(12, 165)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(116, 43)
        Me.startButton.TabIndex = 6
        Me.startButton.Text = "START"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'stopButton
        '
        Me.stopButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.stopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.stopButton.Location = New System.Drawing.Point(156, 165)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(116, 43)
        Me.stopButton.TabIndex = 7
        Me.stopButton.Text = "STOP"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'startKey
        '
        Me.startKey.AccessibleName = "startKey"
        Me.startKey.Location = New System.Drawing.Point(13, 111)
        Me.startKey.Name = "startKey"
        Me.startKey.Size = New System.Drawing.Size(115, 20)
        Me.startKey.TabIndex = 8
        Me.startKey.Text = "a"
        '
        'stopKey
        '
        Me.stopKey.AccessibleName = "stopKey"
        Me.stopKey.Location = New System.Drawing.Point(156, 110)
        Me.stopKey.Name = "stopKey"
        Me.stopKey.Size = New System.Drawing.Size(116, 20)
        Me.stopKey.TabIndex = 9
        Me.stopKey.Text = "z"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "MILLISECONDS"
        '
        'startTimer
        '
        Me.startTimer.Interval = 1
        '
        'stopTimer
        '
        Me.stopTimer.Interval = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 214)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(168, 214)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'submitKeys
        '
        Me.submitKeys.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submitKeys.Location = New System.Drawing.Point(12, 136)
        Me.submitKeys.Name = "submitKeys"
        Me.submitKeys.Size = New System.Drawing.Size(260, 23)
        Me.submitKeys.TabIndex = 15
        Me.submitKeys.Text = "Submit Start/Stop Buttons"
        Me.submitKeys.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "MILLISECONDS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 65)
        Me.Label6.MaximumSize = New System.Drawing.Size(116, 43)
        Me.Label6.MinimumSize = New System.Drawing.Size(116, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 43)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Enter your starting button below:               (Letters or numbers)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Location = New System.Drawing.Point(165, 64)
        Me.Label7.MaximumSize = New System.Drawing.Size(116, 43)
        Me.Label7.MinimumSize = New System.Drawing.Size(116, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 43)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Enter your stopping button below:               (Letters or numbers)"
        '
        'errorLabel
        '
        Me.errorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorLabel.ForeColor = System.Drawing.Color.Red
        Me.errorLabel.Location = New System.Drawing.Point(10, 217)
        Me.errorLabel.Name = "errorLabel"
        Me.errorLabel.Size = New System.Drawing.Size(258, 57)
        Me.errorLabel.TabIndex = 21
        Me.errorLabel.Text = "Label3"
        Me.errorLabel.Visible = False
        '
        'Form1
        '
        Me.AcceptButton = Me.submitKeys
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.stopButton
        Me.ClientSize = New System.Drawing.Size(284, 218)
        Me.Controls.Add(Me.errorLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.submitKeys)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.stopKey)
        Me.Controls.Add(Me.startKey)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.maxTime)
        Me.Controls.Add(Me.minTime)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents minTime As TextBox
    Friend WithEvents maxTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents startButton As Button
    Friend WithEvents stopButton As Button
    Friend WithEvents startKey As TextBox
    Friend WithEvents stopKey As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents startTimer As Timer
    Friend WithEvents stopTimer As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents submitKeys As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents errorLabel As System.Windows.Forms.Label
End Class
