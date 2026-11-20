Option Strict Off
Imports OmniRig
Public Class Form1
    'V1　タイマー追加版
    Private OmniRig As OmniRigX

    Private Sub Form1_Load(
    sender As Object,
    e As EventArgs) Handles MyBase.Load

        Timer1.Interval = CInt(NumericUpDown1.Value) * 1000

        Try
            ' Me.Text = "IC-7760 ⇔ FT-1000MP Sync Tool"

            OmniRig = New OmniRigX()

            'OmniRigデータ取り込みタイミング合わせるために1秒待つ
            Threading.Thread.Sleep(1200)
            Application.DoEvents()

            Dim r1 As RigX = OmniRig.Rig1
            Dim r2 As RigX = OmniRig.Rig2

            Dim mode1 As String = OmniRig.Rig1.Mode.ToString
            Dim mode2 As String = OmniRig.Rig2.Mode.ToString

            'Me.Text = "IC-7760 ⇔ FT-1000MP Sync Tool"
            Me.Text = r1.RigType.ToString & " ⇒ " & r2.RigType.ToString & " Sync Tool"

            Dim mode1Name As String = GetModeName(mode1)
            Dim mode2Name As String = GetModeName(mode2)

            lblmastermode.Text = mode1Name
            lblclientmode.Text = mode2Name

            lblMaster.Text =
                "Master (" &
                r1.RigType.ToString &
                ")     : " &
                FormatFreq(r1.FreqA) &
                " MHz"

            lblSlave.Text =
                "Slave (" &
                r2.RigType.ToString &
                ") : " &
                FormatFreq(r2.FreqA) &
                " MHz"

            lblStatus.Text = "OmniRig接続OK" & Format(Now, " HH:mm:ss")

            txtOffset.Text = "0"

            ' EnterキーでSYNC
            Me.AcceptButton = btnSync

        Catch ex As Exception

            lblStatus.Text = ex.Message

        End Try

    End Sub

    Private Sub chkAutoUpdate_CheckedChanged(
    sender As Object,
    e As EventArgs) Handles chkAutoUpdate.CheckedChanged

        Timer1.Enabled = chkAutoUpdate.Checked

        'チェックボックスにチェック無い時は手動更新ボタン押下可能にする
        btnRefresh.Enabled = Not chkAutoUpdate.Checked

        lblStatus.Text = "手動更新"

    End Sub

    Private Sub Timer1_Tick(
    sender As Object,
    e As EventArgs) Handles Timer1.Tick

        UpdateDisplay()
        If chkAutoUpdate.Checked Then

            lblStatus.Text =
                "自動更新" & Format(Now, "         HH:mm:ss")

        End If

    End Sub

    Private Sub NumericUpDown1_ValueChanged(
    sender As Object,
    e As EventArgs) Handles NumericUpDown1.ValueChanged

        Timer1.Interval = Math.Max(1, CInt(NumericUpDown1.Value)) * 1000

    End Sub

    Private Function GetModeName(modeText As String) As String

        Select Case modeText

            Case "PM_SSB_L"
                Return "LSB"

            Case "PM_SSB_U"
                Return "USB"

            Case "PM_CW_L"
                Return "CW"

            Case "PM_CW_U"
                Return "CW-R"

            Case "PM_AM"
                Return "AM"

            Case "PM_FM"
                Return "FM"

            Case "PM_DIG_L"      '7760 14MHzより下は RTTY-LSB
                Return "RTTY"

            Case "PM_DIG_U"      '7760 14MHzより上は RTTY-USB
                Return "RTTY-R"

            Case "RTTY"
                Return "RTTY"

            Case "PM_UNKNOWN"      '7760 14MHzより上は RTTY-USB
                Return "PSK LSB/FM"

            Case Else
                Return modeText

        End Select

    End Function

    Private Function FormatFreq(freq As Integer) As String

        Dim s As String

        s = freq.ToString("00000000")

        Return Mid(s, 1, 2) & "." &
           Mid(s, 3, 3) & "." &
           Mid(s, 6, 3)

    End Function

    Private Sub UpdateDisplay()
        Try
            Dim r1 As RigX = OmniRig.Rig1
            Dim r2 As RigX = OmniRig.Rig2

            lblMaster.Text =
                "Master (" &
                r1.RigType.ToString &
                ")     : " &
                FormatFreq(r1.FreqA) &
                " MHz"

            lblSlave.Text =
                "Slave (" &
                r2.RigType.ToString &
                ") : " &
                FormatFreq(r2.FreqA) &
                " MHz"


            Dim modeName1 As String = GetModeName(r1.Mode.ToString)
            Dim modeName2 As String = GetModeName(r2.Mode.ToString)

            Dim modeName As String
            modeName = ""

            modeName = GetModeName(OmniRig.Rig1.Mode.ToString)
            'Me.lblmastermode.Text = modeName1
            Me.lblmastermode.Text = modeName
            modeName = ""
            modeName = GetModeName(OmniRig.Rig2.Mode.ToString)
            'Me.lblclientmode.Text = modeName2
            Me.lblclientmode.Text = modeName

        Catch ex As Exception
            lblStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub btnSync_Click(
    sender As Object,
    e As EventArgs) Handles btnSync.Click

        Try

            Dim offset As Integer

            Integer.TryParse(txtOffset.Text, offset)

            Dim masterFreq As Integer

            masterFreq = OmniRig.Rig1.FreqA

            Dim targetFreq As Integer

            targetFreq = masterFreq + offset

            '周波数同期
            OmniRig.Rig2.SetSimplexMode(targetFreq)

            'モード同期
            If OmniRig.Rig2.Mode <> OmniRig.Rig1.Mode Then
                OmniRig.Rig2.Mode = OmniRig.Rig1.Mode
            End If

            Application.DoEvents()

            Threading.Thread.Sleep(1000)

            UpdateDisplay()

            lblStatus.Text = "同期完了 " & Format(Now, "HH:mm:ss")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub



    'Private Sub btnSync_Click(
    'sender As Object,
    'e As EventArgs) Handles btnSync.Click

    '    Try

    '        Dim offset As Integer

    '        Integer.TryParse(txtOffset.Text, offset)

    '        Dim masterFreq As Integer

    '        masterFreq = OmniRig.Rig1.FreqA

    '        Dim targetFreq As Integer

    '        targetFreq = masterFreq + offset

    '        OmniRig.Rig2.SetSimplexMode(targetFreq)

    '        Application.DoEvents()

    '        Threading.Thread.Sleep(1000)

    '        UpdateDisplay()

    '        'lblStatus.Text = "同期完了"
    '        lblStatus.Text = "同期完了 " & Format(Now, "        HH:mm:ss")

    '    Catch ex As Exception

    '        MessageBox.Show(ex.Message)

    '    End Try

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show(
                    "終了しますか？",
                    "確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                                ) = DialogResult.Yes Then

            Me.Close()

        End If
        '   End'

    End Sub

    Private Sub btnRefresh_Click(
    sender As Object,
    e As EventArgs) Handles btnRefresh.Click

        Dim r1 As RigX = OmniRig.Rig1
        Dim r2 As RigX = OmniRig.Rig2

        Try

            UpdateDisplay()

            lblStatus.Text = "手動更新" & Format(Now, "         HH:mm:ss")

        Catch ex As Exception

            lblStatus.Text = ex.Message

        End Try

    End Sub

    Private Sub btnOffsetClear_Click(sender As Object, e As EventArgs) Handles btnOffsetClear.Click

        txtOffset.Text = "0"

        lblStatus.Text = "オフセットクリア" & Format(Now, " HH:mm:ss")

    End Sub


End Class