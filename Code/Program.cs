using System;
using System.Collections.Generic;
using Code.Helpers;

namespace Code
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Welcome to the command line game of match... Its in the game");
            
            var argumentParser = GetArgumentParser(args);
            if (argumentParser == null)
                return 1;
            
            var deck = new DeckOfCardsBuilder(argumentParser.NumberOfPacks).BuildShuffledDeck();
            var players = GetPlayers();
            var cardMatcher = new CardMatcher(argumentParser.MatchingCondition);
            var cardCounter =
                new CardCounterBuilder(
                        argumentParser.MatchingCondition,
                        argumentParser.NumberOfPacks)
                    .Build();

            var dealer = new Dealer(deck, players, cardMatcher, cardCounter);

            Play play;
            try
            {
                do
                {
                    play = dealer.Deals();
                } while (play.Continue);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Oops something went wrong:");
                Console.WriteLine($"=> {exception.Message}");
                return 1;
            }

            Console.WriteLine(
                play.Winner != null
                    ? $"=> Congratulations {play.Winner.Name}. You have won with {play.Score} cards"
                    : $"=> Its a tie. Both players scored {play.Score}");

            return 0;
        }
        
        private static ArgumentParser GetArgumentParser(IReadOnlyList<string> args)
        {
            var argumentParser = new ArgumentParser(args);

            if (argumentParser.ErrorMessages.Count == 0)
                return argumentParser;
            
            Console.WriteLine("Oops something went wrong:");
            foreach (var errorMessage in argumentParser.ErrorMessages)
            {
                Console.WriteLine($"=> {errorMessage}");
            }

            Console.WriteLine(string.Empty);
            Console.WriteLine("Please ensure you call the command as --n X and --c Y");
            Console.WriteLine("Where X is any number > 0");
            Console.WriteLine("And Y can only be:");
            Console.WriteLine("1 - for matching on the **suit** of two cards");
            Console.WriteLine("2 - for matching on the **value** of two cards");
            Console.WriteLine("3 - for matching on the **suit and value** of two cards");

            return null;
        }

        private static Queue<Player> GetPlayers()
        {
            var players = new Queue<Player>();
            players.Enqueue(new Player("Jack"));
            players.Enqueue(new Player("Joe"));
            
            return players;
        }
    }
}