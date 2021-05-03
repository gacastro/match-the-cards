namespace Code
{
    public class Player
    {
        public string Name { get; }
        public int Winnings { get; private set; }
        
        public Player(string name)
        {
            Name = name;
        }

        public void TakeWinnings(int pile)
        {
            Winnings += pile;
        }
    }
}