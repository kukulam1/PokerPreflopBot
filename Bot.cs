using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPreflopBot
{
    class Bot
    {
        public bool ShoveOrFold(Card c1, Card c2, int bb)
        {
            if (c1.myVALUE == c2.myVALUE)// Pair
                return true;
            if (bb <= 2 || bb >= 18) // Shoving any hand
                return true; 
            if (bb <= 3 || bb >= 17) //Shoving for 2.5/3bb effectively
            {
                if (OneOfCardsTENOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 4)
                    return true;
                if (Value(c1, c2) >= 3 && SameSuit(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 4 || bb >= 16) // Shoving for 3.5/4bb effectively
            {
                if (OneOfCardsJACKOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 9)
                    return true;
                if (Value(c1, c2) >= 7 && SameSuit(c1, c2))
                    return true;
                if (Value(c1, c2) >= 4 && SameSuit(c1, c2) && Connected2(c1,c2))
                    return true;
                return false;
            }
            if (bb <= 5 || bb >= 15) // Shoving for 4.5/5bb effectively
            {
                if (OneOfCardsJACKOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 10)
                    return true;
                if (Value(c1, c2) >= 8 && SameSuit(c1, c2))
                    return true;
                if (Value(c1, c2) >= 4 && SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 6 || bb >= 14) // Shoving for 5.5/6bb effectively
            {
                if (OneOfCardsQUEENOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 12)
                    return true;
                if (Value(c1, c2) >= 9 && SameSuit(c1, c2))
                    return true;
                if (Value(c1, c2) >= 9 && Connected(c1, c2))
                    return true;
                if (Value(c1, c2) >= 10 && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 4 && SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 7 && SameSuit(c1, c2) && Connected3(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 7 || bb >= 13) // Shoving for 6.5/7bb effectively
            {
                if (OneOfCardsQUEENOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 13)
                    return true;
                if (Value(c1, c2) >= 9 && SameSuit(c1, c2))
                    return true;
                if (Value(c1, c2) >= 9 && Connected(c1, c2))
                    return true;
                if (Value(c1, c2) >= 12 && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 4 && SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 7 && SameSuit(c1, c2) && Connected3(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 8 || bb >= 12) // Shoving for 7.5/8bb effectively
            {
                if (OneOfCardsKINGOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 13)
                    return true;
                if (Value(c1, c2) >= 10 && SameSuit(c1, c2))
                    return true;
                if (OneOfCardsJACKOrHigher(c1, c2) && SameSuit(c1, c2))
                    return true;
                if (Value(c1, c2) >= 11 && Connected(c1, c2))
                    return true;
                if (Value(c1, c2) >= 12 && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 4 && SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 7 && SameSuit(c1, c2) && Connected3(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 9 || bb >= 11) // Shoving for 8.5/9bb effectively
            {
                if (OneOfCardsKINGOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 14)
                    return true;
                if (Value(c1, c2) >= 11 && SameSuit(c1, c2))
                    return true;
                if (OneOfCardsJACKOrHigher(c1, c2) && SameSuit(c1, c2))
                    return true;
                if (Value(c1, c2) >= 11 && Connected(c1, c2))
                    return true;
                if (Value(c1, c2) >= 12 && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 4 && SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 7 && SameSuit(c1, c2) && Connected3(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 10 || bb >= 10) // Shoving for 8.5/9bb effectively
            {
                if (OneOfCardsKINGOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 15)
                    return true;
                if (Value(c1, c2) >= 11 && SameSuit(c1, c2))
                    return true;
                if (OneOfCardsJACKOrHigher(c1,c2) && SameSuit(c1, c2))
                    return true;
                if (Value(c1, c2) >= 11 && Connected(c1, c2))
                    return true;
                if (Value(c1, c2) >= 12 && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 4 && SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 7 && SameSuit(c1, c2) && Connected3(c1, c2))
                    return true;
                return false;
            }
            Console.WriteLine("Decision not defined?!?!");
            return false;
        }

        public bool FoldOrCall(Card c1, Card c2, int bb)
        {
            if (c1.myVALUE == c2.myVALUE)// Pair
                return true;
            if (bb <= 2 || bb >= 18) // Calling any hand
                return true;
            if (bb <= 3 || bb >= 17) // Calling 2.5/3bb
            {
                if (Value(c1, c2) >= 6)
                    return true;
                if (Value(c1, c2) >= 4 && SameSuit(c1, c2))
                    return true;
                if (SameSuit(c1, c2) && Connected(c1, c2))
                    return true;
                if (SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 4 || bb >= 16) // Shoving for 3.5/4bb effectively
            {
                if (OneOfCardsTENOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 12)
                    return true;
                if (Value(c1, c2) >= 6 && SameSuit(c1, c2))
                    return true;
                if (Value(c1, c2) >= 3 && SameSuit(c1, c2) && Connected(c1, c2))
                    return true;
                if (Value(c1, c2) >= 5 && SameSuit(c1, c2) && Connected3(c1, c2))
                    return true;
                if (Value(c1, c2) >= 7 && Connected(c1, c2))
                    return true;
                if (Value(c1, c2) >= 8 && Connected2(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 5 || bb >= 15) // Shoving for 4.5/5bb effectively
            {
                if (OneOfCardsQUEENOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 11)
                    return true;
                if (Value(c1, c2) >= 9 && SameSuit(c1, c2))
                    return true;
                if (Value(c1, c2) >= 7 && SameSuit(c1, c2) && Connected(c1, c2))
                    return true;
                if (Value(c1, c2) >= 8 && SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 9 && SameSuit(c1, c2) && Connected3(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 6 || bb >= 14) // Shoving for 5.5/6bb effectively
            {
                if (OneOfCardsQUEENOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 13)
                    return true;
                if (Value(c1, c2) >= 11 && SameSuit(c1, c2))
                    return true;
                if (OneOfCardsJACKOrHigher(c1,c2) && SameSuit(c1, c2))
                    return true;
                if (Value(c1, c2) >= 10 && SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 7 || bb >= 13) // Shoving for 6.5/7bb effectively
            {
                if (OneOfCardsKINGOrHigher(c1, c2))
                    return true;
                if (OneOfCardsQUEENOrHigher(c1, c2) && SameSuit(c1, c2))
                    return true;
                if (OneOfCardsQUEENOrHigher(c1, c2) && Value(c1,c2) >= 13)
                    return true;
                if (SameSuit(c1, c2) && Value(c1, c2) >= 14)
                    return true;
                if (Value(c1, c2) >= 15)
                    return true;
                if (Value(c1, c2) >= 14 && Connected2(c1, c2))
                    return true;
                if (Value(c1, c2) >= 12 && SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                return false;
            }
            if (bb <= 8 || bb >= 12) // Shoving for 7.5/8bb effectively
            {
                if (OneOfCardsKINGOrHigher(c1, c2))
                    return true;
                if (OneOfCardsQUEENOrHigher(c1, c2) && SameSuit(c1, c2))
                    return true;
                if (OneOfCardsQUEENOrHigher(c1, c2) && Value(c1, c2) >= 15)
                    return true;
                if (OneOfCardsJACKOrHigher(c1, c2) && SameSuit(c1, c2) && Value(c1,c2) >= 13)
                    return true;
                if (Value(c1, c2) >= 15)
                    return true;
                if (Value(c1, c2) >= 13 && SameSuit(c1, c2) && Connected(c1, c2))
                    return true;
                if (Value(c1, c2) >= 7 && SameSuit(c1, c2) && (Connected2(c1, c2) || (Connected3(c1,c2))))
                    return true;
                return false;
            }
            if (bb <= 9 || bb >= 11) // Shoving for 8.5/9bb effectively
            {
                if (OneOfCardsACE(c1, c2))
                    return true;
                if (OneOfCardsKINGOrHigher(c1, c2) && SameSuit(c1, c2))
                    return true;
                if (OneOfCardsKINGOrHigher(c1, c2) && Value(c1, c2) >= 13)
                    return true;
                if (OneOfCardsQUEENOrHigher(c1, c2) && SameSuit(c1, c2) && Value(c1,c2) >= 12)
                    return true;
                if (OneOfCardsQUEENOrHigher(c1, c2) && Value(c1, c2) >= 16)
                    return true;
                if (OneOfCardsJACKOrHigher(c1, c2) && SameSuit(c1, c2) && Connected4(c1,c2))
                    return true;
                if (Value(c1, c2) >= 16 && Connected2(c1,c2))
                    return true;
                if (Value(c1, c2) >= 14 && SameSuit(c1, c2) && Connected2(c1, c2))
                    return true;
                if (Connected(c1, c2) && OneOfCardsTENOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 13 && SameSuit(c1, c2) && Connected(c1,c2))
                    return true;
                return false;
            }
            if (bb <= 10 || bb >= 10) // Shoving for 8.5/9bb effectively
            {
                if (OneOfCardsACE(c1, c2))
                    return true;
                if (OneOfCardsKINGOrHigher(c1, c2) && SameSuit(c1, c2))
                    return true;
                if (OneOfCardsKINGOrHigher(c1, c2) && Value(c1, c2) >= 15)
                    return true;
                if (OneOfCardsQUEENOrHigher(c1, c2) && SameSuit(c1, c2) && Value(c1, c2) >= 14)
                    return true;
                if (OneOfCardsQUEENOrHigher(c1, c2) && Value(c1, c2) >= 16)
                    return true;
                if (OneOfCardsJACKOrHigher(c1, c2) && SameSuit(c1, c2) && Connected3(c1, c2))
                    return true;
                if (Value(c1, c2) >= 16 && Connected2(c1, c2))
                    return true;
                if (Connected(c1, c2) && OneOfCardsJACKOrHigher(c1, c2))
                    return true;
                if (Value(c1, c2) >= 15 && SameSuit(c1, c2) && Connected(c1, c2))
                    return true;
                return false;
            }
            Console.WriteLine("Decision not defined");
            return false;
        }

        private bool OneOfCardsTENOrHigher(Card c1, Card c2)
        {
            if (c1.myVALUE == Card.VALUE.TEN || c1.myVALUE == Card.VALUE.JACK || c1.myVALUE == Card.VALUE.QUEEN || c1.myVALUE == Card.VALUE.KING || c1.myVALUE == Card.VALUE.ACE)
                return true;
            if (c2.myVALUE == Card.VALUE.TEN || c2.myVALUE == Card.VALUE.JACK || c2.myVALUE == Card.VALUE.QUEEN || c2.myVALUE == Card.VALUE.KING || c2.myVALUE == Card.VALUE.ACE)
                return true;
            return false;
        }

        private bool OneOfCardsJACKOrHigher(Card c1, Card c2)
        {
            if (c1.myVALUE == Card.VALUE.JACK || c1.myVALUE == Card.VALUE.QUEEN || c1.myVALUE == Card.VALUE.KING || c1.myVALUE == Card.VALUE.ACE)
                return true;
            if (c2.myVALUE == Card.VALUE.JACK || c2.myVALUE == Card.VALUE.QUEEN || c2.myVALUE == Card.VALUE.KING || c2.myVALUE == Card.VALUE.ACE)
                return true;
            return false;
        }

        private bool OneOfCardsQUEENOrHigher(Card c1, Card c2)
        {
            if (c1.myVALUE == Card.VALUE.QUEEN || c1.myVALUE == Card.VALUE.KING || c1.myVALUE == Card.VALUE.ACE)
                return true;
            if (c2.myVALUE == Card.VALUE.QUEEN || c2.myVALUE == Card.VALUE.KING || c2.myVALUE == Card.VALUE.ACE)
                return true;
            return false;
        }

        private bool OneOfCardsKINGOrHigher(Card c1, Card c2)
        {
            if (c1.myVALUE == Card.VALUE.KING || c1.myVALUE == Card.VALUE.ACE)
                return true;
            if (c2.myVALUE == Card.VALUE.KING || c2.myVALUE == Card.VALUE.ACE)
                return true;
            return false;
        }

        private bool OneOfCardsACE(Card c1, Card c2)
        {
            if (c1.myVALUE == Card.VALUE.ACE || c2.myVALUE == Card.VALUE.ACE)
                return true;
            return false;
        }

        private bool SameSuit(Card c1, Card c2)
        {
            if (c1.mySUIT == c2.mySUIT)
                return true;
            else
                return false;
        }

        private bool Connected(Card c1,Card c2)
        {
            if (Math.Abs(c1.myVALUE - c2.myVALUE) == 1)
                return true;
            else
                return false;
        }

        private bool Connected2(Card c1, Card c2)
        {
            if (Math.Abs(c1.myVALUE - c2.myVALUE) == 2)
                return true;
            else
                return false;
        }

        private bool Connected3(Card c1, Card c2)
        {
            if (Math.Abs(c1.myVALUE - c2.myVALUE) == 3)
                return true;
            else
                return false;
        }

        private bool Connected4(Card c1, Card c2)
        {
            if (Math.Abs(c1.myVALUE - c2.myVALUE) == 4)
                return true;
            else
                return false;
        }

        private int Value(Card c1, Card c2)
        {
            int x = (int)(c1.myVALUE);
            int y = (int)(c2.myVALUE);
            return x + y;
        }

    }
}
