using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace PokerPreflopBot
{
    public partial class Game : Form
    {
        private bool EndOfGame;
        private Player player;
        private Player COM;
        private Deck deck;
        private System.Media.SoundPlayer SoundPlayer;
        public Game()
        {
            InitializeComponent();
            EndOfGame = false;
            player = new Player(100, Player.Position.SB);
            COM = new Player(100, Player.Position.BB);
            deck = new Deck();
            deck.SetUpDeck();
            SoundPlayer = new System.Media.SoundPlayer();
            Hand();
            ChooseWinner();
            if (!EndOfGame)
                Hand();
            
        }

        private void Hand()
        {
            deck.ShuffleDeck();
            GetCards.GetCardsToPlayers(deck, ref player, ref COM);
            PlayerCard1.Image = player.card1.image;
            PlayerCard2.Image = player.card2.image;
            COMActionBox.Text = "";
            PlayerActionBox.Text = "";
            COMCard1.Image = Properties.Resources.PokerCardBack;
            COMCard2.Image = Properties.Resources.PokerCardBack;
            Flop1.Image = Properties.Resources.PokerCardBack;
            Flop2.Image = Properties.Resources.PokerCardBack;
            Flop3.Image = Properties.Resources.PokerCardBack;
            Turn.Image = Properties.Resources.PokerCardBack;
            River.Image = Properties.Resources.PokerCardBack;
            Preflop_Play();
        }

        private void Preflop_Play()
        {
            if (player.Chips == 5 || COM.Chips == 5)
            {
                PotBox.Text = "10";
                PlayersAreAllIn();
                return;
            }
            if (player.position == Player.Position.SB) // if player or COM have 5 chips on BB
            {
                PlayerBetBox.Text = "5";
                PlayerChipsBox.Text = (player.Chips - 5).ToString();
                COMBetBox.Text = "10";
                ComputerChipsBox.Text = (COM.Chips - 10).ToString();
                PotBox.Text = "15";
            }
            else
            {
                PlayerBetBox.Text = "10";
                PlayerChipsBox.Text = (player.Chips - 10).ToString();
                COMBetBox.Text = "5";
                ComputerChipsBox.Text = (COM.Chips - 5).ToString();
                PotBox.Text = "15";
                if (COM.AllInOrFold(COM) == Player.Action.ALLIN)
                    COMAllIn();
                else
                    COMFolded();
            }
        }

        private async void COMAllIn()
        {
            await Task.Delay(500);
            COMActionBox.Text = "ALL-IN";
            COMBetBox.Text = (COM.Chips).ToString();
            ComputerChipsBox.Text = "0";
            if (COM.position == Player.Position.SB)
                PotBox.Text = (COM.Chips + 10).ToString();
            else
                PotBox.Text = (COM.Chips + 5).ToString();
        }

        private void PlayerAllIn()
        {
            PlayerActionBox.Text = "ALL-IN";
            PlayerBetBox.Text = (player.Chips).ToString();
            PlayerChipsBox.Text = "0";
            if (player.position == Player.Position.SB)
                PotBox.Text = (player.Chips + 10).ToString();
            else
                PotBox.Text = (player.Chips + 5).ToString();
        }

        private void PlayerFolded()
        {
            if (player.position == Player.Position.SB)
            {
                player.Chips -= 5;
                COM.Chips += 5;
            }
            else
            {
                player.Chips -= 10;
                COM.Chips += 10;
            }
            ChangePositions();
            Hand();
        }

        private async void COMFolded()
        {
            await Task.Delay(1000);
            COMActionBox.Text = "FOLD";
            await Task.Delay(1000);
            if (COM.position == Player.Position.SB)
            {
                COM.Chips -= 5;
                player.Chips += 5;
              //  PotTextBox.Text = "COM Folded From SB"; 
            }
            else
            {
                COM.Chips -= 10;
                player.Chips += 10;
            }

            ChangePositions();
            Hand();
        }

        private async void PlayersAreAllIn()
        {
            int pot;
            if (player.Chips <= COM.Chips)
            {
                pot = player.Chips * 2;
                if (COM.Chips - player.Chips > 0)
                {
                    ComputerChipsBox.Text = (COM.Chips - player.Chips).ToString();
                    PlayerChipsBox.Text = "0";
                    COMBetBox.Text = (player.Chips).ToString();
                    PlayerBetBox.Text = (player.Chips).ToString();
                }
            }
            else
            {
                pot = COM.Chips * 2;
                PlayerChipsBox.Text = (player.Chips - COM.Chips).ToString();
                ComputerChipsBox.Text = "0";
                COMBetBox.Text = (COM.Chips).ToString();
                PlayerBetBox.Text = (COM.Chips).ToString();
            }
            PotBox.Text = (pot).ToString();
            await Task.Delay(500);
            COMCard1.Image = COM.card1.image;
            COMCard2.Image = COM.card2.image;
            await Task.Delay(500);
            //sound
            Flop1.Image = deck.deck[5].image;
            Flop2.Image = deck.deck[6].image;
            Flop3.Image = deck.deck[7].image;
            await Task.Delay(500);
            Turn.Image = deck.deck[9].image;
            await Task.Delay(500);
            River.Image = deck.deck[11].image;
            await Task.Delay(1000);
            //WHO WINS GETS CHIPS
            if (COM.Chips == 0 || player.Chips == 0)
                EndOfGame = true;
            else
            {
                ChangePositions();
                Hand();
            }
        }

        private void ChangePositions()
        {
            if (COM.position == Player.Position.SB)
            {
                COM.position = Player.Position.BB;
                player.position = Player.Position.SB;
            }
            else
            {
                COM.position = Player.Position.SB;
                player.position = Player.Position.BB;
            }
        }

        private void ChooseWinner()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        public void ShowCards(PictureBox PictureBox, Card card)
        {
            PictureBox.Image = card.image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (player.position == Player.Position.SB)
            {
                PlayerAllIn();
                Bot bot = new Bot();
                if (bot.FoldOrCall(COM.card1, COM.card2, COM.Chips / 10))
                {
                    PlayersAreAllIn();
                    COMActionBox.Text = "CALL";
                }
                else
                    COMFolded();
            }
            else
                PlayersAreAllIn();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FoldButton_Click(object sender, EventArgs e)
        {
            PlayerFolded();
        }

        private void PlayerCard1_Click(object sender, EventArgs e)
        {

        }

        private void ComputerChipsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Flop2_Click(object sender, EventArgs e)
        {

        }

        private void COMCard1_Click(object sender, EventArgs e)
        {
        }

        private void River_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
/*
    public class Game
    {
        public Player Player1;
        public Player Player2;

    }

    public class Player
    {
        public int Chips;
        public int Card1;
        public int Card2;
    }
    */
}
