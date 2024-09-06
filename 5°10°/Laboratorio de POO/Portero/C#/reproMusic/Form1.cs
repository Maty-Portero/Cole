using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
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
        int ruta = 0;
        public const int MAX_PATH = 260;
        StringBuilder sbBuffer = new StringBuilder(MAX_PATH);
        List<string> rutas = new List<string>();


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
                mciSendString($"open \"{rutas[ruta].ToString()}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);
                mciSendString("status MediaFile length", sbBuffer, MAX_PATH, IntPtr.Zero);
                trackBar1.Maximum = Convert.ToInt32(sbBuffer.ToString()) / 1000;
                timer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "| |";
            if (ruta + 1 < listBox1.Items.Count)
            {
                ruta--;
                mciSendString("close MediaFile", null, 0, IntPtr.Zero);
                mciSendString($"open \"{rutas[ruta].ToString()}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);
                mciSendString("set MediaFile time format miliseconds", null, 0, IntPtr.Zero);
                mciSendString("status MediaFile length", sbBuffer, MAX_PATH, IntPtr.Zero);
                trackBar1.Maximum = Convert.ToInt32(sbBuffer.ToString()) / 1000;
                timer1.Start();
                listBox1.SelectedIndex = ruta;
            }
            else
            {
                MessageBox.Show("No hay mas canciones");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ruta > 0)
            {
                ruta++;
                mciSendString("close MediaFile", null, 0, IntPtr.Zero);
                mciSendString($"open \"{rutas[ruta].ToString()}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);
                mciSendString("set MediaFile time format miliseconds", null, 0, IntPtr.Zero);
                mciSendString("status MediaFile length", sbBuffer, MAX_PATH, IntPtr.Zero);
                trackBar1.Maximum = Convert.ToInt32(sbBuffer.ToString()) / 1000;
                timer1.Start();
                listBox1.SelectedIndex = ruta;
            }
            else
            {
                MessageBox.Show("No hay mas canciones");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int musicaSeleccionada = listBox1.SelectedIndex;
            nombreMusica = listBox1.Items[musicaSeleccionada].ToString();
            textBox1.Text = listBox1.Items[musicaSeleccionada].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Browse MP3 Files";
            openFileDialog1.FileName = "0";
            openFileDialog1.Filter = "MP3 |*.mp3";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {   
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName));
                rutas.Add(openFileDialog1.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mciSendString("status MediaFIle position", sbBuffer, MAX_PATH, IntPtr.Zero);
            trackBar1.Value = Convert.ToInt32(sbBuffer.ToString()) / 1000;

            if (trackBar1.Value == trackBar1.Maximum)
            {
                ruta++;
                mciSendString("close MediaFile", null, 0, IntPtr.Zero);
                mciSendString($"open \"{rutas[ruta].ToString()}\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);
                mciSendString("set MediaFile time format miliseconds", null, 0, IntPtr.Zero);
                mciSendString("status MediaFile length", sbBuffer, MAX_PATH, IntPtr.Zero);
                trackBar1.Maximum = Convert.ToInt32(sbBuffer.ToString()) / 1000;
                listBox1.SelectedIndex = ruta;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mciSendString("seek MediaFile to " + (trackBar1.Value * 1000).ToString(), null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }
    }
}
