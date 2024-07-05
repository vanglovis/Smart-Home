namespace AppalaktikhVirvou
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.planner = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.thermometer = new System.Windows.Forms.Button();
            this.elder = new System.Windows.Forms.Button();
            this.food = new System.Windows.Forms.Button();
            this.manual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // planner
            // 
            this.planner.BackColor = System.Drawing.Color.Transparent;
            this.planner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.planner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.planner.Location = new System.Drawing.Point(62, 30);
            this.planner.Name = "planner";
            this.planner.Size = new System.Drawing.Size(127, 40);
            this.planner.TabIndex = 2;
            this.planner.UseVisualStyleBackColor = false;
            this.planner.Click += new System.EventHandler(this.planner_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Location = new System.Drawing.Point(62, 151);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(127, 40);
            this.home.TabIndex = 3;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // thermometer
            // 
            this.thermometer.BackColor = System.Drawing.Color.Transparent;
            this.thermometer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thermometer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thermometer.Location = new System.Drawing.Point(62, 269);
            this.thermometer.Name = "thermometer";
            this.thermometer.Size = new System.Drawing.Size(127, 40);
            this.thermometer.TabIndex = 4;
            this.thermometer.UseVisualStyleBackColor = false;
            this.thermometer.Click += new System.EventHandler(this.thermometer_Click);
            // 
            // elder
            // 
            this.elder.BackColor = System.Drawing.Color.Transparent;
            this.elder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elder.Location = new System.Drawing.Point(267, 30);
            this.elder.Name = "elder";
            this.elder.Size = new System.Drawing.Size(127, 40);
            this.elder.TabIndex = 5;
            this.elder.UseVisualStyleBackColor = false;
            this.elder.Click += new System.EventHandler(this.elder_Click);
            // 
            // food
            // 
            this.food.BackColor = System.Drawing.Color.Transparent;
            this.food.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.food.Cursor = System.Windows.Forms.Cursors.Hand;
            this.food.Location = new System.Drawing.Point(267, 151);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(127, 40);
            this.food.TabIndex = 6;
            this.food.UseVisualStyleBackColor = false;
            this.food.Click += new System.EventHandler(this.food_Click);
            // 
            // manual
            // 
            this.manual.BackColor = System.Drawing.Color.Transparent;
            this.manual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manual.Location = new System.Drawing.Point(267, 269);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(127, 40);
            this.manual.TabIndex = 7;
            this.manual.UseVisualStyleBackColor = false;
            this.manual.Click += new System.EventHandler(this.manual_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(497, 376);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.food);
            this.Controls.Add(this.elder);
            this.Controls.Add(this.thermometer);
            this.Controls.Add(this.home);
            this.Controls.Add(this.planner);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button planner;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button thermometer;
        private System.Windows.Forms.Button elder;
        private System.Windows.Forms.Button food;
        private System.Windows.Forms.Button manual;
    }
}

