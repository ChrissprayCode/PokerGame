using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerGame.Models;

namespace PokerGame.Interfaces
{
    public interface IHandEvaluator
    {
        bool IsRoyalFlush();
        bool IsStraightFlush();
        bool IsFourOfaKind();
        bool IsFlush();
        bool IsStraight();
        bool IsThreeOfaKind();
        bool IsTwoPair();
        bool IsPair();
        bool IsHighCard();
        void TieBreaker();

        //Card[] SortHandByValue();
        //Card[] SortHandBySuit();
    }
}
