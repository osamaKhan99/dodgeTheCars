using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace Racing_game1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random Rnd = new Random();
        
            
        }
        int speed;
        int score = 0;
        PictureBox[] road = new PictureBox[6];
        
        

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            speed = 3;
            road[0] = pictureBox1;
            road[1] = pictureBox2;
            road[2] = pictureBox3;
            road[3] = pictureBox4;
            road[4] = pictureBox5;
            road[5] = pictureBox6;
        }

        private void RoadMover_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 5; i++)
            {
                road[i].Top += speed;
                if (road[i].Top > Height)
                    road[i].Top = -road[i].Height;
            }
            if (score > 10 && score < 20) speed = 4;
            else if (score > 20 && score < 30) speed = 5;
            else if (score > 30) speed = 6;
            speed_text.Text = "Speed " + speed;
            if (Car.Bounds.IntersectsWith(EnemyCar1.Bounds))
            {
                newgame.Visible = true;
                End_text.Visible = true;
                RoadMover.Stop();
                enemy1timer.Stop();
                enemy2timer.Stop();
                enemy3timer.Stop();
            }
            else if (Car.Bounds.IntersectsWith(EnmeyCar2.Bounds))
            {
                newgame.Visible = true;
                End_text.Visible = true;
                RoadMover.Stop();
                enemy1timer.Stop();
                enemy2timer.Stop();
                enemy3timer.Stop();
            }
            else if (Car.Bounds.IntersectsWith(EnemyCar3.Bounds))
            {
                newgame.Visible = true;
                End_text.Visible = true;
                RoadMover.Stop();
                enemy1timer.Stop();
                enemy2timer.Stop();
                enemy3timer.Stop();
            }
        }
     
        
    

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                Right_Mover.Start();
            else if (e.KeyCode == Keys.Left)
                Left_Mover.Start();
        }

        private void Left_Mover_Tick(object sender, EventArgs e)
        {
            if (Car.Location.X>0)
            Car.Left -= 5;
        }

        private void Right_Mover_Tick(object sender, EventArgs e)
        {
            if (Car.Location.X<320)
            Car.Left += 5;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Right_Mover.Stop();
            Left_Mover.Stop();
        }

        private void enemy1timer_Tick(object sender, EventArgs e)
        {
            Random Rnd = new Random();
        //    int Rndnum = Rnd.Next(40, 170);
            EnemyCar1.Top +=speed-2;
            if (EnemyCar1.Top >= Height)
            {
                score += 1;
                Score_text.Text = "Score " + score;
                EnemyCar1.Left = Rnd.Next(2, 40);
                EnemyCar1.Top = Rnd.Next(0, 200);
                EnemyCar1.Top = -EnemyCar1.Height;

                          }
            }

        private void enemy2timer_Tick(object sender, EventArgs e)
        {
            Random R = new Random();
            
            EnmeyCar2.Top +=speed+2;
            if (EnmeyCar2.Top >= Height)
            {
                score += 1;
                Score_text.Text = "Score " + score;
                EnmeyCar2.Top = R.Next(0, 200);
                EnmeyCar2.Left = R.Next(90, 180);
                EnmeyCar2.Top = -EnmeyCar2.Height;
            }
        }

      //  private int Rnd()
     //   {
     //       throw new NotImplementedException();
     //   }

        private void enemy3timer_Tick(object sender, EventArgs e)
        {
            Random R2 = new Random();
        //    int Rndnum = R2.Next(30, 130);
            EnemyCar3.Top += speed-2;
            if (EnemyCar3.Top >= Height)
            {
                score += 1;
                Score_text.Text = "Score " + score;
                EnemyCar3.Top = R2.Next(0, 200);
                EnemyCar3.Left = R2.Next(250, 325);
                EnemyCar3.Top = -EnemyCar3.Height;
            }

        }

        private void EnmeyCar2_Click(object sender, EventArgs e)
        {

        }

        private void newgame_Click(object sender, EventArgs e)
        {
            score = 0;
            Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void End_text_Click(object sender, EventArgs e)
        {

        }
    }
}
