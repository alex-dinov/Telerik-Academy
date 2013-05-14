using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.Cards.Count == 0)
            {
                return string.Empty;
            }

            foreach (ICard card in this.Cards)
            {
                sb.AppendFormat("{0} ", card.ToString());
            }

            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
