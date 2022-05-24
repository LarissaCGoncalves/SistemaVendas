namespace ViewForm
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFornecedores = new System.Windows.Forms.Button();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(821, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao Sistema de Vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFornecedores);
            this.groupBox1.Controls.Add(this.buttonProdutos);
            this.groupBox1.Controls.Add(this.buttonClientes);
            this.groupBox1.Location = new System.Drawing.Point(21, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastros";
            // 
            // buttonFornecedores
            // 
            this.buttonFornecedores.Location = new System.Drawing.Point(25, 145);
            this.buttonFornecedores.Name = "buttonFornecedores";
            this.buttonFornecedores.Size = new System.Drawing.Size(108, 29);
            this.buttonFornecedores.TabIndex = 4;
            this.buttonFornecedores.Text = "Fornecedores";
            this.buttonFornecedores.UseVisualStyleBackColor = true;
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.Location = new System.Drawing.Point(25, 100);
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.Size = new System.Drawing.Size(108, 29);
            this.buttonProdutos.TabIndex = 3;
            this.buttonProdutos.Text = "Produtos";
            this.buttonProdutos.UseVisualStyleBackColor = true;
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(25, 54);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(108, 29);
            this.buttonClientes.TabIndex = 2;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFornecedores;
        private System.Windows.Forms.Button buttonProdutos;
        private System.Windows.Forms.Button buttonClientes;
    }
}
