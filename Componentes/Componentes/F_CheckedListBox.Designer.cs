
namespace Componentes
{
    partial class F_CheckedListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarselecionados = new System.Windows.Forms.Button();
            this.btn_limparlista = new System.Windows.Forms.Button();
            this.btn_resetarlista = new System.Windows.Forms.Button();
            this.btn_AddNovoTransporte = new System.Windows.Forms.Button();
            this.tb_NovoTransporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(12, 12);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(120, 229);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_mostrarselecionados
            // 
            this.btn_mostrarselecionados.Location = new System.Drawing.Point(138, 12);
            this.btn_mostrarselecionados.Name = "btn_mostrarselecionados";
            this.btn_mostrarselecionados.Size = new System.Drawing.Size(270, 24);
            this.btn_mostrarselecionados.TabIndex = 1;
            this.btn_mostrarselecionados.Text = "Mostrar Selecionados";
            this.btn_mostrarselecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarselecionados.Click += new System.EventHandler(this.btn_mostrarselecionados_Click);
            // 
            // btn_limparlista
            // 
            this.btn_limparlista.Location = new System.Drawing.Point(139, 42);
            this.btn_limparlista.Name = "btn_limparlista";
            this.btn_limparlista.Size = new System.Drawing.Size(269, 24);
            this.btn_limparlista.TabIndex = 2;
            this.btn_limparlista.Text = "Limpar Lista";
            this.btn_limparlista.UseVisualStyleBackColor = true;
            this.btn_limparlista.Click += new System.EventHandler(this.btn_limparlista_Click);
            // 
            // btn_resetarlista
            // 
            this.btn_resetarlista.Location = new System.Drawing.Point(139, 72);
            this.btn_resetarlista.Name = "btn_resetarlista";
            this.btn_resetarlista.Size = new System.Drawing.Size(270, 23);
            this.btn_resetarlista.TabIndex = 3;
            this.btn_resetarlista.Text = "Resetar Lista";
            this.btn_resetarlista.UseVisualStyleBackColor = true;
            this.btn_resetarlista.Click += new System.EventHandler(this.btn_resetarlista_Click);
            // 
            // btn_AddNovoTransporte
            // 
            this.btn_AddNovoTransporte.Location = new System.Drawing.Point(139, 222);
            this.btn_AddNovoTransporte.Name = "btn_AddNovoTransporte";
            this.btn_AddNovoTransporte.Size = new System.Drawing.Size(270, 21);
            this.btn_AddNovoTransporte.TabIndex = 4;
            this.btn_AddNovoTransporte.Text = "]";
            this.btn_AddNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_AddNovoTransporte.Click += new System.EventHandler(this.btn_AddNovoTransporte_Click);
            // 
            // tb_NovoTransporte
            // 
            this.tb_NovoTransporte.Location = new System.Drawing.Point(139, 196);
            this.tb_NovoTransporte.Name = "tb_NovoTransporte";
            this.tb_NovoTransporte.Size = new System.Drawing.Size(269, 20);
            this.tb_NovoTransporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_NovoTransporte);
            this.Controls.Add(this.btn_AddNovoTransporte);
            this.Controls.Add(this.btn_resetarlista);
            this.Controls.Add(this.btn_limparlista);
            this.Controls.Add(this.btn_mostrarselecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.Click += new System.EventHandler(this.F_CheckedListBox_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostrarselecionados;
        private System.Windows.Forms.Button btn_limparlista;
        private System.Windows.Forms.Button btn_resetarlista;
        private System.Windows.Forms.Button btn_AddNovoTransporte;
        private System.Windows.Forms.TextBox tb_NovoTransporte;
        private System.Windows.Forms.Label label1;
    }
}