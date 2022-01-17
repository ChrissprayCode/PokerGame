using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerGame.Models;
using PokerGame.Interfaces;

namespace PokerGame
{
    //Possibly refactor displayPlayerHand & displayCommunityCards

    class Dealer : Deck, IDealer
    {
        private Card[] playerHand;
        private Card[] computerHand;
        private Card[] sortedPlayerHand;
        private Card[] sortedComputerHand;
        private Card[] communityCards;
        public Deck deck = new Deck();
        public int totalCardsDealt;
        public const int handSize = 2;

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
        }

        public void DealAllCards()
        {
            // Deal cards to all players, one at a time
            // Deal card to player, computer, player, computer
            int cardInHand = 0;
            // ++ numofPlayers, until i <= numofPlayers+1
            for(int i=0; i < 3; i+=2)
            {
                playerHand[cardInHand] = getDeck[i];
                computerHand[cardInHand] = getDeck[i+1];
                cardInHand++;
                totalCardsDealt += 2;
            }

            
            //deal the community cards (5 cards in the middle)
            for(int i=totalCardsDealt; i < totalCardsDealt + 5; i++) //i=4, until i=9
            {
                communityCards[i - totalCardsDealt] = getDeck[i];
            }
        }

        public void BurnCard()
        {
            totalCardsDealt++;
        }

        public void DisplayPlayerHand()
        {
            Console.WriteLine("Your Hand:");

            for(int i=0; i<handSize; i++)
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

            Console.WriteLine("");
            /*
            Console.WriteLine("Computer Hand:");

            for (int i = 0; i < handSize; i++)
            {
                switch (computerHand[i].cardSuit.ToString())
                {
                    case "Diamonds":
                        Console.Write(computerHand[i].cardFaceValue + " \u2666 ");
                        break;
                    case "Hearts":
                        Console.Write(computerHand[i].cardFaceValue + " \u2665 ");
                        break;
                    case "Clubs":
                        Console.Write(computerHand[i].cardFaceValue + " \u2663 ");
                        break;
                    case "Spades":
                        Console.Write(computerHand[i].cardFaceValue + " \u2660 ");
                        break;
                }
            }
            */
            Console.WriteLine();
            
        }

        public void CommunityCardHandler(int round)
        {
            //display community cards
            Console.WriteLine("Community Cards:");

            switch (round)
            {
                case 0:
                    DisplayCommunityCards(0);
                    break;
                case 1:
                    DisplayCommunityCards(3);
                    break;
                case 2:
                    DisplayCommunityCards(4);
                    break;
                case 3:
                    DisplayCommunityCards(5);
                    break;
            }

        }

        public void DisplayCommunityCards(int numOfCardsToShow)
        {
            for (int i = 0; i < numOfCardsToShow; i++)
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
            Console.WriteLine("");
        }

        public void EvaluateHands(Card[] hand)
        {
            Console.WriteLine("Evaluating...");
            Card[] handToEvaluate = hand.Concat(communityCards).ToArray();


        }

    }

}
