Imports System.Drawing.Design

Public Class Form1

    Private Sub btnAutoGenerate_Click(sender As Object, e As EventArgs) Handles btnAutoGenerate.Click

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub strpMidnight_Click(sender As Object, e As EventArgs) Handles strpMidnight.Click
        Me.BackColor = Color.MidnightBlue
    End Sub

    Private Sub strpDark_Click(sender As Object, e As EventArgs) Handles strpDark.Click
        Me.BackColor = Color.Black
    End Sub

    Private Sub strpBubbleGum_Click(sender As Object, e As EventArgs) Handles strpBubbleGum.Click
        Me.BackColor = Color.
    End Sub

    Private Sub strpCyan_Click(sender As Object, e As EventArgs) Handles strpCyan.Click
        Me.BackColor = 
    End Sub
End Class
