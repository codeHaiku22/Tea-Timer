Imports System.Linq
Public Class frmMain

    Private mintBrewSeconds As Integer
    Private miconApp As Icon
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            ResetForm()

            tmrBrew.Interval = 1000

            miconApp = TeaTimer.My.Resources.tea

            Me.Icon = miconApp

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Tea Timer")

        End Try

    End Sub
    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Try

            If Me.WindowState = FormWindowState.Minimized Then
                With NotifyIcon1
                    .Visible = True
                    .Icon = miconApp
                End With
                ShowInTaskbar = False
            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Tea Timer")

        End Try

    End Sub
    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click, NotifyIcon1.DoubleClick

        Try

            ShowInTaskbar = True

            Me.WindowState = FormWindowState.Normal

            NotifyIcon1.Visible = False

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Tea Timer")

        End Try

    End Sub
    Private Sub cmdBrew_Click(sender As Object, e As EventArgs) Handles cmdBrew.Click

        Try

            prgbarBrew.Maximum = trkbarMinutes.Value * 60

            tmrBrew.Enabled = True

            tmrBrew.Start()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Tea Timer")

        End Try

    End Sub
    Private Sub trkbarMinutes_ValueChanged(sender As Object, e As EventArgs) Handles trkbarMinutes.ValueChanged

        Try

            Dim intBrewMinutes As Integer = trkbarMinutes.Value

            If intBrewMinutes = 60 Then
                lblBrewTime.Text = "Brew Time: " & intBrewMinutes & " minute"
            Else
                lblBrewTime.Text = "Brew Time: " & intBrewMinutes & " minutes"
            End If

            cmdBrew.Enabled = (intBrewMinutes > 0)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Tea Timer")

        End Try

    End Sub
    Private Sub ResetForm()

        Try

            mintBrewSeconds = 0

            miconApp = TeaTimer.My.Resources.tea

            Me.Icon = miconApp

            lblBrewTime.Text = "Brew Time: 0 minutes"
            lblBrewTemp.Text = "Brew Temperature: "

            trkbarMinutes.Value = 0

            cmdBrew.Enabled = False

            prgbarBrew.Value = 0

            tmrBrew.Enabled = False

            rbBlack.Checked = False
            rbGreen.Checked = False
            rbHerbal.Checked = False
            rbOolong.Checked = False
            rbWhite.Checked = False

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Tea Timer")

        End Try

    End Sub
    Private Sub tmrBrew_Tick(sender As Object, e As EventArgs) Handles tmrBrew.Tick

        Try

            mintBrewSeconds = mintBrewSeconds + 1

            If mintBrewSeconds = 4 Then Me.WindowState = FormWindowState.Minimized

            If prgbarBrew.Value = prgbarBrew.Maximum Then
                tmrBrew.Stop()
                With NotifyIcon1
                    .Visible = True
                    .Icon = miconApp
                    .BalloonTipIcon = ToolTipIcon.Info
                    .BalloonTipTitle = "TeaTimer"
                    .BalloonTipText = "Your tea is ready."
                    .ShowBalloonTip(1000)
                End With
                System.Threading.Thread.Sleep(1000)
                ResetForm()
            Else
                prgbarBrew.Value = mintBrewSeconds
            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Tea Timer")

        End Try

    End Sub
    Private Sub radioButton_CheckedChanged(sender As Object, e As EventArgs) Handles rbGreen.CheckedChanged, rbBlack.CheckedChanged, rbHerbal.CheckedChanged, rbOolong.CheckedChanged, rbWhite.CheckedChanged

        Try

            Dim radioButton As RadioButton = grpbxTeaType.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

            If radioButton Is Nothing Then Exit Sub

            Dim strTeaType As String = radioButton.Text.ToLower

            Select Case strTeaType
                Case "green"
                    trkbarMinutes.Value = 3
                    lblBrewTemp.Text = "Brew Temperature: 170F"
                    miconApp = TeaTimer.My.Resources.green_tea1
                Case "black"
                    trkbarMinutes.Value = 4
                    lblBrewTemp.Text = "Brew Temperature: 210F"
                    miconApp = TeaTimer.My.Resources.black_tea1
                Case "white"
                    trkbarMinutes.Value = 4
                    lblBrewTemp.Text = "Brew Temperature: 155F"
                    miconApp = TeaTimer.My.Resources.white_tea1
                Case "oolong"
                    trkbarMinutes.Value = 5
                    lblBrewTemp.Text = "Brew Temperature: 180F"
                    miconApp = TeaTimer.My.Resources.oolong_tea1
                Case "herbal"
                    trkbarMinutes.Value = 5
                    lblBrewTemp.Text = "Brew Temperature: 210F"
                    miconApp = TeaTimer.My.Resources.herbal_tea1
                Case Else
                    lblBrewTemp.Text = "Brew Temperature: ?"
                    miconApp = TeaTimer.My.Resources.tea
            End Select

            Me.Icon = miconApp

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Tea Timer")

        End Try

    End Sub
End Class
