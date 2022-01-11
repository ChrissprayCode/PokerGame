using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerGame.Models;
using PokerGame.Interfaces;

namespace PokerGame
{
    class Dealer : Deck, IDealer
    {
        private Card[] playerHand;
        private Card[] computerHand;
        private Card[] communityCards;
        public Deck deck = new Deck();
        public int totalCardsDealt;

        public Dealer()
        {
            playerHand = new Card[2];
            computerHand = new Card[2];
            communityCards = new Card[5];
            totalCardsDealt = 0;
        }

        public void Deal()
        {
            CreateDeck();
            DealAllCards();
            DisplayPlayerHand();
            DisplayCommunityCards();
            //EvaluateHands();
        }

        public void DealAllCards()
        {

            
            // Deal cards to all players, one at a time
            // Deal card to player, computer, player, computer
            int cardInHand = 0;
            for(int i=0; i < 3; i+=2)
            {
                playerHand[cardInHand] = getDeck[i];
                computerHand[cardInHand] = getDeck[i+1];
                cardInHand++;
                totalCardsDealt += 2;
            }

            //deal the community cards (5 cards in the middle)
            for(int i=totalCardsDealt; i < totalCardsDealt + 5; i++)
            {
                communityCards[i - totalCardsDealt] = getDeck[i];
            }
        }

        public void DisplayPlayerHand()
        {
            Console.WriteLine("Your Hand:");

            for(int i=0; i<2; i++)
            {
                switch (playerHand[i].cardSuit.ToString())
                {
                    case "Diamonds":
                        Console.Write(playerHand[i].cardFaceValue + " \u2666 ");
                        break;
                    case "Hearts":
                        Console.Write(playerHand[i].cardFaceValue + " \u2665 ");
                        break;
                    case "Clubs":
                        Console.Write(playerHand[i].cardFaceValue + " \u2663 ");
                        break;
                    case "Spades":
                        Console.Write(playerHand[i].cardFaceValue + " \u2660 ");
                        break;
                }
            }
            Console.WriteLine();
        }

        public void DisplayCommunityCards()
        {
            //display community cards
            Console.WriteLine("Community Cards:");
            for (int i = 0; i < 5; i++)
            {
                switch (communityCards[i].cardSuit.ToString())
                {
                    case "Diamonds":
                        Console.Write(communityCards[i].cardFaceValue + " \u2666 ");
                        break;
                    case "Hearts":
                        Console.Write(communityCards[i].cardFaceValue + " \u2665 ");
                        break;
                    case "Clubs":
                        Console.Write(communityCards[i].cardFaceValue + " \u2663 ");
                        break;
                    case "Spades":
                        Console.Write(communityCards[i].cardFaceValue + " \u2660 ");
                        break;
                }
            }
        }

        public void EvaluateHands()
        {
            Console.WriteLine("Pog");
        }

    }

}
