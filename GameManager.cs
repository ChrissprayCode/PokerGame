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

            //create new deck, shuffle, and deal
            dealer.Deal();

            /* ROUND ZERO
             * bet round
             * ROUND ONE
             * Burn card
             * Deal flop (first 3 cards)
             * Bet
             * ROUND TWO
             * Burn card
             * flip turn (next card)
             * bet
             * ROUND THREE
             * Burn card
             * Deal river (reveal last card)
             * Bet
             * Evaluate hands
             * Payout winner
             */
        }
    }
}
