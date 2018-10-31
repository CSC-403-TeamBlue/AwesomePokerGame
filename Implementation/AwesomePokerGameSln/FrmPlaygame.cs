using AwesomePokerGameSln.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardType = System.Tuple<int, int>;

namespace AwesomePokerGameSln {
    public partial class FrmPlaygame : Form {
        private Deck deck;
        private PictureBox[] playerCardPics;
        private PictureBox[] dealerCardPics;
        private Hand playerHand;
        private Hand dealerHand;
    
        // create the form
        public FrmPlaygame() {
            InitializeComponent();

            // create and display the cards for the player
            playerCardPics = new PictureBox[5];
            for (int c = 1; c <= 5; c++) {
                playerCardPics[c - 1] = this.Controls.Find("picCard" + c.ToString(), true)[0] as PictureBox;
            }

            // create and display the cards for the dealer
            dealerCardPics = new PictureBox[5];
            for (int c = 1; c <= 5; c++) {
                dealerCardPics[c - 1] = this.Controls.Find("pictureBox" + c.ToString(), true)[0] as PictureBox;
            }
        }

        // deal cards to the player and dealer
        private void dealCards() {
            // first shuffle the deck
            deck.shuffleDeck();

            // create an array of tuple that represents a card - the first integer is the face while the second
            // integer is the suit
            Tuple<int, int>[] cards = new Tuple<int, int>[5];

            // grab a new card for each card the dealer needs and give the card its respective image
            int index = 0;
            foreach (PictureBox playerCardPic in playerCardPics) {
                CardType card = deck.nextCard();
                cards[index++] = card;
                playerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }

            // set these cards as the dealer's hand, then start creating the player's hand
            dealerHand = new Hand(cards);
            cards = new CardType[5];
            index = 0;

            // grab a new card for each card the player needs and give the card its respective image
            foreach (PictureBox dealerCardPic in dealerCardPics) {
                CardType card = deck.nextCard();
                cards[index++] = card;
                dealerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }

            // set those cards as the player's hand and then determine the best combination of cards in the
            // player's hand
            playerHand = new Hand(cards);
            label_hand_type.Text = playerHand.getHandType().ToString();
        }
    
        // close all of the open windows
        private void FrmPlaygame_FormClosed(object sender, FormClosedEventArgs e) {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                Application.OpenForms[i].Close();
        }

        // load a new game
        private void FrmPlaygame_Load(object sender, EventArgs e) {
            // create a new deck and deal out its cards
            deck = new Deck();
            dealCards();
        }

        // redeal button
        private void button1_Click(object sender, EventArgs e) {
            dealCards();
        }
    }
}
