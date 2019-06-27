<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.labPass = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnForest = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnComposeNew = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNewAccount = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lbAccounts = New System.Windows.Forms.ListBox()
        Me.labUserSelected = New System.Windows.Forms.Label()
        Me.labDate = New System.Windows.Forms.Label()
        Me.labDateIndex = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbSearchResult = New System.Windows.Forms.ListBox()
        Me.btnCloselist = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForgotPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labPass
        '
        Me.labPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labPass.AutoSize = True
        Me.labPass.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.labPass.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPass.ForeColor = System.Drawing.Color.AliceBlue
        Me.labPass.Location = New System.Drawing.Point(639, 30)
        Me.labPass.Margin = New System.Windows.Forms.Padding(0)
        Me.labPass.Name = "labPass"
        Me.labPass.Size = New System.Drawing.Size(69, 13)
        Me.labPass.TabIndex = 1
        Me.labPass.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPassword.Location = New System.Drawing.Point(608, 54)
        Me.txtPassword.MaxLength = 25
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnForest
        '
        Me.btnForest.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnForest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForest.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnForest.Location = New System.Drawing.Point(38, 250)
        Me.btnForest.Name = "btnForest"
        Me.btnForest.Size = New System.Drawing.Size(106, 23)
        Me.btnForest.TabIndex = 4
        Me.btnForest.Text = "Forest"
        Me.btnForest.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.Location = New System.Drawing.Point(38, 221)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(106, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(38, 192)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnComposeNew
        '
        Me.btnComposeNew.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnComposeNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComposeNew.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComposeNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnComposeNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnComposeNew.Location = New System.Drawing.Point(38, 153)
        Me.btnComposeNew.Name = "btnComposeNew"
        Me.btnComposeNew.Size = New System.Drawing.Size(106, 33)
        Me.btnComposeNew.TabIndex = 7
        Me.btnComposeNew.Text = "Compose New"
        Me.btnComposeNew.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSearch.Location = New System.Drawing.Point(38, 49)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnNewAccount
        '
        Me.btnNewAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNewAccount.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnNewAccount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewAccount.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnNewAccount.Location = New System.Drawing.Point(711, 25)
        Me.btnNewAccount.Name = "btnNewAccount"
        Me.btnNewAccount.Size = New System.Drawing.Size(77, 23)
        Me.btnNewAccount.TabIndex = 9
        Me.btnNewAccount.Text = "New User"
        Me.btnNewAccount.UseVisualStyleBackColor = False
        '
        'btnLogIn
        '
        Me.btnLogIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogIn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogIn.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnLogIn.Location = New System.Drawing.Point(711, 52)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(77, 23)
        Me.btnLogIn.TabIndex = 10
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtSearch.Location = New System.Drawing.Point(145, 49)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(312, 21)
        Me.txtSearch.TabIndex = 11
        Me.txtSearch.Text = "Search your history"
        '
        'lbAccounts
        '
        Me.lbAccounts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbAccounts.FormattingEnabled = True
        Me.lbAccounts.Location = New System.Drawing.Point(500, 45)
        Me.lbAccounts.Name = "lbAccounts"
        Me.lbAccounts.Size = New System.Drawing.Size(96, 30)
        Me.lbAccounts.TabIndex = 13
        '
        'labUserSelected
        '
        Me.labUserSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labUserSelected.AutoSize = True
        Me.labUserSelected.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.labUserSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labUserSelected.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labUserSelected.ForeColor = System.Drawing.Color.AliceBlue
        Me.labUserSelected.Location = New System.Drawing.Point(459, 29)
        Me.labUserSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.labUserSelected.Name = "labUserSelected"
        Me.labUserSelected.Size = New System.Drawing.Size(137, 13)
        Me.labUserSelected.TabIndex = 15
        Me.labUserSelected.Text = "Select Your Account"
        '
        'labDate
        '
        Me.labDate.AutoSize = True
        Me.labDate.BackColor = System.Drawing.SystemColors.Window
        Me.labDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDate.Location = New System.Drawing.Point(38, 109)
        Me.labDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labDate.MinimumSize = New System.Drawing.Size(106, 0)
        Me.labDate.Name = "labDate"
        Me.labDate.Padding = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.labDate.Size = New System.Drawing.Size(106, 13)
        Me.labDate.TabIndex = 17
        Me.labDate.Text = "1/1/2000"
        Me.labDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labDateIndex
        '
        Me.labDateIndex.AutoSize = True
        Me.labDateIndex.BackColor = System.Drawing.SystemColors.Window
        Me.labDateIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDateIndex.Location = New System.Drawing.Point(38, 92)
        Me.labDateIndex.MinimumSize = New System.Drawing.Size(106, 0)
        Me.labDateIndex.Name = "labDateIndex"
        Me.labDateIndex.Size = New System.Drawing.Size(106, 17)
        Me.labDateIndex.TabIndex = 20
        Me.labDateIndex.Text = "Today's  Date"
        Me.labDateIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/YYYY"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(38, 127)
        Me.DateTimePicker1.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'lbSearchResult
        '
        Me.lbSearchResult.FormattingEnabled = True
        Me.lbSearchResult.Location = New System.Drawing.Point(151, 92)
        Me.lbSearchResult.Name = "lbSearchResult"
        Me.lbSearchResult.Size = New System.Drawing.Size(637, 186)
        Me.lbSearchResult.TabIndex = 26
        '
        'btnCloselist
        '
        Me.btnCloselist.Location = New System.Drawing.Point(763, 92)
        Me.btnCloselist.Name = "btnCloselist"
        Me.btnCloselist.Size = New System.Drawing.Size(25, 20)
        Me.btnCloselist.TabIndex = 28
        Me.btnCloselist.Text = "X"
        Me.btnCloselist.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccount.BackColor = System.Drawing.Color.HotPink
        Me.btnAccount.BackgroundImage = Global.nautureJournal.My.Resources.Resources._25Account
        Me.btnAccount.Image = Global.nautureJournal.My.Resources.Resources._25Account
        Me.btnAccount.Location = New System.Drawing.Point(462, 45)
        Me.btnAccount.Margin = New System.Windows.Forms.Padding(3, 3, 10, 10)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(25, 25)
        Me.btnAccount.TabIndex = 2
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 511)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 30
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.NewUserToolStripMenuItem, Me.ForgotPasswordToolStripMenuItem, Me.DeleteAccountToolStripMenuItem})
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'NewUserToolStripMenuItem
        '
        Me.NewUserToolStripMenuItem.Name = "NewUserToolStripMenuItem"
        Me.NewUserToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.NewUserToolStripMenuItem.Text = "New User"
        '
        'ForgotPasswordToolStripMenuItem
        '
        Me.ForgotPasswordToolStripMenuItem.Name = "ForgotPasswordToolStripMenuItem"
        Me.ForgotPasswordToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ForgotPasswordToolStripMenuItem.Text = "Forgot Password"
        '
        'DeleteAccountToolStripMenuItem
        '
        Me.DeleteAccountToolStripMenuItem.Name = "DeleteAccountToolStripMenuItem"
        Me.DeleteAccountToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DeleteAccountToolStripMenuItem.Text = "Delete Account"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 533)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnCloselist)
        Me.Controls.Add(Me.lbSearchResult)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.labDateIndex)
        Me.Controls.Add(Me.labDate)
        Me.Controls.Add(Me.labUserSelected)
        Me.Controls.Add(Me.lbAccounts)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnNewAccount)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnComposeNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnForest)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.labPass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Opacity = 0.96R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forest Journal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labPass As Label
    Friend WithEvents btnAccount As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnForest As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnComposeNew As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnNewAccount As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lbAccounts As ListBox
    Friend WithEvents labUserSelected As Label
    Friend WithEvents labDate As Label
    Friend WithEvents labDateIndex As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbSearchResult As ListBox
    Friend WithEvents btnCloselist As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForgotPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewUserToolStripMenuItem As ToolStripMenuItem
End Class
