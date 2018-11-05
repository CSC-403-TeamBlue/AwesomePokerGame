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
        private int blind = 10;
        private int bet;
        private int dealerBet;
        private int playerPoints = 100;
        private int dealerPoints = 100;




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

            //set dealer's bet
            if (dealerPoints >= blind)
            {
                Random uhh = new Random();
                dealerBet = uhh.Next(blind, dealerPoints);
            }
            //If he doesn't have enough, he's all in
            else
            {
                dealerBet = dealerPoints;
            }

            bet = 0;

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
            label1.Text = playerPoints.ToString();
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

        private void Reset()
        {
            dealerPoints = 100;
            playerPoints = 100;
            FrmPlaygame frmPlaygame = new FrmPlaygame();
            frmPlaygame.Show();
            this.Dispose(false);
        }


        // redeal button
        private void button1_Click(object sender, EventArgs e) {

            RedealClick();
        }

        private void RedealClick()
        {
            button1.Enabled = true;
            betButton.Enabled = true;
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
            label_hand_type.Text = playerHand.getHandType().ToString();

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
            roundUpdate();
        }

        private void Bet_Click(object sender, EventArgs e)
        {
            Bet();
        }

        //Bet however many points you want as long as you have enough
        private void Bet()
        {
           
            //Opens a window to set your bet to match the dealer or all in
            using (FormBet formbet = new FormBet())
            {
                //If you have enough to match the dealer, you can bet it
                if (playerPoints >= dealerBet)
                {
                    formbet.label1.Visible = true;
                    formbet.label1.Text = "The dealer's bet is " + dealerBet;
                    formbet.numericUpDown1.Maximum = playerPoints;
                    formbet.numericUpDown1.Minimum = dealerBet;
                    formbet.numericUpDown1.Value = dealerBet;
                    formbet.ShowDialog();
                    bet = Convert.ToInt32(formbet.numericUpDown1.Value);
                }
                //If you don't have enough, you have to all in
                else if (playerPoints < dealerBet)
                {
                    formbet.label1.Text = "The dealer's bet is " + dealerBet + " You Must All In";
                    formbet.numericUpDown1.Visible = false;
                    formbet.label1.Visible = true;
                    formbet.ShowDialog();
                    bet = playerPoints;
                }
            }
        }
        //Update after bet has been made
        private void roundUpdate()
        {
            //if they didn't make a bet on the hand, set the default bet to the dealer's bet or go all in if the player doesn't have enough points
            if(bet <= 0)
            {
                if(playerPoints < dealerBet)
                {
                    bet = playerPoints;
                }
                else
                {
                    bet = dealerBet;
                }
            }

            //If your hand is better, you win the pot
            if ((int)playerHand.getHandType() < (int)dealerHand.getHandType())
            {
                MessageBox.Show("Your Hand Won", "Hand Results", MessageBoxButtons.OK);
                playerPoints += dealerBet;
                dealerPoints -= dealerBet;
            }
            //If your hand is worse, you lose
            else if ((int)playerHand.getHandType() > (int)dealerHand.getHandType())
            {
                MessageBox.Show("The Dealer's Hand Was Better", "Hand Results", MessageBoxButtons.OK);
                playerPoints -= bet;
                dealerPoints += bet;
            }
            //If you both have the same handtype, the pot is split
            else
            {
                MessageBox.Show("Split Pot!", "Hand Results", MessageBoxButtons.OK);
                double pot = dealerBet + bet;
                pot = Math.Floor(pot / 2);
                playerPoints -= bet;
                dealerPoints -= dealerBet;
                playerPoints += (int)pot;
                dealerPoints += (int)pot;
            }

            //Update points displayed
            label1.Text = playerPoints.ToString();
            //If you have points to bet, redeal
            if (playerPoints > 0 & dealerPoints > 0)
            {
                blind += 5;
                RedealClick();
            }
            //If you've run out, the game's over
            else if (playerPoints <= 0)
            {
                MessageBox.Show("You Lose", "Results", MessageBoxButtons.OK);
                Reset();
            }
            else if (dealerPoints <= 0)
            {
                MessageBox.Show("You Win!", "Results", MessageBoxButtons.OK);
                Reset();
            }



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
