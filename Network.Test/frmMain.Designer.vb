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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.btnTrain = New System.Windows.Forms.Button()
        Me.tbSampleSetA = New System.Windows.Forms.TextBox()
        Me.tbSampleSetB = New System.Windows.Forms.TextBox()
        Me.tbResult = New System.Windows.Forms.TextBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.btnAbort = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNetValues = New System.Windows.Forms.TextBox()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTrain
        '
        Me.btnTrain.Location = New System.Drawing.Point(12, 189)
        Me.btnTrain.Name = "btnTrain"
        Me.btnTrain.Size = New System.Drawing.Size(106, 29)
        Me.btnTrain.TabIndex = 0
        Me.btnTrain.Text = "Train"
        Me.btnTrain.UseVisualStyleBackColor = True
        '
        'tbSampleSetA
        '
        Me.tbSampleSetA.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSampleSetA.Location = New System.Drawing.Point(12, 42)
        Me.tbSampleSetA.Name = "tbSampleSetA"
        Me.tbSampleSetA.ReadOnly = True
        Me.tbSampleSetA.Size = New System.Drawing.Size(442, 22)
        Me.tbSampleSetA.TabIndex = 1
        Me.tbSampleSetA.Text = "1 2 3 4 5 6 7 8 9 10"
        Me.tbSampleSetA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSampleSetB
        '
        Me.tbSampleSetB.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSampleSetB.Location = New System.Drawing.Point(12, 85)
        Me.tbSampleSetB.Name = "tbSampleSetB"
        Me.tbSampleSetB.ReadOnly = True
        Me.tbSampleSetB.Size = New System.Drawing.Size(442, 22)
        Me.tbSampleSetB.TabIndex = 2
        Me.tbSampleSetB.Text = "1 2 3 4 5 6 7 8 9 10"
        Me.tbSampleSetB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbResult
        '
        Me.tbResult.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResult.Location = New System.Drawing.Point(12, 124)
        Me.tbResult.Name = "tbResult"
        Me.tbResult.ReadOnly = True
        Me.tbResult.Size = New System.Drawing.Size(442, 22)
        Me.tbResult.TabIndex = 3
        Me.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(236, 189)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(106, 29)
        Me.btnQuery.TabIndex = 5
        Me.btnQuery.Text = "Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'btnAbort
        '
        Me.btnAbort.Location = New System.Drawing.Point(124, 189)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(106, 29)
        Me.btnAbort.TabIndex = 6
        Me.btnAbort.Text = "Stop"
        Me.btnAbort.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(348, 189)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(106, 29)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Chart
        '
        Me.Chart.BackColor = System.Drawing.SystemColors.Control
        Me.Chart.BackSecondaryColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart.Legends.Add(Legend1)
        Me.Chart.Location = New System.Drawing.Point(12, 292)
        Me.Chart.Name = "Chart"
        Me.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Me.Chart.Size = New System.Drawing.Size(395, 260)
        Me.Chart.TabIndex = 8
        Me.Chart.Text = "Chart"
        Me.Chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "X Sequence"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Y Sequence"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Reference"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Output"
        '
        'tbNetValues
        '
        Me.tbNetValues.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNetValues.Location = New System.Drawing.Point(12, 163)
        Me.tbNetValues.Name = "tbNetValues"
        Me.tbNetValues.ReadOnly = True
        Me.tbNetValues.Size = New System.Drawing.Size(442, 22)
        Me.tbNetValues.TabIndex = 13
        Me.tbNetValues.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 564)
        Me.Controls.Add(Me.tbNetValues)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAbort)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.tbResult)
        Me.Controls.Add(Me.tbSampleSetB)
        Me.Controls.Add(Me.tbSampleSetA)
        Me.Controls.Add(Me.btnTrain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Network Test - Teaching Simple Math Sums"
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTrain As System.Windows.Forms.Button
    Friend WithEvents tbSampleSetA As System.Windows.Forms.TextBox
    Friend WithEvents tbSampleSetB As System.Windows.Forms.TextBox
    Friend WithEvents tbResult As System.Windows.Forms.TextBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents btnAbort As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbNetValues As System.Windows.Forms.TextBox

End Class
