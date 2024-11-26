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
        ' g.FillRectangle(brush, 10, 10, 100, 100) ' g is your Graphics object
        Dim brush As New SolidBrush(selectedColor)
        Panel1.(brush, 10, 10, 100, 100)
    End Sub

    ' Function that returns a random color based on the index
    Function GetRandomColor(index As Integer) As Color
        ' List of predefined VB colors
        Dim colors As Color() = {
            Color.AliceBlue, Color.AntiqueWhite, Color.Aqua, Color.Aquamarine, Color.Azure,
            Color.Beige, Color.Bisque, Color.Black, Color.BlanchedAlmond, Color.Blue,
            Color.BlueViolet, Color.Brown, Color.BurlyWood, Color.CadetBlue, Color.Chartreuse,
            Color.Chocolate, Color.Coral, Color.CornflowerBlue, Color.Crimson, Color.Cyan,
            Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.DarkGreen,
            Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange, Color.DarkOrchid,
            Color.DarkRed, Color.DarkSalmon, Color.DarkSeaGreen, Color.DarkSlateBlue, Color.DarkSlateGray,
            Color.DarkTurquoise, Color.DarkViolet, Color.DeepPink, Color.DeepSkyBlue, Color.DimGray,
            Color.DodgerBlue, Color.Firebrick, Color.FloralWhite, Color.ForestGreen, Color.Fuchsia,
            Color.Gainsboro, Color.GhostWhite, Color.Gold, Color.Goldenrod, Color.Gray,
            Color.Green, Color.GreenYellow, Color.Honeydew, Color.HotPink, Color.IndianRed,
            Color.Indigo, Color.Ivory, Color.Khaki, Color.Lavender, Color.LavenderBlush,
            Color.LawnGreen, Color.LemonChiffon, Color.LightBlue, Color.LightCoral, Color.LightCyan,
            Color.LightGoldenrodYellow, Color.LightGreen, Color.LightGray, Color.LightPink, Color.LightSalmon,
            Color.LightSeaGreen, Color.LightSkyBlue, Color.LightSlateGray, Color.LightSteelBlue, Color.LightYellow,
            Color.Lime, Color.LimeGreen, Color.Linen, Color.Magenta, Color.Maroon,
            Color.MediumAquamarine, Color.MediumBlue, Color.MediumOrchid, Color.MediumPurple, Color.MediumSeaGreen,
            Color.MediumSlateBlue, Color.MediumSpringGreen, Color.MediumTurquoise, Color.MediumVioletRed, Color.MidnightBlue,
            Color.MintCream, Color.MistyRose, Color.Moccasin, Color.NavajoWhite, Color.Navy,
            Color.OldLace, Color.Olive, Color.OliveDrab, Color.Orange, Color.OrangeRed,
            Color.Orchid, Color.PaleGoldenrod, Color.PaleGreen, Color.PaleTurquoise, Color.PaleVioletRed,
            Color.PapayaWhip, Color.PeachPuff, Color.Peru, Color.Pink, Color.Plum,
            Color.PowderBlue, Color.Purple, Color.Red, Color.RosyBrown, Color.RoyalBlue,
            Color.SaddleBrown, Color.Salmon, Color.SandyBrown, Color.SeaGreen, Color.SeaShell,
            Color.Sienna, Color.Silver, Color.SkyBlue, Color.SlateBlue, Color.SlateGray,
            Color.Snow, Color.SpringGreen, Color.SteelBlue, Color.Tan, Color.Teal,
            Color.Thistle, Color.Tomato, Color.Transparent, Color.Turquoise, Color.Violet,
            Color.Wheat, Color.White, Color.WhiteSmoke, Color.Yellow, Color.YellowGreen
        }

        ' Make sure the index is within the bounds of the color array
        Return colors(index Mod colors.Length)
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.Controls.Clear()
        Me.InitializeComponent()
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
    End Sub

    Private Sub strpDark_Click(sender As Object, e As EventArgs) Handles strpDark.Click
        Me.BackColor = Color.DarkGray
        Me.ForeColor = Color.White
        btnAutoGenerate.BackColor = Color.Black
        btnExit.BackColor = Color.Black
        btnReset.BackColor = Color.Black
        MenuStrip1.BackColor = Color.DarkGray
    End Sub

    Private Sub strpBubbleGum_Click(sender As Object, e As EventArgs) Handles strpBubbleGum.Click
        Me.BackColor = Color.HotPink
        Me.ForeColor = Color.Black
        btnAutoGenerate.BackColor = Color.LightPink
        btnExit.BackColor = Color.LightPink
        btnReset.BackColor = Color.LightPink
        MenuStrip1.BackColor = Color.HotPink
    End Sub

    Private Sub strpCyan_Click(sender As Object, e As EventArgs) Handles strpCyan.Click
        Me.BackColor = Color.ForestGreen
        Me.ForeColor = Color.Black
        btnAutoGenerate.BackColor = Color.LightSeaGreen
        btnExit.BackColor = Color.LightSeaGreen
        btnReset.BackColor = Color.LightSeaGreen
        MenuStrip1.BackColor = Color.ForestGreen
    End Sub
End Class
