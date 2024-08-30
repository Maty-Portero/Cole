using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Winrar ZIP|*.zip";
            d = openFileDialog1.ShowDialog(this);

            if (d == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Width = this.Width - 45;
            richTextBox1.Height = this.Height - 120;
        }
    }
}
