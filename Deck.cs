using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerApp
{
    class Deck : Card
    {
        const int NUM_OF_CARDS = 52;
        private Card[] deck;

        public Deck()
        {
            deck = new Deck[NUM_OF_CARDS];
        }

        public Card[] getDeck { get { return deck; } }

        public void setUpDeck()
        {
            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(VAlUE v in Enum.GetValues(typeof(VAlUE)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v };
                }
            }
        }
        ShuffleCards();
    }
    public void ShuffleCards();
}
