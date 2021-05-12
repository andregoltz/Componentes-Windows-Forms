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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_somentetexto.Checked)
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                
            }
            else
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = maskedTextBox1.Text;
            MessageBox.Show(msg);
        }

        private void tb_mostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (tb_mostrarsenha.Checked)
            {
                mtb_senha.PasswordChar = default;
            }
            else
            {
                mtb_senha.PasswordChar = '*';
            }
        }
    }
}
