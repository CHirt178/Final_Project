﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        btnAutoGenerate = New Button()
        btnReset = New Button()
        btnExit = New Button()
        MenuStrip1 = New MenuStrip()
        ThemesToolStripMenuItem = New ToolStripMenuItem()
        strpMidnight = New ToolStripMenuItem()
        strpDark = New ToolStripMenuItem()
        strpBubbleGum = New ToolStripMenuItem()
        strpCyan = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.ForeColor = SystemColors.AppWorkspace
        Panel1.Location = New Point(81, 75)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(643, 283)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(231, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 37)
        Label1.TabIndex = 1
        Label1.Text = "Random Art Generation "
        ' 
        ' btnAutoGenerate
        ' 
        btnAutoGenerate.Location = New Point(81, 438)
        btnAutoGenerate.Name = "btnAutoGenerate"
        btnAutoGenerate.Size = New Size(81, 55)
        btnAutoGenerate.TabIndex = 2
        btnAutoGenerate.Text = "&Auto Generator "
        btnAutoGenerate.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(360, 438)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(81, 55)
        btnReset.TabIndex = 3
        btnReset.Text = "R&eset Art Panel "
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(643, 438)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(81, 55)
        btnExit.TabIndex = 4
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ThemesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ThemesToolStripMenuItem
        ' 
        ThemesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {strpMidnight, strpDark, strpBubbleGum, strpCyan})
        ThemesToolStripMenuItem.Name = "ThemesToolStripMenuItem"
        ThemesToolStripMenuItem.Size = New Size(60, 20)
        ThemesToolStripMenuItem.Text = "Themes"
        ' 
        ' strpMidnight
        ' 
        strpMidnight.Name = "strpMidnight"
        strpMidnight.Size = New Size(180, 22)
        strpMidnight.Text = "Midnight"
        ' 
        ' strpDark
        ' 
        strpDark.Name = "strpDark"
        strpDark.Size = New Size(180, 22)
        strpDark.Text = "Dark"
        ' 
        ' strpBubbleGum
        ' 
        strpBubbleGum.Name = "strpBubbleGum"
        strpBubbleGum.Size = New Size(180, 22)
        strpBubbleGum.Text = "BubbleGum "
        ' 
        ' strpCyan
        ' 
        strpCyan.Name = "strpCyan"
        strpCyan.Size = New Size(180, 22)
        strpCyan.Text = "Cyan"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 503)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(btnAutoGenerate)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Random Art Genorator "
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAutoGenerate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents strpMidnight As ToolStripMenuItem
    Friend WithEvents strpDark As ToolStripMenuItem
    Friend WithEvents strpBubbleGum As ToolStripMenuItem
    Friend WithEvents strpCyan As ToolStripMenuItem

End Class