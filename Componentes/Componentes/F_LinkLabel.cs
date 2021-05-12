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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiploslinks.Links.Add(0,6,"www.google.com.br");
            ll_multiploslinks.Links.Add(9, 5, "www.youtube.com.br/cfbcursos");
            ll_multiploslinks.Links.Add(17, 7, "www.youtube.com");

            ll_multiploslinks.Links[2].Enabled = false;
        }

        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://Youtube.com/cfbcursos");
            LinkLabel ll = (LinkLabel)sender;
            ll_canal.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_multiploslinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
