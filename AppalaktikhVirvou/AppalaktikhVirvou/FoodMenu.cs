using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApallaktikiVirvou
{
    public partial class FoodMenu : Form
    {
        public FoodMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            back.Image = Image.FromFile("back.png");
            help.Image = Image.FromFile("help1.png");
            BackgroundImage = Image.FromFile("image.png");
            DueCafe.Click += new EventHandler(clicked);
            DueCafe.Image = Image.FromFile("DUECAFE.png");
            CoffeeIsland.Click += new EventHandler(clicked);
            CoffeeIsland.Image = Image.FromFile("CoffeIsland.png");
            CoffeeLab.Click += new EventHandler(clicked);
            CoffeeLab.Image = Image.FromFile("CoffeLab.png");
            CoffeeBerry.Click += new EventHandler(clicked);
            CoffeeBerry.Image = Image.FromFile("CoffeBerry.png");
            SimplyBurgers.Click += new EventHandler(clicked);
            SimplyBurgers.Image = Image.FromFile("SimplyBurgers.png");
            McDonalds.Click += new EventHandler(clicked);
            McDonalds.Image = Image.FromFile("McDonalds.png");
            ShakeBeer.Click += new EventHandler(clicked);
            ShakeBeer.Image = Image.FromFile("shakebeer.png");
            HomeBurger.Click += new EventHandler(clicked);
            HomeBurger.Image = Image.FromFile("homeburger.png");
            if (comboBox1.Text == "Διευθυνση")
            {
                foreach (Control lbl in Controls)
                {
                    if ((lbl) is PictureBox)
                        lbl.Hide();
                    if ((lbl) is Label)
                        lbl.Hide();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                foreach (Control lbl in Controls)
                {
                    if ((lbl) is PictureBox)
                        lbl.Show();
                    if ((lbl) is Label)
                        lbl.Show();
                }
        }
        private void clicked(object sender, EventArgs e)
        {
                Menu form2 = new Menu(((PictureBox)sender).Name);
                form2.FormClosed += new FormClosedEventHandler(form_FormClosed);
                this.Hide();
                form2.Show();
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
            MessageBox.Show("Firstly: Select address\n" +
                "Secondly: Pick the shop you want to order from","Menu Helper");
        }

        private void DueCafe_Click(object sender, EventArgs e)
        {

        }
    }
}
