using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.Models
{
    public class Card
    {
        public enum Suit
        {
            Diamonds,
            Hearts,
            Clubs,
            Spades
        }

        public enum FaceValue
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

        public Suit cardSuit { get; set; }
        public FaceValue cardFaceValue { get; set; }
}
}
