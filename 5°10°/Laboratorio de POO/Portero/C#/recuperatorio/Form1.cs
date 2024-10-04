using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int contColores = 0;
        int contRojo = 0;
        int contAmarillo = 0;
        int contVerde = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (contColores == 0)
            {
                this.BackColor = Color.Lime;
                timer1.Interval = 10000;
                contColores++;
            }   
            else if (this.BackColor == Color.Lime)
            {
                contColores = 1;
                this.BackColor = Color.Yellow;
                timer1.Interval = 1000;
                contColores++;
            }
            else if (contColores == 2)
            {
                this.BackColor = Color.Red;
                timer1.Interval = 10000;
                contColores++;
            }
            else if (contColores == 3)
            {
                this.BackColor = Color.Yellow;
                timer1.Interval = 1000;
                contColores++;
            }
            else if (contColores == 4)
            {
                this.BackColor = Color.Lime;
                timer1.Interval = 10000;
                contColores++;
            }



            //timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                contRojo++;
                label1.Text = "Pasan " + contRojo + " autos en Rojo";
                label1.Visible = true;
            }
            else if (this.BackColor == Color.Yellow)
            {
                contAmarillo++;
                label2.Text = "Pasan " + contAmarillo + " autos en Amarillo";
                label2.Visible = true;
            }                
            else if (this.BackColor == Color.Lime)
            {
                contVerde++;
                label3.Text = "Pasan " + contVerde + " autos en Verde";
                label3.Visible = true;
            }                
        }
    }
}
