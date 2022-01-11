using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerGame.Interfaces;

namespace PokerGame.Models
{
    class Deck : Card, IDeck
    {
        const int maxCardNum = 52;
        private Card[] deck;

        public Deck()
        {
            deck = new Card[maxCardNum];
        }

        public void CreateDeck()
        {
            int count = 0;
            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach(FaceValue faceValue in Enum.GetValues(typeof(FaceValue)))
                {
                    deck[count] = new Card
                    {
                        cardSuit = suit,
                        cardFaceValue = faceValue
                    };
                    count++;
                }
            }

            ShuffleDeck();
        }

        public void ShuffleDeck()
        {
            Random rand = new Random();

            // Knuth-Fisher–Yates inside-out shuffle
            for (int i = deck.Length -1; i > 0; i--)
            {
                int randIndex = rand.Next(i + 1);

                Card temp = deck[i];
                deck[i] = deck[randIndex];
                deck[randIndex] = temp;
            }

        }

        public Card[] getDeck { get { return deck; } } //get the deck

    }
}
