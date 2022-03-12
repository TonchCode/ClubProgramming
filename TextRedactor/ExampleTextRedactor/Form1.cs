using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW10
{
    public partial class Form1 : Form
    {
        bool saved;
        bool newFile;
        bool justLoaded;
        string filePath;
        public Form1()
        {
            InitializeComponent();
            saved = true;
            newFile = true;
            justLoaded = false;
            filePath = string.Empty;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!justLoaded)
            {
                saved = false;
            }
            justLoaded = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                if (MessageBox.Show("You will lose your changes. Are you sure you want to close?", "Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file to Load";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                filePath = openFileDialog.FileName;
                TextBox.Text = File.ReadAllText(filePath);
                saved = true;
                newFile = false;
                justLoaded = true;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newFile)
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                File.WriteAllText(filePath, TextBox.Text);
                saved = true;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save as:";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                string path = saveFileDialog.FileName;
                File.WriteAllText(path, TextBox.Text);
                saved = true;
                newFile = false;
            }
        }
    }
}
