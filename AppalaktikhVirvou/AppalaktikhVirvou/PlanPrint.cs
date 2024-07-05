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
    public partial class PlanPrint : Form
    {
        String[] timeStart = new string[3];
        String[] timeEnd = new String[3];
        String[] WayOfTansport = new String[3];
        int labelsandpic=0;
        Label[] labelarr;
        PictureBox[] picarr;
        int[] drastiriotites = new int[] {0 , 1 ,2 };
        public PlanPrint(String[] timsta, String[] timend, String[] trans)
        {
            InitializeComponent();
            timeStart = timsta;
            timeEnd = timend;
            WayOfTansport = trans;
        }
        int skipparismeno=1111,skiparimesno1=111111;
        private void Form2_Load(object sender, EventArgs e)
        {
            help.Image = Image.FromFile("help.png");
            for (int i = 0; i < 3; i++) {
                if (WayOfTansport[i] != null)
                    labelsandpic++;
                else
                {
                    if (skipparismeno != 1111)
                        skiparimesno1 = i;
                    else
                        skipparismeno = i;
                }
            }
            LabelandPic();
        }
        void LabelandPic()
        {
            var numbersList = drastiriotites.ToList();
            if (skipparismeno!=1111)
                numbersList.Remove(skipparismeno);
            if (skiparimesno1 != 111111)
                numbersList.Remove(skiparimesno1);
            labelarr = new Label[3];
            for (int i = 0; i < 3; i++)
            {
                labelarr[i] = new Label();
                labelarr[i].Location = new Point(i * 225+130, 46);
                labelarr[i].Anchor = AnchorStyles.Top;
                labelarr[i].Name = "label" + i;
                labelarr[i].AutoSize = true;
            }
            for(int i=0; i<labelsandpic;i++)
                this.Controls.Add(labelarr[i]);
            if (numbersList.Contains(0))
                labelarr[0].Text = "Work from "+timeStart[0]+" until "+timeEnd[0];
            else if (numbersList.Contains(1))
                labelarr[0].Text = "Super Market " + timeStart[1] + " until " + timeEnd[1];
            else if (numbersList.Contains(2))
                labelarr[0].Text = "Workout " + timeStart[2] + " until " + timeEnd[2];

            if (numbersList.Contains(1))
                labelarr[1].Text = "Super Market " + timeStart[1] + " until " + timeEnd[1];
            else if (numbersList.Contains(2))
                labelarr[1].Text = "Workout " + timeStart[2] + " until " + timeEnd[2];

            if (numbersList.Contains(2))
                labelarr[2].Text = "Workout " + timeStart[2] + " until " + timeEnd[2];


            picarr = new PictureBox[3];
            for (int i = 0; i < 3; i++)
            {
                picarr[i] = new PictureBox();
                picarr[i].Location = new Point(i * 225 + 130, 78);
                picarr[i].Anchor = AnchorStyles.Top;
                picarr[i].Size = new Size(200, 150);
                picarr[i].Name = "picture" + i;     
                picarr[i].Click += new EventHandler(clicked);
                picarr[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picarr[i].BackColor = Color.Black;
            }
            for (int i = 0; i < labelsandpic; i++)
                this.Controls.Add(picarr[i]);
            if (numbersList.Contains(0))
            {
                numbersList.Remove(0);
                if (WayOfTansport[0] == "Car")
                    picarr[0].Image = Image.FromFile("work_car.png");
                else if (WayOfTansport[0] == "Bus")
                    picarr[0].Image = Image.FromFile("work_LEWF.png");
                else if (WayOfTansport[0] == "Subway")
                    picarr[0].Image = Image.FromFile("work_METRO.png");
                else if (WayOfTansport[0] == "Walk")
                    picarr[0].Image = Image.FromFile("work_walk.png");
            }
            else if (numbersList.Contains(1))
            {
                numbersList.Remove(1);
                if (WayOfTansport[1] == "Car")
                    picarr[0].Image = Image.FromFile("sm_amaxi.png");
                else if (WayOfTansport[1] == "Bus")
                    picarr[0].Image = Image.FromFile("sm_lewf.png");
                else if (WayOfTansport[1] == "Subway")
                    picarr[0].Image = Image.FromFile("sm_subway.png");
                else if (WayOfTansport[1] == "Walk")
                    picarr[0].Image = Image.FromFile("sm_podia.png");
            }
            else if (numbersList.Contains(2))
            {
                numbersList.Remove(2);
                picarr[0].Image = Image.FromFile("workout_footieonly.png");
            }






            if (numbersList.Contains(1))
            {
                numbersList.Remove(1);
                if (WayOfTansport[1] == "Car")
                    picarr[1].Image = Image.FromFile("sm_amaxi.png");
                else if (WayOfTansport[1] == "Bus")
                    picarr[1].Image = Image.FromFile("sm_lewf.png");
                else if (WayOfTansport[1] == "Subway")
                    picarr[1].Image = Image.FromFile("sm_subway.png");
                else if (WayOfTansport[1] == "Walk")
                    picarr[1].Image = Image.FromFile("sm_podia.png");
            }
            else if (numbersList.Contains(2))
            {
                numbersList.Remove(2);
                picarr[1].Image = Image.FromFile("workout_footieonly.png");
            }

            





            if (numbersList.Contains(2))
                picarr[2].Image = Image.FromFile("workout_footieonly.png");

        }
        int clickone = 0;
        int x=0, y=0;

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on a map to enlarge it and click again to bring it to default size","Help");
        }

        private void clicked(object sender, EventArgs e)
        {            
            if (sender is PictureBox && clickone == 0)
            {
                
                x = ((PictureBox)sender).Location.X;
                y = ((PictureBox)sender).Location.Y;
                ((PictureBox)sender).Location = new Point(5,5);
                ((PictureBox)sender).Size = new Size(this.Width-10,this.Height-10);
                ((PictureBox)sender).BringToFront();
                clickone++;
                foreach (Control lbl in Controls)
                {
                    if ((lbl) is Label)
                        lbl.Hide();
                }

            }
            else {
                
                ((PictureBox)sender).Size = new Size(200, 150);
                ((PictureBox)sender).Location = new Point(x, y);
                ((PictureBox)sender).SendToBack();
                clickone = 0;
                foreach (Control lbl in Controls)
                {
                    if ((lbl) is Label)
                        lbl.Show();
                }
            }
        }
    }
}
