using AwesomePokerGameSln.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln.Code {
    class CardImageHelper {

        // convert a card tuple to a bitmap
        public static Bitmap cardToBitmap(Tuple<int, int> card) {
            // we're given a tuple that has its first item as the face of the card and the second item as the
            // suit of the card
            int face = card.Item1;
            int suit = card.Item2;

            // determine the suit of the card
            string suitName = null;
            switch (suit) {
                case 0: suitName = "diamonds"; break;
                case 1: suitName = "spades"; break;
                case 2: suitName = "hearts"; break;
                case 3: suitName = "clubs"; break;
                default: suitName = ""; break;
            }

            // dynamically create the name of each card's bitmap by using the card's face and suit names
            string faceName = null;
            if (face <= 8) {
                // if the face is less than or equal to 8, that means it's between 2 and 10 (inclusive)
                faceName = "_" + (face + 2).ToString();
            }
            else {
                // otherwise, the face of the card is a jack, queen, king, or ace
                switch (face) {
                    case 9:  faceName = "jack"; break;
                    case 10: faceName = "queen"; break;
                    case 11: faceName = "king"; break;
                    case 12: faceName = "ace"; break;
                    default: faceName = ""; break;
                }
            }

            // return the bitmap with the dynamically created name
            return Resources.ResourceManager.GetObject(faceName + "_of_" + suitName) as Bitmap;
        }
    }
}
