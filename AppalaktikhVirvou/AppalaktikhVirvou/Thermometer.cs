using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppThermotmetro
{
    public partial class Thermometer : Form
    {
        public Thermometer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            button1.Enabled = false;
            int m = random.Next(100);
            if (m < 10)
            {
                // >380
                int kappa = random.Next(381, 399);
                String randomstring = kappa.ToString();
                pictureBox1.Image = Image.FromFile(randomstring + ".png");
                label1.Text = "Your temperature is " + randomstring.Insert(2, ",") + " celcius";
                button1.Enabled = false;
                timer1.Enabled = true;
                MessageBox.Show("You might have COVID-19!! , better go do a rapid test at 'Σωτηρία' hospital\nΜεσογείων 152, Αθήνα 115 27\t2107763100","DANGER");
            }
            else if (m < 20)
            {
                // <380
                int kappa = random.Next(373, 380);
                String randomstring = kappa.ToString();
                pictureBox1.Image = Image.FromFile(randomstring + ".png");
                label1.Text = "Your temperature is " + randomstring.Insert(2, ",") + " celcius";
                BackColor = Color.Red;
                button1.BackColor = Color.Red;
                MessageBox.Show("Sorry but you cant come in be cautius!!","Carefull!");
                button1.Enabled = true;
            }
            else if (m < 30)
            {
                //<372
                int kappa = random.Next(367, 372);
                String randomstring = kappa.ToString();
                pictureBox1.Image = Image.FromFile(randomstring + ".png");
                label1.Text = "Your temperature is " + randomstring.Insert(2, ",") + " celcius";
                BackColor = Color.Orange;
                button1.BackColor = Color.Orange;
                MessageBox.Show("Wait 5 minutes and try again","Warning");
                button1.Enabled = true;
            }
            else if (m < 101)
            {
                //366
                int kappa = random.Next(360, 366);
                String randomstring = kappa.ToString();
                pictureBox1.Image = Image.FromFile(randomstring + ".png");
                label1.Text = "Your temperature is " + randomstring.Insert(2, ",") + " celcius";
                BackColor = Color.Green;
                button1.BackColor = Color.Green;
                MessageBox.Show("Your temperature is normal","Healthy");
                button1.Enabled = true;
            }
            
        }
        private readonly Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            back.Image = Image.FromFile("back.png");
            help.Image = Image.FromFile("help.png");
            label1.Visible = false;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("therm.png");
        }
        int i = 0,stop=0;

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on Take temperature to use the infared thermometer","Help");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (i == 0)
            {
                BackColor = Color.Red;
                button1.BackColor = Color.Red;
                i++;
                stop++;
            }
            else
            {
                BackColor = Color.Yellow;
                button1.BackColor = Color.Yellow;
                i = 0;
            }
            if (stop == 10)
            {
                timer1.Enabled = false;
                button1.Enabled = true;
                stop = 0;
            }
        }
    }
}
