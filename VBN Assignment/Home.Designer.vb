<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.lblHomeTitle = New System.Windows.Forms.Label()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.lblStaffPass = New System.Windows.Forms.Label()
        Me.txtboxStaffID = New System.Windows.Forms.TextBox()
        Me.txtboxStaffPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btmHomeClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHomeTitle
        '
        Me.lblHomeTitle.AutoSize = True
        Me.lblHomeTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeTitle.Location = New System.Drawing.Point(69, 9)
        Me.lblHomeTitle.Name = "lblHomeTitle"
        Me.lblHomeTitle.Size = New System.Drawing.Size(371, 73)
        Me.lblHomeTitle.TabIndex = 0
        Me.lblHomeTitle.Text = "Home Page"
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(12, 121)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(136, 24)
        Me.lblStaffID.TabIndex = 1
        Me.lblStaffID.Text = "Staff Username"
        '
        'lblStaffPass
        '
        Me.lblStaffPass.AutoSize = True
        Me.lblStaffPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffPass.Location = New System.Drawing.Point(17, 156)
        Me.lblStaffPass.Name = "lblStaffPass"
        Me.lblStaffPass.Size = New System.Drawing.Size(131, 24)
        Me.lblStaffPass.TabIndex = 2
        Me.lblStaffPass.Text = "Staff Password"
        '
        'txtboxStaffID
        '
        Me.txtboxStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxStaffID.Location = New System.Drawing.Point(154, 118)
        Me.txtboxStaffID.Name = "txtboxStaffID"
        Me.txtboxStaffID.Size = New System.Drawing.Size(358, 29)
        Me.txtboxStaffID.TabIndex = 3
        '
        'txtboxStaffPass
        '
        Me.txtboxStaffPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxStaffPass.Location = New System.Drawing.Point(154, 153)
        Me.txtboxStaffPass.Name = "txtboxStaffPass"
        Me.txtboxStaffPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtboxStaffPass.Size = New System.Drawing.Size(358, 29)
        Me.txtboxStaffPass.TabIndex = 4
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(154, 188)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(124, 103)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btmHomeClear
        '
        Me.btmHomeClear.Location = New System.Drawing.Point(388, 195)
        Me.btmHomeClear.Name = "btmHomeClear"
        Me.btmHomeClear.Size = New System.Drawing.Size(124, 103)
        Me.btmHomeClear.TabIndex = 6
        Me.btmHomeClear.Text = "Clear"
        Me.btmHomeClear.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 313)
        Me.Controls.Add(Me.btmHomeClear)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtboxStaffPass)
        Me.Controls.Add(Me.txtboxStaffID)
        Me.Controls.Add(Me.lblStaffPass)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.lblHomeTitle)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHomeTitle As Label
    Friend WithEvents lblStaffID As Label
    Friend WithEvents lblStaffPass As Label
    Friend WithEvents txtboxStaffID As TextBox
    Friend WithEvents txtboxStaffPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btmHomeClear As Button
End Class
