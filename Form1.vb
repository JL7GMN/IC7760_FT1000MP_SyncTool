Option Strict Off
Imports OmniRig
Public Class Form1

    Private OmniRig As OmniRigX

    Private Sub Form1_Load(
    sender As Object,
    e As EventArgs) Handles MyBase.Load

        Try
            ' Me.Text = "IC-7760 ⇔ FT-1000MP Sync Tool"

            OmniRig = New OmniRigX()

            Dim r1 As RigX = OmniRig.Rig1
            Dim r2 As RigX = OmniRig.Rig2

            'Me.Text = "IC-7760 ⇔ FT-1000MP Sync Tool"
            Me.Text = r1.RigType.ToString & " ⇒ " & r2.RigType.ToString & " Sync Tool"

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

            OmniRig.Rig2.SetSimplexMode(targetFreq)

            Application.DoEvents()

            Threading.Thread.Sleep(1000)

            UpdateDisplay()

            'lblStatus.Text = "同期完了"
            lblStatus.Text = "同期完了 " & Format(Now, "       HH:mm:ss")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

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

            lblStatus.Text = "周波数更新" & Format(Now, "    HH:mm:ss")

        Catch ex As Exception

            lblStatus.Text = ex.Message

        End Try

    End Sub

    Private Sub btnOffsetClear_Click(sender As Object, e As EventArgs) Handles btnOffsetClear.Click

        txtOffset.Text = "0"

        lblStatus.Text = "オフセットクリア" & Format(Now, "HH:mm:ss")

    End Sub


End Class