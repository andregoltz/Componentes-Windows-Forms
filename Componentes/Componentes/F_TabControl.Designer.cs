
namespace Componentes
{
    partial class F_TabControl
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_Componentes = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_novapagina = new System.Windows.Forms.TextBox();
            this.btn_novatab = new System.Windows.Forms.Button();
            this.btn_removertabatual = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_posicionartab = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tab_Componentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab_Componentes);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Location = new System.Drawing.Point(12, 66);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(776, 372);
            this.tab.TabIndex = 0;
            // 
            // tab_Componentes
            // 
            this.tab_Componentes.Controls.Add(this.splitContainer2);
            this.tab_Componentes.Controls.Add(this.label2);
            this.tab_Componentes.Controls.Add(this.textBox2);
            this.tab_Componentes.Location = new System.Drawing.Point(4, 22);
            this.tab_Componentes.Name = "tab_Componentes";
            this.tab_Componentes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Componentes.Size = new System.Drawing.Size(768, 346);
            this.tab_Componentes.TabIndex = 0;
            this.tab_Componentes.Text = "Componentes";
            this.tab_Componentes.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(406, 172);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(150, 100);
            this.splitContainer2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_novapagina
            // 
            this.tb_novapagina.Location = new System.Drawing.Point(16, 13);
            this.tb_novapagina.Name = "tb_novapagina";
            this.tb_novapagina.Size = new System.Drawing.Size(100, 20);
            this.tb_novapagina.TabIndex = 1;
            // 
            // btn_novatab
            // 
            this.btn_novatab.Location = new System.Drawing.Point(123, 9);
            this.btn_novatab.Name = "btn_novatab";
            this.btn_novatab.Size = new System.Drawing.Size(111, 23);
            this.btn_novatab.TabIndex = 2;
            this.btn_novatab.Text = "Nova Tab";
            this.btn_novatab.UseVisualStyleBackColor = true;
            this.btn_novatab.Click += new System.EventHandler(this.btn_novatab_Click);
            // 
            // btn_removertabatual
            // 
            this.btn_removertabatual.Location = new System.Drawing.Point(240, 9);
            this.btn_removertabatual.Name = "btn_removertabatual";
            this.btn_removertabatual.Size = new System.Drawing.Size(111, 23);
            this.btn_removertabatual.TabIndex = 3;
            this.btn_removertabatual.Text = "Remover Tab Atual";
            this.btn_removertabatual.UseVisualStyleBackColor = true;
            this.btn_removertabatual.Click += new System.EventHandler(this.btn_removertabatual_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_posicionartab
            // 
            this.btn_posicionartab.Location = new System.Drawing.Point(123, 37);
            this.btn_posicionartab.Name = "btn_posicionartab";
            this.btn_posicionartab.Size = new System.Drawing.Size(111, 23);
            this.btn_posicionartab.TabIndex = 5;
            this.btn_posicionartab.Text = "Posicionar na Tab";
            this.btn_posicionartab.UseVisualStyleBackColor = true;
            this.btn_posicionartab.Click += new System.EventHandler(this.btn_posicionartab_Click);
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_posicionartab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_removertabatual);
            this.Controls.Add(this.btn_novatab);
            this.Controls.Add(this.tb_novapagina);
            this.Controls.Add(this.tab);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            this.Load += new System.EventHandler(this.F_TabControl_Load);
            this.tab.ResumeLayout(false);
            this.tab_Componentes.ResumeLayout(false);
            this.tab_Componentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab_Componentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_novapagina;
        private System.Windows.Forms.Button btn_novatab;
        private System.Windows.Forms.Button btn_removertabatual;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_posicionartab;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}