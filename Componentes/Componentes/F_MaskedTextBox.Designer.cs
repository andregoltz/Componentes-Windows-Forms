
namespace Componentes
{
    partial class F_MaskedTextBox
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
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.l_senha = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_somentetexto = new System.Windows.Forms.CheckBox();
            this.tb_mostrarsenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(3, 28);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(178, 20);
            this.mtb_senha.TabIndex = 0;
            // 
            // l_senha
            // 
            this.l_senha.AutoSize = true;
            this.l_senha.Location = new System.Drawing.Point(3, 9);
            this.l_senha.Name = "l_senha";
            this.l_senha.Size = new System.Drawing.Size(38, 13);
            this.l_senha.TabIndex = 1;
            this.l_senha.Text = "Senha";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(3, 83);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(178, 20);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_somentetexto
            // 
            this.cb_somentetexto.AutoSize = true;
            this.cb_somentetexto.Location = new System.Drawing.Point(187, 84);
            this.cb_somentetexto.Name = "cb_somentetexto";
            this.cb_somentetexto.Size = new System.Drawing.Size(94, 17);
            this.cb_somentetexto.TabIndex = 4;
            this.cb_somentetexto.Text = "Somente texto";
            this.cb_somentetexto.UseVisualStyleBackColor = true;
            // 
            // tb_mostrarsenha
            // 
            this.tb_mostrarsenha.AutoSize = true;
            this.tb_mostrarsenha.Location = new System.Drawing.Point(188, 30);
            this.tb_mostrarsenha.Name = "tb_mostrarsenha";
            this.tb_mostrarsenha.Size = new System.Drawing.Size(93, 17);
            this.tb_mostrarsenha.TabIndex = 5;
            this.tb_mostrarsenha.Text = "Mostrar senha";
            this.tb_mostrarsenha.UseVisualStyleBackColor = true;
            this.tb_mostrarsenha.CheckedChanged += new System.EventHandler(this.tb_mostrarsenha_CheckedChanged);
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 451);
            this.Controls.Add(this.tb_mostrarsenha);
            this.Controls.Add(this.cb_somentetexto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.l_senha);
            this.Controls.Add(this.mtb_senha);
            this.Name = "F_MaskedTextBox";
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Label l_senha;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_somentetexto;
        private System.Windows.Forms.CheckBox tb_mostrarsenha;
    }
}