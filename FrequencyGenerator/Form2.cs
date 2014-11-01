using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrequencyGenerator
{
    public partial class Form2 : Form
    {
        public static string picturePath;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //TODO - fix this
            pictureBox1.ImageLocation = @"C:\Users\Thomas\Downloads\tmpD99E.bmp";
            pictureBox1.Load();
            //Console.WriteLine("picturePath: " + picturePath);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveas
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //copy to clipboard
            //System.Windows.Forms.Clipboard.SetText(debugTB2.Text);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add stuff here", "Help");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PC interface for the Frequency Generator made by Group 4", "Frequency Generator");
        }
    }
}
