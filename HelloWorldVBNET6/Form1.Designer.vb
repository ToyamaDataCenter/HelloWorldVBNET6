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
        Dim Label1 As Label
        Dim lblFactorial As Label
        Dim lblAnswer As Label
        txtFactorial = New TextBox()
        btnCalculate = New Button()
        txtAnswer = New TextBox()
        Label1 = New Label()
        lblFactorial = New Label()
        lblAnswer = New Label()
        Me.SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 75)
        Label1.TabIndex = 0
        Label1.Text = "このプログラムは階乗を求めるプログラムです。" & vbCrLf & "階乗とは 1 から指定された数字まですべて掛け合わせたものです。" & vbCrLf & "例 : 6 の階乗 (数式 6!)" & vbCrLf & "6! = 1 * 2 * 3 * 4 * 5 * 6 = 720" & vbCrLf & vbCrLf
        ' 
        ' lblFactorial
        ' 
        lblFactorial.AutoSize = True
        lblFactorial.Location = New Point(12, 100)
        lblFactorial.Name = "lblFactorial"
        lblFactorial.Size = New Size(31, 15)
        lblFactorial.TabIndex = 4
        lblFactorial.Text = "階乗"
        ' 
        ' lblAnswer
        ' 
        lblAnswer.AutoSize = True
        lblAnswer.Location = New Point(153, 100)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.Size = New Size(28, 15)
        lblAnswer.TabIndex = 5
        lblAnswer.Text = "答え"
        ' 
        ' txtFactorial
        ' 
        txtFactorial.Location = New Point(12, 118)
        txtFactorial.Name = "txtFactorial"
        txtFactorial.Size = New Size(100, 23)
        txtFactorial.TabIndex = 1
        txtFactorial.Text = "0"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(12, 167)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "計算"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtAnswer
        ' 
        txtAnswer.Location = New Point(153, 118)
        txtAnswer.Name = "txtAnswer"
        txtAnswer.Size = New Size(100, 23)
        txtAnswer.TabIndex = 3
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(7F, 15F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(800, 450)
        Me.Controls.Add(lblAnswer)
        Me.Controls.Add(lblFactorial)
        Me.Controls.Add(txtAnswer)
        Me.Controls.Add(btnCalculate)
        Me.Controls.Add(txtFactorial)
        Me.Controls.Add(Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFactorial As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lblFactorial As Label
    Friend WithEvents lblAnswer As Label
End Class
