<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartUp
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartUp))
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.White
        Me.username.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(420, 120)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(196, 24)
        Me.username.TabIndex = 0
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(420, 177)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(196, 24)
        Me.password.TabIndex = 1
        Me.password.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.RoyalBlue
        Me.login.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.login.FlatAppearance.BorderSize = 0
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.login.Font = New System.Drawing.Font("MS Reference Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.Location = New System.Drawing.Point(366, 256)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(169, 55)
        Me.login.TabIndex = 4
        Me.login.Text = "Log in"
        Me.login.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Brgy. Bagbag"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTime.Location = New System.Drawing.Point(327, 51)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(58, 19)
        Me.LabelTime.TabIndex = 8
        Me.LabelTime.Text = "Label4"
        Me.LabelTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(327, 79)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(58, 19)
        Me.LabelDate.TabIndex = 9
        Me.LabelDate.Text = "Label5"
        Me.LabelDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(280, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Date:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 296)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'StartUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(628, 330)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelDate)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(644, 368)
        Me.MinimumSize = New System.Drawing.Size(644, 368)
        Me.Name = "StartUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log-In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents login As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelTime As System.Windows.Forms.Label
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
