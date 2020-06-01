using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stupid_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать кнопку!");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 
            if (e.X > button1.Left - 10 && e.X < button1.Left + button1.Width + 10)
            {
                if (e.X >= (button1.Left + (button1.Width / 2)))
                {
                    button1.Left -= 10;
                    button1.Top -= 10;
                }
                else
                {
                    button1.Left += 10;
                    button1.Top += 10;
                }
            }
            if (e.Y >= button1.Top - 10 && e.Y <= button1.Top + button1.Height + 10)
            {
                if (e.Y >= (button1.Top + (button1.Height / 2)))
                    button1.Top -= 10;
                else
                    button1.Top += 10;
            }

            if (button1.Left <= 0) button1.Left = this.ClientSize.Width - button1.Width - 20;
            else if (button1.Left + button1.Width >= this.ClientSize.Width) button1.Left = 20;


            if (button1.Top < 0)
                button1.Top = this.ClientSize.Height;

            if ((button1.Top + button1.Height) > this.ClientSize.Height)
                button1.Top = this.ClientSize.Height - button1.Height;
        }
        private void Form1_Load(object sender, EventArgs e)
            {

            }
        }
    }
