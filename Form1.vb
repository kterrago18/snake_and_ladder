﻿Public Class Form1

    Dim defaultPlayerCoordinate() As Integer = {65, 1431}

    Dim ladders(,) As Integer = {{5, 32}, {59, 99}, {75, 97}}
    Dim snakes(,) As Integer = {{36, 25}, {40, 19}, {78, 55}, {91, 54}}


    Dim playerOneBoardLocation As Integer = 1
    Dim playerTwoBoardLocation As Integer = 1

    Dim diceNumberStr As String = "START"
    Dim diceNumberInt As Integer

    '0 - player one, 1 - player two
    Dim playerTurnSwitch As Integer = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        InitialLoad()
    End Sub

    Private Sub InitialLoad()
        PlayerOnePictureBox.Location = New Point(defaultPlayerCoordinate(0), defaultPlayerCoordinate(1))
        PlayerTwoPictureBox.Location = New Point(defaultPlayerCoordinate(0), defaultPlayerCoordinate(1))
        DiceRollLabel.Text = diceNumberStr
        playerOneBoardLocation = 1
        playerTwoBoardLocation = 1
        labelPlayer1Position.Text = playerOneBoardLocation.ToString
        labelPlayer2Position.Text = playerTwoBoardLocation.ToString
        playerTurnSwitch = 1
        PlayerTurnLabel.Text = "Player 1"
        PlayerTurnLabel.ForeColor = Color.Blue
        diceNumberStr = "START"
        diceNumberInt = 0
    End Sub

    Private Sub SwitchTurn(ByVal diceRandomValue As Integer)
        If (playerTurnSwitch = 0) Then
            PlayerTurnLabel.Text = "Player 1"
            PlayerTurnLabel.ForeColor = Color.Blue

            playerTwoBoardLocation += diceRandomValue 'Track player board location
            MovePlayer(PlayerTwoPictureBox, playerTwoBoardLocation, labelPlayer2Position)
            PlayerTwoTurn()
        Else
            PlayerTurnLabel.Text = "Player 2"
            PlayerTurnLabel.ForeColor = Color.Crimson


            playerOneBoardLocation += diceRandomValue
            MovePlayer(PlayerOnePictureBox, playerOneBoardLocation, labelPlayer1Position)
            PlayerOneTurn()
        End If
    End Sub

    Private Sub PlayerOneTurn()
        playerTurnSwitch = 0
    End Sub

    Private Sub PlayerTwoTurn()
        playerTurnSwitch = 1
    End Sub


    Private Sub ResetGame()
        InitialLoad()
    End Sub

    Private Sub MovePlayer(ByVal player As PictureBox, ByRef playerBoardLocation As Integer, ByRef playerPositionLabel As Label)
        'Set label of player position
        SetLabelBoardLocation(playerBoardLocation, playerPositionLabel)

        'Set player location
        player.Location = SetBoardPosition(playerBoardLocation)

        'If player got a ladder
        For ladder = 0 To 2
            If playerBoardLocation = ladders(ladder, 0) Then
                MsgBox($"You got the ladder! Your position will increase to: {ladders(ladder, 1)}")
                player.Location = SetBoardPosition(ladders(ladder, 1))
                playerBoardLocation = ladders(ladder, 1)
                SetLabelBoardLocation(playerBoardLocation, playerPositionLabel)
            End If
        Next ladder

        'If player got  bitten by a snake
        For snake = 0 To 2
            If playerBoardLocation = snakes(snake, 0) Then
                MsgBox($"You got bitten by a snake! Your position will decrease to: {snakes(snake, 1)}")
                player.Location = SetBoardPosition(snakes(snake, 1))
                playerBoardLocation = snakes(snake, 1)
                SetLabelBoardLocation(playerBoardLocation, playerPositionLabel)
            End If
        Next snake

        'If the player has already been to the finish location.
        If playerBoardLocation = 100 Then
            If playerTurnSwitch Then
                MsgBox("The winner is Player 1! The game will reset.")
            Else
                MsgBox("The winner is Player 2! The game will reset.")
            End If
            ResetGame()
        End If

    End Sub

    Function SetBoardPosition(ByRef playerBoardLocation As Integer) As Point

        Dim x As Integer
        Dim y As Integer

        If playerBoardLocation <= 10 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(0) '1st row

        ElseIf playerBoardLocation <= 20 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(1) '2nd row

        ElseIf playerBoardLocation <= 30 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(2) '3rd row

        ElseIf playerBoardLocation <= 40 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(3) '4th row

        ElseIf playerBoardLocation <= 50 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(4) '5th row

        ElseIf playerBoardLocation <= 60 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(5) '6th row

        ElseIf playerBoardLocation <= 70 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(6) '7th row

        ElseIf playerBoardLocation <= 80 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(7) '8th row

        ElseIf playerBoardLocation <= 90 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(8) '9th row

        ElseIf playerBoardLocation <= 100 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(9) '10th row

        Else 'if player board location is greater then 100
            playerBoardLocation = 100 - (playerBoardLocation Mod 10)
            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(9) '10th row
        End If

        Return New Point(x, y)

    End Function

    Function SetXLocation(ByRef playerBoardLocation As Integer) As Integer
        Dim stepX As Integer = playerBoardLocation Mod 10

        Dim x As Integer

        If stepX = 0 Then
            x = defaultPlayerCoordinate(0) + (144 * 9)

        Else
            x = defaultPlayerCoordinate(0) + (144 * (stepX - 1))

        End If

        Return x

    End Function

    Function SetYLocation(ByRef boardRow As Integer) As Integer

        Dim y As Integer

        y = defaultPlayerCoordinate(1) - (148 * boardRow)

        Return y

    End Function

    Private Sub SetLabelBoardLocation(ByRef boardLocation As Integer, ByRef playerPositionLabel As Label)

        If boardLocation > 100 Then
            boardLocation = 100 - (boardLocation Mod 10)
        End If

        playerPositionLabel.Text = boardLocation.ToString

    End Sub

    Private Sub RollDice()
        Dim randomDice As Integer = GetRandom(1, 6)
        DiceRollLabel.Text = randomDice.ToString
        diceNumberInt = randomDice
        SwitchTurn(diceNumberInt)
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        RollDice()
    End Sub

    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        ResetGame()
    End Sub
End Class
