<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registry
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
        Dim btnRegistryClear As System.Windows.Forms.Button
        Dim btnRegistryHome As System.Windows.Forms.Button
        Me.lblRegistryTitle = New System.Windows.Forms.Label()
        Me.lblRegistryCusName = New System.Windows.Forms.Label()
        Me.lblRegistryGender = New System.Windows.Forms.Label()
        Me.lblRegistryContactNo = New System.Windows.Forms.Label()
        Me.lblCusAddress = New System.Windows.Forms.Label()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.txtCusAddress = New System.Windows.Forms.TextBox()
        Me.btnRegistryRegister = New System.Windows.Forms.Button()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.mtbContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.txtboxRegistryStaff = New System.Windows.Forms.TextBox()
        Me.lblRegistryStaff = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        btnRegistryClear = New System.Windows.Forms.Button()
        btnRegistryHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRegistryClear
        '
        btnRegistryClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnRegistryClear.Location = New System.Drawing.Point(305, 259)
        btnRegistryClear.Name = "btnRegistryClear"
        btnRegistryClear.Size = New System.Drawing.Size(111, 103)
        btnRegistryClear.TabIndex = 13
        btnRegistryClear.Text = "Clear"
        btnRegistryClear.UseVisualStyleBackColor = True
        AddHandler btnRegistryClear.Click, AddressOf Me.btnRegistryClear_Click
        '
        'btnRegistryHome
        '
        btnRegistryHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnRegistryHome.Location = New System.Drawing.Point(12, 298)
        btnRegistryHome.Name = "btnRegistryHome"
        btnRegistryHome.Size = New System.Drawing.Size(67, 63)
        btnRegistryHome.TabIndex = 16
        btnRegistryHome.Text = "Main Menu"
        btnRegistryHome.UseVisualStyleBackColor = True
        AddHandler btnRegistryHome.Click, AddressOf Me.Button1_Click
        '
        'lblRegistryTitle
        '
        Me.lblRegistryTitle.AutoSize = True
        Me.lblRegistryTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistryTitle.Location = New System.Drawing.Point(188, 40)
        Me.lblRegistryTitle.Name = "lblRegistryTitle"
        Me.lblRegistryTitle.Size = New System.Drawing.Size(267, 73)
        Me.lblRegistryTitle.TabIndex = 1
        Me.lblRegistryTitle.Text = "Registry"
        '
        'lblRegistryCusName
        '
        Me.lblRegistryCusName.AutoSize = True
        Me.lblRegistryCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistryCusName.Location = New System.Drawing.Point(30, 119)
        Me.lblRegistryCusName.Name = "lblRegistryCusName"
        Me.lblRegistryCusName.Size = New System.Drawing.Size(152, 24)
        Me.lblRegistryCusName.TabIndex = 3
        Me.lblRegistryCusName.Text = "Customer Name:"
        '
        'lblRegistryGender
        '
        Me.lblRegistryGender.AutoSize = True
        Me.lblRegistryGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistryGender.Location = New System.Drawing.Point(103, 154)
        Me.lblRegistryGender.Name = "lblRegistryGender"
        Me.lblRegistryGender.Size = New System.Drawing.Size(79, 24)
        Me.lblRegistryGender.TabIndex = 4
        Me.lblRegistryGender.Text = "Gender:"
        '
        'lblRegistryContactNo
        '
        Me.lblRegistryContactNo.AutoSize = True
        Me.lblRegistryContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistryContactNo.Location = New System.Drawing.Point(30, 194)
        Me.lblRegistryContactNo.Name = "lblRegistryContactNo"
        Me.lblRegistryContactNo.Size = New System.Drawing.Size(152, 24)
        Me.lblRegistryContactNo.TabIndex = 5
        Me.lblRegistryContactNo.Text = "Contact Number:"
        '
        'lblCusAddress
        '
        Me.lblCusAddress.AutoSize = True
        Me.lblCusAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusAddress.Location = New System.Drawing.Point(97, 227)
        Me.lblCusAddress.Name = "lblCusAddress"
        Me.lblCusAddress.Size = New System.Drawing.Size(85, 24)
        Me.lblCusAddress.TabIndex = 6
        Me.lblCusAddress.Text = "Address:"
        '
        'txtCusName
        '
        Me.txtCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(188, 116)
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(358, 29)
        Me.txtCusName.TabIndex = 8
        '
        'txtCusAddress
        '
        Me.txtCusAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusAddress.Location = New System.Drawing.Point(188, 224)
        Me.txtCusAddress.Name = "txtCusAddress"
        Me.txtCusAddress.Size = New System.Drawing.Size(358, 29)
        Me.txtCusAddress.TabIndex = 11
        '
        'btnRegistryRegister
        '
        Me.btnRegistryRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistryRegister.Location = New System.Drawing.Point(188, 259)
        Me.btnRegistryRegister.Name = "btnRegistryRegister"
        Me.btnRegistryRegister.Size = New System.Drawing.Size(111, 103)
        Me.btnRegistryRegister.TabIndex = 12
        Me.btnRegistryRegister.Text = "Register"
        Me.btnRegistryRegister.UseVisualStyleBackColor = True
        '
        'cboGender
        '
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(188, 151)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(358, 32)
        Me.cboGender.TabIndex = 14
        '
        'mtbContactNo
        '
        Me.mtbContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbContactNo.Location = New System.Drawing.Point(188, 189)
        Me.mtbContactNo.Mask = "000-0000000"
        Me.mtbContactNo.Name = "mtbContactNo"
        Me.mtbContactNo.Size = New System.Drawing.Size(358, 29)
        Me.mtbContactNo.TabIndex = 15
        '
        'txtboxRegistryStaff
        '
        Me.txtboxRegistryStaff.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxRegistryStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxRegistryStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxRegistryStaff.Location = New System.Drawing.Point(477, 10)
        Me.txtboxRegistryStaff.Name = "txtboxRegistryStaff"
        Me.txtboxRegistryStaff.ReadOnly = True
        Me.txtboxRegistryStaff.Size = New System.Drawing.Size(145, 29)
        Me.txtboxRegistryStaff.TabIndex = 41
        '
        'lblRegistryStaff
        '
        Me.lblRegistryStaff.AutoSize = True
        Me.lblRegistryStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistryStaff.Location = New System.Drawing.Point(322, 12)
        Me.lblRegistryStaff.Name = "lblRegistryStaff"
        Me.lblRegistryStaff.Size = New System.Drawing.Size(149, 24)
        Me.lblRegistryStaff.TabIndex = 40
        Me.lblRegistryStaff.Text = "Staff Logged In : "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(487, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 63)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Update Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Registry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 373)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtboxRegistryStaff)
        Me.Controls.Add(Me.lblRegistryStaff)
        Me.Controls.Add(btnRegistryHome)
        Me.Controls.Add(Me.mtbContactNo)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(btnRegistryClear)
        Me.Controls.Add(Me.btnRegistryRegister)
        Me.Controls.Add(Me.txtCusAddress)
        Me.Controls.Add(Me.txtCusName)
        Me.Controls.Add(Me.lblCusAddress)
        Me.Controls.Add(Me.lblRegistryContactNo)
        Me.Controls.Add(Me.lblRegistryGender)
        Me.Controls.Add(Me.lblRegistryCusName)
        Me.Controls.Add(Me.lblRegistryTitle)
        Me.Name = "Registry"
        Me.Text = "Registry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegistryTitle As Label
    Friend WithEvents lblRegistryCusName As Label
    Friend WithEvents lblRegistryGender As Label
    Friend WithEvents lblRegistryContactNo As Label
    Friend WithEvents lblCusAddress As Label
    Friend WithEvents txtCusName As TextBox
    Friend WithEvents txtCusAddress As TextBox
    Friend WithEvents btnRegistryRegister As Button
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents mtbContactNo As MaskedTextBox
    Friend WithEvents txtboxRegistryStaff As TextBox
    Friend WithEvents lblRegistryStaff As Label
    Friend WithEvents Button1 As Button
End Class
