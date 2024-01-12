Public Class frmSalary

    'Calculate Employee Totals Button
    Private Sub btnHourlyCalculate_Click(sender As Object, e As EventArgs) Handles btnHourlyCalculate.Click
        'Declare Input Variables
        Dim strFirstName As String = txtFirstName.Text
        Dim strLastName As String = txtLastName.Text
        Dim strSalary As String = txtSalary.Text
        'Handle exception converting string to Double when field is left blank by Parsing the String to an Double
        Dim dblSalary As Double = Double.TryParse(strSalary, dblSalary)
        Dim strPriorGrossPay As String = txtPriorGrossPay.Text
        'Handle exception converting string to Double when field is left blank by Parsing the String to an Double
        Dim dblPriorGrossPay As Double = Double.TryParse(strPriorGrossPay, dblPriorGrossPay)

        'Declare Output Variables
        Dim dblGrossPay As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFedTax As Double
        Dim dblNetPay As Double

        'Declare SubTotal Variables
        Dim dblSSTax As Double
        Dim dblMCTax As Double

        'Set Boolean Validation
        Dim blnValidated As Boolean = True

        'Validate Inputs
        Validate_First_Name()
        Validate_Last_Name()
        Validate_Salary(dblSalary, blnValidated)
        Validate_Prior_Gross_Pay(dblPriorGrossPay, blnValidated)
        Validate_State(blnValidated)

        'Calculate Hourly Employee Totals
        If blnValidated Then
            dblGrossPay = CalculateSalaryGrossPay(dblSalary)
            dblSSTax = CalculateSSTax(dblGrossPay, dblPriorGrossPay)
            dblMCTax = CalculateMedicareTax(dblGrossPay)
            dblFICA = CalculateFICA(dblSSTax, dblMCTax)
            dblStateTax = CalculateStateTax(dblGrossPay)
            dblFedTax = CalculateFederalTax(dblGrossPay)
            dblNetPay = CalculateSalaryNetPay(dblGrossPay, dblFICA, dblStateTax, dblFedTax)
            Display_Output(dblGrossPay, dblFICA, dblStateTax, dblFedTax, dblNetPay)
        End If
    End Sub

    'Calculate State Tax
    Private Function CalculateStateTax(dblGrossPay As Double) As Double
        Dim dblStateTaxRate As Double
        Dim dblStateTax As Double

        If radOhio.Checked Then
            dblStateTaxRate = 0.065
        Else
            If radKentucky.Checked Then
                dblStateTaxRate = 0.06
            Else
                If radIndiana.Checked Then
                    dblStateTaxRate = 0.055
                End If
            End If
        End If

        dblStateTax = dblGrossPay * dblStateTaxRate

        Return dblStateTax

    End Function

    'Display Outputs
    Private Sub Display_Output(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTax As Double, ByVal dblFederalTax As Double, ByVal dblNetPay As Double)
        lblGrossPay.Text = dblGrossPay.ToString("C")
        lblFICA.Text = dblFICA.ToString("C")
        lblStateTax.Text = dblStateTax.ToString("C")
        lblFederalTax.Text = dblFederalTax.ToString("C")
        lblNetPay.Text = dblNetPay.ToString("C")
    End Sub

    'Validate First Name
    Private Sub Validate_First_Name()
        If txtFirstName.Text = String.Empty Then
            MessageBox.Show("First Name Must be Entered")
            txtFirstName.Focus()
            Exit Sub
        End If
    End Sub

    'Validate Last Name
    Private Sub Validate_Last_Name()
        If txtLastName.Text = String.Empty Then
            MessageBox.Show("Last Name Must be Entered")
            txtLastName.Focus()
            Exit Sub
        End If
    End Sub

    'Validate Salary
    Private Sub Validate_Salary(ByRef dblSalary As Double, ByRef blnValidated As Boolean)
        If Double.TryParse(txtSalary.Text, dblSalary) Then
            dblSalary = txtSalary.Text
            If dblSalary >= 1 Then
            Else
                MessageBox.Show("Salary Must be Greater than 1")
                txtSalary.Focus()
                blnValidated = False
            End If
        Else
            MessageBox.Show("Salary Must be Entered and be Numeric")
            txtSalary.Focus()
            blnValidated = False
        End If
    End Sub

    'Validate Prior Gross Pay
    Private Sub Validate_Prior_Gross_Pay(ByRef dblPriorGrossPay As Double, ByRef blnValidated As Boolean)
        If Double.TryParse(txtPriorGrossPay.Text, dblPriorGrossPay) Then
            dblPriorGrossPay = txtPriorGrossPay.Text
            If dblPriorGrossPay >= 0 Then
            Else
                MessageBox.Show("Prior Gross Pay Must be Greater than 0")
                txtPriorGrossPay.Focus()
                blnValidated = False
            End If
        Else
            MessageBox.Show("Prior Gross Pay Must be Numeric")
            txtPriorGrossPay.Focus()
            blnValidated = False
        End If
    End Sub

    'Validate State Selection
    Private Sub Validate_State(ByRef blnValidated)
        If radOhio.Checked = False Then
            If radKentucky.Checked = False Then
                If radIndiana.Checked = False Then
                    MessageBox.Show("State must be Selected")
                    blnValidated = False
                End If
            End If
        End If
    End Sub

    'Clear Inputs and Outputs
    Private Sub btnHourlyClear_Click(sender As Object, e As EventArgs) Handles btnHourlyClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtSalary.Clear()
        txtPriorGrossPay.Clear()
        lblGrossPay.ResetText()
        lblFICA.ResetText()
        lblStateTax.ResetText()
        lblFederalTax.ResetText()
        lblNetPay.ResetText()
        radOhio.Checked = False
        radKentucky.Checked = False
        radIndiana.Checked = False
        txtFirstName.Focus()
    End Sub

    'Exit Form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Please Select another Employee Type to Enter Payroll")
        Close()
    End Sub

    'Calculate Employee Totals Menu
    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        'Declare Input Variables
        Dim strFirstName As String = txtFirstName.Text
        Dim strLastName As String = txtLastName.Text
        Dim strSalary As String = txtSalary.Text
        'Handle exception converting string to Double when field is left blank by Parsing the String to an Double
        Dim dblSalary As Double = Double.TryParse(strSalary, dblSalary)
        Dim strPriorGrossPay As String = txtPriorGrossPay.Text
        'Handle exception converting string to Double when field is left blank by Parsing the String to an Double
        Dim dblPriorGrossPay As Double = Double.TryParse(strPriorGrossPay, dblPriorGrossPay)

        'Declare Output Variables
        Dim dblGrossPay As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFedTax As Double
        Dim dblNetPay As Double

        'Declare SubTotal Variables
        Dim dblSSTax As Double
        Dim dblMCTax As Double

        'Set Boolean Validation
        Dim blnValidated As Boolean = True

        'Validate Inputs
        Validate_First_Name()
        Validate_Last_Name()
        Validate_Salary(dblSalary, blnValidated)
        Validate_Prior_Gross_Pay(dblPriorGrossPay, blnValidated)
        Validate_State(blnValidated)

        'Calculate Hourly Employee Totals
        If blnValidated Then
            dblGrossPay = CalculateSalaryGrossPay(dblSalary)
            dblSSTax = CalculateSSTax(dblGrossPay, dblPriorGrossPay)
            dblMCTax = CalculateMedicareTax(dblGrossPay)
            dblFICA = CalculateFICA(dblSSTax, dblMCTax)
            dblStateTax = CalculateStateTax(dblGrossPay)
            dblFedTax = CalculateFederalTax(dblGrossPay)
            dblNetPay = CalculateSalaryNetPay(dblGrossPay, dblFICA, dblStateTax, dblFedTax)
            Display_Output(dblGrossPay, dblFICA, dblStateTax, dblFedTax, dblNetPay)
        End If
    End Sub

    'Clear Inputs and Outputs Menu
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtSalary.Clear()
        txtPriorGrossPay.Clear()
        lblGrossPay.ResetText()
        lblFICA.ResetText()
        lblStateTax.ResetText()
        lblFederalTax.ResetText()
        lblNetPay.ResetText()
        radOhio.Checked = False
        radKentucky.Checked = False
        radIndiana.Checked = False
        txtFirstName.Focus()
    End Sub

    'Exit Form Menu
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Please Select another Employee Type to Enter Payroll")
        Close()
    End Sub
End Class