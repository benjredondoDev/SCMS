<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadDataForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.cboSheet = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.printdataBtn = New System.Windows.Forms.Button()
        Me.LoadDataBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(855, 374)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filename"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(87, 392)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.ReadOnly = True
        Me.txtFileName.Size = New System.Drawing.Size(736, 27)
        Me.txtFileName.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(829, 391)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(33, 29)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'cboSheet
        '
        Me.cboSheet.FormattingEnabled = True
        Me.cboSheet.Location = New System.Drawing.Point(87, 437)
        Me.cboSheet.Name = "cboSheet"
        Me.cboSheet.Size = New System.Drawing.Size(151, 28)
        Me.cboSheet.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sheet"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(535, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Backup Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'printdataBtn
        '
        Me.printdataBtn.Location = New System.Drawing.Point(707, 486)
        Me.printdataBtn.Name = "printdataBtn"
        Me.printdataBtn.Size = New System.Drawing.Size(155, 29)
        Me.printdataBtn.TabIndex = 5
        Me.printdataBtn.Text = "Print Data"
        Me.printdataBtn.UseVisualStyleBackColor = True
        '
        'LoadDataBtn
        '
        Me.LoadDataBtn.Location = New System.Drawing.Point(361, 486)
        Me.LoadDataBtn.Name = "LoadDataBtn"
        Me.LoadDataBtn.Size = New System.Drawing.Size(155, 29)
        Me.LoadDataBtn.TabIndex = 5
        Me.LoadDataBtn.Text = "Load Database"
        Me.LoadDataBtn.UseVisualStyleBackColor = True
        '
        'LoadDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 527)
        Me.Controls.Add(Me.printdataBtn)
        Me.Controls.Add(Me.LoadDataBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboSheet)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "LoadDataForm"
        Me.Text = "Load Data"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents cboSheet As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents printdataBtn As Button
    Friend WithEvents LoadDataBtn As Button
End Class
