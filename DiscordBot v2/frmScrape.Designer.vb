﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScrape
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScrape))
        Me.XylosTabControl1 = New Gotcha.XylosTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblCurrentPokemon = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtToken = New Gotcha.XylosTextBox()
        Me.XylosSeparator1 = New Gotcha.XylosSeparator()
        Me.XylosButton2 = New Gotcha.XylosButton()
        Me.XylosButton1 = New Gotcha.XylosButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtY = New Gotcha.XylosTextBox()
        Me.txtX = New Gotcha.XylosTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.XylosTabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'XylosTabControl1
        '
        Me.XylosTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.XylosTabControl1.Controls.Add(Me.TabPage1)
        Me.XylosTabControl1.Controls.Add(Me.TabPage2)
        Me.XylosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XylosTabControl1.FirstHeaderBorder = False
        Me.XylosTabControl1.ItemSize = New System.Drawing.Size(40, 180)
        Me.XylosTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XylosTabControl1.Multiline = True
        Me.XylosTabControl1.Name = "XylosTabControl1"
        Me.XylosTabControl1.SelectedIndex = 0
        Me.XylosTabControl1.Size = New System.Drawing.Size(474, 194)
        Me.XylosTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.XylosTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(286, 186)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Tag = "dash"
        Me.TabPage1.Text = "Dashboard"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.lblCurrentPokemon)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtToken)
        Me.TabPage2.Controls.Add(Me.XylosSeparator1)
        Me.TabPage2.Controls.Add(Me.XylosButton2)
        Me.TabPage2.Controls.Add(Me.XylosButton1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtY)
        Me.TabPage2.Controls.Add(Me.txtX)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(286, 186)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Image Scrape"
        '
        'lblCurrentPokemon
        '
        Me.lblCurrentPokemon.AutoSize = True
        Me.lblCurrentPokemon.Location = New System.Drawing.Point(167, 102)
        Me.lblCurrentPokemon.Name = "lblCurrentPokemon"
        Me.lblCurrentPokemon.Size = New System.Drawing.Size(111, 15)
        Me.lblCurrentPokemon.TabIndex = 23
        Me.lblCurrentPokemon.Text = "lblCurrentPokemon"
        Me.lblCurrentPokemon.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Token:"
        '
        'txtToken
        '
        Me.txtToken.EnabledCalc = True
        Me.txtToken.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtToken.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtToken.Location = New System.Drawing.Point(6, 120)
        Me.txtToken.MaxLength = 32767
        Me.txtToken.MultiLine = False
        Me.txtToken.Name = "txtToken"
        Me.txtToken.ReadOnly = False
        Me.txtToken.Size = New System.Drawing.Size(272, 29)
        Me.txtToken.TabIndex = 21
        Me.txtToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtToken.UseSystemPasswordChar = True
        '
        'XylosSeparator1
        '
        Me.XylosSeparator1.Location = New System.Drawing.Point(6, 58)
        Me.XylosSeparator1.Name = "XylosSeparator1"
        Me.XylosSeparator1.Size = New System.Drawing.Size(274, 2)
        Me.XylosSeparator1.TabIndex = 20
        Me.XylosSeparator1.Text = "XylosSeparator1"
        '
        'XylosButton2
        '
        Me.XylosButton2.EnabledCalc = True
        Me.XylosButton2.Location = New System.Drawing.Point(6, 66)
        Me.XylosButton2.Name = "XylosButton2"
        Me.XylosButton2.Size = New System.Drawing.Size(272, 23)
        Me.XylosButton2.TabIndex = 19
        Me.XylosButton2.Text = "Invite Bot"
        '
        'XylosButton1
        '
        Me.XylosButton1.EnabledCalc = True
        Me.XylosButton1.Location = New System.Drawing.Point(9, 155)
        Me.XylosButton1.Name = "XylosButton1"
        Me.XylosButton1.Size = New System.Drawing.Size(269, 23)
        Me.XylosButton1.TabIndex = 18
        Me.XylosButton1.Text = "Start"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Press F5 to set the middle of the sprite on discord."
        '
        'txtY
        '
        Me.txtY.EnabledCalc = True
        Me.txtY.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtY.Location = New System.Drawing.Point(92, 23)
        Me.txtY.MaxLength = 32767
        Me.txtY.MultiLine = False
        Me.txtY.Name = "txtY"
        Me.txtY.ReadOnly = False
        Me.txtY.Size = New System.Drawing.Size(83, 29)
        Me.txtY.TabIndex = 16
        Me.txtY.Text = "Y"
        Me.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtY.UseSystemPasswordChar = False
        '
        'txtX
        '
        Me.txtX.EnabledCalc = True
        Me.txtX.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtX.Location = New System.Drawing.Point(3, 23)
        Me.txtX.MaxLength = 32767
        Me.txtX.MultiLine = False
        Me.txtX.Name = "txtX"
        Me.txtX.ReadOnly = False
        Me.txtX.Size = New System.Drawing.Size(83, 29)
        Me.txtX.TabIndex = 15
        Me.txtX.Text = "X"
        Me.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtX.UseSystemPasswordChar = False
        '
        'frmScrape
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 194)
        Me.Controls.Add(Me.XylosTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScrape"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Gotcha! - Image Scraper"
        Me.XylosTabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents txtY As XylosTextBox
    Friend WithEvents txtX As XylosTextBox
    Friend WithEvents XylosTabControl1 As XylosTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents XylosButton1 As XylosButton
    Friend WithEvents XylosButton2 As XylosButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtToken As XylosTextBox
    Friend WithEvents XylosSeparator1 As XylosSeparator
    Friend WithEvents lblCurrentPokemon As Label
End Class
