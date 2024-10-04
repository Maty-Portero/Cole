using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    public partial class Form1 : Form
    {
        object[] items;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.Items.Count - 1; i > -1; i--)
            {
                listBox2.Items.Add(listBox1.Items[i]);
                listBox1.Items.Remove(listBox1.Items[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.Items.Count - 1; i > -1; i--)
            {
                if (Convert.ToInt32(listBox2.Items[i]) > 10000)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                    listBox2.Items.Remove(listBox2.Items[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add(1235);
            listBox2.Items.Add(5);
            timer1.Enabled = false;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex % 2 == 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void agregarUnElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(2);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(27);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Color color = new Color();

            int r = trackBar1.Value;
            int g = trackBar2.Value;
            int b = trackBar3.Value;

            color = Color.FromArgb(r, g, b);
            this.BackColor = color;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            Color color = new Color();

            color = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.BackColor = color;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            Color color = new Color();

            color = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            this.BackColor = color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 100; i < 111; i++)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            items = new object[listBox2.SelectedItems.Count];
            listBox1.SelectedItems.CopyTo(items, 0);

            listBox1.
        }
    }
}