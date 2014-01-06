using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyLabel.Text = Name + " bet " + MyBet.Amount + " on dog #" + MyBet.Dog;
            MyRadioButton.Text = Name + " has " + Cash + " bucks";

        }

        public void ClearBet()
        {
            MyBet = null;
        }

        public bool PlaceBet(int myAmount, int myDog)
        {
            if (Cash >= myAmount)
            {
                MyBet = new Bet { Amount = myAmount, Dog = myDog, Bettor = this };
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {
            MyBet.PayOut(Winner);
        }


    }
}
