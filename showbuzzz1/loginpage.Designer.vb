<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        Me.button_login = New System.Windows.Forms.Button()
        Me.label_login = New System.Windows.Forms.Label()
        Me.label_username = New System.Windows.Forms.Label()
        Me.label_password = New System.Windows.Forms.Label()
        Me.textbox_username = New System.Windows.Forms.TextBox()
        Me.textbox_password = New System.Windows.Forms.TextBox()
        Me.label_usertype = New System.Windows.Forms.Label()
        Me.combobox_usertype = New System.Windows.Forms.ComboBox()
        Me.button_reset = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.button_singn_up = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_login
        '
        Me.button_login.Location = New System.Drawing.Point(99, 363)
        Me.button_login.Margin = New System.Windows.Forms.Padding(4)
        Me.button_login.Name = "button_login"
        Me.button_login.Size = New System.Drawing.Size(133, 45)
        Me.button_login.TabIndex = 1
        Me.button_login.Text = "Login"
        Me.button_login.UseVisualStyleBackColor = True
        '
        'label_login
        '
        Me.label_login.AutoSize = True
        Me.label_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_login.Location = New System.Drawing.Point(93, 30)
        Me.label_login.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_login.Name = "label_login"
        Me.label_login.Size = New System.Drawing.Size(85, 31)
        Me.label_login.TabIndex = 2
        Me.label_login.Text = "Login"
        '
        'label_username
        '
        Me.label_username.AutoSize = True
        Me.label_username.Location = New System.Drawing.Point(94, 179)
        Me.label_username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_username.Name = "label_username"
        Me.label_username.Size = New System.Drawing.Size(110, 25)
        Me.label_username.TabIndex = 3
        Me.label_username.Text = "Username"
        '
        'label_password
        '
        Me.label_password.AutoSize = True
        Me.label_password.Location = New System.Drawing.Point(94, 275)
        Me.label_password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_password.Name = "label_password"
        Me.label_password.Size = New System.Drawing.Size(106, 25)
        Me.label_password.TabIndex = 4
        Me.label_password.Text = "Password"
        '
        'textbox_username
        '
        Me.textbox_username.Location = New System.Drawing.Point(335, 179)
        Me.textbox_username.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_username.Name = "textbox_username"
        Me.textbox_username.Size = New System.Drawing.Size(227, 31)
        Me.textbox_username.TabIndex = 5
        '
        'textbox_password
        '
        Me.textbox_password.Location = New System.Drawing.Point(335, 269)
        Me.textbox_password.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox_password.Name = "textbox_password"
        Me.textbox_password.Size = New System.Drawing.Size(227, 31)
        Me.textbox_password.TabIndex = 6
        '
        'label_usertype
        '
        Me.label_usertype.AutoSize = True
        Me.label_usertype.Location = New System.Drawing.Point(94, 92)
        Me.label_usertype.Name = "label_usertype"
        Me.label_usertype.Size = New System.Drawing.Size(104, 25)
        Me.label_usertype.TabIndex = 7
        Me.label_usertype.Text = "User type"
        '
        'combobox_usertype
        '
        Me.combobox_usertype.FormattingEnabled = True
        Me.combobox_usertype.Location = New System.Drawing.Point(335, 89)
        Me.combobox_usertype.Name = "combobox_usertype"
        Me.combobox_usertype.Size = New System.Drawing.Size(227, 33)
        Me.combobox_usertype.TabIndex = 8
        '
        'button_reset
        '
        Me.button_reset.Location = New System.Drawing.Point(455, 363)
        Me.button_reset.Margin = New System.Windows.Forms.Padding(4)
        Me.button_reset.Name = "button_reset"
        Me.button_reset.Size = New System.Drawing.Size(133, 45)
        Me.button_reset.TabIndex = 9
        Me.button_reset.Text = "Reset"
        Me.button_reset.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.button_singn_up)
        Me.Panel1.Controls.Add(Me.label_usertype)
        Me.Panel1.Controls.Add(Me.label_login)
        Me.Panel1.Controls.Add(Me.button_reset)
        Me.Panel1.Controls.Add(Me.combobox_usertype)
        Me.Panel1.Controls.Add(Me.textbox_password)
        Me.Panel1.Controls.Add(Me.button_login)
        Me.Panel1.Controls.Add(Me.label_username)
        Me.Panel1.Controls.Add(Me.label_password)
        Me.Panel1.Controls.Add(Me.textbox_username)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(382, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 475)
        Me.Panel1.TabIndex = 10
        '
        'button_singn_up
        '
        Me.button_singn_up.Location = New System.Drawing.Point(516, 16)
        Me.button_singn_up.Name = "button_singn_up"
        Me.button_singn_up.Size = New System.Drawing.Size(139, 45)
        Me.button_singn_up.TabIndex = 10
        Me.button_singn_up.Text = "Sign Up"
        Me.button_singn_up.UseVisualStyleBackColor = True
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.CWP__77_1
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "form_login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button_login As System.Windows.Forms.Button
    Friend WithEvents label_login As System.Windows.Forms.Label
    Friend WithEvents label_username As System.Windows.Forms.Label
    Friend WithEvents label_password As System.Windows.Forms.Label
    Friend WithEvents textbox_username As System.Windows.Forms.TextBox
    Friend WithEvents textbox_password As System.Windows.Forms.TextBox
    Friend WithEvents label_usertype As System.Windows.Forms.Label
    Friend WithEvents combobox_usertype As System.Windows.Forms.ComboBox
    Friend WithEvents button_reset As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents button_singn_up As System.Windows.Forms.Button

End Class
