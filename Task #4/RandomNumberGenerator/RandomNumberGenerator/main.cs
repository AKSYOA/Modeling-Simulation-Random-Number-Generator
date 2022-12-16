using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RandomNumberGenerator
{
    public partial class main : Form
    {
        private MainFuctions fun;

        public main()
        {
            InitializeComponent();
            fun = new MainFuctions();
        }


        

        private void generateButton_Click(object sender, EventArgs e)
        {

            randomNumbersTable.Rows.Clear();
            double seed = double.Parse(seedTextBox.Text);
            double multiplier = double.Parse(multiplierTextBox.Text);
            double increment = double.Parse(incrementTextBox.Text);
            double modulus = double.Parse(modulusTextBox.Text);
            double iteration = double.Parse(numberOfIterationsTextBox.Text);

            List<double> randomNumber = fun.LCG_Generator(multiplier, increment, modulus, seed, iteration);

            for(int i = 0; i < randomNumber.Count; i++)
            {
                randomNumbersTable.Rows.Add(randomNumber[i]);
            }
           

        }

        private void randomNumbersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
