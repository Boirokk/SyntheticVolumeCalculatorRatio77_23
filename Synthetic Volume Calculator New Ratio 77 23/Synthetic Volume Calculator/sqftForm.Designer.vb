<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sqftForm
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
        Me.txtsqft = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtthick = New System.Windows.Forms.TextBox()
        Me.sqftSubmitbtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtsqft
        '
        Me.txtsqft.Location = New System.Drawing.Point(74, 50)
        Me.txtsqft.Name = "txtsqft"
        Me.txtsqft.Size = New System.Drawing.Size(100, 20)
        Me.txtsqft.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Square Ft."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Thickness"
        '
        'txtthick
        '
        Me.txtthick.Location = New System.Drawing.Point(262, 50)
        Me.txtthick.Name = "txtthick"
        Me.txtthick.Size = New System.Drawing.Size(100, 20)
        Me.txtthick.TabIndex = 4
        '
        'sqftSubmitbtn
        '
        Me.sqftSubmitbtn.Location = New System.Drawing.Point(287, 98)
        Me.sqftSubmitbtn.Name = "sqftSubmitbtn"
        Me.sqftSubmitbtn.Size = New System.Drawing.Size(75, 23)
        Me.sqftSubmitbtn.TabIndex = 5
        Me.sqftSubmitbtn.Text = "Submit"
        Me.sqftSubmitbtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "mm"
        '
        'sqftForm
        '
        Me.AcceptButton = Me.sqftSubmitbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 142)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sqftSubmitbtn)
        Me.Controls.Add(Me.txtthick)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsqft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "sqftForm"
        Me.Text = "Square Foot Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsqft As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtthick As TextBox
    Friend WithEvents sqftSubmitbtn As Button
    Friend WithEvents Label4 As Label
End Class
