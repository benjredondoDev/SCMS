<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.ViewBtn = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.ShowEventBtn = New System.Windows.Forms.Button()
        Me.ShowClubBtn = New System.Windows.Forms.Button()
        Me.LoadDataBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(93, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(609, 53)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ISCP Club Management System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(386, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(498, 282)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SlateBlue
        Me.Label1.Font = New System.Drawing.Font("Constantia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(105, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome Admin!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(135, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MANAGE STUDENTS"
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.AddBtn.FlatAppearance.BorderSize = 10
        Me.AddBtn.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(105, 180)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(157, 46)
        Me.AddBtn.TabIndex = 5
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'RemoveBtn
        '
        Me.RemoveBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.RemoveBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.RemoveBtn.FlatAppearance.BorderSize = 10
        Me.RemoveBtn.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RemoveBtn.ForeColor = System.Drawing.Color.White
        Me.RemoveBtn.Location = New System.Drawing.Point(105, 232)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(157, 46)
        Me.RemoveBtn.TabIndex = 5
        Me.RemoveBtn.Text = "Remove"
        Me.RemoveBtn.UseVisualStyleBackColor = False
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.UpdateBtn.FlatAppearance.BorderSize = 10
        Me.UpdateBtn.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.Location = New System.Drawing.Point(290, 180)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(157, 46)
        Me.UpdateBtn.TabIndex = 5
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'ViewBtn
        '
        Me.ViewBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ViewBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.ViewBtn.FlatAppearance.BorderSize = 10
        Me.ViewBtn.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ViewBtn.ForeColor = System.Drawing.Color.White
        Me.ViewBtn.Location = New System.Drawing.Point(290, 232)
        Me.ViewBtn.Name = "ViewBtn"
        Me.ViewBtn.Size = New System.Drawing.Size(157, 46)
        Me.ViewBtn.TabIndex = 5
        Me.ViewBtn.Text = "View"
        Me.ViewBtn.UseVisualStyleBackColor = False
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LogoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.LogoutBtn.FlatAppearance.BorderSize = 10
        Me.LogoutBtn.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LogoutBtn.Location = New System.Drawing.Point(692, 383)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(96, 46)
        Me.LogoutBtn.TabIndex = 5
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = False
        '
        'ShowEventBtn
        '
        Me.ShowEventBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ShowEventBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.ShowEventBtn.FlatAppearance.BorderSize = 10
        Me.ShowEventBtn.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowEventBtn.ForeColor = System.Drawing.Color.White
        Me.ShowEventBtn.Location = New System.Drawing.Point(290, 293)
        Me.ShowEventBtn.Name = "ShowEventBtn"
        Me.ShowEventBtn.Size = New System.Drawing.Size(157, 46)
        Me.ShowEventBtn.TabIndex = 5
        Me.ShowEventBtn.Text = "Show Events"
        Me.ShowEventBtn.UseVisualStyleBackColor = False
        '
        'ShowClubBtn
        '
        Me.ShowClubBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ShowClubBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.ShowClubBtn.FlatAppearance.BorderSize = 10
        Me.ShowClubBtn.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowClubBtn.ForeColor = System.Drawing.Color.White
        Me.ShowClubBtn.Location = New System.Drawing.Point(105, 293)
        Me.ShowClubBtn.Name = "ShowClubBtn"
        Me.ShowClubBtn.Size = New System.Drawing.Size(157, 46)
        Me.ShowClubBtn.TabIndex = 5
        Me.ShowClubBtn.Text = "Show Clubs"
        Me.ShowClubBtn.UseVisualStyleBackColor = False
        '
        'LoadDataBtn
        '
        Me.LoadDataBtn.BackColor = System.Drawing.Color.ForestGreen
        Me.LoadDataBtn.Font = New System.Drawing.Font("Constantia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LoadDataBtn.ForeColor = System.Drawing.Color.White
        Me.LoadDataBtn.Location = New System.Drawing.Point(105, 356)
        Me.LoadDataBtn.Name = "LoadDataBtn"
        Me.LoadDataBtn.Size = New System.Drawing.Size(157, 41)
        Me.LoadDataBtn.TabIndex = 6
        Me.LoadDataBtn.Text = "Load Data"
        Me.LoadDataBtn.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LoadDataBtn)
        Me.Controls.Add(Me.RemoveBtn)
        Me.Controls.Add(Me.LogoutBtn)
        Me.Controls.Add(Me.ShowClubBtn)
        Me.Controls.Add(Me.ShowEventBtn)
        Me.Controls.Add(Me.ViewBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddBtn As Button
    Friend WithEvents RemoveBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents ViewBtn As Button
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents ShowEventBtn As Button
    Friend WithEvents ShowClubBtn As Button
    Friend WithEvents LoadDataBtn As Button
End Class
