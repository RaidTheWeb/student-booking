<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentName = New System.Windows.Forms.TextBox()
        Me.StudentDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EngineeringRadio = New System.Windows.Forms.RadioButton()
        Me.InformationSystemsRadio = New System.Windows.Forms.RadioButton()
        Me.SoftwareDevelopmentRadio = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextCheckBox = New System.Windows.Forms.CheckBox()
        Me.CallCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmailCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StudentDetailSummary = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MaleRadio = New System.Windows.Forms.RadioButton()
        Me.FemaleRadio = New System.Windows.Forms.RadioButton()
        Me.OtherRadio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StudentPhoneNumber = New System.Windows.Forms.TextBox()
        Me.StudentEmailAddress = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Booking Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Full Name"
        '
        'StudentName
        '
        Me.StudentName.AccessibleName = ""
        Me.StudentName.Location = New System.Drawing.Point(204, 65)
        Me.StudentName.Name = "StudentName"
        Me.StudentName.Size = New System.Drawing.Size(283, 20)
        Me.StudentName.TabIndex = 2
        '
        'StudentDOB
        '
        Me.StudentDOB.Location = New System.Drawing.Point(204, 123)
        Me.StudentDOB.Name = "StudentDOB"
        Me.StudentDOB.Size = New System.Drawing.Size(283, 20)
        Me.StudentDOB.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Student Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Student Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Student Email Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Select a Course:"
        '
        'EngineeringRadio
        '
        Me.EngineeringRadio.AutoSize = True
        Me.EngineeringRadio.Location = New System.Drawing.Point(6, 31)
        Me.EngineeringRadio.Name = "EngineeringRadio"
        Me.EngineeringRadio.Size = New System.Drawing.Size(81, 17)
        Me.EngineeringRadio.TabIndex = 10
        Me.EngineeringRadio.TabStop = True
        Me.EngineeringRadio.Text = "Engineering"
        Me.EngineeringRadio.UseVisualStyleBackColor = True
        '
        'InformationSystemsRadio
        '
        Me.InformationSystemsRadio.AutoSize = True
        Me.InformationSystemsRadio.Location = New System.Drawing.Point(6, 10)
        Me.InformationSystemsRadio.Name = "InformationSystemsRadio"
        Me.InformationSystemsRadio.Size = New System.Drawing.Size(119, 17)
        Me.InformationSystemsRadio.TabIndex = 11
        Me.InformationSystemsRadio.TabStop = True
        Me.InformationSystemsRadio.Text = "Information Systems"
        Me.InformationSystemsRadio.UseVisualStyleBackColor = True
        '
        'SoftwareDevelopmentRadio
        '
        Me.SoftwareDevelopmentRadio.AutoSize = True
        Me.SoftwareDevelopmentRadio.Location = New System.Drawing.Point(6, 54)
        Me.SoftwareDevelopmentRadio.Name = "SoftwareDevelopmentRadio"
        Me.SoftwareDevelopmentRadio.Size = New System.Drawing.Size(133, 17)
        Me.SoftwareDevelopmentRadio.TabIndex = 12
        Me.SoftwareDevelopmentRadio.TabStop = True
        Me.SoftwareDevelopmentRadio.Text = "Software Development"
        Me.SoftwareDevelopmentRadio.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Communication Preferences:"
        '
        'TextCheckBox
        '
        Me.TextCheckBox.AutoSize = True
        Me.TextCheckBox.Location = New System.Drawing.Point(204, 342)
        Me.TextCheckBox.Name = "TextCheckBox"
        Me.TextCheckBox.Size = New System.Drawing.Size(47, 17)
        Me.TextCheckBox.TabIndex = 15
        Me.TextCheckBox.Text = "Text"
        Me.TextCheckBox.UseVisualStyleBackColor = True
        '
        'CallCheckBox
        '
        Me.CallCheckBox.AutoSize = True
        Me.CallCheckBox.Location = New System.Drawing.Point(204, 365)
        Me.CallCheckBox.Name = "CallCheckBox"
        Me.CallCheckBox.Size = New System.Drawing.Size(43, 17)
        Me.CallCheckBox.TabIndex = 16
        Me.CallCheckBox.Text = "Call"
        Me.CallCheckBox.UseVisualStyleBackColor = True
        '
        'EmailCheckBox
        '
        Me.EmailCheckBox.AutoSize = True
        Me.EmailCheckBox.Location = New System.Drawing.Point(204, 388)
        Me.EmailCheckBox.Name = "EmailCheckBox"
        Me.EmailCheckBox.Size = New System.Drawing.Size(51, 17)
        Me.EmailCheckBox.TabIndex = 17
        Me.EmailCheckBox.Text = "Email"
        Me.EmailCheckBox.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(60, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(427, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Submit Information"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StudentDetailSummary
        '
        Me.StudentDetailSummary.FormattingEnabled = True
        Me.StudentDetailSummary.Location = New System.Drawing.Point(60, 490)
        Me.StudentDetailSummary.Name = "StudentDetailSummary"
        Me.StudentDetailSummary.Size = New System.Drawing.Size(427, 173)
        Me.StudentDetailSummary.TabIndex = 20
        Me.StudentDetailSummary.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 474)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Student Detail Summary:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Student Gender"
        '
        'MaleRadio
        '
        Me.MaleRadio.AutoSize = True
        Me.MaleRadio.Location = New System.Drawing.Point(204, 95)
        Me.MaleRadio.Name = "MaleRadio"
        Me.MaleRadio.Size = New System.Drawing.Size(48, 17)
        Me.MaleRadio.TabIndex = 23
        Me.MaleRadio.TabStop = True
        Me.MaleRadio.Text = "Male"
        Me.MaleRadio.UseVisualStyleBackColor = True
        '
        'FemaleRadio
        '
        Me.FemaleRadio.AutoSize = True
        Me.FemaleRadio.Location = New System.Drawing.Point(258, 95)
        Me.FemaleRadio.Name = "FemaleRadio"
        Me.FemaleRadio.Size = New System.Drawing.Size(59, 17)
        Me.FemaleRadio.TabIndex = 24
        Me.FemaleRadio.TabStop = True
        Me.FemaleRadio.Text = "Female"
        Me.FemaleRadio.UseVisualStyleBackColor = True
        '
        'OtherRadio
        '
        Me.OtherRadio.AutoSize = True
        Me.OtherRadio.Location = New System.Drawing.Point(323, 95)
        Me.OtherRadio.Name = "OtherRadio"
        Me.OtherRadio.Size = New System.Drawing.Size(51, 17)
        Me.OtherRadio.TabIndex = 25
        Me.OtherRadio.TabStop = True
        Me.OtherRadio.Text = "Other"
        Me.OtherRadio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EngineeringRadio)
        Me.GroupBox1.Controls.Add(Me.InformationSystemsRadio)
        Me.GroupBox1.Controls.Add(Me.SoftwareDevelopmentRadio)
        Me.GroupBox1.Location = New System.Drawing.Point(204, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 77)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'StudentPhoneNumber
        '
        Me.StudentPhoneNumber.Location = New System.Drawing.Point(204, 160)
        Me.StudentPhoneNumber.MaxLength = 10
        Me.StudentPhoneNumber.Name = "StudentPhoneNumber"
        Me.StudentPhoneNumber.Size = New System.Drawing.Size(283, 20)
        Me.StudentPhoneNumber.TabIndex = 27
        '
        'StudentEmailAddress
        '
        Me.StudentEmailAddress.Location = New System.Drawing.Point(204, 195)
        Me.StudentEmailAddress.Name = "StudentEmailAddress"
        Me.StudentEmailAddress.Size = New System.Drawing.Size(283, 20)
        Me.StudentEmailAddress.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 675)
        Me.Controls.Add(Me.StudentEmailAddress)
        Me.Controls.Add(Me.StudentPhoneNumber)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OtherRadio)
        Me.Controls.Add(Me.FemaleRadio)
        Me.Controls.Add(Me.MaleRadio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StudentDetailSummary)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.EmailCheckBox)
        Me.Controls.Add(Me.CallCheckBox)
        Me.Controls.Add(Me.TextCheckBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StudentDOB)
        Me.Controls.Add(Me.StudentName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Student Booking Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StudentName As TextBox
    Friend WithEvents StudentDOB As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents EngineeringRadio As RadioButton
    Friend WithEvents InformationSystemsRadio As RadioButton
    Friend WithEvents SoftwareDevelopmentRadio As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents TextCheckBox As CheckBox
    Friend WithEvents CallCheckBox As CheckBox
    Friend WithEvents EmailCheckBox As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents StudentDetailSummary As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MaleRadio As RadioButton
    Friend WithEvents FemaleRadio As RadioButton
    Friend WithEvents OtherRadio As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StudentPhoneNumber As TextBox
    Friend WithEvents StudentEmailAddress As TextBox
End Class
