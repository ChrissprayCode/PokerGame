using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerGame.Models;
using PokerGame;

namespace PokerGame.Interfaces
{
    public interface IHandEvaluator
    {
        bool IsRoyalFlush(Card[] hand);
        bool IsStraightFlush(Card[] hand);
        bool IsFourOfaKind(Card[] hand);
        bool IsFlush(Card[] hand);
        bool IsStraight(Card[] hand);
        bool IsThreeOfaKind(Card[] hand);
        bool IsTwoPair(Card[] hand);
        bool IsPair(Card[] hand);
        bool IsHighCard(Card[] hand);
        void TieBreaker(Card[] hand);

        Card[] SortHandByValue(Card[] hand);
        Card[] SortHandBySuit(Card[] hand);
    }
}
