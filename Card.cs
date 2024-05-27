using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerApp
{
     class Card
    {
        public enum SUIT
        {
            HEARTS,
            SPADES,
            DIAMONDS,
            CLUBS
        }
        public enum VAlUE
        {
            TWO = 2, THREE, FOUR, FIVE,SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
        }
        public SUIT MySuit { get; set; }
        public VAlUE MyValue { get; set; }
    }
}
