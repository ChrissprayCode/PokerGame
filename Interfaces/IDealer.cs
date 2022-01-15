using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerGame.Models;

namespace PokerGame.Interfaces
{
    interface IDealer
    {

        void Deal();
        void DealAllCards();
        void DisplayPlayerHand();
        void CommunityCardHandler(string round);
        void EvaluateHands(Card[] hand);

    }
}
