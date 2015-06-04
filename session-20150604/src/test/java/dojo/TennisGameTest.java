package dojo;

import dojo.TennisGame;
import org.junit.Test;

import static org.junit.Assert.*;

public class TennisGameTest {

    public static final int STARTING_SCORE = 0;

    @Test
    public void homeTeamHaveZeroScoreAtBeginning() {
        TennisGame game = new TennisGame();
        assertEquals(STARTING_SCORE, game.getScore().getHome());
    }

    @Test
    public void questTeamHaveZeroScoreAtBeginning() {
        TennisGame game = new TennisGame();
        assertEquals(STARTING_SCORE, game.getScore().getGuests());
    }

    @Test
    public void homeTeamGetFirstBall() {
        TennisGame game = new TennisGame();
        game.homeScores();
        assertEquals(15, game.getScore().getHome());
    }

    @Test
    public void homeTeamGetSecondBall() {
        TennisGame game = new TennisGame();
        game.homeScores();
        game.homeScores();
        assertEquals(30, game.getScore().getHome());
    }

    @Test
    public void homeTeamGetThirdBall() {
        TennisGame game = new TennisGame();
        game.homeScores();
        game.homeScores();
        game.homeScores();
        assertEquals(40, game.getScore().getHome());
    }

    @Test
    public void guestTeamHasAllowedScores() {
        TennisGame game = new TennisGame();
        game.guestScores();
        assertEquals(15, game.getScore().getGuests());
        game.guestScores();
        assertEquals(30, game.getScore().getGuests());
        game.guestScores();
        assertEquals(40, game.getScore().getGuests());
    }

    @Test
    public void homeTeamWinTheGameAfterScoringFourTimesInLine() {
        TennisGame game = new TennisGame(40, 0);
        game.homeScores();
        assertEquals(true, game.isOver());
    }

    @Test
    public void homeTeamWithFortyPointsDoesNotWinGame() {
        TennisGame game = new TennisGame(40, 0);
        assertEquals(false, game.isOver());
    }

    @Test
    public void guestTeamWinTheGameAfterScoringFourTimesInLine() {
        TennisGame game = new TennisGame(0, 40);
        game.guestScores();
        assertEquals(true, game.isOver());
    }

    @Test
    public void homeScoresDoesNotCauseToEndGame() {
        TennisGame game = new TennisGame(0, 0);
        game.homeScores();
        assertEquals(false, game.isOver());
    }

    @Test
    public void maxScoreIsForty() {
        TennisGame game = new TennisGame(40, 40);
        game.homeScores();
        game.guestScores();
        assertEquals(40, game.getScore().getHome());
        assertEquals(40, game.getScore().getGuests());
    }

    @Test
    public void whenIsDeuceFortyPointsIsNotOver() {
        TennisGame game = new TennisGame(40, 40);
        game.homeScores();
        assertEquals(false, game.isOver());
    }

    @Test
    public void whenGuestScoresOnDeuceTheGameIsNotOver() {
        TennisGame game = new TennisGame(40, 40);
        game.guestScores();
        assertEquals(false, game.isOver());
    }

    @Test
    public void whenGuestScoresOnAdvantageTheGameIsOver() {
        TennisGame game = new TennisGame(40, 40);
        game.guestScores();
        game.guestScores();
        assertEquals(true, game.isOver());
    }

    @Test
    public void whenHomeScoresOnAdvantageTheGameIsOver() {
        TennisGame game = new TennisGame(40, 40);
        game.homeScores();
        game.homeScores();
        assertEquals(true, game.isOver());
    }

    @Test
    public void banana() {
        TennisGame game = new TennisGame(40, 40);
        game.homeScores();
        game.guestScores();
        game.guestScores();
        assertEquals(false, game.isOver());
    }
}