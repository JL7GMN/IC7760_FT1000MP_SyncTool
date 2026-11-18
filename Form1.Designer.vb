<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        txtOffset = New TextBox()
        btnSync = New Button()
        lblStatus = New Label()
        lblMaster = New Label()
        lblSlave = New Label()
        GroupBox1 = New GroupBox()
        lblunit = New Label()
        lblRig2 = New Label()
        lblOffset = New Label()
        lblRig1 = New Label()
        Button1 = New Button()
        btnRefresh = New Button()
        lblCondition = New Label()
        GroupBox3 = New GroupBox()
        btnOffsetClear = New Button()
        GroupBox4 = New GroupBox()
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        NumericUpDown1 = New NumericUpDown()
        chkAutoUpdate = New CheckBox()
        GroupBox5 = New GroupBox()
        Timer1 = New Timer(components)
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtOffset
        ' 
        txtOffset.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtOffset.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        txtOffset.Location = New Point(252, 52)
        txtOffset.Name = "txtOffset"
        txtOffset.Size = New Size(46, 27)
        txtOffset.TabIndex = 0
        txtOffset.Text = "0"
        ' 
        ' btnSync
        ' 
        btnSync.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSync.FlatStyle = FlatStyle.Popup
        btnSync.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnSync.Location = New Point(11, 34)
        btnSync.Name = "btnSync"
        btnSync.Size = New Size(120, 50)
        btnSync.TabIndex = 1
        btnSync.Text = "SYNC"
        btnSync.UseVisualStyleBackColor = False
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblStatus.Location = New Point(134, 22)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(55, 21)
        lblStatus.TabIndex = 2
        lblStatus.Text = "Label1"
        ' 
        ' lblMaster
        ' 
        lblMaster.AutoSize = True
        lblMaster.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMaster.Location = New Point(62, 28)
        lblMaster.Name = "lblMaster"
        lblMaster.Size = New Size(55, 21)
        lblMaster.TabIndex = 3
        lblMaster.Text = "Label1"
        ' 
        ' lblSlave
        ' 
        lblSlave.AutoSize = True
        lblSlave.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblSlave.Location = New Point(64, 82)
        lblSlave.Name = "lblSlave"
        lblSlave.Size = New Size(55, 21)
        lblSlave.TabIndex = 4
        lblSlave.Text = "Label1"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblunit)
        GroupBox1.Controls.Add(txtOffset)
        GroupBox1.Controls.Add(lblRig2)
        GroupBox1.Controls.Add(lblOffset)
        GroupBox1.Controls.Add(lblRig1)
        GroupBox1.Controls.Add(lblMaster)
        GroupBox1.Controls.Add(lblSlave)
        GroupBox1.FlatStyle = FlatStyle.Popup
        GroupBox1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        GroupBox1.Location = New Point(4, 141)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(349, 111)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "OmniRig setting"
        ' 
        ' lblunit
        ' 
        lblunit.AutoSize = True
        lblunit.Location = New Point(302, 56)
        lblunit.Name = "lblunit"
        lblunit.Size = New Size(39, 21)
        lblunit.TabIndex = 9
        lblunit.Text = "[Hz]"
        ' 
        ' lblRig2
        ' 
        lblRig2.AutoSize = True
        lblRig2.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblRig2.Location = New Point(4, 82)
        lblRig2.Name = "lblRig2"
        lblRig2.Size = New Size(55, 21)
        lblRig2.TabIndex = 6
        lblRig2.Text = "Rig2 : "
        ' 
        ' lblOffset
        ' 
        lblOffset.AutoSize = True
        lblOffset.Location = New Point(82, 56)
        lblOffset.Name = "lblOffset"
        lblOffset.Size = New Size(162, 21)
        lblOffset.TabIndex = 8
        lblOffset.Text = "Rig2 = Rig1+オフセット"
        ' 
        ' lblRig1
        ' 
        lblRig1.AutoSize = True
        lblRig1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblRig1.Location = New Point(4, 28)
        lblRig1.Name = "lblRig1"
        lblRig1.Size = New Size(52, 21)
        lblRig1.TabIndex = 5
        lblRig1.Text = "Rig1 : "
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Button1.Location = New Point(11, 192)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 50)
        Button1.TabIndex = 6
        Button1.Text = "END"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnRefresh.FlatStyle = FlatStyle.Popup
        btnRefresh.Location = New Point(19, 23)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(120, 50)
        btnRefresh.TabIndex = 7
        btnRefresh.Text = "更新"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblCondition
        ' 
        lblCondition.AutoSize = True
        lblCondition.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblCondition.Location = New Point(7, 22)
        lblCondition.Name = "lblCondition"
        lblCondition.Size = New Size(130, 21)
        lblCondition.TabIndex = 10
        lblCondition.Text = "同期・更新状態："
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnOffsetClear)
        GroupBox3.Controls.Add(btnSync)
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        GroupBox3.Location = New Point(362, 1)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(140, 251)
        GroupBox3.TabIndex = 11
        GroupBox3.TabStop = False
        GroupBox3.Text = "メニュー"
        ' 
        ' btnOffsetClear
        ' 
        btnOffsetClear.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnOffsetClear.FlatStyle = FlatStyle.Popup
        btnOffsetClear.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        btnOffsetClear.Location = New Point(11, 112)
        btnOffsetClear.Name = "btnOffsetClear"
        btnOffsetClear.Size = New Size(120, 50)
        btnOffsetClear.TabIndex = 8
        btnOffsetClear.Text = "オフセットクリア"
        btnOffsetClear.UseVisualStyleBackColor = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(lblCondition)
        GroupBox4.Controls.Add(lblStatus)
        GroupBox4.FlatStyle = FlatStyle.Popup
        GroupBox4.Location = New Point(4, 1)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(349, 56)
        GroupBox4.TabIndex = 12
        GroupBox4.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(NumericUpDown1)
        GroupBox2.Controls.Add(chkAutoUpdate)
        GroupBox2.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        GroupBox2.Location = New Point(4, 56)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(182, 85)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "自動更新設定"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(152, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(26, 21)
        Label2.TabIndex = 3
        Label2.Text = "秒"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 21)
        Label1.TabIndex = 2
        Label1.Text = "更新間隔"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(103, 50)
        NumericUpDown1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(43, 29)
        NumericUpDown1.TabIndex = 1
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' chkAutoUpdate
        ' 
        chkAutoUpdate.AutoSize = True
        chkAutoUpdate.Location = New Point(7, 23)
        chkAutoUpdate.Name = "chkAutoUpdate"
        chkAutoUpdate.Size = New Size(93, 25)
        chkAutoUpdate.TabIndex = 0
        chkAutoUpdate.Text = "自動更新"
        chkAutoUpdate.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(btnRefresh)
        GroupBox5.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        GroupBox5.Location = New Point(193, 56)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(160, 85)
        GroupBox5.TabIndex = 14
        GroupBox5.TabStop = False
        GroupBox5.Text = "手動更新処理"
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(508, 257)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtOffset As TextBox
    Friend WithEvents btnSync As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblMaster As Label
    Friend WithEvents lblSlave As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblRig2 As Label
    Friend WithEvents lblRig1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblOffset As Label
    Friend WithEvents lblCondition As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnOffsetClear As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblunit As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkAutoUpdate As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
