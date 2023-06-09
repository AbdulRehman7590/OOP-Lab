using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    class Card
    {
        private int _value;
        private int _suit;

        public Card(int value, int suit)
        {
            _value = value;
            _suit = suit;
        }

        public int Value
        {
            get { return _value; }
        }

        public int Suit
        {
            get { return _suit; }
        }

        public string StringValue
        {
            get
            {
                string stringValue;
                if (_value == 1)
                {
                    stringValue = "Ace";
                }
                else if (_value == 11)
                {
                    stringValue = "Jack";
                }
                else if (_value == 12)
                {
                    stringValue = "Queen";
                }
                else if (_value == 13)
                {
                    stringValue = "King";
                }
                else
                {
                    stringValue = _value.ToString();
                }
                return stringValue;
            }
        }

        public string StringSuit
        {
            get
            {
                string stringSuit;
                if (_suit == 1)
                {
                    stringSuit = "Clubs";
                }
                else if (_suit == 2)
                {
                    stringSuit = "Diamonds";
                }
                else if (_suit == 3)
                {
                    stringSuit = "Spades";
                }
                else
                {
                    stringSuit = "Hearts";
                }
                return stringSuit;
            }
        }

        public string FullCard
        {
            get { return StringValue + " of " + StringSuit; }
        }
    }
}
