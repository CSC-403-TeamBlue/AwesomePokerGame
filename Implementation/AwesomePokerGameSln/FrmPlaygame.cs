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
        private int NumAllowedOptions = 3;
        List<CheckBox> Selections = new List<CheckBox>();



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

            // grab a new card for each card the player needs and give the card its respective image
            int index = 0;
            foreach (PictureBox playerCardPic in playerCardPics) {
                CardType card = deck.nextCard();
                cards[index++] = card;
                playerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
            }

            // set these cards as the player's hand, then start creating the dealer's hand
            playerHand = new Hand(cards);
            cards = new CardType[5];
            index = 0;

            // grab a new card for each card the dealer needs and give the card its respective image
            foreach (PictureBox dealerCardPic in dealerCardPics) {
                CardType card = deck.nextCard();
                cards[index++] = card;
                dealerCardPic.BackgroundImage = CardImageHelper.getResource("halloween_back");
            }

            // set those cards as the dealer's hand and then determine the best combination of cards in the
            // player's hand
            dealerHand = new Hand(cards);

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

            button1.Enabled = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;

            if (Selections.Count > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    Selections.RemoveAt(0);
                    i++;
                }
            }

            dealCards();
        }

        // discard button
        private void button2_Click(object sender, EventArgs e)
        {
            if (Selections.Count > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    Selections.RemoveAt(0);
                    i++;
                }
            }

            discardCards();
        }

        // reveal button
        private void button3_Click(object sender, EventArgs e)
        {
            revealDealerHand();
        }

        // Make sure we don't have too many options selected.
        private void chkOption_CheckChanged(object sender, EventArgs e)
        {

            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                // Add this selection.
                Selections.Add(chk);

                // Make sure we don't have too many.
                if (Selections.Count > NumAllowedOptions)
                {
                    // Remove the oldest selection.
                    Selections[0].Checked = false;
                    Selections.RemoveAt(0);
                }
            }
            else
            {
                // Remove this selection.
                Selections.Remove(chk);
            }
        }

        private void discardCards()
        {
            Tuple<int, int>[] playerCards = new Tuple<int, int>[5];
            playerCards = playerHand.getCurrentHand();

            if (checkBox1.Checked == true)
            {
                CardType playerCard = deck.nextCard();
                playerCards[0] = playerCard;
                checkBox1.Checked = false;
            }
            if (checkBox2.Checked == true)
            {
                CardType playerCard = deck.nextCard();
                playerCards[1] = playerCard;
                checkBox2.Checked = false;
            }
            if (checkBox3.Checked == true)
            {
                CardType playerCard = deck.nextCard();
                playerCards[2] = playerCard;
                checkBox3.Checked = false;
            }
            if (checkBox4.Checked == true)
            {
                CardType playerCard = deck.nextCard();
                playerCards[3] = playerCard;
                checkBox4.Checked = false;
            }
            if (checkBox5.Checked == true)
            {
                CardType playerCard = deck.nextCard();
                playerCards[4] = playerCard;
                checkBox5.Checked = false;
            }

            int playerIndex = 0;

            foreach (PictureBox playerCardPic in playerCardPics)
            {

                playerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(playerCards[playerIndex]);
                playerIndex++;
            }

            playerHand = new Hand(playerCards);

            Random RNG = new Random();
            // create an array of tuple that represents a card - the first integer is the face while the second
            // integer is the suit
            Tuple<int, int>[] cards = new Tuple<int, int>[5];
            int numberDealerToDiscard = RNG.Next(1, 6);

            //Create the array based off of the amount of cards the RNG  gave us
            int index = 0;
            cards = dealerHand.getCurrentHand();

            // grab a new card for each card the dealer needs
            for(int l = 0; l < numberDealerToDiscard; l++)
            {
                CardType card = deck.nextCard();
                cards[index++] = card;
             
            }

            foreach (PictureBox dealerCardPic in dealerCardPics)
            {

                dealerCardPic.BackgroundImage = CardImageHelper.getResource("halloween_back");
            }

            // set those cards as the dealer's hand
            dealerHand = new Hand(cards);

            button1.Enabled = false;
        }

        private void revealDealerHand()
        {
            Tuple<int, int>[] cards = new Tuple<int, int>[5];
            cards = dealerHand.getCurrentHand();
            int index = 0;
            foreach (PictureBox dealerCardPic in dealerCardPics)
            {
                
                dealerCardPic.BackgroundImage = CardImageHelper.cardToBitmap(cards[index]);
                index++;
            }
        }
    }
}
