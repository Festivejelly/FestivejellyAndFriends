using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class ADayAtTheRacesForm : Form
    {

        Guy[] Bettors;
        Greyhound[] Dogs;
        int CurrentBettor;
        Timer Timer1 = new Timer();
        
        int Winner;

        public ADayAtTheRacesForm()
        {
            InitializeComponent();

            Random Randomizer = new Random();

           // Timer1.Enabled = false;
            Timer1.Tick += Timer1_Tick;

            Bettors = new Guy[3];
            Dogs = new Greyhound[4];

            Bettors[0] = new Guy();
            Bettors[0].Name = "Joe";
            Bettors[0].MyRadioButton = joeRadioButton;
            Bettors[0].MyLabel = joeBetLabel;
            Bettors[0].Cash = 50;
            Bettors[0].MyLabel.Text = "Joe hasnt placed a bet yet";

            Bettors[1] = new Guy();
            Bettors[1].Name = "Bob";
            Bettors[1].MyRadioButton = bobRadioButton;
            Bettors[1].MyLabel = bobBetLabel;
            Bettors[1].Cash = 75;
            Bettors[1].MyLabel.Text = "Bob hasnt placed a bet yet";

            Bettors[2] = new Guy();
            Bettors[2].Name = "Al";
            Bettors[2].MyRadioButton = alRadioButton;
            Bettors[2].MyLabel = alBetLabel;
            Bettors[2].Cash = 45;
            Bettors[2].MyLabel.Text = "Al hasnt placed a bet yet";

            int StartPosition = dog1Pic.Location.X;
            int distance = raceTrack.Width;

            for (int i = 0; i < 4; i++)
            {
                Dogs[i] = new Greyhound();
                Dogs[i].Randomizer = Randomizer;
                Dogs[i].RacetrackLength = distance;
                Dogs[i].Location = Dogs[i].StartingPosition = StartPosition;
            }

            Dogs[0].MyPictureBox = dog1Pic;
            Dogs[1].MyPictureBox = dog2Pic;
            Dogs[2].MyPictureBox = dog3Pic;
            Dogs[3].MyPictureBox = dog4Pic;

        }

        private void RaceButton_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
            Timer1.Interval = 20;
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Dogs.Length; i++)
            {   
                if (Dogs[i].Run())
                {
                   Timer1.Stop();
                   MessageBox.Show("Dog #" + i + " won the race", "We have a winner");
                   Winner = i;
                   break;
                   
                }

            }
        }

        private void BetsButton_Click(object sender, EventArgs e)
        {
            Bettors[CurrentBettor].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Bettors[CurrentBettor].UpdateLabels();
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentBettor = 0;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentBettor = 1;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentBettor = 2;
        }




    }
}
