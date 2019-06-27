<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JournalEdit
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
        Me.labDateIndex = New System.Windows.Forms.Label()
        Me.labTodayDate = New System.Windows.Forms.Label()
        Me.txtJournalHalfDay = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labDateIndex
        '
        Me.labDateIndex.AutoSize = True
        Me.labDateIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDateIndex.Location = New System.Drawing.Point(9, 9)
        Me.labDateIndex.Name = "labDateIndex"
        Me.labDateIndex.Size = New System.Drawing.Size(90, 17)
        Me.labDateIndex.TabIndex = 0
        Me.labDateIndex.Text = "Today's date"
        '
        'labTodayDate
        '
        Me.labTodayDate.AutoSize = True
        Me.labTodayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTodayDate.Location = New System.Drawing.Point(9, 32)
        Me.labTodayDate.Name = "labTodayDate"
        Me.labTodayDate.Size = New System.Drawing.Size(92, 13)
        Me.labTodayDate.TabIndex = 2
        Me.labTodayDate.Text = "Midday Journal"
        '
        'txtJournalHalfDay
        '
        Me.txtJournalHalfDay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtJournalHalfDay.Location = New System.Drawing.Point(12, 48)
        Me.txtJournalHalfDay.Multiline = True
        Me.txtJournalHalfDay.Name = "txtJournalHalfDay"
        Me.txtJournalHalfDay.Size = New System.Drawing.Size(404, 273)
        Me.txtJournalHalfDay.TabIndex = 3
        Me.txtJournalHalfDay.Tag = "midDay"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.nautureJournal.My.Resources.Resources.sbug
        Me.PictureBox1.Location = New System.Drawing.Point(107, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'JournalEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 333)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtJournalHalfDay)
        Me.Controls.Add(Me.labTodayDate)
        Me.Controls.Add(Me.labDateIndex)
        Me.Name = "JournalEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Joural Edit"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labDateIndex As Label
    Friend WithEvents labTodayDate As Label
    Friend WithEvents txtJournalHalfDay As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
