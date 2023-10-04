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
        btnSaySomething = New Button()
        btnCalculateAge = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' btnSaySomething
        ' 
        btnSaySomething.Location = New Point(334, 241)
        btnSaySomething.Name = "btnSaySomething"
        btnSaySomething.Size = New Size(131, 39)
        btnSaySomething.TabIndex = 0
        btnSaySomething.Text = "Say Something"
        btnSaySomething.UseVisualStyleBackColor = True
        ' 
        ' btnCalculateAge
        ' 
        btnCalculateAge.Location = New Point(331, 128)
        btnCalculateAge.Name = "btnCalculateAge"
        btnCalculateAge.Size = New Size(134, 45)
        btnCalculateAge.TabIndex = 1
        btnCalculateAge.Text = "Calculate Age"
        btnCalculateAge.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(350, 341)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnCalculateAge)
        Controls.Add(btnSaySomething)
        Name = "Form1"
        Text = "Working with Data"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSaySomething As Button
    Friend WithEvents btnCalculateAge As Button
    Friend WithEvents btnClose As Button
End Class
