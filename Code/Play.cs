namespace Code
{
    public class Play
    {
        public int Score { get; }
        public bool Continue { get; }
        public Player Winner { get; }
        
        public Play(Player winner, bool continueGame, int score)
        {
            Winner = winner;
            Continue = continueGame;
            Score = score;
        }

        public Play(bool continueGame)
        {
            Continue = continueGame;
        }
    }
}