namespace PokerPreflopBot
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.FoldButton = new System.Windows.Forms.Button();
            this.AllinButton = new System.Windows.Forms.Button();
            this.PlayerChipsTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ComputerChipsBox = new System.Windows.Forms.TextBox();
            this.PlayerChipsBox = new System.Windows.Forms.TextBox();
            this.PotTextBox = new System.Windows.Forms.TextBox();
            this.PotBox = new System.Windows.Forms.TextBox();
            this.COMBetBox = new System.Windows.Forms.TextBox();
            this.PlayerBetBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.PlayerCard1 = new System.Windows.Forms.PictureBox();
            this.PlayerCard2 = new System.Windows.Forms.PictureBox();
            this.COMCard1 = new System.Windows.Forms.PictureBox();
            this.COMCard2 = new System.Windows.Forms.PictureBox();
            this.Flop3 = new System.Windows.Forms.PictureBox();
            this.Turn = new System.Windows.Forms.PictureBox();
            this.River = new System.Windows.Forms.PictureBox();
            this.Flop2 = new System.Windows.Forms.PictureBox();
            this.Flop1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PlayerActionBox = new System.Windows.Forms.TextBox();
            this.COMActionBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Turn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.River)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FoldButton
            // 
            this.FoldButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FoldButton.Location = new System.Drawing.Point(670, 510);
            this.FoldButton.Name = "FoldButton";
            this.FoldButton.Size = new System.Drawing.Size(153, 73);
            this.FoldButton.TabIndex = 3;
            this.FoldButton.Text = "FOLD";
            this.FoldButton.UseVisualStyleBackColor = true;
            this.FoldButton.EnabledChanged += new System.EventHandler(this.FoldButton_Click);
            this.FoldButton.Click += new System.EventHandler(this.FoldButton_Click);
            // 
            // AllinButton
            // 
            this.AllinButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllinButton.Location = new System.Drawing.Point(851, 510);
            this.AllinButton.Name = "AllinButton";
            this.AllinButton.Size = new System.Drawing.Size(153, 73);
            this.AllinButton.TabIndex = 4;
            this.AllinButton.Text = "ALL-IN";
            this.AllinButton.UseVisualStyleBackColor = true;
            this.AllinButton.EnabledChanged += new System.EventHandler(this.button5_Click);
            this.AllinButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // PlayerChipsTextBox
            // 
            this.PlayerChipsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerChipsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerChipsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerChipsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerChipsTextBox.Location = new System.Drawing.Point(148, 572);
            this.PlayerChipsTextBox.Name = "PlayerChipsTextBox";
            this.PlayerChipsTextBox.Size = new System.Drawing.Size(126, 24);
            this.PlayerChipsTextBox.TabIndex = 7;
            this.PlayerChipsTextBox.Text = "Your chips:";
            this.PlayerChipsTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(104, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 25);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Computer chips:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ComputerChipsBox
            // 
            this.ComputerChipsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComputerChipsBox.BackColor = System.Drawing.SystemColors.Control;
            this.ComputerChipsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComputerChipsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
            this.ComputerChipsBox.Location = new System.Drawing.Point(280, 40);
            this.ComputerChipsBox.Name = "ComputerChipsBox";
            this.ComputerChipsBox.Size = new System.Drawing.Size(84, 55);
            this.ComputerChipsBox.TabIndex = 16;
            this.ComputerChipsBox.Text = "100";
            this.ComputerChipsBox.TextChanged += new System.EventHandler(this.ComputerChipsBox_TextChanged);
            // 
            // PlayerChipsBox
            // 
            this.PlayerChipsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerChipsBox.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerChipsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerChipsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerChipsBox.Location = new System.Drawing.Point(280, 558);
            this.PlayerChipsBox.Name = "PlayerChipsBox";
            this.PlayerChipsBox.Size = new System.Drawing.Size(84, 55);
            this.PlayerChipsBox.TabIndex = 17;
            this.PlayerChipsBox.Text = "100";
            // 
            // PotTextBox
            // 
            this.PotTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PotTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PotTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PotTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.PotTextBox.Location = new System.Drawing.Point(701, 102);
            this.PotTextBox.Name = "PotTextBox";
            this.PotTextBox.Size = new System.Drawing.Size(57, 25);
            this.PotTextBox.TabIndex = 18;
            this.PotTextBox.Text = "Pot:";
            // 
            // PotBox
            // 
            this.PotBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PotBox.BackColor = System.Drawing.SystemColors.Control;
            this.PotBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PotBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
            this.PotBox.Location = new System.Drawing.Point(783, 85);
            this.PotBox.Name = "PotBox";
            this.PotBox.Size = new System.Drawing.Size(100, 55);
            this.PotBox.TabIndex = 19;
            this.PotBox.Text = "200";
            // 
            // COMBetBox
            // 
            this.COMBetBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.COMBetBox.BackColor = System.Drawing.SystemColors.Control;
            this.COMBetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.COMBetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
            this.COMBetBox.Location = new System.Drawing.Point(280, 102);
            this.COMBetBox.Name = "COMBetBox";
            this.COMBetBox.Size = new System.Drawing.Size(84, 55);
            this.COMBetBox.TabIndex = 22;
            this.COMBetBox.Text = "100";
            // 
            // PlayerBetBox
            // 
            this.PlayerBetBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerBetBox.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerBetBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerBetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
            this.PlayerBetBox.Location = new System.Drawing.Point(280, 485);
            this.PlayerBetBox.Name = "PlayerBetBox";
            this.PlayerBetBox.Size = new System.Drawing.Size(84, 55);
            this.PlayerBetBox.TabIndex = 23;
            this.PlayerBetBox.Text = "100";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(120, 116);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(139, 24);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = "Computer bet:";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(160, 497);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(99, 24);
            this.textBox7.TabIndex = 25;
            this.textBox7.Text = "Your bet:";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerCard1.Image = global::PokerPreflopBot.Properties.Resources.PokerCardBack;
            this.PlayerCard1.Location = new System.Drawing.Point(397, 453);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(100, 130);
            this.PlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard1.TabIndex = 14;
            this.PlayerCard1.TabStop = false;
            this.PlayerCard1.Click += new System.EventHandler(this.PlayerCard1_Click);
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerCard2.Image = global::PokerPreflopBot.Properties.Resources.PokerCardBack;
            this.PlayerCard2.Location = new System.Drawing.Point(524, 453);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(100, 130);
            this.PlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCard2.TabIndex = 13;
            this.PlayerCard2.TabStop = false;
            // 
            // COMCard1
            // 
            this.COMCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.COMCard1.Image = global::PokerPreflopBot.Properties.Resources.PokerCardBack;
            this.COMCard1.Location = new System.Drawing.Point(397, 72);
            this.COMCard1.Name = "COMCard1";
            this.COMCard1.Size = new System.Drawing.Size(100, 130);
            this.COMCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.COMCard1.TabIndex = 12;
            this.COMCard1.TabStop = false;
            this.COMCard1.Click += new System.EventHandler(this.COMCard1_Click);
            // 
            // COMCard2
            // 
            this.COMCard2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.COMCard2.Image = global::PokerPreflopBot.Properties.Resources.PokerCardBack;
            this.COMCard2.Location = new System.Drawing.Point(524, 72);
            this.COMCard2.Name = "COMCard2";
            this.COMCard2.Size = new System.Drawing.Size(100, 130);
            this.COMCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.COMCard2.TabIndex = 11;
            this.COMCard2.TabStop = false;
            // 
            // Flop3
            // 
            this.Flop3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Flop3.Image = global::PokerPreflopBot.Properties.Resources.PokerCardBack;
            this.Flop3.Location = new System.Drawing.Point(465, 261);
            this.Flop3.Name = "Flop3";
            this.Flop3.Size = new System.Drawing.Size(100, 130);
            this.Flop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flop3.TabIndex = 10;
            this.Flop3.TabStop = false;
            // 
            // Turn
            // 
            this.Turn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Turn.Image = global::PokerPreflopBot.Properties.Resources.PokerCardBack;
            this.Turn.Location = new System.Drawing.Point(592, 261);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(100, 130);
            this.Turn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Turn.TabIndex = 9;
            this.Turn.TabStop = false;
            // 
            // River
            // 
            this.River.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.River.Image = global::PokerPreflopBot.Properties.Resources.PokerCardBack;
            this.River.Location = new System.Drawing.Point(723, 261);
            this.River.Name = "River";
            this.River.Size = new System.Drawing.Size(100, 130);
            this.River.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.River.TabIndex = 8;
            this.River.TabStop = false;
            this.River.Click += new System.EventHandler(this.River_Click);
            // 
            // Flop2
            // 
            this.Flop2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Flop2.Image = global::PokerPreflopBot.Properties.Resources.PokerCardBack;
            this.Flop2.Location = new System.Drawing.Point(334, 261);
            this.Flop2.Name = "Flop2";
            this.Flop2.Size = new System.Drawing.Size(100, 130);
            this.Flop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flop2.TabIndex = 6;
            this.Flop2.TabStop = false;
            this.Flop2.Click += new System.EventHandler(this.Flop2_Click);
            // 
            // Flop1
            // 
            this.Flop1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Flop1.Image = global::PokerPreflopBot.Properties.Resources.PokerCardBack;
            this.Flop1.Location = new System.Drawing.Point(203, 261);
            this.Flop1.Name = "Flop1";
            this.Flop1.Size = new System.Drawing.Size(100, 130);
            this.Flop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flop1.TabIndex = 5;
            this.Flop1.TabStop = false;
            this.Flop1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(89, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 25);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "Computer Action:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(120, 438);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 25);
            this.textBox3.TabIndex = 27;
            this.textBox3.Text = "Your Action:";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // PlayerActionBox
            // 
            this.PlayerActionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerActionBox.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerActionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerActionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.PlayerActionBox.Location = new System.Drawing.Point(252, 430);
            this.PlayerActionBox.Name = "PlayerActionBox";
            this.PlayerActionBox.Size = new System.Drawing.Size(99, 37);
            this.PlayerActionBox.TabIndex = 29;
            this.PlayerActionBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // COMActionBox
            // 
            this.COMActionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.COMActionBox.BackColor = System.Drawing.SystemColors.Control;
            this.COMActionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.COMActionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.COMActionBox.Location = new System.Drawing.Point(265, 179);
            this.COMActionBox.Name = "COMActionBox";
            this.COMActionBox.Size = new System.Drawing.Size(99, 37);
            this.COMActionBox.TabIndex = 30;
            // 
            // Game
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 669);
            this.Controls.Add(this.COMActionBox);
            this.Controls.Add(this.PlayerActionBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.PlayerBetBox);
            this.Controls.Add(this.COMBetBox);
            this.Controls.Add(this.PotBox);
            this.Controls.Add(this.PotTextBox);
            this.Controls.Add(this.PlayerChipsBox);
            this.Controls.Add(this.ComputerChipsBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PlayerCard1);
            this.Controls.Add(this.PlayerCard2);
            this.Controls.Add(this.COMCard1);
            this.Controls.Add(this.COMCard2);
            this.Controls.Add(this.Flop3);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.River);
            this.Controls.Add(this.PlayerChipsTextBox);
            this.Controls.Add(this.Flop2);
            this.Controls.Add(this.Flop1);
            this.Controls.Add(this.AllinButton);
            this.Controls.Add(this.FoldButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = " PokerPreflopBot";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COMCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Turn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.River)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flop1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button AllinButton;
        private System.Windows.Forms.Button FoldButton;
        private System.Windows.Forms.PictureBox PlayerCard1;
        private System.Windows.Forms.PictureBox PlayerCard2;
        private System.Windows.Forms.PictureBox COMCard1;
        private System.Windows.Forms.PictureBox COMCard2;
        private System.Windows.Forms.PictureBox Flop3;
        private System.Windows.Forms.PictureBox Turn;
        private System.Windows.Forms.PictureBox River;
        private System.Windows.Forms.TextBox PlayerChipsTextBox;
        private System.Windows.Forms.PictureBox Flop2;
        private System.Windows.Forms.PictureBox Flop1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox PlayerChipsBox;
        private System.Windows.Forms.TextBox ComputerChipsBox;
        private System.Windows.Forms.TextBox PotBox;
        private System.Windows.Forms.TextBox PotTextBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox PlayerBetBox;
        private System.Windows.Forms.TextBox COMBetBox;
        private System.Windows.Forms.TextBox PlayerActionBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox COMActionBox;
    }
}

