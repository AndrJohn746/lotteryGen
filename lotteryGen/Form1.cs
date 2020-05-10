using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotteryGen
{
    public partial class Form1 : Form
    {

        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int num5 = 0;
        int num6 = 0;
        readonly int BASEVAL = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void genButt_Click(object sender, EventArgs e)
        {
            num1 = BASEVAL;
            num2 = BASEVAL;
            num3 = BASEVAL;
            num4 = BASEVAL;
            num5 = BASEVAL;
            num6 = BASEVAL;

            Random randGen = new Random();
            num1 = randGen.Next(1, 50);

            while (num2 == BASEVAL || num2 == num1)
            {
                num2 = randGen.Next(1, 50);
            }
            while (num3 == BASEVAL || num3 == num2 || num3 == num1)
            {
                num3 = randGen.Next(1, 50);
            }
            while (num4 == BASEVAL || num4 == num3 || num4 == num2 || num4 == num1)
            {
                num4 = randGen.Next(1, 50);
            }
            while (num5 == BASEVAL || num5 == num4 || num5 == num3 || num5 == num2 || num5 == num1)
            {
                num5 = randGen.Next(1, 50);
            }
            while (num6 == BASEVAL || num6 == num5 || num6 == num4 || num6 == num3 || num6 == num2 || num6 == num1)
            {
                num6 = randGen.Next(1, 50);
            }

            numText.Text = "Your winning numbers are: ";
            numText.Text += "\n" + num1 + ", " + num2 + ", " + num3 + ", " + num4 + ", " + num5 + ", " + num6;

        }
    }
}
