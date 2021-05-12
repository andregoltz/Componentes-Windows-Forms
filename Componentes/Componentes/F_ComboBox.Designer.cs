
namespace Componentes
{
    partial class F_ComboBox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarselecionado = new System.Windows.Forms.Button();
            this.btn_limparelementos = new System.Windows.Forms.Button();
            this.btn_resetarelementos = new System.Windows.Forms.Button();
            this.tb_transporte = new System.Windows.Forms.TextBox();
            this.btn_addnovotransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(176, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarselecionado
            // 
            this.btn_mostrarselecionado.Location = new System.Drawing.Point(194, 9);
            this.btn_mostrarselecionado.Name = "btn_mostrarselecionado";
            this.btn_mostrarselecionado.Size = new System.Drawing.Size(196, 24);
            this.btn_mostrarselecionado.TabIndex = 1;
            this.btn_mostrarselecionado.Text = "Mostrar Selecionado";
            this.btn_mostrarselecionado.UseVisualStyleBackColor = true;
            this.btn_mostrarselecionado.Click += new System.EventHandler(this.btn_mostrarselecionado_Click);
            // 
            // btn_limparelementos
            // 
            this.btn_limparelementos.Location = new System.Drawing.Point(194, 40);
            this.btn_limparelementos.Name = "btn_limparelementos";
            this.btn_limparelementos.Size = new System.Drawing.Size(196, 22);
            this.btn_limparelementos.TabIndex = 2;
            this.btn_limparelementos.Text = "Limpar Elementos";
            this.btn_limparelementos.UseVisualStyleBackColor = true;
            this.btn_limparelementos.Click += new System.EventHandler(this.btn_limparelementos_Click);
            // 
            // btn_resetarelementos
            // 
            this.btn_resetarelementos.Location = new System.Drawing.Point(194, 69);
            this.btn_resetarelementos.Name = "btn_resetarelementos";
            this.btn_resetarelementos.Size = new System.Drawing.Size(196, 22);
            this.btn_resetarelementos.TabIndex = 3;
            this.btn_resetarelementos.Text = "Resetar Elementos";
            this.btn_resetarelementos.UseVisualStyleBackColor = true;
            this.btn_resetarelementos.Click += new System.EventHandler(this.btn_resetarelementos_Click);
            // 
            // tb_transporte
            // 
            this.tb_transporte.Location = new System.Drawing.Point(194, 122);
            this.tb_transporte.Name = "tb_transporte";
            this.tb_transporte.Size = new System.Drawing.Size(196, 20);
            this.tb_transporte.TabIndex = 4;
            // 
            // btn_addnovotransporte
            // 
            this.btn_addnovotransporte.Location = new System.Drawing.Point(194, 148);
            this.btn_addnovotransporte.Name = "btn_addnovotransporte";
            this.btn_addnovotransporte.Size = new System.Drawing.Size(196, 27);
            this.btn_addnovotransporte.TabIndex = 5;
            this.btn_addnovotransporte.Text = "Add Novo Transporte";
            this.btn_addnovotransporte.UseVisualStyleBackColor = true;
            this.btn_addnovotransporte.Click += new System.EventHandler(this.btn_addnovotransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 465);
            this.Controls.Add(this.btn_addnovotransporte);
            this.Controls.Add(this.tb_transporte);
            this.Controls.Add(this.btn_resetarelementos);
            this.Controls.Add(this.btn_limparelementos);
            this.Controls.Add(this.btn_mostrarselecionado);
            this.Controls.Add(this.cb_transportes);
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrarselecionado;
        private System.Windows.Forms.Button btn_limparelementos;
        private System.Windows.Forms.Button btn_resetarelementos;
        private System.Windows.Forms.TextBox tb_transporte;
        private System.Windows.Forms.Button btn_addnovotransporte;
    }
}