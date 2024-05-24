Public Class Form1

    Dim defaultPlayerCoordinate() As Integer = {61, 1129}

    Dim ladders(,) As Integer = {{4, 23}, {13, 46}, {33, 52}, {42, 63}, {50, 69}, {62, 81}, {74, 93}}
    Dim snakes(,) As Integer = {{40, 2}, {27, 5}, {43, 17}, {54, 31}, {66, 45}, {89, 53}, {95, 76}, {99, 41}}

    Dim playerOneBoardLocation As Integer = 1
    Dim playerTwoBoardLocation As Integer = 1

    Dim diceNumberStr As String
    Dim diceNumberInt As Integer

    Dim playerTurnSwitch As Integer

    'This will execute when the form is loaded
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen() 'Load this window at center of the screen
        InitialLoad() 'Setting initials values
    End Sub

    Private Sub InitialLoad()
        PlayerOnePictureBox.Location = New Point(defaultPlayerCoordinate(0), defaultPlayerCoordinate(1))
        PlayerTwoPictureBox.Location = New Point(defaultPlayerCoordinate(0), defaultPlayerCoordinate(1))
        diceNumberStr = "ROLL THE DICE!"
        DiceRollLabel.Text = diceNumberStr
        playerOneBoardLocation = 1
        playerTwoBoardLocation = 1
        labelPlayer1Position.Text = playerOneBoardLocation.ToString
        labelPlayer2Position.Text = playerTwoBoardLocation.ToString
        playerTurnSwitch = 0 '0 - player one, 1 - player two
        diceNumberInt = 0
        RollButtonPlayerOne.Enabled = True
        RollButtonPlayerTwo.Enabled = False
    End Sub

    Private Sub PlayerTurning(ByVal diceRandomValue As Integer)
        'When it's player one's turn
        If (playerTurnSwitch = 0) Then
            playerOneBoardLocation += diceRandomValue
            MovePlayer(PlayerOnePictureBox, playerOneBoardLocation, labelPlayer1Position)
            PlayerTwoTurn() 'Switch Player
        Else 'When it's player two's turn
            playerTwoBoardLocation += diceRandomValue 'Track player board location
            MovePlayer(PlayerTwoPictureBox, playerTwoBoardLocation, labelPlayer2Position)
            PlayerOneTurn() 'Switch Player
        End If
    End Sub

    Private Sub PlayerOneTurn()
        playerTurnSwitch = 0

        RollButtonPlayerOne.Enabled = True
        RollButtonPlayerTwo.Enabled = False
    End Sub

    Private Sub PlayerTwoTurn()
        playerTurnSwitch = 1
        RollButtonPlayerOne.Enabled = False
        RollButtonPlayerTwo.Enabled = True
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
        For ladder = 0 To 6
            If playerBoardLocation = ladders(ladder, 0) Then
                MsgBox($"You got the ladder! Your position will increase to: {ladders(ladder, 1)}")
                player.Location = SetBoardPosition(ladders(ladder, 1))
                playerBoardLocation = ladders(ladder, 1)
                SetLabelBoardLocation(playerBoardLocation, playerPositionLabel)
            End If
        Next ladder

        'If player got  bitten by a snake
        For snake = 0 To 7
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

            x = SetXLocation(playerBoardLocation, True)
            y = SetYLocation(1) '2nd row

        ElseIf playerBoardLocation <= 30 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(2) '3rd row

        ElseIf playerBoardLocation <= 40 Then

            x = SetXLocation(playerBoardLocation, True)
            y = SetYLocation(3) '4th row

        ElseIf playerBoardLocation <= 50 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(4) '5th row

        ElseIf playerBoardLocation <= 60 Then

            x = SetXLocation(playerBoardLocation, True)
            y = SetYLocation(5) '6th row

        ElseIf playerBoardLocation <= 70 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(6) '7th row

        ElseIf playerBoardLocation <= 80 Then

            x = SetXLocation(playerBoardLocation, True)
            y = SetYLocation(7) '8th row

        ElseIf playerBoardLocation <= 90 Then

            x = SetXLocation(playerBoardLocation)
            y = SetYLocation(8) '9th row

        ElseIf playerBoardLocation <= 100 Then

            x = SetXLocation(playerBoardLocation, True)
            y = SetYLocation(9) '10th row

        Else 'if player board location is greater then 100
            playerBoardLocation = 100 - (playerBoardLocation Mod 10)
            x = SetXLocation(playerBoardLocation, True)
            y = SetYLocation(9) '10th row
        End If

        Return New Point(x, y)

    End Function

    Function SetXLocation(ByRef playerBoardLocation As Integer, Optional ByVal isBackward As Boolean = False) As Integer
        Dim stepX As Integer = playerBoardLocation Mod 10 'This will get the remaining value, ex. 25 mod 10, the value is 5. 

        Dim x As Integer


        If isBackward Then
            If stepX = 0 Then
                x = defaultPlayerCoordinate(0)
            Else
                x = defaultPlayerCoordinate(0) + (117 * (10 - stepX))
            End If
        Else
            If stepX = 0 Then
                x = defaultPlayerCoordinate(0) + (117 * 9)
            Else
                x = defaultPlayerCoordinate(0) + (117 * (stepX - 1))
            End If
        End If



        Return x

    End Function

    Function SetYLocation(ByRef boardRow As Integer) As Integer

        Dim y As Integer

        '116 is equivalent of one step vertically
        y = defaultPlayerCoordinate(1) - (116 * boardRow)
        'if the boardRow is 0, it means it's on 1st row, if 1 it's on 2nd row, and so on..

        Return y

    End Function

    'This will update the label of player's location
    Private Sub SetLabelBoardLocation(ByRef boardLocation As Integer, ByRef playerPositionLabel As Label)

        If boardLocation > 100 Then
            boardLocation = 100 - (boardLocation Mod 10)
        End If

        playerPositionLabel.Text = boardLocation.ToString

    End Sub

    Private Sub RollDice()
        Dim randomDice As Integer = GetRandom(1, 6) 'Getting 1 integer number from 1-6 randomly
        DiceRollLabel.Text = randomDice.ToString 'Displaying selected random rolled dice number
        diceNumberInt = randomDice
        PlayerTurning(diceNumberInt) 'The movement of the player depending on diceNumberInt value
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButtonPlayerOne.Click
        RollDice()
    End Sub

    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        ResetGame()
    End Sub

    Private Sub RollButtonPlayerTwo_Click(sender As Object, e As EventArgs) Handles RollButtonPlayerTwo.Click
        RollDice()
    End Sub
End Class
