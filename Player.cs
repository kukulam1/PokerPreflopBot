using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPreflopBot
{
    class Player
    {
        public int Chips;
        public Card card1;
        public Card card2;
        public enum Position { SB, BB};
        public enum Action { CALL,FOLD,ALLIN}
        public Position position;
        public Player(int chips,Position pos)
        {
            this.Chips = chips;
            position = pos;
        }

        public Action FoldOrCall (Player COM)
        {
            return Player.Action.CALL;
        }

        public  Action AllInOrFold(Player COM)
        {
            Bot bot = new Bot();
            if (bot.ShoveOrFold(COM.card1, COM.card2, COM.Chips / 10))
                return Player.Action.ALLIN;
            else
                return Player.Action.FOLD;
        }
    }
}
