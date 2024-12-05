Imports System.Drawing.Design
Imports System.Text.Json
Imports System.Xml
'Author: Connor and Caden
'Project: Final Project 
'Date: December 5, 2024
Public Class Form1


    Public Sub btnAutoGenerate_Click(sender As Object, e As EventArgs) Handles btnAutoGenerate.Click
        'Graphic generator
        Dim g As Graphics = pbox1.CreateGraphics()
        ' Create a Random object
        Dim rand As New Random()
        Dim rand2 As New Random()
        Dim rand3 As New Random()

        'Make the loop for the random shape generation 
        For i As Integer = 1 To 100
            'Number range 1-3 for shapes 
            Dim Shape As Integer = rand.Next(0, 2)
            'Random Numbers for Size 
            Dim SizeX As Integer = rand.Next(0, 600)
            Dim SizeY As Integer = rand.Next(0, 600)


            ' Get a random number between 0 and the number of predefined colors
            Dim colorIndex As Integer = rand.Next(0, 100) ' There are about 100 predefined colors in VB.NET

            ' Use the color index to pick a color
            Dim selectedColor As Color = GetRandomColor(colorIndex)

            ' Output the selected color's name
            Console.WriteLine("Selected Color: " & selectedColor.Name)
            Dim Width As Integer = rand.Next(0, 100)
            Dim Height As Integer = rand.Next(0, 100)

            'Random Shape generator
            Select Case Shape
            'Line
                Case 0
                    g.DrawLine(New Pen(GetRandomColor(colorIndex), Width), SizeX, SizeY, SizeX + Width, SizeY + Height)
            'Circle
                Case 1
                    g.DrawEllipse(New Pen(GetRandomColor(colorIndex), Width), SizeX, SizeY, Width, Height)
            'Rectangle
                Case 2
                    g.DrawRectangle(New Pen(GetRandomColor(colorIndex), Width), SizeX, SizeY, Width, Height)
            End Select

        Next



        g.Dispose()
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
        pbox1.BackColor = Color.DarkGray
        pbox2.Image = My.Resources.pexels_krisof_1252890
    End Sub

    Private Sub strpDark_Click(sender As Object, e As EventArgs) Handles strpDark.Click
        Me.BackColor = Color.DarkGray
        Me.ForeColor = Color.White
        btnAutoGenerate.BackColor = Color.Black
        btnExit.BackColor = Color.Black
        btnReset.BackColor = Color.Black
        MenuStrip1.BackColor = Color.DarkGray
        MenuStrip1.ForeColor = Color.White
        pbox1.BackColor = Color.Black
        pbox2.Image = My.Resources.premium_photo_1683121862832_2c9fe1cf4b79
    End Sub

    Private Sub strpBubbleGum_Click(sender As Object, e As EventArgs) Handles strpBubbleGum.Click
        Me.BackColor = Color.HotPink
        Me.ForeColor = Color.Black
        btnAutoGenerate.BackColor = Color.LightPink
        btnExit.BackColor = Color.LightPink
        btnReset.BackColor = Color.LightPink
        MenuStrip1.BackColor = Color.HotPink
        MenuStrip1.ForeColor = Color.Black
        pbox1.BackColor = Color.LightPink
        pbox2.Image = My.Resources.photo_1627494113508_9ba5b63d9d5c
    End Sub

    Private Sub strpCyan_Click(sender As Object, e As EventArgs) Handles strpCyan.Click
        Me.BackColor = Color.DarkGreen
        Me.ForeColor = Color.Black
        btnAutoGenerate.BackColor = Color.ForestGreen
        btnExit.BackColor = Color.ForestGreen
        btnReset.BackColor = Color.ForestGreen
        MenuStrip1.BackColor = Color.DarkGreen
        MenuStrip1.ForeColor = Color.Black
        pbox1.BackColor = Color.ForestGreen
        pbox2.Image = My.Resources._2048x1365_Oak_trees_SEO_GettyImages_90590330_b6bfe8b
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = DefaultBackColor
        Me.ForeColor = Color.Black
        btnAutoGenerate.BackColor = DefaultBackColor
        btnExit.BackColor = DefaultBackColor
        btnReset.BackColor = DefaultBackColor
        MenuStrip1.BackColor = DefaultBackColor
        MenuStrip1.ForeColor = Color.Black
        pbox1.BackColor = Color.LightGray
        pbox2.Image = Nothing
    End Sub

    Private Sub SaveAsjpgToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
