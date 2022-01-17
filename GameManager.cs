using System;
using PokerGame.Models;

namespace PokerGame
{
    class GameManager
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dealer dealer = new Dealer();

            const int maxNumOfRounds = 4;
            
            //create new deck, shuffle, and deal
            dealer.Deal();
            

            for(int currentRound = 0; currentRound < maxNumOfRounds; currentRound++)
            {
                dealer.DisplayPlayerHand();
                dealer.CommunityCardHandler(currentRound);
                //ManageBetting();
                Console.ReadLine();

                if(currentRound == 3)
                {
                    //evaluate hand
                    break;
                }
            }
        }

        public enum BetOptions
        {
            Call,
            Fold,
            Raise,
            Check
        }


        void ManageBetting()
        {
            //everything related to betting goes in here.

        }
    }
}
