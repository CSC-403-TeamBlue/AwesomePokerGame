using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln.Code {
    // set up the possible hand combinations as enums, from best to worst
    public enum HandType {
        ROYAL_FLUSH,
        STR_FLUSH,
        FOUR,
        FULL_HOUSE,
        FLUSH,
        STRAIGHT,
        THREE,
        TWO_PAIRS,
        ONE_PAIR,
        HIGH
    }

    public class Hand {
        // a hand object is composed of an array of tuples which represent cards
        private Tuple<int, int>[] cards;
        private int[] aceLow = { 0, 1, 2, 3, 12};

        // default constructor
        public Hand(Tuple<int, int>[] cards) {
            this.cards = cards;
        }

        // determine how good the player's hand is
        public HandType getHandType() {
            // automatically assume the player has the worst hand (like actual garbage)
            HandType handType = HandType.HIGH;

            int[] values = cards.Select(card => card.Item1).ToArray();
            int uniqueCount = values.Distinct().Count();

            // print out the cards in our hand
            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine("Card " + i + " " + cards[i]);
            }

            // determine the hand type that we have depending on how many unique values
            // we have in our hand
            switch (uniqueCount) {
                // flush, straight, straight flush, royal flush
                case 5: {
                    // to aid us in determining if we have a straight, we need a sorted list of our
                    // card values and the min/max of those values
                    Array.Sort(values);
                    int min = values[0];
                    int max = values[values.Length - 1];
                    
                    // in determining a flush, we need to know the number of suits we have
                    int[] suits = cards.Select(card => card.Item2).ToArray();
                    
                    // if the range of the sorts list of values equals 4 or we're using ace as low,
                    // then we have a straight
                    if ((max - min) == 4 || values.SequenceEqual(aceLow)) { 
                        handType = HandType.STRAIGHT;
                        
                        // if we have a straight, that means we could potentially have a straight
                        // flush or royal flush
                        if (suits.Distinct().Count() == 1) { 
                            handType = HandType.STR_FLUSH;
                            
                            // if our highest card is an ace and our lowest is a 10, then we have
                            // a royal flush
                            if (max == 12 && min == 8)
                                handType = HandType.ROYAL_FLUSH;
                        }
                    }
                    // if we only have one suit of cards, then we have a flush
                    else if (suits.Distinct().Count() == 1) { 
                        handType = HandType.FLUSH;
                    }
                }
                break;

                // one pair
                case 4: {
                        // if there's only 4 unique cards, then we can only possibly have one pair
                        handType = HandType.ONE_PAIR;
                    }
                break;

                // two pair, three of a kind
                case 3: {
                    int x = values[0];
                    int freq = cards.Count(card => card.Item1 == x);
                    
                    // check the first value in our values array; if it only occurs once
                    // we need to check the next value
                    if (freq == 1) {
                        x = values[1];
                        freq = cards.Count(card => card.Item1 == x);
                        
                        // if the first value occurs twice, then we know it's a two pair
                        if (freq == 2) {
                            handType = HandType.TWO_PAIRS;
                        }
                        // if the first value occurs thrice, then we know it's three-of-a-kind
                        else {
                            handType = HandType.THREE;
                        }
                    }
                    // if the first value occurs twice, then we know it's a two pair
                    else if (freq == 2) {
                        handType = HandType.TWO_PAIRS;
                    }
                    // if the first value occurs thrice, then we know it's three-of-a-kind
                    else if (freq == 3) {
                        handType = HandType.THREE;
                    }
                }
                break;

                // full house or four of a kind
                case 2: {
                    int freq = cards.Count(card => card.Item1 == values[0]);

                    // if we have 2 or 3 cards that share the same face (or value),
                    // then the hand is a full house
                    if (freq == 2 || freq == 3) {
                        handType = HandType.FULL_HOUSE;
                    }
                    else {
                        handType = HandType.FOUR;
                    }
                }
                break;
            }

            // print out the number of unique cards and the hand type
            Console.WriteLine("Uniques - " + uniqueCount + " Hand Type - " + handType);

            return handType;
        }
    }
}
