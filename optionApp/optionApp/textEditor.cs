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

namespace optionApp
{
    public partial class textEditor : Form
    {
        string Archivo;
        public textEditor()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBody.Clear();
            Archivo = null;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Texto|*.txt";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Archivo = OpenFile.FileName;
                using (StreamReader A = new StreamReader(Archivo))
                {
                    txtBody.Text = A.ReadToEnd();
                }

            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Texto|*.txt";
            if (Archivo != null)
            {
                using (StreamWriter G = new StreamWriter(Archivo))
                {
                    G.Write(txtBody.Text);
                }
            }
            else
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    Archivo = SaveFile.FileName;
                    using (StreamWriter g = new StreamWriter(SaveFile.FileName))
                    {
                        g.Write(txtBody.Text);

                    }
                }


            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void estMenu_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
               txtBody.ForeColor = color.Color;
            }
        }

        private void forMenu_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();

            if (fuente.ShowDialog() == DialogResult.OK)
            {
               txtBody.Font = fuente.Font;
            }
        }
    }
}
