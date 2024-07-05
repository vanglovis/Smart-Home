using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSmartHome
{
    public partial class SmartMenu : Form
    {
        public SmartMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            back.Image = Image.FromFile("back.png");
            help.Image = Image.FromFile("help.png");
            this.BackgroundImage = Image.FromFile("house.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Image.FromFile("bedroom.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Name = "bedroom";
            pictureBox1.Click += new EventHandler(clicked);

            pictureBox2.Image = Image.FromFile("kitchen.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Name = "kitchen";
            pictureBox2.Click += new EventHandler(clicked);

            pictureBox3.Image = Image.FromFile("bathroom.png");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Name = "bathroom";
            pictureBox3.Click += new EventHandler(clicked);

            pictureBox4.Image = Image.FromFile("livingroom.png");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Name = "living";
            pictureBox4.Click += new EventHandler(clicked);

        }
        private void clicked(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Name == "bedroom")
            {              
                Bedroom form2 = new Bedroom();
                form2.FormClosed += new FormClosedEventHandler(form_FormClosed);
                this.Hide();
                form2.Show();
            }
            else if (((PictureBox)sender).Name == "kitchen")
            {
                Kitchen form3 = new Kitchen();
                form3.FormClosed += new FormClosedEventHandler(form_FormClosed);
                this.Hide();
                form3.Show();
            }
            else if (((PictureBox)sender).Name == "bathroom")
            {
                Bathroom form4 = new Bathroom();
                form4.FormClosed += new FormClosedEventHandler(form_FormClosed);
                this.Hide();
                form4.Show();
            }
            else if (((PictureBox)sender).Name == "living")
            {
                Livingroom form5 = new Livingroom();
                form5.FormClosed += new FormClosedEventHandler(form_FormClosed);
                this.Hide();
                form5.Show();
            }
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
                this.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on a room to see the smart features it contains","Help");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
