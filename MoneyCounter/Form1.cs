using System;
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
            int[] NoteValues = new int[] { 1, 2, 5, 10, 20, 50, 100 };
            int[] NumofNotesUsed = new int[7];
            // If txtAmount is not numerical then notify user and exit
            int Amount2Cal = Convert.ToInt32(txtAmount.Text);
            int InputAmount = Amount2Cal;

            // For loop
            for (int currentCoin = 6; currentCoin >= 0; currentCoin--)
            {
                int currentCoinIndex = InputAmount / NoteValues[currentCoin];
                NumofNotesUsed[currentCoin] = currentCoinIndex; //Money input divided with number of notes
                InputAmount -= (currentCoinIndex * NoteValues[currentCoin]);//Multiplying divided answer with number of notes

                if (InputAmount == 0) break;

            }
            //Number of notes output 
            res100.Text = NumofNotesUsed[6].ToString();
            res50.Text = NumofNotesUsed[5].ToString();
            res20.Text = NumofNotesUsed[4].ToString();
            res10.Text = NumofNotesUsed[3].ToString();
            res5.Text = NumofNotesUsed[2].ToString();
            res2.Text = NumofNotesUsed[1].ToString();
            res1.Text = NumofNotesUsed[0].ToString();


        }
    }
}
