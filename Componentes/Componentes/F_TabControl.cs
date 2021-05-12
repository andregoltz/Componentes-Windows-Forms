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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void btn_novatab_Click(object sender, EventArgs e)
        {
            if(tb_novapagina.Text != "")
            {
                TabPage pagina = new TabPage();
                pagina.Text = tb_novapagina.Text;
                pagina.Name = tb_novapagina.Text;
                tab.TabPages.Add(pagina);
                tb_novapagina.Clear();
                DefinirMaximo();
            }
            else
            {
                MessageBox.Show("Digite o nome da nova Tab");
                tb_novapagina.Focus();
            }
        }

        private void btn_removertabatual_Click(object sender, EventArgs e)
        {
            tab.TabPages.Remove(tab.SelectedTab);
            DefinirMaximo();
        }

        private void btn_posicionartab_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < tab.TabPages.Count)
            {
                tab.SelectedIndex = Int32.Parse( numericUpDown1.Value.ToString());
            }
        }
        private void DefinirMaximo()
        {
            numericUpDown1.Maximum = tab.TabPages.Count-1;
 
        }

        private void F_TabControl_Load(object sender, EventArgs e)
        {
            DefinirMaximo();
        }
    }
}
