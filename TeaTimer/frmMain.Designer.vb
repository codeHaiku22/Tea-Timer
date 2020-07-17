<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.prgbarBrew = New System.Windows.Forms.ProgressBar()
        Me.cmdBrew = New System.Windows.Forms.Button()
        Me.trkbarMinutes = New System.Windows.Forms.TrackBar()
        Me.lblBrewTime = New System.Windows.Forms.Label()
        Me.tmrBrew = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpbxTeaType = New System.Windows.Forms.GroupBox()
        Me.rbHerbal = New System.Windows.Forms.RadioButton()
        Me.rbOolong = New System.Windows.Forms.RadioButton()
        Me.rbBlack = New System.Windows.Forms.RadioButton()
        Me.rbWhite = New System.Windows.Forms.RadioButton()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.lblBrewTemp = New System.Windows.Forms.Label()
        CType(Me.trkbarMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxTeaType.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "Tea Timer"
        Me.NotifyIcon1.Visible = True
        '
        'prgbarBrew
        '
        Me.prgbarBrew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prgbarBrew.Location = New System.Drawing.Point(9, 258)
        Me.prgbarBrew.Margin = New System.Windows.Forms.Padding(2)
        Me.prgbarBrew.Name = "prgbarBrew"
        Me.prgbarBrew.Size = New System.Drawing.Size(520, 35)
        Me.prgbarBrew.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgbarBrew.TabIndex = 1
        '
        'cmdBrew
        '
        Me.cmdBrew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBrew.Location = New System.Drawing.Point(179, 213)
        Me.cmdBrew.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdBrew.Name = "cmdBrew"
        Me.cmdBrew.Size = New System.Drawing.Size(200, 34)
        Me.cmdBrew.TabIndex = 3
        Me.cmdBrew.Text = "&Brew"
        Me.cmdBrew.UseVisualStyleBackColor = True
        '
        'trkbarMinutes
        '
        Me.trkbarMinutes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trkbarMinutes.LargeChange = 1
        Me.trkbarMinutes.Location = New System.Drawing.Point(9, 114)
        Me.trkbarMinutes.Margin = New System.Windows.Forms.Padding(2)
        Me.trkbarMinutes.Maximum = 5
        Me.trkbarMinutes.Name = "trkbarMinutes"
        Me.trkbarMinutes.Size = New System.Drawing.Size(518, 45)
        Me.trkbarMinutes.TabIndex = 4
        Me.trkbarMinutes.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblBrewTime
        '
        Me.lblBrewTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrewTime.Location = New System.Drawing.Point(179, 165)
        Me.lblBrewTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBrewTime.Name = "lblBrewTime"
        Me.lblBrewTime.Size = New System.Drawing.Size(200, 23)
        Me.lblBrewTime.TabIndex = 5
        Me.lblBrewTime.Text = "Brew Time: 0 minutes"
        Me.lblBrewTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrBrew
        '
        '
        'grpbxTeaType
        '
        Me.grpbxTeaType.Controls.Add(Me.rbHerbal)
        Me.grpbxTeaType.Controls.Add(Me.rbOolong)
        Me.grpbxTeaType.Controls.Add(Me.rbBlack)
        Me.grpbxTeaType.Controls.Add(Me.rbWhite)
        Me.grpbxTeaType.Controls.Add(Me.rbGreen)
        Me.grpbxTeaType.Location = New System.Drawing.Point(9, 10)
        Me.grpbxTeaType.Margin = New System.Windows.Forms.Padding(2)
        Me.grpbxTeaType.Name = "grpbxTeaType"
        Me.grpbxTeaType.Padding = New System.Windows.Forms.Padding(2)
        Me.grpbxTeaType.Size = New System.Drawing.Size(518, 91)
        Me.grpbxTeaType.TabIndex = 11
        Me.grpbxTeaType.TabStop = False
        '
        'rbHerbal
        '
        Me.rbHerbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHerbal.Image = Global.TeaTimer.My.Resources.Resources.herbal_tea
        Me.rbHerbal.Location = New System.Drawing.Point(431, 8)
        Me.rbHerbal.Margin = New System.Windows.Forms.Padding(2)
        Me.rbHerbal.Name = "rbHerbal"
        Me.rbHerbal.Size = New System.Drawing.Size(68, 80)
        Me.rbHerbal.TabIndex = 4
        Me.rbHerbal.TabStop = True
        Me.rbHerbal.Text = "Herbal"
        Me.rbHerbal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbHerbal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rbHerbal.UseVisualStyleBackColor = True
        '
        'rbOolong
        '
        Me.rbOolong.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOolong.Image = Global.TeaTimer.My.Resources.Resources.oolong_tea
        Me.rbOolong.Location = New System.Drawing.Point(328, 8)
        Me.rbOolong.Margin = New System.Windows.Forms.Padding(2)
        Me.rbOolong.Name = "rbOolong"
        Me.rbOolong.Size = New System.Drawing.Size(68, 80)
        Me.rbOolong.TabIndex = 3
        Me.rbOolong.TabStop = True
        Me.rbOolong.Text = "Oolong"
        Me.rbOolong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbOolong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rbOolong.UseVisualStyleBackColor = True
        '
        'rbBlack
        '
        Me.rbBlack.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBlack.Image = Global.TeaTimer.My.Resources.Resources.black_tea
        Me.rbBlack.Location = New System.Drawing.Point(225, 8)
        Me.rbBlack.Margin = New System.Windows.Forms.Padding(2)
        Me.rbBlack.Name = "rbBlack"
        Me.rbBlack.Size = New System.Drawing.Size(68, 80)
        Me.rbBlack.TabIndex = 2
        Me.rbBlack.TabStop = True
        Me.rbBlack.Text = "Black"
        Me.rbBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbBlack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rbBlack.UseVisualStyleBackColor = True
        '
        'rbWhite
        '
        Me.rbWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWhite.Image = Global.TeaTimer.My.Resources.Resources.white_tea
        Me.rbWhite.Location = New System.Drawing.Point(122, 8)
        Me.rbWhite.Margin = New System.Windows.Forms.Padding(2)
        Me.rbWhite.Name = "rbWhite"
        Me.rbWhite.Size = New System.Drawing.Size(68, 80)
        Me.rbWhite.TabIndex = 1
        Me.rbWhite.TabStop = True
        Me.rbWhite.Text = "White"
        Me.rbWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbWhite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rbWhite.UseVisualStyleBackColor = True
        '
        'rbGreen
        '
        Me.rbGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGreen.Image = Global.TeaTimer.My.Resources.Resources.green_tea
        Me.rbGreen.Location = New System.Drawing.Point(19, 8)
        Me.rbGreen.Margin = New System.Windows.Forms.Padding(2)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(68, 80)
        Me.rbGreen.TabIndex = 0
        Me.rbGreen.TabStop = True
        Me.rbGreen.Text = "Green"
        Me.rbGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbGreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'lblBrewTemp
        '
        Me.lblBrewTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrewTemp.Location = New System.Drawing.Point(179, 188)
        Me.lblBrewTemp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBrewTemp.Name = "lblBrewTemp"
        Me.lblBrewTemp.Size = New System.Drawing.Size(200, 23)
        Me.lblBrewTemp.TabIndex = 12
        Me.lblBrewTemp.Text = "Brew Temperature: 180F"
        Me.lblBrewTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 306)
        Me.Controls.Add(Me.lblBrewTemp)
        Me.Controls.Add(Me.grpbxTeaType)
        Me.Controls.Add(Me.lblBrewTime)
        Me.Controls.Add(Me.trkbarMinutes)
        Me.Controls.Add(Me.cmdBrew)
        Me.Controls.Add(Me.prgbarBrew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tea Timer"
        CType(Me.trkbarMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxTeaType.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents prgbarBrew As ProgressBar
    Friend WithEvents cmdBrew As Button
    Friend WithEvents trkbarMinutes As TrackBar
    Friend WithEvents lblBrewTime As Label
    Friend WithEvents tmrBrew As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents grpbxTeaType As GroupBox
    Friend WithEvents rbWhite As RadioButton
    Friend WithEvents rbGreen As RadioButton
    Friend WithEvents rbHerbal As RadioButton
    Friend WithEvents rbOolong As RadioButton
    Friend WithEvents rbBlack As RadioButton
    Friend WithEvents lblBrewTemp As Label
End Class
