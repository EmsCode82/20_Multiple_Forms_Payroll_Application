Module modPayroll

    'Daily Global SubTotals for Gross Pay and Net Pay
    Public dblDailyHourlyGross As Double = 0
    Public dblDailyHourlyNet As Double = 0
    Public dblDailySalaryGross As Double = 0
    Public dblDailySalaryNet As Double = 0


    'Calculate Regular Hours
    Public Function CalculateRegHours(ByVal intHoursWorked As Integer) As Integer
        Dim intRegHours As Integer

        If intHoursWorked <= 40 Then
            intRegHours = intHoursWorked
        Else
            intRegHours = 40
        End If

        Return intRegHours

    End Function

    'Calculate Over Time Hours
    Public Function CalculateOverTimeHours(ByVal intHoursWorked As Integer) As Integer
        Dim intOTHours As Integer

        If intHoursWorked > 40 Then
            intOTHours = intHoursWorked - 40
        End If

        Return intOTHours

    End Function

    'Calculate Regular Pay
    Public Function CalculateRegPay(ByVal intRegHours As Integer, ByVal dblHourlyWage As Double) As Double
        Dim dblRegPay As Double

        dblRegPay = intRegHours * dblHourlyWage

        Return dblRegPay

    End Function

    'Calculate Over Time Pay
    Public Function CalculateOTPay(ByVal intOTHours As Integer, ByVal dblHourlyWage As Double) As Double
        Dim dblOTPay As Double

        dblOTPay = intOTHours * (dblHourlyWage * 1.5)

        Return dblOTPay

    End Function

    'Calculate Hourly Gross Pay
    Public Function CalculateHourlyGrossPay(ByVal dblOTPay As Double, ByVal dblRegPay As Double) As Double
        Dim dblGrossPay As Double

        dblGrossPay = dblOTPay + dblRegPay
        dblDailyHourlyGross += dblGrossPay

        Return dblGrossPay

    End Function

    'Calculate Salary Gross Pay
    Public Function CalculateSalaryGrossPay(ByVal dblSalary As Double) As Double
        Dim dblGrossPay As Double

        dblGrossPay = dblSalary / 52
        dblDailySalaryGross += dblGrossPay

        Return dblGrossPay

    End Function

    'Calculate Social Security Tax
    Public Function CalculateSSTax(ByVal dblGrossPay As Double, ByVal dblPriorGrossPay As Double) As Double
        Dim dblMaxSSEarnings As Double = 125000
        Dim dblSSRate As Double = 0.062
        Dim dblSSTax As Double

        dblGrossPay += dblPriorGrossPay

        If dblGrossPay < dblMaxSSEarnings Then
            dblSSTax = dblGrossPay * dblSSRate
        Else
            dblSSTax = dblMaxSSEarnings * dblSSRate
        End If

        Return dblSSTax

    End Function

    'Calculate Medicare Tax
    Public Function CalculateMedicareTax(ByVal dblGrossPay As Double) As Double
        Dim dblMCRate As Double = 0.0145
        Dim dblMCTax As Double

        dblMCTax = dblGrossPay * dblMCRate

        Return dblMCTax

    End Function

    'Calculate FICA
    Public Function CalculateFICA(ByVal dblSSTax As Double, ByVal dblMCTax As Double) As Double
        Dim dblFICA As Double

        dblFICA = dblSSTax + dblMCTax

        Return dblFICA

    End Function

    'Calculate Federal Tax
    Public Function CalculateFederalTax(ByVal dblGrossPay As Double) As Double
        Dim dblFedTax As Double

        If dblGrossPay <= 50 Then
            dblFedTax = 0
        Else
            If dblGrossPay > 50 Then
                If dblGrossPay <= 500 Then
                    dblFedTax = 0.1 * (dblGrossPay - 50)
                Else
                    If dblGrossPay <= 2500 Then
                        dblFedTax = 45 + 0.15 * (dblGrossPay - 500)
                    Else
                        If dblGrossPay <= 5000 Then
                            dblFedTax = 345 + 0.2 * (dblGrossPay - 2500)
                        Else
                            dblFedTax = 845 + 0.25 * (dblGrossPay - 5000)
                        End If
                    End If
                End If
            End If
        End If

        Return dblFedTax

    End Function

    'Calculate Hourly Net Pay
    Public Function CalculateHourlyNetPay(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTax As Double, ByVal dblFedTax As Double) As Double
        Dim dblNetPay As Double

        dblNetPay = dblGrossPay - (dblFICA + dblStateTax + dblFedTax)
        dblDailyHourlyNet += dblNetPay

        Return dblNetPay

    End Function

    'Calculate Salary Net Pay
    Public Function CalculateSalaryNetPay(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTax As Double, ByVal dblFedTax As Double) As Double
        Dim dblNetPay As Double

        dblNetPay = dblGrossPay - (dblFICA + dblStateTax + dblFedTax)
        dblDailySalaryNet += dblNetPay

        Return dblNetPay

    End Function

End Module
