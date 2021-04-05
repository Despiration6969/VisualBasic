<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnRegistryForm = New System.Windows.Forms.Button()
        Me.btnOrderForm = New System.Windows.Forms.Button()
        Me.lblStaffLoggedIn = New System.Windows.Forms.Label()
        Me.txtBoxStaffLoggedIn = New System.Windows.Forms.TextBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblMainMenuTItle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRegistryForm
        '
        Me.btnRegistryForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistryForm.Location = New System.Drawing.Point(12, 177)
        Me.btnRegistryForm.Name = "btnRegistryForm"
        Me.btnRegistryForm.Size = New System.Drawing.Size(215, 192)
        Me.btnRegistryForm.TabIndex = 0
        Me.btnRegistryForm.Text = "Registry"
        Me.btnRegistryForm.UseVisualStyleBackColor = True
        '
        'btnOrderForm
        '
        Me.btnOrderForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderForm.Location = New System.Drawing.Point(243, 177)
        Me.btnOrderForm.Name = "btnOrderForm"
        Me.btnOrderForm.Size = New System.Drawing.Size(215, 192)
        Me.btnOrderForm.TabIndex = 1
        Me.btnOrderForm.Text = "Order"
        Me.btnOrderForm.UseVisualStyleBackColor = True
        '
        'lblStaffLoggedIn
        '
        Me.lblStaffLoggedIn.AutoSize = True
        Me.lblStaffLoggedIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffLoggedIn.Location = New System.Drawing.Point(21, 118)
        Me.lblStaffLoggedIn.Name = "lblStaffLoggedIn"
        Me.lblStaffLoggedIn.Size = New System.Drawing.Size(149, 24)
        Me.lblStaffLoggedIn.TabIndex = 3
        Me.lblStaffLoggedIn.Text = "Staff Logged In : "
        '
        'txtBoxStaffLoggedIn
        '
        Me.txtBoxStaffLoggedIn.BackColor = System.Drawing.SystemColors.Menu
        Me.txtBoxStaffLoggedIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoxStaffLoggedIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxStaffLoggedIn.Location = New System.Drawing.Point(176, 116)
        Me.txtBoxStaffLoggedIn.Name = "txtBoxStaffLoggedIn"
        Me.txtBoxStaffLoggedIn.ReadOnly = True
        Me.txtBoxStaffLoggedIn.Size = New System.Drawing.Size(195, 29)
        Me.txtBoxStaffLoggedIn.TabIndex = 4
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(342, 375)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(116, 43)
        Me.btnHome.TabIndex = 5
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lblMainMenuTItle
        '
        Me.lblMainMenuTItle.AutoSize = True
        Me.lblMainMenuTItle.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenuTItle.Location = New System.Drawing.Point(12, 24)
        Me.lblMainMenuTItle.Name = "lblMainMenuTItle"
        Me.lblMainMenuTItle.Size = New System.Drawing.Size(349, 73)
        Me.lblMainMenuTItle.TabIndex = 6
        Me.lblMainMenuTItle.Text = "Main Menu"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 438)
        Me.Controls.Add(Me.lblMainMenuTItle)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.txtBoxStaffLoggedIn)
        Me.Controls.Add(Me.lblStaffLoggedIn)
        Me.Controls.Add(Me.btnOrderForm)
        Me.Controls.Add(Me.btnRegistryForm)
        Me.Name = "MainMenu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistryForm As Button
    Friend WithEvents btnOrderForm As Button
    Friend WithEvents lblStaffLoggedIn As Label
    Friend WithEvents txtBoxStaffLoggedIn As TextBox
    Friend WithEvents btnHome As Button
    Friend WithEvents lblMainMenuTItle As Label
End Class
