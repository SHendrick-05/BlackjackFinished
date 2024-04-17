using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.Resources;

namespace Blackjack
{
    internal static class GameHandler
    {
        internal static int wins = 0;
        internal static int losses = 0;
        internal static int draws = 0;

        internal static bool playerBust()
        {
            if (!split)
                return isBust(playerHand);
            else
                return isBust(playerSplit1) && isBust(playerSplit2);
        }

        internal static bool isBust(List<Card> cards)
        {
            int total = 0;
            foreach(Card c in cards)
            {
                total += c.getValue();
            }
            return total > 21;
        }

        internal static int getHandValue(List<Card> cards)
        {
            int total = 0;
            bool soft = false;
            foreach (Card c in cards)
            {
                total += c.getValue();
                if (c.value == Value.ACE) soft = true;
            }
            if (soft && total < 12) total += 10;
            return total;
        }

        internal static bool split = false;
        internal static bool playing = true;

        // 0 = playerHand, 1 = s1, 2 = s2
        internal static int handToPlay = 0;

        internal static List<Card> dealerHand = new List<Card>();
        internal static List<Card> playerHand = new List<Card>();

        internal static List<Card> playerSplit1 = new List<Card>();
        internal static List<Card> playerSplit2 = new List<Card>();


        internal static void startGame()
        {
            dealerHand.Clear();
            playerHand.Clear();
            playerSplit1.Clear();
            playerSplit2.Clear();

            dealerHand.Add(DeckHandler.drawCard());
            dealerHand.Add(DeckHandler.drawCard());
            playerHand.Add(DeckHandler.drawCard());
            playerHand.Add(DeckHandler.drawCard());
        }

        internal static void dealerPlay()
        {
            while (getHandValue(dealerHand) < 17)
            {
                dealerHand.Add(DeckHandler.drawCard());
            }
        }

        internal static void Hit()
        {
            switch (handToPlay)
            {
                case 0:
                    playerHand.Add(DeckHandler.drawCard());
                    break;
                case 1:
                    playerSplit1.Add(DeckHandler.drawCard());
                    break;
                case 2:
                    playerSplit2.Add(DeckHandler.drawCard());
                    break;
            }
        }
    }
}
