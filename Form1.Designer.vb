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
        GroupBox2 = New GroupBox()
        PlayerTurnLabel = New Label()
        GroupBox1 = New GroupBox()
        labelPlayerOnePosition = New Label()
        labelPlayer2Position = New Label()
        labelPlayer1Position = New Label()
        labelPlayerTwoPosition = New Label()
        BoardPanel.SuspendLayout()
        CType(PlayerOnePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PlayerTwoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        ControlPanel.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
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
        PlayerOnePictureBox.Location = New Point(65, 1431)
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
        PlayerTwoPictureBox.Location = New Point(65, 1431)
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
        RestartButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RestartButton.Location = New Point(12, 1502)
        RestartButton.Name = "RestartButton"
        RestartButton.Size = New Size(410, 46)
        RestartButton.TabIndex = 3
        RestartButton.Text = "RESTART"
        RestartButton.UseVisualStyleBackColor = True
        ' 
        ' ControlPanel
        ' 
        ControlPanel.Controls.Add(GroupBox2)
        ControlPanel.Controls.Add(GroupBox1)
        ControlPanel.Controls.Add(RestartButton)
        ControlPanel.Controls.Add(RollButton)
        ControlPanel.Controls.Add(DiceRollLabel)
        ControlPanel.Location = New Point(1538, -2)
        ControlPanel.Name = "ControlPanel"
        ControlPanel.Size = New Size(435, 1555)
        ControlPanel.TabIndex = 4
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PlayerTurnLabel)
        GroupBox2.Location = New Point(12, 364)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(410, 142)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "TURN"
        ' 
        ' PlayerTurnLabel
        ' 
        PlayerTurnLabel.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        PlayerTurnLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PlayerTurnLabel.ForeColor = Color.Blue
        PlayerTurnLabel.Location = New Point(9, 35)
        PlayerTurnLabel.Name = "PlayerTurnLabel"
        PlayerTurnLabel.Size = New Size(395, 104)
        PlayerTurnLabel.TabIndex = 4
        PlayerTurnLabel.Text = "Player 1"
        PlayerTurnLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(labelPlayerOnePosition)
        GroupBox1.Controls.Add(labelPlayer2Position)
        GroupBox1.Controls.Add(labelPlayer1Position)
        GroupBox1.Controls.Add(labelPlayerTwoPosition)
        GroupBox1.Location = New Point(12, 550)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(410, 441)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "POSITION"
        ' 
        ' labelPlayerOnePosition
        ' 
        labelPlayerOnePosition.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        labelPlayerOnePosition.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPlayerOnePosition.ForeColor = Color.Blue
        labelPlayerOnePosition.Location = New Point(9, 160)
        labelPlayerOnePosition.Name = "labelPlayerOnePosition"
        labelPlayerOnePosition.Size = New Size(395, 45)
        labelPlayerOnePosition.TabIndex = 5
        labelPlayerOnePosition.Text = "Player One"
        labelPlayerOnePosition.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelPlayer2Position
        ' 
        labelPlayer2Position.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        labelPlayer2Position.Font = New Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPlayer2Position.ForeColor = Color.Crimson
        labelPlayer2Position.Location = New Point(6, 293)
        labelPlayer2Position.Name = "labelPlayer2Position"
        labelPlayer2Position.Size = New Size(398, 50)
        labelPlayer2Position.TabIndex = 8
        labelPlayer2Position.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelPlayer1Position
        ' 
        labelPlayer1Position.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        labelPlayer1Position.Font = New Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPlayer1Position.ForeColor = Color.Blue
        labelPlayer1Position.Location = New Point(6, 95)
        labelPlayer1Position.Name = "labelPlayer1Position"
        labelPlayer1Position.Size = New Size(398, 50)
        labelPlayer1Position.TabIndex = 7
        labelPlayer1Position.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelPlayerTwoPosition
        ' 
        labelPlayerTwoPosition.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        labelPlayerTwoPosition.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPlayerTwoPosition.ForeColor = Color.Crimson
        labelPlayerTwoPosition.Location = New Point(9, 343)
        labelPlayerTwoPosition.Name = "labelPlayerTwoPosition"
        labelPlayerTwoPosition.Size = New Size(395, 45)
        labelPlayerTwoPosition.TabIndex = 6
        labelPlayerTwoPosition.Text = "Player Two"
        labelPlayerTwoPosition.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1985, 1558)
        Controls.Add(ControlPanel)
        Controls.Add(BoardPanel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        Text = "SNAKE AND LADDER GAME"
        BoardPanel.ResumeLayout(False)
        CType(PlayerOnePictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PlayerTwoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ControlPanel.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
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
    Friend WithEvents labelPlayerTwoPosition As Label
    Friend WithEvents labelPlayerOnePosition As Label
    Friend WithEvents labelPlayer2Position As Label
    Friend WithEvents labelPlayer1Position As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class
