using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PokerPreflopBot 
{
    class Deck : Card
    {
        public int CardsDealt;
        public Card[] deck;

        public Deck()
        {
            deck = new Card[52];
        }

        public Card[] getDeck { get { return deck; } }

        //Create deck of 52 cards
        public void SetUpDeck()
        {
            CardsDealt = 0;
            int i = 0;
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(VALUE v in Enum.GetValues(typeof(VALUE)))
                {
                    deck[i] = new Card { mySUIT = s, myVALUE = v };
                    deck[i].image = GetImage(deck[i]);
                    i++;
                }
            }

            ShuffleDeck();
        }

        //Shuffle the deck
        public void ShuffleDeck()
        {
            Random rand = new Random();
            Card temp;

            //Swap 2 cards 52000 times
            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for (int i = 0; i < 52; i++)
                {
                    //swap the cards
                    int secondCardIndex = rand.Next(52);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            } 
        }

        public Image GetImage(Card card)
        {
            if (card.myVALUE == Card.VALUE.TWO && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources._2_CLUB;
            if (card.myVALUE == Card.VALUE.TWO && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources._2_HEARTS;
            if (card.myVALUE == Card.VALUE.TWO && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources._2_DIAMONDS;
            if (card.myVALUE == Card.VALUE.TWO && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources._2_SPADES;
            if (card.myVALUE == Card.VALUE.THREE && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources._3_CLUB;
            if (card.myVALUE == Card.VALUE.THREE && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources._3_HEARTS;
            if (card.myVALUE == Card.VALUE.THREE && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources._3_DIAMONDS;
            if (card.myVALUE == Card.VALUE.THREE && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources._3_SPADES;
            if (card.myVALUE == Card.VALUE.FOUR && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources._4_CLUB;
            if (card.myVALUE == Card.VALUE.FOUR && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources._4_HEARTS;
            if (card.myVALUE == Card.VALUE.FOUR && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources._4_DIAMONDS;
            if (card.myVALUE == Card.VALUE.FOUR && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources._4_SPADES;
            if (card.myVALUE == Card.VALUE.FIVE && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources._5_CLUB;
            if (card.myVALUE == Card.VALUE.FIVE && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources._5_HEARTS;
            if (card.myVALUE == Card.VALUE.FIVE && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources._5_DIAMONDS;
            if (card.myVALUE == Card.VALUE.FIVE && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources._5_SPADES;
            if (card.myVALUE == Card.VALUE.SIX && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources._6_CLUB;
            if (card.myVALUE == Card.VALUE.SIX && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources._6_HEARTS;
            if (card.myVALUE == Card.VALUE.SIX && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources._6_DIAMONDS;
            if (card.myVALUE == Card.VALUE.SIX && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources._6_SPADES;
            if (card.myVALUE == Card.VALUE.SEVEN && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources._7_CLUB;
            if (card.myVALUE == Card.VALUE.SEVEN && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources._7_HEARTS;
            if (card.myVALUE == Card.VALUE.SEVEN && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources._7_DIAMONDS;
            if (card.myVALUE == Card.VALUE.SEVEN && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources._7_SPADES;
            if (card.myVALUE == Card.VALUE.EIGHT && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources._8_CLUB;
            if (card.myVALUE == Card.VALUE.EIGHT && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources._8_HEARTS;
            if (card.myVALUE == Card.VALUE.EIGHT && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources._8_DIAMONDS;
            if (card.myVALUE == Card.VALUE.EIGHT && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources._8_SPADES;
            if (card.myVALUE == Card.VALUE.NINE && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources._9_CLUB;
            if (card.myVALUE == Card.VALUE.NINE && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources._9_HEARTS;
            if (card.myVALUE == Card.VALUE.NINE && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources._9_DIAMONDS;
            if (card.myVALUE == Card.VALUE.NINE && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources._9_SPADES;
            if (card.myVALUE == Card.VALUE.TEN && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources.T_CLUB;
            if (card.myVALUE == Card.VALUE.TEN && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources.T_HEARTS;
            if (card.myVALUE == Card.VALUE.TEN && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources.T_DIAMONDS;
            if (card.myVALUE == Card.VALUE.TEN && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources.T_SPADES;
            if (card.myVALUE == Card.VALUE.JACK && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources.J_CLUB;
            if (card.myVALUE == Card.VALUE.JACK && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources.J_HEARTS;
            if (card.myVALUE == Card.VALUE.JACK && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources.J_DIAMONDS;
            if (card.myVALUE == Card.VALUE.JACK && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources.J_SPADES;
            if (card.myVALUE == Card.VALUE.QUEEN && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources.Q_CLUB;
            if (card.myVALUE == Card.VALUE.QUEEN && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources.Q_HEARTS;
            if (card.myVALUE == Card.VALUE.QUEEN && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources.Q_DIAMONDS;
            if (card.myVALUE == Card.VALUE.QUEEN && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources.Q_SPADES;
            if (card.myVALUE == Card.VALUE.KING && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources.K_CLUB;
            if (card.myVALUE == Card.VALUE.KING && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources.K_HEARTS;
            if (card.myVALUE == Card.VALUE.KING && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources.K_DIAMONDS;
            if (card.myVALUE == Card.VALUE.KING && card.mySUIT == Card.SUIT.SPADE)
                return global::PokerPreflopBot.Properties.Resources.K_SPADES;
            if (card.myVALUE == Card.VALUE.ACE && card.mySUIT == Card.SUIT.CLUB)
                return global::PokerPreflopBot.Properties.Resources.A_CLUB;
            if (card.myVALUE == Card.VALUE.ACE && card.mySUIT == Card.SUIT.HEART)
                return global::PokerPreflopBot.Properties.Resources.A_HEARTS;
            if (card.myVALUE == Card.VALUE.ACE && card.mySUIT == Card.SUIT.DIAMOND)
                return global::PokerPreflopBot.Properties.Resources.A_DIAMONDS;
            else
                return global::PokerPreflopBot.Properties.Resources.A_SPADES;
        }
    }
}

