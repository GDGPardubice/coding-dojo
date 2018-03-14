import org.junit.jupiter.api.Assertions.assertEquals
import org.junit.jupiter.api.Test


class GemTest {

    @Test
    fun playerOneScoreStartsWithZero() {
        val gem = Gem()
        assertEquals(0, gem.getPlayerOneScore())
    }

    @Test
    fun playerOneScoresOnceAndHasFifteen() {
        val gem = Gem()
        gem.playerScores(Player.ONE)
        assertEquals(15, gem.getPlayerOneScore())
    }

    @Test
    fun playerOneScoresTwiceAndHasThirty() {
        val gem = Gem()
        gem.playerScores(Player.ONE)
        gem.playerScores(Player.ONE)
        assertEquals(30, gem.getPlayerOneScore())
    }

    @Test
    fun playerOneScoresThreeTimesAndHasForty() {
        val gem = Gem()
        gem.playerScores(Player.ONE)
        gem.playerScores(Player.ONE)
        gem.playerScores(Player.ONE)
        assertEquals(40, gem.getPlayerOneScore())
    }


    @Test
    fun playerOneScoresFourTimesAndHasStillForty() {
        val gem = Gem()
        gem.playerScores(Player.ONE)
        gem.playerScores(Player.ONE)
        gem.playerScores(Player.ONE)
        gem.playerScores(Player.ONE)
        assertEquals(40, gem.getPlayerOneScore())
    }

    @Test
    fun playerOneDoesNotWinUntilScoresFourTimes() {
        val gem = Gem()
        assertEquals(Gem.Winner.NONE, gem.getWinner())

        gem.playerScores(Player.ONE)
        assertEquals(Gem.Winner.NONE, gem.getWinner())

        gem.playerScores(Player.ONE)
        assertEquals(Gem.Winner.NONE, gem.getWinner())

        gem.playerScores(Player.ONE)
        assertEquals(Gem.Winner.NONE, gem.getWinner())

        gem.playerScores(Player.ONE)
        assertEquals(Gem.Winner.PLAYER_ONE, gem.getWinner())
    }

    @Test
    fun playerTwoScoreStartsWithZero() {
        val gem = Gem()
        assertEquals(0, gem.getPlayerTwoScore())
    }

    @Test
    fun playerTwoScoresOnceAndHasFifteen() {
        val gem = Gem()
        gem.playerScores(Player.TWO)
        assertEquals(15, gem.getPlayerTwoScore())
    }

    @Test
    fun playerTwoScoresOnceAndPlayerOneHasZero() {
        val gem = Gem()
        gem.playerScores(Player.TWO)
        assertEquals(0, gem.getPlayerOneScore())
    }


}
