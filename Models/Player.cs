using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerGame.Interfaces;

namespace PokerGame.Models
{
    class Player
    {
        private Card[] hand;
        public bool isCPU = false;
        int holdings = 5000;
        public bool isInRound = true;
        

        public Player(bool isCPU, int holdings)
        {
            this.isCPU = isCPU;
            this.holdings = holdings;
        }



    }
}
