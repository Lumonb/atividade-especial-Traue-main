namespace CaixaBanco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btSacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSaque
            // 
            this.txtSaque.Location = new System.Drawing.Point(324, 47);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(100, 20);
            this.txtSaque.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe o valor do saque:";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(142, 119);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(16, 13);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "...";
            this.lbResultado.Visible = false;
            // 
            // btSacar
            // 
            this.btSacar.Location = new System.Drawing.Point(339, 216);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(75, 23);
            this.btSacar.TabIndex = 3;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.btSacar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btSacar;
    }
}

