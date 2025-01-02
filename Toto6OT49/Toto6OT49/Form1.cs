using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toto6OT49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[] numbers = new int[6];
            int count = 0;
            while (count < 6)
            {
                int num = rand.Next(1, 50);
                bool doesExist = false;
                for (int i = 0; i < count; i++)
                {
                    if (numbers[i] == num)
                    {
                        doesExist = true;
                        break;
                    }                   
                }
                if(!doesExist)
                {
                    numbers[count] = num;
                    count++;
                }               
                txtB1.Text = numbers[0].ToString();
                txtB2.Text = numbers[1].ToString();
                txtB3.Text = numbers[2].ToString();
                txtB4.Text = numbers[3].ToString();
                txtB5.Text = numbers[4].ToString();
                txtB6.Text = numbers[5].ToString();               
            }
        }
    }
}
