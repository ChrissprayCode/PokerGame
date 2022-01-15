using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerGame.Models;
using PokerGame.Interfaces;


namespace PokerGame
{
    class HandEvaluator : IHandEvaluator
    {
        /* Royal Flush - 10,J,Q,K,A (Same Suit)
        * Straight Flush - Straight, Same Suit
        * Four of a Kind - Four of a kind
        * Full house - 3 of 1 card, 2 of other (any suit)
        * Flush - 5 cards of same suit
        * Straight - 5 numbers in a row
        * Three of a Kind - three of the same card
        * Two Pair - two pairs
        * Pair - single pair
        * High Card - nothing, just pick highest card
        */

        public bool IsRoyalFlush(Card[] hand)
        {
            return false;
        }

        public bool IsStraightFlush(Card[] hand)
        {
            return false;
        }

        public bool IsFourOfaKind(Card[] hand)
        {
            return false;
        }

        public bool IsFlush(Card[] hand)
        {
            return false;
        }

        public bool IsStraight(Card[] hand)
        {
            hand = SortHandByValue(hand);

            if (hand[0].cardFaceValue == hand[4].cardFaceValue - 5 || hand[1].cardFaceValue == hand[5].cardFaceValue - 5 || hand[3].cardFaceValue == hand[6].cardFaceValue - 5)
            {
                return true;
            }

            return false;
        }

        public bool IsThreeOfaKind(Card[] hand)
        {
            return false;
        }

        public bool IsTwoPair(Card[] hand)
        {
            return false;
        }

        public bool IsPair(Card[] hand)
        {
            for(int i = 0; i < hand.Length; i++)
            {
                for(int j=i+1; j < hand.Length; j++)
                {
                    if(hand[i].cardFaceValue == hand[j].cardFaceValue)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsHighCard(Card[] hand)
        {
            return false;
        }

        public void TieBreaker(Card[] hand)
        {
            
        }

        public Card[] SortHandByValue(Card[] hand)
        {
            for (int i = 0; i < hand.Length; i++)
            {
                for (int j = i+1; j < hand.Length; j++)
                {
                    if(hand[j].cardFaceValue > hand[i].cardFaceValue)
                    {
                        Card spareCard = new Card();
                        spareCard.cardFaceValue = hand[i].cardFaceValue;
                        spareCard.cardSuit = hand[i].cardSuit;

                        hand[i].cardFaceValue = hand[j].cardFaceValue;
                        hand[i].cardSuit = hand[j].cardSuit;

                        hand[j].cardFaceValue = spareCard.cardFaceValue;
                        hand[j].cardSuit = spareCard.cardSuit;

                        break;
                    }
                    
                }
                
            }
            return hand;
        }

        public Card[] SortHandBySuit(Card[] hand)
        {
            for (int i = 0; i < hand.Length; i++)
            {
                for (int j = i + 1; j < hand.Length; j++)
                {
                    if (hand[j].cardSuit > hand[i].cardSuit)
                    {
                        Card spareCard = new Card();
                        spareCard.cardFaceValue = hand[i].cardFaceValue;
                        spareCard.cardSuit = hand[i].cardSuit;

                        hand[i].cardFaceValue = hand[j].cardFaceValue;
                        hand[i].cardSuit = hand[j].cardSuit;

                        hand[j].cardFaceValue = spareCard.cardFaceValue;
                        hand[j].cardSuit = spareCard.cardSuit;

                        break;
                    }

                }

            }
            return hand;
        }

    }
}
