
namespace Componentes
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_iniciart1 = new System.Windows.Forms.Button();
            this.btn_parart1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_iniciarfoto = new System.Windows.Forms.Button();
            this.timer_foto = new System.Windows.Forms.Timer(this.components);
            this.btn_pararfoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_iniciart1
            // 
            this.btn_iniciart1.Location = new System.Drawing.Point(13, 13);
            this.btn_iniciart1.Name = "btn_iniciart1";
            this.btn_iniciart1.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciart1.TabIndex = 0;
            this.btn_iniciart1.Text = "Iniciar";
            this.btn_iniciart1.UseVisualStyleBackColor = true;
            this.btn_iniciart1.Click += new System.EventHandler(this.btn_iniciart1_Click);
            // 
            // btn_parart1
            // 
            this.btn_parart1.Location = new System.Drawing.Point(94, 13);
            this.btn_parart1.Name = "btn_parart1";
            this.btn_parart1.Size = new System.Drawing.Size(75, 23);
            this.btn_parart1.TabIndex = 1;
            this.btn_parart1.Text = "Parar";
            this.btn_parart1.UseVisualStyleBackColor = true;
            this.btn_parart1.Click += new System.EventHandler(this.btn_parart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Location = new System.Drawing.Point(176, 12);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_reiniciar.TabIndex = 3;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Componentes.Properties.Resources.IMG_20161116_WA0007;
            this.pictureBox1.Location = new System.Drawing.Point(12, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_iniciarfoto
            // 
            this.btn_iniciarfoto.Location = new System.Drawing.Point(12, 85);
            this.btn_iniciarfoto.Name = "btn_iniciarfoto";
            this.btn_iniciarfoto.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciarfoto.TabIndex = 5;
            this.btn_iniciarfoto.Text = "Iniciar foto";
            this.btn_iniciarfoto.UseVisualStyleBackColor = true;
            this.btn_iniciarfoto.Click += new System.EventHandler(this.btn_iniciarfoto_Click);
            // 
            // timer_foto
            // 
            this.timer_foto.Interval = 1;
            this.timer_foto.Tick += new System.EventHandler(this.timer_foto_Tick);
            // 
            // btn_pararfoto
            // 
            this.btn_pararfoto.Location = new System.Drawing.Point(94, 85);
            this.btn_pararfoto.Name = "btn_pararfoto";
            this.btn_pararfoto.Size = new System.Drawing.Size(75, 23);
            this.btn_pararfoto.TabIndex = 6;
            this.btn_pararfoto.Text = "Parar foto";
            this.btn_pararfoto.UseVisualStyleBackColor = true;
            this.btn_pararfoto.Click += new System.EventHandler(this.btn_pararfoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ini12 - fim 688";
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pararfoto);
            this.Controls.Add(this.btn_iniciarfoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parart1);
            this.Controls.Add(this.btn_iniciart1);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_iniciart1;
        private System.Windows.Forms.Button btn_parart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_iniciarfoto;
        private System.Windows.Forms.Timer timer_foto;
        private System.Windows.Forms.Button btn_pararfoto;
        private System.Windows.Forms.Label label2;
    }
}