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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("muy bien amigo, aprobaste", "Aprobacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("no podes reprobar, en serio deseas rendirte?", "Rendicion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            e.Cancel = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("como vas a reporbar, alto fraca, volve a intentarlo", "Reprobacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}