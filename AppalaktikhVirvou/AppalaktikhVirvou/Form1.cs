using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppalaktikhVirvou
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Image.FromFile("background.png");

            planner.BackgroundImage = Image.FromFile("smartplan.png");
            planner.BackColor = Color.Transparent;
            planner.FlatStyle = FlatStyle.Flat;
            planner.FlatAppearance.BorderSize = 0;
            planner.FlatAppearance.MouseDownBackColor = Color.Transparent;
            planner.FlatAppearance.MouseOverBackColor = Color.Transparent;


            home.BackgroundImage = Image.FromFile("smarthome.png");
            home.BackColor = Color.Transparent;
            home.FlatStyle = FlatStyle.Flat;
            home.FlatAppearance.BorderSize = 0;
            home.FlatAppearance.MouseDownBackColor = Color.Transparent;
            home.FlatAppearance.MouseOverBackColor = Color.Transparent;


            thermometer.BackgroundImage = Image.FromFile("thermometer.png");
            thermometer.BackColor = Color.Transparent;
            thermometer.FlatStyle = FlatStyle.Flat;
            thermometer.FlatAppearance.BorderSize = 0;
            thermometer.FlatAppearance.MouseDownBackColor = Color.Transparent;
            thermometer.FlatAppearance.MouseOverBackColor = Color.Transparent;

            elder.BackgroundImage = Image.FromFile("elderly.png");
            elder.BackColor = Color.Transparent;
            elder.FlatStyle = FlatStyle.Flat;
            elder.FlatAppearance.BorderSize = 0;
            elder.FlatAppearance.MouseDownBackColor = Color.Transparent;
            elder.FlatAppearance.MouseOverBackColor = Color.Transparent;


            food.BackgroundImage = Image.FromFile("food.png");
            food.BackColor = Color.Transparent;
            food.FlatStyle = FlatStyle.Flat;
            food.FlatAppearance.BorderSize = 0;
            food.FlatAppearance.MouseDownBackColor = Color.Transparent;
            food.FlatAppearance.MouseOverBackColor = Color.Transparent;

            manual.BackgroundImage = Image.FromFile("manual.png");
            manual.BackColor = Color.Transparent;
            manual.FlatStyle = FlatStyle.Flat;
            manual.FlatAppearance.BorderSize = 0;
            manual.FlatAppearance.MouseDownBackColor = Color.Transparent;
            manual.FlatAppearance.MouseOverBackColor = Color.Transparent;

        }

        private void manual_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;
            startInfo.FileName = "manual.pdf";
            process.Start();
        }

        private void food_Click(object sender, EventArgs e)
        {
            ApallaktikiVirvou.FoodMenu food = new ApallaktikiVirvou.FoodMenu();
            food.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
            food.Show();
        }

        private void elder_Click(object sender, EventArgs e)
        {
            WindowsFormsAppGerontia.Gerodia gerontia = new WindowsFormsAppGerontia.Gerodia();
            gerontia.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
            gerontia.Show();
        }

        private void thermometer_Click(object sender, EventArgs e)
        {
            WindowsFormsAppThermotmetro.Thermometer thermometer = new WindowsFormsAppThermotmetro.Thermometer();
            thermometer.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
            thermometer.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            WindowsFormsAppSmartHome.SmartMenu smartMenu = new WindowsFormsAppSmartHome.SmartMenu();
            smartMenu.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
            smartMenu.Show();
        }

        private void planner_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.SmartPlanner planner = new WindowsFormsApp1.SmartPlanner();
            planner.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
            planner.Show();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
                this.Show();
        }
    }
}
