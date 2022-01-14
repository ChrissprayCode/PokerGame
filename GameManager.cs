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

        }
    }
}
