using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ApallaktikiVirvou
{
    public partial class Menu : Form
    {
        ComboBox[] boxes = new ComboBox[4];
        List<String> list = new List<String>();
        List<int> numlist = new List<int>();
        List<double> paymentinfo = new List<double>();
        List<String> productnames = new List<String>();
        string PictureBoxName,product;
        public Menu(string temp)
        {
            InitializeComponent();
            PictureBoxName = temp;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            back.Image = Image.FromFile("back.png");
            help.Image = Image.FromFile("help.png");
            boxes[0] = comboBox1;
            boxes[1] = comboBox2;
            boxes[2] = comboBox3;
            boxes[3] = comboBox4;
            button1.Click += new EventHandler(clicked);
            button2.Click += new EventHandler(clicked);
            button3.Click += new EventHandler(clicked);
            button4.Click += new EventHandler(clicked);
            if (PictureBoxName == "DueCafe" || PictureBoxName == "CoffeeBerry" || PictureBoxName == "CoffeeIsland" || PictureBoxName == "CoffeeLab")
            {
                this.Text = "Coffee";
                product = "coffee";
                for (int i = 0; i < 4; i++)
                {
                    boxes[i].Text = "Sugar";
                    boxes[i].Items.Add("Sweet");
                    boxes[i].Items.Add("Medium");
                    boxes[i].Items.Add("Black");
                }
                paymentinfo.Add(1.70);
                paymentinfo.Add(2.20);
                paymentinfo.Add(1.90);
                paymentinfo.Add(2.00);
                productnames.Add("Freddo Espresso");
                productnames.Add("Freddoccino");
                productnames.Add("Freddo Cappuccino");
                productnames.Add("Cappuccino");
                label1.Text = productnames[0];
                label2.Text = productnames[1];
                label3.Text = productnames[2];
                label4.Text = productnames[3];
                label5.Text = String.Format("{0:.00}", paymentinfo[0]).ToString()+ "€";
                label6.Text = String.Format("{0:.00}", paymentinfo[1]).ToString() + "€"; ;
                label7.Text = String.Format("{0:.00}", paymentinfo[2]).ToString() + "€"; ;
                label8.Text = String.Format("{0:.00}", paymentinfo[3]).ToString() + "€"; ;
                pictureBox1.Image = Image.FromFile("freddoEspresso.png");
                pictureBox2.Image = Image.FromFile("freddoccino.png");
                pictureBox3.Image = Image.FromFile("freddoCappuccino.png");
                pictureBox4.Image = Image.FromFile("cappuccino.png");
            }
            else
            {
                this.Text = "Burger";
                product = "burger";
                boxes[0].Visible = false;
                boxes[1].Visible = false;
                boxes[2].Visible = false;
                boxes[3].Visible = false;
                paymentinfo.Add(5.00);
                paymentinfo.Add(4.80);
                paymentinfo.Add(5.20);
                paymentinfo.Add(4.20);
                productnames.Add("Cheese Burger");
                productnames.Add("Bbq Burger");
                productnames.Add("Chicken Burger");
                productnames.Add("Vegan Burger");
                label1.Text = productnames[0];
                label2.Text = productnames[1];
                label3.Text = productnames[2];
                label4.Text = productnames[3];
                label5.Text = String.Format("{0:.00}", paymentinfo[0]).ToString() + "€";
                label6.Text = String.Format("{0:.00}", paymentinfo[1]).ToString() + "€"; ;
                label7.Text = String.Format("{0:.00}", paymentinfo[2]).ToString() + "€"; ;
                label8.Text = String.Format("{0:.00}", paymentinfo[3]).ToString() + "€"; ;
                pictureBox1.Image = Image.FromFile("cheeseburger.png");
                pictureBox2.Image = Image.FromFile("BbqBurger.png");
                pictureBox3.Image = Image.FromFile("ChickenBurger.png");
                pictureBox4.Image = Image.FromFile("VeganBurger.png");
            }
        }
        double payment = 0.00;
        private void clicked(object sender, EventArgs e)
        {
            if (product == "coffee")
            {
                Boolean temp = true;
                if (((Button)sender).Name == "button1")
                {
                    if (comboBox1.Text == "Sugar")
                    {
                        MessageBox.Show("Add sugar first");
                        temp = false;
                    }
                    if (Convert.ToInt32(numericUpDown1.Value) == 0)
                    {
                        MessageBox.Show("Add at least one coffee");
                        temp = false;
                    }
                    if (temp == true)
                    {
                        list.Add(label1.Text + " " + comboBox1.SelectedItem);
                        numlist.Add(Convert.ToInt32(numericUpDown1.Value));
                        payment += 1.70 * Convert.ToInt32(numericUpDown1.Value);
                    }
                }
                if (((Button)sender).Name == "button2")
                {
                    if (comboBox2.Text == "Sugar")
                    {
                        MessageBox.Show("Add sugar first");
                        temp = false;
                    }
                    if (Convert.ToInt32(numericUpDown2.Value) == 0)
                    {
                        MessageBox.Show("Add at least one coffee");
                        temp = false;
                    }
                    if (temp == true)
                    {
                        numlist.Add(Convert.ToInt32(numericUpDown2.Value));
                        list.Add(label2.Text + " " + comboBox2.SelectedItem);
                        payment += 2.20 * Convert.ToInt32(numericUpDown2.Value);
                    }
                }
                if (((Button)sender).Name == "button3")
                {
                    if (comboBox3.Text == "Sugar")
                    {
                        MessageBox.Show("Add sugar first");
                        temp = false;
                    }
                    if (Convert.ToInt32(numericUpDown3.Value) == 0)
                    {
                        MessageBox.Show("Add at least one coffee");
                        temp = false;
                    }
                    if (temp == true)
                    {
                        numlist.Add(Convert.ToInt32(numericUpDown3.Value));
                        list.Add(label3.Text + " " + comboBox3.SelectedItem);
                        payment += 1.90 * Convert.ToInt32(numericUpDown3.Value);
                    }
                }
                if (((Button)sender).Name == "button4")
                {
                    if (comboBox4.Text == "Sugar")
                    {
                        MessageBox.Show("Add sugar first");
                        temp = false;
                    }
                    if (Convert.ToInt32(numericUpDown4.Value) == 0)
                    {
                        MessageBox.Show("Add at least one coffee");
                        temp = false;
                    }
                    if (temp == true)
                    {
                        numlist.Add(Convert.ToInt32(numericUpDown4.Value));
                        list.Add(label4.Text + " " + comboBox4.SelectedItem);
                        payment += 2.00 * Convert.ToInt32(numericUpDown4.Value);
                    }
                }
            }
            else if (product == "burger")
            {
                Boolean temp = true;
                if (((Button)sender).Name == "button1")
                {
                    if (Convert.ToInt32(numericUpDown1.Value) == 0)
                    {
                        MessageBox.Show("Add at least one burger");
                        temp = false;
                    }
                    if (temp == true)
                    {
                        list.Add(label1.Text);
                        numlist.Add(Convert.ToInt32(numericUpDown1.Value));
                        payment += 5.00 * Convert.ToInt32(numericUpDown1.Value);
                    }
                }
                if (((Button)sender).Name == "button2")
                {
                    if (Convert.ToInt32(numericUpDown2.Value) == 0)
                    {
                        MessageBox.Show("Add at least one burger");
                        temp = false;
                    }
                    if (temp == true)
                    {
                        list.Add(label2.Text);
                        numlist.Add(Convert.ToInt32(numericUpDown2.Value));
                        payment += 4.80 * Convert.ToInt32(numericUpDown2.Value);
                    }
                }
                if (((Button)sender).Name == "button3")
                {
                    if (Convert.ToInt32(numericUpDown3.Value) == 0)
                    {
                        MessageBox.Show("Add at least one burger");
                        temp = false;
                    }
                    if (temp == true)
                    {
                        list.Add(label3.Text);
                        numlist.Add(Convert.ToInt32(numericUpDown3.Value));
                        payment += 5.20 * Convert.ToInt32(numericUpDown3.Value);
                    }
                }
                if (((Button)sender).Name == "button4")
                {
                    if (Convert.ToInt32(numericUpDown4.Value) == 0)
                    {
                        MessageBox.Show("Add at least one burger");
                        temp = false;
                    }
                    if (temp == true)
                    {
                        list.Add(label4.Text);
                        numlist.Add(Convert.ToInt32(numericUpDown4.Value));
                        payment += 4.20 * Convert.ToInt32(numericUpDown4.Value);
                    }
                }
            }
        }
        PayProduct form3;

        private void button5_Click(object sender, EventArgs e)
        {
            if (payment > 0)
            {
                form3 = new PayProduct(payment, list, numlist, productnames, paymentinfo);
                form3.FormClosed += new FormClosedEventHandler(form_FormClosed);
                this.Hide();

                form3.Show();
            }
            else
            {
                MessageBox.Show("Please select a product before you proceed to payment");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pick the quantity of the product you want and \nadd it to cart, when finished click proceed to payment");
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
    {
        form3 = null;
        this.Show();
    }
}
}
