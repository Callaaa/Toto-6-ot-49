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
        int countB = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countB++;

            try
            {
                Random randomNums = new Random();
                int[] nums = new int[6];
                int count = 0;

                while (count < 6)
                {
                    int num = randomNums.Next(6, 50);                   
                    if (!nums.Contains(num))
                    {
                        nums[count] = num;
                        count++;
                    }               
                }
                txtB1.Text = nums[0].ToString();
                txtB2.Text = nums[1].ToString();
                txtB3.Text = nums[2].ToString();
                txtB4.Text = nums[3].ToString();
                txtB5.Text = nums[4].ToString();
                txtB6.Text = nums[5].ToString();
                pictureBox2.Image = Image.FromFile("money.gif");
                
                 
                
                if (countB==1)
                {
                    pictureBox1.Image = Image.FromFile("kit.gif");
                    
                }
                else
                if (countB==2)
                {
                    pictureBox1.Image = Image.FromFile("lotto.gif");
                    countB = 0;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error","Problem!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
                                         
        }
       

            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtB6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            txtB1.Text = "";
            txtB2.Text = "";
            txtB3.Text = "";
            txtB4.Text = "";
            txtB5.Text = "";
            txtB6.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}

