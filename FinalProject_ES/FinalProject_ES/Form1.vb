Public Class frmMain
    'Calculate Payroll Button
    Private Sub btnCalculatePayroll_Click(sender As Object, e As EventArgs) Handles btnCalculatePayroll.Click
        If radSalary.Checked Then
            Dim frmSalary As New frmSalary
            frmSalary.ShowDialog()
        Else
            If radHourly.Checked Then
                Dim frmHourly As New frmHourly
                frmHourly.ShowDialog()
            Else
                MessageBox.Show("Employee Type Must be Selected")
            End If
        End If
    End Sub

    'Display Cumulative Daily Gross/Net Totals Hourly and Salary Button
    Private Sub btnDailyTotals_Click(sender As Object, e As EventArgs) Handles btnDailyTotals.Click
        Dim dblCombinedGross As Double
        Dim dblCombinedNet As Double

        dblCombinedGross = dblDailyHourlyGross + dblDailySalaryGross
        dblCombinedNet = dblDailyHourlyNet + dblDailySalaryNet

        MessageBox.Show("Daily Gross Totals = " + ("Hourly Gross " + dblDailyHourlyGross.ToString("C") + " - " + "Salary Gross " + dblDailySalaryGross.ToString("C") & vbCrLf & vbCrLf & "Daily Net Totals = " + ("Hourly Net " + dblDailyHourlyNet.ToString("C") + " - " + "Salary Net " + dblDailySalaryNet.ToString("C") & vbCrLf & vbCrLf & "Combined Daily Gross Total = " + dblCombinedGross.ToString("C") & vbCrLf & vbCrLf & "Combined Daily Net Total = " + dblCombinedNet.ToString("C"))))
    End Sub

    'Exit the Application Button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Thank you for Using " & vbCrLf & vbCrLf & "The Lick 2 The Stick Lollipop Company Payroll Program!")
        Close()
    End Sub

    'Calculate Payroll Menu
    Private Sub CalculatePayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatePayrollToolStripMenuItem.Click
        If radSalary.Checked Then
            Dim frmSalary As New frmSalary
            frmSalary.ShowDialog()
        Else
            If radHourly.Checked Then
                Dim frmHourly As New frmHourly
                frmHourly.ShowDialog()
            Else
                MessageBox.Show("Employee Type Must be Selected")
            End If
        End If
    End Sub

    'Calculate and Display Culmulative Daily Gross/Net Totals Hourly and Salary Menu
    Private Sub DailyTotalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyTotalsToolStripMenuItem.Click
        Dim dblCombinedGross As Double
        Dim dblCombinedNet As Double

        dblCombinedNet = dblDailyHourlyNet + dblDailySalaryNet
        dblCombinedGross = dblDailyHourlyGross + dblDailySalaryGross

        MessageBox.Show("Daily Gross Totals = " + ("Hourly Gross " + dblDailyHourlyGross.ToString("C") + " - " + "Salary Gross " + dblDailySalaryGross.ToString("C") & vbCrLf & vbCrLf & "Daily Net Totals = " + ("Hourly Net " + dblDailyHourlyNet.ToString("C") + " - " + "Salary Net " + dblDailySalaryNet.ToString("C") & vbCrLf & vbCrLf & "Combined Daily Gross Total = " + dblCombinedGross.ToString("C") & vbCrLf & vbCrLf & "Combined Daily Net Total = " + dblCombinedNet.ToString("C"))))
    End Sub

    'Exit the Application Menu
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Thank you for Using " & vbCrLf & vbCrLf & "The Lick 2 The Stick Lollipop Company Payroll Program!")
        Close()
    End Sub
End Class
