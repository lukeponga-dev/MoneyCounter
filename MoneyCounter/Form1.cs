using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int[] Coinvals = new int[] { 1, 2, 5, 10, 20, 50, 100 };
            int[] NumofCoinsUsed = new int[7];
            // If txtAmount is not numerical then notify user and exit
            int Amount2Cal = Convert.ToInt32(txtAmount.Text);
            int RemainingAmount = Amount2Cal;

            for (int currentCoin = 6; 
                    currentCoin >= 0; currentCoin--) 
            {
                int currentCoinIndex = RemainingAmount / Coinvals[currentCoin];
                
                NumofCoinsUsed[currentCoin] = currentCoinIndex;
                RemainingAmount -= (currentCoinIndex * Coinvals[currentCoin]);

                if (RemainingAmount == 0) break;
            }

            res100.Text = NumofCoinsUsed[6].ToString();
            res50.Text = NumofCoinsUsed[5].ToString();
            res20.Text = NumofCoinsUsed[4].ToString();
            res10.Text = NumofCoinsUsed[3].ToString();
            res5.Text = NumofCoinsUsed[2].ToString();
            res2.Text = NumofCoinsUsed[1].ToString();
            res1.Text = NumofCoinsUsed[0].ToString();


        }
    }
}
