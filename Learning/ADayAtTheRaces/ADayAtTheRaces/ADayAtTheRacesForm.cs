using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class ADayAtTheRacesForm : Form
    {

        Guy[] Bettors;
        Greyhound[] Dogs;
        Guy CurrentBettor;

        public ADayAtTheRacesForm()
        {
            InitializeComponent();

            Bettors = new Guy[3];
            Dogs = new Greyhound[4];

            Bettors[0] = new Guy();
            Bettors[0].Name = "Joe";
            Bettors[0].MyRadioButton = joeRadioButton;
            Bettors[0].MyLabel = joeBetLabel;
            Bettors[0].Cash = 50;
            Bettors[0].UpdateLabels();

            Bettors[1] = new Guy();
            Bettors[1].Name = "Bob";
            Bettors[1].MyRadioButton = bobRadioButton;
            Bettors[1].MyLabel = bobBetLabel;
            Bettors[1].Cash = 75;
            Bettors[1].UpdateLabels();

            Bettors[2] = new Guy();
            Bettors[2].Name = "Al";
            Bettors[2].MyRadioButton = alRadioButton;
            Bettors[2].MyLabel = alBetLabel;
            Bettors[2].Cash = 45;
            Bettors[2].UpdateLabels();

            int StartPosition = dog1Pic.Location.X;
            int distance = raceTrack.Width;

            for (int i = 0; i < 4; i++)
            {
                Dogs[i] = new Greyhound();
                Dogs[i].RacetrackLength = distance;
                Dogs[i].Location = Dogs[i].StartingPosition = StartPosition;
            }

            Dogs[0].MyPictureBox = dog1Pic;
            Dogs[1].MyPictureBox = dog2Pic;
            Dogs[2].MyPictureBox = dog3Pic;
            Dogs[3].MyPictureBox = dog4Pic;

            CurrentBettor = Bettors[0];

        }

        private void RaceButton_Click(object sender, EventArgs e)
        {














        }
    }
}
