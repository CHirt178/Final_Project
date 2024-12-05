<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        DefaultToolStripMenuItem = New ToolStripMenuItem()
        pbox1 = New PictureBox()
        pbox2 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(pbox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(223, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(347, 40)
        Label1.TabIndex = 1
        Label1.Text = "Random Art Generation"
        ' 
        ' btnAutoGenerate
        ' 
        btnAutoGenerate.BackColor = SystemColors.Control
        btnAutoGenerate.FlatStyle = FlatStyle.Flat
        btnAutoGenerate.Location = New Point(81, 436)
        btnAutoGenerate.Name = "btnAutoGenerate"
        btnAutoGenerate.Size = New Size(81, 55)
        btnAutoGenerate.TabIndex = 2
        btnAutoGenerate.Text = "&Auto Generator "
        btnAutoGenerate.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Location = New Point(365, 436)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(81, 55)
        btnReset.TabIndex = 3
        btnReset.Text = "R&eset Art Panel "
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(643, 438)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(81, 55)
        btnExit.TabIndex = 4
        btnExit.Text = "E&xit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.Control
        MenuStrip1.Items.AddRange(New ToolStripItem() {ThemesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ThemesToolStripMenuItem
        ' 
        ThemesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {strpMidnight, strpDark, strpBubbleGum, strpCyan, DefaultToolStripMenuItem})
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
        strpCyan.Text = "Forest Green"
        ' 
        ' DefaultToolStripMenuItem
        ' 
        DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        DefaultToolStripMenuItem.Size = New Size(180, 22)
        DefaultToolStripMenuItem.Text = "Default"
        ' 
        ' pbox1
        ' 
        pbox1.BackColor = SystemColors.ControlDark
        pbox1.Location = New Point(90, 103)
        pbox1.Name = "pbox1"
        pbox1.Size = New Size(621, 296)
        pbox1.TabIndex = 7
        pbox1.TabStop = False
        ' 
        ' pbox2
        ' 
        pbox2.Location = New Point(0, 0)
        pbox2.Name = "pbox2"
        pbox2.Size = New Size(800, 507)
        pbox2.SizeMode = PictureBoxSizeMode.StretchImage
        pbox2.TabIndex = 8
        pbox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 503)
        Controls.Add(pbox1)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(btnAutoGenerate)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Controls.Add(pbox2)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Random Art Generator "
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pbox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
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
    Friend WithEvents pbox1 As PictureBox
    Friend WithEvents DefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbox2 As PictureBox

End Class
