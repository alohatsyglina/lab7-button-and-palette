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
            colorChange();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label_RedMaxValue_Click(object sender, EventArgs e)
        {

        }

        public void colorChange()
        {
            canvas.BackColor = Color.FromArgb(redBar.Value, greenBar.Value, blueBar.Value);
            curRed.Text = Convert.ToString(redBar.Value);
            curGreen.Text = Convert.ToString(greenBar.Value);
            curBlue.Text = Convert.ToString(blueBar.Value);

            string colortag = "#" + redBar.Value.ToString("X") + greenBar.Value.ToString("X") +blueBar.Value.ToString("X");
            Clipboard.Clear();
            Clipboard.SetText(colortag);
        }

        private void RedBar_Scroll(object sender, EventArgs e)
        {
            colorChange();
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            colorChange();
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            colorChange();
        }

        private void Canvas_MouseHover(object sener, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(canvas, Clipboard.GetText());
        }
    }
}
