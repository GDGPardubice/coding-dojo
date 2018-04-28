import org.junit.jupiter.api.Assertions
import org.junit.jupiter.api.Assertions.*
import org.junit.jupiter.api.Test

class PacmanTests {
    @Test
    fun `Game without initialization is not ready`() {
        val game: Game  = Game();
        assertEquals(false, game.isReady())
    }

    @Test
    fun `Game is ready after initialization with plan`() {
        val gamePlan = GamePlan(2, 2);
        val game: Game  = Game();
        game.plan = gamePlan;
        game.pacmanPosition = Position(0, 0)
        assertEquals(true, game.isReady())
    }

    @Test
    fun `Pacman after game initialization is on right position`() {
        val gamePlan = GamePlan(2, 2);
        val game: Game  = Game();
        game.plan = gamePlan;
        game.pacmanPosition = Position(0, 0)
        assertEquals(Position(0, 0), game.pacmanPosition)
    }

    @Test
    fun `Pacman after game initialization out of range position throw exception`() {
        val gamePlan = GamePlan(2,2)
        val game: Game  = Game();
        game.plan = gamePlan;
        Assertions.assertThrows(IndexOutOfBoundsException::class.java){
            game.pacmanPosition = Position(3, 2)
        }
    }
}