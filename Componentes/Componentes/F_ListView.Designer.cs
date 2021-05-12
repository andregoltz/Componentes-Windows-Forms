
namespace Componentes
{
    partial class F_ListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00"}, -1);
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_qtde = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.l_ID = new System.Windows.Forms.Label();
            this.l_produto = new System.Windows.Forms.Label();
            this.l_quantidade = new System.Windows.Forms.Label();
            this.l_preco = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_produtos
            // 
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_produto,
            this.col_qtde,
            this.col_preco});
            this.lv_produtos.FullRowSelect = true;
            this.lv_produtos.HideSelection = false;
            this.lv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_produtos.Location = new System.Drawing.Point(12, 12);
            this.lv_produtos.MultiSelect = false;
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Size = new System.Drawing.Size(506, 131);
            this.lv_produtos.TabIndex = 0;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            this.lv_produtos.SelectedIndexChanged += new System.EventHandler(this.lv_produtos_SelectedIndexChanged);
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            this.col_ID.Width = 40;
            // 
            // col_produto
            // 
            this.col_produto.Text = "Produto";
            this.col_produto.Width = 250;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Quantidade";
            this.col_qtde.Width = 80;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.Width = 120;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(12, 175);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(40, 20);
            this.tb_ID.TabIndex = 1;
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(58, 175);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(241, 20);
            this.tb_produto.TabIndex = 2;
            // 
            // tb_qtde
            // 
            this.tb_qtde.Location = new System.Drawing.Point(306, 175);
            this.tb_qtde.Name = "tb_qtde";
            this.tb_qtde.Size = new System.Drawing.Size(75, 20);
            this.tb_qtde.TabIndex = 3;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(388, 174);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(111, 20);
            this.tb_preco.TabIndex = 4;
            // 
            // l_ID
            // 
            this.l_ID.AutoSize = true;
            this.l_ID.Location = new System.Drawing.Point(13, 156);
            this.l_ID.Name = "l_ID";
            this.l_ID.Size = new System.Drawing.Size(18, 13);
            this.l_ID.TabIndex = 5;
            this.l_ID.Text = "ID";
            // 
            // l_produto
            // 
            this.l_produto.AutoSize = true;
            this.l_produto.Location = new System.Drawing.Point(55, 156);
            this.l_produto.Name = "l_produto";
            this.l_produto.Size = new System.Drawing.Size(44, 13);
            this.l_produto.TabIndex = 6;
            this.l_produto.Text = "Produto";
            // 
            // l_quantidade
            // 
            this.l_quantidade.AutoSize = true;
            this.l_quantidade.Location = new System.Drawing.Point(303, 156);
            this.l_quantidade.Name = "l_quantidade";
            this.l_quantidade.Size = new System.Drawing.Size(62, 13);
            this.l_quantidade.TabIndex = 7;
            this.l_quantidade.Text = "Quantidade";
            // 
            // l_preco
            // 
            this.l_preco.AutoSize = true;
            this.l_preco.Location = new System.Drawing.Point(385, 156);
            this.l_preco.Name = "l_preco";
            this.l_preco.Size = new System.Drawing.Size(35, 13);
            this.l_preco.TabIndex = 8;
            this.l_preco.Text = "Preço";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(12, 213);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(146, 20);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(164, 213);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(173, 20);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(343, 213);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(156, 20);
            this.btn_obter.TabIndex = 11;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 278);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.l_preco);
            this.Controls.Add(this.l_quantidade);
            this.Controls.Add(this.l_produto);
            this.Controls.Add(this.l_ID);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_qtde);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lv_produtos);
            this.Name = "F_ListView";
            this.Text = "F_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_produtos;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.TextBox tb_qtde;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label l_ID;
        private System.Windows.Forms.Label l_produto;
        private System.Windows.Forms.Label l_quantidade;
        private System.Windows.Forms.Label l_preco;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
    }
}