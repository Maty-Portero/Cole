using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = trackBar2.Value.ToString();

            int r = trackBar2.Value;
            int g = trackBar1.Value;
            int b = trackBar3.Value;

            Color color = new Color();
            color = Color.FromArgb(r, g, b);
            panel1.BackColor = color;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = trackBar1.Value.ToString();

            int r = trackBar2.Value;
            int g = trackBar1.Value;
            int b = trackBar3.Value;

            Color color = new Color();
            color = Color.FromArgb(r, g, b);
            panel1.BackColor = color;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();

            int r = trackBar2.Value;
            int g = trackBar1.Value;
            int b = trackBar3.Value;

            Color color = new Color();
            color = Color.FromArgb(r, g, b);
            panel1.BackColor = color;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && trackBar2.Value < 256)
            {
                trackBar2.Value = int.Parse(textBox1.Text);
            }
            else if (trackBar2.Value > 255)
            {
                trackBar2.Value = 255;
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && trackBar1.Value < 256)
            {
                trackBar1.Value = int.Parse(textBox2.Text);
            }
            else if (trackBar1.Value > 255)
            {
                trackBar1.Value = 255;
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && trackBar3.Value < 256)
            {
                trackBar3.Value = int.Parse(textBox3.Text);
            }
            else if (trackBar3.Value > 255)
            {
                trackBar3.Value = 255;
            }
        }
    }
}
