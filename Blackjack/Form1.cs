using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Blackjack
{
    enum Status
    {
        BUST,
        LOSE,
        WIN,
        DRAW
    }
    public partial class Main : Form
    {
        // Draggable top
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Main()
        {
            InitializeComponent();
            playerCardBoxes = new PictureBox[5] { playerCard1, playerCard2, playerCard3, playerCard4, playerCard5 };
            split1CardBoxes = new PictureBox[5] { s11, s12, s13, s14, s15 };
            split2CardBoxes = new PictureBox[5] { s21, s22, s23, s24, s25 };
            dealerCardBoxes = new PictureBox[5] { dealer1, dealer2, dealer3, dealer4, dealer5 };
            GameHandler.startGame();
            updateCards();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void clearHand(PictureBox[] hand)
        {
            foreach(PictureBox pc in hand)
            {
                pc.Image = null;
            }
        }


        private void endGame(Status status)
        {
            playerTurn = false; // Debounce
            replayButton.Visible = true;
            statusLabel.Visible = true;
            switch(status)
            {
                case Status.BUST:
                    statusLabel.Text = "BUST! You lose.";
                    GameHandler.losses++;
                    return;
                case Status.LOSE:
                    statusLabel.Text = "You lose.";
                    GameHandler.losses++;
                    return;
                case Status.WIN:
                    statusLabel.Text = "You win!";
                    GameHandler.wins++;
                    return;
                case Status.DRAW:
                    statusLabel.Text = "Tie!";
                    GameHandler.draws++;
                    return;
            }
        }
        private void replayButton_Click(object sender, EventArgs e)
        {
            clearHand(playerCardBoxes);
            clearHand(dealerCardBoxes);
            clearHand(split1CardBoxes);
            clearHand(split2CardBoxes);



            replayButton.Visible = false;
            statusLabel.Visible = false;
            playerTurn = true;
            playerHand.Visible = true;
            split1Hand.Visible = false;
            split2Hand.Visible = false;

            DeckHandler.shuffleCards();
            GameHandler.startGame();
            updateCards();
            winLossLabel.Text = $"{GameHandler.wins}-{GameHandler.losses}-{GameHandler.draws}";
            if (GameHandler.playerHand[0].getValue() == GameHandler.playerHand[1].getValue())
                splitButton.Visible = true;
        }

        private void standButton_Click(object sender, EventArgs e) // Ends the game and calculates who won.
        {
            if (GameHandler.split && GameHandler.handToPlay++ == 2)
            {
                GameHandler.dealerPlay();
                updateCards(true);
                // End game
                int dealerScore = GameHandler.getHandValue(GameHandler.dealerHand);
                if (dealerScore > 21)
                {
                    endGame(Status.WIN);
                    return;
                }

                int score = Math.Max(GameHandler.getHandValue(GameHandler.playerSplit1),
                                     GameHandler.getHandValue(GameHandler.playerSplit2));
                if (score > dealerScore)
                    endGame(Status.WIN);
                else
                    endGame(Status.LOSE);
            }
            else if(!GameHandler.split)
            {
                GameHandler.dealerPlay();
                updateCards(true);
                // End game
                int dealerScore = GameHandler.getHandValue(GameHandler.dealerHand);
                if (dealerScore > 21)
                {
                    endGame(Status.WIN);
                    return;
                }
                if (GameHandler.getHandValue(GameHandler.playerHand) > dealerScore)
                    endGame(Status.WIN);
                else
                    endGame(Status.LOSE);
            }
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            splitButton.Visible = false;
            GameHandler.Hit();
            updateCards();
        }

        private PictureBox[] playerCardBoxes;
        private PictureBox[] dealerCardBoxes;
        private PictureBox[] split1CardBoxes;
        private PictureBox[] split2CardBoxes;
        internal static bool playerTurn = true;

        private void updateCards(bool showDealer = false)
        {
            // Dealer
            string add = "";
            int dealerScore = GameHandler.getHandValue(GameHandler.dealerHand);
            int playerScore = 0;
            int playerScore1 = 0;
            int playerScore2 = 0;

            for(int i = 0; i < 5; i++)
            {
                // Dealer
                if (i < GameHandler.dealerHand.Count())
                    dealerCardBoxes[i].Image = GameHandler.dealerHand[i].image;
                

                // Player
                if (GameHandler.split)
                {
                    if (i < GameHandler.playerSplit1.Count())
                        split1CardBoxes[i].Image = GameHandler.playerSplit1[i].image;
                    if (i < GameHandler.playerSplit2.Count())
                        split2CardBoxes[i].Image = GameHandler.playerSplit2[i].image;
                }
                else
                {
                    if (i < GameHandler.playerHand.Count())
                        playerCardBoxes[i].Image = GameHandler.playerHand[i].image;
                }
            }

            if (!showDealer)
            {
                dealerCardBoxes[0].Image = Properties.Resources.back;
                dealerScore = GameHandler.dealerHand[1].getValue();
                add = "+?";
            }

            dealerValueLabel.Text = $"{dealerScore}{add}/21";

            // Player
            if (GameHandler.split)
            {
                playerScore1 = GameHandler.getHandValue(GameHandler.playerSplit1);
                playerScore2 = GameHandler.getHandValue(GameHandler.playerSplit2);
                split1Value.Text = $"{playerScore1}/21";
                split2Value.Text = $"{playerScore2}/21";
                if (playerScore1 > 21)
                    s1Label.Visible = true;
                if (playerScore2 > 21)
                    s2Label.Visible = true;
                if (playerScore1 > 21 && playerScore2 > 21)
                    endGame(Status.BUST);
            }
            else
            {
                playerScore = GameHandler.getHandValue(GameHandler.playerHand);
                valueLabel.Text = $"{playerScore}/21";
                if (playerScore > 21)
                    endGame(Status.BUST);
            }
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            GameHandler.split = true;
            GameHandler.handToPlay = 1;
            GameHandler.playerSplit1.Add(GameHandler.playerHand[0]);
            GameHandler.playerSplit2.Add(GameHandler.playerHand[1]);

            playerHand.Visible = false;
            split1Hand.Visible = true;
            split2Hand.Visible = true;
            updateCards();
            splitButton.Visible = false;
        }
    }
}
