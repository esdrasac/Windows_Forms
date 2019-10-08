namespace Atividade_Forms {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lblRaiz2 = new System.Windows.Forms.Label();
            this.lblRaiz1 = new System.Windows.Forms.Label();
            this.txtraiz1 = new System.Windows.Forms.TextBox();
            this.txtraiz2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(53, 59);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(15, 16);
            this.lbla.TabIndex = 0;
            this.lbla.Text = "A";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(96, 59);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(14, 16);
            this.lblb.TabIndex = 1;
            this.lblb.Text = "B";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(138, 59);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(17, 16);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "C";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(43, 87);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(36, 20);
            this.txtA.TabIndex = 3;
            this.txtA.Click += new System.EventHandler(this.TxtA_Click);
            this.txtA.TextChanged += new System.EventHandler(this.TxtA_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtA_KeyPress);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(127, 87);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(36, 20);
            this.txtC.TabIndex = 5;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtC_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(85, 87);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(36, 20);
            this.txtB.TabIndex = 4;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Delta";
            // 
            // txtDelta
            // 
            this.txtDelta.Location = new System.Drawing.Point(43, 157);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.ReadOnly = true;
            this.txtDelta.Size = new System.Drawing.Size(39, 20);
            this.txtDelta.TabIndex = 7;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btCalcular.FlatAppearance.BorderSize = 0;
            this.btCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btCalcular.Location = new System.Drawing.Point(269, 176);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(0);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(110, 45);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // lblRaiz2
            // 
            this.lblRaiz2.AutoSize = true;
            this.lblRaiz2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaiz2.Location = new System.Drawing.Point(172, 129);
            this.lblRaiz2.Name = "lblRaiz2";
            this.lblRaiz2.Size = new System.Drawing.Size(45, 17);
            this.lblRaiz2.TabIndex = 9;
            this.lblRaiz2.Text = "Raiz 2";
            // 
            // lblRaiz1
            // 
            this.lblRaiz1.AutoSize = true;
            this.lblRaiz1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaiz1.Location = new System.Drawing.Point(117, 128);
            this.lblRaiz1.Name = "lblRaiz1";
            this.lblRaiz1.Size = new System.Drawing.Size(45, 17);
            this.lblRaiz1.TabIndex = 10;
            this.lblRaiz1.Text = "Raiz 1";
            // 
            // txtraiz1
            // 
            this.txtraiz1.Location = new System.Drawing.Point(120, 157);
            this.txtraiz1.Name = "txtraiz1";
            this.txtraiz1.ReadOnly = true;
            this.txtraiz1.Size = new System.Drawing.Size(39, 20);
            this.txtraiz1.TabIndex = 11;
            // 
            // txtraiz2
            // 
            this.txtraiz2.Location = new System.Drawing.Point(175, 157);
            this.txtraiz2.Name = "txtraiz2";
            this.txtraiz2.ReadOnly = true;
            this.txtraiz2.Size = new System.Drawing.Size(39, 20);
            this.txtraiz2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 38);
            this.panel1.TabIndex = 13;
            // 
            // btSair
            // 
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.Location = new System.Drawing.Point(336, 0);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(55, 40);
            this.btSair.TabIndex = 15;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.Location = new System.Drawing.Point(266, 59);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(59, 13);
            this.lblmensagem.TabIndex = 14;
            this.lblmensagem.Text = "Mensagem";
            this.lblmensagem.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Equação do 2° Grau";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(391, 233);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtraiz2);
            this.Controls.Add(this.txtraiz1);
            this.Controls.Add(this.lblRaiz1);
            this.Controls.Add(this.lblRaiz2);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtDelta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lblRaiz2;
        private System.Windows.Forms.Label lblRaiz1;
        private System.Windows.Forms.TextBox txtraiz1;
        private System.Windows.Forms.TextBox txtraiz2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblmensagem;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label2;
    }
}

