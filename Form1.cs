namespace Black_Jack_Card_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        int amountClick = 0;

        int gamerScore = 0;
        int pcScore = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            amountClick++;
            if(amountClick== 1 ) 
            {
            
            int a1, a2, sumCards;

            a1 = random.Next(1, 11);
            a2 = random.Next(1, 11);

            sumCards = a1+ a2;

            label1.Text= a1.ToString();
            label2.Text= a2.ToString();
            label10.Text= sumCards.ToString();
            }

            if(amountClick == 2 )
            {
                int a3, sumCards;
                a3 = random.Next(1, 11);
                label3.Text= a3.ToString();

                sumCards = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label10.Text= sumCards.ToString();

             
            }

            if(amountClick == 3)
            {
                int a4, sumCards;

                a4 = random.Next(1, 11);
                label4.Text= a4.ToString();

                sumCards = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;

                label10.Text= sumCards.ToString();


            }

            if(label1.Text == "1")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\1.png";
            }
            if (label1.Text == "2")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\2.png";
            }
            if (label1.Text == "3")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\3.png";
            }
            if (label1.Text == "4")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\4.png";
            }
            if (label1.Text == "5")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\5.png";
            }
            if (label1.Text == "6")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\6.png";
            }
            if (label1.Text == "7")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\7.png";
            }
            if (label1.Text == "8")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\8.png";
            }
            if (label1.Text == "9")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\9.png";
            }
            if (label1.Text == "10")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\10.png";
            }
            if (label1.Text == "11")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\11.png";
            }
            if (label1.Text == "12")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\12.png";
            }
            if (label1.Text == "13")
            {
                pictureBox1.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\13.png";
            }
            // label 2

            if (label2.Text == "1")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\1.png";
            }
            if (label2.Text == "2")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\2.png";
            }
            if (label2.Text == "3")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\3.png";
            }
            if (label2.Text == "4")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\4.png";
            }
            if (label2.Text == "5")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\5.png";
            }
            if (label2.Text == "6")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\6.png";
            }
            if (label2.Text == "7")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\7.png";
            }
            if (label2.Text == "8")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\8.png";
            }
            if (label2.Text == "9")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\9.png";
            }
            if (label2.Text == "10")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\10.png";
            }
            if (label2.Text == "11")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\11.png";
            }
            if (label2.Text == "12")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\12.png";
            }
            if (label2.Text == "13")
            {
                pictureBox2.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\13.png";
            }

            //label 3


            if (label3.Text == "1")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\1.png";
            }
            if (label3.Text == "2")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\2.png";
            }
            if (label3.Text == "3")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\3.png";
            }
            if (label3.Text == "4")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\4.png";
            }
            if (label3.Text == "5")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\5.png";
            }
            if (label3.Text == "6")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\6.png";
            }
            if (label3.Text == "7")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\7.png";
            }
            if (label3.Text == "8")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\8.png";
            }
            if (label3.Text == "9")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\9.png";
            }
            if (label3.Text == "10")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\10.png";
            }
            if (label3.Text == "11")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\11.png";
            }
            if (label3.Text == "12")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\12.png";
            }
            if (label3.Text == "13")
            {
                pictureBox3.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\13.png";
            }

            //label 4


            if (label4.Text == "1")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\1.png";
            }
            if (label4.Text == "2")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\2.png";
            }
            if (label4.Text == "3")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\3.png";
            }
            if (label4.Text == "4")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\4.png";
            }
            if (label4.Text == "5")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\5.png";
            }
            if (label4.Text == "6")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\6.png";
            }
            if (label4.Text == "7")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\7.png";
            }
            if (label4.Text == "8")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\8.png";
            }
            if (label4.Text == "9")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\9.png";
            }
            if (label4.Text == "10")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\10.png";
            }
            if (label4.Text == "11")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\11.png";
            }
            if (label4.Text == "12")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\12.png";
            }
            if (label4.Text == "13")
            {
                pictureBox4.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\13.png";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2, sumCards;
            b1 = random.Next(1, 11);
            b2 = random.Next(1, 11);

            sumCards = b1 + b2;

            label5.Text= b1.ToString();
            label6.Text= b2.ToString();

            label11.Text = sumCards.ToString();

            if (sumCards < 16)
            {
                int b3;

                b3 = random.Next(1, 11);
                label7.Text= b3.ToString();

                sumCards = sumCards+ b3;
                label11.Text = sumCards.ToString();
            }
            
            if(sumCards< 16)
            {

                int b4;
                b4 = random.Next(1, 11);
                label8.Text= b4.ToString();

                sumCards= sumCards+ b4;
                label11.Text = sumCards.ToString();
            }

            // label 5

            if (label5.Text == "1")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\1.png";
            }
            if (label5.Text == "2")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\2.png";
            }
            if (label5.Text == "3")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\3.png";
            }
            if (label5.Text == "4")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\4.png";
            }
            if (label5.Text == "5")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\5.png";
            }
            if (label5.Text == "6")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\6.png";
            }
            if (label5.Text == "7")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\7.png";
            }
            if (label5.Text == "8")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\8.png";
            }
            if (label5.Text == "9")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\9.png";
            }
            if (label5.Text == "10")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\10.png";
            }
            if (label5.Text == "11")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\11.png";
            }
            if (label5.Text == "12")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\12.png";
            }
            if (label5.Text == "13")
            {
                pictureBox5.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\13.png";
            }

            // label 6

            if (label6.Text == "1")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\1.png";
            }
            if (label6.Text == "2")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\2.png";
            }
            if (label6.Text == "3")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\3.png";
            }
            if (label6.Text == "4")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\4.png";
            }
            if (label6.Text == "5")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\5.png";
            }
            if (label6.Text == "6")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\6.png";
            }
            if (label6.Text == "7")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\7.png";
            }
            if (label6.Text == "8")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\8.png";
            }
            if (label6.Text == "9")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\9.png";
            }
            if (label6.Text == "10")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\10.png";
            }
            if (label6.Text == "11")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\11.png";
            }
            if (label6.Text == "12")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\12.png";
            }
            if (label6.Text == "13")
            {
                pictureBox6.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\13.png";
            }
            //label 7

            if (label7.Text == "1")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\1.png";
            }
            if (label7.Text == "2")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\2.png";
            }
            if (label7.Text == "3")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\3.png";
            }
            if (label7.Text == "4")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\4.png";
            }
            if (label7.Text == "5")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\5.png";
            }
            if (label7.Text == "6")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\6.png";
            }
            if (label7.Text == "7")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\7.png";
            }
            if (label7.Text == "8")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\8.png";
            }
            if (label7.Text == "9")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\9.png";
            }
            if (label7.Text == "10")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\10.png";
            }
            if (label7.Text == "11")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\11.png";
            }
            if (label7.Text == "12")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\12.png";
            }
            if (label7.Text == "13")
            {
                pictureBox7.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\13.png";
            }

            //label 8

            if (label8.Text == "1")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\1.png";
            }
            if (label8.Text == "2")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\2.png";
            }
            if (label8.Text == "3")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\3.png";
            }
            if (label8.Text == "4")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\4.png";
            }
            if (label8.Text == "5")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\5.png";
            }
            if (label8.Text == "6")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\6.png";
            }
            if (label8.Text == "7")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\7.png";
            }
            if (label8.Text == "8")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\8.png";
            }
            if (label8.Text == "9")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\9.png";
            }
            if (label8.Text == "10")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\10.png";
            }
            if (label8.Text == "11")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\11.png";
            }
            if (label8.Text == "12")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\12.png";
            }
            if (label8.Text == "13")
            {
                pictureBox8.ImageLocation = "C:\\Users\\*\\Pictures\\Card_Game_Pics\\13.png";
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;
            int gamerSum, pcSum;

            gamerSum = Convert.ToInt32(label10.Text);
            pcSum = Convert.ToInt32(label11.Text);

            if(gamerSum>pcSum && gamerSum < 21)
            {

                gamerScore = gamerScore + 10;
                label20.Text = gamerScore.ToString();

                
            }

            if(pcSum> gamerSum && pcSum <= 21)
            {
                pcScore = pcScore + 10;
                label21.Text = pcScore.ToString();
            }

            if(pcSum>21 && gamerSum > 21)
            {
                MessageBox.Show("Degerler Boyukdur, Berabersiniz !!");
            }

            if(pcSum == gamerSum && pcSum<=21 && gamerSum <= 21)
            {
                pcScore = pcScore + 10;
                gamerScore = gamerScore + 10;
            }

            if(gamerScore == 50)
            {
                MessageBox.Show("Congrats ))))");
            }
            if(pcScore== 50)
            {
                MessageBox.Show("You Lost!");
            }

            if(pcSum <=21 && gamerSum > 21)
            {
                pcScore = pcScore + 10;
                label21.Text = pcScore.ToString();
            }

            if(gamerSum<=21 && pcSum > 21)
            {
                gamerScore = gamerScore + 10;
                label20.Text = gamerScore.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            amountClick = 0;

            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0"; 
            label7.Text = "0";
            label8.Text = "0";
            label11.Text = "0";
            label10.Text = "0";
            button4.Enabled = false;
            button3.Enabled = true;

            pictureBox1.ImageLocation = "C:\\Users\\*\\Desktop\\backi.png";
            pictureBox2.ImageLocation = "C:\\Users\\*\\Desktop\\backi.png";
            pictureBox3.ImageLocation = "C:\\Users\\*\\Desktop\\backi.png";
            pictureBox4.ImageLocation = "C:\\Users\\*\\Desktop\\backi.png";
            pictureBox5.ImageLocation = "C:\\Users\\*\\Desktop\\backi.png";
            pictureBox6.ImageLocation = "C:\\Users\\*\\Desktop\\backi.png";
            pictureBox7.ImageLocation = "C:\\Users\\*\\Desktop\\backi.png";
            pictureBox8.ImageLocation = "C:\\Users\\*\\Desktop\\backi.png";

        }
    }
}