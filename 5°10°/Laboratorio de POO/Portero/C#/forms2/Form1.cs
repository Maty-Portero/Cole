using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox2.Items.Add(textBox2.Text);
                textBox2.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {/*
            if (listBox1.SelectedItems.Count <= 2)
            {
                listBox2.Items.Add(listBox1.SelectedItems);
                listBox1.Items.Remove(listBox1.SelectedItems);
            }
         */
        }
    }
}
