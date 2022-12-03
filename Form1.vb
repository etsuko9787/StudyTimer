Imports System
Public Class Form1
    Dim ss, tt, vv As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "00:00:00"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
        vv = vv + 1
        If vv > 59 Then
            vv = 0
            tt = tt + 1
        End If
        If tt = 2 Then
            vv = 0
            tt = 0
            Label1.Text = "00:00:00"
            Timer1.Enabled = False
            MessageBox.Show("Time Ended")
        End If
    End Sub
End Class
