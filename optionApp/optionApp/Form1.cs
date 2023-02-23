using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ponerPanel(object panel)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);
            Form pn = panel as Form;
            pn.TopLevel = false;
            pn.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(pn);
            this.panelContainer.Tag = pn;
            pn.Show();
            
        }
        private void btnPaleta_Click(object sender, EventArgs e)
        {
            ponerPanel(new paleta());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ponerPanel(new textEditor());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
