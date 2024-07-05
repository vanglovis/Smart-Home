using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SmartPlanner : Form
    {
        public SmartPlanner()
        {
            InitializeComponent();
        }
        int program = 0;
        String[] timeStart=new string[3];
        String[] timeEnd=new String[3];
        String[] WayOfTansport = new String[3];
        Random random = new Random();
        Boolean temp1, temp2;
        int skipp = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!(comboBox1.Text == ""))
            {
                var fixedDate = new DateTime(2022, 05, 01, 05, 00, 00);
                var fixedDate1 = new DateTime(2022, 05, 01, 21, 00, 00);
                if (!(dateTimePicker1.Value.TimeOfDay < fixedDate.TimeOfDay || dateTimePicker2.Value.TimeOfDay > fixedDate1.TimeOfDay))
                {
                    if ((dateTimePicker1.Value > dateTimePicker2.Value))
                        MessageBox.Show("Starting time cannot be earlier than ending time!", "Lets try that again.");
                    else
                    {
                        if (program == 0) { Worki(); }
                        else if (program == 1) { SuperMarketi(); }
                        else if (program == 2) { Workouti(); }
                    }
                }
                else
                {
                    if (label2.Text == "Work")
                        Worki();
                    else
                        MessageBox.Show("You cannot go out before 5 or after 9 \nonly for work", "Lets try that again.");
                }
            }
            else
            {
                MessageBox.Show("Please choose a way of transport", "No selection was made");
            }
        }
        void StateOfProgram()
        {
            if (program == 1)
                label2.Text = "Super Marker";
            if (program == 2)
                label2.Text = "Workout";
            if (program == 3)
            {
                if (skipp != 3)
                {
                    PlanPrint form2 = new PlanPrint(timeStart, timeEnd, WayOfTansport);
                    form2.FormClosed += new FormClosedEventHandler(form2_FormClosed);
                    this.Hide();
                    form2.Show();
                }
                else
                {
                    skipp = 0;
                    MessageBox.Show("there is no need to create a programm then", "You skipped everything!");
                    program = 0;
                }
            }
        }
        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        
        void Worki()
        {
            temp1 = true;
            if (comboBox1.Text == "Bus"|| comboBox1.Text == "Subway")
            {
                if (random.Next(100) < 20)
                {
                    MessageBox.Show("This route is a little busy at that time maybe select another way of transport \nIf it is needed you can select the same way of transport", "Watch out");
                    temp1 = false;
                }
            }
            if (temp1)
            {
                if(dateTimePicker1.Value.TimeOfDay.Minutes.ToString().Length == 1)
                    timeStart[program] = dateTimePicker1.Value.TimeOfDay.Hours.ToString() + ":" + "0" + dateTimePicker1.Value.TimeOfDay.Minutes.ToString();
                else
                    timeStart[program] = dateTimePicker1.Value.TimeOfDay.Hours.ToString() + ":" + dateTimePicker1.Value.TimeOfDay.Minutes.ToString();
                if (dateTimePicker2.Value.TimeOfDay.Minutes.ToString().Length == 1)
                    timeEnd[program] = dateTimePicker2.Value.TimeOfDay.Hours.ToString() + ":" + "0" + dateTimePicker2.Value.TimeOfDay.Minutes.ToString();
                else
                    timeEnd[program] = dateTimePicker2.Value.TimeOfDay.Hours.ToString() + ":" + dateTimePicker2.Value.TimeOfDay.Minutes.ToString();
                WayOfTansport[program] = comboBox1.Text;
                program++;
                StateOfProgram();
            }
        }
        void SuperMarketi()
        {
            
            temp2 = true;
            if (comboBox1.Text == "Bus" || comboBox1.Text == "Subway")
            {
                if (random.Next(100) < 20)
                {
                    MessageBox.Show("This route is a little busy at that time maybe select another way of transport \nIf it is needed you can select the same way of transport", "Watch out");
                    temp2 = false;
                }
            }
            if (temp2)
            {
                if(dateTimePicker1.Value.TimeOfDay.Minutes.ToString().Length==1)
                    timeStart[program] = dateTimePicker1.Value.TimeOfDay.Hours.ToString() + ":"+"0" + dateTimePicker1.Value.TimeOfDay.Minutes.ToString();
                else
                    timeStart[program] = dateTimePicker1.Value.TimeOfDay.Hours.ToString() + ":" + dateTimePicker1.Value.TimeOfDay.Minutes.ToString();
                if (dateTimePicker2.Value.TimeOfDay.Minutes.ToString().Length == 1)
                    timeEnd[program] = dateTimePicker2.Value.TimeOfDay.Hours.ToString() + ":" +"0"+ dateTimePicker2.Value.TimeOfDay.Minutes.ToString();
                else
                    timeEnd[program] = dateTimePicker2.Value.TimeOfDay.Hours.ToString() + ":" + dateTimePicker2.Value.TimeOfDay.Minutes.ToString();
                WayOfTansport[program] = comboBox1.Text;
                program++;
                StateOfProgram();
            }
        }

        void Workouti()
        {
            if (comboBox1.Text != "Walk")
            {
                MessageBox.Show("You are working out you shouldn't be using anything but your body!", "What do you think you are doing!");
            }
            else
            {
                if (dateTimePicker1.Value.TimeOfDay.Minutes.ToString().Length == 1)
                    timeStart[program] = dateTimePicker1.Value.TimeOfDay.Hours.ToString() + ":" + "0" + dateTimePicker1.Value.TimeOfDay.Minutes.ToString();
                else
                    timeStart[program] = dateTimePicker1.Value.TimeOfDay.Hours.ToString() + ":" + dateTimePicker1.Value.TimeOfDay.Minutes.ToString();
                if (dateTimePicker2.Value.TimeOfDay.Minutes.ToString().Length == 1)
                    timeEnd[program] = dateTimePicker2.Value.TimeOfDay.Hours.ToString() + ":" + "0" + dateTimePicker2.Value.TimeOfDay.Minutes.ToString();
                else
                    timeEnd[program] = dateTimePicker2.Value.TimeOfDay.Hours.ToString() + ":" + dateTimePicker2.Value.TimeOfDay.Minutes.ToString();
                WayOfTansport[program] = comboBox1.Text;
                program++;
                StateOfProgram();
            }
        }

        private void SmartPlanner_Load(object sender, EventArgs e)
        {
            back.Image = Image.FromFile("back.png");
            help.Image = Image.FromFile("help.png");
            this.BackgroundImage = Image.FromFile("stay_home.png");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create a suitable program for your needs\n" +
                "Choose time and way of transport and click next or skip\n" +
                "if you dont want that task","Help");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skipp++;
            timeStart[program] = null;
            timeEnd[program] = null;
            WayOfTansport[program] = null;
            program++;
            StateOfProgram();

        }
    }
}
