using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face &&
                        hand.Cards[i].Suit == hand.Cards[j].Suit && i != j)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (CountSameFacesOfCard(hand, hand.Cards[0].Face) == 4)
            {
                return true;
            }
            else if (CountSameFacesOfCard(hand, hand.Cards[1].Face) == 4)
            {
                return true;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            bool isFlush = true;
            CardSuit flushSuit = hand.Cards[0].Suit;

            foreach (var card in hand.Cards)
            {
                if (card.Suit != flushSuit)
                {
                    isFlush = false;
                }
            }

            return isFlush;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private static int CountSameFacesOfCard(IHand hand, CardFace face)
        {
            int countEqualFaces = 0;

            foreach (var card in hand.Cards)
            {
                if (card.Face == face)
                {
                    countEqualFaces++;
                }
            }
            return countEqualFaces;
        }

    }
}
