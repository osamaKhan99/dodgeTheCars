namespace Racing_game1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.RoadMover = new System.Windows.Forms.Timer(this.components);
            this.Car = new System.Windows.Forms.PictureBox();
            this.Left_Mover = new System.Windows.Forms.Timer(this.components);
            this.Right_Mover = new System.Windows.Forms.Timer(this.components);
            this.EnemyCar1 = new System.Windows.Forms.PictureBox();
            this.EnmeyCar2 = new System.Windows.Forms.PictureBox();
            this.EnemyCar3 = new System.Windows.Forms.PictureBox();
            this.enemy1timer = new System.Windows.Forms.Timer(this.components);
            this.enemy2timer = new System.Windows.Forms.Timer(this.components);
            this.enemy3timer = new System.Windows.Forms.Timer(this.components);
            this.End_text = new System.Windows.Forms.Label();
            this.Score_text = new System.Windows.Forms.Label();
            this.newgame = new System.Windows.Forms.Button();
            this.speed_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnmeyCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(84, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(250, -95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 148);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(84, -95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 148);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(250, 148);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 148);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(84, 435);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 148);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(250, 435);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 148);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // RoadMover
            // 
            this.RoadMover.Enabled = true;
            this.RoadMover.Interval = 10;
            this.RoadMover.Tick += new System.EventHandler(this.RoadMover_Tick);
            // 
            // Car
            // 
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(153, 390);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(60, 96);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 6;
            this.Car.TabStop = false;
            // 
            // Left_Mover
            // 
            this.Left_Mover.Interval = 10;
            this.Left_Mover.Tick += new System.EventHandler(this.Left_Mover_Tick);
            // 
            // Right_Mover
            // 
            this.Right_Mover.Interval = 10;
            this.Right_Mover.Tick += new System.EventHandler(this.Right_Mover_Tick);
            // 
            // EnemyCar1
            // 
            this.EnemyCar1.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar1.Image")));
            this.EnemyCar1.Location = new System.Drawing.Point(2, 192);
            this.EnemyCar1.Name = "EnemyCar1";
            this.EnemyCar1.Size = new System.Drawing.Size(65, 104);
            this.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar1.TabIndex = 7;
            this.EnemyCar1.TabStop = false;
            // 
            // EnmeyCar2
            // 
            this.EnmeyCar2.Image = ((System.Drawing.Image)(resources.GetObject("EnmeyCar2.Image")));
            this.EnmeyCar2.Location = new System.Drawing.Point(165, -19);
            this.EnmeyCar2.Name = "EnmeyCar2";
            this.EnmeyCar2.Size = new System.Drawing.Size(60, 96);
            this.EnmeyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnmeyCar2.TabIndex = 8;
            this.EnmeyCar2.TabStop = false;
            this.EnmeyCar2.Click += new System.EventHandler(this.EnmeyCar2_Click);
            // 
            // EnemyCar3
            // 
            this.EnemyCar3.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar3.Image")));
            this.EnemyCar3.Location = new System.Drawing.Point(300, 290);
            this.EnemyCar3.Name = "EnemyCar3";
            this.EnemyCar3.Size = new System.Drawing.Size(65, 104);
            this.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar3.TabIndex = 9;
            this.EnemyCar3.TabStop = false;
            // 
            // enemy1timer
            // 
            this.enemy1timer.Enabled = true;
            this.enemy1timer.Interval = 10;
            this.enemy1timer.Tick += new System.EventHandler(this.enemy1timer_Tick);
            // 
            // enemy2timer
            // 
            this.enemy2timer.Enabled = true;
            this.enemy2timer.Interval = 10;
            this.enemy2timer.Tick += new System.EventHandler(this.enemy2timer_Tick);
            // 
            // enemy3timer
            // 
            this.enemy3timer.Enabled = true;
            this.enemy3timer.Interval = 10;
            this.enemy3timer.Tick += new System.EventHandler(this.enemy3timer_Tick);
            // 
            // End_text
            // 
            this.End_text.AutoSize = true;
            this.End_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.End_text.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_text.ForeColor = System.Drawing.Color.White;
            this.End_text.Location = new System.Drawing.Point(87, 106);
            this.End_text.Name = "End_text";
            this.End_text.Size = new System.Drawing.Size(198, 39);
            this.End_text.TabIndex = 10;
            this.End_text.Text = "Game Over";
            this.End_text.Visible = false;
            this.End_text.Click += new System.EventHandler(this.End_text_Click);
            // 
            // Score_text
            // 
            this.Score_text.AutoSize = true;
            this.Score_text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Score_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_text.Location = new System.Drawing.Point(0, 0);
            this.Score_text.Name = "Score_text";
            this.Score_text.Size = new System.Drawing.Size(49, 16);
            this.Score_text.TabIndex = 11;
            this.Score_text.Text = "Score";
            // 
            // newgame
            // 
            this.newgame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newgame.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgame.ForeColor = System.Drawing.Color.White;
            this.newgame.Location = new System.Drawing.Point(94, 302);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(176, 36);
            this.newgame.TabIndex = 12;
            this.newgame.Text = "New Game";
            this.newgame.UseVisualStyleBackColor = false;
            this.newgame.Visible = false;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // speed_text
            // 
            this.speed_text.AutoSize = true;
            this.speed_text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.speed_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_text.Location = new System.Drawing.Point(310, 0);
            this.speed_text.Name = "speed_text";
            this.speed_text.Size = new System.Drawing.Size(54, 16);
            this.speed_text.TabIndex = 13;
            this.speed_text.Text = "Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(394, 574);
            this.Controls.Add(this.speed_text);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.Score_text);
            this.Controls.Add(this.End_text);
            this.Controls.Add(this.EnemyCar3);
            this.Controls.Add(this.EnmeyCar2);
            this.Controls.Add(this.EnemyCar1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dodge The Cars";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnmeyCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        protected System.Windows.Forms.Timer RoadMover;
        private System.Windows.Forms.PictureBox Car;
        protected System.Windows.Forms.Timer Left_Mover;
        protected System.Windows.Forms.Timer Right_Mover;
        private System.Windows.Forms.PictureBox EnemyCar1;
        private System.Windows.Forms.PictureBox EnmeyCar2;
        private System.Windows.Forms.PictureBox EnemyCar3;
        protected System.Windows.Forms.Timer enemy1timer;
        protected System.Windows.Forms.Timer enemy2timer;
        protected System.Windows.Forms.Timer enemy3timer;
        private System.Windows.Forms.Label End_text;
        private System.Windows.Forms.Label Score_text;
        private System.Windows.Forms.Button newgame;
        private System.Windows.Forms.Label speed_text;
    }
}

