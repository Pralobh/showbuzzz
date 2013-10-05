<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_signup))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label_password_error = New System.Windows.Forms.Label()
        Me.Label_userid_error = New System.Windows.Forms.Label()
        Me.Label_dob_validation = New System.Windows.Forms.Label()
        Me.label_reg_no_validation = New System.Windows.Forms.Label()
        Me.Label_error_reg_no = New System.Windows.Forms.Label()
        Me.label_acc_deatails = New System.Windows.Forms.Label()
        Me.label_dob = New System.Windows.Forms.Label()
        Me.datetimepicker_dob = New System.Windows.Forms.DateTimePicker()
        Me.label_emp_details = New System.Windows.Forms.Label()
        Me.button_signup = New System.Windows.Forms.Button()
        Me.button_reset = New System.Windows.Forms.Button()
        Me.textbox_confirm_password = New System.Windows.Forms.TextBox()
        Me.textbox_password = New System.Windows.Forms.TextBox()
        Me.textbox_userid = New System.Windows.Forms.TextBox()
        Me.textbox_last_name = New System.Windows.Forms.TextBox()
        Me.textbox_first_name = New System.Windows.Forms.TextBox()
        Me.textbox_reg_no = New System.Windows.Forms.TextBox()
        Me.label_confirm_password = New System.Windows.Forms.Label()
        Me.label_password = New System.Windows.Forms.Label()
        Me.label_userid = New System.Windows.Forms.Label()
        Me.label_last_name = New System.Windows.Forms.Label()
        Me.label_first_name = New System.Windows.Forms.Label()
        Me.label_reg_no = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.Label_password_error)
        Me.Panel1.Controls.Add(Me.Label_userid_error)
        Me.Panel1.Controls.Add(Me.Label_dob_validation)
        Me.Panel1.Controls.Add(Me.label_reg_no_validation)
        Me.Panel1.Controls.Add(Me.Label_error_reg_no)
        Me.Panel1.Controls.Add(Me.label_acc_deatails)
        Me.Panel1.Controls.Add(Me.label_dob)
        Me.Panel1.Controls.Add(Me.datetimepicker_dob)
        Me.Panel1.Controls.Add(Me.label_emp_details)
        Me.Panel1.Controls.Add(Me.button_signup)
        Me.Panel1.Controls.Add(Me.button_reset)
        Me.Panel1.Controls.Add(Me.textbox_confirm_password)
        Me.Panel1.Controls.Add(Me.textbox_password)
        Me.Panel1.Controls.Add(Me.textbox_userid)
        Me.Panel1.Controls.Add(Me.textbox_last_name)
        Me.Panel1.Controls.Add(Me.textbox_first_name)
        Me.Panel1.Controls.Add(Me.textbox_reg_no)
        Me.Panel1.Controls.Add(Me.label_confirm_password)
        Me.Panel1.Controls.Add(Me.label_password)
        Me.Panel1.Controls.Add(Me.label_userid)
        Me.Panel1.Controls.Add(Me.label_last_name)
        Me.Panel1.Controls.Add(Me.label_first_name)
        Me.Panel1.Controls.Add(Me.label_reg_no)
        Me.Panel1.Location = New System.Drawing.Point(311, 85)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 535)
        Me.Panel1.TabIndex = 0
        '
        'Label_password_error
        '
        Me.Label_password_error.AutoSize = True
        Me.Label_password_error.Location = New System.Drawing.Point(527, 374)
        Me.Label_password_error.Name = "Label_password_error"
        Me.Label_password_error.Size = New System.Drawing.Size(0, 25)
        Me.Label_password_error.TabIndex = 22
        '
        'Label_userid_error
        '
        Me.Label_userid_error.AutoSize = True
        Me.Label_userid_error.Location = New System.Drawing.Point(527, 335)
        Me.Label_userid_error.Name = "Label_userid_error"
        Me.Label_userid_error.Size = New System.Drawing.Size(0, 25)
        Me.Label_userid_error.TabIndex = 21
        '
        'Label_dob_validation
        '
        Me.Label_dob_validation.AutoSize = True
        Me.Label_dob_validation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_dob_validation.Location = New System.Drawing.Point(546, 227)
        Me.Label_dob_validation.Name = "Label_dob_validation"
        Me.Label_dob_validation.Size = New System.Drawing.Size(0, 16)
        Me.Label_dob_validation.TabIndex = 20
        '
        'label_reg_no_validation
        '
        Me.label_reg_no_validation.AutoSize = True
        Me.label_reg_no_validation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_reg_no_validation.Location = New System.Drawing.Point(553, 89)
        Me.label_reg_no_validation.Name = "label_reg_no_validation"
        Me.label_reg_no_validation.Size = New System.Drawing.Size(0, 16)
        Me.label_reg_no_validation.TabIndex = 19
        '
        'Label_error_reg_no
        '
        Me.Label_error_reg_no.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label_error_reg_no.AutoSize = True
        Me.Label_error_reg_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_error_reg_no.Location = New System.Drawing.Point(548, 89)
        Me.Label_error_reg_no.Name = "Label_error_reg_no"
        Me.Label_error_reg_no.Size = New System.Drawing.Size(0, 16)
        Me.Label_error_reg_no.TabIndex = 18
        '
        'label_acc_deatails
        '
        Me.label_acc_deatails.AutoSize = True
        Me.label_acc_deatails.Location = New System.Drawing.Point(73, 286)
        Me.label_acc_deatails.Name = "label_acc_deatails"
        Me.label_acc_deatails.Size = New System.Drawing.Size(240, 25)
        Me.label_acc_deatails.TabIndex = 17
        Me.label_acc_deatails.Text = "Enter  Account details  :"
        '
        'label_dob
        '
        Me.label_dob.AutoSize = True
        Me.label_dob.Location = New System.Drawing.Point(73, 233)
        Me.label_dob.Name = "label_dob"
        Me.label_dob.Size = New System.Drawing.Size(131, 25)
        Me.label_dob.TabIndex = 16
        Me.label_dob.Text = "Date of Birth"
        '
        'datetimepicker_dob
        '
        Me.datetimepicker_dob.CustomFormat = "dd/mm/yyyy"
        Me.datetimepicker_dob.Enabled = False
        Me.datetimepicker_dob.Location = New System.Drawing.Point(307, 227)
        Me.datetimepicker_dob.Name = "datetimepicker_dob"
        Me.datetimepicker_dob.Size = New System.Drawing.Size(213, 31)
        Me.datetimepicker_dob.TabIndex = 15
        '
        'label_emp_details
        '
        Me.label_emp_details.AutoSize = True
        Me.label_emp_details.Location = New System.Drawing.Point(73, 31)
        Me.label_emp_details.Name = "label_emp_details"
        Me.label_emp_details.Size = New System.Drawing.Size(248, 25)
        Me.label_emp_details.TabIndex = 14
        Me.label_emp_details.Text = "Enter Employee Details :"
        '
        'button_signup
        '
        Me.button_signup.Location = New System.Drawing.Point(92, 471)
        Me.button_signup.Name = "button_signup"
        Me.button_signup.Size = New System.Drawing.Size(160, 41)
        Me.button_signup.TabIndex = 13
        Me.button_signup.Text = "Sign up"
        Me.button_signup.UseVisualStyleBackColor = True
        '
        'button_reset
        '
        Me.button_reset.Location = New System.Drawing.Point(488, 465)
        Me.button_reset.Name = "button_reset"
        Me.button_reset.Size = New System.Drawing.Size(140, 41)
        Me.button_reset.TabIndex = 12
        Me.button_reset.Text = "Reset"
        Me.button_reset.UseVisualStyleBackColor = True
        '
        'textbox_confirm_password
        '
        Me.textbox_confirm_password.Location = New System.Drawing.Point(307, 428)
        Me.textbox_confirm_password.Name = "textbox_confirm_password"
        Me.textbox_confirm_password.ReadOnly = True
        Me.textbox_confirm_password.Size = New System.Drawing.Size(214, 31)
        Me.textbox_confirm_password.TabIndex = 11
        Me.textbox_confirm_password.UseSystemPasswordChar = True
        '
        'textbox_password
        '
        Me.textbox_password.Location = New System.Drawing.Point(307, 374)
        Me.textbox_password.Name = "textbox_password"
        Me.textbox_password.ReadOnly = True
        Me.textbox_password.Size = New System.Drawing.Size(214, 31)
        Me.textbox_password.TabIndex = 10
        Me.textbox_password.UseSystemPasswordChar = True
        '
        'textbox_userid
        '
        Me.textbox_userid.Location = New System.Drawing.Point(307, 332)
        Me.textbox_userid.Name = "textbox_userid"
        Me.textbox_userid.ReadOnly = True
        Me.textbox_userid.Size = New System.Drawing.Size(214, 31)
        Me.textbox_userid.TabIndex = 9
        '
        'textbox_last_name
        '
        Me.textbox_last_name.Location = New System.Drawing.Point(306, 170)
        Me.textbox_last_name.Name = "textbox_last_name"
        Me.textbox_last_name.ReadOnly = True
        Me.textbox_last_name.Size = New System.Drawing.Size(214, 31)
        Me.textbox_last_name.TabIndex = 8
        '
        'textbox_first_name
        '
        Me.textbox_first_name.Location = New System.Drawing.Point(307, 133)
        Me.textbox_first_name.Name = "textbox_first_name"
        Me.textbox_first_name.ReadOnly = True
        Me.textbox_first_name.Size = New System.Drawing.Size(214, 31)
        Me.textbox_first_name.TabIndex = 7
        '
        'textbox_reg_no
        '
        Me.textbox_reg_no.Location = New System.Drawing.Point(307, 89)
        Me.textbox_reg_no.Name = "textbox_reg_no"
        Me.textbox_reg_no.Size = New System.Drawing.Size(214, 31)
        Me.textbox_reg_no.TabIndex = 6
        '
        'label_confirm_password
        '
        Me.label_confirm_password.AutoSize = True
        Me.label_confirm_password.Location = New System.Drawing.Point(73, 434)
        Me.label_confirm_password.Name = "label_confirm_password"
        Me.label_confirm_password.Size = New System.Drawing.Size(186, 25)
        Me.label_confirm_password.TabIndex = 5
        Me.label_confirm_password.Text = "Confirm Password"
        '
        'label_password
        '
        Me.label_password.AutoSize = True
        Me.label_password.Location = New System.Drawing.Point(73, 380)
        Me.label_password.Name = "label_password"
        Me.label_password.Size = New System.Drawing.Size(106, 25)
        Me.label_password.TabIndex = 4
        Me.label_password.Text = "Password"
        '
        'label_userid
        '
        Me.label_userid.AutoSize = True
        Me.label_userid.Location = New System.Drawing.Point(73, 332)
        Me.label_userid.Name = "label_userid"
        Me.label_userid.Size = New System.Drawing.Size(80, 25)
        Me.label_userid.TabIndex = 3
        Me.label_userid.Text = "User id"
        '
        'label_last_name
        '
        Me.label_last_name.AutoSize = True
        Me.label_last_name.Location = New System.Drawing.Point(74, 185)
        Me.label_last_name.Name = "label_last_name"
        Me.label_last_name.Size = New System.Drawing.Size(115, 25)
        Me.label_last_name.TabIndex = 2
        Me.label_last_name.Text = "Last Name"
        '
        'label_first_name
        '
        Me.label_first_name.AutoSize = True
        Me.label_first_name.Location = New System.Drawing.Point(74, 139)
        Me.label_first_name.Name = "label_first_name"
        Me.label_first_name.Size = New System.Drawing.Size(116, 25)
        Me.label_first_name.TabIndex = 1
        Me.label_first_name.Text = "First Name"
        '
        'label_reg_no
        '
        Me.label_reg_no.AutoSize = True
        Me.label_reg_no.Location = New System.Drawing.Point(74, 95)
        Me.label_reg_no.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label_reg_no.Name = "label_reg_no"
        Me.label_reg_no.Size = New System.Drawing.Size(178, 25)
        Me.label_reg_no.TabIndex = 0
        Me.label_reg_no.Text = "Registration  No. "
        '
        'form_signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1370, 729)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "form_signup"
        Me.Text = "Signup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents label_reg_no As System.Windows.Forms.Label
    Friend WithEvents label_confirm_password As System.Windows.Forms.Label
    Friend WithEvents label_password As System.Windows.Forms.Label
    Friend WithEvents label_userid As System.Windows.Forms.Label
    Friend WithEvents label_last_name As System.Windows.Forms.Label
    Friend WithEvents label_first_name As System.Windows.Forms.Label
    Friend WithEvents textbox_confirm_password As System.Windows.Forms.TextBox
    Friend WithEvents textbox_password As System.Windows.Forms.TextBox
    Friend WithEvents textbox_userid As System.Windows.Forms.TextBox
    Friend WithEvents textbox_last_name As System.Windows.Forms.TextBox
    Friend WithEvents textbox_first_name As System.Windows.Forms.TextBox
    Friend WithEvents textbox_reg_no As System.Windows.Forms.TextBox
    Friend WithEvents label_dob As System.Windows.Forms.Label
    Friend WithEvents datetimepicker_dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_emp_details As System.Windows.Forms.Label
    Friend WithEvents button_signup As System.Windows.Forms.Button
    Friend WithEvents button_reset As System.Windows.Forms.Button
    Friend WithEvents label_acc_deatails As System.Windows.Forms.Label
    Friend WithEvents Label_error_reg_no As System.Windows.Forms.Label
    Friend WithEvents label_reg_no_validation As System.Windows.Forms.Label
    Friend WithEvents Label_dob_validation As System.Windows.Forms.Label
    Friend WithEvents Label_password_error As System.Windows.Forms.Label
    Friend WithEvents Label_userid_error As System.Windows.Forms.Label

    

End Class
