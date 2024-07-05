using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ApallaktikiVirvou
{
    public partial class PayProduct : Form
    {
        Random rnd = new Random();
        List<String> list = new List<String>();
        double payment;
        List<int> numlist = new List<int>();
        List<string> productname = new List<string>();
        List<double> paymentinfo = new List<double>();

        public PayProduct(double temp, List<String> list1, List<int> numlist1,List<string> temp1,List<double> temp2)
        {
            InitializeComponent();
            payment = temp;
            list = list1;
            numlist = numlist1;
            productname = temp1;
            paymentinfo = temp2;
        }
        int size;
        NumericUpDown[] app;
        TextBox[] text;
        private void Form3_Load(object sender, EventArgs e)
        {
            back.Image = Image.FromFile("back.png");
            help.Image = Image.FromFile("help.png");
            create();
            CustomerPayment();
            label1.Text = (String.Format("{0:.00}"+ "€", payment));
        }
        public void create()
        {
            size = list.Count;
            int x = 20, y = 20;
            app = new NumericUpDown[size];
            text = new TextBox[size];
            for (int i = 0; i < size; i++)
            {
                app[i] = new NumericUpDown();
                text[i] = new TextBox();
                app[i].Location = new Point(x, y);
                text[i].Location = new Point(x + 45, y);
                app[i].Size = new Size(30, 30);
                text[i].Size = new Size(150, 100);
                this.Controls.Add(app[i]);
                this.Controls.Add(text[i]);
                y += 25;
                app[i].Value = numlist[i];
                text[i].Text = list[i];
                app[i].ValueChanged += new EventHandler(updated);
            }
        }
        public void CustomerPayment()
        {
            payment = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 4; j++)
                {
 
                    if (list[i].Contains(productname[j]))
                    {
                        payment += paymentinfo[j] * Convert.ToDouble(app[i].Value);
                        break;
                    }
                }
            }
        }

        private void updated(object sender, EventArgs e)
        {
            CustomerPayment();
            label1.Text = (String.Format("{0:.00}"+ "€", payment));
            int temp = 0;
            for (int i = 0; i < size; i++)
            {
                if (Convert.ToDouble(app[i].Value)==0)
                {
                    temp++;
                }
            }
            if(temp==size)
            {
                label1.Text = "0,00€";
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            maskedTextBox1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile("paywithcard.png");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || maskedTextBox1.Text== "  /")
            {
                MessageBox.Show("Fill the blanks");
            }
            else
            {
                int time = rnd.Next(15, 35);
                MessageBox.Show("Your order will arrive in about "+ time+"  minutes");
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            while (Controls.Count > 0)
            {
                Controls[0].Dispose();
            }
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!Char.IsNumber(e.KeyChar)) && (!Char.IsControl(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!Char.IsNumber(e.KeyChar)) && (!Char.IsControl(e.KeyChar)) ))
            {
                e.Handled = true;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Make final changes and proceed to payment\nadd your credit card information and pay");
        }
    }
}
