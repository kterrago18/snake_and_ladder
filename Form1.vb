Imports System.Numerics

Public Class Form1

    Dim playerOneCoordinate() As Integer = {37, 1432}
    Dim playerTwoCoordinate() As Integer = {103, 1369}

    Dim playerOnePointLocation As New Point(playerOneCoordinate(0), playerOneCoordinate(1))
    Dim playerTwoPointLocation As New Point(playerTwoCoordinate(0), playerTwoCoordinate(1))

    Dim playerOneBoardLocation As Integer = 1
    Dim playerTwoBoardLocation As Integer = 1

    Dim diceNumberStr As String = "START"
    Dim diceNumberInt As Integer

    '0 - player one, 1 - player two
    Dim turnSwitch As Integer = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialLoad()
    End Sub

    Private Sub InitialLoad()
        PlayerOnePictureBox.Location = playerOnePointLocation
        PlayerTwoPictureBox.Location = playerTwoPointLocation
        DiceRollLabel.Text = diceNumberStr
    End Sub

    Private Sub SwitchTurn(ByVal diceRandomValue As Integer)
        If (turnSwitch = 0) Then
            PlayerTurnLabel.Text = "Player 1 Turn"
            SetBoardLocation(diceRandomValue, playerOneBoardLocation)
            MovePlayer(diceRandomValue, playerOnePointLocation, playerOneCoordinate, PlayerOnePictureBox)
            PlayerTwoTurn()
        Else
            PlayerTurnLabel.Text = "Player 2 Turn"
            SetBoardLocation(diceRandomValue, playerTwoBoardLocation)
            MovePlayer(diceRandomValue, playerTwoPointLocation, playerTwoCoordinate, PlayerTwoPictureBox)
            PlayerOneTurn()
        End If


    End Sub

    Private Sub PlayerOneTurn()
        turnSwitch = 0
    End Sub

    Private Sub PlayerTwoTurn()
        turnSwitch = 1
    End Sub


    Private Sub ResetGame()
        InitialLoad()
    End Sub

    Private Sub MovePlayer(ByRef diceValue As Integer, ByVal playerPointLocation As Point, ByVal playerCoordinate() As Integer, ByVal player As PictureBox)
        playerCoordinate(0) += diceValue
        playerCoordinate(0) = player.Location.X + (144 * diceValue)
        player.Location = New Point(playerCoordinate(0), playerCoordinate(1))
    End Sub

    Private Sub SetBoardLocation(ByRef value As Integer, ByVal boardLocation As Integer)
        boardLocation += value
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
