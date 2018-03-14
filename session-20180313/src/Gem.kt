class Gem {

    enum class Winner {
        PLAYER_ONE,
        PLAYER_TWO,
        DEUCE,
        NONE
    }

    private var scoreOne = 0
    private var scoreTwo = 0
    private var winner = Winner.NONE

    fun getPlayerOneScore(): Int {
        return scoreOne
    }

    fun playerScores(who: Player) {
        var currentScore = if(who == Player.ONE) scoreOne else scoreTwo

        if (currentScore == 40) {
            winner = if (who == Player.ONE) Winner.PLAYER_ONE else Winner.PLAYER_TWO
            return
        }

        currentScore += if (currentScore < 30) 15 else 10

        if(who == Player.ONE)
            scoreOne = currentScore
        else
            scoreTwo = currentScore
    }

    fun playerTwoScores() {
        if (scoreTwo == 40) {
            winner = Winner.PLAYER_TWO
            return
        }

        scoreTwo += if (scoreTwo < 30) 15 else 10
    }

    fun getWinner(): Winner {
        return winner
    }

    fun getPlayerTwoScore():Int {
        return scoreTwo
    }

}