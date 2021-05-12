
namespace Componentes
{
    partial class F_LinkLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.ll_canal = new System.Windows.Forms.LinkLabel();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_multiploslinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(16, 30);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(214, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // ll_canal
            // 
            this.ll_canal.AutoSize = true;
            this.ll_canal.Location = new System.Drawing.Point(16, 72);
            this.ll_canal.Name = "ll_canal";
            this.ll_canal.Size = new System.Drawing.Size(34, 13);
            this.ll_canal.TabIndex = 2;
            this.ll_canal.TabStop = true;
            this.ll_canal.Text = "Canal";
            this.ll_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_canal_LinkClicked);
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(74, 72);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(63, 13);
            this.ll_calculadora.TabIndex = 3;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_multiploslinks
            // 
            this.ll_multiploslinks.AutoSize = true;
            this.ll_multiploslinks.Location = new System.Drawing.Point(13, 129);
            this.ll_multiploslinks.Name = "ll_multiploslinks";
            this.ll_multiploslinks.Size = new System.Drawing.Size(126, 13);
            this.ll_multiploslinks.TabIndex = 4;
            this.ll_multiploslinks.TabStop = true;
            this.ll_multiploslinks.Text = "Google - Canal - Youtube";
            this.ll_multiploslinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multiploslinks_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 446);
            this.Controls.Add(this.ll_multiploslinks);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.ll_canal);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Name = "F_LinkLabel";
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.LinkLabel ll_canal;
        private System.Windows.Forms.LinkLabel ll_calculadora;
        private System.Windows.Forms.LinkLabel ll_multiploslinks;
    }
}