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
    public partial class Bedroom : Form
    {
        public Bedroom()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            back.Image = Image.FromFile("back.png");
            help.Image = Image.FromFile("help.png");
            this.BackgroundImage = Image.FromFile("bedroom.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("switchON.png");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = Image.FromFile("light.png");
            pictureBox5.BackColor = Color.Transparent;
        }
        Boolean clickaro = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (clickaro)
            {
                clickaro = false;
                pictureBox1.Image = Image.FromFile("switchOFF.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox5.Image = null;
            }
            else {
                pictureBox5.Image = Image.FromFile("light.png");
                pictureBox1.Image = Image.FromFile("switchON.png");
                clickaro = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                numericUpDown1.BackColor = Color.White;
                radioButton2.Checked = false;
            }
            if (radioButton1.Checked)
                numericUpDown1.BackColor = Color.Cyan;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Checked = false;
                numericUpDown1.BackColor = Color.White;
            }
            if (radioButton2.Checked)
                numericUpDown1.BackColor = Color.OrangeRed;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Light switch: click on it to turn the light on/off\n" +
                "Air-conditioning: Choose if you want cold or hot a/c and desired temperature\n", "Smart Features");
        }
    }
}
