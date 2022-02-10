<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pb_HeadImage = New System.Windows.Forms.PictureBox
        Me.grp_GameLocation = New System.Windows.Forms.GroupBox
        Me.cg_PS_GameLocation = New System.Windows.Forms.Panel
        Me.txb_Location = New System.Windows.Forms.TextBox
        Me.lbl_GamePath = New System.Windows.Forms.Label
        Me.rtb_InfoText = New System.Windows.Forms.RichTextBox
        Me.rab_FromPath = New System.Windows.Forms.RadioButton
        Me.rab_FromRegistry = New System.Windows.Forms.RadioButton
        Me.cbx_CustomSplash = New System.Windows.Forms.CheckBox
        Me.cg_PS_SplashPath = New System.Windows.Forms.Panel
        Me.txb_SplashLocation = New System.Windows.Forms.TextBox
        Me.lbl_SplashPath = New System.Windows.Forms.Label
        Me.btn_Save = New System.Windows.Forms.Button
        Me.btn_Close = New System.Windows.Forms.Button
        Me.cg_FilesInfo = New System.Windows.Forms.Panel
        Me.lbl_ConfigFileStatus = New System.Windows.Forms.Label
        Me.lbl_DefFileStatus = New System.Windows.Forms.Label
        Me.lbl_ConfigFileLbl = New System.Windows.Forms.Label
        Me.lbl_DefFileLbl = New System.Windows.Forms.Label
        Me.cg_TermButtons = New System.Windows.Forms.Panel
        Me.lnk_GitHub = New System.Windows.Forms.LinkLabel
        CType(Me.pb_HeadImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_GameLocation.SuspendLayout()
        Me.cg_PS_GameLocation.SuspendLayout()
        Me.cg_PS_SplashPath.SuspendLayout()
        Me.cg_FilesInfo.SuspendLayout()
        Me.cg_TermButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pb_HeadImage
        '
        Me.pb_HeadImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb_HeadImage.Image = Global.FEConfigurator.My.Resources.Resources.header
        Me.pb_HeadImage.Location = New System.Drawing.Point(0, 0)
        Me.pb_HeadImage.Name = "pb_HeadImage"
        Me.pb_HeadImage.Size = New System.Drawing.Size(350, 125)
        Me.pb_HeadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_HeadImage.TabIndex = 0
        Me.pb_HeadImage.TabStop = False
        '
        'grp_GameLocation
        '
        Me.grp_GameLocation.Controls.Add(Me.cg_PS_GameLocation)
        Me.grp_GameLocation.Controls.Add(Me.rtb_InfoText)
        Me.grp_GameLocation.Controls.Add(Me.rab_FromPath)
        Me.grp_GameLocation.Controls.Add(Me.rab_FromRegistry)
        Me.grp_GameLocation.Location = New System.Drawing.Point(12, 131)
        Me.grp_GameLocation.Name = "grp_GameLocation"
        Me.grp_GameLocation.Size = New System.Drawing.Size(326, 152)
        Me.grp_GameLocation.TabIndex = 1
        Me.grp_GameLocation.TabStop = False
        Me.grp_GameLocation.Text = "Base Game Location"
        '
        'cg_PS_GameLocation
        '
        Me.cg_PS_GameLocation.Controls.Add(Me.txb_Location)
        Me.cg_PS_GameLocation.Controls.Add(Me.lbl_GamePath)
        Me.cg_PS_GameLocation.Location = New System.Drawing.Point(11, 65)
        Me.cg_PS_GameLocation.Name = "cg_PS_GameLocation"
        Me.cg_PS_GameLocation.Size = New System.Drawing.Size(308, 21)
        Me.cg_PS_GameLocation.TabIndex = 3
        '
        'txb_Location
        '
        Me.txb_Location.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txb_Location.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txb_Location.Location = New System.Drawing.Point(32, 0)
        Me.txb_Location.Name = "txb_Location"
        Me.txb_Location.ReadOnly = True
        Me.txb_Location.Size = New System.Drawing.Size(276, 20)
        Me.txb_Location.TabIndex = 1
        '
        'lbl_GamePath
        '
        Me.lbl_GamePath.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_GamePath.Location = New System.Drawing.Point(0, 0)
        Me.lbl_GamePath.Name = "lbl_GamePath"
        Me.lbl_GamePath.Size = New System.Drawing.Size(32, 21)
        Me.lbl_GamePath.TabIndex = 0
        Me.lbl_GamePath.Text = "Path"
        Me.lbl_GamePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtb_InfoText
        '
        Me.rtb_InfoText.Location = New System.Drawing.Point(6, 91)
        Me.rtb_InfoText.Name = "rtb_InfoText"
        Me.rtb_InfoText.ReadOnly = True
        Me.rtb_InfoText.Size = New System.Drawing.Size(314, 55)
        Me.rtb_InfoText.TabIndex = 4
        Me.rtb_InfoText.Text = ""
        '
        'rab_FromPath
        '
        Me.rab_FromPath.AutoSize = True
        Me.rab_FromPath.Location = New System.Drawing.Point(11, 42)
        Me.rab_FromPath.Name = "rab_FromPath"
        Me.rab_FromPath.Size = New System.Drawing.Size(109, 17)
        Me.rab_FromPath.TabIndex = 2
        Me.rab_FromPath.TabStop = True
        Me.rab_FromPath.Text = "Set path manually"
        Me.rab_FromPath.UseVisualStyleBackColor = True
        '
        'rab_FromRegistry
        '
        Me.rab_FromRegistry.AutoSize = True
        Me.rab_FromRegistry.Location = New System.Drawing.Point(11, 19)
        Me.rab_FromRegistry.Name = "rab_FromRegistry"
        Me.rab_FromRegistry.Size = New System.Drawing.Size(136, 17)
        Me.rab_FromRegistry.TabIndex = 1
        Me.rab_FromRegistry.TabStop = True
        Me.rab_FromRegistry.Text = "From Windows Registry"
        Me.rab_FromRegistry.UseVisualStyleBackColor = True
        '
        'cbx_CustomSplash
        '
        Me.cbx_CustomSplash.AutoSize = True
        Me.cbx_CustomSplash.Location = New System.Drawing.Point(12, 299)
        Me.cbx_CustomSplash.Name = "cbx_CustomSplash"
        Me.cbx_CustomSplash.Size = New System.Drawing.Size(115, 17)
        Me.cbx_CustomSplash.TabIndex = 2
        Me.cbx_CustomSplash.Text = "Use custom splash"
        Me.cbx_CustomSplash.UseVisualStyleBackColor = True
        '
        'cg_PS_SplashPath
        '
        Me.cg_PS_SplashPath.Controls.Add(Me.txb_SplashLocation)
        Me.cg_PS_SplashPath.Controls.Add(Me.lbl_SplashPath)
        Me.cg_PS_SplashPath.Location = New System.Drawing.Point(12, 322)
        Me.cg_PS_SplashPath.Name = "cg_PS_SplashPath"
        Me.cg_PS_SplashPath.Size = New System.Drawing.Size(319, 21)
        Me.cg_PS_SplashPath.TabIndex = 3
        '
        'txb_SplashLocation
        '
        Me.txb_SplashLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txb_SplashLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txb_SplashLocation.Location = New System.Drawing.Point(32, 0)
        Me.txb_SplashLocation.Name = "txb_SplashLocation"
        Me.txb_SplashLocation.ReadOnly = True
        Me.txb_SplashLocation.Size = New System.Drawing.Size(287, 20)
        Me.txb_SplashLocation.TabIndex = 1
        '
        'lbl_SplashPath
        '
        Me.lbl_SplashPath.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_SplashPath.Location = New System.Drawing.Point(0, 0)
        Me.lbl_SplashPath.Name = "lbl_SplashPath"
        Me.lbl_SplashPath.Size = New System.Drawing.Size(32, 21)
        Me.lbl_SplashPath.TabIndex = 0
        Me.lbl_SplashPath.Text = "Path"
        Me.lbl_SplashPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Save
        '
        Me.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(3, 4)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(156, 23)
        Me.btn_Save.TabIndex = 4
        Me.btn_Save.Text = "Save Configuration"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Close.Location = New System.Drawing.Point(270, 4)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 5
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'cg_FilesInfo
        '
        Me.cg_FilesInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cg_FilesInfo.Controls.Add(Me.lbl_ConfigFileStatus)
        Me.cg_FilesInfo.Controls.Add(Me.lbl_DefFileStatus)
        Me.cg_FilesInfo.Controls.Add(Me.lbl_ConfigFileLbl)
        Me.cg_FilesInfo.Controls.Add(Me.lbl_DefFileLbl)
        Me.cg_FilesInfo.Location = New System.Drawing.Point(12, 352)
        Me.cg_FilesInfo.Name = "cg_FilesInfo"
        Me.cg_FilesInfo.Size = New System.Drawing.Size(326, 71)
        Me.cg_FilesInfo.TabIndex = 6
        '
        'lbl_ConfigFileStatus
        '
        Me.lbl_ConfigFileStatus.AutoSize = True
        Me.lbl_ConfigFileStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_ConfigFileStatus.Location = New System.Drawing.Point(105, 38)
        Me.lbl_ConfigFileStatus.Name = "lbl_ConfigFileStatus"
        Me.lbl_ConfigFileStatus.Size = New System.Drawing.Size(61, 13)
        Me.lbl_ConfigFileStatus.TabIndex = 3
        Me.lbl_ConfigFileStatus.Text = "Checking..."
        '
        'lbl_DefFileStatus
        '
        Me.lbl_DefFileStatus.AutoSize = True
        Me.lbl_DefFileStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_DefFileStatus.Location = New System.Drawing.Point(105, 15)
        Me.lbl_DefFileStatus.Name = "lbl_DefFileStatus"
        Me.lbl_DefFileStatus.Size = New System.Drawing.Size(61, 13)
        Me.lbl_DefFileStatus.TabIndex = 2
        Me.lbl_DefFileStatus.Text = "Checking..."
        '
        'lbl_ConfigFileLbl
        '
        Me.lbl_ConfigFileLbl.AutoSize = True
        Me.lbl_ConfigFileLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_ConfigFileLbl.Location = New System.Drawing.Point(2, 38)
        Me.lbl_ConfigFileLbl.Name = "lbl_ConfigFileLbl"
        Me.lbl_ConfigFileLbl.Size = New System.Drawing.Size(89, 13)
        Me.lbl_ConfigFileLbl.TabIndex = 1
        Me.lbl_ConfigFileLbl.Text = "config.xml file:"
        '
        'lbl_DefFileLbl
        '
        Me.lbl_DefFileLbl.AutoSize = True
        Me.lbl_DefFileLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl_DefFileLbl.Location = New System.Drawing.Point(19, 15)
        Me.lbl_DefFileLbl.Name = "lbl_DefFileLbl"
        Me.lbl_DefFileLbl.Size = New System.Drawing.Size(72, 13)
        Me.lbl_DefFileLbl.TabIndex = 0
        Me.lbl_DefFileLbl.Text = "def.xml file:"
        '
        'cg_TermButtons
        '
        Me.cg_TermButtons.BackColor = System.Drawing.SystemColors.Window
        Me.cg_TermButtons.Controls.Add(Me.btn_Save)
        Me.cg_TermButtons.Controls.Add(Me.btn_Close)
        Me.cg_TermButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cg_TermButtons.Location = New System.Drawing.Point(0, 445)
        Me.cg_TermButtons.Name = "cg_TermButtons"
        Me.cg_TermButtons.Size = New System.Drawing.Size(350, 31)
        Me.cg_TermButtons.TabIndex = 7
        '
        'lnk_GitHub
        '
        Me.lnk_GitHub.AutoSize = True
        Me.lnk_GitHub.BackColor = System.Drawing.SystemColors.Control
        Me.lnk_GitHub.Location = New System.Drawing.Point(211, 286)
        Me.lnk_GitHub.Name = "lnk_GitHub"
        Me.lnk_GitHub.Size = New System.Drawing.Size(127, 13)
        Me.lnk_GitHub.TabIndex = 6
        Me.lnk_GitHub.TabStop = True
        Me.lnk_GitHub.Text = "FEConfigurator @ GitHub"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 476)
        Me.Controls.Add(Me.lnk_GitHub)
        Me.Controls.Add(Me.cg_TermButtons)
        Me.Controls.Add(Me.cg_FilesInfo)
        Me.Controls.Add(Me.cg_PS_SplashPath)
        Me.Controls.Add(Me.cbx_CustomSplash)
        Me.Controls.Add(Me.grp_GameLocation)
        Me.Controls.Add(Me.pb_HeadImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Fable Explorer Configurator"
        CType(Me.pb_HeadImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_GameLocation.ResumeLayout(False)
        Me.grp_GameLocation.PerformLayout()
        Me.cg_PS_GameLocation.ResumeLayout(False)
        Me.cg_PS_GameLocation.PerformLayout()
        Me.cg_PS_SplashPath.ResumeLayout(False)
        Me.cg_PS_SplashPath.PerformLayout()
        Me.cg_FilesInfo.ResumeLayout(False)
        Me.cg_FilesInfo.PerformLayout()
        Me.cg_TermButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_HeadImage As System.Windows.Forms.PictureBox
    Friend WithEvents grp_GameLocation As System.Windows.Forms.GroupBox
    Friend WithEvents rtb_InfoText As System.Windows.Forms.RichTextBox
    Friend WithEvents rab_FromPath As System.Windows.Forms.RadioButton
    Friend WithEvents rab_FromRegistry As System.Windows.Forms.RadioButton
    Friend WithEvents cg_PS_GameLocation As System.Windows.Forms.Panel
    Friend WithEvents txb_Location As System.Windows.Forms.TextBox
    Friend WithEvents lbl_GamePath As System.Windows.Forms.Label
    Friend WithEvents cbx_CustomSplash As System.Windows.Forms.CheckBox
    Friend WithEvents cg_PS_SplashPath As System.Windows.Forms.Panel
    Friend WithEvents txb_SplashLocation As System.Windows.Forms.TextBox
    Friend WithEvents lbl_SplashPath As System.Windows.Forms.Label
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents cg_FilesInfo As System.Windows.Forms.Panel
    Friend WithEvents cg_TermButtons As System.Windows.Forms.Panel
    Friend WithEvents lbl_ConfigFileLbl As System.Windows.Forms.Label
    Friend WithEvents lbl_DefFileLbl As System.Windows.Forms.Label
    Friend WithEvents lbl_ConfigFileStatus As System.Windows.Forms.Label
    Friend WithEvents lbl_DefFileStatus As System.Windows.Forms.Label
    Friend WithEvents lnk_GitHub As System.Windows.Forms.LinkLabel

End Class
