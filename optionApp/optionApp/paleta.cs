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
    public partial class paleta : Form
    {
        public paleta()
        {
            InitializeComponent();
            cbColors.Items.Clear();
            string[] colors = Enum.GetNames(typeof(System.Drawing.KnownColor));
            cbColors.Items.AddRange(colors);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
           
        }

        private void cbColors_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string text = cbColors.Items[e.Index].ToString();
                Color color = Color.FromName(text);
                Brush onCube = new SolidBrush(color);
                Pen cube = new Pen(e.ForeColor);

                e.Graphics.DrawRectangle(cube, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 50, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(onCube, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 48, e.Bounds.Height - 6));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(cbColors.Text);
        }
    }
}
