using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln.Code {
    public class Deck {
        // each deck is comprised of a list of tuples; where each tuple represents a card; the first item in
        // the tuple is the card's face (or value) while the second item is the card's suit
        private List<Tuple<int,int>> cards;
        // we also need to keep track of which card we are in the deck
        private int curCardIndex;

        // default constructor
        public Deck() {
            // create the a new deck and shuffle it
            newDeck();
            shuffleDeck();
        }

        
        // generates a new deck of int,int tuples that represent cards
        public void newDeck() {
            // card faces range from 0-12 (which represents 2-10, Jack, Queen, King, and Ace respectively)
            // card suits range from 0-3 (which represents diamonds, spades, hearts, and clubs respectively)
            cards = new List<Tuple<int, int>>();

            for (int f = 0; f <= 12; f++) {
                for (int s = 0; s <= 3; s++) {
                    cards.Add(new Tuple<int, int>(f, s));
                }
            }
        }

        // shuffle the deck until the cards are randomized
        public void shuffleDeck() {
            // if we're out of cards or we're down to our last card, go ahead and create a new deck
            if (cards == null || cards.Count == 0)
                newDeck();

            // we create a new random object using the current time as a "seed" (I think)
            Random rand = new Random(DateTime.Now.Millisecond);

            // create a list of cards to be shuffled and a list of already shuffled cards
            List<Tuple<int, int>> curCards = cards;
            List<Tuple<int, int>> shuffledCards = new List<Tuple<int, int>>();

            // while we still have unshuffled cards, grab a random index from those unshuffled cards and add it
            // to the shuffled list (removing the card from the original list in the process)
            while (curCards.Count > 0) {
                int index = rand.Next(0, curCards.Count);
                shuffledCards.Add(curCards[index]);
                curCards.RemoveAt(index);
            }

            // replace the unshuffled list of cards stored in the object with the now shuffled list
            this.cards = shuffledCards;
            curCardIndex = 0;
        }

        // return the next in the deck
        public Tuple<int,int> nextCard() {
            // if we're out of cards to return, shuffle the deck
            if (curCardIndex >= 52 - 5) {
                shuffleDeck();
            }

            return cards[curCardIndex++];
        }
    }
}
