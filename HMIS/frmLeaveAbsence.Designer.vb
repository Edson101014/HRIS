<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeaveAbsence
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Textboxsearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.txtempsearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbalanceleave = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnodaysapplied = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtempname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtremainingdays = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.btnview = New System.Windows.Forms.Button()
        Me.dtgemplist = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 132)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1070, 407)
        Me.DataGridView1.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(638, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Search :"
        '
        'Textboxsearch
        '
        Me.Textboxsearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textboxsearch.Location = New System.Drawing.Point(705, 91)
        Me.Textboxsearch.Multiline = True
        Me.Textboxsearch.Name = "Textboxsearch"
        Me.Textboxsearch.Size = New System.Drawing.Size(234, 27)
        Me.Textboxsearch.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(343, 41)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "List of Approved Leave"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(972, 546)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 38)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 41)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "List of Pending Leave"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCancel.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(164, 310)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 38)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnApprove.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Location = New System.Drawing.Point(67, 310)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(91, 38)
        Me.btnApprove.TabIndex = 42
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'txtempsearch
        '
        Me.txtempsearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempsearch.Location = New System.Drawing.Point(684, 189)
        Me.txtempsearch.Multiline = True
        Me.txtempsearch.Name = "txtempsearch"
        Me.txtempsearch.Size = New System.Drawing.Size(234, 28)
        Me.txtempsearch.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbalanceleave)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtnodaysapplied)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtempname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtremainingdays)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Location = New System.Drawing.Point(519, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 69)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set the number of leave to the employee"
        '
        'txtbalanceleave
        '
        Me.txtbalanceleave.Enabled = False
        Me.txtbalanceleave.Location = New System.Drawing.Point(165, 46)
        Me.txtbalanceleave.Name = "txtbalanceleave"
        Me.txtbalanceleave.Size = New System.Drawing.Size(326, 20)
        Me.txtbalanceleave.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Balance of days(s)  leave :"
        '
        'txtnodaysapplied
        '
        Me.txtnodaysapplied.Location = New System.Drawing.Point(165, 77)
        Me.txtnodaysapplied.Name = "txtnodaysapplied"
        Me.txtnodaysapplied.Size = New System.Drawing.Size(326, 20)
        Me.txtnodaysapplied.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Number of days applied for:"
        '
        'txtempname
        '
        Me.txtempname.Enabled = False
        Me.txtempname.Location = New System.Drawing.Point(165, 20)
        Me.txtempname.Name = "txtempname"
        Me.txtempname.Size = New System.Drawing.Size(326, 20)
        Me.txtempname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Remaining day(s) of leave :"
        '
        'txtremainingdays
        '
        Me.txtremainingdays.Enabled = False
        Me.txtremainingdays.Location = New System.Drawing.Point(165, 104)
        Me.txtremainingdays.Name = "txtremainingdays"
        Me.txtremainingdays.Size = New System.Drawing.Size(326, 20)
        Me.txtremainingdays.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Employee's Name : "
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(119, 26)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(61, 15)
        Me.Label46.TabIndex = 25
        Me.Label46.Text = "Search :"
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnview.Location = New System.Drawing.Point(684, 502)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(89, 38)
        Me.btnview.TabIndex = 45
        Me.btnview.Text = "View"
        Me.btnview.UseVisualStyleBackColor = False
        '
        'dtgemplist
        '
        Me.dtgemplist.AllowUserToAddRows = False
        Me.dtgemplist.AllowUserToDeleteRows = False
        Me.dtgemplist.AllowUserToResizeColumns = False
        Me.dtgemplist.AllowUserToResizeRows = False
        Me.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgemplist.Location = New System.Drawing.Point(67, 132)
        Me.dtgemplist.Name = "dtgemplist"
        Me.dtgemplist.RowHeadersVisible = False
        Me.dtgemplist.RowTemplate.Height = 24
        Me.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgemplist.ShowCellToolTips = False
        Me.dtgemplist.Size = New System.Drawing.Size(872, 172)
        Me.dtgemplist.TabIndex = 39
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(179, 433)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 38)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Print to Preview"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmLeaveAbsence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1094, 641)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Textboxsearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.txtempsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.dtgemplist)
        Me.Controls.Add(Me.Button2)
        Me.Name = "frmLeaveAbsence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLeaveAbsence"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgemplist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Textboxsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApprove As System.Windows.Forms.Button
    Friend WithEvents txtempsearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbalanceleave As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnodaysapplied As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtempname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtremainingdays As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents dtgemplist As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
