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
        BoardPanel = New Panel()
        PlayerOnePictureBox = New PictureBox()
        PlayerTwoPictureBox = New PictureBox()
        DiceRollLabel = New Label()
        RollButton = New Button()
        RestartButton = New Button()
        ControlPanel = New Panel()
        PlayerTurnLabel = New Label()
        BoardPanel.SuspendLayout()
        CType(PlayerOnePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PlayerTwoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        ControlPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' BoardPanel
        ' 
        BoardPanel.BackgroundImage = My.Resources.Resources.board
        BoardPanel.BackgroundImageLayout = ImageLayout.Stretch
        BoardPanel.Controls.Add(PlayerOnePictureBox)
        BoardPanel.Controls.Add(PlayerTwoPictureBox)
        BoardPanel.Location = New Point(-4, -2)
        BoardPanel.Name = "BoardPanel"
        BoardPanel.Size = New Size(1534, 1555)
        BoardPanel.TabIndex = 0
        ' 
        ' PlayerOnePictureBox
        ' 
        PlayerOnePictureBox.BackColor = Color.Transparent
        PlayerOnePictureBox.BackgroundImage = My.Resources.Resources.p2
        PlayerOnePictureBox.BackgroundImageLayout = ImageLayout.Stretch
        PlayerOnePictureBox.Location = New Point(37, 1432)
        PlayerOnePictureBox.Name = "PlayerOnePictureBox"
        PlayerOnePictureBox.Size = New Size(80, 80)
        PlayerOnePictureBox.TabIndex = 1
        PlayerOnePictureBox.TabStop = False
        ' 
        ' PlayerTwoPictureBox
        ' 
        PlayerTwoPictureBox.BackColor = Color.Transparent
        PlayerTwoPictureBox.BackgroundImage = My.Resources.Resources.p1
        PlayerTwoPictureBox.BackgroundImageLayout = ImageLayout.Stretch
        PlayerTwoPictureBox.Location = New Point(103, 1369)
        PlayerTwoPictureBox.Name = "PlayerTwoPictureBox"
        PlayerTwoPictureBox.Size = New Size(80, 80)
        PlayerTwoPictureBox.TabIndex = 0
        PlayerTwoPictureBox.TabStop = False
        ' 
        ' DiceRollLabel
        ' 
        DiceRollLabel.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        DiceRollLabel.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DiceRollLabel.ImageAlign = ContentAlignment.TopRight
        DiceRollLabel.Location = New Point(3, 74)
        DiceRollLabel.Name = "DiceRollLabel"
        DiceRollLabel.Size = New Size(429, 131)
        DiceRollLabel.TabIndex = 1
        DiceRollLabel.Text = "START"
        DiceRollLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RollButton
        ' 
        RollButton.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RollButton.Location = New Point(12, 218)
        RollButton.Name = "RollButton"
        RollButton.Size = New Size(410, 122)
        RollButton.TabIndex = 2
        RollButton.Text = "ROLL"
        RollButton.UseVisualStyleBackColor = True
        ' 
        ' RestartButton
        ' 
        RestartButton.Location = New Point(12, 1502)
        RestartButton.Name = "RestartButton"
        RestartButton.Size = New Size(410, 46)
        RestartButton.TabIndex = 3
        RestartButton.Text = "RESTART"
        RestartButton.UseVisualStyleBackColor = True
        ' 
        ' ControlPanel
        ' 
        ControlPanel.Controls.Add(PlayerTurnLabel)
        ControlPanel.Controls.Add(RestartButton)
        ControlPanel.Controls.Add(RollButton)
        ControlPanel.Controls.Add(DiceRollLabel)
        ControlPanel.Location = New Point(1538, -2)
        ControlPanel.Name = "ControlPanel"
        ControlPanel.Size = New Size(435, 1555)
        ControlPanel.TabIndex = 4
        ' 
        ' PlayerTurnLabel
        ' 
        PlayerTurnLabel.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        PlayerTurnLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PlayerTurnLabel.Location = New Point(12, 358)
        PlayerTurnLabel.Name = "PlayerTurnLabel"
        PlayerTurnLabel.Size = New Size(410, 64)
        PlayerTurnLabel.TabIndex = 4
        PlayerTurnLabel.Text = "Player 1 Turn"
        PlayerTurnLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1985, 1558)
        Controls.Add(ControlPanel)
        Controls.Add(BoardPanel)
        Name = "Form1"
        Text = "Form1"
        BoardPanel.ResumeLayout(False)
        CType(PlayerOnePictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PlayerTwoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ControlPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents BoardPanel As Panel
    Friend WithEvents DiceRollLabel As Label
    Friend WithEvents RollButton As Button
    Friend WithEvents RestartButton As Button
    Friend WithEvents PlayerOnePictureBox As PictureBox
    Friend WithEvents PlayerTwoPictureBox As PictureBox
    Friend WithEvents ControlPanel As Panel
    Friend WithEvents PlayerTurnLabel As Label

End Class
