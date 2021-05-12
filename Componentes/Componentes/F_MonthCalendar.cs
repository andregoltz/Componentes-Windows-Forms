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
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void Pegardata()
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void btn_pegardata_Click(object sender, EventArgs e)
        {
            Pegardata();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Pegardata();
        }
    }
}
