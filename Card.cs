using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace PokerPreflopBot
{
     public class Card
    {
        public Image image;

        public enum SUIT
        {
            HEART,
            DIAMOND,
            SPADE,
            CLUB
        }

        public enum VALUE
        {
            TWO,
            THREE,
            FOUR,
            FIVE,
            SIX,
            SEVEN,
            EIGHT,
            NINE,
            TEN,
            JACK,
            QUEEN,
            KING,
            ACE
        }

        public SUIT mySUIT { get; set; }
        public VALUE myVALUE { get; set; }
    }
}
