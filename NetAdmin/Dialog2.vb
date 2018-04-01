Imports System.Windows.Forms

Public Class dlgRestart

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim bAns3 As Boolean = True
        Dim strAddress As String = TextBox1.Text
        Dim intAnswer As Integer
        If TextBox1.Text = String.Empty Then
            dlgMessage1.ShowDialog(Me)
        ElseIf TextBox1.Text = strAddress Then
            Try
                intAnswer = MsgBox("Restart remote system are you sure?", MsgBoxStyle.YesNo, "Restart")
                If intAnswer = vbYes = True Then
                    System.Diagnostics.Process.Start("shutdown.exe", "-r -t 60 -f -m \\" & TextBox1.Text)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
