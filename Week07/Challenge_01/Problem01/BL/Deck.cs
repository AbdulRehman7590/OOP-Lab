using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    class Deck
    {
        private int _count;
        private Card[] _deck = new Card[52];

        public Deck()
        {
            _count = 0;
            for (int x = 1; x <= 4; x++)
            {
                for (int y = 1; y <= 13; y++)
                {
                    _deck[_count] = new Card(y, x);
                    _count++;
                }
            }
        }

        public void Shuffle()
        {
            System.Random rand = new System.Random();
            Card temp;
            for (int i = 0; i < 52; i++)
            {
                int num = rand.Next(0, 52);
                temp = _deck[num];
                _deck[num] = _deck[i];
                _deck[i] = temp;
            }
            _count = 52;
        }

        public Card DealCard()
        {
            if (_count > 0)
            {
                _count--;
                return _deck[_count];
            }
            return null;
        }

        public int LeftCards
        {
            get { return _count; }
        }
    }
}
