using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BouncingBall
{
    public partial class Form1 : Form
    {
        Graphics g;
        int initional_pos_x, initional_pos_y,initioal_velocity;
        int x,y;
        int ang;
        int a;
        double speed,cof;
        Thread t;
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initi();
            label4.Text="Welcome To Bouncy Ball Fun App \n Click on Show button to display ball .Adjust the parameter(pos,velocity,ang) and through The ball\n click reset to try again";
        }
        public void initi()
        {
            initional_pos_x = 100;
            initional_pos_y = 100;
            initioal_velocity = 10;
            ang = 360 - 45;  
            a = 2; //it is an accelaration which is equal to gravity (supoosed to 2)
           // Mass = 1;  it is 1 and not affected  so not used in follwing code 
            speed = 10;
            cof = 0.8;   //coefficient of efficiency
            trackBar_x.Value = 100;
            labely.Text = initional_pos_y.ToString();
            trackBar_y.Value = 100;
            labelx.Text = initional_pos_x.ToString();
            labelv.Text = speed.ToString();
            velocity.Value = 10;
            trackBarang.Value = 45;
          
 
        }
        public void drawball(int x,int y, int ang,Brush b,Pen p)
        {
            g = frame.CreateGraphics();
            g.FillEllipse(b, x-10, y-10, 20, 20);
            Point p1 = new Point(x,y);
            double radian = ang * (Math.PI / 180);
            Point p2 = new Point(Convert.ToInt32(25* Math.Cos(radian)) + p1.X, Convert.ToInt32(25* Math.Sin(radian)) + p1.Y);
            g.DrawLine(p, p2, p1);
        }
        public void drawball(int x, int y,Brush b)
        {
           g = frame.CreateGraphics();
           g.FillEllipse(b, x - 10, y-10, 20, 20);
        }
       
        private void through_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                t = new Thread(run);
                t.Start();
                flag = false;
            }
        }
        private void show_Click(object sender, EventArgs e)
        {
            drawball(initional_pos_x, initional_pos_y, ang, Brushes.LimeGreen, Pens.Red);
        }
        public void run()
        {
            bool flag = true;
            g = frame.CreateGraphics();
            x = initional_pos_x;
            y = initional_pos_y;
            speed = initioal_velocity;
            double t=0;
            
            drawball(x, y, ang, Brushes.Black, Pens.Black);
            
            do
            {
                double radian = ang * (Math.PI / 180);
                drawball(x, y, Brushes.Black);
                
                int xspeed = Convert.ToInt32(Math.Cos(radian) * speed );
                int yspeed = Convert.ToInt32(Math.Sin(radian) * speed + (a * t));       //a acceleration a= g ,where g is gravity consider as 2 
             
                t++;
                x = x + xspeed;
                y = y + yspeed;
                
                if (y < 20 || y > 270)
                {

                    
                    if(y > 270)
                    {
                      
                       y = 270;
                    
                    }
                    else if (y < 20)
                    {
                        y = 20;
                    }
                   ang = Math.Abs(360 - ang);
                   speed = Math.Sqrt((xspeed * xspeed) + (yspeed*yspeed));
                   speed = (cof) * speed;
                   
                       t = 1;
                }
                else if (x < 20 || x > 510)
                {

                    if (x > 510)
                    {
                       x = 510;
                       
                    }
                    if (x < 20)
                    {
                        x = 20;

                    }

                    if (ang <= 180)
                    {
                        ang = Math.Abs(180 - ang);
                        speed = Math.Sqrt((xspeed * xspeed) + (yspeed * yspeed));
                        speed = (cof) * speed;
                        t = 1;
                        
                       
                    }
                    else
                    {
                        ang = Math.Abs(540-ang);
                        speed = Math.Sqrt((xspeed * xspeed) + (yspeed * yspeed));
                        speed = (cof) * speed;  // 0.5 coefficeient of restitution
                        t = 1;
                       
                    }
                 
                }
                else
                {  
                }
                if (y >= 270 && yspeed<=1)
                {
                    flag = false;
                    speed = 0;
                    t = 0;
                    
                }

                drawball(x, y, Brushes.LimeGreen);
                Thread.Sleep(50);  // consider 50 as 1 unit time
            }while(flag);
            
        }
        private void trackBar_x_Scroll(object sender, EventArgs e)
        {
            if (flag == true)
            {
                drawball(initional_pos_x, initional_pos_y, ang, Brushes.Black, Pens.Black);
                initional_pos_x = trackBar_x.Value;
                labelx.Text = initional_pos_x.ToString();
                drawball(initional_pos_x, initional_pos_y, ang, Brushes.LimeGreen, Pens.Red);
            }
            else
            {
                MessageBox.Show("click to reset");
            }
        }

        private void trackBar_y_Scroll(object sender, EventArgs e)
        {
            if (flag ==true)
            {
                drawball(initional_pos_x, initional_pos_y, ang, Brushes.Black, Pens.Black);
                initional_pos_y = trackBar_y.Value;
                labely.Text = initional_pos_y.ToString();
                drawball(initional_pos_x, initional_pos_y, ang, Brushes.LimeGreen, Pens.Red);
            }
            else
            {
                MessageBox.Show("click to reset");
            }
        }
        private void velocity_Scroll(object sender, EventArgs e)
        {
            if (flag == true)
            {
                initioal_velocity = velocity.Value;
                labelv.Text = initioal_velocity.ToString();
            }
            else
            {
                MessageBox.Show("click to reset");
            }
       }
        private void trackBarang_Scroll(object sender, EventArgs e)
        {
            if (flag == true)
            {
                drawball(initional_pos_x, initional_pos_y, ang, Brushes.Black, Pens.Black);
                ang = 360 - trackBarang.Value;
                labelang.Text = trackBarang.Value.ToString();
                drawball(initional_pos_x, initional_pos_y, ang, Brushes.LimeGreen, Pens.Red);
            }
            else
            {
                MessageBox.Show("click to reset");
            }
        }
        public void reset_val()
        {
            if (!flag)
            {
                t.Abort();
                flag = true;
                drawball(x, y, ang, Brushes.Black, Pens.Black);
                drawball(initional_pos_x, initional_pos_y, ang, Brushes.LimeGreen, Pens.Red);
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {

            reset_val();               
       }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            reset_val(); 
           
        }
    }
}
