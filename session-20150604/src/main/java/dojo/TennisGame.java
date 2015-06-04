package dojo;

public class TennisGame {
    public static final String GUEST = "guest";
    public static final String HOME = "home";
    private Score score = new Score();
    private boolean isOver;
    private String advantage = "";

    public TennisGame() {
    }

    TennisGame(int homeScore, int guestScore) {
        score.setHome(homeScore);
        score.setGuest(guestScore);
    }

    public Score getScore() {
        return score;
    }

    public void homeScores() {
        processGameRules(HOME, score.getHome(), score.getGuests());
        score.setHome(incrementScore(score.getHome()));
    }

    public boolean isOver() {
        return isOver;
    }

    public void guestScores() {
        processGameRules(GUEST, score.getGuests(),  score.getHome());
        score.setGuest(incrementScore(score.getGuests()));
    }

    private void processGameRules(String team, int ownScore, int opponentScore) {
        if (ownScore == 40 && (opponentScore < 40 || advantage.equals(team))) {
            isOver = true;
        }
        if (ownScore == 40) {
            advantage = (!advantage.isEmpty() && !advantage.equals(team) ) ? "" : team;
        }
    }

    private int incrementScore(int score) {
        return score >= 30 ? 40 : score + 15;
    }
}
