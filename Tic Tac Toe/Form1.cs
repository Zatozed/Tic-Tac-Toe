using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {

        private string num = "123456789";
        private int count = 0;
        private Random random = new Random();
        private int rdNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ai()
        {
            if (count < 9)
            {
                string str = "";

                rdNum = random.Next(0, num.Length);

                str = num[rdNum].ToString();

                switch (str)
                {
                    case "1":
                        count++;
                        b1.Text = "O";
                        b1.Enabled = false;
                        num = num.Replace("1", "");
                        break;
                    case "2":
                        count++;
                        b2.Text = "O";
                        b2.Enabled = false;
                        num = num.Replace("2", "");
                        break;
                    case "3":
                        count++;
                        b3.Text = "O";
                        b3.Enabled = false;
                        num = num.Replace("3", "");
                        break;
                    case "4":
                        count++;
                        b4.Text = "O";
                        b4.Enabled = false;
                        num = num.Replace("4", "");
                        break;
                    case "5":
                        count++;
                        b5.Text = "O";
                        b5.Enabled = false;
                        num = num.Replace("5", "");
                        break;
                    case "6":
                        count++;
                        b6.Text = "O";
                        b6.Enabled = false;
                        num = num.Replace("6", "");
                        break;
                    case "7":
                        count++;
                        b7.Text = "O";
                        b7.Enabled = false;
                        num = num.Replace("7", "");
                        break;
                    case "8":
                        count++;
                        b8.Text = "O";
                        b8.Enabled = false;
                        num = num.Replace("8", "");
                        break;
                    case "9":
                        count++;
                        b9.Text = "O";
                        b9.Enabled = false;
                        num = num.Replace("9", "");
                        break;
                }

                checkWinner();

                MessageBox.Show(count.ToString());
            }
            else if(count == 9)
            {
                checkWinner();
            }
        }

        private void checkWinner()
        {
            if 
                (
                    (b1.Enabled == false && b2.Enabled == false && b3.Enabled == false) ||
                    (b4.Enabled == false && b5.Enabled == false && b6.Enabled == false) ||
                    (b7.Enabled == false && b8.Enabled == false && b9.Enabled == false) ||

                    (b1.Enabled == false && b4.Enabled == false && b7.Enabled == false) ||
                    (b2.Enabled == false && b5.Enabled == false && b8.Enabled == false) ||
                    (b3.Enabled == false && b6.Enabled == false && b9.Enabled == false) ||

                    (b1.Enabled == false && b5.Enabled == false && b9.Enabled == false) ||
                    (b3.Enabled == false && b5.Enabled == false && b7.Enabled == false)
                ) 
            {
                // horizontal check
                if (b1.Text == "X" && b2.Text == "X" && b3.Text == "X")
                {
                    MessageBox.Show("You Win!");
                }
                else if (b1.Text == "O" && b2.Text == "O" && b3.Text == "O")
                {
                    MessageBox.Show("You Lose.");
                }
                else if (b4.Text == "X" && b5.Text == "X" && b6.Text == "X")
                {
                    MessageBox.Show("You Win!");
                }
                else if (b4.Text == "O" && b5.Text == "O" && b6.Text == "O")
                {
                    MessageBox.Show("You Lose.");
                }
                else if (b7.Text == "X" && b8.Text == "X" && b9.Text == "X")
                {
                    MessageBox.Show("You Win!");
                }
                else if (b7.Text == "O" && b8.Text == "O" && b9.Text == "O")
                {
                    MessageBox.Show("You Lose.");
                }

                // vertical check
                if (b1.Text == "X" && b4.Text == "X" && b7.Text == "X")
                {
                    MessageBox.Show("You Win!");
                }
                else if (b1.Text == "O" && b4.Text == "O" && b7.Text == "O")
                {
                    MessageBox.Show("You Lose.");
                }
                else if (b2.Text == "X" && b5.Text == "X" && b8.Text == "X")
                {
                    MessageBox.Show("You Win!");
                }
                else if (b2.Text == "O" && b5.Text == "O" && b8.Text == "O")
                {
                    MessageBox.Show("You Lose.");
                }
                else if (b3.Text == "X" && b6.Text == "X" && b9.Text == "X")
                {
                    MessageBox.Show("You Win!");
                }
                else if (b3.Text == "O" && b6.Text == "O" && b9.Text == "O")
                {
                    MessageBox.Show("You Lose.");
                }

                // diagonal check
                else if (b1.Text == "X" && b5.Text == "X" && b9.Text == "X")
                {
                    MessageBox.Show("You Win!");
                }
                else if (b1.Text == "O" && b5.Text == "O" && b9.Text == "O")
                {
                    MessageBox.Show("You Lose.");
                }
                else if (b3.Text == "X" && b5.Text == "X" && b7.Text == "X")
                {
                    MessageBox.Show("You Win!");
                }
                else if (b3.Text == "O" && b5.Text == "O" && b7.Text == "O")
                {
                    MessageBox.Show("You Lose.");
                }
            }
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;

            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";

            count = 0;
            num = "123456789";
        }

        private void b1_Click(object sender, EventArgs e)
        {
            b1.Text = "X";
           
            num = num.Replace("1", "");

            b1.Enabled = false;

            count++;

            ai();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.Text = "X";

            num = num.Replace("2", "");

            b2.Enabled = false;

            count++;

            ai();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.Text = "X";

            num = num.Replace("3", "");

            b3.Enabled = false;

            count++;

            ai();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.Text = "X";

            num = num.Replace("4", "");

            b4.Enabled = false;

            count++;

            ai();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.Text = "X";

            num = num.Replace("5", "");

            b5.Enabled = false;

            count++;

            ai();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            b6.Text = "X";

            num = num.Replace("6", "");

            b6.Enabled = false;

            count++;

            ai();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            b7.Text = "X";

            num = num.Replace("7", "");

            b7.Enabled = false;

            count++;

            ai();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            b8.Text = "X";

            num = num.Replace("8", "");

            b8.Enabled = false;

            count++;

            ai();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            b9.Text = "X";

            num = num.Replace("9", "");

            b9.Enabled = false;

            count++;

            ai();
        }
    }
}
