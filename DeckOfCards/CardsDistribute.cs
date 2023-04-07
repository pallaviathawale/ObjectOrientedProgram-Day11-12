using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    internal class CardsDistribute
    {
        private static readonly string[] SUITS = { "Clubs", "Diamonds", "Hearts", "Spades" };
        private static readonly string[] RANKS = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        private static readonly int NUM_CARDS = SUITS.Length * RANKS.Length;

        private List<string> _cards;
        private Random _random;

        public CardsDistribute()
        {
            _cards = new List<string>();
            _random = new Random();

            // Initialize deck of cards
            foreach (string suit in SUITS)
            {
                foreach (string rank in RANKS)
                {
                    _cards.Add($"{rank} of {suit}");
                }
            }
        }

        public void Shuffle()
        {
            // Shuffle the cards using Random method
            for (int i = 0; i < NUM_CARDS; i++)
            {
                int j = _random.Next(NUM_CARDS);
                string temp = _cards[i];
                _cards[i] = _cards[j];
                _cards[j] = temp;
            }
        }

        public string[,] DealCards()
        {
            string[,] cards = new string[4, 9];

            // Distribute 9 Cards to 4 Players
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cards[i, j] = _cards[i * 9 + j];
                }
            }

            return cards;
        }
    }
}

