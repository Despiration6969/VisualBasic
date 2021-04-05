<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateInfo
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
        Dim btnUPMenu As System.Windows.Forms.Button
        Dim btnUPClear As System.Windows.Forms.Button
        Me.txtboxUPStaff = New System.Windows.Forms.TextBox()
        Me.lblUPStaff = New System.Windows.Forms.Label()
        Me.mtbUPContactNo = New System.Windows.Forms.MaskedTextBox()
        Me.cboUPGender = New System.Windows.Forms.ComboBox()
        Me.btnUPUpdate = New System.Windows.Forms.Button()
        Me.txtUPCusAddress = New System.Windows.Forms.TextBox()
        Me.txtUPCusName = New System.Windows.Forms.TextBox()
        Me.lblUPCusAddress = New System.Windows.Forms.Label()
        Me.lblUPContactNo = New System.Windows.Forms.Label()
        Me.lblUPGender = New System.Windows.Forms.Label()
        Me.lblUPCusName = New System.Windows.Forms.Label()
        Me.lblUpdateTitle = New System.Windows.Forms.Label()
        Me.DataGridViewUpdate = New System.Windows.Forms.DataGridView()
        Me.lblUPCusID = New System.Windows.Forms.Label()
        Me.txtUPCusID = New System.Windows.Forms.TextBox()
        btnUPMenu = New System.Windows.Forms.Button()
        btnUPClear = New System.Windows.Forms.Button()
        CType(Me.DataGridViewUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUPMenu
        '
        btnUPMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnUPMenu.Location = New System.Drawing.Point(285, 309)
        btnUPMenu.Name = "btnUPMenu"
        btnUPMenu.Size = New System.Drawing.Size(124, 103)
        btnUPMenu.TabIndex = 53
        btnUPMenu.Text = "Main Menu"
        btnUPMenu.UseVisualStyleBackColor = True
        AddHandler btnUPMenu.Click, AddressOf Me.btnRegistryHome_Click
        '
        'btnUPClear
        '
        btnUPClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnUPClear.Location = New System.Drawing.Point(415, 310)
        btnUPClear.Name = "btnUPClear"
        btnUPClear.Size = New System.Drawing.Size(111, 103)
        btnUPClear.TabIndex = 50
        btnUPClear.Text = "Clear"
        btnUPClear.UseVisualStyleBackColor = True
        AddHandler btnUPClear.Click, AddressOf Me.btnRegistryClear_Click
        '
        'txtboxUPStaff
        '
        Me.txtboxUPStaff.BackColor = System.Drawing.SystemColors.Menu
        Me.txtboxUPStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxUPStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxUPStaff.Location = New System.Drawing.Point(459, 9)
        Me.txtboxUPStaff.Name = "txtboxUPStaff"
        Me.txtboxUPStaff.ReadOnly = True
        Me.txtboxUPStaff.Size = New System.Drawing.Size(145, 29)
        Me.txtboxUPStaff.TabIndex = 55
        '
        'lblUPStaff
        '
        Me.lblUPStaff.AutoSize = True
        Me.lblUPStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPStaff.Location = New System.Drawing.Point(304, 11)
        Me.lblUPStaff.Name = "lblUPStaff"
        Me.lblUPStaff.Size = New System.Drawing.Size(149, 24)
        Me.lblUPStaff.TabIndex = 54
        Me.lblUPStaff.Text = "Staff Logged In : "
        '
        'mtbUPContactNo
        '
        Me.mtbUPContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbUPContactNo.Location = New System.Drawing.Point(168, 240)
        Me.mtbUPContactNo.Mask = "000-0000000"
        Me.mtbUPContactNo.Name = "mtbUPContactNo"
        Me.mtbUPContactNo.Size = New System.Drawing.Size(358, 29)
        Me.mtbUPContactNo.TabIndex = 52
        '
        'cboUPGender
        '
        Me.cboUPGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUPGender.FormattingEnabled = True
        Me.cboUPGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboUPGender.Location = New System.Drawing.Point(168, 202)
        Me.cboUPGender.Name = "cboUPGender"
        Me.cboUPGender.Size = New System.Drawing.Size(358, 32)
        Me.cboUPGender.TabIndex = 51
        '
        'btnUPUpdate
        '
        Me.btnUPUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUPUpdate.Location = New System.Drawing.Point(168, 310)
        Me.btnUPUpdate.Name = "btnUPUpdate"
        Me.btnUPUpdate.Size = New System.Drawing.Size(111, 103)
        Me.btnUPUpdate.TabIndex = 49
        Me.btnUPUpdate.Text = "Update"
        Me.btnUPUpdate.UseVisualStyleBackColor = True
        '
        'txtUPCusAddress
        '
        Me.txtUPCusAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPCusAddress.Location = New System.Drawing.Point(168, 275)
        Me.txtUPCusAddress.Name = "txtUPCusAddress"
        Me.txtUPCusAddress.Size = New System.Drawing.Size(358, 29)
        Me.txtUPCusAddress.TabIndex = 48
        '
        'txtUPCusName
        '
        Me.txtUPCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPCusName.Location = New System.Drawing.Point(168, 167)
        Me.txtUPCusName.Name = "txtUPCusName"
        Me.txtUPCusName.Size = New System.Drawing.Size(358, 29)
        Me.txtUPCusName.TabIndex = 47
        '
        'lblUPCusAddress
        '
        Me.lblUPCusAddress.AutoSize = True
        Me.lblUPCusAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPCusAddress.Location = New System.Drawing.Point(77, 278)
        Me.lblUPCusAddress.Name = "lblUPCusAddress"
        Me.lblUPCusAddress.Size = New System.Drawing.Size(85, 24)
        Me.lblUPCusAddress.TabIndex = 46
        Me.lblUPCusAddress.Text = "Address:"
        '
        'lblUPContactNo
        '
        Me.lblUPContactNo.AutoSize = True
        Me.lblUPContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPContactNo.Location = New System.Drawing.Point(10, 245)
        Me.lblUPContactNo.Name = "lblUPContactNo"
        Me.lblUPContactNo.Size = New System.Drawing.Size(152, 24)
        Me.lblUPContactNo.TabIndex = 45
        Me.lblUPContactNo.Text = "Contact Number:"
        '
        'lblUPGender
        '
        Me.lblUPGender.AutoSize = True
        Me.lblUPGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPGender.Location = New System.Drawing.Point(83, 205)
        Me.lblUPGender.Name = "lblUPGender"
        Me.lblUPGender.Size = New System.Drawing.Size(79, 24)
        Me.lblUPGender.TabIndex = 44
        Me.lblUPGender.Text = "Gender:"
        '
        'lblUPCusName
        '
        Me.lblUPCusName.AutoSize = True
        Me.lblUPCusName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPCusName.Location = New System.Drawing.Point(10, 170)
        Me.lblUPCusName.Name = "lblUPCusName"
        Me.lblUPCusName.Size = New System.Drawing.Size(152, 24)
        Me.lblUPCusName.TabIndex = 43
        Me.lblUPCusName.Text = "Customer Name:"
        '
        'lblUpdateTitle
        '
        Me.lblUpdateTitle.AutoSize = True
        Me.lblUpdateTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateTitle.Location = New System.Drawing.Point(169, 53)
        Me.lblUpdateTitle.Name = "lblUpdateTitle"
        Me.lblUpdateTitle.Size = New System.Drawing.Size(240, 73)
        Me.lblUpdateTitle.TabIndex = 42
        Me.lblUpdateTitle.Text = "Update"
        '
        'DataGridViewUpdate
        '
        Me.DataGridViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUpdate.Location = New System.Drawing.Point(558, 129)
        Me.DataGridViewUpdate.Name = "DataGridViewUpdate"
        Me.DataGridViewUpdate.Size = New System.Drawing.Size(574, 284)
        Me.DataGridViewUpdate.TabIndex = 58
        '
        'lblUPCusID
        '
        Me.lblUPCusID.AutoSize = True
        Me.lblUPCusID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPCusID.Location = New System.Drawing.Point(44, 134)
        Me.lblUPCusID.Name = "lblUPCusID"
        Me.lblUPCusID.Size = New System.Drawing.Size(118, 24)
        Me.lblUPCusID.TabIndex = 56
        Me.lblUPCusID.Text = "Customer ID:"
        '
        'txtUPCusID
        '
        Me.txtUPCusID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPCusID.Location = New System.Drawing.Point(168, 129)
        Me.txtUPCusID.Name = "txtUPCusID"
        Me.txtUPCusID.Size = New System.Drawing.Size(358, 29)
        Me.txtUPCusID.TabIndex = 59
        '
        'UpdateInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 424)
        Me.Controls.Add(Me.txtUPCusID)
        Me.Controls.Add(Me.DataGridViewUpdate)
        Me.Controls.Add(Me.lblUPCusID)
        Me.Controls.Add(Me.txtboxUPStaff)
        Me.Controls.Add(Me.lblUPStaff)
        Me.Controls.Add(btnUPMenu)
        Me.Controls.Add(Me.mtbUPContactNo)
        Me.Controls.Add(Me.cboUPGender)
        Me.Controls.Add(btnUPClear)
        Me.Controls.Add(Me.btnUPUpdate)
        Me.Controls.Add(Me.txtUPCusAddress)
        Me.Controls.Add(Me.txtUPCusName)
        Me.Controls.Add(Me.lblUPCusAddress)
        Me.Controls.Add(Me.lblUPContactNo)
        Me.Controls.Add(Me.lblUPGender)
        Me.Controls.Add(Me.lblUPCusName)
        Me.Controls.Add(Me.lblUpdateTitle)
        Me.Name = "UpdateInfo"
        Me.Text = "Update"
        CType(Me.DataGridViewUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxUPStaff As TextBox
    Friend WithEvents lblUPStaff As Label
    Friend WithEvents mtbUPContactNo As MaskedTextBox
    Friend WithEvents cboUPGender As ComboBox
    Friend WithEvents btnUPUpdate As Button
    Friend WithEvents txtUPCusAddress As TextBox
    Friend WithEvents txtUPCusName As TextBox
    Friend WithEvents lblUPCusAddress As Label
    Friend WithEvents lblUPContactNo As Label
    Friend WithEvents lblUPGender As Label
    Friend WithEvents lblUPCusName As Label
    Friend WithEvents lblUpdateTitle As Label
    Friend WithEvents DataGridViewUpdate As DataGridView
    Friend WithEvents lblUPCusID As Label
    Friend WithEvents txtUPCusID As TextBox
End Class
