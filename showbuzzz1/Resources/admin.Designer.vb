<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_admin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MoviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentMoviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMoviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMoviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrentsShowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddShowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteShowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScreensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Screen1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Screen2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Scrren3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActiveUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoviesToolStripMenuItem, Me.ShowsToolStripMenuItem, Me.ScreensToolStripMenuItem, Me.UsersToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MoviesToolStripMenuItem
        '
        Me.MoviesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentMoviesToolStripMenuItem, Me.AddMoviesToolStripMenuItem, Me.DeleteMoviesToolStripMenuItem})
        Me.MoviesToolStripMenuItem.Name = "MoviesToolStripMenuItem"
        Me.MoviesToolStripMenuItem.Size = New System.Drawing.Size(95, 34)
        Me.MoviesToolStripMenuItem.Text = "Movies"
        '
        'CurrentMoviesToolStripMenuItem
        '
        Me.CurrentMoviesToolStripMenuItem.Name = "CurrentMoviesToolStripMenuItem"
        Me.CurrentMoviesToolStripMenuItem.Size = New System.Drawing.Size(236, 34)
        Me.CurrentMoviesToolStripMenuItem.Text = "Current Movies"
        '
        'AddMoviesToolStripMenuItem
        '
        Me.AddMoviesToolStripMenuItem.Name = "AddMoviesToolStripMenuItem"
        Me.AddMoviesToolStripMenuItem.Size = New System.Drawing.Size(236, 34)
        Me.AddMoviesToolStripMenuItem.Text = "Add Movies"
        '
        'DeleteMoviesToolStripMenuItem
        '
        Me.DeleteMoviesToolStripMenuItem.Name = "DeleteMoviesToolStripMenuItem"
        Me.DeleteMoviesToolStripMenuItem.Size = New System.Drawing.Size(236, 34)
        Me.DeleteMoviesToolStripMenuItem.Text = "Delete Movies"
        '
        'ShowsToolStripMenuItem
        '
        Me.ShowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentsShowsToolStripMenuItem, Me.AddShowsToolStripMenuItem, Me.DeleteShowsToolStripMenuItem})
        Me.ShowsToolStripMenuItem.Name = "ShowsToolStripMenuItem"
        Me.ShowsToolStripMenuItem.Size = New System.Drawing.Size(89, 34)
        Me.ShowsToolStripMenuItem.Text = "Shows"
        '
        'CurrentsShowsToolStripMenuItem
        '
        Me.CurrentsShowsToolStripMenuItem.Name = "CurrentsShowsToolStripMenuItem"
        Me.CurrentsShowsToolStripMenuItem.Size = New System.Drawing.Size(239, 34)
        Me.CurrentsShowsToolStripMenuItem.Text = "Currents Shows"
        '
        'AddShowsToolStripMenuItem
        '
        Me.AddShowsToolStripMenuItem.Name = "AddShowsToolStripMenuItem"
        Me.AddShowsToolStripMenuItem.Size = New System.Drawing.Size(239, 34)
        Me.AddShowsToolStripMenuItem.Text = "Add Shows"
        '
        'DeleteShowsToolStripMenuItem
        '
        Me.DeleteShowsToolStripMenuItem.Name = "DeleteShowsToolStripMenuItem"
        Me.DeleteShowsToolStripMenuItem.Size = New System.Drawing.Size(239, 34)
        Me.DeleteShowsToolStripMenuItem.Text = "Delete Shows"
        '
        'ScreensToolStripMenuItem
        '
        Me.ScreensToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Screen1ToolStripMenuItem, Me.Screen2ToolStripMenuItem, Me.Scrren3ToolStripMenuItem})
        Me.ScreensToolStripMenuItem.Name = "ScreensToolStripMenuItem"
        Me.ScreensToolStripMenuItem.Size = New System.Drawing.Size(99, 34)
        Me.ScreensToolStripMenuItem.Text = "Screens"
        '
        'Screen1ToolStripMenuItem
        '
        Me.Screen1ToolStripMenuItem.Name = "Screen1ToolStripMenuItem"
        Me.Screen1ToolStripMenuItem.Size = New System.Drawing.Size(169, 34)
        Me.Screen1ToolStripMenuItem.Text = "Screen 1"
        '
        'Screen2ToolStripMenuItem
        '
        Me.Screen2ToolStripMenuItem.Name = "Screen2ToolStripMenuItem"
        Me.Screen2ToolStripMenuItem.Size = New System.Drawing.Size(169, 34)
        Me.Screen2ToolStripMenuItem.Text = "Screen 2"
        '
        'Scrren3ToolStripMenuItem
        '
        Me.Scrren3ToolStripMenuItem.Name = "Scrren3ToolStripMenuItem"
        Me.Scrren3ToolStripMenuItem.Size = New System.Drawing.Size(169, 34)
        Me.Scrren3ToolStripMenuItem.Text = "Scrren 3"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActiveUsersToolStripMenuItem, Me.UsersProfileToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(77, 34)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ActiveUsersToolStripMenuItem
        '
        Me.ActiveUsersToolStripMenuItem.Name = "ActiveUsersToolStripMenuItem"
        Me.ActiveUsersToolStripMenuItem.Size = New System.Drawing.Size(209, 34)
        Me.ActiveUsersToolStripMenuItem.Text = "Active Users"
        '
        'UsersProfileToolStripMenuItem
        '
        Me.UsersProfileToolStripMenuItem.Name = "UsersProfileToolStripMenuItem"
        Me.UsersProfileToolStripMenuItem.Size = New System.Drawing.Size(209, 34)
        Me.UsersProfileToolStripMenuItem.Text = "Users Profile"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(105, 34)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(258, 34)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(258, 34)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'form_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "form_admin"
        Me.Text = "Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MoviesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentMoviesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMoviesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteMoviesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentsShowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddShowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteShowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScreensToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Screen1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Screen2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Scrren3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActiveUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
