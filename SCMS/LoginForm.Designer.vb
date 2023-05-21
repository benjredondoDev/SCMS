<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.username = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.usernameTxt = New System.Windows.Forms.TextBox()
        Me.passwordTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Constantia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.username.Location = New System.Drawing.Point(438, 127)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(136, 35)
        Me.username.TabIndex = 0
        Me.username.Text = "Username"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Font = New System.Drawing.Font("Constantia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.password.Location = New System.Drawing.Point(438, 206)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(128, 35)
        Me.password.TabIndex = 0
        Me.password.Text = "Password"
        '
        'usernameTxt
        '
        Me.usernameTxt.Location = New System.Drawing.Point(438, 165)
        Me.usernameTxt.Name = "usernameTxt"
        Me.usernameTxt.Size = New System.Drawing.Size(264, 27)
        Me.usernameTxt.TabIndex = 1
        Me.usernameTxt.Tag = "usernameTxt"
        '
        'passwordTxt
        '
        Me.passwordTxt.Location = New System.Drawing.Point(438, 244)
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.Size = New System.Drawing.Size(264, 27)
        Me.passwordTxt.TabIndex = 2
        Me.passwordTxt.Tag = "passwordTxt"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(438, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitBtn.Location = New System.Drawing.Point(586, 296)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(116, 38)
        Me.ExitBtn.TabIndex = 3
        Me.ExitBtn.Text = "Quit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(93, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(609, 53)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ISCP Club Management System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(51, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(381, 334)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SCMS.My.Resources.Resources.simple_gaming_screen_panel_overlay_design_with_blue_color_live_streaming_overlay_and_broadcast_border_image_with_blue_color_online_user_interface_with_abstract_shapes_free_png
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.passwordTxt)
        Me.Controls.Add(Me.usernameTxt)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username As Label
    Friend WithEvents password As Label
    Friend WithEvents usernameTxt As TextBox
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
