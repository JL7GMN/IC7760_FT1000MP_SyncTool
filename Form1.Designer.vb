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
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtOffset
        ' 
        txtOffset.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txtOffset.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        txtOffset.Location = New Point(224, 56)
        txtOffset.Name = "txtOffset"
        txtOffset.Size = New Size(41, 27)
        txtOffset.TabIndex = 0
        txtOffset.Text = "0"
        ' 
        ' btnSync
        ' 
        btnSync.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSync.FlatStyle = FlatStyle.Popup
        btnSync.Location = New Point(6, 15)
        btnSync.Name = "btnSync"
        btnSync.Size = New Size(106, 32)
        btnSync.TabIndex = 1
        btnSync.Text = "SYNC"
        btnSync.UseVisualStyleBackColor = False
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblStatus.Location = New Point(126, 21)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(51, 20)
        lblStatus.TabIndex = 2
        lblStatus.Text = "Label1"
        ' 
        ' lblMaster
        ' 
        lblMaster.AutoSize = True
        lblMaster.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblMaster.Location = New Point(50, 33)
        lblMaster.Name = "lblMaster"
        lblMaster.Size = New Size(51, 20)
        lblMaster.TabIndex = 3
        lblMaster.Text = "Label1"
        ' 
        ' lblSlave
        ' 
        lblSlave.AutoSize = True
        lblSlave.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblSlave.Location = New Point(52, 85)
        lblSlave.Name = "lblSlave"
        lblSlave.Size = New Size(51, 20)
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
        GroupBox1.Location = New Point(4, 60)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(307, 116)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "OmniRig setting"
        ' 
        ' lblunit
        ' 
        lblunit.AutoSize = True
        lblunit.Location = New Point(268, 60)
        lblunit.Name = "lblunit"
        lblunit.Size = New Size(33, 19)
        lblunit.TabIndex = 9
        lblunit.Text = "[Hz]"
        ' 
        ' lblRig2
        ' 
        lblRig2.AutoSize = True
        lblRig2.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblRig2.Location = New Point(4, 85)
        lblRig2.Name = "lblRig2"
        lblRig2.Size = New Size(51, 20)
        lblRig2.TabIndex = 6
        lblRig2.Text = "Rig2 : "
        ' 
        ' lblOffset
        ' 
        lblOffset.AutoSize = True
        lblOffset.Location = New Point(73, 60)
        lblOffset.Name = "lblOffset"
        lblOffset.Size = New Size(142, 19)
        lblOffset.TabIndex = 8
        lblOffset.Text = "Rig2 = Rig1+オフセット"
        ' 
        ' lblRig1
        ' 
        lblRig1.AutoSize = True
        lblRig1.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblRig1.Location = New Point(4, 33)
        lblRig1.Name = "lblRig1"
        lblRig1.Size = New Size(49, 20)
        lblRig1.TabIndex = 5
        lblRig1.Text = "Rig1 : "
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(6, 131)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 39)
        Button1.TabIndex = 6
        Button1.Text = "END"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnRefresh.FlatStyle = FlatStyle.Popup
        btnRefresh.Location = New Point(6, 53)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(106, 32)
        btnRefresh.TabIndex = 7
        btnRefresh.Text = "更新"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblCondition
        ' 
        lblCondition.AutoSize = True
        lblCondition.Font = New Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        lblCondition.Location = New Point(6, 21)
        lblCondition.Name = "lblCondition"
        lblCondition.Size = New Size(122, 20)
        lblCondition.TabIndex = 10
        lblCondition.Text = "同期・更新状態："
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnOffsetClear)
        GroupBox3.Controls.Add(btnSync)
        GroupBox3.Controls.Add(btnRefresh)
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Location = New Point(317, 0)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(124, 176)
        GroupBox3.TabIndex = 11
        GroupBox3.TabStop = False
        GroupBox3.Text = "メニュー"
        ' 
        ' btnOffsetClear
        ' 
        btnOffsetClear.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnOffsetClear.FlatStyle = FlatStyle.Popup
        btnOffsetClear.Location = New Point(6, 93)
        btnOffsetClear.Name = "btnOffsetClear"
        btnOffsetClear.Size = New Size(106, 32)
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
        GroupBox4.Size = New Size(307, 53)
        GroupBox4.TabIndex = 12
        GroupBox4.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 19.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 184)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        MaximizeBox = False
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
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

End Class
