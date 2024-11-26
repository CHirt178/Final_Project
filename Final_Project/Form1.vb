Imports System.Drawing.Design

Public Class Form1

    Private Sub btnAutoGenerate_Click(sender As Object, e As EventArgs) Handles btnAutoGenerate.Click
        ' Create a Random object
        Dim rand As New Random()

        ' Get a random number between 0 and the number of predefined colors
        Dim colorIndex As Integer = rand.Next(0, 100) ' There are about 100 predefined colors in VB.NET

        ' Use the color index to pick a color
        Dim selectedColor As Color = GetRandomColor(colorIndex)

        ' Output the selected color's name
        Console.WriteLine("Selected Color: " & selectedColor.Name)

        ' Here you can use selectedColor for drawing, for example:
        ' Dim brush As New SolidBrush(selectedColor)
        Dim brush As New SolidBrush(selectedColor)

    End Sub



    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        pbox1.Image = Nothing
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub strpMidnight_Click(sender As Object, e As EventArgs) Handles strpMidnight.Click
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        btnAutoGenerate.BackColor = Color.DarkGray
        btnExit.BackColor = Color.DarkGray
        btnReset.BackColor = Color.DarkGray
        MenuStrip1.BackColor = Color.Black
        MenuStrip1.ForeColor = Color.White
    End Sub

    Private Sub strpDark_Click(sender As Object, e As EventArgs) Handles strpDark.Click
        Me.BackColor = Color.DarkGray
        Me.ForeColor = Color.White
        btnAutoGenerate.BackColor = Color.Black
        btnExit.BackColor = Color.Black
        btnReset.BackColor = Color.Black
        MenuStrip1.BackColor = Color.DarkGray
        MenuStrip1.ForeColor = Color.White
    End Sub

    Private Sub strpBubbleGum_Click(sender As Object, e As EventArgs) Handles strpBubbleGum.Click
        Me.BackColor = Color.HotPink
        Me.ForeColor = Color.Black
        btnAutoGenerate.BackColor = Color.LightPink
        btnExit.BackColor = Color.LightPink
        btnReset.BackColor = Color.LightPink
        MenuStrip1.BackColor = Color.HotPink
        MenuStrip1.ForeColor = Color.Black
        'hi
    End Sub

    Private Sub strpCyan_Click(sender As Object, e As EventArgs) Handles strpCyan.Click
        Me.BackColor = Color.ForestGreen
        Me.ForeColor = Color.Black
        btnAutoGenerate.BackColor = Color.LightSeaGreen
        btnExit.BackColor = Color.LightSeaGreen
        btnReset.BackColor = Color.LightSeaGreen
        MenuStrip1.BackColor = Color.ForestGreen
        MenuStrip1.ForeColor = Color.Black
    End Sub
End Class
