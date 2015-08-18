<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calcu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblMean = New System.Windows.Forms.TextBox()
        Me.lblStdDev = New System.Windows.Forms.TextBox()
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdComput = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Values"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mean"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Standard Deviation"
        '
        'lblNumber
        '
        Me.lblNumber.Location = New System.Drawing.Point(116, 21)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.ReadOnly = True
        Me.lblNumber.Size = New System.Drawing.Size(95, 20)
        Me.lblNumber.TabIndex = 4
        Me.lblNumber.Text = "0"
        Me.lblNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(116, 47)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(95, 20)
        Me.txtInput.TabIndex = 5
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMean
        '
        Me.lblMean.Location = New System.Drawing.Point(116, 150)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.ReadOnly = True
        Me.lblMean.Size = New System.Drawing.Size(95, 20)
        Me.lblMean.TabIndex = 6
        Me.lblMean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStdDev
        '
        Me.lblStdDev.Location = New System.Drawing.Point(116, 176)
        Me.lblStdDev.Name = "lblStdDev"
        Me.lblStdDev.ReadOnly = True
        Me.lblStdDev.Size = New System.Drawing.Size(95, 20)
        Me.lblStdDev.TabIndex = 7
        Me.lblStdDev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdAccept
        '
        Me.cmdAccept.Location = New System.Drawing.Point(15, 84)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(95, 23)
        Me.cmdAccept.TabIndex = 8
        Me.cmdAccept.Text = "&Accept Number"
        Me.cmdAccept.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(15, 113)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(95, 23)
        Me.cmdNew.TabIndex = 9
        Me.cmdNew.Text = "&New Sequence"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdComput
        '
        Me.cmdComput.Location = New System.Drawing.Point(116, 84)
        Me.cmdComput.Name = "cmdComput"
        Me.cmdComput.Size = New System.Drawing.Size(95, 23)
        Me.cmdComput.TabIndex = 10
        Me.cmdComput.Text = "&Compute"
        Me.cmdComput.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(116, 113)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(95, 23)
        Me.cmdExit.TabIndex = 11
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Calcu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 220)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdComput)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.lblStdDev)
        Me.Controls.Add(Me.lblMean)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Calcu"
        Me.Text = "Mean and Standard Deviation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents lblMean As System.Windows.Forms.TextBox
    Friend WithEvents lblStdDev As System.Windows.Forms.TextBox
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdComput As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button

End Class
