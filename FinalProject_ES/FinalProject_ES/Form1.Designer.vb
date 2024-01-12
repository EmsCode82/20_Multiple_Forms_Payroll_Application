<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSalary = New System.Windows.Forms.RadioButton()
        Me.radHourly = New System.Windows.Forms.RadioButton()
        Me.btnCalculatePayroll = New System.Windows.Forms.Button()
        Me.btnDailyTotals = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatePayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyTotalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSalary)
        Me.GroupBox1.Controls.Add(Me.radHourly)
        Me.GroupBox1.Location = New System.Drawing.Point(106, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Type"
        '
        'radSalary
        '
        Me.radSalary.AutoSize = True
        Me.radSalary.Location = New System.Drawing.Point(30, 19)
        Me.radSalary.Name = "radSalary"
        Me.radSalary.Size = New System.Drawing.Size(54, 17)
        Me.radSalary.TabIndex = 0
        Me.radSalary.Text = "Salary"
        Me.radSalary.UseVisualStyleBackColor = True
        '
        'radHourly
        '
        Me.radHourly.AutoSize = True
        Me.radHourly.Location = New System.Drawing.Point(30, 46)
        Me.radHourly.Name = "radHourly"
        Me.radHourly.Size = New System.Drawing.Size(55, 17)
        Me.radHourly.TabIndex = 1
        Me.radHourly.Text = "Hourly"
        Me.radHourly.UseVisualStyleBackColor = True
        '
        'btnCalculatePayroll
        '
        Me.btnCalculatePayroll.Location = New System.Drawing.Point(16, 113)
        Me.btnCalculatePayroll.Name = "btnCalculatePayroll"
        Me.btnCalculatePayroll.Size = New System.Drawing.Size(94, 23)
        Me.btnCalculatePayroll.TabIndex = 2
        Me.btnCalculatePayroll.Text = "Calculate Payroll"
        Me.btnCalculatePayroll.UseVisualStyleBackColor = True
        '
        'btnDailyTotals
        '
        Me.btnDailyTotals.Location = New System.Drawing.Point(116, 113)
        Me.btnDailyTotals.Name = "btnDailyTotals"
        Me.btnDailyTotals.Size = New System.Drawing.Size(94, 23)
        Me.btnDailyTotals.TabIndex = 3
        Me.btnDailyTotals.Text = "Daily Totals"
        Me.btnDailyTotals.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 113)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatePayrollToolStripMenuItem, Me.DailyTotalsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(45, 3)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(237, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculatePayrollToolStripMenuItem
        '
        Me.CalculatePayrollToolStripMenuItem.Name = "CalculatePayrollToolStripMenuItem"
        Me.CalculatePayrollToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.CalculatePayrollToolStripMenuItem.Text = "Calculate Payroll"
        '
        'DailyTotalsToolStripMenuItem
        '
        Me.DailyTotalsToolStripMenuItem.Name = "DailyTotalsToolStripMenuItem"
        Me.DailyTotalsToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.DailyTotalsToolStripMenuItem.Text = "Daily Totals"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 150)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDailyTotals)
        Me.Controls.Add(Me.btnCalculatePayroll)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "L2TSL Payroll"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSalary As RadioButton
    Friend WithEvents radHourly As RadioButton
    Friend WithEvents btnCalculatePayroll As Button
    Friend WithEvents btnDailyTotals As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculatePayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyTotalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
