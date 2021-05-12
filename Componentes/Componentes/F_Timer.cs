using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    
    public partial class F_Timer : Form
    {
        int num = 0;
        int px, py;
        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            px = pictureBox1.Location.X;
            py = pictureBox1.Location.Y;
        }

        private void btn_iniciart1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_parart1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void btn_iniciarfoto_Click(object sender, EventArgs e)
        {
            timer_foto.Start();
        }

        private void btn_pararfoto_Click(object sender, EventArgs e)
        {
            timer_foto.Stop();
        }

        private void timer_foto_Tick(object sender, EventArgs e)
        {
            px+=2;
            if (px >= 688)
            {
                px = 12;
            }

            pictureBox1.Location = new Point(px, py);
            px = pictureBox1.Location.X;
        }
    }
}
