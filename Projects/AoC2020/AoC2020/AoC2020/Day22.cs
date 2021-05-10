using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2020
{
    class Day22
    {
        public static List<int> playerOneList = new List<int>();
        public static List<int> playerTwoList = new List<int>();
        public static Queue<int> playerOne = new Queue<int>();
        public static Queue<int> playerTwo = new Queue<int>();

        public static void Execute()
        {
            playerOneList = FileParser.ParseFileInt(221);
            playerTwoList = FileParser.ParseFileInt(222);
            playerOne = FillDecks(playerOneList);
            playerTwo = FillDecks(playerTwoList);

            int answer = PartOne();
            Console.WriteLine("THE ANSWER IS: " + answer);
        }

        public static int PartOne()
        {
            while (playerOne.Count > 0 && playerTwo.Count > 0) PlayRound();

            if (playerOne.Count > 0) return CalculateResults(playerOne);
            else return CalculateResults(playerTwo);
        }

        public static void PlayRound()
        {
            int playerOneCard = playerOne.Dequeue();
            int playerTwoCard = playerTwo.Dequeue();

            if (playerOneCard > playerTwoCard)
            {
                playerOne.Enqueue(playerOneCard);
                playerOne.Enqueue(playerTwoCard);
            }
            else
            {
                playerTwo.Enqueue(playerTwoCard);
                playerTwo.Enqueue(playerOneCard);
            }
        }

        public static int CalculateResults(Queue<int> winner)
        {
            int result = 0;

            while (winner.Count > 0)
            {
                result += winner.Peek() * winner.Count();
                winner.Dequeue();
            }

            return result;
        }

        public static Queue<int> FillDecks(List<int> cards)
        {
            Queue<int> deck = new Queue<int>();
            foreach (int card in cards) deck.Enqueue(card);

            return deck;
        }
    }
}
