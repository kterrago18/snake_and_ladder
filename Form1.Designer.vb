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
        RollButtonPlayerOne = New Button()
        RestartButton = New Button()
        RollButtonPlayerTwo = New Button()
        labelPlayerOnePosition = New Label()
        labelPlayer2Position = New Label()
        labelPlayer1Position = New Label()
        labelPlayerTwoPosition = New Label()
        BoardPanel.SuspendLayout()
        CType(PlayerOnePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PlayerTwoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BoardPanel
        ' 
        BoardPanel.BackgroundImage = My.Resources.Resources.board1
        BoardPanel.BackgroundImageLayout = ImageLayout.Stretch
        BoardPanel.Controls.Add(PlayerOnePictureBox)
        BoardPanel.Controls.Add(PlayerTwoPictureBox)
        BoardPanel.Location = New Point(-4, -2)
        BoardPanel.Name = "BoardPanel"
        BoardPanel.Size = New Size(1243, 1280)
        BoardPanel.TabIndex = 0
        ' 
        ' PlayerOnePictureBox
        ' 
        PlayerOnePictureBox.BackColor = Color.Transparent
        PlayerOnePictureBox.BackgroundImage = My.Resources.Resources.p2
        PlayerOnePictureBox.BackgroundImageLayout = ImageLayout.Stretch
        PlayerOnePictureBox.Location = New Point(61, 1013)
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
        PlayerTwoPictureBox.Location = New Point(61, 1129)
        PlayerTwoPictureBox.Name = "PlayerTwoPictureBox"
        PlayerTwoPictureBox.Size = New Size(80, 80)
        PlayerTwoPictureBox.TabIndex = 0
        PlayerTwoPictureBox.TabStop = False
        ' 
        ' DiceRollLabel
        ' 
        DiceRollLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DiceRollLabel.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DiceRollLabel.ImageAlign = ContentAlignment.TopRight
        DiceRollLabel.Location = New Point(429, 1281)
        DiceRollLabel.Name = "DiceRollLabel"
        DiceRollLabel.Size = New Size(400, 146)
        DiceRollLabel.TabIndex = 1
        DiceRollLabel.Text = "ROLL THE DICE!"
        DiceRollLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RollButtonPlayerOne
        ' 
        RollButtonPlayerOne.BackColor = Color.CornflowerBlue
        RollButtonPlayerOne.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RollButtonPlayerOne.ForeColor = Color.White
        RollButtonPlayerOne.Location = New Point(10, 1440)
        RollButtonPlayerOne.Name = "RollButtonPlayerOne"
        RollButtonPlayerOne.Size = New Size(413, 77)
        RollButtonPlayerOne.TabIndex = 2
        RollButtonPlayerOne.Text = "ROLL"
        RollButtonPlayerOne.UseVisualStyleBackColor = False
        ' 
        ' RestartButton
        ' 
        RestartButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RestartButton.Location = New Point(429, 1440)
        RestartButton.Name = "RestartButton"
        RestartButton.Size = New Size(400, 77)
        RestartButton.TabIndex = 3
        RestartButton.Text = "RESTART GAME"
        RestartButton.UseVisualStyleBackColor = True
        ' 
        ' RollButtonPlayerTwo
        ' 
        RollButtonPlayerTwo.BackColor = Color.RosyBrown
        RollButtonPlayerTwo.Font = New Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RollButtonPlayerTwo.ForeColor = Color.White
        RollButtonPlayerTwo.Location = New Point(835, 1440)
        RollButtonPlayerTwo.Name = "RollButtonPlayerTwo"
        RollButtonPlayerTwo.Size = New Size(404, 77)
        RollButtonPlayerTwo.TabIndex = 9
        RollButtonPlayerTwo.Text = "ROLL"
        RollButtonPlayerTwo.UseVisualStyleBackColor = False
        ' 
        ' labelPlayerOnePosition
        ' 
        labelPlayerOnePosition.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        labelPlayerOnePosition.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPlayerOnePosition.ForeColor = Color.Blue
        labelPlayerOnePosition.Location = New Point(12, 1382)
        labelPlayerOnePosition.Name = "labelPlayerOnePosition"
        labelPlayerOnePosition.Size = New Size(411, 45)
        labelPlayerOnePosition.TabIndex = 5
        labelPlayerOnePosition.Text = "Player One"
        labelPlayerOnePosition.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelPlayer2Position
        ' 
        labelPlayer2Position.Anchor = AnchorStyles.None
        labelPlayer2Position.Font = New Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPlayer2Position.ForeColor = Color.Crimson
        labelPlayer2Position.Location = New Point(835, 1311)
        labelPlayer2Position.Name = "labelPlayer2Position"
        labelPlayer2Position.Size = New Size(404, 50)
        labelPlayer2Position.TabIndex = 8
        labelPlayer2Position.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelPlayer1Position
        ' 
        labelPlayer1Position.Anchor = AnchorStyles.None
        labelPlayer1Position.Font = New Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPlayer1Position.ForeColor = Color.Blue
        labelPlayer1Position.Location = New Point(10, 1311)
        labelPlayer1Position.Name = "labelPlayer1Position"
        labelPlayer1Position.Size = New Size(411, 50)
        labelPlayer1Position.TabIndex = 7
        labelPlayer1Position.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' labelPlayerTwoPosition
        ' 
        labelPlayerTwoPosition.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        labelPlayerTwoPosition.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPlayerTwoPosition.ForeColor = Color.Crimson
        labelPlayerTwoPosition.Location = New Point(835, 1382)
        labelPlayerTwoPosition.Name = "labelPlayerTwoPosition"
        labelPlayerTwoPosition.Size = New Size(404, 45)
        labelPlayerTwoPosition.TabIndex = 6
        labelPlayerTwoPosition.Text = "Player Two"
        labelPlayerTwoPosition.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1243, 1529)
        Controls.Add(labelPlayer1Position)
        Controls.Add(labelPlayerOnePosition)
        Controls.Add(RollButtonPlayerTwo)
        Controls.Add(labelPlayer2Position)
        Controls.Add(RollButtonPlayerOne)
        Controls.Add(RestartButton)
        Controls.Add(BoardPanel)
        Controls.Add(DiceRollLabel)
        Controls.Add(labelPlayerTwoPosition)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form1"
        Text = "SNAKE AND LADDER GAME"
        BoardPanel.ResumeLayout(False)
        CType(PlayerOnePictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PlayerTwoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BoardPanel As Panel
    Friend WithEvents DiceRollLabel As Label
    Friend WithEvents RollButtonPlayerOne As Button
    Friend WithEvents RestartButton As Button
    Friend WithEvents PlayerOnePictureBox As PictureBox
    Friend WithEvents PlayerTwoPictureBox As PictureBox
    Friend WithEvents labelPlayerTwoPosition As Label
    Friend WithEvents labelPlayerOnePosition As Label
    Friend WithEvents labelPlayer2Position As Label
    Friend WithEvents labelPlayer1Position As Label
    Friend WithEvents RollButtonPlayerTwo As Button

End Class
