using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace tp2_Base_de_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"E:\Ferchabbita\Escritorio\ejemplo.txt");
            string linea;
            linea = leer.ReadLine();
            while (linea != null)
            {
                richTextBox1.AppendText(linea+"\n");
                linea = leer.ReadLine();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"E:\Ferchabbita\Escritorio\ejemplo.txt");
            escribir.WriteLine(textBox1.Text);
            escribir.Close();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = "";
        }

       

        }
    }

