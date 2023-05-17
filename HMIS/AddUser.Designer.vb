<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.TextBoxUser = New System.Windows.Forms.TextBox()
        Me.TextBoxPass = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxUserID = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBoxUser
        '
        Me.TextBoxUser.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUser.Location = New System.Drawing.Point(197, 116)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(241, 26)
        Me.TextBoxUser.TabIndex = 2
        '
        'TextBoxPass
        '
        Me.TextBoxPass.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPass.Location = New System.Drawing.Point(197, 165)
        Me.TextBoxPass.Name = "TextBoxPass"
        Me.TextBoxPass.Size = New System.Drawing.Size(241, 26)
        Me.TextBoxPass.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Administrator", "Sub Admin"})
        Me.ComboBox1.Location = New System.Drawing.Point(197, 215)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(241, 28)
        Me.ComboBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "USERNAME: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PASSWORD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "AUTH LEVEL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "USER ID:"
        '
        'TextBoxUserID
        '
        Me.TextBoxUserID.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUserID.Location = New System.Drawing.Point(197, 37)
        Me.TextBoxUserID.MaxLength = 7
        Me.TextBoxUserID.Name = "TextBoxUserID"
        Me.TextBoxUserID.Size = New System.Drawing.Size(160, 26)
        Me.TextBoxUserID.TabIndex = 0
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Firebrick
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonCancel.Location = New System.Drawing.Point(268, 286)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(158, 48)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAdd.Location = New System.Drawing.Point(61, 286)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(173, 48)
        Me.ButtonAdd.TabIndex = 5
        Me.ButtonAdd.Text = "ADD"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Name:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(197, 77)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(241, 26)
        Me.TextBoxName.TabIndex = 1
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(467, 345)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxUserID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBoxPass)
        Me.Controls.Add(Me.TextBoxUser)
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxUser As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPass As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUserID As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
End Class
