
namespace Componentes
{
    partial class F_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_obterdata = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_setarData = new System.Windows.Forms.Button();
            this.btn_voltarparahoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 12);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(232, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_obterdata
            // 
            this.btn_obterdata.Location = new System.Drawing.Point(250, 12);
            this.btn_obterdata.Name = "btn_obterdata";
            this.btn_obterdata.Size = new System.Drawing.Size(276, 23);
            this.btn_obterdata.TabIndex = 1;
            this.btn_obterdata.Text = "Obter Data";
            this.btn_obterdata.UseVisualStyleBackColor = true;
            this.btn_obterdata.Click += new System.EventHandler(this.btn_obterdata_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 64);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(232, 20);
            this.tb_data.TabIndex = 2;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(12, 112);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(72, 20);
            this.tb_dia.TabIndex = 3;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(90, 112);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(71, 20);
            this.tb_mes.TabIndex = 4;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(167, 112);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(77, 20);
            this.tb_ano.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mês";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Completa";
            // 
            // btn_setarData
            // 
            this.btn_setarData.Location = new System.Drawing.Point(250, 112);
            this.btn_setarData.Name = "btn_setarData";
            this.btn_setarData.Size = new System.Drawing.Size(276, 24);
            this.btn_setarData.TabIndex = 16;
            this.btn_setarData.Text = "Alterar Data";
            this.btn_setarData.UseVisualStyleBackColor = true;
            this.btn_setarData.Click += new System.EventHandler(this.btn_setarData_Click);
            // 
            // btn_voltarparahoje
            // 
            this.btn_voltarparahoje.Location = new System.Drawing.Point(250, 61);
            this.btn_voltarparahoje.Name = "btn_voltarparahoje";
            this.btn_voltarparahoje.Size = new System.Drawing.Size(276, 25);
            this.btn_voltarparahoje.TabIndex = 17;
            this.btn_voltarparahoje.Text = "Voltar para HOJE";
            this.btn_voltarparahoje.UseVisualStyleBackColor = true;
            this.btn_voltarparahoje.Click += new System.EventHandler(this.btn_voltarparahoje_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 464);
            this.Controls.Add(this.btn_voltarparahoje);
            this.Controls.Add(this.btn_setarData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_obterdata);
            this.Controls.Add(this.dtp_data);
            this.Name = "F_DateTimePicker";
            this.Text = "F_DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_obterdata;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_setarData;
        private System.Windows.Forms.Button btn_voltarparahoje;
    }
}