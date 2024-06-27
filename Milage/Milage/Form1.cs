using System;

namespace Milage
{
    public partial class Form1 : Form
    {
        private int startMiles;
        private int endMiles;
        private double miTraveled;
        private double perMileRate;
        private double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            startMiles = (int)startMi.Value; // start miles == to first numUpDown box.
            endMiles = (int)endMi.Value; // end miles == to second numUpDown box.
            perMileRate = (double)changeRate.Value; // perMiRate changing rate.


            if (startMiles < endMiles) // if start miles are less then end miles.
            {
                miTraveled = endMiles - startMiles; // mi traveled = end mi - start mi.
                amountOwed = miTraveled * perMileRate; // amount is coming from mi traveled times per mi rate.
                Total.Text = "Total: $" + amountOwed; // total text is eq. to amount owed.
            }

            else // start miles are greater then end miles then it is just not worth for our calc calculation
            {
                MessageBox.Show("Start miles are greater then end miles.");
            }
        }
    }
}