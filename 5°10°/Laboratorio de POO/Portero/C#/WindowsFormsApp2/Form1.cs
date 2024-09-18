using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void canciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Una canción");
        }

        private void canciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < 5; i++)
            {
                listBox1.Items.Add("Una canción");
            }
        }

        private void hidroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void DESFILARMISPENASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void lAPRIMERAVEZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void tRAPDEVERDADToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gold;
        }

        private void cUANDOFUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Goldenrod;
        }

        private void rELOJESREVENTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void qUIERENMÁSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void tODALAVIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
        }

        private void mÁSGRANDEESTEAÑOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] selectedItems = new object[listBox2.SelectedItems.Count];
            listBox2.SelectedItems.CopyTo(selectedItems, 0);

            listBox1.Items.AddRange(selectedItems);
            for (int i = 0; i < selectedItems.Length; i++)
            {
                listBox2.Items.Remove(selectedItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object[] selectedItems = new object[listBox1.SelectedItems.Count];
            listBox1.SelectedItems.CopyTo(selectedItems, 0);

            listBox2.Items.AddRange(selectedItems);
            for (int i = 0; i < selectedItems.Length; i++)
            {
                listBox1.Items.Remove(selectedItems[i]);
            }
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

            int r = trackBar1.Value;
            int g = trackBar2.Value;
            int b = trackBar3.Value;

            color = Color.FromArgb(r, g, b);
            this.BackColor = color;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            Color color = new Color();

            int r = trackBar1.Value;
            int g = trackBar2.Value;
            int b = trackBar3.Value;

            color = Color.FromArgb(r, g, b);
            this.BackColor = color;
        }
    }
}
