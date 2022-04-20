Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Form Loaded!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StudentDetailSummary.Items.Clear()
        Console.WriteLine("+====== Student Report ======+")
        StudentDetailSummary.Items.Add("Report for Student `" + StudentName.Text + "`")
        StudentDetailSummary.Items.Add("==================")

        If Not StudentName.Text.Trim().Equals("") Then
            Console.WriteLine("Name: " + StudentName.Text)
            StudentDetailSummary.Items.Add("Full Name: " + StudentName.Text)
        Else
            ' No Data (Throw Error!)
            MsgBox("Missing Data! (No Name Entered, Please Enter Your Full Name!)", vbCritical, "Required Data Not Found")
            Return ' Ensure we go no further
        End If

        Console.Write("Gender: ")
        If MaleRadio.Checked Then
            Console.WriteLine("Male")
            StudentDetailSummary.Items.Add("Gender: Male")
        ElseIf FemaleRadio.Checked Then
            Console.WriteLine("Female")
            StudentDetailSummary.Items.Add("Gender: Female")
        ElseIf OtherRadio.Checked Then
            Console.WriteLine("Other")
            StudentDetailSummary.Items.Add("Gender: Other")
        Else
            Console.WriteLine("None Selected!")
            ' No Data (Throw Error!)
            MsgBox("Missing Data! (No Gender Selected, Please Specify a Gender)", vbCritical, "Required Data Not Found")
            Return ' Ensure we go no further
        End If

        ' No need to handle missing data for date of birth (Will always have a default value)
        Console.WriteLine("DOB: " + StudentDOB.Text)
        StudentDetailSummary.Items.Add("Date of Birth: " + StudentDOB.Text)

        If Not StudentPhoneNumber.Text.Trim().Equals("") Then
            If Not StudentPhoneNumber.Text.Trim().Length = 10 Then
                ' Phone Number Is Invalid (Throw Error!)
                MsgBox("Invalid Data! (Phone Number Is Not Of Valid Length, Please Enter A Valid Phone Number!)", vbCritical, "Invalid Data Found")
                Return ' Ensure we go no further
            ElseIf Not IsNumeric(StudentPhoneNumber.Text) Then
                ' Phone Number Is Invalid (Throw Error!)
                MsgBox("Invalid Data! (Phone Number Is Not Numeric, Please Enter A Valid Phone Number!)", vbCritical, "Invalid Data Found")
                Return ' Ensure we go no further
            Else
                Console.WriteLine("Phone Number: " + StudentPhoneNumber.Text)
                StudentDetailSummary.Items.Add("Phone Number: " + StudentPhoneNumber.Text)
            End If
        Else
            ' No Data (Throw Error!)
            MsgBox("Missing Data! (No Phone Number Entered, Please Enter Your Phone Number!)", vbCritical, "Required Data Not Found")
            Return ' Ensure we go no further
        End If

        If Not StudentEmailAddress.Text.Trim().Equals("") Then
            Console.WriteLine("Email Address: " + StudentEmailAddress.Text)
            StudentDetailSummary.Items.Add("Email Address: " + StudentEmailAddress.Text)
        Else
            ' No Data (Throw Error!)
            MsgBox("Missing Data! (No Email Address Entered, Please Enter Your Email Address!)", vbCritical, "Required Data Not Found")
            Return ' Ensure we go no further
        End If

        Console.Write("Course Selection: ")
        If EngineeringRadio.Checked Then
            Console.WriteLine("Engineering")
            StudentDetailSummary.Items.Add("Course Selection: Engineering")
        ElseIf InformationSystemsRadio.Checked Then
            Console.WriteLine("Information Systems")
            StudentDetailSummary.Items.Add("Course Selection: Information Systems")
        ElseIf SoftwareDevelopmentRadio.Checked Then
            Console.WriteLine("Software Development")
            StudentDetailSummary.Items.Add("Course Selection: Software Development")
        Else
            Console.WriteLine("None Selected!")
            ' No Data (Throw Error!)
            MsgBox("Missing Data! (No Course Selected)", vbCritical, "Required Data Not Found")
            Return ' Ensure we go no further
        End If

        Dim commMethods As New System.Text.StringBuilder
        Console.Write("Preferred Method(s) of Communication: ")
        commMethods.Append("Preferred Method(s) of Communication: ")
        If TextCheckBox.Checked Then
            Console.Write("Text ")
            commMethods.Append("Text ")
        End If
        If CallCheckBox.Checked Then
            Console.Write("Call ")
            commMethods.Append("Call ")
        End If

        If EmailCheckBox.Checked Then
            Console.Write("Email ")
            commMethods.Append("Email ")
        End If

        If commMethods.ToString.Equals("Preferred Method(s) of Communication: ") Then
            ' No Data (Throw Error!)
            MsgBox("Missing Data! (No Communication Method Selected)", vbCritical, "Required Data Not Found")
            Return ' Ensure we go no further
        End If

        Console.WriteLine()
        StudentDetailSummary.Items.Add(commMethods.ToString)

        Dim confirmation As Integer
        confirmation = MsgBox("Are you sure you entered the correct data?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirm Validity")
        If confirmation = vbNo Then
            StudentDetailSummary.Items.Clear()
            Console.WriteLine("Data Invalidated!")
            Return
        Else
            Console.WriteLine("Data Validation Date: " + Date.Now.ToString)
        End If

        Console.WriteLine("+====== Student Report ======+")
    End Sub
End Class
