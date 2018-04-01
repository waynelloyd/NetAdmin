Public Class frmMain


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim bAns4 As Boolean = True
        Dim strAddress As String = TextBox1.Text
        If TextBox1.Text = String.Empty Then
            dlgMessage1.ShowDialog(Me)
            elseIf TextBox1.Text = strAddress Then
            If RadioButton1.Checked = True Then
                Try
                    System.Diagnostics.Process.Start("cmd.exe", "/c ping.exe -n 10 " & TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf RadioButton2.Checked = True Then
                Try
                    System.Diagnostics.Process.Start("msinfo32.exe", "/computer " & TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf RadioButton3.Checked = True Then
                Try
                    System.Diagnostics.Process.Start("gpedit.msc", "/gpcomputer: " & TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf RadioButton4.Checked = True Then
                Try
                    System.Diagnostics.Process.Start("mstsc.exe", "-v:" & TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf RadioButton5.Checked = True Then
                Try
                    System.Diagnostics.Process.Start("compmgmt.msc", "/computer:" & TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub

    Private Sub RemoteRestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoteRestartToolStripMenuItem.Click
        dlgRestart.ShowDialog(Me)
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        dlgAbout.ShowDialog(Me)
    End Sub
End Class
