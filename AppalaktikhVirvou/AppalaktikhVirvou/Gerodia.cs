using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGerontia
{
    public partial class Gerodia : Form
    {
        public Gerodia()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            back.Image = Image.FromFile("back.png");
            help.Image = Image.FromFile("help.png");
            BackgroundImage = Image.FromFile("kitchen.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Image.FromFile("barbas.png");
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Image.FromFile("cam.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.Image = Image.FromFile("lapdelivery.png"); 
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r.Next(0, 10) > 5)
            {
                pictureBox3.Enabled = false;
                pictureBox1.Location = new Point(49, 158 + 100);
                pictureBox1.Size = new Size(126, 159);
                pictureBox1.Image = Image.FromFile("oldman_fallen.png");
                timer1.Enabled = false;
                DialogResult dialogResult = MessageBox.Show("It looks like you have fallen!\nWould you like to call an ambulance?", "Oh no!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("AMBULANCE IS ON ITS WAY", "IOU IOU IOU");
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Hope you are better :)", "Get well");
                    pictureBox1.Location = new Point(49, 158);
                    pictureBox1.Size = new Size(126, 259);
                    pictureBox1.Image = Image.FromFile("barbas.png");
                    timer1.Interval += 10000;
                    timer1.Enabled = true;
                    pictureBox3.Enabled = true;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ApallaktikiVirvou.FoodMenu food = new ApallaktikiVirvou.FoodMenu();
            food.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
            food.Show();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {       
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("Elderly people might fall over in a random time" +
                ",we check that and ask him if he is okay or not\nIf he replies he is okay he continues with his life\n" +
                "If he replies he is not ok an ambulance will go and pick him up\n" +
                "Also smart delivery is implemented in the laptop so he can order food", "Smart Helper");
            timer1.Enabled = true;
        }
        int tim = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            tim++;
            if(tim==3)
            {
                pictureBox1.Image = Image.FromFile("barbas.png");
                MessageBox.Show("Nurses picked you up and gave u a check up, you can now continue your day", "Help has arrived");
                pictureBox1.Location = new Point(49, 158);
                pictureBox1.Size = new Size(126, 259);
                timer1.Interval += 10000;
                timer1.Enabled = true;
                pictureBox3.Enabled = true;
            }
        }
    }
}
