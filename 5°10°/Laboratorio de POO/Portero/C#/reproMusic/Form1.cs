using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reproMusic
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);
        string nombreMusica;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {                  
            if (button2.Text == "| |") 
            {
                button2.Text = "▶";  
                mciSendString("pause MediaFile", null, 0, IntPtr.Zero);
            }
            else
            {
                button2.Text = "| |";
                mciSendString("close MediaFile", null, 0, IntPtr.Zero);
                mciSendString("open \"" + "C:\\Users\\A-19\\Downloads\\" + nombreMusica + ".mp3" + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            button2.Text = "| |";
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            mciSendString("open \"" + "C:\\Users\\A-19\\Downloads\\" + nombreMusica + ".mp3" + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int musicaSeleccionada = listBox1.SelectedIndex + 1;
            nombreMusica = listBox1.Items[musicaSeleccionada].ToString();
            textBox1.Text = listBox1.Items[musicaSeleccionada].ToString();

            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
            mciSendString("open \"" + "C:\\Users\\A-19\\Downloads\\" + nombreMusica + ".mp3" + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int musicaSeleccionada = listBox1.SelectedIndex;
            nombreMusica = listBox1.Items[musicaSeleccionada].ToString();
            textBox1.Text = listBox1.Items[musicaSeleccionada].ToString();
            if(listBox1.SelectedIndex == null)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse MP3 Files";
            openFileDialog1.FileName = "0";
            openFileDialog1.Filter = "MP3 |*.mp3";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
                listBox1.Items.Add(openFileDialog1.FileName);
            }
        }
    }
}
