using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerGame.Models;

namespace PokerGame.Interfaces
{
    interface IPlayer
    {
        Card[] hand { get; set; }
        bool isCPU { get; set; }
        bool isInCurrentRound { get; set; }
        int holdings { get; set; }

        void Bet();



    }
}
