﻿using System;
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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = treeView1.SelectedNode.Text;
            if(treeView1.SelectedNode.Tag != null)
            {
                textBox2.Text = treeView1.SelectedNode.Tag.ToString();
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TreeNode raizEstados = treeView1.Nodes.Add("Estados");
            raizEstados.Name = "raizEstados";

            TreeNode raizCores = treeView1.Nodes.Add("Cores");
            raizCores.Name = "raizCores";

            TreeNode estado1 = raizEstados.Nodes.Add("Minas Gerais");
            estado1.Name = "MG";
            TreeNode estado2 = raizEstados.Nodes.Add("Rio de Janeiro");
            estado2.Name = "RJ";
            TreeNode estado3 = raizEstados.Nodes.Add("São Paulo");
            estado3.Name = "SP";

            TreeNode cores1 = raizCores.Nodes.Add("Azul");
            cores1.Name = "azul";
            TreeNode cores2 = raizCores.Nodes.Add("Amarelo");
            cores2.Name = "amarelo";
            TreeNode cores3 = raizCores.Nodes.Add("Verde");
            cores3.Name = "verde";

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.Nodes["raizEstados"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao remover nó." + ex.ToString());            }
        }

        private void btn_removerselecionado_Click(object sender, EventArgs e)
        {

            try
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover nó." );
            }
        }
        
    }
}
