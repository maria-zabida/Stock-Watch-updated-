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
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.tbCurrent = New System.Windows.Forms.TextBox()
        Me.tbOriginal = New System.Windows.Forms.TextBox()
        Me.tbShares = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblOriginal = New System.Windows.Forms.Label()
        Me.lblShares = New System.Windows.Forms.Label()
        Me.lblReset = New System.Windows.Forms.Button()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(65, 43)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(100, 23)
        Me.tbName.TabIndex = 0
        '
        'tbCurrent
        '
        Me.tbCurrent.Location = New System.Drawing.Point(65, 141)
        Me.tbCurrent.Name = "tbCurrent"
        Me.tbCurrent.Size = New System.Drawing.Size(100, 23)
        Me.tbCurrent.TabIndex = 1
        '
        'tbOriginal
        '
        Me.tbOriginal.Location = New System.Drawing.Point(65, 246)
        Me.tbOriginal.Name = "tbOriginal"
        Me.tbOriginal.Size = New System.Drawing.Size(100, 23)
        Me.tbOriginal.TabIndex = 2
        '
        'tbShares
        '
        Me.tbShares.Location = New System.Drawing.Point(65, 349)
        Me.tbShares.Name = "tbShares"
        Me.tbShares.Size = New System.Drawing.Size(100, 23)
        Me.tbShares.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalc.Location = New System.Drawing.Point(347, 141)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(150, 46)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(60, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(115, 25)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Stock Name"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCurrent.Location = New System.Drawing.Point(35, 113)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(175, 25)
        Me.lblCurrent.TabIndex = 6
        Me.lblCurrent.Text = "Current Stock Price"
        '
        'lblOriginal
        '
        Me.lblOriginal.AutoSize = True
        Me.lblOriginal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOriginal.Location = New System.Drawing.Point(32, 218)
        Me.lblOriginal.Name = "lblOriginal"
        Me.lblOriginal.Size = New System.Drawing.Size(178, 25)
        Me.lblOriginal.TabIndex = 7
        Me.lblOriginal.Text = "Original Stock Price"
        '
        'lblShares
        '
        Me.lblShares.AutoSize = True
        Me.lblShares.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblShares.Location = New System.Drawing.Point(32, 321)
        Me.lblShares.Name = "lblShares"
        Me.lblShares.Size = New System.Drawing.Size(167, 25)
        Me.lblShares.TabIndex = 8
        Me.lblShares.Text = "Number of Shares"
        '
        'lblReset
        '
        Me.lblReset.BackColor = System.Drawing.Color.LightCoral
        Me.lblReset.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblReset.Location = New System.Drawing.Point(564, 141)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(150, 46)
        Me.lblReset.TabIndex = 9
        Me.lblReset.Text = "Reset"
        Me.lblReset.UseVisualStyleBackColor = False
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNet.Location = New System.Drawing.Point(325, 218)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(409, 72)
        Me.lblNet.TabIndex = 10
        Me.lblNet.Text = "NET GAIN/LOSS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblReset)
        Me.Controls.Add(Me.lblShares)
        Me.Controls.Add(Me.lblOriginal)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.tbShares)
        Me.Controls.Add(Me.tbOriginal)
        Me.Controls.Add(Me.tbCurrent)
        Me.Controls.Add(Me.tbName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbName As TextBox
    Friend WithEvents tbCurrent As TextBox
    Friend WithEvents tbOriginal As TextBox
    Friend WithEvents tbShares As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents lblOriginal As Label
    Friend WithEvents lblShares As Label
    Friend WithEvents lblReset As Button
    Friend WithEvents lblNet As Label
    Friend WithEvents Label1 As Label
End Class
