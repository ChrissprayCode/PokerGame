using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.Interfaces
{
    interface IDealer
    {

        void Deal();
        void DealAllCards();
        void DisplayPlayerHand();
        void DisplayCommunityCards();
        void EvaluateHands();

    }
}
