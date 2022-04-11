using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPreflopBot
{
    class GetCards 
    {
        //draw cards for both computer and player
        public static void GetCardsToPlayers(Deck deck,ref Player player,ref Player COM)
        {
            player.card1 = deck.deck[0];
            COM.card1 = deck.deck[1];
            player.card2 = deck.deck[2];
            COM.card2 = deck.deck[3];
        }


    }
}
